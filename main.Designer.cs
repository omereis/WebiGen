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
			menuMain = new MenuStrip();
			popupFile = new ToolStripMenuItem();
			miDatabase = new ToolStripMenuItem();
			miFileSep1 = new ToolStripSeparator();
			miExit = new ToolStripMenuItem();
			popupHelp = new ToolStripMenuItem();
			miAbout = new ToolStripMenuItem();
			menuMain.SuspendLayout();
			SuspendLayout();
			// 
			// menuMain
			// 
			menuMain.Items.AddRange(new ToolStripItem[] { popupFile, popupHelp });
			menuMain.Location = new Point(0, 0);
			menuMain.Name = "menuMain";
			menuMain.Size = new Size(800, 24);
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
			miDatabase.Size = new Size(180, 22);
			miDatabase.Text = "&Database...";
			// 
			// miFileSep1
			// 
			miFileSep1.Name = "miFileSep1";
			miFileSep1.Size = new Size(177, 6);
			// 
			// miExit
			// 
			miExit.Name = "miExit";
			miExit.Size = new Size(180, 22);
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
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(menuMain);
			MainMenuStrip = menuMain;
			Name = "frmMain";
			Text = "WebeSmarts Data Generetor";
			menuMain.ResumeLayout(false);
			menuMain.PerformLayout();
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
	}
}
