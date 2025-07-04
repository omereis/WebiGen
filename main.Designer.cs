﻿namespace WebiGen
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
			DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
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
			groupBox2 = new GroupBox();
			radioMilliRem = new RadioButton();
			radioRem = new RadioButton();
			txtEndDate = new TextBox();
			txtStartDate = new TextBox();
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
			btnHistogramRefresh = new Button();
			gridHistogram = new DataGridView();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			Column14 = new DataGridViewTextBoxColumn();
			tabControl2 = new TabControl();
			tabInsert = new TabPage();
			label22 = new Label();
			txtDoseReset = new TextBox();
			label21 = new Label();
			label20 = new Label();
			btnInsertDefault = new Button();
			btnCalculateInsert = new Button();
			groupBox3 = new GroupBox();
			radiInsertMiliRem = new RadioButton();
			radiInsertRem = new RadioButton();
			txtInsertAvg = new TextBox();
			txtInsertMax = new TextBox();
			txtInsertMin = new TextBox();
			txtInsertSampling = new TextBox();
			btnInsertCount = new Button();
			txtInsertCount = new TextBox();
			btnInsStartByCount = new Button();
			btnInsCurrentStart = new Button();
			dtpInsertEnd = new DateTimePicker();
			dtpInsertStart = new DateTimePicker();
			label19 = new Label();
			label18 = new Label();
			label17 = new Label();
			label16 = new Label();
			label15 = new Label();
			label6 = new Label();
			label5 = new Label();
			tabDelete = new TabPage();
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
			btnSetBoundaries = new Button();
			menuMain.SuspendLayout();
			status_bar.SuspendLayout();
			toolbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridPoints).BeginInit();
			((System.ComponentModel.ISupportInitialize)chartRate).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridStats).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridHistogram).BeginInit();
			tabControl2.SuspendLayout();
			tabInsert.SuspendLayout();
			groupBox3.SuspendLayout();
			tabDelete.SuspendLayout();
			gboxDelDates.SuspendLayout();
			gboxDelRates.SuspendLayout();
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
			status_bar.Location = new Point(0, 616);
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
			dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = Color.Silver;
			dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
			gridPoints.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
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
			dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column7.DefaultCellStyle = dataGridViewCellStyle15;
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
			chartArea2.Name = "ChartArea1";
			chartRate.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			chartRate.Legends.Add(legend2);
			chartRate.Location = new Point(-31, 0);
			chartRate.Name = "chartRate";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			chartRate.Series.Add(series2);
			chartRate.Size = new Size(593, 300);
			chartRate.TabIndex = 11;
			chartRate.Text = "chart1";
			// 
			// gridStats
			// 
			gridStats.AllowUserToAddRows = false;
			gridStats.AllowUserToDeleteRows = false;
			dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = Color.Silver;
			dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
			gridStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
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
			dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle17;
			dataGridViewTextBoxColumn9.HeaderText = "Count";
			dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			dataGridViewTextBoxColumn9.Width = 70;
			// 
			// Column11
			// 
			dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column11.DefaultCellStyle = dataGridViewCellStyle18;
			Column11.HeaderText = "Sampling";
			Column11.Name = "Column11";
			Column11.Width = 70;
			// 
			// Column13
			// 
			dataGridViewCellStyle19.BackColor = Color.FromArgb(64, 64, 64);
			Column13.DefaultCellStyle = dataGridViewCellStyle19;
			Column13.HeaderText = "";
			Column13.Name = "Column13";
			Column13.Width = 10;
			// 
			// Column8
			// 
			dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column8.DefaultCellStyle = dataGridViewCellStyle20;
			Column8.HeaderText = "Minimum";
			Column8.Name = "Column8";
			Column8.ReadOnly = true;
			Column8.Width = 65;
			// 
			// Column9
			// 
			dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column9.DefaultCellStyle = dataGridViewCellStyle21;
			Column9.HeaderText = "Maximum";
			Column9.Name = "Column9";
			Column9.ReadOnly = true;
			Column9.Width = 65;
			// 
			// Column10
			// 
			dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column10.DefaultCellStyle = dataGridViewCellStyle22;
			Column10.HeaderText = "Average";
			Column10.Name = "Column10";
			Column10.ReadOnly = true;
			Column10.Width = 65;
			// 
			// Column12
			// 
			dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column12.DefaultCellStyle = dataGridViewCellStyle23;
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
			groupBox1.BackColor = Color.White;
			groupBox1.Controls.Add(groupBox2);
			groupBox1.Controls.Add(txtEndDate);
			groupBox1.Controls.Add(txtStartDate);
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
			groupBox1.Size = new Size(241, 282);
			groupBox1.TabIndex = 14;
			groupBox1.TabStop = false;
			groupBox1.Text = "New Points";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(radioMilliRem);
			groupBox2.Controls.Add(radioRem);
			groupBox2.Location = new Point(164, 184);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(71, 76);
			groupBox2.TabIndex = 63;
			groupBox2.TabStop = false;
			groupBox2.Text = "Units";
			// 
			// radioMilliRem
			// 
			radioMilliRem.AutoSize = true;
			radioMilliRem.Location = new Point(9, 44);
			radioMilliRem.Name = "radioMilliRem";
			radioMilliRem.Size = new Size(60, 19);
			radioMilliRem.TabIndex = 1;
			radioMilliRem.TabStop = true;
			radioMilliRem.Text = "mRem";
			radioMilliRem.UseVisualStyleBackColor = true;
			radioMilliRem.CheckedChanged += radioMilliRem_CheckedChanged;
			// 
			// radioRem
			// 
			radioRem.AutoSize = true;
			radioRem.Checked = true;
			radioRem.Location = new Point(9, 19);
			radioRem.Name = "radioRem";
			radioRem.Size = new Size(49, 19);
			radioRem.TabIndex = 0;
			radioRem.TabStop = true;
			radioRem.Text = "Rem";
			radioRem.UseVisualStyleBackColor = true;
			radioRem.CheckedChanged += radioRem_CheckedChanged;
			// 
			// txtEndDate
			// 
			txtEndDate.Location = new Point(86, 71);
			txtEndDate.Name = "txtEndDate";
			txtEndDate.ReadOnly = true;
			txtEndDate.Size = new Size(115, 23);
			txtEndDate.TabIndex = 62;
			txtEndDate.TextAlign = HorizontalAlignment.Center;
			// 
			// txtStartDate
			// 
			txtStartDate.Location = new Point(86, 42);
			txtStartDate.Name = "txtStartDate";
			txtStartDate.ReadOnly = true;
			txtStartDate.Size = new Size(115, 23);
			txtStartDate.TabIndex = 61;
			txtStartDate.TextAlign = HorizontalAlignment.Center;
			// 
			// btnPointRefresh
			// 
			btnPointRefresh.Location = new Point(173, 13);
			btnPointRefresh.Name = "btnPointRefresh";
			btnPointRefresh.Size = new Size(60, 23);
			btnPointRefresh.TabIndex = 55;
			btnPointRefresh.Text = "Refresh";
			btnPointRefresh.UseVisualStyleBackColor = true;
			btnPointRefresh.Click += btnPointRefresh_Click;
			// 
			// comboPoints
			// 
			comboPoints.DropDownStyle = ComboBoxStyle.DropDownList;
			comboPoints.FormattingEnabled = true;
			comboPoints.Location = new Point(44, 15);
			comboPoints.Name = "comboPoints";
			comboPoints.Size = new Size(123, 23);
			comboPoints.TabIndex = 54;
			comboPoints.DropDownClosed += comboPoints_DropDownClosed;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 19);
			label1.Name = "label1";
			label1.Size = new Size(35, 15);
			label1.TabIndex = 53;
			label1.Text = "Point";
			// 
			// txtPointCount
			// 
			txtPointCount.Location = new Point(101, 128);
			txtPointCount.Name = "txtPointCount";
			txtPointCount.ReadOnly = true;
			txtPointCount.Size = new Size(57, 23);
			txtPointCount.TabIndex = 52;
			txtPointCount.TextAlign = HorizontalAlignment.Center;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(3, 101);
			label14.Name = "label14";
			label14.Size = new Size(83, 15);
			label14.TabIndex = 49;
			label14.Text = "Sampling Rate";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(42, 128);
			label13.Name = "label13";
			label13.Size = new Size(40, 15);
			label13.TabIndex = 48;
			label13.Text = "Count";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(49, 71);
			label12.Name = "label12";
			label12.Size = new Size(27, 15);
			label12.TabIndex = 47;
			label12.Text = "End";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(49, 47);
			label11.Name = "label11";
			label11.Size = new Size(31, 15);
			label11.TabIndex = 46;
			label11.Text = "Start";
			// 
			// txtStdDiv
			// 
			txtStdDiv.Location = new Point(101, 245);
			txtStdDiv.Name = "txtStdDiv";
			txtStdDiv.ReadOnly = true;
			txtStdDiv.Size = new Size(57, 23);
			txtStdDiv.TabIndex = 45;
			txtStdDiv.TextAlign = HorizontalAlignment.Center;
			// 
			// txtAverage
			// 
			txtAverage.Location = new Point(101, 216);
			txtAverage.Name = "txtAverage";
			txtAverage.ReadOnly = true;
			txtAverage.Size = new Size(57, 23);
			txtAverage.TabIndex = 44;
			txtAverage.TextAlign = HorizontalAlignment.Center;
			// 
			// txtMax
			// 
			txtMax.Location = new Point(101, 187);
			txtMax.Name = "txtMax";
			txtMax.ReadOnly = true;
			txtMax.Size = new Size(57, 23);
			txtMax.TabIndex = 43;
			txtMax.TextAlign = HorizontalAlignment.Center;
			// 
			// txtMin
			// 
			txtMin.Location = new Point(101, 159);
			txtMin.Name = "txtMin";
			txtMin.ReadOnly = true;
			txtMin.Size = new Size(57, 23);
			txtMin.TabIndex = 42;
			txtMin.TextAlign = HorizontalAlignment.Center;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(-12, 245);
			label10.Name = "label10";
			label10.Size = new Size(107, 15);
			label10.TabIndex = 41;
			label10.Text = "Standard Deviation";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(45, 219);
			label9.Name = "label9";
			label9.Size = new Size(50, 15);
			label9.TabIndex = 40;
			label9.Text = "Average";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(33, 190);
			label8.Name = "label8";
			label8.Size = new Size(62, 15);
			label8.TabIndex = 39;
			label8.Text = "Maximum";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(35, 162);
			label7.Name = "label7";
			label7.Size = new Size(60, 15);
			label7.TabIndex = 38;
			label7.Text = "Minimum";
			// 
			// txtRate
			// 
			txtRate.Location = new Point(101, 99);
			txtRate.Name = "txtRate";
			txtRate.ReadOnly = true;
			txtRate.Size = new Size(57, 23);
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
			tabControl1.Location = new Point(572, 280);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(602, 352);
			tabControl1.TabIndex = 15;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(chartRate);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(594, 324);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Rate vs Time";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(btnHistogramRefresh);
			tabPage2.Controls.Add(gridHistogram);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(594, 324);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Histogram";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnHistogramRefresh
			// 
			btnHistogramRefresh.Location = new Point(274, 13);
			btnHistogramRefresh.Name = "btnHistogramRefresh";
			btnHistogramRefresh.Size = new Size(75, 23);
			btnHistogramRefresh.TabIndex = 14;
			btnHistogramRefresh.Text = "Histogram";
			btnHistogramRefresh.UseVisualStyleBackColor = true;
			btnHistogramRefresh.Click += btnHistogramRefresh_Click;
			// 
			// gridHistogram
			// 
			gridHistogram.AllowUserToAddRows = false;
			gridHistogram.AllowUserToDeleteRows = false;
			dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle24.BackColor = Color.Silver;
			dataGridViewCellStyle24.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle24.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle24.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
			gridHistogram.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
			gridHistogram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridHistogram.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column14 });
			gridHistogram.EditMode = DataGridViewEditMode.EditProgrammatically;
			gridHistogram.Location = new Point(6, 3);
			gridHistogram.MultiSelect = false;
			gridHistogram.Name = "gridHistogram";
			gridHistogram.RowHeadersVisible = false;
			gridHistogram.Size = new Size(252, 306);
			gridHistogram.TabIndex = 13;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle25;
			dataGridViewTextBoxColumn1.HeaderText = "Rate";
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.Width = 110;
			// 
			// Column14
			// 
			dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column14.DefaultCellStyle = dataGridViewCellStyle26;
			Column14.HeaderText = "Count";
			Column14.Name = "Column14";
			// 
			// tabControl2
			// 
			tabControl2.Controls.Add(tabInsert);
			tabControl2.Controls.Add(tabDelete);
			tabControl2.Location = new Point(263, 287);
			tabControl2.Name = "tabControl2";
			tabControl2.SelectedIndex = 0;
			tabControl2.Size = new Size(303, 290);
			tabControl2.TabIndex = 64;
			// 
			// tabInsert
			// 
			tabInsert.BackColor = Color.LightSkyBlue;
			tabInsert.Controls.Add(label22);
			tabInsert.Controls.Add(txtDoseReset);
			tabInsert.Controls.Add(label21);
			tabInsert.Controls.Add(label20);
			tabInsert.Controls.Add(btnInsertDefault);
			tabInsert.Controls.Add(btnCalculateInsert);
			tabInsert.Controls.Add(groupBox3);
			tabInsert.Controls.Add(txtInsertAvg);
			tabInsert.Controls.Add(txtInsertMax);
			tabInsert.Controls.Add(txtInsertMin);
			tabInsert.Controls.Add(txtInsertSampling);
			tabInsert.Controls.Add(btnInsertCount);
			tabInsert.Controls.Add(txtInsertCount);
			tabInsert.Controls.Add(btnInsStartByCount);
			tabInsert.Controls.Add(btnInsCurrentStart);
			tabInsert.Controls.Add(dtpInsertEnd);
			tabInsert.Controls.Add(dtpInsertStart);
			tabInsert.Controls.Add(label19);
			tabInsert.Controls.Add(label18);
			tabInsert.Controls.Add(label17);
			tabInsert.Controls.Add(label16);
			tabInsert.Controls.Add(label15);
			tabInsert.Controls.Add(label6);
			tabInsert.Controls.Add(label5);
			tabInsert.Location = new Point(4, 24);
			tabInsert.Name = "tabInsert";
			tabInsert.Padding = new Padding(3);
			tabInsert.Size = new Size(295, 262);
			tabInsert.TabIndex = 0;
			tabInsert.Text = "Insert";
			// 
			// label22
			// 
			label22.AutoSize = true;
			label22.Location = new Point(160, 201);
			label22.Name = "label22";
			label22.Size = new Size(39, 15);
			label22.TabIndex = 91;
			label22.Text = "Hours";
			// 
			// txtDoseReset
			// 
			txtDoseReset.Location = new Point(89, 198);
			txtDoseReset.Name = "txtDoseReset";
			txtDoseReset.Size = new Size(69, 23);
			txtDoseReset.TabIndex = 90;
			txtDoseReset.Text = "24";
			txtDoseReset.TextAlign = HorizontalAlignment.Center;
			// 
			// label21
			// 
			label21.AutoSize = true;
			label21.Location = new Point(19, 201);
			label21.Name = "label21";
			label21.Size = new Size(64, 15);
			label21.TabIndex = 89;
			label21.Text = "Reset Dose";
			// 
			// label20
			// 
			label20.AutoSize = true;
			label20.Location = new Point(160, 90);
			label20.Name = "label20";
			label20.Size = new Size(51, 15);
			label20.TabIndex = 88;
			label20.Text = "Seconds";
			// 
			// btnInsertDefault
			// 
			btnInsertDefault.Location = new Point(16, 233);
			btnInsertDefault.Name = "btnInsertDefault";
			btnInsertDefault.Size = new Size(75, 23);
			btnInsertDefault.TabIndex = 87;
			btnInsertDefault.Text = "Default";
			btnInsertDefault.UseVisualStyleBackColor = true;
			btnInsertDefault.Click += btnInsertDefault_Click;
			// 
			// btnCalculateInsert
			// 
			btnCalculateInsert.Location = new Point(97, 233);
			btnCalculateInsert.Name = "btnCalculateInsert";
			btnCalculateInsert.Size = new Size(75, 23);
			btnCalculateInsert.TabIndex = 86;
			btnCalculateInsert.Text = "Calculate";
			btnCalculateInsert.UseVisualStyleBackColor = true;
			btnCalculateInsert.Click += btnCalculateInsert_Click;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(radiInsertMiliRem);
			groupBox3.Controls.Add(radiInsertRem);
			groupBox3.Location = new Point(193, 111);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(76, 76);
			groupBox3.TabIndex = 85;
			groupBox3.TabStop = false;
			groupBox3.Text = "Units";
			// 
			// radiInsertMiliRem
			// 
			radiInsertMiliRem.AutoSize = true;
			radiInsertMiliRem.Location = new Point(9, 44);
			radiInsertMiliRem.Name = "radiInsertMiliRem";
			radiInsertMiliRem.Size = new Size(60, 19);
			radiInsertMiliRem.TabIndex = 1;
			radiInsertMiliRem.TabStop = true;
			radiInsertMiliRem.Text = "mRem";
			radiInsertMiliRem.UseVisualStyleBackColor = true;
			// 
			// radiInsertRem
			// 
			radiInsertRem.AutoSize = true;
			radiInsertRem.Checked = true;
			radiInsertRem.Location = new Point(9, 19);
			radiInsertRem.Name = "radiInsertRem";
			radiInsertRem.Size = new Size(49, 19);
			radiInsertRem.TabIndex = 0;
			radiInsertRem.TabStop = true;
			radiInsertRem.Text = "Rem";
			radiInsertRem.UseVisualStyleBackColor = true;
			// 
			// txtInsertAvg
			// 
			txtInsertAvg.Location = new Point(88, 168);
			txtInsertAvg.Name = "txtInsertAvg";
			txtInsertAvg.Size = new Size(70, 23);
			txtInsertAvg.TabIndex = 84;
			txtInsertAvg.TextAlign = HorizontalAlignment.Center;
			// 
			// txtInsertMax
			// 
			txtInsertMax.Location = new Point(88, 141);
			txtInsertMax.Name = "txtInsertMax";
			txtInsertMax.Size = new Size(70, 23);
			txtInsertMax.TabIndex = 83;
			txtInsertMax.TextAlign = HorizontalAlignment.Center;
			// 
			// txtInsertMin
			// 
			txtInsertMin.Location = new Point(88, 114);
			txtInsertMin.Name = "txtInsertMin";
			txtInsertMin.Size = new Size(70, 23);
			txtInsertMin.TabIndex = 82;
			txtInsertMin.TextAlign = HorizontalAlignment.Center;
			// 
			// txtInsertSampling
			// 
			txtInsertSampling.Location = new Point(88, 87);
			txtInsertSampling.Name = "txtInsertSampling";
			txtInsertSampling.Size = new Size(70, 23);
			txtInsertSampling.TabIndex = 81;
			txtInsertSampling.TextAlign = HorizontalAlignment.Center;
			// 
			// btnInsertCount
			// 
			btnInsertCount.Location = new Point(164, 61);
			btnInsertCount.Name = "btnInsertCount";
			btnInsertCount.Size = new Size(105, 23);
			btnInsertCount.TabIndex = 80;
			btnInsertCount.Text = "Counts By Dates";
			btnInsertCount.UseVisualStyleBackColor = true;
			btnInsertCount.Click += btnInsertCount_Click;
			// 
			// txtInsertCount
			// 
			txtInsertCount.Location = new Point(88, 60);
			txtInsertCount.Name = "txtInsertCount";
			txtInsertCount.Size = new Size(70, 23);
			txtInsertCount.TabIndex = 79;
			txtInsertCount.Text = "100000";
			txtInsertCount.TextAlign = HorizontalAlignment.Center;
			// 
			// btnInsStartByCount
			// 
			btnInsStartByCount.Location = new Point(194, 6);
			btnInsStartByCount.Name = "btnInsStartByCount";
			btnInsStartByCount.Size = new Size(75, 23);
			btnInsStartByCount.TabIndex = 78;
			btnInsStartByCount.Text = "By Count";
			btnInsStartByCount.UseVisualStyleBackColor = true;
			btnInsStartByCount.Click += btnInsStartByCount_Click;
			// 
			// btnInsCurrentStart
			// 
			btnInsCurrentStart.Location = new Point(194, 33);
			btnInsCurrentStart.Name = "btnInsCurrentStart";
			btnInsCurrentStart.Size = new Size(75, 23);
			btnInsCurrentStart.TabIndex = 77;
			btnInsCurrentStart.Text = "To Start";
			btnInsCurrentStart.UseVisualStyleBackColor = true;
			btnInsCurrentStart.Click += btnInsCurrentStart_Click;
			// 
			// dtpInsertEnd
			// 
			dtpInsertEnd.CustomFormat = "dd/MM/yyyy, HH:mm:ss";
			dtpInsertEnd.Format = DateTimePickerFormat.Custom;
			dtpInsertEnd.Location = new Point(45, 33);
			dtpInsertEnd.Name = "dtpInsertEnd";
			dtpInsertEnd.Size = new Size(143, 23);
			dtpInsertEnd.TabIndex = 76;
			// 
			// dtpInsertStart
			// 
			dtpInsertStart.CustomFormat = "dd/MM/yyyy, HH:mm:ss";
			dtpInsertStart.Format = DateTimePickerFormat.Custom;
			dtpInsertStart.Location = new Point(45, 6);
			dtpInsertStart.Name = "dtpInsertStart";
			dtpInsertStart.Size = new Size(143, 23);
			dtpInsertStart.TabIndex = 75;
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Location = new Point(26, 172);
			label19.Name = "label19";
			label19.Size = new Size(50, 15);
			label19.TabIndex = 74;
			label19.Text = "Average";
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new Point(14, 145);
			label18.Name = "label18";
			label18.Size = new Size(62, 15);
			label18.TabIndex = 73;
			label18.Text = "Maximum";
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(16, 118);
			label17.Name = "label17";
			label17.Size = new Size(60, 15);
			label17.TabIndex = 72;
			label17.Text = "Minimum";
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(19, 91);
			label16.Name = "label16";
			label16.Size = new Size(57, 15);
			label16.TabIndex = 71;
			label16.Text = "Sampling";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(36, 64);
			label15.Name = "label15";
			label15.Size = new Size(40, 15);
			label15.TabIndex = 70;
			label15.Text = "Count";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(12, 37);
			label6.Name = "label6";
			label6.Size = new Size(27, 15);
			label6.TabIndex = 69;
			label6.Text = "End";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(8, 10);
			label5.Name = "label5";
			label5.Size = new Size(31, 15);
			label5.TabIndex = 68;
			label5.Text = "Start";
			// 
			// tabDelete
			// 
			tabDelete.BackColor = Color.LightSalmon;
			tabDelete.Controls.Add(rbDelNone);
			tabDelete.Controls.Add(rbDelByValue);
			tabDelete.Controls.Add(gboxDelDates);
			tabDelete.Controls.Add(rbDelDates);
			tabDelete.Controls.Add(gboxDelRates);
			tabDelete.Controls.Add(rbDelAll);
			tabDelete.Controls.Add(btnPointRadDel);
			tabDelete.Controls.Add(btnSetBoundaries);
			tabDelete.Location = new Point(4, 24);
			tabDelete.Name = "tabDelete";
			tabDelete.Padding = new Padding(3);
			tabDelete.Size = new Size(295, 262);
			tabDelete.TabIndex = 1;
			tabDelete.Text = "Delete";
			// 
			// rbDelNone
			// 
			rbDelNone.AutoSize = true;
			rbDelNone.Checked = true;
			rbDelNone.Location = new Point(16, 23);
			rbDelNone.Name = "rbDelNone";
			rbDelNone.Size = new Size(54, 19);
			rbDelNone.TabIndex = 71;
			rbDelNone.TabStop = true;
			rbDelNone.Text = "None";
			rbDelNone.UseVisualStyleBackColor = true;
			// 
			// rbDelByValue
			// 
			rbDelByValue.AutoSize = true;
			rbDelByValue.Location = new Point(17, 76);
			rbDelByValue.Name = "rbDelByValue";
			rbDelByValue.Size = new Size(74, 19);
			rbDelByValue.TabIndex = 70;
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
			gboxDelDates.Location = new Point(94, 90);
			gboxDelDates.Name = "gboxDelDates";
			gboxDelDates.Size = new Size(192, 74);
			gboxDelDates.TabIndex = 65;
			gboxDelDates.TabStop = false;
			gboxDelDates.Text = "By Dates";
			// 
			// dtpDelTo
			// 
			dtpDelTo.CustomFormat = "dd/MM/yyyy, HH:mm:ss";
			dtpDelTo.Format = DateTimePickerFormat.Custom;
			dtpDelTo.Location = new Point(40, 47);
			dtpDelTo.Name = "dtpDelTo";
			dtpDelTo.Size = new Size(146, 23);
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
			dtpDelFrom.Location = new Point(40, 20);
			dtpDelFrom.Name = "dtpDelFrom";
			dtpDelFrom.Size = new Size(145, 23);
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
			rbDelDates.Location = new Point(17, 58);
			rbDelDates.Name = "rbDelDates";
			rbDelDates.Size = new Size(70, 19);
			rbDelDates.TabIndex = 69;
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
			gboxDelRates.Location = new Point(98, 6);
			gboxDelRates.Name = "gboxDelRates";
			gboxDelRates.Size = new Size(184, 77);
			gboxDelRates.TabIndex = 66;
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
			rbDelAll.Location = new Point(17, 40);
			rbDelAll.Name = "rbDelAll";
			rbDelAll.Size = new Size(39, 19);
			rbDelAll.TabIndex = 68;
			rbDelAll.Text = "All";
			rbDelAll.UseVisualStyleBackColor = true;
			// 
			// btnPointRadDel
			// 
			btnPointRadDel.Location = new Point(113, 174);
			btnPointRadDel.Name = "btnPointRadDel";
			btnPointRadDel.Size = new Size(75, 23);
			btnPointRadDel.TabIndex = 67;
			btnPointRadDel.Text = "Delete";
			btnPointRadDel.UseVisualStyleBackColor = true;
			btnPointRadDel.Click += btnPointRadDel_Click;
			// 
			// btnSetBoundaries
			// 
			btnSetBoundaries.Location = new Point(6, 116);
			btnSetBoundaries.Name = "btnSetBoundaries";
			btnSetBoundaries.Size = new Size(81, 23);
			btnSetBoundaries.TabIndex = 64;
			btnSetBoundaries.Text = "Boundaries";
			btnSetBoundaries.UseVisualStyleBackColor = true;
			btnSetBoundaries.Click += btnSetBoundaries_Click;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1174, 638);
			Controls.Add(tabControl2);
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
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gridHistogram).EndInit();
			tabControl2.ResumeLayout(false);
			tabInsert.ResumeLayout(false);
			tabInsert.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			tabDelete.ResumeLayout(false);
			tabDelete.PerformLayout();
			gboxDelDates.ResumeLayout(false);
			gboxDelDates.PerformLayout();
			gboxDelRates.ResumeLayout(false);
			gboxDelRates.PerformLayout();
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
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TextBox txtStartDate;
		private TextBox txtEndDate;
		private GroupBox groupBox2;
		private RadioButton radioMilliRem;
		private RadioButton radioRem;
		private TabControl tabControl2;
		private TabPage tabInsert;
		private TabPage tabDelete;
		private Label label20;
		private Button btnInsertDefault;
		private Button btnCalculateInsert;
		private GroupBox groupBox3;
		private RadioButton radiInsertMiliRem;
		private RadioButton radiInsertRem;
		private TextBox txtInsertAvg;
		private TextBox txtInsertMax;
		private TextBox txtInsertMin;
		private TextBox txtInsertSampling;
		private Button btnInsertCount;
		private TextBox txtInsertCount;
		private Button btnInsStartByCount;
		private Button btnInsCurrentStart;
		private DateTimePicker dtpInsertEnd;
		private DateTimePicker dtpInsertStart;
		private Label label19;
		private Label label18;
		private Label label17;
		private Label label16;
		private Label label15;
		private Label label6;
		private Label label5;
		private RadioButton rbDelNone;
		private RadioButton rbDelByValue;
		private GroupBox gboxDelDates;
		private DateTimePicker dtpDelTo;
		private Label label2;
		private DateTimePicker dtpDelFrom;
		private Label label3;
		private RadioButton rbDelDates;
		private GroupBox gboxDelRates;
		private TextBox txtDelVal;
		private Label label4;
		private RadioButton rbDelLt;
		private RadioButton rbDelEq;
		private RadioButton rbDelGt;
		private RadioButton rbDelAll;
		private Button btnPointRadDel;
		private Button btnSetBoundaries;
		private Button btnHistogramRefresh;
		private DataGridView gridHistogram;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn Column14;
		private Label label21;
		private TextBox txtDoseReset;
		private Label label22;
	}
}
