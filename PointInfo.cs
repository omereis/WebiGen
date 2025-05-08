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
//----------------------------------------------------------------------------
namespace WebiGen {
	public class TPointInfo {
		private int m_id;
		private string m_strName;
		private string m_strDevice;
		private string m_strDetector;
		private string m_strIP;
		private int m_strConnectionID;
//----------------------------------------------------------------------------
		public int    PointID      {get{return(m_id);}set{m_id=value;}}
		public string Name         {get{return(m_strName);}set{m_strName=value;}}
		public string Device       {get{return(m_strDevice);}set{m_strDevice=value;}}
		public string Detector     {get{return(m_strDetector);}set{m_strDetector=value;}}
		public string IP           {get{return(m_strIP);}set{m_strIP=value;}}
		public int    ConnectionID {get{return(m_strConnectionID);}set{m_strConnectionID=value;}}
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
		}
//----------------------------------------------------------------------------
		public void AssignAll (TPointInfo other) {
			PointID      = other.PointID;
			Name         = other.Name;
			Device       = other.Device;
			Detector     = other.Detector;
			IP           = other.IP;
			ConnectionID = other.ConnectionID;
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
	}
//----------------------------------------------------------------------------
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//----------------------------------------------------------------------------
	public class TPointInfoDB : TPointInfo {
		private static readonly string SelectString = "select * from points, connections, connections_tcp where (connections.ConnectionId = connections_tcp.ConnectionId) and (connections.ConnectionId=points.Connection_ConnectionId)";
		private static readonly string FldPointID = "PointId";
		private static readonly string FldName = "Name";
		private static readonly string FldDetector = "Detector_Type";
		private static readonly string FldConnection = "ConnectionId";
		private static readonly string FldDevice = "DeviceType";
		private static readonly string FldIP = "IP";
//----------------------------------------------------------------------------
		public TPointInfoDB() : base () {}
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
	}
//----------------------------------------------------------------------------
}
