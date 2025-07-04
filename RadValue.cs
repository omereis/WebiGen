﻿/*****************************************************************************\
|                                  WebiGen                                    |
|                                RadValue.cs                                  |
\*****************************************************************************/
using Microsoft.Data.SqlClient;
using OmerEisCommon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using TUintHistogram = System.Collections.Generic.SortedDictionary<uint, double>;
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
			int nRows=0;
			return (TRadValueDB.DeleteRadiations(database, idPoint, aRads, ref strErr, ref nRows));
		}
//----------------------------------------------------------------------------
		public static bool DeleteRadiations (SqlConnection database, int idPoint, TRadValue[] aRads, ref string strErr, ref int nRows) {
			return (TRadValueDB.DeleteRadiations(database, idPoint, aRads, ref strErr, ref nRows));
		}
//----------------------------------------------------------------------------
		public static bool DeleteRadiations (SqlCommand cmd, int idPoint, TRadValue[] aRads, ref string strErr) {
			int nRows=0;
			return (TRadValueDB.DeleteRadiations(cmd, idPoint, aRads, ref strErr, ref nRows));
		}
//----------------------------------------------------------------------------
		public static bool DeleteRadiations (SqlCommand cmd, int idPoint, TRadValue[] aRads, ref string strErr, ref int nRows) {
			return (TRadValueDB.DeleteRadiations(cmd, idPoint, aRads, ref strErr, ref nRows));
		}
//----------------------------------------------------------------------------
		public static bool DeleteRadiations (SqlCommand cmd, int idPoint, TDelValueParams del_param, ref string strErr, ref int nRows) {
			bool f = TRadValueDB.DeleteRadiations (cmd, idPoint, del_param, ref strErr, ref nRows);
			return (f);
		}
//----------------------------------------------------------------------------
		public static bool LoadRadiationCount (SqlCommand cmd, DateTime? dtFrom, DateTime? dtUntil, int idPoint, ref int nCount, ref string strErr) {
			return (TRadValueDB.LoadRadiationCount (cmd, dtFrom, dtUntil, idPoint, ref nCount, ref strErr));
		}
//----------------------------------------------------------------------------
		public static bool LoadRadiationCount (SqlCommand cmd, TDelValueParams del_param, int idPoint, ref int nCount, ref string strErr) {
			return (TRadValueDB.LoadRadiationCount (cmd, del_param, idPoint, ref nCount, ref strErr));
		}
//----------------------------------------------------------------------------
		public static DateTime? GetLastDate (TRadValue[] aRad) {
			DateTime? dt = null;

			if (aRad != null) {
				dt = aRad[0].SampleTime;
				for (int n=1 ; n < aRad.Length; n++) {
					if (dt.Value < aRad[n].SampleTime)
						dt = aRad[n].SampleTime;
				}
			}
			return (dt);
		}
//----------------------------------------------------------------------------
		public static bool GetStartEndTimes (TRadValue[] aRad, TDelValueParams rad_params) {
			bool fFound=false;
			int nStart, nEnd;

			if (aRad != null) {
				if (aRad.Length > 0) {
					nStart = nEnd = 0;
					for (int n=1 ; n < aRad.Length ; n++) {
						if (aRad[n].SampleTime < aRad[nStart].SampleTime)
							nStart = n;
						if (aRad[n].SampleTime > aRad[nEnd].SampleTime)
							nEnd = n;
					}
					rad_params.From = aRad[nStart].SampleTime;
					rad_params.Until = aRad[nEnd].SampleTime;
					fFound = true;
				}
			}
			return (fFound);
		}
//----------------------------------------------------------------------------
		public static bool LoadRateHistogram (SqlConnection database, int idPoint, TUintHistogram hist, ref string strErr) {
			return (TRadValueDB.LoadRateHistogram (database, idPoint, hist, ref strErr));
		}
//----------------------------------------------------------------------------
		public static bool InsertToDB (SqlConnection database, int idPoint, TRadValue[] aRad, ref uint nRows, ref string strErr) {
			return (TRadValueDB.InsertToDB (database, idPoint, aRad, ref nRows, ref strErr));
		}
//----------------------------------------------------------------------------
		public static void GetStartEnd (TRadValue[] aRad, ref DateTime? dtStart, ref DateTime? dtEnd) {
			if (aRad == null) {
				dtStart = dtEnd = null;
			}
			else {
				dtStart = aRad[0].SampleTime;
				dtEnd =  aRad[aRad.Length-1].SampleTime;
				for (int n=0 ; n < aRad.Length ; n++) {
					if (dtEnd < aRad[n].SampleTime)
						dtEnd = aRad[n].SampleTime;
					if (dtStart > aRad[n].SampleTime)
						dtStart = aRad[n].SampleTime;
				}
			}
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
				cmd.CommandText = System.String.Format ("select * from {0} where {1}={2} order by {3}", Table, FldPointID, idPoint, FldTime);
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
				cmd.CommandText = System.String.Format("select * from {0} where {1}={2} order by {3} asc;",
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
					string strValues="", strSqlFmt = System.String.Format ("({0}={{0}})", FldTime);
					string strSqlBase = System.String.Format ("insert into {0} ({1},{2},{3},{4})",
													Table, FldTime, FldPointID, FldRate, FldDose);
					for (n=0 ; n < aRads.Length ; n++) {
						strValues = System.String.Format ("({0},{1},{2},{3})", TMisc.GetSqlString (aRads[n].SampleTime), idPoint, aRads[n].Rate, aRads[n].Dose);
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
				cmd.CommandText = System.String.Format (m_strInsertFormat, strSqlBase, strValues);
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
		public static new bool DeleteRadiations (SqlCommand cmd, int idPoint, TRadValue[] aRads, ref string strErr, ref int nRows) {
			bool fDelete = false;
			//nRows = 0;

			try {
				if (aRads != null) {
					TDelValueParams rad_params = new TDelValueParams (ERadValueOp.RVO_DEL_BY_DATE);
					if (TRadValue.GetStartEndTimes (aRads, rad_params)) {
						fDelete = DeleteRadiations (cmd, idPoint, rad_params, ref strErr, ref nRows);
/*
						string str = System.String.Format ("delete from {0} where {1}={2} and {3} between {4} and {5};",
												Table, FldPointID, idPoint, FldTime,
												TMisc.GetDateString (rad_params.From),
												TMisc.GetDateString (rad_params.Until));
						cmd.CommandText = str;
						nRows = cmd.ExecuteNonQuery ();
*/
					}
/*
					ArrayList al = new ArrayList();
					string str, strDates="", strSqlFmt = System.String.Format ("({0}={{0}})", FldTime);
					//SqlCommand cmd = database.CreateCommand ();
					string strSqlBase = System.String.Format ("delete from {0} where (({1}={2}) and (",
								Table, FldPointID, idPoint);
					for (int n=0 ; n < aRads.Length ; n++) {
						str = System.String.Format (strSqlFmt, TMisc.GetSqlString (aRads[n].SampleTime));
						al.Add (str);
						if (al.Count == 25) {
							cmd.CommandText = System.String.Format ("{0}{1}));", strSqlBase, CombineItems (al));
							al.Clear();
							nRows += cmd.ExecuteNonQuery ();
						}
					}
					if (al.Count > 0) {
						cmd.CommandText = System.String.Format ("{0}{1}));", strSqlBase, CombineItems (al));
						nRows += cmd.ExecuteNonQuery ();
					}
*/
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
		public static new bool DeleteRadiations (SqlConnection database, int idPoint, TRadValue[] aRads, ref string strErr, ref int nRows) {
			return (DeleteRadiations (database.CreateCommand(), idPoint, aRads, ref strErr, ref nRows));
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
		public static new bool DeleteRadiations (SqlCommand cmd, int idPoint, TDelValueParams del_param, ref string strErr, ref int nRows) {
			bool fDel = false;
			string strWhere="";

			try {
				nRows = 0;
				strWhere = GetSqlWhere (del_param);
				cmd.CommandText = System.String.Format ("delete from {0} where ({1}={2}) and ({3});",
									Table, FldPointID,idPoint, strWhere);
				nRows = cmd.ExecuteNonQuery ();
				fDel = true;
			}
			catch (Exception ex) {
				strErr = "Error deleting records\n" + ex.Message;
				fDel = false;
			}
			return (fDel);
		}
//----------------------------------------------------------------------------
		public static string GetSqlDateString (DateTime? dt) {
			string str="";
			if (dt != null)
				str = dt.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
			return (str);
		}
//----------------------------------------------------------------------------
		public static new bool LoadRadiationCount (SqlCommand cmd, DateTime? dtFrom, DateTime? dtUntil, int idPoint, ref int nCount, ref string strErr) {
			bool fCount = false;
			SqlDataReader reader = null;
			string strCount = "count";

			try {
				cmd.CommandText = System.String.Format ("select count(*) as '{1}' from {0} where {2} >= {3} and {2} <= {4};",
									Table, strCount, FldTime, TMisc.GetSqlString (dtFrom), TMisc.GetSqlString (dtUntil));
				reader = cmd.ExecuteReader ();
				if (reader.Read()) {
					nCount = TMisc.ReadIntField (reader, strCount, ref strErr);
					fCount = true;
				}
			}
			catch (Exception ex) {
				strErr = ex.Message;
			}
			finally {
				if (reader != null)
					reader.Close ();
			}
			return (fCount);
		}
//----------------------------------------------------------------------------
		public static string GetSqlWhere (TDelValueParams del_param) {
			string strWhere="";
			if (del_param.Op == ERadValueOp.RVO_DEL_BY_DATE)
				strWhere = System.String.Format ("{0} between {1} and {2}", FldTime, TMisc.GetSqlString (del_param.From), TMisc.GetSqlString (del_param.Until));
			else {
				string strOp = TDelValueParams.GetOpString (del_param);
				if (strOp.Length > 0)
					strWhere = System.String.Format ("{0} {1} {2}", FldRate, strOp, del_param.Value);
			}
			return (strWhere);
		}
//----------------------------------------------------------------------------
		public new static bool LoadRadiationCount (SqlCommand cmd, TDelValueParams del_param, int idPoint, ref int nCount, ref string strErr) {
			bool fCount = false;
			SqlDataReader reader = null;
			string strCount = "count";

			try {
				string strWhere = GetSqlWhere (del_param);
				cmd.CommandText = System.String.Format ("select count(*) as '{0}' from {1} where ({2}={3}) and ({4});",
									strCount, Table, FldPointID,idPoint, strWhere);
				reader = cmd.ExecuteReader ();
				if (reader.Read()) {
					nCount = TMisc.ReadIntField (reader, strCount, ref strErr);
					fCount = true;
				}
			}
			catch (Exception ex) {
				strErr = ex.Message;
			}
			finally {
				if (reader != null)
					reader.Close ();
			}
			return (fCount);
		}
//----------------------------------------------------------------------------
		public static bool LoadRateHistogram (SqlConnection database, int idPoint, TUintHistogram hist, ref string strErr) {
			bool fCount = false;
			SqlDataReader reader = null;
			string strCount = "count";

			try {
				SqlCommand cmd = database.CreateCommand ();
				hist.Clear ();
				//string strWhere = GetSqlWhere (del_param);
				cmd.CommandText = System.String.Format ("select {0},count({0}) as '{1}' from {2} where ({4}={3}) group by {0} order by {0};",
												FldRate, strCount, Table, FldPointID, idPoint);
				//cmd.CommandText = System.String.Format ("select count(*) as '{0}' from {1} where ({2}={3}) and ({4});",
									//strCount, Table, FldPointID,idPoint, strWhere);
				reader = cmd.ExecuteReader ();
				while (reader.Read()) {
					uint uiCount = TMisc.ReadUIntField (reader, strCount, ref strErr);
					double dValue = TMisc.ReadFloatField (reader, FldRate, ref strErr);
					hist.Add (uiCount, dValue);
				}
				fCount = true;
			}
			catch (Exception ex) {
				strErr = ex.Message;
			}
			finally {
				if (reader != null)
					reader.Close ();
			}
			return (fCount);
		}
//----------------------------------------------------------------------------
		public static new bool InsertToDB (SqlConnection database, int idPoint, TRadValue[] aRad, ref uint nRows, ref string strErr) {
			bool fInsert=false;

			try {
				if (aRad != null) {
					SqlCommand cmd = database.CreateCommand();
					DateTime? dtStart=null, dtEnd=null;
					nRows = 0;
					string strValues="", str;
					GetStartEnd (aRad, ref dtStart, ref dtEnd);
					if ((fInsert = DeleteBetweenDates (database, idPoint, dtStart, dtEnd, ref strErr)) == true) {
						string strSqlBase = System.String.Format ("insert into {0} ({1},{2},{3},{4}) values ",
												Table, FldPointID, FldRate, FldDose, FldTime);
						for (int n=0 ; n < aRad.Length ; n++) {
							str = System.String.Format ("({0},{1},{2},{3})",idPoint, aRad[n].Rate, aRad[n].Dose,
													TMisc.GetSqlString (aRad[n].SampleTime));
							strValues += str;
							if ((n+1) % 100 == 0) {
								cmd.CommandText = System.String.Format ("{0} {1};", strSqlBase, strValues);
								nRows += (uint) cmd.ExecuteNonQuery();
								strValues = "";
							}
							else
								strValues += ",";
						}
						fInsert = true;
					}
				}
			}
			catch (Exception ex) {
				strErr = ex.Message;
				fInsert = false;
			}
			return (fInsert);
		}
//----------------------------------------------------------------------------
		public static bool DeleteBetweenDates (SqlConnection database, int idPoint, DateTime? dtStart, DateTime? dtEnd, ref string strErr) {
			bool fDel=false;
			int nRows;

			try {
				if ((dtStart != null) && (dtEnd != null)) {
					SqlCommand cmd = database.CreateCommand();
					cmd.CommandText = System.String.Format ("delete from {0} where ({1}={2}) and ({3} between {4} and {5});",
												Table, FldPointID, idPoint, FldTime, TMisc.GetSqlString (dtStart), TMisc.GetSqlString (dtEnd));
					nRows = cmd.ExecuteNonQuery();
					fDel = true;
				}
			}
			catch (Exception ex) {
				strErr = ex.Message;
				fDel = false;
			}
			return (fDel);
		}
//----------------------------------------------------------------------------
	}
//----------------------------------------------------------------------------
//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//----------------------------------------------------------------------------
	public class TRadValueCompare : IComparer {
		public int Compare (object x, object y) {
			TRadValue rv1 = (TRadValue)x;
			TRadValue rv2 = (TRadValue)y;
			int nComapare = rv1.SampleTime < rv2.SampleTime ? 1 : 0;
			return (nComapare);
		}
	}
}
