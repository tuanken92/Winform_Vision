﻿
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
            this.panelISDisplay = new System.Windows.Forms.Panel();
            this.CvsInSightDisplay2 = new Cognex.InSight.Controls.Display.CvsInSightDisplay();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxPLC = new System.Windows.Forms.ListBox();
            this.contextMenuStripPLCListbox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblGridOpacityValue = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.chkLive = new System.Windows.Forms.CheckBox();
            this.hScrollOpacity = new System.Windows.Forms.HScrollBar();
            this.chkUsePLC = new System.Windows.Forms.CheckBox();
            this.chkGrid = new System.Windows.Forms.CheckBox();
            this.grpImageZoom = new System.Windows.Forms.GroupBox();
            this.optFill = new System.Windows.Forms.RadioButton();
            this.optFit = new System.Windows.Forms.RadioButton();
            this.optNone = new System.Windows.Forms.RadioButton();
            this.chkUseCam = new System.Windows.Forms.CheckBox();
            this.chkOnline = new System.Windows.Forms.CheckBox();
            this.chkSaveImage = new System.Windows.Forms.CheckBox();
            this.chkImage = new System.Windows.Forms.CheckBox();
            this.chkGraphics = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TriggerCamButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.NGLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.OKLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.tabPage_Setting = new System.Windows.Forms.TabPage();
            this.button_SaveParam = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OpenFolderTextButton = new System.Windows.Forms.Button();
            this.FolderTextFileButton = new System.Windows.Forms.Button();
            this.OpenFolderImageButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.FolderImageFileButton = new System.Windows.Forms.Button();
            this.PathTxtFileTextbox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.PathImageFileTextbox = new System.Windows.Forms.TextBox();
            this.groupBox_Setting_Camera = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.PassCameraTextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.UserCameraTextbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.IPCameraTextbox = new System.Windows.Forms.TextBox();
            this.groupBox_Setting_Server = new System.Windows.Forms.GroupBox();
            this.ReadM100Button = new System.Windows.Forms.Button();
            this.M100Checkbox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultPLCTextbox = new System.Windows.Forms.TextBox();
            this.YPLCTextbox = new System.Windows.Forms.TextBox();
            this.PositionPLCTextbox = new System.Windows.Forms.TextBox();
            this.XPLCTextbox = new System.Windows.Forms.TextBox();
            this.TriggerPLCTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AnglePLCTextbox = new System.Windows.Forms.TextBox();
            this.portPLCTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IPPLCTextbox = new System.Windows.Forms.TextBox();
            this.tabPage_About = new System.Windows.Forms.TabPage();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_DateTime = new System.Windows.Forms.Label();
            this.timer_Datetime = new System.Windows.Forms.Timer(this.components);
            this.StatusBar1 = new System.Windows.Forms.StatusBar();
            this.lblState = new System.Windows.Forms.StatusBarPanel();
            this.lblStatus = new System.Windows.Forms.StatusBarPanel();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.folderBrowserDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPageLineScan = new System.Windows.Forms.TabPage();
            this.Display_Image = new System.Windows.Forms.PictureBox();
            this.btnMergeImage = new System.Windows.Forms.Button();
            this.NumberRow_nbup = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnStartThread = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Width_nbup = new System.Windows.Forms.NumericUpDown();
            this.Height_nbup = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.btnStopThread = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Auto.SuspendLayout();
            this.panelISDisplay.SuspendLayout();
            this.panelBot.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStripPLCListbox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grpImageZoom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage_Setting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Setting_Camera.SuspendLayout();
            this.groupBox_Setting_Server.SuspendLayout();
            this.tabPage_About.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.tabPageLineScan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Display_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRow_nbup)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Width_nbup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height_nbup)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Main.Controls.Add(this.tabPage_Auto);
            this.tabControl_Main.Controls.Add(this.tabPage_Setting);
            this.tabControl_Main.Controls.Add(this.tabPage_About);
            this.tabControl_Main.Controls.Add(this.tabPageLineScan);
            this.tabControl_Main.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Main.ItemSize = new System.Drawing.Size(65, 50);
            this.tabControl_Main.Location = new System.Drawing.Point(-1, 66);
            this.tabControl_Main.Multiline = true;
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.ShowToolTips = true;
            this.tabControl_Main.Size = new System.Drawing.Size(870, 573);
            this.tabControl_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_Main.TabIndex = 0;
            // 
            // tabPage_Auto
            // 
            this.tabPage_Auto.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Auto.Controls.Add(this.panelISDisplay);
            this.tabPage_Auto.Controls.Add(this.panelBot);
            this.tabPage_Auto.Controls.Add(this.panel1);
            this.tabPage_Auto.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Auto.Name = "tabPage_Auto";
            this.tabPage_Auto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Auto.Size = new System.Drawing.Size(862, 515);
            this.tabPage_Auto.TabIndex = 0;
            this.tabPage_Auto.Text = "Main";
            // 
            // panelISDisplay
            // 
            this.panelISDisplay.Controls.Add(this.CvsInSightDisplay2);
            this.panelISDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelISDisplay.Location = new System.Drawing.Point(3, 3);
            this.panelISDisplay.Name = "panelISDisplay";
            this.panelISDisplay.Size = new System.Drawing.Size(715, 392);
            this.panelISDisplay.TabIndex = 43;
            // 
            // CvsInSightDisplay2
            // 
            this.CvsInSightDisplay2.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional;
            this.CvsInSightDisplay2.DialogIcon = null;
            this.CvsInSightDisplay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CvsInSightDisplay2.Location = new System.Drawing.Point(0, 0);
            this.CvsInSightDisplay2.Name = "CvsInSightDisplay2";
            this.CvsInSightDisplay2.PreferredCropScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplayCropScaleMode.Default;
            this.CvsInSightDisplay2.Size = new System.Drawing.Size(715, 392);
            this.CvsInSightDisplay2.TabIndex = 7;
            // 
            // panelBot
            // 
            this.panelBot.Controls.Add(this.panel3);
            this.panelBot.Controls.Add(this.panel4);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(3, 395);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(715, 117);
            this.panelBot.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBoxPLC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 117);
            this.panel3.TabIndex = 1;
            // 
            // listBoxPLC
            // 
            this.listBoxPLC.ContextMenuStrip = this.contextMenuStripPLCListbox;
            this.listBoxPLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPLC.FormattingEnabled = true;
            this.listBoxPLC.Location = new System.Drawing.Point(0, 0);
            this.listBoxPLC.Name = "listBoxPLC";
            this.listBoxPLC.Size = new System.Drawing.Size(357, 117);
            this.listBoxPLC.TabIndex = 7;
            // 
            // contextMenuStripPLCListbox
            // 
            this.contextMenuStripPLCListbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStripPLCListbox.Name = "contextMenuStripPLCListbox";
            this.contextMenuStripPLCListbox.Size = new System.Drawing.Size(102, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblGridOpacityValue);
            this.panel4.Controls.Add(this.Label4);
            this.panel4.Controls.Add(this.chkLive);
            this.panel4.Controls.Add(this.hScrollOpacity);
            this.panel4.Controls.Add(this.chkUsePLC);
            this.panel4.Controls.Add(this.chkGrid);
            this.panel4.Controls.Add(this.grpImageZoom);
            this.panel4.Controls.Add(this.chkUseCam);
            this.panel4.Controls.Add(this.chkOnline);
            this.panel4.Controls.Add(this.chkSaveImage);
            this.panel4.Controls.Add(this.chkImage);
            this.panel4.Controls.Add(this.chkGraphics);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(357, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 117);
            this.panel4.TabIndex = 0;
            // 
            // lblGridOpacityValue
            // 
            this.lblGridOpacityValue.Location = new System.Drawing.Point(302, 96);
            this.lblGridOpacityValue.Name = "lblGridOpacityValue";
            this.lblGridOpacityValue.Size = new System.Drawing.Size(40, 16);
            this.lblGridOpacityValue.TabIndex = 53;
            this.lblGridOpacityValue.Text = "75%";
            this.lblGridOpacityValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(132, 78);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(75, 16);
            this.Label4.TabIndex = 52;
            this.Label4.Text = "Grid Opacity:";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkLive
            // 
            this.chkLive.Location = new System.Drawing.Point(17, 11);
            this.chkLive.Name = "chkLive";
            this.chkLive.Size = new System.Drawing.Size(80, 16);
            this.chkLive.TabIndex = 47;
            this.chkLive.Text = "Live";
            // 
            // hScrollOpacity
            // 
            this.hScrollOpacity.Location = new System.Drawing.Point(135, 96);
            this.hScrollOpacity.Name = "hScrollOpacity";
            this.hScrollOpacity.Size = new System.Drawing.Size(152, 16);
            this.hScrollOpacity.TabIndex = 51;
            this.hScrollOpacity.Value = 75;
            // 
            // chkUsePLC
            // 
            this.chkUsePLC.Location = new System.Drawing.Point(17, 95);
            this.chkUsePLC.Name = "chkUsePLC";
            this.chkUsePLC.Size = new System.Drawing.Size(97, 17);
            this.chkUsePLC.TabIndex = 45;
            this.chkUsePLC.Text = "Use PLC";
            // 
            // chkGrid
            // 
            this.chkGrid.Location = new System.Drawing.Point(17, 53);
            this.chkGrid.Name = "chkGrid";
            this.chkGrid.Size = new System.Drawing.Size(112, 16);
            this.chkGrid.TabIndex = 45;
            this.chkGrid.Text = "Show Grid";
            // 
            // grpImageZoom
            // 
            this.grpImageZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpImageZoom.Controls.Add(this.optFill);
            this.grpImageZoom.Controls.Add(this.optFit);
            this.grpImageZoom.Controls.Add(this.optNone);
            this.grpImageZoom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpImageZoom.Location = new System.Drawing.Point(259, 6);
            this.grpImageZoom.Name = "grpImageZoom";
            this.grpImageZoom.Size = new System.Drawing.Size(83, 86);
            this.grpImageZoom.TabIndex = 50;
            this.grpImageZoom.TabStop = false;
            this.grpImageZoom.Text = "Image Zoom";
            // 
            // optFill
            // 
            this.optFill.Location = new System.Drawing.Point(13, 58);
            this.optFill.Name = "optFill";
            this.optFill.Size = new System.Drawing.Size(40, 16);
            this.optFill.TabIndex = 2;
            this.optFill.Text = "Fill";
            // 
            // optFit
            // 
            this.optFit.Location = new System.Drawing.Point(13, 37);
            this.optFit.Name = "optFit";
            this.optFit.Size = new System.Drawing.Size(40, 16);
            this.optFit.TabIndex = 1;
            this.optFit.Text = "Fit";
            // 
            // optNone
            // 
            this.optNone.Location = new System.Drawing.Point(13, 16);
            this.optNone.Name = "optNone";
            this.optNone.Size = new System.Drawing.Size(48, 16);
            this.optNone.TabIndex = 0;
            this.optNone.Text = "None";
            // 
            // chkUseCam
            // 
            this.chkUseCam.Location = new System.Drawing.Point(17, 74);
            this.chkUseCam.Name = "chkUseCam";
            this.chkUseCam.Size = new System.Drawing.Size(97, 16);
            this.chkUseCam.TabIndex = 46;
            this.chkUseCam.Text = "Use Camera";
            // 
            // chkOnline
            // 
            this.chkOnline.Location = new System.Drawing.Point(17, 32);
            this.chkOnline.Name = "chkOnline";
            this.chkOnline.Size = new System.Drawing.Size(112, 16);
            this.chkOnline.TabIndex = 46;
            this.chkOnline.Text = "Online";
            // 
            // chkSaveImage
            // 
            this.chkSaveImage.Location = new System.Drawing.Point(135, 57);
            this.chkSaveImage.Name = "chkSaveImage";
            this.chkSaveImage.Size = new System.Drawing.Size(112, 20);
            this.chkSaveImage.TabIndex = 49;
            this.chkSaveImage.Text = "Save Image";
            // 
            // chkImage
            // 
            this.chkImage.Location = new System.Drawing.Point(135, 33);
            this.chkImage.Name = "chkImage";
            this.chkImage.Size = new System.Drawing.Size(112, 20);
            this.chkImage.TabIndex = 49;
            this.chkImage.Text = "Show Image";
            // 
            // chkGraphics
            // 
            this.chkGraphics.Location = new System.Drawing.Point(135, 9);
            this.chkGraphics.Name = "chkGraphics";
            this.chkGraphics.Size = new System.Drawing.Size(112, 20);
            this.chkGraphics.TabIndex = 48;
            this.chkGraphics.Text = "Show Graphics";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TriggerCamButton);
            this.panel1.Controls.Add(this.ResultLabel);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Controls.Add(this.NGLabel);
            this.panel1.Controls.Add(this.StopButton);
            this.panel1.Controls.Add(this.OKLabel);
            this.panel1.Controls.Add(this.ResetButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(718, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 509);
            this.panel1.TabIndex = 40;
            // 
            // TriggerCamButton
            // 
            this.TriggerCamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TriggerCamButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TriggerCamButton.Image = global::Winform_Vision.Properties.Resources.Log_On;
            this.TriggerCamButton.Location = new System.Drawing.Point(6, 359);
            this.TriggerCamButton.Name = "TriggerCamButton";
            this.TriggerCamButton.Size = new System.Drawing.Size(130, 32);
            this.TriggerCamButton.TabIndex = 50;
            this.TriggerCamButton.Text = "   Trigger";
            this.TriggerCamButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TriggerCamButton.UseVisualStyleBackColor = true;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultLabel.BackColor = System.Drawing.Color.Green;
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.White;
            this.ResultLabel.Location = new System.Drawing.Point(6, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(131, 111);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "RESULT";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.Green;
            this.StartButton.Location = new System.Drawing.Point(6, 398);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(130, 32);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // NGLabel
            // 
            this.NGLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NGLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NGLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NGLabel.Location = new System.Drawing.Point(6, 158);
            this.NGLabel.Name = "NGLabel";
            this.NGLabel.Size = new System.Drawing.Size(130, 29);
            this.NGLabel.TabIndex = 6;
            this.NGLabel.Text = "NG";
            this.NGLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StopButton.Location = new System.Drawing.Point(6, 434);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(130, 32);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // OKLabel
            // 
            this.OKLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OKLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OKLabel.Location = new System.Drawing.Point(6, 123);
            this.OKLabel.Name = "OKLabel";
            this.OKLabel.Size = new System.Drawing.Size(130, 29);
            this.OKLabel.TabIndex = 5;
            this.OKLabel.Text = "OK";
            this.OKLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ResetButton.Location = new System.Drawing.Point(6, 472);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(130, 32);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "RESET";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // tabPage_Setting
            // 
            this.tabPage_Setting.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Setting.Controls.Add(this.button_SaveParam);
            this.tabPage_Setting.Controls.Add(this.groupBox1);
            this.tabPage_Setting.Controls.Add(this.groupBox_Setting_Camera);
            this.tabPage_Setting.Controls.Add(this.groupBox_Setting_Server);
            this.tabPage_Setting.Location = new System.Drawing.Point(4, 4);
            this.tabPage_Setting.Name = "tabPage_Setting";
            this.tabPage_Setting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Setting.Size = new System.Drawing.Size(862, 515);
            this.tabPage_Setting.TabIndex = 5;
            this.tabPage_Setting.Text = "Setting";
            // 
            // button_SaveParam
            // 
            this.button_SaveParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SaveParam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_SaveParam.Location = new System.Drawing.Point(704, 455);
            this.button_SaveParam.Name = "button_SaveParam";
            this.button_SaveParam.Size = new System.Drawing.Size(152, 54);
            this.button_SaveParam.TabIndex = 7;
            this.button_SaveParam.Text = "SAVE";
            this.button_SaveParam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_SaveParam.UseVisualStyleBackColor = true;
            this.button_SaveParam.Click += new System.EventHandler(this.button_SaveParam_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpenFolderTextButton);
            this.groupBox1.Controls.Add(this.FolderTextFileButton);
            this.groupBox1.Controls.Add(this.OpenFolderImageButton);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.FolderImageFileButton);
            this.groupBox1.Controls.Add(this.PathTxtFileTextbox);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.PathImageFileTextbox);
            this.groupBox1.Location = new System.Drawing.Point(224, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 118);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // OpenFolderTextButton
            // 
            this.OpenFolderTextButton.Location = new System.Drawing.Point(549, 48);
            this.OpenFolderTextButton.Name = "OpenFolderTextButton";
            this.OpenFolderTextButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFolderTextButton.TabIndex = 6;
            this.OpenFolderTextButton.Text = "Open";
            this.OpenFolderTextButton.UseVisualStyleBackColor = true;
            this.OpenFolderTextButton.Click += new System.EventHandler(this.OpenFolderTextButton_Click);
            // 
            // FolderTextFileButton
            // 
            this.FolderTextFileButton.Location = new System.Drawing.Point(469, 49);
            this.FolderTextFileButton.Name = "FolderTextFileButton";
            this.FolderTextFileButton.Size = new System.Drawing.Size(75, 23);
            this.FolderTextFileButton.TabIndex = 6;
            this.FolderTextFileButton.Text = "Change";
            this.FolderTextFileButton.UseVisualStyleBackColor = true;
            this.FolderTextFileButton.Click += new System.EventHandler(this.FolderTextFileButton_Click);
            // 
            // OpenFolderImageButton
            // 
            this.OpenFolderImageButton.Location = new System.Drawing.Point(549, 15);
            this.OpenFolderImageButton.Name = "OpenFolderImageButton";
            this.OpenFolderImageButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFolderImageButton.TabIndex = 6;
            this.OpenFolderImageButton.Text = "Open";
            this.OpenFolderImageButton.UseVisualStyleBackColor = true;
            this.OpenFolderImageButton.Click += new System.EventHandler(this.OpenFolderImageButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Text File";
            // 
            // FolderImageFileButton
            // 
            this.FolderImageFileButton.Location = new System.Drawing.Point(469, 16);
            this.FolderImageFileButton.Name = "FolderImageFileButton";
            this.FolderImageFileButton.Size = new System.Drawing.Size(75, 23);
            this.FolderImageFileButton.TabIndex = 6;
            this.FolderImageFileButton.Text = "Change";
            this.FolderImageFileButton.UseVisualStyleBackColor = true;
            this.FolderImageFileButton.Click += new System.EventHandler(this.FolderImageFileButton_Click);
            // 
            // PathTxtFileTextbox
            // 
            this.PathTxtFileTextbox.Location = new System.Drawing.Point(89, 50);
            this.PathTxtFileTextbox.Name = "PathTxtFileTextbox";
            this.PathTxtFileTextbox.Size = new System.Drawing.Size(374, 20);
            this.PathTxtFileTextbox.TabIndex = 0;
            this.PathTxtFileTextbox.Text = "...";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Image File";
            // 
            // PathImageFileTextbox
            // 
            this.PathImageFileTextbox.Location = new System.Drawing.Point(89, 17);
            this.PathImageFileTextbox.Name = "PathImageFileTextbox";
            this.PathImageFileTextbox.Size = new System.Drawing.Size(374, 20);
            this.PathImageFileTextbox.TabIndex = 0;
            this.PathImageFileTextbox.Text = "...";
            // 
            // groupBox_Setting_Camera
            // 
            this.groupBox_Setting_Camera.Controls.Add(this.label15);
            this.groupBox_Setting_Camera.Controls.Add(this.PassCameraTextbox);
            this.groupBox_Setting_Camera.Controls.Add(this.label13);
            this.groupBox_Setting_Camera.Controls.Add(this.UserCameraTextbox);
            this.groupBox_Setting_Camera.Controls.Add(this.label14);
            this.groupBox_Setting_Camera.Controls.Add(this.IPCameraTextbox);
            this.groupBox_Setting_Camera.Location = new System.Drawing.Point(9, 132);
            this.groupBox_Setting_Camera.Name = "groupBox_Setting_Camera";
            this.groupBox_Setting_Camera.Size = new System.Drawing.Size(200, 118);
            this.groupBox_Setting_Camera.TabIndex = 6;
            this.groupBox_Setting_Camera.TabStop = false;
            this.groupBox_Setting_Camera.Text = "Camera";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Pass";
            // 
            // PassCameraTextbox
            // 
            this.PassCameraTextbox.Location = new System.Drawing.Point(91, 78);
            this.PassCameraTextbox.Name = "PassCameraTextbox";
            this.PassCameraTextbox.Size = new System.Drawing.Size(100, 20);
            this.PassCameraTextbox.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "User";
            // 
            // UserCameraTextbox
            // 
            this.UserCameraTextbox.Location = new System.Drawing.Point(91, 48);
            this.UserCameraTextbox.Name = "UserCameraTextbox";
            this.UserCameraTextbox.Size = new System.Drawing.Size(100, 20);
            this.UserCameraTextbox.TabIndex = 2;
            this.UserCameraTextbox.Text = "admin";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Name";
            // 
            // IPCameraTextbox
            // 
            this.IPCameraTextbox.Location = new System.Drawing.Point(91, 17);
            this.IPCameraTextbox.Name = "IPCameraTextbox";
            this.IPCameraTextbox.Size = new System.Drawing.Size(100, 20);
            this.IPCameraTextbox.TabIndex = 0;
            this.IPCameraTextbox.Text = "192.168.3.192";
            // 
            // groupBox_Setting_Server
            // 
            this.groupBox_Setting_Server.Controls.Add(this.ReadM100Button);
            this.groupBox_Setting_Server.Controls.Add(this.M100Checkbox);
            this.groupBox_Setting_Server.Controls.Add(this.label12);
            this.groupBox_Setting_Server.Controls.Add(this.label2);
            this.groupBox_Setting_Server.Controls.Add(this.label3);
            this.groupBox_Setting_Server.Controls.Add(this.label11);
            this.groupBox_Setting_Server.Controls.Add(this.label8);
            this.groupBox_Setting_Server.Controls.Add(this.label1);
            this.groupBox_Setting_Server.Controls.Add(this.ResultPLCTextbox);
            this.groupBox_Setting_Server.Controls.Add(this.YPLCTextbox);
            this.groupBox_Setting_Server.Controls.Add(this.PositionPLCTextbox);
            this.groupBox_Setting_Server.Controls.Add(this.XPLCTextbox);
            this.groupBox_Setting_Server.Controls.Add(this.TriggerPLCTextbox);
            this.groupBox_Setting_Server.Controls.Add(this.label9);
            this.groupBox_Setting_Server.Controls.Add(this.AnglePLCTextbox);
            this.groupBox_Setting_Server.Controls.Add(this.portPLCTextbox);
            this.groupBox_Setting_Server.Controls.Add(this.label10);
            this.groupBox_Setting_Server.Controls.Add(this.IPPLCTextbox);
            this.groupBox_Setting_Server.Location = new System.Drawing.Point(9, 6);
            this.groupBox_Setting_Server.Name = "groupBox_Setting_Server";
            this.groupBox_Setting_Server.Size = new System.Drawing.Size(847, 120);
            this.groupBox_Setting_Server.TabIndex = 4;
            this.groupBox_Setting_Server.TabStop = false;
            this.groupBox_Setting_Server.Text = "PLC";
            // 
            // ReadM100Button
            // 
            this.ReadM100Button.Location = new System.Drawing.Point(734, 89);
            this.ReadM100Button.Name = "ReadM100Button";
            this.ReadM100Button.Size = new System.Drawing.Size(107, 23);
            this.ReadM100Button.TabIndex = 7;
            this.ReadM100Button.Text = "Read M100";
            this.ReadM100Button.UseVisualStyleBackColor = true;
            this.ReadM100Button.Click += new System.EventHandler(this.ReadM100Button_Click);
            // 
            // M100Checkbox
            // 
            this.M100Checkbox.AutoSize = true;
            this.M100Checkbox.Location = new System.Drawing.Point(666, 95);
            this.M100Checkbox.Name = "M100Checkbox";
            this.M100Checkbox.Size = new System.Drawing.Size(53, 17);
            this.M100Checkbox.TabIndex = 6;
            this.M100Checkbox.Text = "M100";
            this.M100Checkbox.UseVisualStyleBackColor = true;
            this.M100Checkbox.CheckedChanged += new System.EventHandler(this.M100Checkbox_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(638, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Position";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(446, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Angle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(638, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trigger";
            // 
            // ResultPLCTextbox
            // 
            this.ResultPLCTextbox.Location = new System.Drawing.Point(304, 50);
            this.ResultPLCTextbox.Name = "ResultPLCTextbox";
            this.ResultPLCTextbox.Size = new System.Drawing.Size(100, 20);
            this.ResultPLCTextbox.TabIndex = 4;
            // 
            // YPLCTextbox
            // 
            this.YPLCTextbox.Location = new System.Drawing.Point(684, 48);
            this.YPLCTextbox.Name = "YPLCTextbox";
            this.YPLCTextbox.Size = new System.Drawing.Size(100, 20);
            this.YPLCTextbox.TabIndex = 4;
            // 
            // PositionPLCTextbox
            // 
            this.PositionPLCTextbox.Location = new System.Drawing.Point(492, 18);
            this.PositionPLCTextbox.Name = "PositionPLCTextbox";
            this.PositionPLCTextbox.Size = new System.Drawing.Size(100, 20);
            this.PositionPLCTextbox.TabIndex = 4;
            // 
            // XPLCTextbox
            // 
            this.XPLCTextbox.Location = new System.Drawing.Point(684, 16);
            this.XPLCTextbox.Name = "XPLCTextbox";
            this.XPLCTextbox.Size = new System.Drawing.Size(100, 20);
            this.XPLCTextbox.TabIndex = 4;
            // 
            // TriggerPLCTextbox
            // 
            this.TriggerPLCTextbox.Location = new System.Drawing.Point(304, 18);
            this.TriggerPLCTextbox.Name = "TriggerPLCTextbox";
            this.TriggerPLCTextbox.Size = new System.Drawing.Size(100, 20);
            this.TriggerPLCTextbox.TabIndex = 4;
            this.TriggerPLCTextbox.Text = "D1000";
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
            // AnglePLCTextbox
            // 
            this.AnglePLCTextbox.Location = new System.Drawing.Point(492, 48);
            this.AnglePLCTextbox.Name = "AnglePLCTextbox";
            this.AnglePLCTextbox.Size = new System.Drawing.Size(100, 20);
            this.AnglePLCTextbox.TabIndex = 4;
            // 
            // portPLCTextbox
            // 
            this.portPLCTextbox.Location = new System.Drawing.Point(92, 48);
            this.portPLCTextbox.Name = "portPLCTextbox";
            this.portPLCTextbox.Size = new System.Drawing.Size(100, 20);
            this.portPLCTextbox.TabIndex = 2;
            this.portPLCTextbox.Text = "12222";
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
            // IPPLCTextbox
            // 
            this.IPPLCTextbox.Location = new System.Drawing.Point(91, 18);
            this.IPPLCTextbox.Name = "IPPLCTextbox";
            this.IPPLCTextbox.Size = new System.Drawing.Size(100, 20);
            this.IPPLCTextbox.TabIndex = 0;
            this.IPPLCTextbox.Text = "192.168.3.222";
            // 
            // tabPage_About
            // 
            this.tabPage_About.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_About.Controls.Add(this.panelTitle);
            this.tabPage_About.Location = new System.Drawing.Point(4, 4);
            this.tabPage_About.Name = "tabPage_About";
            this.tabPage_About.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_About.Size = new System.Drawing.Size(862, 515);
            this.tabPage_About.TabIndex = 8;
            this.tabPage_About.Text = "About";
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.label5);
            this.panelTitle.Controls.Add(this.label6);
            this.panelTitle.Controls.Add(this.label7);
            this.panelTitle.Controls.Add(this.label_address);
            this.panelTitle.Controls.Add(this.lb_title);
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(3, 3);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(856, 124);
            this.panelTitle.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(87)))), ((int)(((byte)(162)))));
            this.label5.Location = new System.Drawing.Point(644, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email: infor@tanhungha.com.vn";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(87)))), ((int)(((byte)(162)))));
            this.label6.Location = new System.Drawing.Point(729, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tel: 0432.127.673";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(87)))), ((int)(((byte)(162)))));
            this.label7.Location = new System.Drawing.Point(626, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Website: https://tanhungha.com.vn";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_address
            // 
            this.label_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(87)))), ((int)(((byte)(162)))));
            this.label_address.Location = new System.Drawing.Point(590, 34);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(263, 17);
            this.label_address.TabIndex = 1;
            this.label_address.Text = "302 Phú Viên, Bồ Đề, Long Biên, Hà Nội";
            this.label_address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_title
            // 
            this.lb_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(87)))), ((int)(((byte)(162)))));
            this.lb_title.Location = new System.Drawing.Point(290, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(563, 20);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "CÔNG TY TNHH THƯƠNG MẠI & DỊCH VỤ TỔNG HỢP TÂN HƯNG HÀ";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Winform_Vision.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_Title
            // 
            this.label_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(871, 63);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Machine Vision - Demo";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_DateTime
            // 
            this.label_DateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_DateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.label_DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DateTime.ForeColor = System.Drawing.Color.White;
            this.label_DateTime.Location = new System.Drawing.Point(721, 0);
            this.label_DateTime.Name = "label_DateTime";
            this.label_DateTime.Size = new System.Drawing.Size(150, 63);
            this.label_DateTime.TabIndex = 3;
            this.label_DateTime.Text = "Date-Time";
            this.label_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_Datetime
            // 
            this.timer_Datetime.Interval = 1000;
            // 
            // StatusBar1
            // 
            this.StatusBar1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBar1.Location = new System.Drawing.Point(0, 645);
            this.StatusBar1.Name = "StatusBar1";
            this.StatusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.lblState,
            this.lblStatus});
            this.StatusBar1.ShowPanels = true;
            this.StatusBar1.Size = new System.Drawing.Size(871, 16);
            this.StatusBar1.TabIndex = 22;
            // 
            // lblState
            // 
            this.lblState.Name = "lblState";
            this.lblState.Width = 200;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Width = 654;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.pictureBox_Logo.Image = global::Winform_Vision.Properties.Resources.logo;
            this.pictureBox_Logo.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(169, 63);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 2;
            this.pictureBox_Logo.TabStop = false;
            // 
            // tabPageLineScan
            // 
            this.tabPageLineScan.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageLineScan.Controls.Add(this.groupBox3);
            this.tabPageLineScan.Controls.Add(this.groupBox2);
            this.tabPageLineScan.Controls.Add(this.listBox1);
            this.tabPageLineScan.Controls.Add(this.btnClearLog);
            this.tabPageLineScan.Controls.Add(this.Display_Image);
            this.tabPageLineScan.Location = new System.Drawing.Point(4, 4);
            this.tabPageLineScan.Name = "tabPageLineScan";
            this.tabPageLineScan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLineScan.Size = new System.Drawing.Size(862, 515);
            this.tabPageLineScan.TabIndex = 9;
            this.tabPageLineScan.Text = "LineScan";
            // 
            // Display_Image
            // 
            this.Display_Image.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Display_Image.Location = new System.Drawing.Point(6, 6);
            this.Display_Image.Name = "Display_Image";
            this.Display_Image.Size = new System.Drawing.Size(490, 394);
            this.Display_Image.TabIndex = 0;
            this.Display_Image.TabStop = false;
            // 
            // btnMergeImage
            // 
            this.btnMergeImage.Location = new System.Drawing.Point(183, 13);
            this.btnMergeImage.Name = "btnMergeImage";
            this.btnMergeImage.Size = new System.Drawing.Size(112, 34);
            this.btnMergeImage.TabIndex = 1;
            this.btnMergeImage.Text = "Merge Image";
            this.btnMergeImage.UseVisualStyleBackColor = true;
            // 
            // NumberRow_nbup
            // 
            this.NumberRow_nbup.Location = new System.Drawing.Point(81, 22);
            this.NumberRow_nbup.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumberRow_nbup.Name = "NumberRow_nbup";
            this.NumberRow_nbup.Size = new System.Drawing.Size(76, 20);
            this.NumberRow_nbup.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Number row";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(502, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(354, 251);
            this.listBox1.TabIndex = 4;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(797, 263);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(59, 34);
            this.btnClearLog.TabIndex = 1;
            this.btnClearLog.Text = "Clear";
            this.btnClearLog.UseVisualStyleBackColor = true;
            // 
            // btnStartThread
            // 
            this.btnStartThread.Location = new System.Drawing.Point(204, 26);
            this.btnStartThread.Name = "btnStartThread";
            this.btnStartThread.Size = new System.Drawing.Size(57, 34);
            this.btnStartThread.TabIndex = 1;
            this.btnStartThread.Text = "Start";
            this.btnStartThread.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.btnStopThread);
            this.groupBox2.Controls.Add(this.btnStartThread);
            this.groupBox2.Controls.Add(this.Height_nbup);
            this.groupBox2.Controls.Add(this.Width_nbup);
            this.groupBox2.Location = new System.Drawing.Point(506, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Row Data";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Width";
            // 
            // Width_nbup
            // 
            this.Width_nbup.Location = new System.Drawing.Point(66, 19);
            this.Width_nbup.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.Width_nbup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Width_nbup.Name = "Width_nbup";
            this.Width_nbup.Size = new System.Drawing.Size(76, 20);
            this.Width_nbup.TabIndex = 2;
            this.Width_nbup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Height_nbup
            // 
            this.Height_nbup.Location = new System.Drawing.Point(66, 45);
            this.Height_nbup.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.Height_nbup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Height_nbup.Name = "Height_nbup";
            this.Height_nbup.Size = new System.Drawing.Size(76, 20);
            this.Height_nbup.TabIndex = 2;
            this.Height_nbup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Height";
            // 
            // btnStopThread
            // 
            this.btnStopThread.Location = new System.Drawing.Point(276, 26);
            this.btnStopThread.Name = "btnStopThread";
            this.btnStopThread.Size = new System.Drawing.Size(57, 34);
            this.btnStopThread.TabIndex = 1;
            this.btnStopThread.Text = "Stop";
            this.btnStopThread.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.NumberRow_nbup);
            this.groupBox3.Controls.Add(this.btnMergeImage);
            this.groupBox3.Location = new System.Drawing.Point(90, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 54);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // Vision
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(871, 661);
            this.Controls.Add(this.StatusBar1);
            this.Controls.Add(this.label_DateTime);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.tabControl_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vision";
            this.Text = "Machine Vision";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vision_FormClosing);
            this.Load += new System.EventHandler(this.Vision_Load);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Auto.ResumeLayout(false);
            this.panelISDisplay.ResumeLayout(false);
            this.panelBot.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.contextMenuStripPLCListbox.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.grpImageZoom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage_Setting.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Setting_Camera.ResumeLayout(false);
            this.groupBox_Setting_Camera.PerformLayout();
            this.groupBox_Setting_Server.ResumeLayout(false);
            this.groupBox_Setting_Server.PerformLayout();
            this.tabPage_About.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.tabPageLineScan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Display_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRow_nbup)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Width_nbup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height_nbup)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Auto;
        private System.Windows.Forms.TabPage tabPage_Setting;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Label label_DateTime;
        private System.Windows.Forms.Timer timer_Datetime;
        private System.Windows.Forms.Label NGLabel;
        private System.Windows.Forms.Label OKLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox groupBox_Setting_Camera;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PassCameraTextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox UserCameraTextbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox IPCameraTextbox;
        private System.Windows.Forms.GroupBox groupBox_Setting_Server;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox portPLCTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IPPLCTextbox;
        private System.Windows.Forms.TabPage tabPage_About;
        private System.Windows.Forms.Button button_SaveParam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResultPLCTextbox;
        private System.Windows.Forms.TextBox PositionPLCTextbox;
        private System.Windows.Forms.TextBox TriggerPLCTextbox;
        internal System.Windows.Forms.StatusBar StatusBar1;
        internal System.Windows.Forms.StatusBarPanel lblState;
        internal System.Windows.Forms.StatusBarPanel lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPLCListbox;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Panel panelISDisplay;
        private Cognex.InSight.Controls.Display.CvsInSightDisplay CvsInSightDisplay2;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBoxPLC;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Label lblGridOpacityValue;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.CheckBox chkLive;
        private System.Windows.Forms.HScrollBar hScrollOpacity;
        internal System.Windows.Forms.CheckBox chkGrid;
        internal System.Windows.Forms.GroupBox grpImageZoom;
        internal System.Windows.Forms.RadioButton optFill;
        internal System.Windows.Forms.RadioButton optFit;
        internal System.Windows.Forms.RadioButton optNone;
        internal System.Windows.Forms.CheckBox chkOnline;
        internal System.Windows.Forms.CheckBox chkImage;
        internal System.Windows.Forms.CheckBox chkGraphics;
        private System.Windows.Forms.Button TriggerCamButton;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox YPLCTextbox;
        private System.Windows.Forms.TextBox XPLCTextbox;
        private System.Windows.Forms.TextBox AnglePLCTextbox;
        private System.Windows.Forms.CheckBox M100Checkbox;
        private System.Windows.Forms.Button ReadM100Button;
        internal System.Windows.Forms.CheckBox chkSaveImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OpenFolderTextButton;
        private System.Windows.Forms.Button FolderTextFileButton;
        private System.Windows.Forms.Button OpenFolderImageButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button FolderImageFileButton;
        private System.Windows.Forms.TextBox PathTxtFileTextbox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox PathImageFileTextbox;
        internal System.Windows.Forms.CheckBox chkUsePLC;
        internal System.Windows.Forms.CheckBox chkUseCam;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDlg;
        private System.Windows.Forms.TabPage tabPageLineScan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnStopThread;
        private System.Windows.Forms.Button btnStartThread;
        private System.Windows.Forms.NumericUpDown Height_nbup;
        private System.Windows.Forms.NumericUpDown Width_nbup;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown NumberRow_nbup;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnMergeImage;
        private System.Windows.Forms.PictureBox Display_Image;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

