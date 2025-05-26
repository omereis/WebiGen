/*****************************************************************************\
|                                  WebiGen                                    |
|                                RadValue.cs                                  |
\*****************************************************************************/
using Microsoft.Data.SqlClient;
using OmerEisCommon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
		public static int GetStats (TRadValue[] aRads, ref double dMin, ref double dMax, ref double dAvg, ref double dStd) {
			dMin = dMax = dAvg = dStd = 0;
			int nCount = 0, nLength = (aRads == null ? 0 : aRads.Length);
			//if (aRads.Length > 0) {
			if (nLength > 0) {
				dMin = dMax = dAvg = 0;
				if (aRads != null) {
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
			return (nCount);
		}
//----------------------------------------------------------------------------
		public static bool LoadStartRad (SqlConnection database, int idPoint, ref TRadValue rad, ref string strErr) {
			return (TRadValueDB.LoadStartRad (database, idPoint, ref rad, ref strErr));
		}
//----------------------------------------------------------------------------
		public static DateTime? DateTimeFromString (string strDate, string strTime) {
			DateTime? dt;

			try {
				dt = DateTime.Parse (strDate + ", " + strTime);
			}
			catch (Exception ex) {
				dt = null;
				Console.WriteLine (ex.ToString ());
			}
			return (dt);
		}
//----------------------------------------------------------------------------
		public bool ReadFromLine (string[] astrLine) {
			bool fRead=false;

			try {
				if (astrLine.Length >= 4) {
					SampleTime = DateTimeFromString (astrLine[0], astrLine[1]);
					Rate = (float) TMisc.ToDoubleDef (astrLine[2]);
					Dose = (float) TMisc.ToDoubleDef (astrLine[3]);
					fRead = true;
				}
			}
			catch (Exception ex) {
				Console.WriteLine (ex.Message);
				fRead = false;
			}
			return (fRead);
		}
//----------------------------------------------------------------------------
		public static bool InsertValues (SqlCommand cmd, int idPoint, TRadValue[] aRads, ref string strErr, ref int nInserted) {
			return (TRadValueDB.InsertValues (cmd, idPoint, aRads, ref strErr, ref nInserted));
		}
//----------------------------------------------------------------------------
		public static bool InsertValues (SqlConnection database, int idPoint, TRadValue[] aRads, ref string strErr, ref int nInserted) {
			return (InsertValues (database.CreateCommand(), idPoint, aRads, ref strErr, ref nInserted));
		}
//----------------------------------------------------------------------------
		public static bool DeleteRadiations (SqlConnection database, int idPoint, TRadValue[] aRads, ref string strErr) {
			return (TRadValueDB.DeleteRadiations(database, idPoint, aRads, ref strErr));
		}
//----------------------------------------------------------------------------
		public static bool DeleteRadiations (SqlCommand cmd, int idPoint, TRadValue[] aRads, ref string strErr) {
			return (TRadValueDB.DeleteRadiations(cmd, idPoint, aRads, ref strErr));
		}
//----------------------------------------------------------------------------
		public static bool DeleteRadiations (SqlCommand cmd, int idPoint, TDelValueParams del_params, ref string strErr) {
			//return (TRadValueDB.DeleteRadiations(DeleteRadiations (cmd, idPoint, del_params, ref strErr));
			bool f = TRadValueDB.DeleteRadiations (cmd, idPoint, del_params, ref strErr);
			return (f);
		}
//----------------------------------------------------------------------------
	}
//----------------------------------------------------------------------------
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//----------------------------------------------------------------------------
	internal class TRadValueDB : TRadValue {
		public static readonly string Table = "DataRecords";
		private static readonly string FldTime = "RecordTime";
		private static readonly string FldPointID = "Point_PointId";
		private static readonly string FldDose = "Dose";
		private static readonly string FldRate = "Rate";
		private static readonly string m_strInsertFormat = "{0} values {1};";

//----------------------------------------------------------------------------
		public TRadValueDB () : base () {}
//----------------------------------------------------------------------------
		public TRadValueDB (TRadValue other) : base (other) {}
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
//----------------------------------------------------------------------------
		public static new bool InsertValues (SqlCommand cmd, int idPoint, TRadValue[] aRads, ref string strErr, ref int nInserted) {
			bool fInsert = false;
			int j=0, n, nRows = 0;

			try {
				if (aRads != null) {
					ArrayList al = new ArrayList ();
					string strValues="", strSqlFmt = String.Format ("({0}={{0}})", FldTime);
					string strSqlBase = String.Format ("insert into {0} ({1},{2},{3},{4})",
													Table, FldTime, FldPointID, FldRate, FldDose);
					for (n=0 ; n < aRads.Length ; n++) {
						strValues = String.Format ("({0},{1},{2},{3})", TMisc.GetSqlString (aRads[n].SampleTime), idPoint, aRads[n].Rate, aRads[n].Dose);
						al.Add (strValues);
						if (al.Count == 25) {
							nRows += InsertValues (cmd, al, strSqlBase, ref strErr);
							al.Clear ();
						}
					}
					if (al.Count > 0) {
						nRows += InsertValues (cmd, al, strSqlBase, ref strErr);
					}
				}
				fInsert = true;
			}
			catch (Exception ex) {
				strErr = "Error during Insert:\n" + ex.Message;
				fInsert = false;
			}
			finally {
				nInserted = nRows;
			}
			return (fInsert);
		}
//----------------------------------------------------------------------------
		public static new bool InsertValues (SqlConnection database, int idPoint, TRadValue[] aRads, ref string strErr, ref int nInserted) {
			return (InsertValues (database.CreateCommand(), idPoint, aRads, ref strErr, ref nInserted));
		}
//----------------------------------------------------------------------------
		private static int InsertValues (SqlCommand cmd, ArrayList al, string strSqlBase, ref string strErr) {
			string strValues;
			int nRows=0;

			try {
				strValues = CombineForInsert (al);
				cmd.CommandText = String.Format (m_strInsertFormat, strSqlBase, strValues);
				nRows = cmd.ExecuteNonQuery ();
			}
			catch (Exception ex) {
				strErr = ex.Message;
			}
			return (nRows);
		}
//----------------------------------------------------------------------------
		private static string CombineForInsert (ArrayList al) {
			string str="";

			for (int n=0 ; n < al.Count ; n++) {
				str += (string) al[n];
				if (n < al.Count - 1)
					str += ",";
			}
			return (str);
		}
//----------------------------------------------------------------------------
		public static new bool DeleteRadiations (SqlCommand cmd, int idPoint, TRadValue[] aRads, ref string strErr) {
			bool fDelete = false;
			int nRows = 0;

			try {
				if (aRads != null) {
					ArrayList al = new ArrayList();
					string str, strDates="", strSqlFmt = String.Format ("({0}={{0}})", FldTime);
					//SqlCommand cmd = database.CreateCommand ();
					string strSqlBase = String.Format ("delete from {0} where (({1}={2}) and (",
								Table, FldPointID, idPoint);
					for (int n=0 ; n < aRads.Length ; n++) {
						str = String.Format (strSqlFmt, TMisc.GetSqlString (aRads[n].SampleTime));
						al.Add (str);
						if (al.Count == 25) {
							cmd.CommandText = String.Format ("{0}{1}));", strSqlBase, CombineItems (al));
							al.Clear();
							nRows += cmd.ExecuteNonQuery ();
						}
					}
					if (al.Count > 0) {
						cmd.CommandText = String.Format ("{0}{1}));", strSqlBase, CombineItems (al));
						nRows += cmd.ExecuteNonQuery ();
					}
				}
				fDelete = true;
			}
			catch (Exception ex) {
				strErr = "Error during delete:\n" + ex.Message;
				fDelete = false;
			}
			string s = nRows.ToString () + " affected rows";
			return (fDelete);
		}
//----------------------------------------------------------------------------
		public static new bool DeleteRadiations (SqlConnection database, int idPoint, TRadValue[] aRads, ref string strErr) {
			return (DeleteRadiations (database.CreateCommand(), idPoint, aRads, ref strErr));
		}
//----------------------------------------------------------------------------
		private static string CombineItems (ArrayList al) {
			string str = "";
			
			for (int n=0 ; n < al.Count ; n++ ) {
				str += (string) al[n];
				if (n < al.Count - 1)
					str += " or ";
			}
			return (str);
		}
//----------------------------------------------------------------------------
		public static new bool DeleteRadiations (SqlCommand cmd, int idPoint, TDelValueParams del_params, ref string strErr) {
			bool fDel = false;
			string strSql="", strWhere="";

			try {
				strSql = String.Format ("delete from {0} where {1}={2}", Table, FldPointID, idPoint);
				if (del_params != null)
					strWhere = GetSqlDelParams (del_params);
				if (strWhere.Length > 0 )
					strSql += " and (" + strWhere + ");";
				cmd.CommandText = strSql;
				int nRows = cmd.ExecuteNonQuery ();
				fDel = true;
			}
			catch (Exception ex) {
				strErr = "Error deleting records\n" + ex.Message;
				fDel = false;
			}
			return (fDel);
		}
//----------------------------------------------------------------------------
		private static string GetSqlDelParams (TDelValueParams del_params) {
			string strWhere = "";
			string strOp = "";

			if (del_params != null) {
				if (del_params.Op == EDelValueOp.DVO_GT)
					strOp = ">";
				else if (del_params.Op == EDelValueOp.DVO_EQ)
					strOp = "=";
				else if (del_params.Op == EDelValueOp.DVO_LT)
					strOp = ">";
				if (strOp.Length > 0)
					strWhere = String.Format ("{0} {1}", strOp, del_params.Value);
			}
			return (strWhere);
		}
//----------------------------------------------------------------------------
	}
}
