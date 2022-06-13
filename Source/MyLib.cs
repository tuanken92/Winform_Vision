using Cognex.InSight;
using MCProtocol;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Vision.Source
{
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


        public static bool WriteTextResult(CvsStatusLevel result)
        {
            CreateFolder(MyDefine.path_save_texts);
            //String fileName = String.Format("{0}\\result_{1}.txt", MyDefine.path_save_texts, DateTime.Now.ToString("yyyyMMdd_hhmmss"));
            String fileName = String.Format("{0}\\result.txt", MyDefine.path_save_texts);
            String data_result = String.Format("Time: {0}\nResult: {1}", DateTime.Now.ToString("ddd MM/dd/yyyy hh:mm:ss tt"),result);
            bool bResult = true;
            
            try
            {
                if (!File.Exists(fileName))
                {
                    File.Create(fileName);
                    using (TextWriter tw = new StreamWriter(fileName))
                    {
                        tw.WriteLine(data_result);
                        tw.Close();
                    }
                    
                }
                else
                {
                    //overwrite
                    using (var tw = new StreamWriter(fileName, false))
                    {
                        tw.WriteLine(data_result);
                        //tw.Flush();
                        tw.Close();
                    }
                }
            }  
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                bResult = false;
            }


            

            return bResult;
        }
        
        public static bool WriteTextResult(string data_result)
        {
            CreateFolder(MyDefine.path_save_texts);
            //String fileName = String.Format("{0}\\result_{1}.txt", MyDefine.path_save_texts, DateTime.Now.ToString("yyyyMMdd_hhmmss"));
            String fileName = String.Format("{0}\\result.txt", MyDefine.path_save_texts);
            
            bool bResult = true;
            
            try
            {
                if (!File.Exists(fileName))
                {
                    File.Create(fileName);
                    using (TextWriter tw = new StreamWriter(fileName))
                    {
                        tw.WriteLine(data_result);
                        tw.Close();
                    }
                    
                }
                else
                {
                    //overwrite
                    using (var tw = new StreamWriter(fileName, false))
                    {
                        tw.WriteLine(data_result);
                        //tw.Flush();
                        tw.Close();
                    }
                }
            }  
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                bResult = false;
            }


            

            return bResult;
        }
    }


    
}
