namespace WindowsFormsApplication8
{
    partial class Form1
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
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.armControlGroupBox = new System.Windows.Forms.GroupBox();
            this.armControlLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.auxTrackBar = new System.Windows.Forms.TrackBar();
            this.gripperTrackBar = new System.Windows.Forms.TrackBar();
            this.elevationTrackBar = new System.Windows.Forms.TrackBar();
            this.extensionTrackBar = new System.Windows.Forms.TrackBar();
            this.rotationLabel = new System.Windows.Forms.Label();
            this.extensionLabel = new System.Windows.Forms.Label();
            this.elevationLabel = new System.Windows.Forms.Label();
            this.gripperLabel = new System.Windows.Forms.Label();
            this.auxLabel = new System.Windows.Forms.Label();
            this.rotationTrackBar = new System.Windows.Forms.TrackBar();
            this.framesGroupBox = new System.Windows.Forms.GroupBox();
            this.framesListBox = new System.Windows.Forms.ListBox();
            this.connectionControlGroupBox = new System.Windows.Forms.GroupBox();
            this.connectionControlTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.baudRateTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.refreshRate = new System.Windows.Forms.TextBox();
            this.resfreshRateLabel = new System.Windows.Forms.Label();
            this.frameControlGroupBox = new System.Windows.Forms.GroupBox();
            this.FrameControlTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.overwriteButton = new System.Windows.Forms.Button();
            this.newFrameButton = new System.Windows.Forms.Button();
            this.framDurationLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.playbackGroupBox = new System.Windows.Forms.GroupBox();
            this.PlaybackControlTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.stopButton = new System.Windows.Forms.Button();
            this.playFromSelectedButton = new System.Windows.Forms.Button();
            this.playFromTopButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.connectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.arduinoSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.serialTimer = new System.Windows.Forms.Timer(this.components);
            this.mainLayoutPanel.SuspendLayout();
            this.armControlGroupBox.SuspendLayout();
            this.armControlLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gripperTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extensionTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationTrackBar)).BeginInit();
            this.framesGroupBox.SuspendLayout();
            this.connectionControlGroupBox.SuspendLayout();
            this.connectionControlTableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.frameControlGroupBox.SuspendLayout();
            this.FrameControlTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.playbackGroupBox.SuspendLayout();
            this.PlaybackControlTableLayoutPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainLayoutPanel.ColumnCount = 3;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainLayoutPanel.Controls.Add(this.armControlGroupBox, 1, 0);
            this.mainLayoutPanel.Controls.Add(this.framesGroupBox, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.connectionControlGroupBox, 2, 0);
            this.mainLayoutPanel.Controls.Add(this.frameControlGroupBox, 2, 1);
            this.mainLayoutPanel.Controls.Add(this.playbackGroupBox, 2, 2);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.91694F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.86047F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.22259F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(811, 571);
            this.mainLayoutPanel.TabIndex = 2;
            // 
            // armControlGroupBox
            // 
            this.armControlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armControlGroupBox.Controls.Add(this.armControlLayoutPanel);
            this.armControlGroupBox.Location = new System.Drawing.Point(273, 3);
            this.armControlGroupBox.Name = "armControlGroupBox";
            this.mainLayoutPanel.SetRowSpan(this.armControlGroupBox, 3);
            this.armControlGroupBox.Size = new System.Drawing.Size(264, 545);
            this.armControlGroupBox.TabIndex = 1;
            this.armControlGroupBox.TabStop = false;
            this.armControlGroupBox.Text = "Arm Control";
            // 
            // armControlLayoutPanel
            // 
            this.armControlLayoutPanel.AutoSize = true;
            this.armControlLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.armControlLayoutPanel.ColumnCount = 1;
            this.armControlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.armControlLayoutPanel.Controls.Add(this.auxTrackBar, 0, 9);
            this.armControlLayoutPanel.Controls.Add(this.gripperTrackBar, 0, 7);
            this.armControlLayoutPanel.Controls.Add(this.elevationTrackBar, 0, 5);
            this.armControlLayoutPanel.Controls.Add(this.extensionTrackBar, 0, 3);
            this.armControlLayoutPanel.Controls.Add(this.rotationLabel, 0, 0);
            this.armControlLayoutPanel.Controls.Add(this.extensionLabel, 0, 2);
            this.armControlLayoutPanel.Controls.Add(this.elevationLabel, 0, 4);
            this.armControlLayoutPanel.Controls.Add(this.gripperLabel, 0, 6);
            this.armControlLayoutPanel.Controls.Add(this.auxLabel, 0, 8);
            this.armControlLayoutPanel.Controls.Add(this.rotationTrackBar, 0, 1);
            this.armControlLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.armControlLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.armControlLayoutPanel.Name = "armControlLayoutPanel";
            this.armControlLayoutPanel.RowCount = 10;
            this.armControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.armControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.armControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.armControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.armControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.armControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.armControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.armControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.armControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.armControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.armControlLayoutPanel.Size = new System.Drawing.Size(258, 526);
            this.armControlLayoutPanel.TabIndex = 0;
            // 
            // auxTrackBar
            // 
            this.auxTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.auxTrackBar.LargeChange = 20;
            this.auxTrackBar.Location = new System.Drawing.Point(4, 446);
            this.auxTrackBar.Maximum = 100;
            this.auxTrackBar.Name = "auxTrackBar";
            this.auxTrackBar.Size = new System.Drawing.Size(250, 76);
            this.auxTrackBar.TabIndex = 9;
            this.auxTrackBar.TickFrequency = 10;
            this.auxTrackBar.Scroll += new System.EventHandler(this.auxTrackBar_Scroll);
            // 
            // gripperTrackBar
            // 
            this.gripperTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gripperTrackBar.LargeChange = 20;
            this.gripperTrackBar.Location = new System.Drawing.Point(4, 342);
            this.gripperTrackBar.Maximum = 100;
            this.gripperTrackBar.Name = "gripperTrackBar";
            this.gripperTrackBar.Size = new System.Drawing.Size(250, 71);
            this.gripperTrackBar.TabIndex = 8;
            this.gripperTrackBar.TickFrequency = 10;
            this.gripperTrackBar.Scroll += new System.EventHandler(this.gripperTrackBar_Scroll);
            // 
            // elevationTrackBar
            // 
            this.elevationTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elevationTrackBar.LargeChange = 20;
            this.elevationTrackBar.Location = new System.Drawing.Point(4, 238);
            this.elevationTrackBar.Maximum = 100;
            this.elevationTrackBar.Name = "elevationTrackBar";
            this.elevationTrackBar.Size = new System.Drawing.Size(250, 71);
            this.elevationTrackBar.TabIndex = 7;
            this.elevationTrackBar.TickFrequency = 10;
            this.elevationTrackBar.Scroll += new System.EventHandler(this.elevationTrackBar_Scroll);
            // 
            // extensionTrackBar
            // 
            this.extensionTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extensionTrackBar.LargeChange = 20;
            this.extensionTrackBar.Location = new System.Drawing.Point(4, 134);
            this.extensionTrackBar.Maximum = 100;
            this.extensionTrackBar.Name = "extensionTrackBar";
            this.extensionTrackBar.Size = new System.Drawing.Size(250, 71);
            this.extensionTrackBar.TabIndex = 6;
            this.extensionTrackBar.TickFrequency = 10;
            this.extensionTrackBar.Scroll += new System.EventHandler(this.extensionTrackBar_Scroll);
            // 
            // rotationLabel
            // 
            this.rotationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotationLabel.AutoSize = true;
            this.rotationLabel.Location = new System.Drawing.Point(4, 1);
            this.rotationLabel.Name = "rotationLabel";
            this.rotationLabel.Size = new System.Drawing.Size(250, 25);
            this.rotationLabel.TabIndex = 0;
            this.rotationLabel.Text = "Rotation: 0";
            this.rotationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rotationLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // extensionLabel
            // 
            this.extensionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extensionLabel.AutoSize = true;
            this.extensionLabel.Location = new System.Drawing.Point(4, 105);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(250, 25);
            this.extensionLabel.TabIndex = 1;
            this.extensionLabel.Text = "Extension: 0";
            this.extensionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elevationLabel
            // 
            this.elevationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elevationLabel.AutoSize = true;
            this.elevationLabel.Location = new System.Drawing.Point(4, 209);
            this.elevationLabel.Name = "elevationLabel";
            this.elevationLabel.Size = new System.Drawing.Size(250, 25);
            this.elevationLabel.TabIndex = 2;
            this.elevationLabel.Text = "Elevation: 0";
            this.elevationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gripperLabel
            // 
            this.gripperLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gripperLabel.AutoSize = true;
            this.gripperLabel.Location = new System.Drawing.Point(4, 313);
            this.gripperLabel.Name = "gripperLabel";
            this.gripperLabel.Size = new System.Drawing.Size(250, 25);
            this.gripperLabel.TabIndex = 3;
            this.gripperLabel.Text = "Gripper: 0";
            this.gripperLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // auxLabel
            // 
            this.auxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.auxLabel.AutoSize = true;
            this.auxLabel.Location = new System.Drawing.Point(4, 417);
            this.auxLabel.Name = "auxLabel";
            this.auxLabel.Size = new System.Drawing.Size(250, 25);
            this.auxLabel.TabIndex = 4;
            this.auxLabel.Text = "Aux: 0";
            this.auxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rotationTrackBar
            // 
            this.rotationTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotationTrackBar.LargeChange = 20;
            this.rotationTrackBar.Location = new System.Drawing.Point(4, 30);
            this.rotationTrackBar.Maximum = 100;
            this.rotationTrackBar.Name = "rotationTrackBar";
            this.rotationTrackBar.Size = new System.Drawing.Size(250, 71);
            this.rotationTrackBar.TabIndex = 5;
            this.rotationTrackBar.TickFrequency = 10;
            this.rotationTrackBar.Scroll += new System.EventHandler(this.rotationTrackBar_Scroll);
            // 
            // framesGroupBox
            // 
            this.framesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.framesGroupBox.Controls.Add(this.framesListBox);
            this.framesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.framesGroupBox.Name = "framesGroupBox";
            this.mainLayoutPanel.SetRowSpan(this.framesGroupBox, 3);
            this.framesGroupBox.Size = new System.Drawing.Size(264, 545);
            this.framesGroupBox.TabIndex = 2;
            this.framesGroupBox.TabStop = false;
            this.framesGroupBox.Text = "Frames";
            // 
            // framesListBox
            // 
            this.framesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.framesListBox.FormattingEnabled = true;
            this.framesListBox.Items.AddRange(new object[] {
            "Frame 1: [0,0,0,0,0]",
            "Frame 2: [100,100,100,100,100]"});
            this.framesListBox.Location = new System.Drawing.Point(3, 16);
            this.framesListBox.Name = "framesListBox";
            this.framesListBox.Size = new System.Drawing.Size(258, 526);
            this.framesListBox.TabIndex = 0;
            // 
            // connectionControlGroupBox
            // 
            this.connectionControlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionControlGroupBox.Controls.Add(this.connectionControlTableLayoutPanel);
            this.connectionControlGroupBox.Location = new System.Drawing.Point(543, 3);
            this.connectionControlGroupBox.Name = "connectionControlGroupBox";
            this.connectionControlGroupBox.Size = new System.Drawing.Size(265, 131);
            this.connectionControlGroupBox.TabIndex = 3;
            this.connectionControlGroupBox.TabStop = false;
            this.connectionControlGroupBox.Text = "Connection Control";
            // 
            // connectionControlTableLayoutPanel
            // 
            this.connectionControlTableLayoutPanel.AutoSize = true;
            this.connectionControlTableLayoutPanel.ColumnCount = 2;
            this.connectionControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectionControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.connectionControlTableLayoutPanel.Controls.Add(this.baudRateLabel, 0, 0);
            this.connectionControlTableLayoutPanel.Controls.Add(this.panel1, 1, 0);
            this.connectionControlTableLayoutPanel.Controls.Add(this.connectButton, 0, 1);
            this.connectionControlTableLayoutPanel.Controls.Add(this.refreshRate, 1, 2);
            this.connectionControlTableLayoutPanel.Controls.Add(this.resfreshRateLabel, 0, 2);
            this.connectionControlTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionControlTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.connectionControlTableLayoutPanel.Name = "connectionControlTableLayoutPanel";
            this.connectionControlTableLayoutPanel.RowCount = 3;
            this.connectionControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.connectionControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.connectionControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.connectionControlTableLayoutPanel.Size = new System.Drawing.Size(259, 112);
            this.connectionControlTableLayoutPanel.TabIndex = 0;
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baudRateLabel.Location = new System.Drawing.Point(3, 0);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(123, 37);
            this.baudRateLabel.TabIndex = 1;
            this.baudRateLabel.Text = "Baud Rate:";
            this.baudRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.baudRateLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.baudRateTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(132, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 31);
            this.panel1.TabIndex = 2;
            // 
            // baudRateTextBox
            // 
            this.baudRateTextBox.AllowDrop = true;
            this.baudRateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baudRateTextBox.Location = new System.Drawing.Point(3, 8);
            this.baudRateTextBox.Name = "baudRateTextBox";
            this.baudRateTextBox.Size = new System.Drawing.Size(118, 20);
            this.baudRateTextBox.TabIndex = 0;
            this.baudRateTextBox.Text = "115200";
            // 
            // connectButton
            // 
            this.connectionControlTableLayoutPanel.SetColumnSpan(this.connectButton, 2);
            this.connectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectButton.Location = new System.Drawing.Point(15, 45);
            this.connectButton.Margin = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(229, 21);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // refreshRate
            // 
            this.refreshRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshRate.Location = new System.Drawing.Point(132, 82);
            this.refreshRate.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.refreshRate.Name = "refreshRate";
            this.refreshRate.Size = new System.Drawing.Size(124, 20);
            this.refreshRate.TabIndex = 4;
            this.refreshRate.Text = "100";
            this.refreshRate.TextChanged += new System.EventHandler(this.refreshRate_TextChanged);
            // 
            // resfreshRateLabel
            // 
            this.resfreshRateLabel.AutoSize = true;
            this.resfreshRateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resfreshRateLabel.Location = new System.Drawing.Point(3, 74);
            this.resfreshRateLabel.Name = "resfreshRateLabel";
            this.resfreshRateLabel.Size = new System.Drawing.Size(123, 38);
            this.resfreshRateLabel.TabIndex = 5;
            this.resfreshRateLabel.Text = "Refresh Rate (ms):";
            this.resfreshRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frameControlGroupBox
            // 
            this.frameControlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameControlGroupBox.Controls.Add(this.FrameControlTableLayoutPanel);
            this.frameControlGroupBox.Location = new System.Drawing.Point(543, 140);
            this.frameControlGroupBox.Name = "frameControlGroupBox";
            this.frameControlGroupBox.Size = new System.Drawing.Size(265, 224);
            this.frameControlGroupBox.TabIndex = 4;
            this.frameControlGroupBox.TabStop = false;
            this.frameControlGroupBox.Text = "Frame Control";
            // 
            // FrameControlTableLayoutPanel
            // 
            this.FrameControlTableLayoutPanel.ColumnCount = 2;
            this.FrameControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.FrameControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.FrameControlTableLayoutPanel.Controls.Add(this.deleteButton, 0, 2);
            this.FrameControlTableLayoutPanel.Controls.Add(this.overwriteButton, 0, 1);
            this.FrameControlTableLayoutPanel.Controls.Add(this.newFrameButton, 0, 0);
            this.FrameControlTableLayoutPanel.Controls.Add(this.framDurationLabel, 0, 3);
            this.FrameControlTableLayoutPanel.Controls.Add(this.numericUpDown1, 1, 3);
            this.FrameControlTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.FrameControlTableLayoutPanel.Name = "FrameControlTableLayoutPanel";
            this.FrameControlTableLayoutPanel.RowCount = 4;
            this.FrameControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FrameControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FrameControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FrameControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.FrameControlTableLayoutPanel.Size = new System.Drawing.Size(258, 155);
            this.FrameControlTableLayoutPanel.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.FrameControlTableLayoutPanel.SetColumnSpan(this.deleteButton, 2);
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(7, 83);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(7);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(244, 24);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete Selected Frame";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // overwriteButton
            // 
            this.FrameControlTableLayoutPanel.SetColumnSpan(this.overwriteButton, 2);
            this.overwriteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overwriteButton.Location = new System.Drawing.Point(7, 45);
            this.overwriteButton.Margin = new System.Windows.Forms.Padding(7);
            this.overwriteButton.Name = "overwriteButton";
            this.overwriteButton.Size = new System.Drawing.Size(244, 24);
            this.overwriteButton.TabIndex = 1;
            this.overwriteButton.Text = "Overwrite Current Frame";
            this.overwriteButton.UseVisualStyleBackColor = true;
            // 
            // newFrameButton
            // 
            this.FrameControlTableLayoutPanel.SetColumnSpan(this.newFrameButton, 2);
            this.newFrameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFrameButton.Location = new System.Drawing.Point(7, 7);
            this.newFrameButton.Margin = new System.Windows.Forms.Padding(7);
            this.newFrameButton.Name = "newFrameButton";
            this.newFrameButton.Size = new System.Drawing.Size(244, 24);
            this.newFrameButton.TabIndex = 0;
            this.newFrameButton.Text = "Save as New Frame";
            this.newFrameButton.UseVisualStyleBackColor = true;
            // 
            // framDurationLabel
            // 
            this.framDurationLabel.AutoSize = true;
            this.framDurationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.framDurationLabel.Location = new System.Drawing.Point(3, 114);
            this.framDurationLabel.Name = "framDurationLabel";
            this.framDurationLabel.Size = new System.Drawing.Size(84, 41);
            this.framDurationLabel.TabIndex = 3;
            this.framDurationLabel.Text = "Frame Duration (ms):";
            this.framDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(93, 124);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(162, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // playbackGroupBox
            // 
            this.playbackGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playbackGroupBox.Controls.Add(this.PlaybackControlTableLayoutPanel);
            this.playbackGroupBox.Location = new System.Drawing.Point(543, 370);
            this.playbackGroupBox.Name = "playbackGroupBox";
            this.playbackGroupBox.Size = new System.Drawing.Size(265, 178);
            this.playbackGroupBox.TabIndex = 5;
            this.playbackGroupBox.TabStop = false;
            this.playbackGroupBox.Text = "Playback Control";
            // 
            // PlaybackControlTableLayoutPanel
            // 
            this.PlaybackControlTableLayoutPanel.ColumnCount = 1;
            this.PlaybackControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PlaybackControlTableLayoutPanel.Controls.Add(this.stopButton, 0, 2);
            this.PlaybackControlTableLayoutPanel.Controls.Add(this.playFromSelectedButton, 0, 1);
            this.PlaybackControlTableLayoutPanel.Controls.Add(this.playFromTopButton, 0, 0);
            this.PlaybackControlTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlaybackControlTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.PlaybackControlTableLayoutPanel.Name = "PlaybackControlTableLayoutPanel";
            this.PlaybackControlTableLayoutPanel.RowCount = 3;
            this.PlaybackControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PlaybackControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PlaybackControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PlaybackControlTableLayoutPanel.Size = new System.Drawing.Size(259, 159);
            this.PlaybackControlTableLayoutPanel.TabIndex = 1;
            // 
            // stopButton
            // 
            this.stopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopButton.Location = new System.Drawing.Point(7, 113);
            this.stopButton.Margin = new System.Windows.Forms.Padding(7);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(245, 39);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop Playback";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // playFromSelectedButton
            // 
            this.playFromSelectedButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playFromSelectedButton.Location = new System.Drawing.Point(7, 60);
            this.playFromSelectedButton.Margin = new System.Windows.Forms.Padding(7);
            this.playFromSelectedButton.Name = "playFromSelectedButton";
            this.playFromSelectedButton.Size = new System.Drawing.Size(245, 39);
            this.playFromSelectedButton.TabIndex = 1;
            this.playFromSelectedButton.Text = "Play from Selected Frame";
            this.playFromSelectedButton.UseVisualStyleBackColor = true;
            // 
            // playFromTopButton
            // 
            this.playFromTopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playFromTopButton.Location = new System.Drawing.Point(7, 7);
            this.playFromTopButton.Margin = new System.Windows.Forms.Padding(7);
            this.playFromTopButton.Name = "playFromTopButton";
            this.playFromTopButton.Size = new System.Drawing.Size(245, 39);
            this.playFromTopButton.TabIndex = 0;
            this.playFromTopButton.Text = "Play from Top";
            this.playFromTopButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(811, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 573);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(811, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(79, 17);
            this.connectionStatusLabel.Text = "Disconnected";
            this.connectionStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // arduinoSerialPort
            // 
            this.arduinoSerialPort.PortName = "COM3";
            // 
            // serialTimer
            // 
            this.serialTimer.Enabled = true;
            this.serialTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 595);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Robot Arm Control";
            this.mainLayoutPanel.ResumeLayout(false);
            this.armControlGroupBox.ResumeLayout(false);
            this.armControlGroupBox.PerformLayout();
            this.armControlLayoutPanel.ResumeLayout(false);
            this.armControlLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auxTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gripperTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extensionTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationTrackBar)).EndInit();
            this.framesGroupBox.ResumeLayout(false);
            this.connectionControlGroupBox.ResumeLayout(false);
            this.connectionControlGroupBox.PerformLayout();
            this.connectionControlTableLayoutPanel.ResumeLayout(false);
            this.connectionControlTableLayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.frameControlGroupBox.ResumeLayout(false);
            this.FrameControlTableLayoutPanel.ResumeLayout(false);
            this.FrameControlTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.playbackGroupBox.ResumeLayout(false);
            this.PlaybackControlTableLayoutPanel.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.GroupBox armControlGroupBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.GroupBox framesGroupBox;
        private System.Windows.Forms.GroupBox connectionControlGroupBox;
        private System.Windows.Forms.GroupBox frameControlGroupBox;
        private System.Windows.Forms.GroupBox playbackGroupBox;
        private System.Windows.Forms.TableLayoutPanel armControlLayoutPanel;
        private System.Windows.Forms.TrackBar auxTrackBar;
        private System.Windows.Forms.TrackBar gripperTrackBar;
        private System.Windows.Forms.TrackBar elevationTrackBar;
        private System.Windows.Forms.TrackBar extensionTrackBar;
        private System.Windows.Forms.Label rotationLabel;
        private System.Windows.Forms.Label extensionLabel;
        private System.Windows.Forms.Label elevationLabel;
        private System.Windows.Forms.Label gripperLabel;
        private System.Windows.Forms.Label auxLabel;
        private System.Windows.Forms.TrackBar rotationTrackBar;
        private System.Windows.Forms.ListBox framesListBox;
        private System.Windows.Forms.TableLayoutPanel connectionControlTableLayoutPanel;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox baudRateTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatusLabel;
        private System.Windows.Forms.TableLayoutPanel FrameControlTableLayoutPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button overwriteButton;
        private System.Windows.Forms.Button newFrameButton;
        private System.Windows.Forms.TableLayoutPanel PlaybackControlTableLayoutPanel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playFromSelectedButton;
        private System.Windows.Forms.Button playFromTopButton;
        private System.IO.Ports.SerialPort arduinoSerialPort;
        private System.Windows.Forms.Label framDurationLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer serialTimer;
        private System.Windows.Forms.TextBox refreshRate;
        private System.Windows.Forms.Label resfreshRateLabel;
    }
}

