/*****************************************************************************\
|                                  WebiGen                                    |
|                                  main.cs                                    |
\*****************************************************************************/
//-----------------------------------------------------------------------------
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using OmerEisCommon;
//-----------------------------------------------------------------------------
using OmerEisGlobal;
using System;
using System.Collections;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;
using TDoubleHistogram = System.Collections.Generic.SortedDictionary<uint, uint>;
//using TUintHistogram = System.Collections.Generic.KeyValuePair<uint, double>;
using TUintHistogram = System.Collections.Generic.SortedDictionary<uint, double>;
//-----------------------------------------------------------------------------
namespace WebiGen {
	public partial class frmMain : Form {
		private TDBParams m_db_params;
		private static readonly string DefauleConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=OMER\\SQLEXPRESS;TrustServerCertificate=True;";
		SqlConnection m_database;
		string m_strErr = "";
		TRadValue[] m_aStatRads;
		//----------------------------------------------------------------------------
		public frmMain() {
			InitializeComponent();
			m_db_params = null;
			m_database = null;
			m_aStatRads = null;
		}
		//----------------------------------------------------------------------------
		private void miExit_Click(object sender, EventArgs e) {
			Close();
		}
		//----------------------------------------------------------------------------
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
			InitRateChart();
		}
		//----------------------------------------------------------------------------
		private void InitRateChart() {
			chartRate.Series.Clear();
			//ChartArea CA = chartRate.ChartAreas[0];  // quick reference
			//CA.AxisX.ScaleView.Zoomable = true;
			//CA.CursorX.AutoScroll = true;
			//CA.CursorX.IsUserSelectionEnabled = true;
		}
		//----------------------------------------------------------------------------
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
		//----------------------------------------------------------------------------
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
		//----------------------------------------------------------------------------
		private string LoadIniConnectionString() {
			string str = "";
			TIniFile ini = new TIniFile(TMisc.GetIniName());
			str = ini.ReadString("Database", "default");
			return (str);
		}
		//----------------------------------------------------------------------------
		private void SaveIniConnectionString(string strConnection) {
			TIniFile ini = new TIniFile(TMisc.GetIniName());
			ini.WriteString("Database", "default", strConnection);
		}
		//----------------------------------------------------------------------------
		private void frmMain_FormClosed(object sender, FormClosedEventArgs e) {
			Application.Idle -= OnIdle;
			if(m_database != null) {
				m_database.Close();
			}
		}
		//----------------------------------------------------------------------------
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
		//----------------------------------------------------------------------------
		private void btnConnect_Click(object sender, EventArgs e) {
			ConnectToDB();
			SetConnectButtons(true);
		}
		//----------------------------------------------------------------------------
		private void btnDisconnect_Click(object sender, EventArgs e) {
			DisconnectDatabase();
			SetConnectButtons(false);
			UpdateStatusBar();
		}
		//----------------------------------------------------------------------------
		private void DisconnectDatabase() {
			if(m_database != null)
				if(m_database.State == ConnectionState.Open)
					m_database.Close();
		}
		//----------------------------------------------------------------------------
		private void SetConnectButtons(bool fConnect) {
			btnConnect.Enabled = !fConnect;
			btnDisconnect.Enabled = fConnect;
		}
		//----------------------------------------------------------------------------
		private bool DatabaseConnected() {
			bool fConnected = false;

			if(m_database != null)
				fConnected = m_database.State == ConnectionState.Open;
			return (fConnected);
		}
		//----------------------------------------------------------------------------
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
				if(comboMaps.Items.Count > 0)
					comboMaps.SelectedIndex = 0;
				comboMaps.Items.Add("");
			}
		}
		//----------------------------------------------------------------------------
		private void OnIdle(object sender, EventArgs e) {
			EnableLoadPoints();
			EnableLoadRads();
			btnMaps.Enabled = DatabaseConnected();
			btnPointRefresh.Enabled = UpoadSelectedPoint(comboPoints) != null;
			EnablePointDel();
			EnablePointInsert();
		}
		//----------------------------------------------------------------------------
		private void EnablePointDel() {
			TPointInfo pt = UpoadSelectedPoint(comboPoints);
			//gboxManipulation.Enabled = (pt != null);
			//gboxDel.Visible = rbPointDel.Checked;
			//gboxDel.Enabled = rbPointDel.Checked;
			//if (rbPointDel.Checked) {
			pt = UpoadSelectedPoint(comboPoints);
			gboxDelDates.Enabled = rbDelDates.Checked;
			gboxDelRates.Enabled = rbDelByValue.Checked;
			bool f = rbDelNone.Checked;
			btnPointRadDel.Enabled = (rbDelAll.Checked) || (pt != null) &&
					((rbDelByValue.Checked && IsValidDelParams()) ||
					(rbDelDates.Checked && IsValidDelParams()));
			//} else {
			//gboxDelDates.Enabled = false;
			//gboxDelRates.Enabled = false;
			//btnPointRadDel.Enabled = false;
			//}
		}
		//----------------------------------------------------------------------------
		private void EnablePointInsert() {
			//TPointInfo pt = UpoadSelectedPoint(comboPoints);
			//gboxManipulation.Enabled = (pt != null);
			//gboxInsert.Visible = (pt != null) && radioPointInsert.Checked;
			//gboxInsert.Enabled = (pt != null) && radioPointInsert.Checked;
			//gboxInsert.Top = gboxDel.Top;
			//gboxInsert.Left = gboxDel.Left;
		}
		//----------------------------------------------------------------------------
		private TPointInfo UpoadSelectedPoint(ComboBox combo) {
			TPointInfo pt = null;

			try {
				if(combo.SelectedItem != null)
					pt = (TPointInfo)combo.SelectedItem;
			} catch(Exception) {
				pt = null;
			}
			return (pt);
		}
		//----------------------------------------------------------------------------
		private void EnableLoadPoints() {
			bool fMapSelected = false;

			try {
				if(DatabaseConnected()) {
					TMapInfo map = UploadCurrentMap();
					fMapSelected = (map != null);
				}
			} catch(Exception ex) {
				fMapSelected = false;
				Console.WriteLine(ex.Message);
			}
			btnLoadPoints.Enabled = fMapSelected;
		}
		//----------------------------------------------------------------------------
		private TMapInfo UploadCurrentMap() {
			TMapInfo map = null;

			if(comboMaps.SelectedItem != null)
				map = (TMapInfo)comboMaps.SelectedItem;
			return (map);
		}
		//----------------------------------------------------------------------------
		private void btnLoadPoints_Click(object sender, EventArgs e) {
			TPointInfo[] aPoints = null;
			TMapInfo map = UploadCurrentMap();

			gridPoints.Rows.Clear();
			comboPoints.Items.Clear();
			if(TPointInfo.LoadFromDB(m_database, map.ID, ref aPoints, ref m_strErr)) {
				gridPoints.RowCount = aPoints.Length;
				for(int n = 0; n < aPoints.Length; n++) {
					DownloadPointToRow(n, aPoints[n]);
					AddPoint(comboPoints, aPoints[n]);
				}
				comboPoints.Items.Add("");
			} else
				MessageBox.Show("Error loading points\n" + m_strErr);
		}
		//----------------------------------------------------------------------------
		private void AddPoint(ComboBox combo, TPointInfo point) {
			if(combo.Items.IndexOf(point) < 0)
				combo.Items.Add(point);
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
			TPointInfo[] aPoints = UploadSelectedPoints();
			if(aPoints != null)
				for(int n = 0; (n < aPoints.Length) && (fEnabled == false); n++)
					fEnabled = aPoints[n].PointID > 0;
			btnLoadRads.Enabled = fEnabled;
			miPointsExport.Enabled = fEnabled;
			btnExport.Enabled = fEnabled;
		}
		//----------------------------------------------------------------------------
		private TPointInfo[] UploadSelectedPoints() {

			//int[] aIDs = null;
			TPointInfo[] aPoints = null;
			ArrayList ar = new ArrayList();

			for(int n = 0; n < gridPoints.RowCount; n++) {
				if(CheckedPoint(n)) {
					TPointInfo point = UploadPointFromRow(gridPoints, n);
					if(point != null)
						ar.Add(new TPointInfo(point));
				}
			}
			if(ar.Count > 0) {
				aPoints = new TPointInfo[ar.Count];
				for(int n = 0; n < ar.Count; n++)
					aPoints[n] = (TPointInfo)ar[n];
			}
			return (aPoints);
		}
		//----------------------------------------------------------------------------
		private bool CheckedPoint(int row) {
			bool fChecked = false;

			if((row >= 0) && (row < gridPoints.RowCount))
				fChecked = TMisc.ToIntDef(gridPoints.Rows[row].Cells[0].Value) > 0;
			return (fChecked);
		}
		//----------------------------------------------------------------------------
		private TPointInfo UploadPointFromRow(DataGridView grid, int row) {
			TPointInfo point = null;

			if((row >= 0) && (row < grid.RowCount))
				point = (TPointInfo)grid.Rows[row].Cells[0].Tag;
			return (point);


		}
		//----------------------------------------------------------------------------
		private void btnLoadRads_Click(object sender, EventArgs e) {
			LoadPointsRadiation();
		}
		//----------------------------------------------------------------------------
		private void LoadPointsRadiation() {
			System.Windows.Forms.Cursor curOld = System.Windows.Forms.Cursor.Current;
			try {
				System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
				TRadValue[] aRads = null;
				TPointInfo[] aPoints = UploadSelectedPoints();

				if(aPoints != null) {
					for(int n = 0; n < aPoints.Length; n++) {
						if(TRadValue.LoadFromDB(m_database, aPoints[n].PointID, ref aRads, ref m_strErr)) {
							SetPointStats(aPoints[n], aRads);
							SetPointsTab(aPoints[n], aRads);
							DownloadPointsChart(aPoints[n], aRads);
						}
					}
				}
			} catch(Exception ex) {
			} finally {
				System.Windows.Forms.Cursor.Current = curOld;
			}
		}
		//----------------------------------------------------------------------------
		private void SetPointStats(TPointInfo point, TRadValue[] aRads) {
			double dMin, dMax, dAvg, dStd;
			dMin = dMax = dAvg = dStd = 0;
			int nRow = GetRowByPointID(gridStats, point);
			int nCount = TRadValue.GetStats(aRads, ref dMin, ref dMax, ref dAvg, ref dStd);
			if(nRow < 0)
				nRow = gridStats.Rows.Add();
			if(nRow >= 0) {
				try {
					gridStats.Rows[nRow].Cells[0].Tag = point;
					gridStats.Rows[nRow].Cells[0].Value = point.Name;
					gridStats.Rows[nRow].Cells[3].Value = TMisc.IntFormat(nCount);
					gridStats.Rows[nRow].Cells[1].Value = (aRads != null ? TMisc.AppDateTime(aRads[0].SampleTime) : "");
					gridStats.Rows[nRow].Cells[2].Value = (aRads != null ? TMisc.AppDateTime(aRads[aRads.Length - 1].SampleTime) : "");
					if(aRads != null) {
						DateTime? dt = TPointInfo.GetSamplingRate(aRads);
						if(dt != null)
							gridStats.Rows[nRow].Cells[4].Value = System.String.Format("{0}.{1:D3}", dt.Value.Second, dt.Value.Millisecond);
					} else {
						gridStats.Rows[nRow].Cells[4].Value = "";
					}
					gridStats.Rows[nRow].Cells[6].Value = (1e3 * dMin).ToString("0.##");
					gridStats.Rows[nRow].Cells[7].Value = (1e3 * dMax).ToString("0.##");
					gridStats.Rows[nRow].Cells[8].Value = (1e3 * dAvg).ToString("0.##");
					gridStats.Rows[nRow].Cells[9].Value = (1e3 * dStd).ToString("0.##");
				} catch(Exception ex) {
					m_strErr = ex.Message;
				}
			}
		}
		//----------------------------------------------------------------------------
		private int GetRowByPointID(DataGridView grid, TPointInfo point) {
			int n, nRow = -1;
			TPointInfo pointGrid;

			for(n = 0; (n < grid.Rows.Count) && (nRow < 0); n++) {
				pointGrid = UploadPointFromRow(grid, n);
				if(point.PointID == pointGrid.PointID)
					nRow = n;
			}
			return (nRow);
		}
		//----------------------------------------------------------------------------
		private void DownloadPointsChart(TPointInfo point, TRadValue[] aRads) {
			Series ser = FindSeriesByPoint(chartRate, point);

			if(ser != null)
				ser.Points.Clear();
			if(aRads != null) {
				if(ser == null) {
					ser = CreateSeries(chartRate, point);
					chartRate.Series.Add(ser);
				}
				//StreamWriter writer = new StreamWriter("rad.csv");
				try {
					for(int n = 0; n < aRads.Length; n++) {
						//ser.Points.AddY(aRads[n].Rate);
						ser.Points.AddXY(aRads[n].SampleTime, aRads[n].Rate);
						//ser.Points.AddXY(n, aRads[n].Rate);
						//writer.WriteLine(aRads[n].Rate.ToString());
					}
				} catch(Exception ex) {
					MessageBox.Show(ex.Message);
				}
				//writer.Close();
			}
		}
		//----------------------------------------------------------------------------
		private Series FindSeriesByPoint(Chart chart, TPointInfo point) {
			Series serFound = null;

			for(int n = 0; (n < chart.Series.Count) && (serFound == null); n++) {
				TPointInfo ptRad = (TPointInfo)chart.Series[n].Tag;
				if(point.PointID == ptRad.PointID)
					serFound = chart.Series[n];
			}
			return (serFound);
		}
		//----------------------------------------------------------------------------
		private Series CreateSeries(Chart chart, TPointInfo point) {
			Series serNew = new Series();
			serNew.ChartType = SeriesChartType.Line;
			//serNew.ChartType = SeriesChartType.FastLine;
			serNew.LegendText = point.Name;
			serNew.Tag = point;
			serNew.XValueType = ChartValueType.DateTime;
			return (serNew);
		}
		//----------------------------------------------------------------------------
		private void gridStats_CellClick(object sender, DataGridViewCellEventArgs e) {
			TRadAdd ra = null;
			if(e.ColumnIndex == 0) {
				TPointInfo point = (TPointInfo)gridStats.Rows[e.RowIndex].Cells[0].Tag;
				DlgAddPoint dlg = new DlgAddPoint();
				bool f = dlg.Execute(m_database, point, ref ra);
				//if (f)
			}
		}
		//----------------------------------------------------------------------------
		private void miPointsExport_Click(object sender, EventArgs e) {
			ExportSelectedPoints();
		}
		//----------------------------------------------------------------------------
		private void ExportSelectedPoints() {
			TPointInfo[] aPoints = UploadSelectedPoints();
			TRadValue[] aRads = null;
			ArrayList al = new ArrayList();
			System.Windows.Forms.Cursor curOld = System.Windows.Forms.Cursor.Current;

			if(dlgSaveCsv.ShowDialog() == DialogResult.OK) {
				try {
					System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
					if(aPoints != null) {
						for(int n = 0; n < aPoints.Length; n++) {
							if(aPoints[n].LoadRadiations(m_database, ref aRads, ref m_strErr))
								aPoints[n].RadToCsv(aRads, al);
						}
						if(al.Count > 0)
							TMisc.SaveToCsv(dlgSaveCsv.FileName, al);
					}
				} catch(Exception ex) {
					MessageBox.Show(ex.Message);
				} finally {
					System.Windows.Forms.Cursor.Current = curOld;
				}
			}
		}
		//----------------------------------------------------------------------------
		private void btnExport_Click(object sender, EventArgs e) {
			ExportSelectedPoints();
		}
		//----------------------------------------------------------------------------
		private void SetPointsTab(TPointInfo points, TRadValue[] aRads) {
		}
		//----------------------------------------------------------------------------
		private void btnPointRefresh_Click(object sender, EventArgs e) {
			RefreshCurrentPoint();
		}
		//----------------------------------------------------------------------------
		private void RefreshCurrentPoint() {
			TPointInfo pt = UpoadSelectedPoint(comboPoints);
			TRadValue[] aRads = null;
			System.Windows.Forms.Cursor curOld = System.Windows.Forms.Cursor.Current;

			try {
				chartRate.Series.Clear();
				if(pt != null) {
					System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
					if(TRadValue.LoadFromDB(m_database, pt.PointID, ref aRads, ref m_strErr)) {
						if(aRads != null) {
							SetTextDate(txtStartDate, aRads[0].SampleTime);
							SetTextDate(txtEndDate, aRads[aRads.Length - 1].SampleTime);
							txtPointCount.Text = TMisc.IntFormat(aRads.Length);
							DateTime? dt = TPointInfo.GetSamplingRate(aRads);
							if(dt != null)
								txtRate.Text = System.String.Format("{0}.{1:D3}", dt.Value.Second, dt.Value.Millisecond);
							DownloadStats(aRads);
						} else {
							txtStartDate.Text = "";
							txtStartDate.Tag = null;
							txtEndDate.Text = "";
							txtEndDate.Tag = null;
							txtPointCount.Text = "";
							txtRate.Text = "";
							txtMin.Text = "";
							txtMax.Text = "";
							txtAverage.Text = "";
							txtStdDiv.Text = "";
						}
						DownloadPointsChart(pt, aRads);
					} else {
						MessageBox.Show("Error loading point radiation\n" + m_strErr);
					}
				}
			} catch(Exception ex) {
				MessageBox.Show(ex.Message);
			} finally {
				System.Windows.Forms.Cursor.Current = curOld;
			}
		}
		//----------------------------------------------------------------------------
		private void SetTextDate(TextBox txt, DateTime? dt) {
			txt.Tag = dt;
			if(dt != null)
				txt.Text = TMisc.AppDateTime(dt);
		}
		//----------------------------------------------------------------------------
		private void DownloadStats(TRadValue[] aRads) {
			double dMin, dMax, dAvg, dStd;

			dMin = dMax = dAvg = dStd = 0;
			double dFactor = radioRem.Checked ? 1 : 1e3;
			TRadValue.GetStats(aRads, ref dMin, ref dMax, ref dAvg, ref dStd);
			txtMin.Text = (dMin * dFactor).ToString("N3");
			txtMax.Text = (dMax * dFactor).ToString("N3");
			txtAverage.Text = (dAvg * dFactor).ToString("N3");
			txtStdDiv.Text = (dStd * dFactor).ToString("N3");
			m_aStatRads = aRads;
		}
		//----------------------------------------------------------------------------
		private void importFromCSVToolStripMenuItem_Click(object sender, EventArgs e) {
			if(dlgOpenCsv.ShowDialog() == DialogResult.OK) {
				SqlCommand cmd = m_database.CreateCommand();
				SqlTransaction transaction = m_database.BeginTransaction();
				cmd.Transaction = transaction;
				DlgImportCsv dlg = new DlgImportCsv();
				if(dlg.Execute(cmd, dlgOpenCsv.FileName)) {
					transaction.Commit();
					RefreshCurrentPoint();
					LoadPointsRadiation();
				} else
					transaction.Rollback();
			}
		}
		//----------------------------------------------------------------------------
		private void comboPoints_DropDownClosed(object sender, EventArgs e) {
			RefreshCurrentPoint();
		}
		//----------------------------------------------------------------------------
		private void DelFromStartHandler(object sender, EventArgs e) {
			DateTime dt;
			if(txtStartDate.Tag != null)
				dtpDelFrom.Value = (DateTime)txtStartDate.Tag;
		}
		//----------------------------------------------------------------------------
		private void DelTilEndHandler(object sender, EventArgs e) {
			if(txtEndDate.Tag != null)
				dtpDelTo.Value = (DateTime)txtEndDate.Tag;
		}
		//----------------------------------------------------------------------------
		private bool IsValidDelParams() {
			TDelValueParams del_params = new TDelValueParams();
			if(rbDelDates.Checked)
				del_params.Upload(dtpDelFrom.Value, dtpDelTo.Value);
			else
				del_params.Upload(rbDelLt.Checked, rbDelEq.Checked, rbDelGt.Checked, txtDelVal.Text);
			return (del_params.IsValid());
		}
		//----------------------------------------------------------------------------
		private void btnPointRadDel_Click(object sender, EventArgs e) {
			TPointInfo pt = UpoadSelectedPoint(comboPoints);
			int nCount = 0;
			if(pt != null) {
				if(rbDelAll.Checked) {
					string strMessage = "Delete all records from point " + pt.Name + "?";
					if(MessageBox.Show(strMessage, "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
						if(pt.DeleteRadiations(m_database, null, ref m_strErr, ref nCount))
							MessageBox.Show(nCount.ToString() + " items deleted");
						else
							MessageBox.Show("Error deleting radiations:\n" + m_strErr);
				} else {
					TDelValueParams del_param = new TDelValueParams();
					if(rbDelDates.Checked)
						del_param.Upload(dtpDelFrom.Value, dtpDelTo.Value);
					else if(rbDelByValue.Checked)
						del_param.Upload(rbDelLt.Checked, rbDelEq.Checked, rbDelGt.Checked, txtDelVal.Text);
					DeleteByParam(pt, del_param);
				}
			}
		}
		//----------------------------------------------------------------------------
		private void DeleteByParam(TPointInfo pt, TDelValueParams del_param) {
			int nCount = 0;
			if(pt.LoadRadiationCount(m_database, del_param, ref nCount, ref m_strErr)) {
				string strMessage = System.String.Format("Delete {0} records from point {1}?", nCount, pt.Name);
				if(MessageBox.Show(strMessage, "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
					if(pt.DeleteRadiations(m_database, del_param, ref m_strErr, ref nCount)) {
						MessageBox.Show(TMisc.IntFormat(nCount) + " items deleted");
						RefreshCurrentPoint();
					} else
						MessageBox.Show("Error deleting radiations:\n" + m_strErr);
			} else
				MessageBox.Show("Error deleting radiations:\n" + m_strErr);
		}
		//----------------------------------------------------------------------------
		private void btnSetBoundaries_Click(object sender, EventArgs e) {
			if(txtStartDate.Tag != null)
				dtpDelFrom.Value = (DateTime)txtStartDate.Tag;
			if(txtEndDate.Tag != null)
				dtpDelTo.Value = (DateTime)txtEndDate.Tag;
		}
		//----------------------------------------------------------------------------
		private void radioRem_CheckedChanged(object sender, EventArgs e) {
			if(m_aStatRads != null)
				DownloadStats(m_aStatRads);
		}
		//----------------------------------------------------------------------------
		private void radioMilliRem_CheckedChanged(object sender, EventArgs e) {
			if(m_aStatRads != null)
				DownloadStats(m_aStatRads);
		}
		//----------------------------------------------------------------------------
		private double GetFactor(RadioButton radio) {
			return (radio.Checked ? 1 : 1000);
		}
		//----------------------------------------------------------------------------
		private void btnInsertDefault_Click(object sender, EventArgs e) {
			TPointInfo pt = UpoadSelectedPoint(comboPoints);
			TRadValue[] aRad = null;
			double dMin, dMax, dAvg, dStd;
			if(pt != null) {
				if(pt.LoadRadiations(m_database, ref aRad, ref m_strErr)) {
					dMin = dMax = dAvg = dStd = 0;
					TRadValue.GetStats(aRad, ref dMin, ref dMax, ref dAvg, ref dStd);
					DateTime? dtSampling = TPointInfo.GetSamplingRate(aRad);
					if(dtSampling != null)
						txtInsertSampling.Text = System.String.Format("{0}.{1:D3}", dtSampling.Value.Second, dtSampling.Value.Millisecond);
					double dFactor = GetFactor(radiInsertRem);
					SetTextDouble(txtInsertMin, dMin, dFactor);
					SetTextDouble(txtInsertMax, dMax, dFactor);
					SetTextDouble(txtInsertAvg, dAvg, dFactor);
					//txtInsertMin.Text = (dMin * dFactor).ToString("N3");
					//txtInsertMax.Text = (dMax * dFactor).ToString("N3");
					//txtInsertAvg.Text = (dAvg * dFactor).ToString("N3");
					DateTime? dt = TRadValue.GetLastDate(aRad);
					if(dt != null) {
						double dRate = TMisc.ToDoubleDef(txtInsertSampling.Text);
						dt = TRadValue.GetLastDate(aRad);
						dt = dt.Value.AddSeconds(-dRate);
						dtpInsertEnd.Value = (DateTime)dt;
						double dCount = TMisc.ToDoubleDef(txtInsertCount.Text);
						DateTime dtStart = dt.Value.AddSeconds(-(dCount * dRate));
					}
				}
			}
		}
		//----------------------------------------------------------------------------
		private static void SetTextDouble(TextBox txt, double dFactor) {
			if(txt.Tag != null) {
				try {
					double dValue = (double)txt.Tag;
					SetTextDouble(txt, dValue, dFactor);
				} catch {
				}
			}
		}
		//----------------------------------------------------------------------------
		private static void SetTextDouble(TextBox txt, double dValue, double dFactor) {
			txt.Text = (dValue * dFactor).ToString("N3");
			txt.Tag = dValue;
		}
		//----------------------------------------------------------------------------
		private void radiInsertRem_CheckedChanged(object sender, EventArgs e) {
			UpdateInsertValues();
		}
		//----------------------------------------------------------------------------
		private void UpdateInsertValues() {
			double dFactor = GetFactor(radiInsertRem);
			SetTextDouble(txtInsertMin, dFactor);
			SetTextDouble(txtInsertMax, dFactor);
			SetTextDouble(txtInsertAvg, dFactor);
		}
		//----------------------------------------------------------------------------
		private void radiInsertMiliRem_CheckedChanged(object sender, EventArgs e) {
			UpdateInsertValues();
		}
		//----------------------------------------------------------------------------
		private void btnInsStartByCount_Click(object sender, EventArgs e) {
			double dRate = TMisc.ToDoubleDef(txtInsertSampling.Text);
			double dCount = TMisc.ToDoubleDef(txtInsertCount.Text);
			if((dRate > 0) & (dCount > 0)) {
				DateTime dtStart = dtpInsertEnd.Value;
				DateTime dtEnd = dtStart.AddSeconds(-dRate * dCount);
				dtpInsertStart.Value = dtEnd;
			}
		}
		//----------------------------------------------------------------------------
		private void btnInsertCount_Click(object sender, EventArgs e) {
			DateTime dtStart = dtpInsertStart.Value;
			DateTime dtEnd = dtpInsertEnd.Value;
			double dRate = TMisc.ToDoubleDef(txtInsertSampling.Text);
			TimeSpan ts = dtEnd - dtStart;
			if(dRate > 0) {
				double dCount = ts.TotalSeconds / dRate;
				txtInsertCount.Text = System.String.Format("{0:#,0}", dCount);
			}
		}
		//----------------------------------------------------------------------------
		private void btnHistogramRefresh_Click(object sender, EventArgs e) {
			TPointInfo pt = UpoadSelectedPoint(comboPoints);
			gridHistogram.Rows.Clear();
			if(pt != null) {
				TUintHistogram hist = new TUintHistogram();
				if(pt.LoadRateHistogram(m_database, hist, ref m_strErr)) {
					gridHistogram.RowCount = hist.Count;
					TUintHistogram.KeyCollection keys = hist.Keys;
					int nRow = 0;
					foreach(uint k in keys) {
						gridHistogram.Rows[nRow].Cells[0].Value = System.String.Format("{0:#,0}", (hist[k] * 1e3));//.Values[0];
						gridHistogram.Rows[nRow].Cells[1].Value = TMisc.IntFormat((int)k);
						nRow++;
					}
				} else
					MessageBox.Show(m_strErr);
			}
		}
		//----------------------------------------------------------------------------
		private void btnInsCurrentStart_Click(object sender, EventArgs e) {
			TPointInfo pt = UpoadSelectedPoint(comboPoints);
			if(pt != null) {
				dtpInsertEnd.Value = (DateTime)txtStartDate.Tag;
			}
		}

		private void btnCalculateInsert_Click(object sender, EventArgs e) {

		}
	}
	//----------------------------------------------------------------------------
}
