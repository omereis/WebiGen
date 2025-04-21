namespace OmerEisCommon {
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
			label4 = new Label();
			txtbxServer = new TextBox();
			txtbxDatabase = new TextBox();
			txtbxUsername = new TextBox();
			txtbxPassword = new TextBox();
			listBox1 = new ListBox();
			label5 = new Label();
			txtbxTitle = new TextBox();
			btnTest = new Button();
			txtJson = new TextBox();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			Page1 = new TabControl();
			tabMySql = new TabPage();
			tabSqlServer = new TabPage();
			gridSqlSer = new DataGridView();
			Column1 = new DataGridViewTextBoxColumn();
			Column2 = new DataGridViewTextBoxColumn();
			txtConnection = new TextBox();
			Page1.SuspendLayout();
			tabMySql.SuspendLayout();
			tabSqlServer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridSqlSer).BeginInit();
			SuspendLayout();
			// 
			// btnOK
			// 
			btnOK.ImageAlign = ContentAlignment.MiddleLeft;
			btnOK.Location = new Point(154, 386);
			btnOK.Name = "btnOK";
			btnOK.Size = new Size(75, 23);
			btnOK.TabIndex = 6;
			btnOK.Text = "OK";
			btnOK.UseVisualStyleBackColor = true;
			btnOK.Click += btnOK_Click;
			// 
			// btnCancel
			// 
			btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
			btnCancel.Location = new Point(266, 386);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 7;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(75, 62);
			label1.Name = "label1";
			label1.Size = new Size(39, 15);
			label1.TabIndex = 2;
			label1.Text = "Server";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(59, 95);
			label2.Name = "label2";
			label2.Size = new Size(55, 15);
			label2.TabIndex = 3;
			label2.Text = "Database";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(49, 137);
			label3.Name = "label3";
			label3.Size = new Size(65, 15);
			label3.TabIndex = 4;
			label3.Text = "User Name";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(57, 174);
			label4.Name = "label4";
			label4.Size = new Size(57, 15);
			label4.TabIndex = 5;
			label4.Text = "Password";
			// 
			// txtbxServer
			// 
			txtbxServer.Location = new Point(135, 59);
			txtbxServer.Name = "txtbxServer";
			txtbxServer.Size = new Size(100, 23);
			txtbxServer.TabIndex = 1;
			// 
			// txtbxDatabase
			// 
			txtbxDatabase.Location = new Point(135, 92);
			txtbxDatabase.Name = "txtbxDatabase";
			txtbxDatabase.Size = new Size(100, 23);
			txtbxDatabase.TabIndex = 2;
			// 
			// txtbxUsername
			// 
			txtbxUsername.Location = new Point(135, 129);
			txtbxUsername.Name = "txtbxUsername";
			txtbxUsername.Size = new Size(100, 23);
			txtbxUsername.TabIndex = 3;
			// 
			// txtbxPassword
			// 
			txtbxPassword.Location = new Point(135, 166);
			txtbxPassword.Name = "txtbxPassword";
			txtbxPassword.Size = new Size(100, 23);
			txtbxPassword.TabIndex = 4;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(20, 40);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(33, 94);
			listBox1.TabIndex = 10;
			listBox1.Visible = false;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(59, 23);
			label5.Name = "label5";
			label5.Size = new Size(29, 15);
			label5.TabIndex = 11;
			label5.Text = "Title";
			label5.Visible = false;
			// 
			// txtbxTitle
			// 
			txtbxTitle.Location = new Point(135, 20);
			txtbxTitle.Name = "txtbxTitle";
			txtbxTitle.Size = new Size(100, 23);
			txtbxTitle.TabIndex = 0;
			txtbxTitle.Visible = false;
			// 
			// btnTest
			// 
			btnTest.Location = new Point(692, 50);
			btnTest.Name = "btnTest";
			btnTest.Size = new Size(75, 23);
			btnTest.TabIndex = 12;
			btnTest.Text = "Test...";
			btnTest.UseVisualStyleBackColor = true;
			btnTest.Click += btnTest_Click;
			// 
			// txtJson
			// 
			txtJson.Location = new Point(353, 16);
			txtJson.Multiline = true;
			txtJson.Name = "txtJson";
			txtJson.Size = new Size(214, 165);
			txtJson.TabIndex = 13;
			// 
			// button1
			// 
			button1.Location = new Point(263, 81);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 14;
			button1.Text = "Compose";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(263, 23);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 15;
			button2.Text = "Clear";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(263, 52);
			button3.Name = "button3";
			button3.Size = new Size(75, 23);
			button3.TabIndex = 16;
			button3.Text = "Json";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// Page1
			// 
			Page1.Controls.Add(tabMySql);
			Page1.Controls.Add(tabSqlServer);
			Page1.Location = new Point(12, 3);
			Page1.Name = "Page1";
			Page1.SelectedIndex = 0;
			Page1.Size = new Size(657, 358);
			Page1.TabIndex = 17;
			// 
			// tabMySql
			// 
			tabMySql.Controls.Add(txtbxPassword);
			tabMySql.Controls.Add(button3);
			tabMySql.Controls.Add(listBox1);
			tabMySql.Controls.Add(button2);
			tabMySql.Controls.Add(button1);
			tabMySql.Controls.Add(label1);
			tabMySql.Controls.Add(txtJson);
			tabMySql.Controls.Add(label2);
			tabMySql.Controls.Add(label3);
			tabMySql.Controls.Add(label4);
			tabMySql.Controls.Add(txtbxTitle);
			tabMySql.Controls.Add(txtbxServer);
			tabMySql.Controls.Add(label5);
			tabMySql.Controls.Add(txtbxDatabase);
			tabMySql.Controls.Add(txtbxUsername);
			tabMySql.Location = new Point(4, 24);
			tabMySql.Name = "tabMySql";
			tabMySql.Padding = new Padding(3);
			tabMySql.Size = new Size(649, 330);
			tabMySql.TabIndex = 0;
			tabMySql.Text = "MySql";
			tabMySql.UseVisualStyleBackColor = true;
			// 
			// tabSqlServer
			// 
			tabSqlServer.Controls.Add(txtConnection);
			tabSqlServer.Controls.Add(gridSqlSer);
			tabSqlServer.Location = new Point(4, 24);
			tabSqlServer.Name = "tabSqlServer";
			tabSqlServer.Padding = new Padding(3);
			tabSqlServer.Size = new Size(649, 330);
			tabSqlServer.TabIndex = 1;
			tabSqlServer.Text = "Sql Server";
			tabSqlServer.UseVisualStyleBackColor = true;
			// 
			// gridSqlSer
			// 
			gridSqlSer.AllowUserToAddRows = false;
			gridSqlSer.AllowUserToDeleteRows = false;
			gridSqlSer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridSqlSer.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
			gridSqlSer.EditMode = DataGridViewEditMode.EditOnF2;
			gridSqlSer.Location = new Point(3, 3);
			gridSqlSer.Name = "gridSqlSer";
			gridSqlSer.RowHeadersVisible = false;
			gridSqlSer.Size = new Size(565, 233);
			gridSqlSer.TabIndex = 0;
			// 
			// Column1
			// 
			Column1.HeaderText = "Field";
			Column1.Name = "Column1";
			// 
			// Column2
			// 
			Column2.HeaderText = "Value";
			Column2.Name = "Column2";
			Column2.Width = 300;
			// 
			// txtConnection
			// 
			txtConnection.Location = new Point(6, 301);
			txtConnection.Name = "txtConnection";
			txtConnection.Size = new Size(562, 23);
			txtConnection.TabIndex = 1;
			// 
			// DlgEditDB
			// 
			AcceptButton = btnOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = btnCancel;
			ClientSize = new Size(1032, 421);
			Controls.Add(Page1);
			Controls.Add(btnCancel);
			Controls.Add(btnOK);
			Controls.Add(btnTest);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "DlgEditDB";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Database Parameters";
			Page1.ResumeLayout(false);
			tabMySql.ResumeLayout(false);
			tabMySql.PerformLayout();
			tabSqlServer.ResumeLayout(false);
			tabSqlServer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)gridSqlSer).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button btnOK;
		private Button btnCancel;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox txtbxServer;
		private TextBox txtbxDatabase;
		private TextBox txtbxUsername;
		private TextBox txtbxPassword;
		private ListBox listBox1;
		private Label label5;
		private TextBox txtbxTitle;
		private Button btnTest;
		private TextBox txtJson;
		private Button button1;
		private Button button2;
		private Button button3;
		private TabControl Page1;
		private TabPage tabMySql;
		private TabPage tabSqlServer;
		private DataGridView gridSqlSer;
		private TextBox txtConnection;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
	}
}