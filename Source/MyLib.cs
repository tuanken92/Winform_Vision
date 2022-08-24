using MCProtocol;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Vision.Source
{

    public sealed class AsyncLock
    {
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);
        public async Task<IDisposable> LockAsync()
        {
            await _semaphore.WaitAsync();
            return new Handler(_semaphore);
        }

        private sealed class Handler : IDisposable
        {
            private readonly SemaphoreSlim _semaphore;
            private bool _disposed = false;

            public Handler(SemaphoreSlim semaphore)
            {
                _semaphore = semaphore;
            }

            public void Dispose()
            {
                if (!_disposed)
                {
                    _semaphore.Release();
                    _disposed = true;
                }
            }
        }
    }

    public class TaskLoop
    {

        #region Implementation of INotifyPropertyChanged

        //public event PropertyChangedEventHandler PropertyChanged;

        //private void OnPropertyChanged(string propertyName)
        //{
        //    if (this.PropertyChanged != null)
        //        this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //}

        #endregion

        private CancellationTokenSource _cancelSource;
        private readonly AsyncLock _lock = new AsyncLock();

        public CancellationTokenSource CancelSource { get => _cancelSource; set => _cancelSource = value; }

        public TaskLoop()
        {
            CancelSource = new CancellationTokenSource();
        }

        ~TaskLoop()
        {
            CancelSource?.Dispose();
        }


        public void ResetToken()
        {
            CancelSource?.Dispose();
            CancelSource = new CancellationTokenSource();
        }

        public void StopLoop()
        {
            CancelSource?.Cancel();
        }



        public async Task RunLoop(int interval, Action action)
        {
            if (action == null)
                return;

            using (await _lock.LockAsync())
            {
                while (!CancelSource.IsCancellationRequested)
                {
                    await Task.Run(() => action());
                    await Task.Delay(interval);
                }
            }
        }

    }

    public class MyLib
    {
        public static bool CreateFolder(string path_folder)
        {
            bool result = Directory.Exists(path_folder);
            if (!result)
            {
                Directory.CreateDirectory(path_folder);
                result = Directory.Exists(path_folder);
            }
            return result;
        }

        public static string GenerateNameImage()
        {
            CreateFolder(MyDefine.path_save_images);
            return String.Format("{0}\\{1}.jpg", MyDefine.path_save_images, DateTime.Now.ToString("yyyyMMdd_hhmmss"));
        }
        public static string GenerateNameImage(String path2save, bool isOK=false)
        {
            path2save += isOK ? "\\OK" : "\\NG";
            CreateFolder(path2save);
            return String.Format("{0}\\{1}.jpg", path2save, DateTime.Now.ToString("yyyyMMdd_hhmmss"));
        }

        public static async void ConnectToPlc(string ip, int port)
        {

            if (PLCData.PLC != null)
            {
                PLCData.PLC.Dispose();
                PLCData.PLC = null;
            }

            PLCData.PLC = new Mitsubishi.McProtocolTcp(ip, port, Mitsubishi.McFrame.MC3E);



            try
            {
                await PLCData.PLC.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public static bool DisconnectPLC()
        {
            if (PLCData.PLC == null)
                return false;

            if (PLCData.PLC.Connected)
            {
                int iClose = PLCData.PLC.Close();
                Console.WriteLine(iClose);
            }

            return !PLCData.PLC.Connected;
        }
    }


    
}
