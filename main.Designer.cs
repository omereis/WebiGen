namespace WebiGen
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			menuMain = new MenuStrip();
			popupFile = new ToolStripMenuItem();
			miDatabase = new ToolStripMenuItem();
			miFileSep1 = new ToolStripSeparator();
			miExit = new ToolStripMenuItem();
			popupData = new ToolStripMenuItem();
			miPointsExport = new ToolStripMenuItem();
			importFromCSVToolStripMenuItem = new ToolStripMenuItem();
			popupHelp = new ToolStripMenuItem();
			miAbout = new ToolStripMenuItem();
			btnSetBoundaries = new Button();
			comboMaps = new ComboBox();
			status_bar = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			toolStripStatusLabel2 = new ToolStripStatusLabel();
			toolStripStatusLabel3 = new ToolStripStatusLabel();
			toolbar = new ToolStrip();
			btnConnect = new ToolStripButton();
			btnDisconnect = new ToolStripButton();
			btnMaps = new ToolStripButton();
			btnLoadMaps = new Button();
			gridPoints = new DataGridView();
			Column1 = new DataGridViewCheckBoxColumn();
			Column7 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column6 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			Column5 = new DataGridViewTextBoxColumn();
			btnLoadPoints = new Button();
			btnLoadRads = new Button();
			sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
			chartRate = new System.Windows.Forms.DataVisualization.Charting.Chart();
			gridStats = new DataGridView();
			dataGridViewTextBoxColumn2 = new DataGridViewLinkColumn();
			dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
			Column11 = new DataGridViewTextBoxColumn();
			Column13 = new DataGridViewTextBoxColumn();
			Column8 = new DataGridViewTextBoxColumn();
			Column9 = new DataGridViewTextBoxColumn();
			Column10 = new DataGridViewTextBoxColumn();
			Column12 = new DataGridViewTextBoxColumn();
			dlgOpenCsv = new OpenFileDialog();
			dlgSaveCsv = new SaveFileDialog();
			groupBox1 = new GroupBox();
			txtEndDate = new TextBox();
			txtStartDate = new TextBox();
			gboxDel = new GroupBox();
			rbDelNone = new RadioButton();
			rbDelByValue = new RadioButton();
			gboxDelDates = new GroupBox();
			dtpDelTo = new DateTimePicker();
			label2 = new Label();
			dtpDelFrom = new DateTimePicker();
			label3 = new Label();
			rbDelDates = new RadioButton();
			gboxDelRates = new GroupBox();
			txtDelVal = new TextBox();
			label4 = new Label();
			rbDelLt = new RadioButton();
			rbDelEq = new RadioButton();
			rbDelGt = new RadioButton();
			rbDelAll = new RadioButton();
			btnPointRadDel = new Button();
			gboxManipulation = new GroupBox();
			rbOpintNone = new RadioButton();
			rbPointDel = new RadioButton();
			radioButton2 = new RadioButton();
			btnPointRefresh = new Button();
			comboPoints = new ComboBox();
			label1 = new Label();
			txtPointCount = new TextBox();
			label14 = new Label();
			label13 = new Label();
			label12 = new Label();
			label11 = new Label();
			txtStdDiv = new TextBox();
			txtAverage = new TextBox();
			txtMax = new TextBox();
			txtMin = new TextBox();
			label10 = new Label();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			txtRate = new TextBox();
			btnExport = new Button();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			tabPage2 = new TabPage();
			menuMain.SuspendLayout();
			status_bar.SuspendLayout();
			toolbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridPoints).BeginInit();
			((System.ComponentModel.ISupportInitialize)chartRate).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridStats).BeginInit();
			groupBox1.SuspendLayout();
			gboxDel.SuspendLayout();
			gboxDelDates.SuspendLayout();
			gboxDelRates.SuspendLayout();
			gboxManipulation.SuspendLayout();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			SuspendLayout();
			// 
			// menuMain
			// 
			menuMain.Items.AddRange(new ToolStripItem[] { popupFile, popupData, popupHelp });
			menuMain.Location = new Point(0, 0);
			menuMain.Name = "menuMain";
			menuMain.Size = new Size(1174, 24);
			menuMain.TabIndex = 0;
			menuMain.Text = "menuStrip1";
			// 
			// popupFile
			// 
			popupFile.DropDownItems.AddRange(new ToolStripItem[] { miDatabase, miFileSep1, miExit });
			popupFile.Name = "popupFile";
			popupFile.Size = new Size(37, 20);
			popupFile.Text = "&File";
			// 
			// miDatabase
			// 
			miDatabase.Name = "miDatabase";
			miDatabase.Size = new Size(131, 22);
			miDatabase.Text = "&Database...";
			miDatabase.Click += miDatabase_Click;
			// 
			// miFileSep1
			// 
			miFileSep1.Name = "miFileSep1";
			miFileSep1.Size = new Size(128, 6);
			// 
			// miExit
			// 
			miExit.Name = "miExit";
			miExit.Size = new Size(131, 22);
			miExit.Text = "E&xit";
			miExit.Click += miExit_Click;
			// 
			// popupData
			// 
			popupData.DropDownItems.AddRange(new ToolStripItem[] { miPointsExport, importFromCSVToolStripMenuItem });
			popupData.Name = "popupData";
			popupData.Size = new Size(43, 20);
			popupData.Text = "Data";
			// 
			// miPointsExport
			// 
			miPointsExport.Name = "miPointsExport";
			miPointsExport.Size = new Size(172, 22);
			miPointsExport.Text = "&Export to CSV...";
			miPointsExport.Click += miPointsExport_Click;
			// 
			// importFromCSVToolStripMenuItem
			// 
			importFromCSVToolStripMenuItem.Name = "importFromCSVToolStripMenuItem";
			importFromCSVToolStripMenuItem.Size = new Size(172, 22);
			importFromCSVToolStripMenuItem.Text = "&Import from CSV...";
			importFromCSVToolStripMenuItem.Click += importFromCSVToolStripMenuItem_Click;
			// 
			// popupHelp
			// 
			popupHelp.DropDownItems.AddRange(new ToolStripItem[] { miAbout });
			popupHelp.Name = "popupHelp";
			popupHelp.Size = new Size(44, 20);
			popupHelp.Text = "&Help";
			// 
			// miAbout
			// 
			miAbout.Name = "miAbout";
			miAbout.Size = new Size(116, 22);
			miAbout.Text = "&About...";
			// 
			// btnSetBoundaries
			// 
			btnSetBoundaries.Location = new Point(0, 116);
			btnSetBoundaries.Name = "btnSetBoundaries";
			btnSetBoundaries.Size = new Size(81, 23);
			btnSetBoundaries.TabIndex = 1;
			btnSetBoundaries.Text = "Boundaries";
			btnSetBoundaries.UseVisualStyleBackColor = true;
			btnSetBoundaries.Click += btnSetBoundaries_Click;
			// 
			// comboMaps
			// 
			comboMaps.DropDownStyle = ComboBoxStyle.DropDownList;
			comboMaps.FormattingEnabled = true;
			comboMaps.Location = new Point(99, 66);
			comboMaps.Name = "comboMaps";
			comboMaps.Size = new Size(170, 23);
			comboMaps.TabIndex = 2;
			// 
			// status_bar
			// 
			status_bar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
			status_bar.Location = new Point(0, 589);
			status_bar.Name = "status_bar";
			status_bar.Size = new Size(1174, 22);
			status_bar.TabIndex = 4;
			status_bar.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new Size(118, 17);
			toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// toolStripStatusLabel2
			// 
			toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			toolStripStatusLabel2.Size = new Size(118, 17);
			toolStripStatusLabel2.Text = "toolStripStatusLabel2";
			// 
			// toolStripStatusLabel3
			// 
			toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			toolStripStatusLabel3.Size = new Size(118, 17);
			toolStripStatusLabel3.Text = "toolStripStatusLabel3";
			// 
			// toolbar
			// 
			toolbar.BackColor = Color.Silver;
			toolbar.ImageScalingSize = new Size(32, 32);
			toolbar.Items.AddRange(new ToolStripItem[] { btnConnect, btnDisconnect, btnMaps });
			toolbar.Location = new Point(0, 24);
			toolbar.Name = "toolbar";
			toolbar.Size = new Size(1174, 39);
			toolbar.TabIndex = 5;
			toolbar.Text = "toolStrip1";
			// 
			// btnConnect
			// 
			btnConnect.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnConnect.Image = (Image)resources.GetObject("btnConnect.Image");
			btnConnect.ImageTransparentColor = Color.Magenta;
			btnConnect.Name = "btnConnect";
			btnConnect.Size = new Size(36, 36);
			btnConnect.Text = "toolStripButton1";
			btnConnect.Click += btnConnect_Click;
			// 
			// btnDisconnect
			// 
			btnDisconnect.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnDisconnect.Image = (Image)resources.GetObject("btnDisconnect.Image");
			btnDisconnect.ImageTransparentColor = Color.Magenta;
			btnDisconnect.Name = "btnDisconnect";
			btnDisconnect.Size = new Size(36, 36);
			btnDisconnect.Text = "toolStripButton2";
			btnDisconnect.Click += btnDisconnect_Click;
			// 
			// btnMaps
			// 
			btnMaps.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnMaps.Image = (Image)resources.GetObject("btnMaps.Image");
			btnMaps.ImageTransparentColor = Color.Magenta;
			btnMaps.Name = "btnMaps";
			btnMaps.Size = new Size(36, 36);
			btnMaps.Text = "toolStripButton1";
			// 
			// btnLoadMaps
			// 
			btnLoadMaps.Location = new Point(7, 65);
			btnLoadMaps.Name = "btnLoadMaps";
			btnLoadMaps.Size = new Size(86, 23);
			btnLoadMaps.TabIndex = 6;
			btnLoadMaps.Text = "Load Maps";
			btnLoadMaps.UseVisualStyleBackColor = true;
			btnLoadMaps.Click += btnLoadMaps_Click;
			// 
			// gridPoints
			// 
			gridPoints.AllowUserToAddRows = false;
			gridPoints.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.Silver;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			gridPoints.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			gridPoints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridPoints.Columns.AddRange(new DataGridViewColumn[] { Column1, Column7, Column2, Column6, Column3, Column4, Column5 });
			gridPoints.EditMode = DataGridViewEditMode.EditProgrammatically;
			gridPoints.Location = new Point(12, 124);
			gridPoints.MultiSelect = false;
			gridPoints.Name = "gridPoints";
			gridPoints.RowHeadersVisible = false;
			gridPoints.Size = new Size(393, 150);
			gridPoints.TabIndex = 8;
			gridPoints.CellClick += gridPoints_CellClick;
			// 
			// Column1
			// 
			Column1.HeaderText = "Select";
			Column1.Name = "Column1";
			Column1.Width = 45;
			// 
			// Column7
			// 
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column7.DefaultCellStyle = dataGridViewCellStyle2;
			Column7.HeaderText = "Point ID";
			Column7.Name = "Column7";
			Column7.Width = 55;
			// 
			// Column2
			// 
			Column2.HeaderText = "Name";
			Column2.Name = "Column2";
			Column2.Width = 55;
			// 
			// Column6
			// 
			Column6.HeaderText = "Device Type";
			Column6.Name = "Column6";
			Column6.Width = 55;
			// 
			// Column3
			// 
			Column3.HeaderText = "Detector Type";
			Column3.Name = "Column3";
			Column3.Width = 55;
			// 
			// Column4
			// 
			Column4.HeaderText = "Connection ID";
			Column4.Name = "Column4";
			Column4.Width = 55;
			// 
			// Column5
			// 
			Column5.HeaderText = "IP Address";
			Column5.Name = "Column5";
			Column5.Width = 55;
			// 
			// btnLoadPoints
			// 
			btnLoadPoints.Location = new Point(12, 95);
			btnLoadPoints.Name = "btnLoadPoints";
			btnLoadPoints.Size = new Size(82, 23);
			btnLoadPoints.TabIndex = 9;
			btnLoadPoints.Text = "Load Points";
			btnLoadPoints.UseVisualStyleBackColor = true;
			btnLoadPoints.Click += btnLoadPoints_Click;
			// 
			// btnLoadRads
			// 
			btnLoadRads.Location = new Point(427, 95);
			btnLoadRads.Name = "btnLoadRads";
			btnLoadRads.Size = new Size(97, 23);
			btnLoadRads.TabIndex = 10;
			btnLoadRads.Text = "Load Radiation";
			btnLoadRads.UseVisualStyleBackColor = true;
			btnLoadRads.Click += btnLoadRads_Click;
			// 
			// sqlCommand1
			// 
			sqlCommand1.CommandTimeout = 30;
			sqlCommand1.EnableOptimizedParameterBinding = false;
			// 
			// chartRate
			// 
			chartArea1.Name = "ChartArea1";
			chartRate.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			chartRate.Legends.Add(legend1);
			chartRate.Location = new Point(-31, 0);
			chartRate.Name = "chartRate";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			chartRate.Series.Add(series1);
			chartRate.Size = new Size(593, 300);
			chartRate.TabIndex = 11;
			chartRate.Text = "chart1";
			// 
			// gridStats
			// 
			gridStats.AllowUserToAddRows = false;
			gridStats.AllowUserToDeleteRows = false;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.Silver;
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			gridStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			gridStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridStats.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, Column11, Column13, Column8, Column9, Column10, Column12 });
			gridStats.EditMode = DataGridViewEditMode.EditProgrammatically;
			gridStats.Location = new Point(427, 124);
			gridStats.MultiSelect = false;
			gridStats.Name = "gridStats";
			gridStats.RowHeadersVisible = false;
			gridStats.Size = new Size(735, 150);
			gridStats.TabIndex = 12;
			gridStats.CellClick += gridStats_CellClick;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewTextBoxColumn2.HeaderText = "Name";
			dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.True;
			dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.Automatic;
			dataGridViewTextBoxColumn2.Width = 70;
			// 
			// dataGridViewTextBoxColumn7
			// 
			dataGridViewTextBoxColumn7.HeaderText = "From";
			dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			dataGridViewTextBoxColumn7.Width = 110;
			// 
			// dataGridViewTextBoxColumn8
			// 
			dataGridViewTextBoxColumn8.HeaderText = "To";
			dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			dataGridViewTextBoxColumn8.Width = 110;
			// 
			// dataGridViewTextBoxColumn9
			// 
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewTextBoxColumn9.HeaderText = "Count";
			dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			dataGridViewTextBoxColumn9.Width = 70;
			// 
			// Column11
			// 
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column11.DefaultCellStyle = dataGridViewCellStyle5;
			Column11.HeaderText = "Sampling";
			Column11.Name = "Column11";
			Column11.Width = 70;
			// 
			// Column13
			// 
			dataGridViewCellStyle6.BackColor = Color.FromArgb(64, 64, 64);
			Column13.DefaultCellStyle = dataGridViewCellStyle6;
			Column13.HeaderText = "";
			Column13.Name = "Column13";
			Column13.Width = 10;
			// 
			// Column8
			// 
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column8.DefaultCellStyle = dataGridViewCellStyle7;
			Column8.HeaderText = "Minimum";
			Column8.Name = "Column8";
			Column8.ReadOnly = true;
			Column8.Width = 65;
			// 
			// Column9
			// 
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column9.DefaultCellStyle = dataGridViewCellStyle8;
			Column9.HeaderText = "Maximum";
			Column9.Name = "Column9";
			Column9.ReadOnly = true;
			Column9.Width = 65;
			// 
			// Column10
			// 
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column10.DefaultCellStyle = dataGridViewCellStyle9;
			Column10.HeaderText = "Average";
			Column10.Name = "Column10";
			Column10.ReadOnly = true;
			Column10.Width = 65;
			// 
			// Column12
			// 
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column12.DefaultCellStyle = dataGridViewCellStyle10;
			Column12.HeaderText = "Std Div";
			Column12.Name = "Column12";
			Column12.ReadOnly = true;
			Column12.Width = 75;
			// 
			// dlgOpenCsv
			// 
			dlgOpenCsv.DefaultExt = "*.csv";
			dlgOpenCsv.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
			// 
			// dlgSaveCsv
			// 
			dlgSaveCsv.DefaultExt = "*.csv";
			dlgSaveCsv.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txtEndDate);
			groupBox1.Controls.Add(txtStartDate);
			groupBox1.Controls.Add(gboxDel);
			groupBox1.Controls.Add(gboxManipulation);
			groupBox1.Controls.Add(btnPointRefresh);
			groupBox1.Controls.Add(comboPoints);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(txtPointCount);
			groupBox1.Controls.Add(label14);
			groupBox1.Controls.Add(label13);
			groupBox1.Controls.Add(label12);
			groupBox1.Controls.Add(label11);
			groupBox1.Controls.Add(txtStdDiv);
			groupBox1.Controls.Add(txtAverage);
			groupBox1.Controls.Add(txtMax);
			groupBox1.Controls.Add(txtMin);
			groupBox1.Controls.Add(label10);
			groupBox1.Controls.Add(label9);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(txtRate);
			groupBox1.Location = new Point(16, 280);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(491, 306);
			groupBox1.TabIndex = 14;
			groupBox1.TabStop = false;
			groupBox1.Text = "New Points";
			// 
			// txtEndDate
			// 
			txtEndDate.Location = new Point(100, 77);
			txtEndDate.Name = "txtEndDate";
			txtEndDate.ReadOnly = true;
			txtEndDate.Size = new Size(103, 23);
			txtEndDate.TabIndex = 62;
			txtEndDate.TextAlign = HorizontalAlignment.Center;
			// 
			// txtStartDate
			// 
			txtStartDate.Location = new Point(100, 48);
			txtStartDate.Name = "txtStartDate";
			txtStartDate.ReadOnly = true;
			txtStartDate.Size = new Size(103, 23);
			txtStartDate.TabIndex = 61;
			txtStartDate.TextAlign = HorizontalAlignment.Center;
			// 
			// gboxDel
			// 
			gboxDel.Controls.Add(rbDelNone);
			gboxDel.Controls.Add(rbDelByValue);
			gboxDel.Controls.Add(gboxDelDates);
			gboxDel.Controls.Add(rbDelDates);
			gboxDel.Controls.Add(gboxDelRates);
			gboxDel.Controls.Add(rbDelAll);
			gboxDel.Controls.Add(btnPointRadDel);
			gboxDel.Controls.Add(btnSetBoundaries);
			gboxDel.Location = new Point(209, 93);
			gboxDel.Name = "gboxDel";
			gboxDel.Size = new Size(279, 202);
			gboxDel.TabIndex = 60;
			gboxDel.TabStop = false;
			gboxDel.Text = "Delete";
			// 
			// rbDelNone
			// 
			rbDelNone.AutoSize = true;
			rbDelNone.Checked = true;
			rbDelNone.Location = new Point(10, 23);
			rbDelNone.Name = "rbDelNone";
			rbDelNone.Size = new Size(54, 19);
			rbDelNone.TabIndex = 63;
			rbDelNone.TabStop = true;
			rbDelNone.Text = "None";
			rbDelNone.UseVisualStyleBackColor = true;
			// 
			// rbDelByValue
			// 
			rbDelByValue.AutoSize = true;
			rbDelByValue.Location = new Point(11, 76);
			rbDelByValue.Name = "rbDelByValue";
			rbDelByValue.Size = new Size(74, 19);
			rbDelByValue.TabIndex = 62;
			rbDelByValue.Text = "By Values";
			rbDelByValue.UseVisualStyleBackColor = true;
			// 
			// gboxDelDates
			// 
			gboxDelDates.BackColor = Color.LightGray;
			gboxDelDates.Controls.Add(dtpDelTo);
			gboxDelDates.Controls.Add(label2);
			gboxDelDates.Controls.Add(dtpDelFrom);
			gboxDelDates.Controls.Add(label3);
			gboxDelDates.Location = new Point(88, 90);
			gboxDelDates.Name = "gboxDelDates";
			gboxDelDates.Size = new Size(184, 74);
			gboxDelDates.TabIndex = 54;
			gboxDelDates.TabStop = false;
			gboxDelDates.Text = "By Dates";
			// 
			// dtpDelTo
			// 
			dtpDelTo.CustomFormat = "dd/MM/yyyy, HH:mm:ss";
			dtpDelTo.Format = DateTimePickerFormat.Custom;
			dtpDelTo.Location = new Point(40, 49);
			dtpDelTo.Name = "dtpDelTo";
			dtpDelTo.Size = new Size(137, 23);
			dtpDelTo.TabIndex = 53;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(2, 23);
			label2.Name = "label2";
			label2.Size = new Size(35, 15);
			label2.TabIndex = 0;
			label2.Text = "From";
			// 
			// dtpDelFrom
			// 
			dtpDelFrom.CustomFormat = "dd/MM/yyyy, hh:mm:ss";
			dtpDelFrom.Format = DateTimePickerFormat.Custom;
			dtpDelFrom.Location = new Point(40, 19);
			dtpDelFrom.Name = "dtpDelFrom";
			dtpDelFrom.Size = new Size(137, 23);
			dtpDelFrom.TabIndex = 52;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(2, 53);
			label3.Name = "label3";
			label3.Size = new Size(32, 15);
			label3.TabIndex = 1;
			label3.Text = "Until";
			// 
			// rbDelDates
			// 
			rbDelDates.AutoSize = true;
			rbDelDates.Location = new Point(11, 58);
			rbDelDates.Name = "rbDelDates";
			rbDelDates.Size = new Size(70, 19);
			rbDelDates.TabIndex = 61;
			rbDelDates.Text = "By Dates";
			rbDelDates.UseVisualStyleBackColor = true;
			// 
			// gboxDelRates
			// 
			gboxDelRates.Controls.Add(txtDelVal);
			gboxDelRates.Controls.Add(label4);
			gboxDelRates.Controls.Add(rbDelLt);
			gboxDelRates.Controls.Add(rbDelEq);
			gboxDelRates.Controls.Add(rbDelGt);
			gboxDelRates.Location = new Point(92, 6);
			gboxDelRates.Name = "gboxDelRates";
			gboxDelRates.Size = new Size(184, 77);
			gboxDelRates.TabIndex = 58;
			gboxDelRates.TabStop = false;
			gboxDelRates.Text = "By Rates";
			// 
			// txtDelVal
			// 
			txtDelVal.Location = new Point(85, 37);
			txtDelVal.Name = "txtDelVal";
			txtDelVal.Size = new Size(69, 23);
			txtDelVal.TabIndex = 55;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(10, 37);
			label4.Name = "label4";
			label4.Size = new Size(30, 15);
			label4.TabIndex = 2;
			label4.Text = "Rate";
			// 
			// rbDelLt
			// 
			rbDelLt.AutoSize = true;
			rbDelLt.Location = new Point(46, 19);
			rbDelLt.Name = "rbDelLt";
			rbDelLt.Size = new Size(33, 19);
			rbDelLt.TabIndex = 5;
			rbDelLt.TabStop = true;
			rbDelLt.Text = "<";
			rbDelLt.UseVisualStyleBackColor = true;
			// 
			// rbDelEq
			// 
			rbDelEq.AutoSize = true;
			rbDelEq.Location = new Point(46, 35);
			rbDelEq.Name = "rbDelEq";
			rbDelEq.Size = new Size(33, 19);
			rbDelEq.TabIndex = 3;
			rbDelEq.TabStop = true;
			rbDelEq.Text = "=";
			rbDelEq.UseVisualStyleBackColor = true;
			// 
			// rbDelGt
			// 
			rbDelGt.AutoSize = true;
			rbDelGt.Location = new Point(46, 51);
			rbDelGt.Name = "rbDelGt";
			rbDelGt.Size = new Size(33, 19);
			rbDelGt.TabIndex = 4;
			rbDelGt.TabStop = true;
			rbDelGt.Text = ">";
			rbDelGt.UseVisualStyleBackColor = true;
			// 
			// rbDelAll
			// 
			rbDelAll.AutoSize = true;
			rbDelAll.Location = new Point(11, 40);
			rbDelAll.Name = "rbDelAll";
			rbDelAll.Size = new Size(39, 19);
			rbDelAll.TabIndex = 60;
			rbDelAll.Text = "All";
			rbDelAll.UseVisualStyleBackColor = true;
			// 
			// btnPointRadDel
			// 
			btnPointRadDel.Location = new Point(107, 174);
			btnPointRadDel.Name = "btnPointRadDel";
			btnPointRadDel.Size = new Size(75, 23);
			btnPointRadDel.TabIndex = 59;
			btnPointRadDel.Text = "Delete";
			btnPointRadDel.UseVisualStyleBackColor = true;
			btnPointRadDel.Click += btnPointRadDel_Click;
			// 
			// gboxManipulation
			// 
			gboxManipulation.Controls.Add(rbOpintNone);
			gboxManipulation.Controls.Add(rbPointDel);
			gboxManipulation.Controls.Add(radioButton2);
			gboxManipulation.Location = new Point(352, 8);
			gboxManipulation.Name = "gboxManipulation";
			gboxManipulation.Size = new Size(102, 84);
			gboxManipulation.TabIndex = 59;
			gboxManipulation.TabStop = false;
			gboxManipulation.Text = "Manipulation";
			// 
			// rbOpintNone
			// 
			rbOpintNone.AutoSize = true;
			rbOpintNone.Checked = true;
			rbOpintNone.Location = new Point(15, 22);
			rbOpintNone.Name = "rbOpintNone";
			rbOpintNone.Size = new Size(54, 19);
			rbOpintNone.TabIndex = 58;
			rbOpintNone.TabStop = true;
			rbOpintNone.Text = "None";
			rbOpintNone.UseVisualStyleBackColor = true;
			// 
			// rbPointDel
			// 
			rbPointDel.AutoSize = true;
			rbPointDel.Location = new Point(15, 41);
			rbPointDel.Name = "rbPointDel";
			rbPointDel.Size = new Size(58, 19);
			rbPointDel.TabIndex = 56;
			rbPointDel.Text = "Delete";
			rbPointDel.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(15, 60);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(54, 19);
			radioButton2.TabIndex = 57;
			radioButton2.Text = "Insert";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// btnPointRefresh
			// 
			btnPointRefresh.Location = new Point(246, 14);
			btnPointRefresh.Name = "btnPointRefresh";
			btnPointRefresh.Size = new Size(75, 23);
			btnPointRefresh.TabIndex = 55;
			btnPointRefresh.Text = "Refresh";
			btnPointRefresh.UseVisualStyleBackColor = true;
			btnPointRefresh.Click += btnPointRefresh_Click;
			// 
			// comboPoints
			// 
			comboPoints.DropDownStyle = ComboBoxStyle.DropDownList;
			comboPoints.FormattingEnabled = true;
			comboPoints.Location = new Point(83, 14);
			comboPoints.Name = "comboPoints";
			comboPoints.Size = new Size(157, 23);
			comboPoints.TabIndex = 54;
			comboPoints.DropDownClosed += comboPoints_DropDownClosed;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(32, 18);
			label1.Name = "label1";
			label1.Size = new Size(35, 15);
			label1.TabIndex = 53;
			label1.Text = "Point";
			// 
			// txtPointCount
			// 
			txtPointCount.Location = new Point(103, 134);
			txtPointCount.Name = "txtPointCount";
			txtPointCount.ReadOnly = true;
			txtPointCount.Size = new Size(100, 23);
			txtPointCount.TabIndex = 52;
			txtPointCount.TextAlign = HorizontalAlignment.Center;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(5, 107);
			label14.Name = "label14";
			label14.Size = new Size(83, 15);
			label14.TabIndex = 49;
			label14.Text = "Sampling Rate";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(44, 134);
			label13.Name = "label13";
			label13.Size = new Size(40, 15);
			label13.TabIndex = 48;
			label13.Text = "Count";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(63, 77);
			label12.Name = "label12";
			label12.Size = new Size(27, 15);
			label12.TabIndex = 47;
			label12.Text = "End";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(63, 53);
			label11.Name = "label11";
			label11.Size = new Size(31, 15);
			label11.TabIndex = 46;
			label11.Text = "Start";
			// 
			// txtStdDiv
			// 
			txtStdDiv.Location = new Point(103, 251);
			txtStdDiv.Name = "txtStdDiv";
			txtStdDiv.ReadOnly = true;
			txtStdDiv.Size = new Size(57, 23);
			txtStdDiv.TabIndex = 45;
			txtStdDiv.TextAlign = HorizontalAlignment.Center;
			// 
			// txtAverage
			// 
			txtAverage.Location = new Point(103, 222);
			txtAverage.Name = "txtAverage";
			txtAverage.ReadOnly = true;
			txtAverage.Size = new Size(57, 23);
			txtAverage.TabIndex = 44;
			txtAverage.TextAlign = HorizontalAlignment.Center;
			// 
			// txtMax
			// 
			txtMax.Location = new Point(103, 193);
			txtMax.Name = "txtMax";
			txtMax.ReadOnly = true;
			txtMax.Size = new Size(57, 23);
			txtMax.TabIndex = 43;
			txtMax.TextAlign = HorizontalAlignment.Center;
			// 
			// txtMin
			// 
			txtMin.Location = new Point(103, 165);
			txtMin.Name = "txtMin";
			txtMin.ReadOnly = true;
			txtMin.Size = new Size(57, 23);
			txtMin.TabIndex = 42;
			txtMin.TextAlign = HorizontalAlignment.Center;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(-10, 251);
			label10.Name = "label10";
			label10.Size = new Size(107, 15);
			label10.TabIndex = 41;
			label10.Text = "Standard Deviation";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(47, 225);
			label9.Name = "label9";
			label9.Size = new Size(50, 15);
			label9.TabIndex = 40;
			label9.Text = "Average";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(35, 196);
			label8.Name = "label8";
			label8.Size = new Size(62, 15);
			label8.TabIndex = 39;
			label8.Text = "Maximum";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(37, 168);
			label7.Name = "label7";
			label7.Size = new Size(60, 15);
			label7.TabIndex = 38;
			label7.Text = "Minimum";
			// 
			// txtRate
			// 
			txtRate.Location = new Point(103, 105);
			txtRate.Name = "txtRate";
			txtRate.ReadOnly = true;
			txtRate.Size = new Size(100, 23);
			txtRate.TabIndex = 37;
			txtRate.TextAlign = HorizontalAlignment.Center;
			// 
			// btnExport
			// 
			btnExport.Location = new Point(300, 95);
			btnExport.Name = "btnExport";
			btnExport.Size = new Size(105, 23);
			btnExport.TabIndex = 1;
			btnExport.Text = "Export to CSV...";
			btnExport.UseVisualStyleBackColor = true;
			btnExport.Click += btnExport_Click;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Location = new Point(530, 280);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(644, 331);
			tabControl1.TabIndex = 15;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(chartRate);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(636, 303);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Rate vs Time";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(636, 303);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Histogram";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1174, 611);
			Controls.Add(tabControl1);
			Controls.Add(groupBox1);
			Controls.Add(btnExport);
			Controls.Add(gridStats);
			Controls.Add(btnLoadRads);
			Controls.Add(btnLoadPoints);
			Controls.Add(gridPoints);
			Controls.Add(btnLoadMaps);
			Controls.Add(toolbar);
			Controls.Add(status_bar);
			Controls.Add(comboMaps);
			Controls.Add(menuMain);
			MainMenuStrip = menuMain;
			Name = "frmMain";
			Text = "WebiSmarts Data Generetor";
			FormClosed += frmMain_FormClosed;
			Load += frmMain_Load;
			menuMain.ResumeLayout(false);
			menuMain.PerformLayout();
			status_bar.ResumeLayout(false);
			status_bar.PerformLayout();
			toolbar.ResumeLayout(false);
			toolbar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)gridPoints).EndInit();
			((System.ComponentModel.ISupportInitialize)chartRate).EndInit();
			((System.ComponentModel.ISupportInitialize)gridStats).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			gboxDel.ResumeLayout(false);
			gboxDel.PerformLayout();
			gboxDelDates.ResumeLayout(false);
			gboxDelDates.PerformLayout();
			gboxDelRates.ResumeLayout(false);
			gboxDelRates.PerformLayout();
			gboxManipulation.ResumeLayout(false);
			gboxManipulation.PerformLayout();
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuMain;
		private ToolStripMenuItem popupFile;
		private ToolStripMenuItem miDatabase;
		private ToolStripSeparator miFileSep1;
		private ToolStripMenuItem miExit;
		private ToolStripMenuItem popupHelp;
		private ToolStripMenuItem miAbout;
		private Button btnSetBoundaries;
		private ComboBox comboMaps;
		private StatusStrip status_bar;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStripStatusLabel toolStripStatusLabel2;
		private ToolStripStatusLabel toolStripStatusLabel3;
		private ToolStrip toolbar;
		private ToolStripButton btnConnect;
		private ToolStripButton btnDisconnect;
		private Button btnLoadMaps;
		private DataGridView gridPoints;
		private Button btnLoadPoints;
		private Button btnLoadRads;
		private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartRate;
		private DataGridView gridStats;
		private DataGridViewCheckBoxColumn Column1;
		private DataGridViewTextBoxColumn Column7;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column5;
		private ToolStripButton btnMaps;
		private ToolStripMenuItem popupData;
		private ToolStripMenuItem miPointsExport;
		private ToolStripMenuItem importFromCSVToolStripMenuItem;
		private OpenFileDialog dlgOpenCsv;
		private SaveFileDialog dlgSaveCsv;
		private GroupBox groupBox1;
		private TextBox txtPointCount;
		private Label label14;
		private Label label13;
		private Label label12;
		private Label label11;
		private TextBox txtStdDiv;
		private TextBox txtAverage;
		private TextBox txtMax;
		private TextBox txtMin;
		private Label label10;
		private Label label9;
		private Label label8;
		private Label label7;
		private TextBox txtRate;
		private Button btnExport;
		private DataGridViewLinkColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private DataGridViewTextBoxColumn Column11;
		private DataGridViewTextBoxColumn Column13;
		private DataGridViewTextBoxColumn Column8;
		private DataGridViewTextBoxColumn Column9;
		private DataGridViewTextBoxColumn Column10;
		private DataGridViewTextBoxColumn Column12;
		private Label label1;
		private Button btnPointRefresh;
		private ComboBox comboPoints;
		private RadioButton radioButton2;
		private RadioButton rbPointDel;
		private GroupBox gboxDelDates;
		private DateTimePicker dtpDelTo;
		private DateTimePicker dtpDelFrom;
		private RadioButton rbDelLt;
		private RadioButton rbDelGt;
		private RadioButton rbDelEq;
		private Label label4;
		private Label label3;
		private Label label2;
		private GroupBox gboxDelRates;
		private TextBox txtDelVal;
		private RadioButton rbDelByValue;
		private RadioButton rbDelDates;
		private RadioButton rbDelAll;
		private Button btnPointRadDel;
		private RadioButton rbDelNone;
		private RadioButton rbOpintNone;
		private GroupBox gboxDel;
		private GroupBox gboxManipulation;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TextBox txtStartDate;
		private TextBox txtEndDate;
	}
}
