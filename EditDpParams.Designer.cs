namespace WebiGen {
	partial class DlgEditDB {
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
			label2 = new Label();
			label3 = new Label();
			txtConnection = new TextBox();
			txtServer = new TextBox();
			btnCompose = new Button();
			comboDatabase = new ComboBox();
			btnTest = new Button();
			tabControl1 = new TabControl();
			tabSimple = new TabPage();
			tabDetailed = new TabPage();
			gridDetails = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			tabControl1.SuspendLayout();
			tabSimple.SuspendLayout();
			tabDetailed.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridDetails).BeginInit();
			SuspendLayout();
			// 
			// btnOK
			// 
			btnOK.Location = new Point(272, 387);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(75, 23);
			btnOK.TabIndex = 0;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(146, 387);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 1;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(22, 19);
			label1.Name = "label1";
			label1.Size = new Size(39, 15);
			label1.TabIndex = 2;
			label1.Text = "Server";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(16, 76);
			label2.Name = "label2";
			label2.Size = new Size(55, 15);
			label2.TabIndex = 3;
			label2.Text = "Database";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(121, 246);
			label3.Name = "label3";
			label3.Size = new Size(103, 15);
			label3.TabIndex = 4;
			label3.Text = "Connection String";
			// 
			// txtConnection
			// 
			txtConnection.Location = new Point(93, 269);
			txtConnection.Multiline = true;
			txtConnection.Name = "txtConnection";
			txtConnection.Size = new Size(411, 111);
			txtConnection.TabIndex = 5;
			// 
			// txtServer
			// 
			txtServer.Location = new Point(79, 19);
			txtServer.Name = "txtServer";
			txtServer.Size = new Size(201, 23);
			txtServer.TabIndex = 6;
			// 
			// btnCompose
			// 
			btnCompose.Location = new Point(12, 269);
			btnCompose.Name = "btnCompose";
			btnCompose.Size = new Size(75, 23);
			btnCompose.TabIndex = 7;
			btnCompose.Text = "Compose";
			btnCompose.UseVisualStyleBackColor = true;
			// 
			// comboDatabase
			// 
			comboDatabase.DropDownStyle = ComboBoxStyle.DropDownList;
			comboDatabase.FormattingEnabled = true;
			comboDatabase.Location = new Point(79, 68);
			comboDatabase.Name = "comboDatabase";
			comboDatabase.Size = new Size(201, 23);
			comboDatabase.TabIndex = 8;
			// 
			// btnTest
			// 
			btnTest.Location = new Point(513, 268);
			btnTest.Name = "btnTest";
			btnTest.Size = new Size(75, 23);
			btnTest.TabIndex = 9;
			btnTest.Text = "Test";
			btnTest.UseVisualStyleBackColor = true;
			btnTest.Click += btnTest_Click;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabSimple);
			tabControl1.Controls.Add(tabDetailed);
			tabControl1.Location = new Point(24, 9);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(564, 234);
			tabControl1.TabIndex = 10;
			// 
			// tabSimple
			// 
			tabSimple.Controls.Add(txtServer);
			tabSimple.Controls.Add(label1);
			tabSimple.Controls.Add(comboDatabase);
			tabSimple.Controls.Add(label2);
			tabSimple.Location = new Point(4, 24);
			tabSimple.Name = "tabSimple";
			tabSimple.Padding = new Padding(3);
			tabSimple.Size = new Size(556, 206);
			tabSimple.TabIndex = 0;
			tabSimple.Text = "Simple";
			tabSimple.UseVisualStyleBackColor = true;
			// 
			// tabDetailed
			// 
			tabDetailed.Controls.Add(gridDetails);
			tabDetailed.Location = new Point(4, 24);
			tabDetailed.Name = "tabDetailed";
			tabDetailed.Padding = new Padding(3);
			tabDetailed.Size = new Size(556, 206);
			tabDetailed.TabIndex = 1;
			tabDetailed.Text = "Detailed";
			tabDetailed.UseVisualStyleBackColor = true;
			// 
			// gridDetails
			// 
			gridDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridDetails.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
			gridDetails.Location = new Point(6, 6);
			gridDetails.Name = "gridDetails";
			gridDetails.RowHeadersVisible = false;
			gridDetails.Size = new Size(526, 194);
			gridDetails.TabIndex = 0;
			// 
			// Column1
			// 
			Column1.HeaderText = "Field";
			Column1.Name = "Column1";
			Column1.Width = 200;
			// 
			// Column2
			// 
			Column2.HeaderText = "Value";
			Column2.Name = "Column2";
			Column2.Width = 300;
			// 
			// DlgEditDB
			// 
			AcceptButton = btnOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(725, 450);
			Controls.Add(tabControl1);
			Controls.Add(btnTest);
			Controls.Add(btnCompose);
			Controls.Add(txtConnection);
			Controls.Add(label3);
			Controls.Add(btnCancel);
			Controls.Add(btnOK);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DlgEditDB";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "EditDpParams";
			tabControl1.ResumeLayout(false);
			tabSimple.ResumeLayout(false);
			tabSimple.PerformLayout();
			tabDetailed.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gridDetails).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnOK;
		private Button btnCancel;
		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txtConnection;
		private TextBox txtServer;
		private Button btnCompose;
		private ComboBox comboDatabase;
		private Button btnTest;
		private TabControl tabControl1;
		private TabPage tabSimple;
		private TabPage tabDetailed;
		private DataGridView gridDetails;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
	}
}