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
			btnOK = new Button();
			btnCancel = new Button();
			label1 = new Label();
			txtName = new TextBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			txtFrom = new TextBox();
			txtTo = new TextBox();
			txtCount = new TextBox();
			txtRate = new TextBox();
			label6 = new Label();
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
			txtAddRate = new TextBox();
			txtAddCount = new TextBox();
			dtpStartTime = new DateTimePicker();
			dtpEndTime = new DateTimePicker();
			btnSetToStart = new Button();
			btnCalculateCount = new Button();
			btnCalculateStart = new Button();
			SuspendLayout();
			// 
			// btnOK
			// 
			btnOK.Location = new Point(372, 406);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(75, 23);
			btnOK.TabIndex = 0;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(265, 406);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 1;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(115, 20);
			label1.Name = "label1";
			label1.Size = new Size(35, 15);
			label1.TabIndex = 2;
			label1.Text = "Point";
			// 
			// txtName
			// 
			txtName.Location = new Point(165, 12);
			txtName.Name = "txtName";
			txtName.ReadOnly = true;
			txtName.Size = new Size(100, 23);
			txtName.TabIndex = 3;
			txtName.TextAlign = HorizontalAlignment.Center;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(122, 58);
			label2.Name = "label2";
			label2.Size = new Size(37, 15);
			label2.TabIndex = 4;
			label2.Text = "begin";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(132, 86);
			label3.Name = "label3";
			label3.Size = new Size(27, 15);
			label3.TabIndex = 5;
			label3.Text = "End";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(115, 115);
			label4.Name = "label4";
			label4.Size = new Size(40, 15);
			label4.TabIndex = 6;
			label4.Text = "Count";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(67, 144);
			label5.Name = "label5";
			label5.Size = new Size(83, 15);
			label5.TabIndex = 7;
			label5.Text = "Sampling Rate";
			// 
			// txtFrom
			// 
			txtFrom.Location = new Point(165, 55);
			txtFrom.Name = "txtFrom";
			txtFrom.ReadOnly = true;
			txtFrom.Size = new Size(100, 23);
			txtFrom.TabIndex = 8;
			txtFrom.TextAlign = HorizontalAlignment.Center;
			// 
			// txtTo
			// 
			txtTo.Location = new Point(165, 83);
			txtTo.Name = "txtTo";
			txtTo.ReadOnly = true;
			txtTo.Size = new Size(100, 23);
			txtTo.TabIndex = 9;
			txtTo.TextAlign = HorizontalAlignment.Center;
			// 
			// txtCount
			// 
			txtCount.Location = new Point(165, 112);
			txtCount.Name = "txtCount";
			txtCount.ReadOnly = true;
			txtCount.Size = new Size(100, 23);
			txtCount.TabIndex = 10;
			txtCount.TextAlign = HorizontalAlignment.Center;
			// 
			// txtRate
			// 
			txtRate.Location = new Point(165, 141);
			txtRate.Name = "txtRate";
			txtRate.ReadOnly = true;
			txtRate.Size = new Size(100, 23);
			txtRate.TabIndex = 11;
			txtRate.TextAlign = HorizontalAlignment.Center;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(280, 144);
			label6.Name = "label6";
			label6.Size = new Size(51, 15);
			label6.TabIndex = 12;
			label6.Text = "Seconds";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(362, 15);
			label7.Name = "label7";
			label7.Size = new Size(60, 15);
			label7.TabIndex = 13;
			label7.Text = "Minimum";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(360, 43);
			label8.Name = "label8";
			label8.Size = new Size(62, 15);
			label8.TabIndex = 14;
			label8.Text = "Maximum";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(372, 72);
			label9.Name = "label9";
			label9.Size = new Size(50, 15);
			label9.TabIndex = 15;
			label9.Text = "Average";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(315, 98);
			label10.Name = "label10";
			label10.Size = new Size(107, 15);
			label10.TabIndex = 16;
			label10.Text = "Standard Deviation";
			// 
			// txtStdDiv
			// 
			txtStdDiv.Location = new Point(428, 98);
			txtStdDiv.Name = "txtStdDiv";
			txtStdDiv.ReadOnly = true;
			txtStdDiv.Size = new Size(100, 23);
			txtStdDiv.TabIndex = 20;
			txtStdDiv.TextAlign = HorizontalAlignment.Center;
			// 
			// txtAverage
			// 
			txtAverage.Location = new Point(428, 69);
			txtAverage.Name = "txtAverage";
			txtAverage.ReadOnly = true;
			txtAverage.Size = new Size(100, 23);
			txtAverage.TabIndex = 19;
			txtAverage.TextAlign = HorizontalAlignment.Center;
			// 
			// txtMax
			// 
			txtMax.Location = new Point(428, 40);
			txtMax.Name = "txtMax";
			txtMax.ReadOnly = true;
			txtMax.Size = new Size(100, 23);
			txtMax.TabIndex = 18;
			txtMax.TextAlign = HorizontalAlignment.Center;
			// 
			// txtMin
			// 
			txtMin.Location = new Point(428, 12);
			txtMin.Name = "txtMin";
			txtMin.ReadOnly = true;
			txtMin.Size = new Size(100, 23);
			txtMin.TabIndex = 17;
			txtMin.TextAlign = HorizontalAlignment.Center;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(300, 222);
			label11.Name = "label11";
			label11.Size = new Size(31, 15);
			label11.TabIndex = 21;
			label11.Text = "Start";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(306, 254);
			label12.Name = "label12";
			label12.Size = new Size(27, 15);
			label12.TabIndex = 22;
			label12.Text = "End";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(287, 311);
			label13.Name = "label13";
			label13.Size = new Size(40, 15);
			label13.TabIndex = 25;
			label13.Text = "Count";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(248, 284);
			label14.Name = "label14";
			label14.Size = new Size(83, 15);
			label14.TabIndex = 26;
			label14.Text = "Sampling Rate";
			// 
			// dtpStartDate
			// 
			dtpStartDate.Format = DateTimePickerFormat.Short;
			dtpStartDate.Location = new Point(353, 221);
			dtpStartDate.Name = "dtpStartDate";
			dtpStartDate.Size = new Size(94, 23);
			dtpStartDate.TabIndex = 27;
			// 
			// dtpEndDate
			// 
			dtpEndDate.Format = DateTimePickerFormat.Short;
			dtpEndDate.Location = new Point(353, 250);
			dtpEndDate.Name = "dtpEndDate";
			dtpEndDate.Size = new Size(94, 23);
			dtpEndDate.TabIndex = 28;
			// 
			// txtAddRate
			// 
			txtAddRate.Location = new Point(407, 281);
			txtAddRate.Name = "txtAddRate";
			txtAddRate.Size = new Size(100, 23);
			txtAddRate.TabIndex = 29;
			// 
			// txtAddCount
			// 
			txtAddCount.Location = new Point(407, 310);
			txtAddCount.Name = "txtAddCount";
			txtAddCount.Size = new Size(100, 23);
			txtAddCount.TabIndex = 30;
			// 
			// dtpStartTime
			// 
			dtpStartTime.Format = DateTimePickerFormat.Time;
			dtpStartTime.Location = new Point(462, 221);
			dtpStartTime.Name = "dtpStartTime";
			dtpStartTime.Size = new Size(94, 23);
			dtpStartTime.TabIndex = 31;
			// 
			// dtpEndTime
			// 
			dtpEndTime.Format = DateTimePickerFormat.Time;
			dtpEndTime.Location = new Point(462, 250);
			dtpEndTime.Name = "dtpEndTime";
			dtpEndTime.Size = new Size(94, 23);
			dtpEndTime.TabIndex = 32;
			// 
			// btnSetToStart
			// 
			btnSetToStart.Location = new Point(602, 225);
			btnSetToStart.Name = "btnSetToStart";
			btnSetToStart.Size = new Size(118, 23);
			btnSetToStart.TabIndex = 33;
			btnSetToStart.Text = "Set To Current Start";
			btnSetToStart.UseVisualStyleBackColor = true;
			// 
			// btnCalculateCount
			// 
			btnCalculateCount.Location = new Point(604, 254);
			btnCalculateCount.Name = "btnCalculateCount";
			btnCalculateCount.Size = new Size(116, 23);
			btnCalculateCount.TabIndex = 34;
			btnCalculateCount.Text = "Calculate Count";
			btnCalculateCount.UseVisualStyleBackColor = true;
			// 
			// btnCalculateStart
			// 
			btnCalculateStart.Location = new Point(600, 308);
			btnCalculateStart.Name = "btnCalculateStart";
			btnCalculateStart.Size = new Size(118, 23);
			btnCalculateStart.TabIndex = 35;
			btnCalculateStart.Text = "Calculate Start";
			btnCalculateStart.UseVisualStyleBackColor = true;
			// 
			// DlgAddPoint
			// 
			AcceptButton = btnOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(800, 450);
			Controls.Add(btnCalculateStart);
			Controls.Add(btnCalculateCount);
			Controls.Add(btnSetToStart);
			Controls.Add(dtpEndTime);
			Controls.Add(dtpStartTime);
			Controls.Add(txtAddCount);
			Controls.Add(txtAddRate);
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
			Controls.Add(label6);
			Controls.Add(txtRate);
			Controls.Add(txtCount);
			Controls.Add(txtTo);
			Controls.Add(txtFrom);
			Controls.Add(label5);
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
		private Label label5;
		private TextBox txtFrom;
		private TextBox txtTo;
		private TextBox txtCount;
		private TextBox txtRate;
		private Label label6;
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
		private TextBox txtAddRate;
		private TextBox txtAddCount;
		private DateTimePicker dtpStartTime;
		private DateTimePicker dtpEndTime;
		private Button btnSetToStart;
		private Button btnCalculateCount;
		private Button btnCalculateStart;
	}
}