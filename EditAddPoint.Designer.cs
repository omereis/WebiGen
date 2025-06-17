namespace WebiGen {
	partial class DlgAddPoint {
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			btnOK = new Button();
			btnCancel = new Button();
			label1 = new Label();
			txtName = new TextBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			txtFrom = new TextBox();
			txtTo = new TextBox();
			txtCount = new TextBox();
			txtRate = new TextBox();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			txtStdDiv = new TextBox();
			txtAverage = new TextBox();
			txtMax = new TextBox();
			txtMin = new TextBox();
			label11 = new Label();
			label12 = new Label();
			label13 = new Label();
			label14 = new Label();
			dtpStartDate = new DateTimePicker();
			dtpEndDate = new DateTimePicker();
			txtAddCount = new TextBox();
			btnSetToStart = new Button();
			btnCalculateCount = new Button();
			btnCalculateStart = new Button();
			label15 = new Label();
			chartRate = new System.Windows.Forms.DataVisualization.Charting.Chart();
			Draw = new Button();
			((System.ComponentModel.ISupportInitialize)chartRate).BeginInit();
			SuspendLayout();
			// 
			// btnOK
			// 
			btnOK.Location = new Point(396, 320);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(75, 23);
			btnOK.TabIndex = 0;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(289, 320);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 1;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 15);
			label1.Name = "label1";
			label1.Size = new Size(35, 15);
			label1.TabIndex = 2;
			label1.Text = "Point";
			// 
			// txtName
			// 
			txtName.Location = new Point(56, 7);
			txtName.Name = "txtName";
			txtName.ReadOnly = true;
			txtName.Size = new Size(67, 23);
			txtName.TabIndex = 3;
			txtName.TextAlign = HorizontalAlignment.Center;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(13, 38);
			label2.Name = "label2";
			label2.Size = new Size(37, 15);
			label2.TabIndex = 4;
			label2.Text = "begin";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(23, 66);
			label3.Name = "label3";
			label3.Size = new Size(27, 15);
			label3.TabIndex = 5;
			label3.Text = "End";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 95);
			label4.Name = "label4";
			label4.Size = new Size(40, 15);
			label4.TabIndex = 6;
			label4.Text = "Count";
			// 
			// txtFrom
			// 
			txtFrom.Location = new Point(56, 35);
			txtFrom.Name = "txtFrom";
			txtFrom.ReadOnly = true;
			txtFrom.Size = new Size(67, 23);
			txtFrom.TabIndex = 8;
			txtFrom.TextAlign = HorizontalAlignment.Center;
			// 
			// txtTo
			// 
			txtTo.Location = new Point(56, 63);
			txtTo.Name = "txtTo";
			txtTo.ReadOnly = true;
			txtTo.Size = new Size(67, 23);
			txtTo.TabIndex = 9;
			txtTo.TextAlign = HorizontalAlignment.Center;
			// 
			// txtCount
			// 
			txtCount.Location = new Point(56, 92);
			txtCount.Name = "txtCount";
			txtCount.ReadOnly = true;
			txtCount.Size = new Size(67, 23);
			txtCount.TabIndex = 10;
			txtCount.TextAlign = HorizontalAlignment.Center;
			// 
			// txtRate
			// 
			txtRate.Location = new Point(110, 185);
			txtRate.Name = "txtRate";
			txtRate.Size = new Size(100, 23);
			txtRate.TabIndex = 11;
			txtRate.TextAlign = HorizontalAlignment.Center;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(183, 15);
			label7.Name = "label7";
			label7.Size = new Size(60, 15);
			label7.TabIndex = 13;
			label7.Text = "Minimum";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(181, 43);
			label8.Name = "label8";
			label8.Size = new Size(62, 15);
			label8.TabIndex = 14;
			label8.Text = "Maximum";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(193, 72);
			label9.Name = "label9";
			label9.Size = new Size(50, 15);
			label9.TabIndex = 15;
			label9.Text = "Average";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(136, 98);
			label10.Name = "label10";
			label10.Size = new Size(107, 15);
			label10.TabIndex = 16;
			label10.Text = "Standard Deviation";
			// 
			// txtStdDiv
			// 
			txtStdDiv.Location = new Point(249, 98);
			txtStdDiv.Name = "txtStdDiv";
			txtStdDiv.ReadOnly = true;
			txtStdDiv.Size = new Size(71, 23);
			txtStdDiv.TabIndex = 20;
			txtStdDiv.TextAlign = HorizontalAlignment.Center;
			// 
			// txtAverage
			// 
			txtAverage.Location = new Point(249, 69);
			txtAverage.Name = "txtAverage";
			txtAverage.ReadOnly = true;
			txtAverage.Size = new Size(71, 23);
			txtAverage.TabIndex = 19;
			txtAverage.TextAlign = HorizontalAlignment.Center;
			// 
			// txtMax
			// 
			txtMax.Location = new Point(249, 40);
			txtMax.Name = "txtMax";
			txtMax.ReadOnly = true;
			txtMax.Size = new Size(71, 23);
			txtMax.TabIndex = 18;
			txtMax.TextAlign = HorizontalAlignment.Center;
			// 
			// txtMin
			// 
			txtMin.Location = new Point(249, 12);
			txtMin.Name = "txtMin";
			txtMin.ReadOnly = true;
			txtMin.Size = new Size(71, 23);
			txtMin.TabIndex = 17;
			txtMin.TextAlign = HorizontalAlignment.Center;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(57, 128);
			label11.Name = "label11";
			label11.Size = new Size(31, 15);
			label11.TabIndex = 21;
			label11.Text = "Start";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(63, 160);
			label12.Name = "label12";
			label12.Size = new Size(27, 15);
			label12.TabIndex = 22;
			label12.Text = "End";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(44, 217);
			label13.Name = "label13";
			label13.Size = new Size(40, 15);
			label13.TabIndex = 25;
			label13.Text = "Count";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(5, 190);
			label14.Name = "label14";
			label14.Size = new Size(83, 15);
			label14.TabIndex = 26;
			label14.Text = "Sampling Rate";
			// 
			// dtpStartDate
			// 
			dtpStartDate.CustomFormat = "dd/MM/yyyy, hh:mm:ss";
			dtpStartDate.Format = DateTimePickerFormat.Custom;
			dtpStartDate.Location = new Point(110, 127);
			dtpStartDate.Name = "dtpStartDate";
			dtpStartDate.Size = new Size(146, 23);
			dtpStartDate.TabIndex = 27;
			// 
			// dtpEndDate
			// 
			dtpEndDate.CustomFormat = "dd/MM/yyyy, hh:mm:ss";
			dtpEndDate.Format = DateTimePickerFormat.Custom;
			dtpEndDate.Location = new Point(110, 154);
			dtpEndDate.Name = "dtpEndDate";
			dtpEndDate.Size = new Size(146, 23);
			dtpEndDate.TabIndex = 28;
			// 
			// txtAddCount
			// 
			txtAddCount.Location = new Point(110, 214);
			txtAddCount.Name = "txtAddCount";
			txtAddCount.Size = new Size(100, 23);
			txtAddCount.TabIndex = 30;
			txtAddCount.TextAlign = HorizontalAlignment.Center;
			// 
			// btnSetToStart
			// 
			btnSetToStart.Location = new Point(262, 158);
			btnSetToStart.Name = "btnSetToStart";
			btnSetToStart.Size = new Size(118, 23);
			btnSetToStart.TabIndex = 33;
			btnSetToStart.Text = "Set To Current Start";
			btnSetToStart.UseVisualStyleBackColor = true;
			btnSetToStart.Click += btnSetToEnd_Click;
			// 
			// btnCalculateCount
			// 
			btnCalculateCount.Location = new Point(262, 129);
			btnCalculateCount.Name = "btnCalculateCount";
			btnCalculateCount.Size = new Size(116, 23);
			btnCalculateCount.TabIndex = 34;
			btnCalculateCount.Text = "Calculate Count";
			btnCalculateCount.UseVisualStyleBackColor = true;
			btnCalculateCount.Click += btnCalculateCount_Click;
			// 
			// btnCalculateStart
			// 
			btnCalculateStart.Location = new Point(262, 224);
			btnCalculateStart.Name = "btnCalculateStart";
			btnCalculateStart.Size = new Size(118, 23);
			btnCalculateStart.TabIndex = 35;
			btnCalculateStart.Text = "Calculate Start";
			btnCalculateStart.UseVisualStyleBackColor = true;
			btnCalculateStart.Click += btnCalculateStart_Click;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(219, 192);
			label15.Name = "label15";
			label15.Size = new Size(51, 15);
			label15.TabIndex = 36;
			label15.Text = "Seconds";
			// 
			// chartRate
			// 
			chartArea1.Name = "ChartArea1";
			chartRate.ChartAreas.Add(chartArea1);
			chartRate.Location = new Point(407, 15);
			chartRate.Name = "chartRate";
			series1.ChartArea = "ChartArea1";
			series1.Name = "Series1";
			chartRate.Series.Add(series1);
			chartRate.Size = new Size(566, 300);
			chartRate.TabIndex = 37;
			chartRate.Text = "chart1";
			// 
			// Draw
			// 
			Draw.Location = new Point(303, 269);
			Draw.Name = "Draw";
			Draw.Size = new Size(75, 23);
			Draw.TabIndex = 38;
			Draw.Text = "button1";
			Draw.UseVisualStyleBackColor = true;
			Draw.Click += Draw_Click;
			// 
			// DlgAddPoint
			// 
			AcceptButton = btnOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(985, 358);
			Controls.Add(Draw);
			Controls.Add(chartRate);
			Controls.Add(label15);
			Controls.Add(btnCalculateStart);
			Controls.Add(btnCalculateCount);
			Controls.Add(btnSetToStart);
			Controls.Add(txtAddCount);
			Controls.Add(dtpEndDate);
			Controls.Add(dtpStartDate);
			Controls.Add(label14);
			Controls.Add(label13);
			Controls.Add(label12);
			Controls.Add(label11);
			Controls.Add(txtStdDiv);
			Controls.Add(txtAverage);
			Controls.Add(txtMax);
			Controls.Add(txtMin);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(txtRate);
			Controls.Add(txtCount);
			Controls.Add(txtTo);
			Controls.Add(txtFrom);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(txtName);
			Controls.Add(label1);
			Controls.Add(btnCancel);
			Controls.Add(btnOK);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DlgAddPoint";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EditAddPoint";
			((System.ComponentModel.ISupportInitialize)chartRate).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnOK;
		private Button btnCancel;
		private Label label1;
		private TextBox txtName;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox txtFrom;
		private TextBox txtTo;
		private TextBox txtCount;
		private TextBox txtRate;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private TextBox txtStdDiv;
		private TextBox txtAverage;
		private TextBox txtMax;
		private TextBox txtMin;
		private Label label11;
		private Label label12;
		private Label label13;
		private Label label14;
		private DateTimePicker dtpStartDate;
		private DateTimePicker dtpEndDate;
		private TextBox txtAddCount;
		private Button btnSetToStart;
		private Button btnCalculateCount;
		private Button btnCalculateStart;
		private Label label15;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartRate;
		private Button Draw;
	}
}