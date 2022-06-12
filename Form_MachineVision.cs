using MCProtocol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_Vision.Source;




namespace Winform_Vision
{

    public partial class Vision : Form
    {
        ShowDateTime showDateTimeManager = null;
        ParameterManager parameter = null;
        System.Windows.Forms.Timer ReadDataTimer = null;
        public Vision()
        {
            InitializeComponent();
            InitVariables();
            InitGui();

        }

        ~Vision()
        {
            Console.WriteLine("Vision destroy.....");
        }


        void InitVariables()
        {
            
            showDateTimeManager = new ShowDateTime(timer_Datetime, label_DateTime);
            parameter = new ParameterManager();
            parameter = SaveLoadParameter.Load_Parameter(parameter, MyDefine.file_config) as ParameterManager;

            parameter.PrintInfo();


            //create folder
            try
            {
                MyLib.CreateFolder(parameter.common.PathText);
                MyLib.CreateFolder(parameter.common.PathImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void InitGUIParameter()
        {
            IPPLCTextbox.Text = parameter.plc.Ip;
            portPLCTextbox.Text = parameter.plc.Port.ToString();

            TriggerPLCTextbox.Text = parameter.plc.TriggerInput.ToString();
            ResultPLCTextbox.Text = parameter.plc.ResultOutput.ToString();
            PositionPLCTextbox.Text = parameter.plc.PosCheckInput.ToString();
            
            XPLCTextbox.Text = parameter.plc.AddX.ToString();
            YPLCTextbox.Text = parameter.plc.AddY.ToString();
            AnglePLCTextbox.Text = parameter.plc.AddAngle.ToString();


            IPCameraTextbox.Text = parameter.cam.Ip;
            UserCameraTextbox.Text = parameter.cam.UserName;
            PassCameraTextbox.Text = parameter.cam.PassWord;

            PathImageFileTextbox.Text = parameter.common.PathImage;
            PathTxtFileTextbox.Text = parameter.common.PathText;

            chkSaveImage.Checked = parameter.common.IsSaveImage;
            chkUseCam.Checked = parameter.common.IsUseCamera;
            chkUsePLC.Checked = parameter.common.IsUsePLC;
        }

        void UpdateGUIParameter()
        {
            parameter.plc.Ip = IPPLCTextbox.Text;
            parameter.plc.Port = int.Parse(portPLCTextbox.Text);

            parameter.plc.TriggerInput = int.Parse(TriggerPLCTextbox.Text);
            parameter.plc.ResultOutput = int.Parse(ResultPLCTextbox.Text);
            parameter.plc.PosCheckInput = int.Parse(PositionPLCTextbox.Text);
            
            parameter.plc.AddX = int.Parse(XPLCTextbox.Text);
            parameter.plc.AddY= int.Parse(YPLCTextbox.Text);
            parameter.plc.AddAngle= int.Parse(AnglePLCTextbox.Text);


            parameter.cam.Ip = IPCameraTextbox.Text;
            parameter.cam.UserName = UserCameraTextbox.Text;
            parameter.cam.PassWord = PassCameraTextbox.Text;

            parameter.common.PathImage = PathImageFileTextbox.Text;
            parameter.common.PathText = PathTxtFileTextbox.Text;

            parameter.common.IsSaveImage = chkSaveImage.Checked;
            parameter.common.IsUseCamera= chkUseCam.Checked;
            parameter.common.IsUsePLC = chkUsePLC.Checked;

            OKLabel.Text = parameter.common.NumOK.ToString();
            NGLabel.Text = parameter.common.NumNG.ToString();


        }


        void InitGui()
        {


            //Thread
            ReadDataTimer = new System.Windows.Forms.Timer();
            ReadDataTimer.Interval = 100;
            ReadDataTimer.Tick += ReadDataTimer_Tick;

            //Tab Camera
            #region tab_camera
            //Insight display
            CvsInSightDisplay2.LoadStandardTheme();
            CvsInSightDisplay2.ShowImage = true;
            CvsInSightDisplay2.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit;

            CvsInSightDisplay2.StatusInformationChanged += new System.EventHandler(this.CvsInSightDisplay2_StatusInformationChanged);
            CvsInSightDisplay2.ConnectedChanged += new System.EventHandler(this.CvsInSightDisplay2_ConnectedChanged);
            CvsInSightDisplay2.StateChanged += new Cognex.InSight.Controls.Display.CvsDisplayStateChangedEventHandler(this.CvsInSightDisplay2_StateChanged);
            CvsInSightDisplay2.ConnectCompleted += new Cognex.InSight.CvsConnectCompletedEventHandler(this.CvsInSightDisplay2_ConnectCompleted);


            //checkbox
            chkGrid.CheckedChanged += new System.EventHandler(this.chkGrid_CheckedChanged);
            chkGraphics.CheckedChanged += new System.EventHandler(this.chkGraphics_CheckedChanged);
            chkImage.CheckedChanged += new System.EventHandler(this.chkImage_CheckedChanged);
            chkOnline.CheckedChanged += new System.EventHandler(this.chkOnline_CheckedChanged);
            chkLive.CheckedChanged += new System.EventHandler(this.chkLive_CheckedChanged);
            chkSaveImage.CheckedChanged += ChkSaveImage_CheckedChanged;
            chkUseCam.CheckedChanged += ChkUseCam_CheckedChanged;
            chkUsePLC.CheckedChanged += ChkUsePLC_CheckedChanged;


            optFill.CheckedChanged += new System.EventHandler(this.optFill_CheckedChanged);
            optFit.CheckedChanged += new System.EventHandler(this.optFit_CheckedChanged);
            optNone.CheckedChanged += new System.EventHandler(this.optNone_CheckedChanged);


            //Scoll
            hScrollOpacity.Scroll += HScrollOpacity_ValueChanged;

            #endregion

            //TabSetting
            InitGUIParameter();

            //TabPLC


            #region tabAuto

            TriggerCamButton.Click += TriggerCamButton_Click;
            StartButton.Click += StartButton_Click;
            StopButton.Click += StopButton_Click;
            #endregion


#if AUTO_RESIZE
            _form_resize = new clsResize(this); //I put this after the initialize event to be sure that all controls are initialized properly
            this.Load += new EventHandler(_Load); //This will be called after the initialization // form_load
            this.Resize += new EventHandler(_Resize); //form_resize
#endif
        }

        private void ChkUsePLC_CheckedChanged(object sender, EventArgs e)
        {
            parameter.common.IsUsePLC = chkUsePLC.Checked;
        }

        private void ChkUseCam_CheckedChanged(object sender, EventArgs e)
        {
            parameter.common.IsUseCamera = chkUseCam.Checked;
        }

        private void ChkSaveImage_CheckedChanged(object sender, EventArgs e)
        {
            //parameter.common.IsSaveImage = chkSaveImage.Checked;
            String file2save = MyLib.GenerateNameImage();
            //CvsInSightDisplay2.SaveBitmap(file2save);
            CvsInSightDisplay2.Results.Image.Save(file2save);
            foreach(var x in CvsInSightDisplay2.Results.Images)
            {
                file2save = MyLib.GenerateNameImage();
                x.Save(file2save);
            }
            var status = CvsInSightDisplay2.InSight.Results.StatusLevel;
            Console.WriteLine(status);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopPrg();
            StopButton.Enabled = false;
            StartButton.Enabled = true;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartPrg();
            StartButton.Enabled = false;
            StopButton.Enabled=true;
        }



        void StartPrg()
        {
            //Start PLC
            if(parameter.common.IsUsePLC)
                ConnectPLC();

            //Start Camera
            if (parameter.common.IsUseCamera)
                ConnectCamIS();
        }

        void StopPrg()
        {
            //Stop PLC
            if (parameter.common.IsUsePLC)
                DisConnectPLC();

            //Stop Camera
            if (parameter.common.IsUseCamera)
                DisconnectCamIS();
        }
        private void ReadDataTimer_Tick(object sender, EventArgs e)
        {
            ReadDataFromPLC();
        }


        void SetResult(bool bResult)
        {
            //Color color = new Color(0, 0, 255);
            if (bResult)
            {
                parameter.common.NumOK++;
                ResultLabel.BackColor = Color.Green;
                ResultLabel.Text = "OK";
            }
            else
            {
                parameter.common.NumNG++;
                ResultLabel.BackColor =Color.DarkRed;
                ResultLabel.Text = "NG";
            }

            OKLabel.Text = $"OK - {parameter.common.NumOK}";
            NGLabel.Text = $"NG - {parameter.common.NumNG}";

            //var status = CvsInSightDisplay2.InSight.Results.StatusLevel;
            

        }

        int timeCount = 0;
        void ReadDataFromPLC()
        {
            
            //while(true)
            {
                //Thread.Sleep(100);
                //Complete Job
                PLCData<bool> plcISComplete = new PLCData<bool>(Mitsubishi.PlcDeviceType.M, 1000, 1);
                plcISComplete.ReadData();
                bool isComplete = plcISComplete[0];
                if(isComplete)
                {
                    AddLog("-----------------------", listBoxPLC);

                    //Result
                    PLCData<Int16> plcJobPass = new PLCData<Int16>(Mitsubishi.PlcDeviceType.D, parameter.plc.ResultOutput, 1);
                    plcJobPass.ReadData();
                    AddLog($"Result={plcJobPass[0]}", listBoxPLC);
                    SetResult(plcJobPass[0]==1?true:false);
                    
                    

                    //Lech X
                    PLCData<float> plcX = new PLCData<float>(Mitsubishi.PlcDeviceType.D, parameter.plc.AddX, 1);
                    plcX.ReadData();
                    AddLog($"X ={plcX[0]}", listBoxPLC);

                    //Lech Y
                    PLCData<float> plcY = new PLCData<float>(Mitsubishi.PlcDeviceType.D, parameter.plc.AddY, 1);
                    plcY.ReadData();
                    AddLog($"Y={plcY[0]}", listBoxPLC);

                    //angle
                    PLCData<float> plcAngle = new PLCData<float>(Mitsubishi.PlcDeviceType.D, parameter.plc.AddAngle, 1);
                    plcAngle.ReadData();
                    AddLog($"Angle={plcAngle[0]}", listBoxPLC);


                    ReadDataTimer.Stop();
                    ReadDataTimer.Enabled = false;
                }
                else
                {
                    timeCount++;
                    if(timeCount > 10)
                    {
                        timeCount = 0;
                        ReadDataTimer.Stop();
                        ReadDataTimer.Enabled = false;
                        AddLog("Error: ---------> Check M1000 on PLC", listBoxPLC);

                    }
                }

            }
        }



        void trigger()
        {
            if (PLCData.PLC == null || !PLCData.PLC.Connected)
                return;

            PLCData<Int16> int16s = new PLCData<Int16>(Mitsubishi.PlcDeviceType.D, parameter.plc.TriggerInput, 2);
            int16s[0] = 3;
            int16s.WriteData();
            UpdateTestStatus("Triggering...");
            Thread.Sleep(100);

            int16s[0] = 1;
            int16s.WriteData();
            UpdateTestStatus("Trigger done!");

            if(!ReadDataTimer.Enabled)
                ReadDataTimer.Enabled = true;
            
            ReadDataTimer.Start();
        }

        #region PLC

        private void TriggerCamButton_Click(object sender, EventArgs e)
        {
            if(parameter.common.IsUsePLC)
            {
                trigger();
            }
            else
            {
                //CvsInSightDisplay2.InSight.ManualAcquire();
                CvsInSightDisplay2.Recorder.PlayNext();
                CvsInSightDisplay2.Refresh();
            }
        }


        private void EnDisButton()
        {
            
            TriggerCamButton.Enabled = PLCData.PLC.Connected;
        }
        private void DisConnectPLC()
        {
            bool bClosePLC = MyLib.DisconnectPLC();
            AddLog($"DisConnect = { bClosePLC}", listBoxPLC);
            EnDisButton();
        }

        private void ConnectPLC()
        {
            MyLib.ConnectToPlc(parameter.plc.Ip, parameter.plc.Port);

            Console.WriteLine($"Connected = { PLCData.PLC.Connected}");
            AddLog($"Connected = { PLCData.PLC.Connected}", listBoxPLC);
            EnDisButton();
        }

        public delegate void DelegateStandardPattern(string data, ListBox listBox);
        void AddLog(string data, ListBox listBox)
        {
            //var date_time = DateTime.Now.ToString("HH:mm:ss");
            if (this.InvokeRequired)
            {
                this.Invoke(new DelegateStandardPattern(AddLog), data, listBox);
                return;
            }
            //listBox.Items.Add(String.Format("{0}: {1}", date_time, data));
            listBox.Items.Add(data);

            if (listBox.Items.Count > 500)
                listBox.Items.RemoveAt(0);

            if (listBox.Items.Count > 0)
                listBox.SelectedIndex = listBox.Items.Count - 1;
        }

        #endregion

        #region Insight Display
        private void CvsInSightDisplay2_StatusInformationChanged(object sender, System.EventArgs e)
        {
            StatusBar1.Panels[1].Text = CvsInSightDisplay2.StatusInformation;
            Console.WriteLine(CvsInSightDisplay2.StatusInformation);
        }

        private void CvsInSightDisplay2_ConnectedChanged(object sender, System.EventArgs e)
        {
            if (CvsInSightDisplay2.Connected)
            {
                //CamISConnectButton.Text = "Dis&connect";
                UpdateTestStatus("Camera Conneted");

            }
            else
            {
                UpdateTestStatus("Camera Disconnect");
            }
        }

        //The state changed within the display control.  Event raised.
        private void CvsInSightDisplay2_StateChanged(object sender, System.EventArgs e)
        {
            UpdateStateMsg();
        }

        //The display control is now connected.  Event raised.
        private void CvsInSightDisplay2_ConnectCompleted(object sender, Cognex.InSight.CvsConnectCompletedEventArgs e)
        {
            chkImage.Checked = CvsInSightDisplay2.ShowImage;

            if (CvsInSightDisplay2.ImageZoomMode == Cognex.InSight.Controls.Display.CvsDisplayZoom.None)
                optNone.Checked = true;
            else if (CvsInSightDisplay2.ImageZoomMode == Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit)
                optFit.Checked = true;
            else if (CvsInSightDisplay2.ImageZoomMode == Cognex.InSight.Controls.Display.CvsDisplayZoom.Fill)
                optFill.Checked = true;

        }

        private void UpdateStateMsg()
        {
            switch (CvsInSightDisplay2.State)
            {
                case Cognex.InSight.Controls.Display.CvsDisplayState.Connecting:
                    StatusBar1.Panels[0].Text = "Connecting...";
                    break;
                case Cognex.InSight.Controls.Display.CvsDisplayState.Dialog:
                    StatusBar1.Panels[0].Text = "Dialog";
                    break;
                case Cognex.InSight.Controls.Display.CvsDisplayState.DialogEditingReferenceRanges:
                    StatusBar1.Panels[0].Text = "Dialog Reference";
                    break;
                case Cognex.InSight.Controls.Display.CvsDisplayState.EditingCellExpression:
                    StatusBar1.Panels[0].Text = "Editing Expression";
                    break;
                case Cognex.InSight.Controls.Display.CvsDisplayState.EditingCellValue:
                    StatusBar1.Panels[0].Text = "Editing Value";
                    break;
                case Cognex.InSight.Controls.Display.CvsDisplayState.EditingGraphics:
                    StatusBar1.Panels[0].Text = "Editing Graphics";
                    break;
                case Cognex.InSight.Controls.Display.CvsDisplayState.EditingReferenceRanges:
                    StatusBar1.Panels[0].Text = "Editing Reference";
                    break;
                case Cognex.InSight.Controls.Display.CvsDisplayState.Normal:
                    StatusBar1.Panels[0].Text = "Normal";
                    break;
                case Cognex.InSight.Controls.Display.CvsDisplayState.Waiting:
                    StatusBar1.Panels[0].Text = "Waiting...";
                    break;
                case Cognex.InSight.Controls.Display.CvsDisplayState.Wizard:
                    StatusBar1.Panels[0].Text = "Wizard";
                    break;
                default:
                    StatusBar1.Panels[0].Text = "Unknown";
                    break;
            }
        }


        //Scroll
        private void HScrollOpacity_ValueChanged(object sender, ScrollEventArgs e)
        {
            CvsInSightDisplay2.GridOpacity = (double)e.NewValue / 100;
            lblGridOpacityValue.Text = System.Convert.ToString(CvsInSightDisplay2.GridOpacity * 100) + '%';
        }

        //Zoom
        private void optFill_CheckedChanged(object sender, System.EventArgs e)
        {
            if (optFill.Checked)
            {
                CvsInSightDisplay2.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fill;
                TestZoomMode();  //Interal Test
            }
        }

        private void optFit_CheckedChanged(object sender, System.EventArgs e)
        {
            if (optFit.Checked)
            {
                CvsInSightDisplay2.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit;
                TestZoomMode();  //Interal Test
            }
        }

        private void optNone_CheckedChanged(object sender, System.EventArgs e)
        {
            if (optNone.Checked)
            {
                CvsInSightDisplay2.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.None;
                TestZoomMode();  //Interal Test
            }
        }


        //internal test code
        #region AutomatedTestHelper

        private bool ATEST_MODE = true;


        private void UpdateTestStatus(string message)
        {
            StatusBar1.Panels[0].Text = message;
        }

        private void chkGrid_CheckedChanged(object sender, EventArgs e)
        {
            //CvsInSightDisplay2.ShowGrid = chkGrid.Checked;
            if (ATEST_MODE)
                UpdateTestStatus("Show Grid = " + CvsInSightDisplay2.ShowGrid);
        }

        private void chkGraphics_CheckedChanged(object sender, EventArgs e)
        {
            //CvsInSightDisplay2.ShowGraphics = chkGraphics.Checked;
            if (ATEST_MODE)
                UpdateTestStatus("Show Graphics = " + CvsInSightDisplay2.ShowGraphics);
        }

        private void chkOnline_CheckedChanged(object sender, EventArgs e)
        {
            //CvsInSightDisplay2.SoftOnline = chkOnline.Checked;
            if (ATEST_MODE)
                UpdateTestStatus("Online = " + CvsInSightDisplay2.SoftOnline);
        }
        //The "Show Image" checkbox is clicked
        //Toggles whether or not the background image is shown behind the grid
        private void chkImage_CheckedChanged(object sender, System.EventArgs e)
        {
            CvsInSightDisplay2.ShowImage = chkImage.Checked;
            if (ATEST_MODE)
                UpdateTestStatus("Show Image = " + CvsInSightDisplay2.ShowImage);
        }

        private void TestZoomMode()
        {
            
            if (ATEST_MODE)
                UpdateTestStatus("Zoom Mode = " + CvsInSightDisplay2.ImageZoomMode);
        }

        private void chkLive_CheckedChanged(object sender, EventArgs e)
        {

            if (ATEST_MODE)
                UpdateTestStatus("Live Mode = " + !CvsInSightDisplay2.Edit.LiveAcquire.Activated);
        }

        #endregion
        #endregion

        private void ConnectCamIS()
        {
            if (!CvsInSightDisplay2.Connected)
            {
                CvsInSightDisplay2.Connect(parameter.cam.Ip, parameter.cam.UserName, parameter.cam.PassWord, false);
                AddLog($"Connected to camera {parameter.cam.Ip}", listBoxPLC);
            }
            
            Refresh();
        }

        private void DisconnectCamIS()
        {
            if (CvsInSightDisplay2.Connected)
            {
                CvsInSightDisplay2.Disconnect();
                AddLog($"Disconnect to camera {parameter.cam.Ip}", listBoxPLC);
            }
            Refresh();
        }


        //private void tabControl_Main_Click(object sender, EventArgs e)
        //{
        //    switch (tabControl_Main.SelectedIndex)
        //    {
        //        case (int)TabControlIndex.TabControl.Tab_Auto:
        //            Console.WriteLine("Tab Auto");
        //            break;
        //        case (int)TabControlIndex.TabControl.Tab_Manual:
        //            Console.WriteLine("Tab Manul");
        //            break;
                
        //        case (int)TabControlIndex.TabControl.Tab_Camera:
        //            Console.WriteLine("Tab Camera");
        //            break;
        //        case (int)TabControlIndex.TabControl.Tab_Setting:
        //            Console.WriteLine("Tab Setting");
        //            break;
        //        case (int)TabControlIndex.TabControl.Tab_Log:
        //            Console.WriteLine("Tab Log");
        //            break;
        //        case (int)TabControlIndex.TabControl.Tab_About:
        //            Console.WriteLine("Tab About");
        //            break;
        //    }
        //}

        private void Vision_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Vision_FormClosing ....");

            //StopPrg
            StopPrg();


            //Save File
            SaveLoadParameter.Save_Parameter(parameter);
        }

        private void button_SaveParam_Click(object sender, EventArgs e)
        {
            UpdateGUIParameter();
            SaveLoadParameter.Save_Parameter(parameter);
        }

        private void Vision_Load(object sender, EventArgs e)
        {
            hScrollOpacity.Value = System.Convert.ToInt32(CvsInSightDisplay2.GridOpacity * 100.0);

            //Bind the display's editing actions to controls
            CvsInSightDisplay2.Edit.SoftOnline.Bind(chkOnline); // online mode
            CvsInSightDisplay2.Edit.LiveAcquire.Bind(chkLive);  // live mode
            CvsInSightDisplay2.Edit.ShowGraphics.Bind(chkGraphics);
            CvsInSightDisplay2.Edit.ShowGrid.Bind(chkGrid);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxPLC.Items.Clear();
        }

        private void M100Checkbox_CheckedChanged(object sender, EventArgs e)
        {

            M100Checkbox.Text = $"M100 = { M100Checkbox.Checked}";

            if (PLCData.PLC == null || !PLCData.PLC.Connected)
                return;


            PLCData<bool> mRegister = new PLCData<bool>(Mitsubishi.PlcDeviceType.M, 100, 1);
            mRegister[0] = M100Checkbox.Checked;
            mRegister.WriteData();

        }

        private void ReadM100Button_Click(object sender, EventArgs e)
        {
            if (PLCData.PLC == null || !PLCData.PLC.Connected)
                return;

            PLCData<bool> mRegister = new PLCData<bool>(Mitsubishi.PlcDeviceType.M, 100, 1);
            mRegister.ReadData();
            ReadM100Button.Text = $"Read M100 = {mRegister[0]}";// mRegister[0]==true?"1":"0";

        }

        private void FolderImageFileButton_Click(object sender, EventArgs e)
        {

            folderBrowserDlg.SelectedPath = parameter.common.PathImage;
            if (folderBrowserDlg.ShowDialog() == DialogResult.OK)
            {
                parameter.common.PathImage =  folderBrowserDlg.SelectedPath;
                PathImageFileTextbox.Text = folderBrowserDlg.SelectedPath;
            }
        }

        private void FolderTextFileButton_Click(object sender, EventArgs e)
        {
            folderBrowserDlg.SelectedPath = parameter.common.PathText;
            if (folderBrowserDlg.ShowDialog() == DialogResult.OK)
            {
                parameter.common.PathText = folderBrowserDlg.SelectedPath;
                PathTxtFileTextbox.Text = folderBrowserDlg.SelectedPath;
            }
        }

        private void OpenFolderImageButton_Click(object sender, EventArgs e)
        {
            MyLib.CreateFolder(parameter.common.PathImage);
            Process.Start(parameter.common.PathImage);
        }

        private void OpenFolderTextButton_Click(object sender, EventArgs e)
        {
            MyLib.CreateFolder(parameter.common.PathText);
            Process.Start(parameter.common.PathText);
        }








#if AUTO_RESIZE
        clsResize _form_resize;
        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }
#endif
    }
}
