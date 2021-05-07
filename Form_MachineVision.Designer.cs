
namespace Winform_Vision
{
    partial class Vision
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vision));
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Auto = new System.Windows.Forms.TabPage();
            this.label_Nunber_NG = new System.Windows.Forms.Label();
            this.label_Number_OK = new System.Windows.Forms.Label();
            this.label_Result = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.tabPage_Manual = new System.Windows.Forms.TabPage();
            this.tabPage_SerialPort = new System.Windows.Forms.TabPage();
            this.listBox_COM_Log = new System.Windows.Forms.ListBox();
            this.listBox_COM_Receive = new System.Windows.Forms.ListBox();
            this.button_COM_Send = new System.Windows.Forms.Button();
            this.textBox_COM_Data2Send = new System.Windows.Forms.TextBox();
            this.comboBox_ListComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_COM_Connect = new System.Windows.Forms.Button();
            this.tabPage_Socket = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Client_Port = new System.Windows.Forms.TextBox();
            this.textBox_Client_Ip = new System.Windows.Forms.TextBox();
            this.button_Client_Send = new System.Windows.Forms.Button();
            this.button_Client_Connect = new System.Windows.Forms.Button();
            this.textBox_Client_Send = new System.Windows.Forms.TextBox();
            this.listBox_Client_Receive = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_Socket_Server = new System.Windows.Forms.GroupBox();
            this.textBox_Server_Port = new System.Windows.Forms.TextBox();
            this.textBox_Server_Ip = new System.Windows.Forms.TextBox();
            this.button_Server_Send = new System.Windows.Forms.Button();
            this.button_Server_Open = new System.Windows.Forms.Button();
            this.textBox_Server_Send = new System.Windows.Forms.TextBox();
            this.listBox_Server_Receive = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_Camera = new System.Windows.Forms.TabPage();
            this.button_Test_Cam_Basler = new System.Windows.Forms.Button();
            this.listBox_Camera_Log = new System.Windows.Forms.ListBox();
            this.button_Camera_Connect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Cam_URL = new System.Windows.Forms.TextBox();
            this.tabPage_Setting = new System.Windows.Forms.TabPage();
            this.groupBox_Setting_Camera = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_Setting_Camera_Flip = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_Setting_Camera_Height = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_Setting_Camera_Width = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Setting_Camera_Fps = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_Setting_Camera_URL = new System.Windows.Forms.TextBox();
            this.groupBox_Setting_Client = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Setting_Client_Port = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_Setting_Client_Ip = new System.Windows.Forms.TextBox();
            this.groupBox_Setting_Server = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Setting_Server_Port = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Setting_Server_Ip = new System.Windows.Forms.TextBox();
            this.groupBox_Setting_COM = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Setting_Baudrate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Setting_Comport = new System.Windows.Forms.TextBox();
            this.tabPage_Log = new System.Windows.Forms.TabPage();
            this.listBox_Log_System = new System.Windows.Forms.ListBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_DateTime = new System.Windows.Forms.Label();
            this.timer_Datetime = new System.Windows.Forms.Timer(this.components);
            this.label_Comport_status = new System.Windows.Forms.Label();
            this.tabPage_Help = new System.Windows.Forms.TabPage();
            this.tabPage_About = new System.Windows.Forms.TabPage();
            this.listBox_ListClient = new System.Windows.Forms.ListBox();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_Display = new System.Windows.Forms.PictureBox();
            this.pictureBox_Frame_Camera = new System.Windows.Forms.PictureBox();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Auto.SuspendLayout();
            this.tabPage_SerialPort.SuspendLayout();
            this.tabPage_Socket.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Socket_Server.SuspendLayout();
            this.tabPage_Camera.SuspendLayout();
            this.tabPage_Setting.SuspendLayout();
            this.groupBox_Setting_Camera.SuspendLayout();
            this.groupBox_Setting_Client.SuspendLayout();
            this.groupBox_Setting_Server.SuspendLayout();
            this.groupBox_Setting_COM.SuspendLayout();
            this.tabPage_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Frame_Camera)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Main.Controls.Add(this.tabPage_Auto);
            this.tabControl_Main.Controls.Add(this.tabPage_Manual);
            this.tabControl_Main.Controls.Add(this.tabPage_SerialPort);
            this.tabControl_Main.Controls.Add(this.tabPage_Socket);
            this.tabControl_Main.Controls.Add(this.tabPage_Camera);
            this.tabControl_Main.Controls.Add(this.tabPage_Setting);
            this.tabControl_Main.Controls.Add(this.tabPage_Log);
            this.tabControl_Main.Controls.Add(this.tabPage_Help);
            this.tabControl_Main.Controls.Add(this.tabPage_About);
            this.tabControl_Main.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Main.ItemSize = new System.Drawing.Size(65, 50);
            this.tabControl_Main.Location = new System.Drawing.Point(-1, 35);
            this.tabControl_Main.Multiline = true;
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.ShowToolTips = true;
            this.tabControl_Main.Size = new System.Drawing.Size(623, 406);
            this.tabControl_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_Main.TabIndex = 0;
            this.tabControl_Main.Click += new System.EventHandler(this.tabControl_Main_Click);
            // 
            // tabPage_Auto
            // 
            this.tabPage_Auto.Controls.Add(this.label_Nunber_NG);
            this.tabPage_Auto.Controls.Add(this.label_Number_OK);
            this.tabPage_Auto.Controls.Add(this.label_Result);
            this.tabPage_Auto.Controls.Add(this.button_Reset);
            this.tabPage_Auto.Controls.Add(this.button_Stop);
            this.tabPage_Auto.Controls.Add(this.button_Start);
            this.tabPage_Auto.Controls.Add(this.pictureBox_Display);
            this.tabPage_Auto.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Auto.Name = "tabPage_Auto";
            this.tabPage_Auto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Auto.Size = new System.Drawing.Size(615, 348);
            this.tabPage_Auto.TabIndex = 0;
            this.tabPage_Auto.Text = "Auto";
            this.tabPage_Auto.UseVisualStyleBackColor = true;
            // 
            // label_Nunber_NG
            // 
            this.label_Nunber_NG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Nunber_NG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nunber_NG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_Nunber_NG.Location = new System.Drawing.Point(479, 162);
            this.label_Nunber_NG.Name = "label_Nunber_NG";
            this.label_Nunber_NG.Size = new System.Drawing.Size(130, 29);
            this.label_Nunber_NG.TabIndex = 6;
            this.label_Nunber_NG.Text = "NG";
            this.label_Nunber_NG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Number_OK
            // 
            this.label_Number_OK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Number_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Number_OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_Number_OK.Location = new System.Drawing.Point(479, 127);
            this.label_Number_OK.Name = "label_Number_OK";
            this.label_Number_OK.Size = new System.Drawing.Size(130, 29);
            this.label_Number_OK.TabIndex = 5;
            this.label_Number_OK.Text = "OK";
            this.label_Number_OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Result
            // 
            this.label_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_Result.Location = new System.Drawing.Point(478, 8);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(131, 111);
            this.label_Result.TabIndex = 4;
            this.label_Result.Text = "RESULT";
            this.label_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Reset
            // 
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Reset.Location = new System.Drawing.Point(479, 310);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(130, 32);
            this.button_Reset.TabIndex = 3;
            this.button_Reset.Text = "RESET";
            this.button_Reset.UseVisualStyleBackColor = true;
            // 
            // button_Stop
            // 
            this.button_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Stop.Location = new System.Drawing.Point(479, 272);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(130, 32);
            this.button_Stop.TabIndex = 2;
            this.button_Stop.Text = "STOP";
            this.button_Stop.UseVisualStyleBackColor = true;
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.ForeColor = System.Drawing.Color.Green;
            this.button_Start.Location = new System.Drawing.Point(479, 236);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(130, 32);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "START";
            this.button_Start.UseVisualStyleBackColor = true;
            // 
            // tabPage_Manual
            // 
            this.tabPage_Manual.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Manual.Name = "tabPage_Manual";
            this.tabPage_Manual.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Manual.Size = new System.Drawing.Size(615, 348);
            this.tabPage_Manual.TabIndex = 1;
            this.tabPage_Manual.Text = "Manual";
            this.tabPage_Manual.UseVisualStyleBackColor = true;
            // 
            // tabPage_SerialPort
            // 
            this.tabPage_SerialPort.Controls.Add(this.label_Comport_status);
            this.tabPage_SerialPort.Controls.Add(this.listBox_COM_Log);
            this.tabPage_SerialPort.Controls.Add(this.listBox_COM_Receive);
            this.tabPage_SerialPort.Controls.Add(this.button_COM_Send);
            this.tabPage_SerialPort.Controls.Add(this.textBox_COM_Data2Send);
            this.tabPage_SerialPort.Controls.Add(this.comboBox_ListComPort);
            this.tabPage_SerialPort.Controls.Add(this.label1);
            this.tabPage_SerialPort.Controls.Add(this.button_COM_Connect);
            this.tabPage_SerialPort.Location = new System.Drawing.Point(4, 4);
            this.tabPage_SerialPort.Name = "tabPage_SerialPort";
            this.tabPage_SerialPort.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SerialPort.Size = new System.Drawing.Size(615, 348);
            this.tabPage_SerialPort.TabIndex = 2;
            this.tabPage_SerialPort.Text = "COM";
            this.tabPage_SerialPort.UseVisualStyleBackColor = true;
            // 
            // listBox_COM_Log
            // 
            this.listBox_COM_Log.FormattingEnabled = true;
            this.listBox_COM_Log.Location = new System.Drawing.Point(293, 8);
            this.listBox_COM_Log.Name = "listBox_COM_Log";
            this.listBox_COM_Log.Size = new System.Drawing.Size(316, 290);
            this.listBox_COM_Log.TabIndex = 6;
            // 
            // listBox_COM_Receive
            // 
            this.listBox_COM_Receive.FormattingEnabled = true;
            this.listBox_COM_Receive.Location = new System.Drawing.Point(9, 49);
            this.listBox_COM_Receive.Name = "listBox_COM_Receive";
            this.listBox_COM_Receive.Size = new System.Drawing.Size(278, 121);
            this.listBox_COM_Receive.TabIndex = 5;
            // 
            // button_COM_Send
            // 
            this.button_COM_Send.Location = new System.Drawing.Point(9, 309);
            this.button_COM_Send.Name = "button_COM_Send";
            this.button_COM_Send.Size = new System.Drawing.Size(278, 27);
            this.button_COM_Send.TabIndex = 4;
            this.button_COM_Send.Text = "Send";
            this.button_COM_Send.UseVisualStyleBackColor = true;
            // 
            // textBox_COM_Data2Send
            // 
            this.textBox_COM_Data2Send.Location = new System.Drawing.Point(9, 180);
            this.textBox_COM_Data2Send.Multiline = true;
            this.textBox_COM_Data2Send.Name = "textBox_COM_Data2Send";
            this.textBox_COM_Data2Send.Size = new System.Drawing.Size(278, 121);
            this.textBox_COM_Data2Send.TabIndex = 3;
            // 
            // comboBox_ListComPort
            // 
            this.comboBox_ListComPort.FormattingEnabled = true;
            this.comboBox_ListComPort.Location = new System.Drawing.Point(81, 9);
            this.comboBox_ListComPort.Name = "comboBox_ListComPort";
            this.comboBox_ListComPort.Size = new System.Drawing.Size(90, 21);
            this.comboBox_ListComPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM port";
            // 
            // button_COM_Connect
            // 
            this.button_COM_Connect.Location = new System.Drawing.Point(189, 8);
            this.button_COM_Connect.Name = "button_COM_Connect";
            this.button_COM_Connect.Size = new System.Drawing.Size(98, 23);
            this.button_COM_Connect.TabIndex = 0;
            this.button_COM_Connect.Text = "Connect";
            this.button_COM_Connect.UseVisualStyleBackColor = true;
            // 
            // tabPage_Socket
            // 
            this.tabPage_Socket.Controls.Add(this.groupBox1);
            this.tabPage_Socket.Controls.Add(this.groupBox_Socket_Server);
            this.tabPage_Socket.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Socket.Name = "tabPage_Socket";
            this.tabPage_Socket.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Socket.Size = new System.Drawing.Size(615, 348);
            this.tabPage_Socket.TabIndex = 3;
            this.tabPage_Socket.Text = "Socket";
            this.tabPage_Socket.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Client_Port);
            this.groupBox1.Controls.Add(this.textBox_Client_Ip);
            this.groupBox1.Controls.Add(this.button_Client_Send);
            this.groupBox1.Controls.Add(this.button_Client_Connect);
            this.groupBox1.Controls.Add(this.textBox_Client_Send);
            this.groupBox1.Controls.Add(this.listBox_Client_Receive);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(312, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 336);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // textBox_Client_Port
            // 
            this.textBox_Client_Port.Location = new System.Drawing.Point(42, 47);
            this.textBox_Client_Port.Name = "textBox_Client_Port";
            this.textBox_Client_Port.Size = new System.Drawing.Size(143, 20);
            this.textBox_Client_Port.TabIndex = 7;
            this.textBox_Client_Port.Text = "8888";
            // 
            // textBox_Client_Ip
            // 
            this.textBox_Client_Ip.Location = new System.Drawing.Point(42, 19);
            this.textBox_Client_Ip.Name = "textBox_Client_Ip";
            this.textBox_Client_Ip.Size = new System.Drawing.Size(143, 20);
            this.textBox_Client_Ip.TabIndex = 6;
            this.textBox_Client_Ip.Text = "127.0.0.1";
            // 
            // button_Client_Send
            // 
            this.button_Client_Send.Location = new System.Drawing.Point(9, 298);
            this.button_Client_Send.Name = "button_Client_Send";
            this.button_Client_Send.Size = new System.Drawing.Size(278, 28);
            this.button_Client_Send.TabIndex = 5;
            this.button_Client_Send.Text = "Send";
            this.button_Client_Send.UseVisualStyleBackColor = true;
            // 
            // button_Client_Connect
            // 
            this.button_Client_Connect.Location = new System.Drawing.Point(191, 19);
            this.button_Client_Connect.Name = "button_Client_Connect";
            this.button_Client_Connect.Size = new System.Drawing.Size(96, 48);
            this.button_Client_Connect.TabIndex = 4;
            this.button_Client_Connect.Text = "Connect";
            this.button_Client_Connect.UseVisualStyleBackColor = true;
            // 
            // textBox_Client_Send
            // 
            this.textBox_Client_Send.Location = new System.Drawing.Point(9, 199);
            this.textBox_Client_Send.Multiline = true;
            this.textBox_Client_Send.Name = "textBox_Client_Send";
            this.textBox_Client_Send.Size = new System.Drawing.Size(278, 95);
            this.textBox_Client_Send.TabIndex = 3;
            // 
            // listBox_Client_Receive
            // 
            this.listBox_Client_Receive.FormattingEnabled = true;
            this.listBox_Client_Receive.Location = new System.Drawing.Point(9, 94);
            this.listBox_Client_Receive.Name = "listBox_Client_Receive";
            this.listBox_Client_Receive.Size = new System.Drawing.Size(278, 95);
            this.listBox_Client_Receive.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ip";
            // 
            // groupBox_Socket_Server
            // 
            this.groupBox_Socket_Server.Controls.Add(this.listBox_ListClient);
            this.groupBox_Socket_Server.Controls.Add(this.textBox_Server_Port);
            this.groupBox_Socket_Server.Controls.Add(this.textBox_Server_Ip);
            this.groupBox_Socket_Server.Controls.Add(this.button_Server_Send);
            this.groupBox_Socket_Server.Controls.Add(this.button_Server_Open);
            this.groupBox_Socket_Server.Controls.Add(this.textBox_Server_Send);
            this.groupBox_Socket_Server.Controls.Add(this.listBox_Server_Receive);
            this.groupBox_Socket_Server.Controls.Add(this.label3);
            this.groupBox_Socket_Server.Controls.Add(this.label2);
            this.groupBox_Socket_Server.Location = new System.Drawing.Point(9, 6);
            this.groupBox_Socket_Server.Name = "groupBox_Socket_Server";
            this.groupBox_Socket_Server.Size = new System.Drawing.Size(293, 336);
            this.groupBox_Socket_Server.TabIndex = 0;
            this.groupBox_Socket_Server.TabStop = false;
            this.groupBox_Socket_Server.Text = "Server";
            // 
            // textBox_Server_Port
            // 
            this.textBox_Server_Port.Location = new System.Drawing.Point(42, 47);
            this.textBox_Server_Port.Name = "textBox_Server_Port";
            this.textBox_Server_Port.Size = new System.Drawing.Size(143, 20);
            this.textBox_Server_Port.TabIndex = 7;
            this.textBox_Server_Port.Text = "8888";
            // 
            // textBox_Server_Ip
            // 
            this.textBox_Server_Ip.Location = new System.Drawing.Point(42, 19);
            this.textBox_Server_Ip.Name = "textBox_Server_Ip";
            this.textBox_Server_Ip.Size = new System.Drawing.Size(143, 20);
            this.textBox_Server_Ip.TabIndex = 6;
            this.textBox_Server_Ip.Text = "127.0.0.1";
            // 
            // button_Server_Send
            // 
            this.button_Server_Send.Location = new System.Drawing.Point(9, 298);
            this.button_Server_Send.Name = "button_Server_Send";
            this.button_Server_Send.Size = new System.Drawing.Size(278, 28);
            this.button_Server_Send.TabIndex = 5;
            this.button_Server_Send.Text = "Send";
            this.button_Server_Send.UseVisualStyleBackColor = true;
            // 
            // button_Server_Open
            // 
            this.button_Server_Open.Location = new System.Drawing.Point(191, 19);
            this.button_Server_Open.Name = "button_Server_Open";
            this.button_Server_Open.Size = new System.Drawing.Size(96, 48);
            this.button_Server_Open.TabIndex = 4;
            this.button_Server_Open.Text = "Open";
            this.button_Server_Open.UseVisualStyleBackColor = true;
            // 
            // textBox_Server_Send
            // 
            this.textBox_Server_Send.Location = new System.Drawing.Point(9, 270);
            this.textBox_Server_Send.Multiline = true;
            this.textBox_Server_Send.Name = "textBox_Server_Send";
            this.textBox_Server_Send.Size = new System.Drawing.Size(278, 24);
            this.textBox_Server_Send.TabIndex = 3;
            // 
            // listBox_Server_Receive
            // 
            this.listBox_Server_Receive.FormattingEnabled = true;
            this.listBox_Server_Receive.Location = new System.Drawing.Point(97, 94);
            this.listBox_Server_Receive.Name = "listBox_Server_Receive";
            this.listBox_Server_Receive.Size = new System.Drawing.Size(190, 173);
            this.listBox_Server_Receive.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ip";
            // 
            // tabPage_Camera
            // 
            this.tabPage_Camera.Controls.Add(this.button_Test_Cam_Basler);
            this.tabPage_Camera.Controls.Add(this.listBox_Camera_Log);
            this.tabPage_Camera.Controls.Add(this.button_Camera_Connect);
            this.tabPage_Camera.Controls.Add(this.label6);
            this.tabPage_Camera.Controls.Add(this.textBox_Cam_URL);
            this.tabPage_Camera.Controls.Add(this.pictureBox_Frame_Camera);
            this.tabPage_Camera.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Camera.Name = "tabPage_Camera";
            this.tabPage_Camera.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Camera.Size = new System.Drawing.Size(615, 348);
            this.tabPage_Camera.TabIndex = 4;
            this.tabPage_Camera.Text = "Camera";
            this.tabPage_Camera.UseVisualStyleBackColor = true;
            // 
            // button_Test_Cam_Basler
            // 
            this.button_Test_Cam_Basler.Location = new System.Drawing.Point(453, 65);
            this.button_Test_Cam_Basler.Name = "button_Test_Cam_Basler";
            this.button_Test_Cam_Basler.Size = new System.Drawing.Size(156, 25);
            this.button_Test_Cam_Basler.TabIndex = 5;
            this.button_Test_Cam_Basler.Text = "Basler";
            this.button_Test_Cam_Basler.UseVisualStyleBackColor = true;
            this.button_Test_Cam_Basler.Click += new System.EventHandler(this.button_Test_Cam_Basler_Click);
            // 
            // listBox_Camera_Log
            // 
            this.listBox_Camera_Log.FormattingEnabled = true;
            this.listBox_Camera_Log.Location = new System.Drawing.Point(453, 156);
            this.listBox_Camera_Log.Name = "listBox_Camera_Log";
            this.listBox_Camera_Log.Size = new System.Drawing.Size(156, 186);
            this.listBox_Camera_Log.TabIndex = 4;
            // 
            // button_Camera_Connect
            // 
            this.button_Camera_Connect.Location = new System.Drawing.Point(453, 34);
            this.button_Camera_Connect.Name = "button_Camera_Connect";
            this.button_Camera_Connect.Size = new System.Drawing.Size(156, 25);
            this.button_Camera_Connect.TabIndex = 2;
            this.button_Camera_Connect.Text = "Connect";
            this.button_Camera_Connect.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Camera";
            // 
            // textBox_Cam_URL
            // 
            this.textBox_Cam_URL.Location = new System.Drawing.Point(502, 7);
            this.textBox_Cam_URL.Name = "textBox_Cam_URL";
            this.textBox_Cam_URL.Size = new System.Drawing.Size(107, 20);
            this.textBox_Cam_URL.TabIndex = 0;
            // 
            // tabPage_Setting
            // 
            this.tabPage_Setting.Controls.Add(this.groupBox_Setting_Camera);
            this.tabPage_Setting.Controls.Add(this.groupBox_Setting_Client);
            this.tabPage_Setting.Controls.Add(this.groupBox_Setting_Server);
            this.tabPage_Setting.Controls.Add(this.groupBox_Setting_COM);
            this.tabPage_Setting.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Setting.Name = "tabPage_Setting";
            this.tabPage_Setting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Setting.Size = new System.Drawing.Size(615, 348);
            this.tabPage_Setting.TabIndex = 5;
            this.tabPage_Setting.Text = "Setting";
            this.tabPage_Setting.UseVisualStyleBackColor = true;
            // 
            // groupBox_Setting_Camera
            // 
            this.groupBox_Setting_Camera.Controls.Add(this.label17);
            this.groupBox_Setting_Camera.Controls.Add(this.textBox_Setting_Camera_Flip);
            this.groupBox_Setting_Camera.Controls.Add(this.label16);
            this.groupBox_Setting_Camera.Controls.Add(this.textBox_Setting_Camera_Height);
            this.groupBox_Setting_Camera.Controls.Add(this.label15);
            this.groupBox_Setting_Camera.Controls.Add(this.textBox_Setting_Camera_Width);
            this.groupBox_Setting_Camera.Controls.Add(this.label13);
            this.groupBox_Setting_Camera.Controls.Add(this.textBox_Setting_Camera_Fps);
            this.groupBox_Setting_Camera.Controls.Add(this.label14);
            this.groupBox_Setting_Camera.Controls.Add(this.textBox_Setting_Camera_URL);
            this.groupBox_Setting_Camera.Location = new System.Drawing.Point(215, 6);
            this.groupBox_Setting_Camera.Name = "groupBox_Setting_Camera";
            this.groupBox_Setting_Camera.Size = new System.Drawing.Size(200, 162);
            this.groupBox_Setting_Camera.TabIndex = 6;
            this.groupBox_Setting_Camera.TabStop = false;
            this.groupBox_Setting_Camera.Text = "Camera";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Flip";
            // 
            // textBox_Setting_Camera_Flip
            // 
            this.textBox_Setting_Camera_Flip.Location = new System.Drawing.Point(91, 135);
            this.textBox_Setting_Camera_Flip.Name = "textBox_Setting_Camera_Flip";
            this.textBox_Setting_Camera_Flip.Size = new System.Drawing.Size(100, 20);
            this.textBox_Setting_Camera_Flip.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Height";
            // 
            // textBox_Setting_Camera_Height
            // 
            this.textBox_Setting_Camera_Height.Location = new System.Drawing.Point(91, 106);
            this.textBox_Setting_Camera_Height.Name = "textBox_Setting_Camera_Height";
            this.textBox_Setting_Camera_Height.Size = new System.Drawing.Size(100, 20);
            this.textBox_Setting_Camera_Height.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Width";
            // 
            // textBox_Setting_Camera_Width
            // 
            this.textBox_Setting_Camera_Width.Location = new System.Drawing.Point(91, 77);
            this.textBox_Setting_Camera_Width.Name = "textBox_Setting_Camera_Width";
            this.textBox_Setting_Camera_Width.Size = new System.Drawing.Size(100, 20);
            this.textBox_Setting_Camera_Width.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "FPS";
            // 
            // textBox_Setting_Camera_Fps
            // 
            this.textBox_Setting_Camera_Fps.Location = new System.Drawing.Point(91, 47);
            this.textBox_Setting_Camera_Fps.Name = "textBox_Setting_Camera_Fps";
            this.textBox_Setting_Camera_Fps.Size = new System.Drawing.Size(100, 20);
            this.textBox_Setting_Camera_Fps.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "URL";
            // 
            // textBox_Setting_Camera_URL
            // 
            this.textBox_Setting_Camera_URL.Location = new System.Drawing.Point(91, 17);
            this.textBox_Setting_Camera_URL.Name = "textBox_Setting_Camera_URL";
            this.textBox_Setting_Camera_URL.Size = new System.Drawing.Size(100, 20);
            this.textBox_Setting_Camera_URL.TabIndex = 0;
            // 
            // groupBox_Setting_Client
            // 
            this.groupBox_Setting_Client.Controls.Add(this.label11);
            this.groupBox_Setting_Client.Controls.Add(this.textBox_Setting_Client_Port);
            this.groupBox_Setting_Client.Controls.Add(this.label12);
            this.groupBox_Setting_Client.Controls.Add(this.textBox_Setting_Client_Ip);
            this.groupBox_Setting_Client.Location = new System.Drawing.Point(6, 174);
            this.groupBox_Setting_Client.Name = "groupBox_Setting_Client";
            this.groupBox_Setting_Client.Size = new System.Drawing.Size(200, 78);
            this.groupBox_Setting_Client.TabIndex = 5;
            this.groupBox_Setting_Client.TabStop = false;
            this.groupBox_Setting_Client.Text = "Client";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Port";
            // 
            // textBox_Setting_Client_Port
            // 
            this.textBox_Setting_Client_Port.Location = new System.Drawing.Point(92, 48);
            this.textBox_Setting_Client_Port.Name = "textBox_Setting_Client_Port";
            this.textBox_Setting_Client_Port.Size = new System.Drawing.Size(100, 20);
            this.textBox_Setting_Client_Port.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "IP";
            // 
            // textBox_Setting_Client_Ip
            // 
            this.textBox_Setting_Client_Ip.Location = new System.Drawing.Point(91, 18);
            this.textBox_Setting_Client_Ip.Name = "textBox_Setting_Client_Ip";
            this.textBox_Setting_Client_Ip.Size = new System.Drawing.Size(100, 20);
            this.textBox_Setting_Client_Ip.TabIndex = 0;
            // 
            // groupBox_Setting_Server
            // 
            this.groupBox_Setting_Server.Controls.Add(this.label9);
            this.groupBox_Setting_Server.Controls.Add(this.textBox_Setting_Server_Port);
            this.groupBox_Setting_Server.Controls.Add(this.label10);
            this.groupBox_Setting_Server.Controls.Add(this.textBox_Setting_Server_Ip);
            this.groupBox_Setting_Server.Location = new System.Drawing.Point(6, 90);
            this.groupBox_Setting_Server.Name = "groupBox_Setting_Server";
            this.groupBox_Setting_Server.Size = new System.Drawing.Size(200, 78);
            this.groupBox_Setting_Server.TabIndex = 4;
            this.groupBox_Setting_Server.TabStop = false;
            this.groupBox_Setting_Server.Text = "Server";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Port";
            // 
            // textBox_Setting_Server_Port
            // 
            this.textBox_Setting_Server_Port.Location = new System.Drawing.Point(92, 48);
            this.textBox_Setting_Server_Port.Name = "textBox_Setting_Server_Port";
            this.textBox_Setting_Server_Port.Size = new System.Drawing.Size(100, 20);
            this.textBox_Setting_Server_Port.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "IP";
            // 
            // textBox_Setting_Server_Ip
            // 
            this.textBox_Setting_Server_Ip.Location = new System.Drawing.Point(91, 18);
            this.textBox_Setting_Server_Ip.Name = "textBox_Setting_Server_Ip";
            this.textBox_Setting_Server_Ip.Size = new System.Drawing.Size(100, 20);
            this.textBox_Setting_Server_Ip.TabIndex = 0;
            // 
            // groupBox_Setting_COM
            // 
            this.groupBox_Setting_COM.Controls.Add(this.label8);
            this.groupBox_Setting_COM.Controls.Add(this.textBox_Setting_Baudrate);
            this.groupBox_Setting_COM.Controls.Add(this.label7);
            this.groupBox_Setting_COM.Controls.Add(this.textBox_Setting_Comport);
            this.groupBox_Setting_COM.Location = new System.Drawing.Point(9, 6);
            this.groupBox_Setting_COM.Name = "groupBox_Setting_COM";
            this.groupBox_Setting_COM.Size = new System.Drawing.Size(200, 78);
            this.groupBox_Setting_COM.TabIndex = 0;
            this.groupBox_Setting_COM.TabStop = false;
            this.groupBox_Setting_COM.Text = "COM Port";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "BaudRate";
            // 
            // textBox_Setting_Baudrate
            // 
            this.textBox_Setting_Baudrate.Location = new System.Drawing.Point(92, 48);
            this.textBox_Setting_Baudrate.Name = "textBox_Setting_Baudrate";
            this.textBox_Setting_Baudrate.Size = new System.Drawing.Size(100, 20);
            this.textBox_Setting_Baudrate.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Com Port";
            // 
            // textBox_Setting_Comport
            // 
            this.textBox_Setting_Comport.Location = new System.Drawing.Point(91, 18);
            this.textBox_Setting_Comport.Name = "textBox_Setting_Comport";
            this.textBox_Setting_Comport.Size = new System.Drawing.Size(100, 20);
            this.textBox_Setting_Comport.TabIndex = 0;
            // 
            // tabPage_Log
            // 
            this.tabPage_Log.Controls.Add(this.listBox_Log_System);
            this.tabPage_Log.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Log.Name = "tabPage_Log";
            this.tabPage_Log.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Log.Size = new System.Drawing.Size(615, 348);
            this.tabPage_Log.TabIndex = 6;
            this.tabPage_Log.Text = "Log";
            this.tabPage_Log.UseVisualStyleBackColor = true;
            // 
            // listBox_Log_System
            // 
            this.listBox_Log_System.FormattingEnabled = true;
            this.listBox_Log_System.Location = new System.Drawing.Point(6, 6);
            this.listBox_Log_System.Name = "listBox_Log_System";
            this.listBox_Log_System.Size = new System.Drawing.Size(603, 329);
            this.listBox_Log_System.TabIndex = 0;
            // 
            // label_Title
            // 
            this.label_Title.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.Blue;
            this.label_Title.Location = new System.Drawing.Point(0, 1);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(618, 31);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Machine Vision Toolbox";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_DateTime
            // 
            this.label_DateTime.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label_DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateTime.ForeColor = System.Drawing.Color.Blue;
            this.label_DateTime.Location = new System.Drawing.Point(495, 1);
            this.label_DateTime.Name = "label_DateTime";
            this.label_DateTime.Size = new System.Drawing.Size(127, 31);
            this.label_DateTime.TabIndex = 3;
            this.label_DateTime.Text = "Date-Time";
            this.label_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_Datetime
            // 
            this.timer_Datetime.Interval = 1000;
            // 
            // label_Comport_status
            // 
            this.label_Comport_status.Location = new System.Drawing.Point(293, 309);
            this.label_Comport_status.Name = "label_Comport_status";
            this.label_Comport_status.Size = new System.Drawing.Size(316, 28);
            this.label_Comport_status.TabIndex = 7;
            this.label_Comport_status.Text = "Comport_status";
            this.label_Comport_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage_Help
            // 
            this.tabPage_Help.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Help.Name = "tabPage_Help";
            this.tabPage_Help.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Help.Size = new System.Drawing.Size(615, 348);
            this.tabPage_Help.TabIndex = 7;
            this.tabPage_Help.Text = "Help";
            this.tabPage_Help.UseVisualStyleBackColor = true;
            // 
            // tabPage_About
            // 
            this.tabPage_About.Location = new System.Drawing.Point(4, 4);
            this.tabPage_About.Name = "tabPage_About";
            this.tabPage_About.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_About.Size = new System.Drawing.Size(615, 348);
            this.tabPage_About.TabIndex = 8;
            this.tabPage_About.Text = "About";
            this.tabPage_About.UseVisualStyleBackColor = true;
            // 
            // listBox_ListClient
            // 
            this.listBox_ListClient.FormattingEnabled = true;
            this.listBox_ListClient.Location = new System.Drawing.Point(9, 94);
            this.listBox_ListClient.Name = "listBox_ListClient";
            this.listBox_ListClient.Size = new System.Drawing.Size(82, 173);
            this.listBox_ListClient.TabIndex = 8;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox_Logo.Image = global::Winform_Vision.Properties.Resources.Vietnam;
            this.pictureBox_Logo.Location = new System.Drawing.Point(3, 1);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(40, 32);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 2;
            this.pictureBox_Logo.TabStop = false;
            // 
            // pictureBox_Display
            // 
            this.pictureBox_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Display.Location = new System.Drawing.Point(6, 6);
            this.pictureBox_Display.Name = "pictureBox_Display";
            this.pictureBox_Display.Size = new System.Drawing.Size(467, 336);
            this.pictureBox_Display.TabIndex = 0;
            this.pictureBox_Display.TabStop = false;
            // 
            // pictureBox_Frame_Camera
            // 
            this.pictureBox_Frame_Camera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Frame_Camera.Location = new System.Drawing.Point(9, 6);
            this.pictureBox_Frame_Camera.Name = "pictureBox_Frame_Camera";
            this.pictureBox_Frame_Camera.Size = new System.Drawing.Size(438, 336);
            this.pictureBox_Frame_Camera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Frame_Camera.TabIndex = 3;
            this.pictureBox_Frame_Camera.TabStop = false;
            // 
            // Vision
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label_DateTime);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.tabControl_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vision";
            this.Text = "Machine Vision";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vision_FormClosing);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Auto.ResumeLayout(false);
            this.tabPage_SerialPort.ResumeLayout(false);
            this.tabPage_SerialPort.PerformLayout();
            this.tabPage_Socket.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Socket_Server.ResumeLayout(false);
            this.groupBox_Socket_Server.PerformLayout();
            this.tabPage_Camera.ResumeLayout(false);
            this.tabPage_Camera.PerformLayout();
            this.tabPage_Setting.ResumeLayout(false);
            this.groupBox_Setting_Camera.ResumeLayout(false);
            this.groupBox_Setting_Camera.PerformLayout();
            this.groupBox_Setting_Client.ResumeLayout(false);
            this.groupBox_Setting_Client.PerformLayout();
            this.groupBox_Setting_Server.ResumeLayout(false);
            this.groupBox_Setting_Server.PerformLayout();
            this.groupBox_Setting_COM.ResumeLayout(false);
            this.groupBox_Setting_COM.PerformLayout();
            this.tabPage_Log.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Frame_Camera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Auto;
        private System.Windows.Forms.TabPage tabPage_Manual;
        private System.Windows.Forms.TabPage tabPage_SerialPort;
        private System.Windows.Forms.TabPage tabPage_Socket;
        private System.Windows.Forms.TabPage tabPage_Camera;
        private System.Windows.Forms.TabPage tabPage_Setting;
        private System.Windows.Forms.TabPage tabPage_Log;
        private System.Windows.Forms.ListBox listBox_COM_Log;
        private System.Windows.Forms.ListBox listBox_COM_Receive;
        private System.Windows.Forms.Button button_COM_Send;
        private System.Windows.Forms.TextBox textBox_COM_Data2Send;
        private System.Windows.Forms.ComboBox comboBox_ListComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_COM_Connect;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Label label_DateTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Client_Port;
        private System.Windows.Forms.TextBox textBox_Client_Ip;
        private System.Windows.Forms.Button button_Client_Send;
        private System.Windows.Forms.Button button_Client_Connect;
        private System.Windows.Forms.TextBox textBox_Client_Send;
        private System.Windows.Forms.ListBox listBox_Client_Receive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox_Socket_Server;
        private System.Windows.Forms.TextBox textBox_Server_Port;
        private System.Windows.Forms.TextBox textBox_Server_Ip;
        private System.Windows.Forms.Button button_Server_Send;
        private System.Windows.Forms.Button button_Server_Open;
        private System.Windows.Forms.TextBox textBox_Server_Send;
        private System.Windows.Forms.ListBox listBox_Server_Receive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_Datetime;
        private System.Windows.Forms.PictureBox pictureBox_Frame_Camera;
        private System.Windows.Forms.Button button_Camera_Connect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Cam_URL;
        private System.Windows.Forms.ListBox listBox_Camera_Log;
        private System.Windows.Forms.Label label_Nunber_NG;
        private System.Windows.Forms.Label label_Number_OK;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.PictureBox pictureBox_Display;
        private System.Windows.Forms.GroupBox groupBox_Setting_Camera;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_Setting_Camera_Flip;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_Setting_Camera_Height;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_Setting_Camera_Width;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Setting_Camera_Fps;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_Setting_Camera_URL;
        private System.Windows.Forms.GroupBox groupBox_Setting_Client;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Setting_Client_Port;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_Setting_Client_Ip;
        private System.Windows.Forms.GroupBox groupBox_Setting_Server;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Setting_Server_Port;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Setting_Server_Ip;
        private System.Windows.Forms.GroupBox groupBox_Setting_COM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Setting_Baudrate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Setting_Comport;
        private System.Windows.Forms.ListBox listBox_Log_System;
        private System.Windows.Forms.Button button_Test_Cam_Basler;
        private System.Windows.Forms.Label label_Comport_status;
        private System.Windows.Forms.TabPage tabPage_Help;
        private System.Windows.Forms.TabPage tabPage_About;
        private System.Windows.Forms.ListBox listBox_ListClient;
    }
}

