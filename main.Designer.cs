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
			dlgOpenCsv = new OpenFileDialog();
			dlgSaveCsv = new SaveFileDialog();
			menuMain.SuspendLayout();
			status_bar.SuspendLayout();
			toolbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridPoints).BeginInit();
			((System.ComponentModel.ISupportInitialize)chartRate).BeginInit();
			((System.ComponentModel.ISupportInitialize)gridStats).BeginInit();
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
			chartRate.Location = new Point(489, 63);
			chartRate.Name = "chartRate";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			chartRate.Series.Add(series1);
			chartRate.Size = new Size(549, 274);
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
			gridStats.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, Column11 });
			gridStats.EditMode = DataGridViewEditMode.EditProgrammatically;
			gridStats.Location = new Point(7, 327);
			gridStats.MultiSelect = false;
			gridStats.Name = "gridStats";
			gridStats.RowHeadersVisible = false;
			gridStats.Size = new Size(464, 150);
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
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1174, 585);
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
		private DataGridViewLinkColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private DataGridViewTextBoxColumn Column11;
		private OpenFileDialog dlgOpenCsv;
		private SaveFileDialog dlgSaveCsv;
	}
}
