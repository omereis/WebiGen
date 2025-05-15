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
			button1 = new Button();
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
			label1 = new Label();
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
			gridNewData = new DataGridView();
			dataGridViewLinkColumn1 = new DataGridViewLinkColumn();
			dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
			groupBox1 = new GroupBox();
			txtAddCount = new TextBox();
			dtpEndDate = new DateTimePicker();
			dtpStartDate = new DateTimePicker();
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
			menuMain.SuspendLayout();
			status_bar.SuspendLayout();
			toolbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridPoints).BeginInit();
			((System.ComponentModel.ISupportInitialize)chartRate).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridStats).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridNewData).BeginInit();
			groupBox1.SuspendLayout();
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
			// button1
			// 
			button1.Location = new Point(368, 68);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// comboMaps
			// 
			comboMaps.DropDownStyle = ComboBoxStyle.DropDownList;
			comboMaps.FormattingEnabled = true;
			comboMaps.Location = new Point(141, 66);
			comboMaps.Name = "comboMaps";
			comboMaps.Size = new Size(170, 23);
			comboMaps.TabIndex = 2;
			// 
			// status_bar
			// 
			status_bar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
			status_bar.Location = new Point(0, 563);
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
			btnLoadMaps.Location = new Point(49, 66);
			btnLoadMaps.Name = "btnLoadMaps";
			btnLoadMaps.Size = new Size(86, 23);
			btnLoadMaps.TabIndex = 6;
			btnLoadMaps.Text = "Load Maps";
			btnLoadMaps.UseVisualStyleBackColor = true;
			btnLoadMaps.Click += btnLoadMaps_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(7, 69);
			label1.Name = "label1";
			label1.Size = new Size(36, 15);
			label1.TabIndex = 7;
			label1.Text = "Maps";
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
			gridPoints.Size = new Size(436, 150);
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
			btnLoadRads.Location = new Point(7, 298);
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
			chartRate.Location = new Point(179, 291);
			chartRate.Name = "chartRate";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			chartRate.Series.Add(series1);
			chartRate.Size = new Size(308, 150);
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
			gridStats.Location = new Point(7, 327);
			gridStats.MultiSelect = false;
			gridStats.Name = "gridStats";
			gridStats.RowHeadersVisible = false;
			gridStats.Size = new Size(876, 150);
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
			Column8.HeaderText = "Minimum";
			Column8.Name = "Column8";
			// 
			// Column9
			// 
			Column9.HeaderText = "Maximum";
			Column9.Name = "Column9";
			// 
			// Column10
			// 
			Column10.HeaderText = "Average";
			Column10.Name = "Column10";
			// 
			// Column12
			// 
			Column12.HeaderText = "Std Div";
			Column12.Name = "Column12";
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
			// gridNewData
			// 
			gridNewData.AllowUserToAddRows = false;
			gridNewData.AllowUserToDeleteRows = false;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = Color.Silver;
			dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			gridNewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			gridNewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridNewData.Columns.AddRange(new DataGridViewColumn[] { dataGridViewLinkColumn1, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
			gridNewData.EditMode = DataGridViewEditMode.EditProgrammatically;
			gridNewData.Location = new Point(303, 46);
			gridNewData.MultiSelect = false;
			gridNewData.Name = "gridNewData";
			gridNewData.RowHeadersVisible = false;
			gridNewData.Size = new Size(464, 150);
			gridNewData.TabIndex = 13;
			// 
			// dataGridViewLinkColumn1
			// 
			dataGridViewLinkColumn1.HeaderText = "Name";
			dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
			dataGridViewLinkColumn1.Resizable = DataGridViewTriState.True;
			dataGridViewLinkColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
			dataGridViewLinkColumn1.Width = 70;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewTextBoxColumn1.HeaderText = "From";
			dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			dataGridViewTextBoxColumn1.Width = 110;
			// 
			// dataGridViewTextBoxColumn3
			// 
			dataGridViewTextBoxColumn3.HeaderText = "To";
			dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			dataGridViewTextBoxColumn3.Width = 110;
			// 
			// dataGridViewTextBoxColumn4
			// 
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle8;
			dataGridViewTextBoxColumn4.HeaderText = "Count";
			dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			dataGridViewTextBoxColumn4.Width = 70;
			// 
			// dataGridViewTextBoxColumn5
			// 
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle9;
			dataGridViewTextBoxColumn5.HeaderText = "Sampling";
			dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			dataGridViewTextBoxColumn5.Width = 70;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txtAddCount);
			groupBox1.Controls.Add(gridNewData);
			groupBox1.Controls.Add(dtpEndDate);
			groupBox1.Controls.Add(dtpStartDate);
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
			groupBox1.Location = new Point(63, 367);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(513, 167);
			groupBox1.TabIndex = 14;
			groupBox1.TabStop = false;
			groupBox1.Text = "New Points";
			// 
			// txtAddCount
			// 
			txtAddCount.Location = new Point(116, 111);
			txtAddCount.Name = "txtAddCount";
			txtAddCount.Size = new Size(100, 23);
			txtAddCount.TabIndex = 52;
			txtAddCount.TextAlign = HorizontalAlignment.Center;
			// 
			// dtpEndDate
			// 
			dtpEndDate.CustomFormat = "dd/MM/yyyy, hh:mm:ss";
			dtpEndDate.Format = DateTimePickerFormat.Custom;
			dtpEndDate.Location = new Point(116, 51);
			dtpEndDate.Name = "dtpEndDate";
			dtpEndDate.Size = new Size(160, 23);
			dtpEndDate.TabIndex = 51;
			// 
			// dtpStartDate
			// 
			dtpStartDate.CustomFormat = "dd/MM/yyyy, hh:mm:ss";
			dtpStartDate.Format = DateTimePickerFormat.Custom;
			dtpStartDate.Location = new Point(116, 24);
			dtpStartDate.Name = "dtpStartDate";
			dtpStartDate.Size = new Size(160, 23);
			dtpStartDate.TabIndex = 50;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(11, 87);
			label14.Name = "label14";
			label14.Size = new Size(83, 15);
			label14.TabIndex = 49;
			label14.Text = "Sampling Rate";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(50, 114);
			label13.Name = "label13";
			label13.Size = new Size(40, 15);
			label13.TabIndex = 48;
			label13.Text = "Count";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(69, 57);
			label12.Name = "label12";
			label12.Size = new Size(27, 15);
			label12.TabIndex = 47;
			label12.Text = "End";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(63, 25);
			label11.Name = "label11";
			label11.Size = new Size(31, 15);
			label11.TabIndex = 46;
			label11.Text = "Start";
			// 
			// txtStdDiv
			// 
			txtStdDiv.Location = new Point(371, 111);
			txtStdDiv.Name = "txtStdDiv";
			txtStdDiv.Size = new Size(100, 23);
			txtStdDiv.TabIndex = 45;
			txtStdDiv.TextAlign = HorizontalAlignment.Center;
			// 
			// txtAverage
			// 
			txtAverage.Location = new Point(371, 82);
			txtAverage.Name = "txtAverage";
			txtAverage.Size = new Size(100, 23);
			txtAverage.TabIndex = 44;
			txtAverage.TextAlign = HorizontalAlignment.Center;
			// 
			// txtMax
			// 
			txtMax.Location = new Point(371, 53);
			txtMax.Name = "txtMax";
			txtMax.Size = new Size(100, 23);
			txtMax.TabIndex = 43;
			txtMax.TextAlign = HorizontalAlignment.Center;
			// 
			// txtMin
			// 
			txtMin.Location = new Point(371, 25);
			txtMin.Name = "txtMin";
			txtMin.Size = new Size(100, 23);
			txtMin.TabIndex = 42;
			txtMin.TextAlign = HorizontalAlignment.Center;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(258, 111);
			label10.Name = "label10";
			label10.Size = new Size(107, 15);
			label10.TabIndex = 41;
			label10.Text = "Standard Deviation";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(315, 85);
			label9.Name = "label9";
			label9.Size = new Size(50, 15);
			label9.TabIndex = 40;
			label9.Text = "Average";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(303, 56);
			label8.Name = "label8";
			label8.Size = new Size(62, 15);
			label8.TabIndex = 39;
			label8.Text = "Maximum";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(305, 28);
			label7.Name = "label7";
			label7.Size = new Size(60, 15);
			label7.TabIndex = 38;
			label7.Text = "Minimum";
			// 
			// txtRate
			// 
			txtRate.Location = new Point(116, 82);
			txtRate.Name = "txtRate";
			txtRate.Size = new Size(100, 23);
			txtRate.TabIndex = 37;
			txtRate.TextAlign = HorizontalAlignment.Center;
			// 
			// btnExport
			// 
			btnExport.Location = new Point(471, 134);
			btnExport.Name = "btnExport";
			btnExport.Size = new Size(105, 23);
			btnExport.TabIndex = 1;
			btnExport.Text = "Export to CSV...";
			btnExport.UseVisualStyleBackColor = true;
			btnExport.Click += btnExport_Click;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1174, 585);
			Controls.Add(btnExport);
			Controls.Add(groupBox1);
			Controls.Add(gridStats);
			Controls.Add(chartRate);
			Controls.Add(btnLoadRads);
			Controls.Add(btnLoadPoints);
			Controls.Add(gridPoints);
			Controls.Add(label1);
			Controls.Add(btnLoadMaps);
			Controls.Add(toolbar);
			Controls.Add(status_bar);
			Controls.Add(comboMaps);
			Controls.Add(button1);
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
			((System.ComponentModel.ISupportInitialize)gridNewData).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
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
		private Button button1;
		private ComboBox comboMaps;
		private StatusStrip status_bar;
		private ToolStripStatusLabel toolStripStatusLabel1;
		private ToolStripStatusLabel toolStripStatusLabel2;
		private ToolStripStatusLabel toolStripStatusLabel3;
		private ToolStrip toolbar;
		private ToolStripButton btnConnect;
		private ToolStripButton btnDisconnect;
		private Button btnLoadMaps;
		private Label label1;
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
		private DataGridView gridNewData;
		private DataGridViewLinkColumn dataGridViewLinkColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private GroupBox groupBox1;
		private TextBox txtAddCount;
		private DateTimePicker dtpEndDate;
		private DateTimePicker dtpStartDate;
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
	}
}
