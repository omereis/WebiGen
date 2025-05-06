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
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Collections;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Linq.Expressions;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Windows.Forms.DataVisualization.Charting;
//-----------------------------------------------------------------------------
using OmerEisGlobal;
using OmerEisCommon;
//-----------------------------------------------------------------------------
namespace WebiGen {
	public partial class frmMain : Form {
		private TDBParams m_db_params;
		private static readonly string DefauleConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=OMER\\SQLEXPRESS;TrustServerCertificate=True;";
		SqlConnection m_database;
		string m_strErr = "";
		public frmMain() {
			InitializeComponent();
			m_db_params = null;
			m_database = null;
		}
//-----------------------------------------------------------------------------
		private void miExit_Click(object sender, EventArgs e) {
			Close();
		}
//-----------------------------------------------------------------------------
		private void button1_Click(object sender, EventArgs e) {
		}
//-----------------------------------------------------------------------------
		private void frmMain_Load(object sender, EventArgs e) {
			Application.Idle += OnIdle;
			bool fConnect = false;
			string strConn = "";

			try {
				fConnect = ConnectToDB();
			} catch(Exception ex) {
				MessageBox.Show("Error connectiong to database\n" + ex.Message);
				m_database = null;
				fConnect = false;
			}
		}
//-----------------------------------------------------------------------------
		private bool ConnectToDB() {
			string strConn = LoadIniConnectionString();
			bool fConnect = false;
			try {
				if(strConn.Length > 0) {
					DisconnectDatabase();
					m_database = new SqlConnection(strConn);
					m_database.Open();
					SetConnectButtons(true);
					fConnect = true;
				}
			} catch(Exception e) {
				fConnect = false;
				MessageBox.Show(e.Message);
			}
			UpdateStatusBar(/*strConn, fConnect*/);
			return (fConnect);
		}
//-----------------------------------------------------------------------------
		private void miDatabase_Click(object sender, EventArgs e) {
			DlgEditDB dlg = new DlgEditDB();
			string strConnection = LoadIniConnectionString();
			if(strConnection.Length == 0)
				strConnection = DefauleConnectionString;
			if(dlg.Execute(ref strConnection)) {
				SaveIniConnectionString(strConnection);
				ConnectToDB();
				//txtConnection.Text = strConnection;
			}
		}
//-----------------------------------------------------------------------------
		private string LoadIniConnectionString() {
			string str = "";
			TIniFile ini = new TIniFile(TMisc.GetIniName());
			str = ini.ReadString("Database", "default");
			return (str);
		}
//-----------------------------------------------------------------------------
		private void SaveIniConnectionString(string strConnection) {
			TIniFile ini = new TIniFile(TMisc.GetIniName());
			ini.WriteString("Database", "default", strConnection);
		}
//-----------------------------------------------------------------------------
		private void frmMain_FormClosed(object sender, FormClosedEventArgs e) {
			Application.Idle -= OnIdle;
			if(m_database != null) {
				m_database.Close();
			}
		}
//-----------------------------------------------------------------------------
		private void UpdateStatusBar(/*string strConnection, bool fConnect*/) {
			//TMsSqlDbParams ms_params = new TMsSqlDbParams(strConnection);
			string strServer = "", strDatabase = "";
			bool fConnect = false;
			if(m_database != null) {
				strServer = m_database.DataSource;
				strDatabase = m_database.Database;
				fConnect = m_database.State == ConnectionState.Open;
			}
			//string strServer = ms_params.GetServer();
			//string strDatabase = ms_params.GetDatabase ();
			status_bar.Items[0].Text = System.String.Format("Server={0}", strServer);
			status_bar.Items[1].Text = System.String.Format("Database={0}", strDatabase);
			status_bar.Items[2].Text = (fConnect ? "Connected" : "Disconnected");
		}
//-----------------------------------------------------------------------------
		private void btnConnect_Click(object sender, EventArgs e) {
			ConnectToDB();
			SetConnectButtons(true);
		}
//-----------------------------------------------------------------------------
		private void btnDisconnect_Click(object sender, EventArgs e) {
			DisconnectDatabase();
			SetConnectButtons(false);
			UpdateStatusBar();
		}
//-----------------------------------------------------------------------------
		private void DisconnectDatabase() {
			if(m_database != null)
				if(m_database.State == ConnectionState.Open)
					m_database.Close();
		}
//-----------------------------------------------------------------------------
		private void SetConnectButtons(bool fConnect) {
			btnConnect.Enabled = !fConnect;
			btnDisconnect.Enabled = fConnect;
		}
//-----------------------------------------------------------------------------
		private bool DatabaseConnected() {
			bool fConnected = false;

			if(m_database != null)
				fConnected = m_database.State == ConnectionState.Open;
			return (fConnected);
		}
//-----------------------------------------------------------------------------
		private void btnLoadMaps_Click(object sender, EventArgs e) {
			if(DatabaseConnected()) {
				TMapInfo[] aMaps = null;

				comboMaps.Items.Clear();
				if(TMapInfo.LoadMapsFromDB(m_database, ref aMaps, ref m_strErr)) {
					if(aMaps != null)
						for(int n = 0; n < aMaps.Length; n++)
							comboMaps.Items.Add(aMaps[n]);
				} else
					MessageBox.Show("Error loading maps:\n" + m_strErr);
				if (comboMaps.Items.Count > 0)
					comboMaps.SelectedIndex = 0;
				comboMaps.Items.Add("");
			}
		}
//-----------------------------------------------------------------------------
		private void OnIdle(object sender, EventArgs e) {
			EnableLoadPoints();
			EnableLoadRads();
		}
//-----------------------------------------------------------------------------
		private void EnableLoadPoints() {
			bool fMapSelected = false;

			try {
				if(DatabaseConnected()) {
					TMapInfo map = UploadCurrentMap ();
					fMapSelected = (map != null);
				}
			} catch(Exception ex) {
				fMapSelected = false;
				Console.WriteLine(ex.Message);
			}
			btnLoadPoints.Enabled = fMapSelected;
		}
//----------------------------------------------------------------------------
		private TMapInfo UploadCurrentMap () {
			TMapInfo map = (TMapInfo)comboMaps.SelectedItem;
		}
//----------------------------------------------------------------------------
		private void btnLoadPoints_Click(object sender, EventArgs e) {
			TPointInfo[] aPoints = null;
			TMapInfo map = UploadCurrentMap ();

			gridPoints.Rows.Clear();
			if(TPointInfo.LoadFromDB(m_database, ref aPoints, ref m_strErr)) {
				gridPoints.RowCount = aPoints.Length;
				for(int n = 0; n < aPoints.Length; n++)
					DownloadPointToRow(n, aPoints[n]);
			} else
				MessageBox.Show("Error loading points\n" + m_strErr);
		}
//----------------------------------------------------------------------------
		private void DownloadPointToRow(int row, TPointInfo point) {
			gridPoints.Rows[row].Cells[0].Tag = point;
			gridPoints.Rows[row].Cells[0].Value = false;
			gridPoints.Rows[row].Cells[1].Value = point.PointID;
			gridPoints.Rows[row].Cells[2].Value = point.Name;
			gridPoints.Rows[row].Cells[3].Value = point.Device;
			gridPoints.Rows[row].Cells[4].Value = point.Detector;
			gridPoints.Rows[row].Cells[5].Value = point.ConnectionID;
			gridPoints.Rows[row].Cells[6].Value = point.IP;

		}
//----------------------------------------------------------------------------
		private void gridPoints_CellClick(object sender, DataGridViewCellEventArgs e) {
			if(e.ColumnIndex == 0)
				TogglePoint(e.RowIndex);
		}
//----------------------------------------------------------------------------
		private void TogglePoint(int row) {
			if((row >= 0) && (row < gridPoints.RowCount)) {
				//int n = TMisc.ToIntDef (gridPoints.Rows[row].Cells [0].Value);
				if(CheckedPoint(row))
					//if (n == 0)
					gridPoints.Rows[row].Cells[0].Value = false;
				else
					gridPoints.Rows[row].Cells[0].Value = true;
			}
		}
//----------------------------------------------------------------------------
		private void EnableLoadRads() {
			bool fEnabled = false;
			int[] aPoints = UploadSelectedPoints();
			if(aPoints != null)
				for(int n = 0; (n < aPoints.Length) && (fEnabled == false); n++)
					fEnabled = aPoints[n] > 0;
			btnLoadRads.Enabled = fEnabled;
		}
//----------------------------------------------------------------------------
		private int[] UploadSelectedPoints() {

			int[] aIDs = null;
			ArrayList ar = new ArrayList();

			for(int n = 0; n < gridPoints.RowCount; n++) {
				if(CheckedPoint(n)) {
					TPointInfo point = UploadPointFromRow(n);
					if(point != null)
						ar.Add(point.PointID);
				}
			}
			if(ar.Count > 0) {
				aIDs = new int[ar.Count];
				for(int n = 0; n < ar.Count; n++)
					aIDs[n] = (int)ar[n];
			}
			return (aIDs);
		}
//----------------------------------------------------------------------------
		private bool CheckedPoint(int row) {
			bool fChecked = false;

			if((row >= 0) && (row < gridPoints.RowCount))
				fChecked = TMisc.ToIntDef(gridPoints.Rows[row].Cells[0].Value) > 0;
			return (fChecked);
		}
//----------------------------------------------------------------------------
		private TPointInfo UploadPointFromRow(int row) {
			TPointInfo point = null;
			if((row >= 0) && (row < gridPoints.RowCount))
				point = (TPointInfo)gridPoints.Rows[row].Cells[0].Tag;
			return (point);


		}
//----------------------------------------------------------------------------
		private void btnLoadRads_Click(object sender, EventArgs e) {
			TRadValue[] aRads=null;
			int[] aIDs = UploadSelectedPoints();

			for (int n=0 ; n < aIDs.Length ; n++) {
				if (TRadValue.LoadFromDB (m_database, aIDs[n], ref aRads, ref m_strErr)) {
					SetPointStats (aIDs[n], aRads);
				}
			}
		}
//----------------------------------------------------------------------------
		private void SetPointStats (int idPoint, TRadValue[] aRads) {
			if (aRads != null) {
				int nRow = GetRowByPointID (idPoint);
				if (nRow >= 0) {
					if (aRads.Length > 0) {
						gridPoints.Rows[nRow].Cells[7].Value = TMisc.AppTime (aRads[0].SampleTime);
						gridPoints.Rows[nRow].Cells[8].Value = TMisc.AppTime (aRads[aRads.Length - 1].SampleTime);
						gridPoints.Rows[nRow].Cells[9].Value = TMisc.IntFormat (aRads.Length);
					}
				}
			}
		}
//----------------------------------------------------------------------------
		private int GetRowByPointID (int idPoint) {
			int n, nRow=-1;
			TPointInfo point;

			for (n=0 ; (n < gridPoints.Rows.Count) && (nRow < 0) ; n++) {
				point = UploadPointFromRow (n);
				if (point.PointID == idPoint)
					nRow = n;
			}
			return (nRow);
		}
	}
	//-----------------------------------------------------------------------------
}
