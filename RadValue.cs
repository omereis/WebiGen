/*****************************************************************************\
|                                  WebiGen                                    |
|                                RadValue.cs                                  |
\*****************************************************************************/
using Microsoft.Data.SqlClient;
using OmerEisCommon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------------------------------------
namespace WebiGen {
	public class TRadValue {
		private int m_id;
		private float m_rRate;
		private float m_rDose;
		private DateTime? m_dt;
//----------------------------------------------------------------------------
		public int PointID {get{return (m_id);}set{m_id=value;}}
		public float Rate {get{return (m_rRate);}set{m_rRate=value;}}
		public float Dose {get{return (m_rDose);}set{m_rDose=value;}}
		public DateTime? SampleTime {get{return (m_dt);}set{m_dt=value;}}
//----------------------------------------------------------------------------
		public TRadValue () {
			Clear();
		}
//----------------------------------------------------------------------------
		public TRadValue (TRadValue other) {
			AssignAll (other);
		}
//----------------------------------------------------------------------------
		public void Clear() {
			PointID = 0;
			Rate = 0;
			Dose = 0;
			SampleTime = null;
		}
//----------------------------------------------------------------------------
		protected void AssignAll (TRadValue other) {
			PointID = other.PointID;
			Rate = other.Rate;
			Dose = other.Dose;
			SampleTime = other.SampleTime;
		}
//----------------------------------------------------------------------------
		public static bool LoadFromDB (SqlConnection database, int idPoint, ref TRadValue[] aRads, ref string strErr) {
			ArrayList al = new ArrayList();
			bool fLoad = TRadValueDB.LoadFromDB (database, idPoint, ref al, ref strErr);
			if (fLoad) {
				if (al.Count > 0) {
					aRads = new TRadValue[al.Count];
					for (int n=0 ; n < al.Count ; n++)
						aRads[n] = new TRadValue((TRadValue)al[n]);
				}
			}
			return (fLoad);
		}
//----------------------------------------------------------------------------
		public static void GetStats (TRadValue[] aRads, ref double dMin, ref double dMax, ref double dAvg, ref double dStd) {
			if (aRads.Length > 0) {
				int nCount = 0;
				dMin = dMax = dAvg = aRads[0].Rate;
				for (int n=1 ; n < aRads.Length ; n ++) {
					double dRate = aRads[n].Rate;
					if (dRate != 0) {
						if (dRate < dMin)
							dMin = dRate;
						if (dRate > dMax)
							dMax = dRate;
						dAvg += dRate;
						nCount++;
					}
				}
				dAvg /= nCount;
				dStd = 0;
				for (int n=0 ; n < aRads.Length ; n ++)
					if (aRads[n].Rate != 0)
						dStd += Math.Pow (aRads[n].Rate - dAvg, 2);
				dStd /= nCount;
				dStd = Math.Sqrt (dStd);
			}
		}
//----------------------------------------------------------------------------
		public static bool LoadStartRad (SqlConnection database, int idPoint, ref TRadValue rad, ref string strErr) {
			return (TRadValueDB.LoadStartRad (database, idPoint, ref rad, ref strErr));
		}

	}
//----------------------------------------------------------------------------
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//----------------------------------------------------------------------------
	public class TRadValueDB : TRadValue {
		public static readonly string Table = "DataRecords";
		private static readonly string FldTime = "RecordTime";
		private static readonly string FldPointID = "Point_PointId";
		private static readonly string FldDose = "Dose";
		private static readonly string FldRate = "Rate";
//----------------------------------------------------------------------------
		public TRadValueDB () : base () {}
//----------------------------------------------------------------------------
		public TRadValueDB (TRadValueDB other) : base (other) {}
//----------------------------------------------------------------------------
		public static bool LoadFromDB (SqlConnection database, int idPoint, ref ArrayList al, ref string strErr) {
			bool fLoad;
			SqlDataReader reader = null;

			try {
				SqlCommand cmd = database.CreateCommand ();
				TRadValueDB rad = new TRadValueDB ();
				cmd.CommandText = String.Format ("select * from {0} where {1}={2} order by {3}", Table, FldPointID, idPoint, FldTime);
				reader = cmd.ExecuteReader ();
				fLoad = true;
				al = new ArrayList ();
				while ((fLoad) && (reader.Read())) {
					if ((fLoad = rad.LoadFromReader (reader, ref strErr)) == true)
						al.Add (new TRadValue (rad));
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
				Clear ();
				PointID = TMisc.ReadIntField (reader, FldPointID, ref strErr);
				Rate = TMisc.ReadFloatField (reader, FldRate, ref strErr);
				Dose = TMisc.ReadFloatField (reader, FldDose, ref strErr);
				SampleTime = TMisc.ReadDateTimeField (reader, FldTime);
				fRead = true;
			}
			catch (Exception ex) {
				fRead = false;
				strErr = ex.Message;
			}
			return (fRead);
		}
//----------------------------------------------------------------------------
		public static new bool LoadStartRad (SqlConnection database, int idPoint, ref TRadValue rad, ref string strErr) {
			SqlDataReader reader = null;
			bool fLoad = false;

			try {
				SqlCommand cmd = database.CreateCommand ();
				cmd.CommandText = String.Format("select * from {0} where {1}={2} order by {3} asc;",
									Table, FldPointID, idPoint, FldTime);
				reader = cmd.ExecuteReader ();
				if (reader != null) {
					if (reader.Read ()) {
						TRadValueDB rdb = new TRadValueDB ();
						if ((fLoad = rdb.LoadFromReader (reader, ref strErr)) == true)
							if (rdb != null)
								rad = new TRadValue (rdb);
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
	}
}
