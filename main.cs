/*****************************************************************************\
|                                  WebiGen                                    |
|                                  main.cs                                    |
\*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------------------------------
using System.Collections;
using Microsoft.VisualBasic.ApplicationServices;
using MySqlX.XDevAPI.Relational;
using System.IO;
using System.Linq.Expressions;
namespace WebiGen
{
	public partial class frmMain : Form {
		public frmMain() {
			InitializeComponent();
		}
//-----------------------------------------------------------------------------
		private void miExit_Click(object sender, EventArgs e) {
			Close ();
		}
//-----------------------------------------------------------------------------
	}
}
