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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.armControlGroupBox = new System.Windows.Forms.GroupBox();
            this.armControlLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TrackBar5 = new System.Windows.Forms.TrackBar();
            this.TrackBar4 = new System.Windows.Forms.TrackBar();
            this.TrackBar3 = new System.Windows.Forms.TrackBar();
            this.TrackBar2 = new System.Windows.Forms.TrackBar();
            this.refreshRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rotationLabel = new System.Windows.Forms.Label();
            this.extensionLabel = new System.Windows.Forms.Label();
            this.elevationLabel = new System.Windows.Forms.Label();
            this.gripperLabel = new System.Windows.Forms.Label();
            this.auxLabel = new System.Windows.Forms.Label();
            this.TrackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.framesGroupBox = new System.Windows.Forms.GroupBox();
            this.framesListBox = new System.Windows.Forms.ListBox();
            this.connectionControlGroupBox = new System.Windows.Forms.GroupBox();
            this.connectionControlTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.serialPortPickerLabel = new System.Windows.Forms.Label();
            this.serialPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.baudRateTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.frameControlGroupBox = new System.Windows.Forms.GroupBox();
            this.FrameControlTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.overwriteButton = new System.Windows.Forms.Button();
            this.newFrameButton = new System.Windows.Forms.Button();
            this.framDurationLabel = new System.Windows.Forms.Label();
            this.durrationNumericUpDown = new System.Windows.Forms.NumericUpDown();
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.playbackTimer = new System.Windows.Forms.Timer(this.components);
            this.loop = new System.Windows.Forms.Label();
            this.loopCheckBox = new System.Windows.Forms.CheckBox();
            this.mainLayoutPanel.SuspendLayout();
            this.armControlGroupBox.SuspendLayout();
            this.armControlLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).BeginInit();
            this.framesGroupBox.SuspendLayout();
            this.connectionControlGroupBox.SuspendLayout();
            this.connectionControlTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialPortNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.frameControlGroupBox.SuspendLayout();
            this.FrameControlTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durrationNumericUpDown)).BeginInit();
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
            this.mainLayoutPanel.Size = new System.Drawing.Size(807, 558);
            this.mainLayoutPanel.TabIndex = 2;
            // 
            // armControlGroupBox
            // 
            this.armControlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armControlGroupBox.Controls.Add(this.armControlLayoutPanel);
            this.armControlGroupBox.Location = new System.Drawing.Point(272, 3);
            this.armControlGroupBox.Name = "armControlGroupBox";
            this.mainLayoutPanel.SetRowSpan(this.armControlGroupBox, 3);
            this.armControlGroupBox.Size = new System.Drawing.Size(263, 532);
            this.armControlGroupBox.TabIndex = 1;
            this.armControlGroupBox.TabStop = false;
            this.armControlGroupBox.Text = "Arm Control";
            // 
            // armControlLayoutPanel
            // 
            this.armControlLayoutPanel.AutoSize = true;
            this.armControlLayoutPanel.ColumnCount = 2;
            this.armControlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.armControlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.armControlLayoutPanel.Controls.Add(this.TrackBar5, 0, 9);
            this.armControlLayoutPanel.Controls.Add(this.TrackBar4, 0, 7);
            this.armControlLayoutPanel.Controls.Add(this.TrackBar3, 0, 5);
            this.armControlLayoutPanel.Controls.Add(this.TrackBar2, 0, 3);
            this.armControlLayoutPanel.Controls.Add(this.refreshRateNumericUpDown, 1, 10);
            this.armControlLayoutPanel.Controls.Add(this.rotationLabel, 0, 0);
            this.armControlLayoutPanel.Controls.Add(this.extensionLabel, 0, 2);
            this.armControlLayoutPanel.Controls.Add(this.elevationLabel, 0, 4);
            this.armControlLayoutPanel.Controls.Add(this.gripperLabel, 0, 6);
            this.armControlLayoutPanel.Controls.Add(this.auxLabel, 0, 8);
            this.armControlLayoutPanel.Controls.Add(this.TrackBar1, 0, 1);
            this.armControlLayoutPanel.Controls.Add(this.label2, 0, 10);
            this.armControlLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.armControlLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.armControlLayoutPanel.Name = "armControlLayoutPanel";
            this.armControlLayoutPanel.RowCount = 11;
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
            this.armControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.armControlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.armControlLayoutPanel.Size = new System.Drawing.Size(257, 513);
            this.armControlLayoutPanel.TabIndex = 0;
            this.armControlLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.armControlLayoutPanel_Paint);
            // 
            // TrackBar5
            // 
            this.TrackBar5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armControlLayoutPanel.SetColumnSpan(this.TrackBar5, 2);
            this.TrackBar5.LargeChange = 20;
            this.TrackBar5.Location = new System.Drawing.Point(3, 415);
            this.TrackBar5.Maximum = 100;
            this.TrackBar5.Name = "TrackBar5";
            this.TrackBar5.Size = new System.Drawing.Size(251, 67);
            this.TrackBar5.TabIndex = 9;
            this.TrackBar5.TickFrequency = 10;
            this.TrackBar5.Scroll += new System.EventHandler(this.auxTrackBar_Scroll);
            // 
            // TrackBar4
            // 
            this.TrackBar4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armControlLayoutPanel.SetColumnSpan(this.TrackBar4, 2);
            this.TrackBar4.LargeChange = 20;
            this.TrackBar4.Location = new System.Drawing.Point(3, 318);
            this.TrackBar4.Maximum = 100;
            this.TrackBar4.Name = "TrackBar4";
            this.TrackBar4.Size = new System.Drawing.Size(251, 67);
            this.TrackBar4.TabIndex = 8;
            this.TrackBar4.TickFrequency = 10;
            this.TrackBar4.Scroll += new System.EventHandler(this.gripperTrackBar_Scroll);
            // 
            // TrackBar3
            // 
            this.TrackBar3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armControlLayoutPanel.SetColumnSpan(this.TrackBar3, 2);
            this.TrackBar3.LargeChange = 20;
            this.TrackBar3.Location = new System.Drawing.Point(3, 221);
            this.TrackBar3.Maximum = 100;
            this.TrackBar3.Name = "TrackBar3";
            this.TrackBar3.Size = new System.Drawing.Size(251, 67);
            this.TrackBar3.TabIndex = 7;
            this.TrackBar3.TickFrequency = 10;
            this.TrackBar3.Scroll += new System.EventHandler(this.elevationTrackBar_Scroll);
            // 
            // TrackBar2
            // 
            this.TrackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armControlLayoutPanel.SetColumnSpan(this.TrackBar2, 2);
            this.TrackBar2.LargeChange = 20;
            this.TrackBar2.Location = new System.Drawing.Point(3, 124);
            this.TrackBar2.Maximum = 100;
            this.TrackBar2.Name = "TrackBar2";
            this.TrackBar2.Size = new System.Drawing.Size(251, 67);
            this.TrackBar2.TabIndex = 6;
            this.TrackBar2.TickFrequency = 10;
            this.TrackBar2.Scroll += new System.EventHandler(this.extensionTrackBar_Scroll);
            // 
            // refreshRateNumericUpDown
            // 
            this.refreshRateNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshRateNumericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.refreshRateNumericUpDown.Location = new System.Drawing.Point(105, 488);
            this.refreshRateNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.refreshRateNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.refreshRateNumericUpDown.Name = "refreshRateNumericUpDown";
            this.refreshRateNumericUpDown.Size = new System.Drawing.Size(149, 20);
            this.refreshRateNumericUpDown.TabIndex = 4;
            this.refreshRateNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.refreshRateNumericUpDown.ThousandsSeparator = true;
            this.refreshRateNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.refreshRateNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // rotationLabel
            // 
            this.rotationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotationLabel.AutoSize = true;
            this.armControlLayoutPanel.SetColumnSpan(this.rotationLabel, 2);
            this.rotationLabel.Location = new System.Drawing.Point(3, 0);
            this.rotationLabel.Name = "rotationLabel";
            this.rotationLabel.Size = new System.Drawing.Size(251, 24);
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
            this.armControlLayoutPanel.SetColumnSpan(this.extensionLabel, 2);
            this.extensionLabel.Location = new System.Drawing.Point(3, 97);
            this.extensionLabel.Name = "extensionLabel";
            this.extensionLabel.Size = new System.Drawing.Size(251, 24);
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
            this.armControlLayoutPanel.SetColumnSpan(this.elevationLabel, 2);
            this.elevationLabel.Location = new System.Drawing.Point(3, 194);
            this.elevationLabel.Name = "elevationLabel";
            this.elevationLabel.Size = new System.Drawing.Size(251, 24);
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
            this.armControlLayoutPanel.SetColumnSpan(this.gripperLabel, 2);
            this.gripperLabel.Location = new System.Drawing.Point(3, 291);
            this.gripperLabel.Name = "gripperLabel";
            this.gripperLabel.Size = new System.Drawing.Size(251, 24);
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
            this.armControlLayoutPanel.SetColumnSpan(this.auxLabel, 2);
            this.auxLabel.Location = new System.Drawing.Point(3, 388);
            this.auxLabel.Name = "auxLabel";
            this.auxLabel.Size = new System.Drawing.Size(251, 24);
            this.auxLabel.TabIndex = 4;
            this.auxLabel.Text = "Aux: 0";
            this.auxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrackBar1
            // 
            this.TrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armControlLayoutPanel.SetColumnSpan(this.TrackBar1, 2);
            this.TrackBar1.LargeChange = 20;
            this.TrackBar1.Location = new System.Drawing.Point(3, 27);
            this.TrackBar1.Maximum = 180;
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(251, 67);
            this.TrackBar1.TabIndex = 5;
            this.TrackBar1.TickFrequency = 10;
            this.TrackBar1.Scroll += new System.EventHandler(this.rotationTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Refresh Rate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.framesGroupBox.Size = new System.Drawing.Size(263, 532);
            this.framesGroupBox.TabIndex = 2;
            this.framesGroupBox.TabStop = false;
            this.framesGroupBox.Text = "Frames";
            // 
            // framesListBox
            // 
            this.framesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.framesListBox.FormattingEnabled = true;
            this.framesListBox.Location = new System.Drawing.Point(3, 16);
            this.framesListBox.Name = "framesListBox";
            this.framesListBox.Size = new System.Drawing.Size(257, 513);
            this.framesListBox.TabIndex = 0;
            this.framesListBox.SelectedIndexChanged += new System.EventHandler(this.framesListBox_SelectedIndexChanged);
            // 
            // connectionControlGroupBox
            // 
            this.connectionControlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionControlGroupBox.Controls.Add(this.connectionControlTableLayoutPanel);
            this.connectionControlGroupBox.Location = new System.Drawing.Point(541, 3);
            this.connectionControlGroupBox.Name = "connectionControlGroupBox";
            this.connectionControlGroupBox.Size = new System.Drawing.Size(263, 128);
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
            this.connectionControlTableLayoutPanel.Controls.Add(this.serialPortPickerLabel, 0, 1);
            this.connectionControlTableLayoutPanel.Controls.Add(this.serialPortNumericUpDown, 1, 1);
            this.connectionControlTableLayoutPanel.Controls.Add(this.baudRateLabel, 0, 0);
            this.connectionControlTableLayoutPanel.Controls.Add(this.panel1, 1, 0);
            this.connectionControlTableLayoutPanel.Controls.Add(this.connectButton, 0, 2);
            this.connectionControlTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionControlTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.connectionControlTableLayoutPanel.Name = "connectionControlTableLayoutPanel";
            this.connectionControlTableLayoutPanel.RowCount = 3;
            this.connectionControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.connectionControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.connectionControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.connectionControlTableLayoutPanel.Size = new System.Drawing.Size(257, 109);
            this.connectionControlTableLayoutPanel.TabIndex = 0;
            // 
            // serialPortPickerLabel
            // 
            this.serialPortPickerLabel.AutoSize = true;
            this.serialPortPickerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serialPortPickerLabel.Location = new System.Drawing.Point(3, 36);
            this.serialPortPickerLabel.Name = "serialPortPickerLabel";
            this.serialPortPickerLabel.Size = new System.Drawing.Size(122, 36);
            this.serialPortPickerLabel.TabIndex = 8;
            this.serialPortPickerLabel.Text = "Serial Port #:";
            this.serialPortPickerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPortNumericUpDown
            // 
            this.serialPortNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serialPortNumericUpDown.Location = new System.Drawing.Point(131, 46);
            this.serialPortNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.serialPortNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.serialPortNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.serialPortNumericUpDown.Name = "serialPortNumericUpDown";
            this.serialPortNumericUpDown.Size = new System.Drawing.Size(123, 20);
            this.serialPortNumericUpDown.TabIndex = 7;
            this.serialPortNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.serialPortNumericUpDown.ValueChanged += new System.EventHandler(this.serialPortNumericUpDown_ValueChanged);
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baudRateLabel.Location = new System.Drawing.Point(3, 0);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(122, 36);
            this.baudRateLabel.TabIndex = 1;
            this.baudRateLabel.Text = "Baud Rate:";
            this.baudRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.baudRateLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.baudRateTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(131, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 30);
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
            this.baudRateTextBox.Size = new System.Drawing.Size(117, 20);
            this.baudRateTextBox.TabIndex = 0;
            this.baudRateTextBox.Text = "9600";
            // 
            // connectButton
            // 
            this.connectionControlTableLayoutPanel.SetColumnSpan(this.connectButton, 2);
            this.connectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectButton.Location = new System.Drawing.Point(15, 80);
            this.connectButton.Margin = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(227, 21);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // frameControlGroupBox
            // 
            this.frameControlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameControlGroupBox.Controls.Add(this.FrameControlTableLayoutPanel);
            this.frameControlGroupBox.Location = new System.Drawing.Point(541, 137);
            this.frameControlGroupBox.Name = "frameControlGroupBox";
            this.frameControlGroupBox.Size = new System.Drawing.Size(263, 219);
            this.frameControlGroupBox.TabIndex = 4;
            this.frameControlGroupBox.TabStop = false;
            this.frameControlGroupBox.Text = "Frame Control";
            // 
            // FrameControlTableLayoutPanel
            // 
            this.FrameControlTableLayoutPanel.ColumnCount = 2;
            this.FrameControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.FrameControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.FrameControlTableLayoutPanel.Controls.Add(this.loop, 0, 4);
            this.FrameControlTableLayoutPanel.Controls.Add(this.deleteButton, 0, 2);
            this.FrameControlTableLayoutPanel.Controls.Add(this.overwriteButton, 0, 1);
            this.FrameControlTableLayoutPanel.Controls.Add(this.newFrameButton, 0, 0);
            this.FrameControlTableLayoutPanel.Controls.Add(this.framDurationLabel, 0, 3);
            this.FrameControlTableLayoutPanel.Controls.Add(this.durrationNumericUpDown, 1, 3);
            this.FrameControlTableLayoutPanel.Controls.Add(this.loopCheckBox, 1, 4);
            this.FrameControlTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrameControlTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.FrameControlTableLayoutPanel.Name = "FrameControlTableLayoutPanel";
            this.FrameControlTableLayoutPanel.RowCount = 5;
            this.FrameControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FrameControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FrameControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FrameControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FrameControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FrameControlTableLayoutPanel.Size = new System.Drawing.Size(257, 200);
            this.FrameControlTableLayoutPanel.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.FrameControlTableLayoutPanel.SetColumnSpan(this.deleteButton, 2);
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(7, 87);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(7);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(243, 26);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete Selected Frame";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // overwriteButton
            // 
            this.FrameControlTableLayoutPanel.SetColumnSpan(this.overwriteButton, 2);
            this.overwriteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overwriteButton.Location = new System.Drawing.Point(7, 47);
            this.overwriteButton.Margin = new System.Windows.Forms.Padding(7);
            this.overwriteButton.Name = "overwriteButton";
            this.overwriteButton.Size = new System.Drawing.Size(243, 26);
            this.overwriteButton.TabIndex = 1;
            this.overwriteButton.Text = "Overwrite Current Frame";
            this.overwriteButton.UseVisualStyleBackColor = true;
            this.overwriteButton.Click += new System.EventHandler(this.overwriteButton_Click);
            // 
            // newFrameButton
            // 
            this.FrameControlTableLayoutPanel.SetColumnSpan(this.newFrameButton, 2);
            this.newFrameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFrameButton.Location = new System.Drawing.Point(7, 7);
            this.newFrameButton.Margin = new System.Windows.Forms.Padding(7);
            this.newFrameButton.Name = "newFrameButton";
            this.newFrameButton.Size = new System.Drawing.Size(243, 26);
            this.newFrameButton.TabIndex = 0;
            this.newFrameButton.Text = "Save as New Frame";
            this.newFrameButton.UseVisualStyleBackColor = true;
            this.newFrameButton.Click += new System.EventHandler(this.newFrameButton_Click);
            // 
            // framDurationLabel
            // 
            this.framDurationLabel.AutoSize = true;
            this.framDurationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.framDurationLabel.Location = new System.Drawing.Point(3, 120);
            this.framDurationLabel.Name = "framDurationLabel";
            this.framDurationLabel.Size = new System.Drawing.Size(83, 40);
            this.framDurationLabel.TabIndex = 3;
            this.framDurationLabel.Text = "Frame Duration (ms):";
            this.framDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // durrationNumericUpDown
            // 
            this.durrationNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.durrationNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.durrationNumericUpDown.Location = new System.Drawing.Point(92, 130);
            this.durrationNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.durrationNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.durrationNumericUpDown.Name = "durrationNumericUpDown";
            this.durrationNumericUpDown.Size = new System.Drawing.Size(162, 20);
            this.durrationNumericUpDown.TabIndex = 4;
            this.durrationNumericUpDown.Value = new decimal(new int[] {
            1000,
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
            this.playbackGroupBox.Location = new System.Drawing.Point(541, 362);
            this.playbackGroupBox.Name = "playbackGroupBox";
            this.playbackGroupBox.Size = new System.Drawing.Size(263, 173);
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
            this.PlaybackControlTableLayoutPanel.Size = new System.Drawing.Size(257, 154);
            this.PlaybackControlTableLayoutPanel.TabIndex = 1;
            // 
            // stopButton
            // 
            this.stopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopButton.Location = new System.Drawing.Point(7, 109);
            this.stopButton.Margin = new System.Windows.Forms.Padding(7);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(243, 38);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop Playback";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playFromSelectedButton
            // 
            this.playFromSelectedButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playFromSelectedButton.Location = new System.Drawing.Point(7, 58);
            this.playFromSelectedButton.Margin = new System.Windows.Forms.Padding(7);
            this.playFromSelectedButton.Name = "playFromSelectedButton";
            this.playFromSelectedButton.Size = new System.Drawing.Size(243, 37);
            this.playFromSelectedButton.TabIndex = 1;
            this.playFromSelectedButton.Text = "Play from Selected Frame";
            this.playFromSelectedButton.UseVisualStyleBackColor = true;
            this.playFromSelectedButton.Click += new System.EventHandler(this.playFromSelectedButton_Click);
            // 
            // playFromTopButton
            // 
            this.playFromTopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playFromTopButton.Location = new System.Drawing.Point(7, 7);
            this.playFromTopButton.Margin = new System.Windows.Forms.Padding(7);
            this.playFromTopButton.Name = "playFromTopButton";
            this.playFromTopButton.Size = new System.Drawing.Size(243, 37);
            this.playFromTopButton.TabIndex = 0;
            this.playFromTopButton.Text = "Play from Top";
            this.playFromTopButton.UseVisualStyleBackColor = true;
            this.playFromTopButton.Click += new System.EventHandler(this.playFromTopButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(807, 24);
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
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 560);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(807, 22);
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
            this.serialTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Title = "Save frames...";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // playbackTimer
            // 
            this.playbackTimer.Tick += new System.EventHandler(this.playbackTimer_Tick);
            // 
            // loop
            // 
            this.loop.AutoSize = true;
            this.loop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loop.Location = new System.Drawing.Point(3, 160);
            this.loop.Name = "loop";
            this.loop.Size = new System.Drawing.Size(83, 40);
            this.loop.TabIndex = 5;
            this.loop.Text = "Loop:";
            this.loop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loopCheckBox
            // 
            this.loopCheckBox.AutoSize = true;
            this.loopCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loopCheckBox.Checked = true;
            this.loopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loopCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loopCheckBox.Location = new System.Drawing.Point(92, 163);
            this.loopCheckBox.Name = "loopCheckBox";
            this.loopCheckBox.Size = new System.Drawing.Size(162, 34);
            this.loopCheckBox.TabIndex = 6;
            this.loopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loopCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.loopCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 582);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Robot Arm Control";
            this.mainLayoutPanel.ResumeLayout(false);
            this.armControlGroupBox.ResumeLayout(false);
            this.armControlGroupBox.PerformLayout();
            this.armControlLayoutPanel.ResumeLayout(false);
            this.armControlLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).EndInit();
            this.framesGroupBox.ResumeLayout(false);
            this.connectionControlGroupBox.ResumeLayout(false);
            this.connectionControlGroupBox.PerformLayout();
            this.connectionControlTableLayoutPanel.ResumeLayout(false);
            this.connectionControlTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialPortNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.frameControlGroupBox.ResumeLayout(false);
            this.FrameControlTableLayoutPanel.ResumeLayout(false);
            this.FrameControlTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durrationNumericUpDown)).EndInit();
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
        private System.Windows.Forms.TrackBar TrackBar5;
        private System.Windows.Forms.TrackBar TrackBar4;
        private System.Windows.Forms.TrackBar TrackBar3;
        private System.Windows.Forms.TrackBar TrackBar2;
        private System.Windows.Forms.Label rotationLabel;
        private System.Windows.Forms.Label extensionLabel;
        private System.Windows.Forms.Label elevationLabel;
        private System.Windows.Forms.Label gripperLabel;
        private System.Windows.Forms.Label auxLabel;
        private System.Windows.Forms.TrackBar TrackBar1;
        private System.Windows.Forms.ListBox framesListBox;
        private System.Windows.Forms.TableLayoutPanel connectionControlTableLayoutPanel;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox baudRateTextBox;
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
        private System.Windows.Forms.NumericUpDown refreshRateNumericUpDown;
        private System.Windows.Forms.Timer serialTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown durrationNumericUpDown;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label serialPortPickerLabel;
        private System.Windows.Forms.NumericUpDown serialPortNumericUpDown;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Timer playbackTimer;
        private System.Windows.Forms.Label loop;
        private System.Windows.Forms.CheckBox loopCheckBox;
    }
}

