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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			menuMain = new MenuStrip();
			popupFile = new ToolStripMenuItem();
			miDatabase = new ToolStripMenuItem();
			miFileSep1 = new ToolStripSeparator();
			miExit = new ToolStripMenuItem();
			popupHelp = new ToolStripMenuItem();
			miAbout = new ToolStripMenuItem();
			button1 = new Button();
			comboMaps = new ComboBox();
			txtConnection = new TextBox();
			status_bar = new StatusStrip();
			toolStripStatusLabel1 = new ToolStripStatusLabel();
			toolStripStatusLabel2 = new ToolStripStatusLabel();
			toolStripStatusLabel3 = new ToolStripStatusLabel();
			toolbar = new ToolStrip();
			btnConnect = new ToolStripButton();
			btnDisconnect = new ToolStripButton();
			btnLoadMaps = new Button();
			label1 = new Label();
			gridPoints = new DataGridView();
			Column1 = new DataGridViewCheckBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			Column6 = new DataGridViewTextBoxColumn();
			Column3 = new DataGridViewTextBoxColumn();
			Column4 = new DataGridViewTextBoxColumn();
			Column5 = new DataGridViewTextBoxColumn();
			btnLoadPoints = new Button();
			button2 = new Button();
			sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
			chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
			menuMain.SuspendLayout();
			status_bar.SuspendLayout();
			toolbar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridPoints).BeginInit();
			((System.ComponentModel.ISupportInitialize)chartData).BeginInit();
			SuspendLayout();
			// 
			// menuMain
			// 
			menuMain.Items.AddRange(new ToolStripItem[] { popupFile, popupHelp });
			menuMain.Location = new Point(0, 0);
			menuMain.Name = "menuMain";
			menuMain.Size = new Size(996, 24);
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
			button1.Location = new Point(217, 165);
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
			comboMaps.Location = new Point(49, 87);
			comboMaps.Name = "comboMaps";
			comboMaps.Size = new Size(170, 23);
			comboMaps.TabIndex = 2;
			// 
			// txtConnection
			// 
			txtConnection.Location = new Point(22, 208);
			txtConnection.Name = "txtConnection";
			txtConnection.Size = new Size(711, 23);
			txtConnection.TabIndex = 3;
			// 
			// status_bar
			// 
			status_bar.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
			status_bar.Location = new Point(0, 563);
			status_bar.Name = "status_bar";
			status_bar.Size = new Size(996, 22);
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
			toolbar.Items.AddRange(new ToolStripItem[] { btnConnect, btnDisconnect });
			toolbar.Location = new Point(0, 24);
			toolbar.Name = "toolbar";
			toolbar.Size = new Size(996, 25);
			toolbar.TabIndex = 5;
			toolbar.Text = "toolStrip1";
			// 
			// btnConnect
			// 
			btnConnect.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnConnect.Image = (Image)resources.GetObject("btnConnect.Image");
			btnConnect.ImageTransparentColor = Color.Magenta;
			btnConnect.Name = "btnConnect";
			btnConnect.Size = new Size(23, 22);
			btnConnect.Text = "toolStripButton1";
			btnConnect.Click += btnConnect_Click;
			// 
			// btnDisconnect
			// 
			btnDisconnect.DisplayStyle = ToolStripItemDisplayStyle.Image;
			btnDisconnect.Image = (Image)resources.GetObject("btnDisconnect.Image");
			btnDisconnect.ImageTransparentColor = Color.Magenta;
			btnDisconnect.Name = "btnDisconnect";
			btnDisconnect.Size = new Size(23, 22);
			btnDisconnect.Text = "toolStripButton2";
			btnDisconnect.Click += btnDisconnect_Click;
			// 
			// btnLoadMaps
			// 
			btnLoadMaps.Location = new Point(49, 58);
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
			label1.Location = new Point(7, 90);
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
			gridPoints.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column6, Column3, Column4, Column5 });
			gridPoints.EditMode = DataGridViewEditMode.EditProgrammatically;
			gridPoints.Location = new Point(333, 52);
			gridPoints.MultiSelect = false;
			gridPoints.Name = "gridPoints";
			gridPoints.RowHeadersVisible = false;
			gridPoints.Size = new Size(562, 150);
			gridPoints.TabIndex = 8;
			gridPoints.CellClick += gridPoints_CellClick;
			// 
			// Column1
			// 
			Column1.HeaderText = "Point ID";
			Column1.Name = "Column1";
			Column1.Width = 60;
			// 
			// Column2
			// 
			Column2.HeaderText = "Name";
			Column2.Name = "Column2";
			Column2.Width = 70;
			// 
			// Column6
			// 
			Column6.HeaderText = "Device Type";
			Column6.Name = "Column6";
			// 
			// Column3
			// 
			Column3.HeaderText = "Detector Type";
			Column3.Name = "Column3";
			Column3.Width = 105;
			// 
			// Column4
			// 
			Column4.HeaderText = "Connection ID";
			Column4.Name = "Column4";
			Column4.Width = 110;
			// 
			// Column5
			// 
			Column5.HeaderText = "IP Address";
			Column5.Name = "Column5";
			// 
			// btnLoadPoints
			// 
			btnLoadPoints.Location = new Point(245, 52);
			btnLoadPoints.Name = "btnLoadPoints";
			btnLoadPoints.Size = new Size(82, 23);
			btnLoadPoints.TabIndex = 9;
			btnLoadPoints.Text = "Load Points";
			btnLoadPoints.UseVisualStyleBackColor = true;
			btnLoadPoints.Click += btnLoadPoints_Click;
			// 
			// button2
			// 
			button2.Location = new Point(29, 242);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 10;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			// 
			// sqlCommand1
			// 
			sqlCommand1.CommandTimeout = 30;
			sqlCommand1.EnableOptimizedParameterBinding = false;
			// 
			// chartData
			// 
			chartArea1.Name = "ChartArea1";
			chartData.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			chartData.Legends.Add(legend1);
			chartData.Location = new Point(110, 237);
			chartData.Name = "chartData";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			chartData.Series.Add(series1);
			chartData.Size = new Size(623, 300);
			chartData.TabIndex = 11;
			chartData.Text = "chart1";
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(996, 585);
			Controls.Add(chartData);
			Controls.Add(button2);
			Controls.Add(btnLoadPoints);
			Controls.Add(gridPoints);
			Controls.Add(label1);
			Controls.Add(btnLoadMaps);
			Controls.Add(toolbar);
			Controls.Add(status_bar);
			Controls.Add(txtConnection);
			Controls.Add(comboMaps);
			Controls.Add(button1);
			Controls.Add(menuMain);
			MainMenuStrip = menuMain;
			Name = "frmMain";
			Text = "WebeSmarts Data Generetor";
			FormClosed += frmMain_FormClosed;
			Load += frmMain_Load;
			menuMain.ResumeLayout(false);
			menuMain.PerformLayout();
			status_bar.ResumeLayout(false);
			status_bar.PerformLayout();
			toolbar.ResumeLayout(false);
			toolbar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)gridPoints).EndInit();
			((System.ComponentModel.ISupportInitialize)chartData).EndInit();
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
		private TextBox txtConnection;
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
		private DataGridViewCheckBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private DataGridViewTextBoxColumn Column6;
		private DataGridViewTextBoxColumn Column3;
		private DataGridViewTextBoxColumn Column4;
		private DataGridViewTextBoxColumn Column5;
		private Button button2;
		private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
	}
}
