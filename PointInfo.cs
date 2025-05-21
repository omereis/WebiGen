/*****************************************************************************\
|                                  WebiGen                                    |
|                               PointInfo.cs                                  |
\*****************************************************************************/
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------------------------------------
using OmerEisCommon;
using System.Runtime.InteropServices;
using System.IO;
//----------------------------------------------------------------------------
namespace WebiGen {
	public class TPointInfo {
		private static readonly string CsvPointStart = "Point Name";
		private static readonly string CsvPointID = "Point ID";
		private int m_id;
		private string m_strName;
		private string m_strDevice;
		private string m_strDetector;
		private string m_strIP;
		private int m_strConnectionID;
		private TRadValue[] m_aRads;
//----------------------------------------------------------------------------
		public int    PointID      {get{return(m_id);}set{m_id=value;}}
		public string Name         {get{return(m_strName);}set{m_strName=value;}}
		public string Device       {get{return(m_strDevice);}set{m_strDevice=value;}}
		public string Detector     {get{return(m_strDetector);}set{m_strDetector=value;}}
		public string IP           {get{return(m_strIP);}set{m_strIP=value;}}
		public int    ConnectionID {get{return(m_strConnectionID);}set{m_strConnectionID=value;}}
		public TRadValue[] Radiations {get{return(m_aRads);}set{m_aRads=value;;}}
//----------------------------------------------------------------------------
		public TPointInfo () {
			Clear ();
		}
//----------------------------------------------------------------------------
		public TPointInfo (TPointInfo other) {
			AssignAll (other);
		}
//----------------------------------------------------------------------------
		public void Clear () {
			PointID      = 0;
			Name         = "";
			Device       = "";
			Detector     = "";
			IP           = "";
			ConnectionID = 0;
			Radiations   = null;
		}
//----------------------------------------------------------------------------
		public void AssignAll (TPointInfo other) {
			PointID      = other.PointID;
			Name         = other.Name;
			Device       = other.Device;
			Detector     = other.Detector;
			IP           = other.IP;
			ConnectionID = other.ConnectionID;
			Radiations   = other.Radiations;
		}
//----------------------------------------------------------------------------
		public static bool LoadFromDB (SqlConnection database, int idMap, ref TPointInfo[] aPoints, ref string strErr) {
			ArrayList al = null;
			aPoints = null;
			bool fLoad = TPointInfoDB.LoadFromDB (database, idMap, ref al, ref strErr);
			if (fLoad) {
				if (al != null) {
					aPoints = new TPointInfo[al.Count];
					for (int n=0 ; n < al.Count ; n++)
						aPoints[n] = (TPointInfo) al[n];
				}
			}
			return (fLoad);
		}
//----------------------------------------------------------------------------
		public static DateTime? GetSamplingRate (TRadValue[] aRads) {
			double dDiff;
			SortedDictionary<double, int> histogram = new SortedDictionary<double, int>();
			TimeSpan? ts=null;
			DateTime? dtRate=null;

			if (aRads != null) {
				if (aRads.Length >= 2) {
					for (int n=0 ; n < aRads.Length - 1 ; n++) {
						DateTime? dtStart = aRads[n].SampleTime;
						DateTime? dtEnd = aRads[n+1].SampleTime;
						ts = dtEnd - dtStart;
						if (ts != null) {
							dDiff = ts.Value.TotalMilliseconds;
							if (histogram.ContainsKey (dDiff))
								histogram[dDiff]++;
							else
								histogram[dDiff] = 1;
						}
					}
					//for (int n=0 ; n < histogram.Count ; n++)
						//if (histogram.Keys.V
				}
				int m = histogram.Values.Max();
				double dMax = -1;;
				int nMax = -1;
				foreach (KeyValuePair<double, int> kvp in histogram) {
					if (kvp.Value > nMax) {
						dMax = kvp.Key;
						nMax = kvp.Value;
					}
				}
				if (dMax > 0)
					dtRate = new DateTime(1970, 1, 1) + TimeSpan.FromMilliseconds (dMax); 
			}
			return (dtRate);
		}
//----------------------------------------------------------------------------
		public bool LoadStartRad (SqlConnection database, ref TRadValue rad, ref string strErr) {
			return (TRadValue.LoadStartRad (database, PointID, ref rad, ref strErr));
		}
//----------------------------------------------------------------------------
		public bool LoadRadiations (SqlConnection database, ref TRadValue[] aRad, ref string strErr) {
			return (TRadValue.LoadFromDB (database, PointID, ref aRad, ref strErr));
		}
//----------------------------------------------------------------------------
		public int RadToCsv (TRadValue[] aRads, ArrayList al) {
			string[] astr = new string[3];

			astr[0] = CsvPointStart;
			astr[1] = Name;
			//astr[2] = CsvPointID;
			astr[2] = PointID.ToString();
			al.Add(astr);
			//astr = new string[3];
			//astr[0] = "Date Time";
			//astr[1] = "Rate";
			//astr[2] = "Dose";
			//al.Add(astr);
			for (int n=0 ; n < aRads.Length ; n++) {
				astr = new string[3];
				astr[0] = TMisc.AppDateTime (aRads[n].SampleTime);
				astr[1] = aRads[n].Rate.ToString("0.##");
				astr[2] = aRads[n].Dose.ToString("0.##");
				al.Add (astr);
			}
			return (al.Count);
		}
//----------------------------------------------------------------------------
		public static TPointInfo[] ReadFromCsv (string[] astrFile) {
			TPointInfo[] aPoints = null;
			ArrayList alPoints = new ArrayList (), alRads = null;//new ArrayList ();
			TRadValue rv = new TRadValue ();
			TPointInfo pt = null;

			try {
				for (int n=0 ; n < astrFile.Length ; n++) {
					string[] astrLine = astrFile [n].Split (",");
					if (astrLine.Length >= 3) {
						if (astrLine[0] == CsvPointStart) {
							if (pt != null) {
								pt.SetRadiations (alRads);
								alPoints.Add (new TPointInfo (pt));
							}
							pt = TPointInfo.ReadFromLine (astrLine);
							alRads = new ArrayList ();
						}
						else {
							if (rv.ReadFromLine (astrLine))
								alRads.Add (new TRadValue (rv));
						}
					}
				}
				if (pt != null) {
					if (alRads != null)
						pt.SetRadiations (alRads);
					alPoints.Add (new TPointInfo (pt));
				}
				if (alRads != null)
					aPoints = TPointInfo.ToArray (alPoints);
			}
			catch (Exception ex) {
				aPoints = null;
				Console.WriteLine (ex.Message);
			}
			return (aPoints);
		}
//----------------------------------------------------------------------------
		public static TPointInfo[] ToArray (ArrayList alPoints) {
			TPointInfo[] aPoints = null;

			if (alPoints != null) {
				if (alPoints.Count > 0) {
					aPoints = new TPointInfo[alPoints.Count];
					for (int n=0 ; n < alPoints.Count ; n++)
						aPoints[n] = (TPointInfo) alPoints[n];
				}
			}
			return (aPoints);
		}
//----------------------------------------------------------------------------
		public static TPointInfo ReadFromLine (string[] astrLine) {
			TPointInfo pt = null;

			if (astrLine.Length >= 3) {
				if (astrLine[0] == CsvPointStart) {
					pt = new TPointInfo ();
					pt.Name = astrLine[1];
					pt.PointID = TMisc.ToIntDef (astrLine[2]);
				}
			}
			return (pt);
		}
//----------------------------------------------------------------------------
		public override string ToString() {
			return (Name);
		}
//----------------------------------------------------------------------------
		public void SetRadiations (ArrayList alRads) {
			TRadValue[] aRads = null;

			if (alRads != null)
				if (alRads.Count > 0) {
					aRads = new TRadValue[alRads.Count];
					for (int n=0 ; n < alRads.Count ; n++)
						aRads[n] = (TRadValue) alRads[n];
					Radiations = aRads;
				}
		}
//----------------------------------------------------------------------------
		public bool InsertToDB (SqlConnection database, bool fDeleteCurrent, bool fOverride, ref string strErr) {
			TPointInfoDB ptdb = new TPointInfoDB (this);
			return (ptdb.InsertToDB (database, fDeleteCurrent, fOverride, ref strErr));
		}
//----------------------------------------------------------------------------
	}
//----------------------------------------------------------------------------
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//----------------------------------------------------------------------------
	internal class TPointInfoDB : TPointInfo {
		private static readonly string SelectString = "select * from points, connections, connections_tcp where (connections.ConnectionId = connections_tcp.ConnectionId) and (connections.ConnectionId=points.Connection_ConnectionId)";
		private static readonly string PointsTable = "points";
		private static readonly string FldPointID = "PointId";
		private static readonly string FldName = "Name";
		private static readonly string FldDetector = "Detector_Type";
		private static readonly string FldConnection = "ConnectionId";
		private static readonly string FldDevice = "DeviceType";
		private static readonly string FldIP = "IP";
//----------------------------------------------------------------------------
		public TPointInfoDB() : base () {}
		public TPointInfoDB (TPointInfo other) : base (other) {}
		public TPointInfoDB (TPointInfoDB other) : base (other) {}
//----------------------------------------------------------------------------
		public static bool LoadFromDB (SqlConnection database, int idMap, ref ArrayList alPoints, ref string strErr) {
			bool fLoad;
			SqlDataReader reader = null;

			try {
				alPoints = null;
				TPointInfoDB point = new TPointInfoDB();
				SqlCommand cmd = database.CreateCommand ();
				string strMapPoints = String.Format ("(PointId in (select Point_PointId as 'PointId' from locations where Map_MapId={0}))", idMap);
				cmd.CommandText = SelectString + "and " + strMapPoints;
				reader = cmd.ExecuteReader ();
				for (fLoad = true ; (reader.Read ()) && (fLoad) ; ) {
					if ((fLoad = point.LoadFromReader (reader, ref strErr)) == true) {
						if (alPoints == null)
							alPoints = new ArrayList ();
						alPoints.Add (new TPointInfo (point));
					}
				}
			}
			catch (Exception ex) {
				strErr = ex.Message;
				fLoad = false;
			}
			finally {
				if (reader != null)
					reader.Close ();
			}
			return (fLoad);
		}
//----------------------------------------------------------------------------
		private bool LoadFromReader (SqlDataReader reader, ref string strErr) {
			bool fRead;

			try {
				PointID      = TMisc.ReadIntField (reader, FldPointID, ref strErr);
				Name         = TMisc.ReadTextField (reader, FldName, ref strErr);
				Device       = TMisc.ReadTextField (reader, FldDevice, ref strErr);
				Detector     = TMisc.ReadTextField (reader, FldDetector, ref strErr);
				IP           = TMisc.ReadTextField (reader, FldIP, ref strErr);
				ConnectionID = TMisc.ReadIntField (reader, FldConnection, ref strErr);
				fRead = true;
			}
			catch (Exception ex) {
				strErr=ex.Message;
				fRead = false;
			}
			return (fRead);
		}
//----------------------------------------------------------------------------
		public bool LoadPointByID (SqlConnection database, ref TPointInfo pt, int idPoint, ref string strErr) {
			bool fLoad=false;
			SqlDataReader reader = null;

			try {
				SqlCommand cmd = database.CreateCommand();
				cmd.CommandText = String.Format("select * from {0} where {1}={2};", PointsTable,FldPointID, idPoint);
				reader = cmd.ExecuteReader();
				if (reader.Read()) {
					TPointInfoDB ptdb = new TPointInfoDB ();
					if (ptdb.LoadFromReader (reader, ref strErr))
						pt = new TPointInfo (ptdb);

				}
				fLoad = true;
			}
			catch (Exception ex) {
				strErr = ex.Message;
				fLoad = false;
			}
			finally {
				if (reader != null)
					reader.Close ();
			}
			return (fLoad);
		}
//----------------------------------------------------------------------------
		public new bool InsertToDB (SqlConnection database, bool fDeleteCurrent, bool fOverride, ref string strErr) {
			TPointInfo pt = null;
			bool fInsert = false;

			if (LoadPointByID (database, ref pt, PointID, ref strErr)) {
				if (pt.PointID == PointID) {
					if ((pt.Name != Name) && (fDeleteCurrent || fOverride))
						fInsert = UpdateInDB (database, ref strErr);
				}
				else
					fInsert = InsertAsNew (database, ref strErr);
			}
			if (fOverride)
				fInsert = TRadValue.DeleteRadiations (database, PointID, Radiations, ref strErr);
			if (fInsert)
				fInsert = TRadValue.InsertValues (database, PointID, Radiations, ref strErr);
			return (fInsert);
		}
//----------------------------------------------------------------------------
		public new bool UpdateInDB (SqlConnection database, ref string strErr) {
			bool fUpdate = false;

			try {
				SqlCommand cmd = database.CreateCommand ();
				cmd.CommandText = String.Format ("update {0} set {1}={2} where {3}={4};",
									PointsTable,
									FldName, TMisc.GetSqlText(Name),
									FldPointID, PointID);
				cmd.ExecuteNonQuery ();
				fUpdate = true;
			}
			catch (Exception ex) {
				strErr += ex.Message;
				fUpdate = false;
			}
			return (fUpdate);
		}
//----------------------------------------------------------------------------
		public bool InsertAsNew (SqlConnection database, ref string strErr) {
			bool fInsert = false;

			try {
				SqlCommand cmd = database.CreateCommand ();
				cmd.CommandText = String.Format ("insert into {0} ({1},{2}) values ({3},{4});",
								PointsTable,
								FldPointID, FldName,
								PointID, TMisc.GetSqlText(Name));
				cmd.ExecuteNonQuery ();
				fInsert = true;
			}
			catch (Exception ex) {
				strErr += ex.Message;
				fInsert = false;
			}
			return (fInsert);
		}
//----------------------------------------------------------------------------
	}
//----------------------------------------------------------------------------
}
