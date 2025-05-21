namespace WebiGen {
	partial class DlgImportCsv {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			btnCancel = new Button();
			btnOK = new Button();
			label1 = new Label();
			txtFile = new TextBox();
			btnBrowse = new Button();
			dlgOpenCsv = new OpenFileDialog();
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
			btnRefresh = new Button();
			cboxDeleteCurrent = new CheckBox();
			cboxOverride = new CheckBox();
			btnInsert = new Button();
			((System.ComponentModel.ISupportInitialize)gridStats).BeginInit();
			SuspendLayout();
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(308, 300);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 3;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			btnOK.Location = new Point(415, 300);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(75, 23);
			btnOK.TabIndex = 2;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(32, 16);
			label1.Name = "label1";
			label1.Size = new Size(25, 15);
			label1.TabIndex = 4;
			label1.Text = "File";
			// 
			// txtFile
			// 
			txtFile.Location = new Point(3, 34);
			txtFile.Name = "txtFile";
			txtFile.Size = new Size(708, 23);
			txtFile.TabIndex = 5;
			// 
			// btnBrowse
			// 
			btnBrowse.Location = new Point(717, 34);
			btnBrowse.Name = "btnBrowse";
			btnBrowse.Size = new Size(75, 23);
			btnBrowse.TabIndex = 6;
			btnBrowse.Text = "Browse...";
			btnBrowse.UseVisualStyleBackColor = true;
			// 
			// dlgOpenCsv
			// 
			dlgOpenCsv.DefaultExt = "*.csv";
			dlgOpenCsv.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
			// 
			// gridStats
			// 
			gridStats.AllowUserToAddRows = false;
			gridStats.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = Color.Silver;
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			gridStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			gridStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridStats.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, Column11, Column13, Column8, Column9, Column10, Column12 });
			gridStats.EditMode = DataGridViewEditMode.EditProgrammatically;
			gridStats.Location = new Point(3, 63);
			gridStats.MultiSelect = false;
			gridStats.Name = "gridStats";
			gridStats.RowHeadersVisible = false;
			gridStats.Size = new Size(735, 150);
			gridStats.TabIndex = 13;
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
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewTextBoxColumn9.HeaderText = "Count";
			dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			dataGridViewTextBoxColumn9.Width = 70;
			// 
			// Column11
			// 
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column11.DefaultCellStyle = dataGridViewCellStyle3;
			Column11.HeaderText = "Sampling";
			Column11.Name = "Column11";
			Column11.Width = 70;
			// 
			// Column13
			// 
			dataGridViewCellStyle4.BackColor = Color.FromArgb(64, 64, 64);
			Column13.DefaultCellStyle = dataGridViewCellStyle4;
			Column13.HeaderText = "";
			Column13.Name = "Column13";
			Column13.Width = 10;
			// 
			// Column8
			// 
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column8.DefaultCellStyle = dataGridViewCellStyle5;
			Column8.HeaderText = "Minimum";
			Column8.Name = "Column8";
			Column8.ReadOnly = true;
			Column8.Width = 65;
			// 
			// Column9
			// 
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column9.DefaultCellStyle = dataGridViewCellStyle6;
			Column9.HeaderText = "Maximum";
			Column9.Name = "Column9";
			Column9.ReadOnly = true;
			Column9.Width = 65;
			// 
			// Column10
			// 
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column10.DefaultCellStyle = dataGridViewCellStyle7;
			Column10.HeaderText = "Average";
			Column10.Name = "Column10";
			Column10.ReadOnly = true;
			Column10.Width = 65;
			// 
			// Column12
			// 
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Column12.DefaultCellStyle = dataGridViewCellStyle8;
			Column12.HeaderText = "Std Div";
			Column12.Name = "Column12";
			Column12.ReadOnly = true;
			Column12.Width = 75;
			// 
			// btnRefresh
			// 
			btnRefresh.Location = new Point(295, 5);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(75, 23);
			btnRefresh.TabIndex = 14;
			btnRefresh.Text = "Refresh";
			btnRefresh.UseVisualStyleBackColor = true;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// cboxDeleteCurrent
			// 
			cboxDeleteCurrent.AutoSize = true;
			cboxDeleteCurrent.Location = new Point(221, 224);
			cboxDeleteCurrent.Name = "cboxDeleteCurrent";
			cboxDeleteCurrent.Size = new Size(102, 19);
			cboxDeleteCurrent.TabIndex = 15;
			cboxDeleteCurrent.Text = "Delete Current";
			cboxDeleteCurrent.UseVisualStyleBackColor = true;
			cboxDeleteCurrent.CheckedChanged += cboxDeleteCurrent_CheckedChanged;
			// 
			// cboxOverride
			// 
			cboxOverride.AutoSize = true;
			cboxOverride.Location = new Point(221, 249);
			cboxOverride.Name = "cboxOverride";
			cboxOverride.Size = new Size(71, 19);
			cboxOverride.TabIndex = 16;
			cboxOverride.Text = "Override";
			cboxOverride.UseVisualStyleBackColor = true;
			// 
			// btnInsert
			// 
			btnInsert.Location = new Point(360, 234);
			btnInsert.Name = "btnInsert";
			btnInsert.Size = new Size(75, 23);
			btnInsert.TabIndex = 17;
			btnInsert.Text = "Insert";
			btnInsert.UseVisualStyleBackColor = true;
			btnInsert.Click += btnInsert_Click;
			// 
			// DlgImportCsv
			// 
			AcceptButton = btnOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(800, 339);
			Controls.Add(btnInsert);
			Controls.Add(cboxOverride);
			Controls.Add(cboxDeleteCurrent);
			Controls.Add(btnRefresh);
			Controls.Add(gridStats);
			Controls.Add(btnBrowse);
			Controls.Add(txtFile);
			Controls.Add(label1);
			Controls.Add(btnCancel);
			Controls.Add(btnOK);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DlgImportCsv";
			ShowIcon = false;
			ShowInTaskbar = false;
			Text = "Import From CSV";
			((System.ComponentModel.ISupportInitialize)gridStats).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCancel;
		private Button btnOK;
		private Label label1;
		private TextBox txtFile;
		private Button btnBrowse;
		private OpenFileDialog dlgOpenCsv;
		private DataGridView gridStats;
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
		private Button btnRefresh;
		private CheckBox cboxDeleteCurrent;
		private CheckBox cboxOverride;
		private Button btnInsert;
	}
}