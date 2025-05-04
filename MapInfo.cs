/*****************************************************************************\
|                                  WebiGen                                    |
|                                MapInfo.cs                                   |
\*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------------------------------
using System.Collections;
using System.Data;
using Microsoft.Data.SqlClient;
using OmerEisCommon;
//-----------------------------------------------------------------------------
namespace WebiGen {
//-----------------------------------------------------------------------------
	public class TMapInfo {
		private int m_nID;
		private string m_strName;
		private string m_strFile;
//-----------------------------------------------------------------------------
		public int ID {get {return (m_nID);}set{m_nID=value;}}
		public string Name {get {return (m_strName);}set{m_strName=value;}}
		public string File {get {return (m_strFile);}set{m_strFile=value;}}
//-----------------------------------------------------------------------------
		public TMapInfo () {
			Clear ();
		}
//-----------------------------------------------------------------------------
		public TMapInfo (TMapInfo other) {
			AssignAll (other);
		}
//-----------------------------------------------------------------------------
		protected void Clear () {
			ID = 0;
			Name = "";
			File = "";
		}
//-----------------------------------------------------------------------------
		private void AssignAll (TMapInfo other) {
			ID = other.ID;
			Name = other.Name;
			File = other.File;
		}
//-----------------------------------------------------------------------------
		public static bool LoadMapsFromDB (SqlConnection database, ref TMapInfo[] aMaps, ref string strErr) {
			ArrayList ar = new ArrayList ();
			bool fLoad = TMapInfoDB.LoadMapsFromDB (database, ar, ref strErr);
			if (fLoad) {
				if (ar.Count > 0) {
					aMaps = new TMapInfo[ar.Count];
					for (int n=0 ; n < ar.Count ; n++)
						aMaps[n] = (new TMapInfo ((TMapInfoDB) ar[n]));
				}
				else
					aMaps = null;
			}
			return (fLoad);
		}
//-----------------------------------------------------------------------------
		public override string ToString () {
			return (Name);
		}
//-----------------------------------------------------------------------------
	}
//-----------------------------------------------------------------------------
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//-----------------------------------------------------------------------------
	internal class TMapInfoDB : TMapInfo {
		private static readonly string Table = "dbo.Maps";
		private static readonly string FldID = "MapId";
		private static readonly string FldName = "Name";
		private static readonly string FldFile = "FileName";
//-----------------------------------------------------------------------------
		public TMapInfoDB () : base () {}
//-----------------------------------------------------------------------------
		public TMapInfoDB (TMapInfoDB other) : base (other) {}
//-----------------------------------------------------------------------------
		public static bool LoadMapsFromDB (SqlConnection database, ArrayList arMaps, ref string strErr) {
			bool fLoad=true;
			SqlCommand cmd = database.CreateCommand ();
			SqlDataReader reader = null;

			try {
				arMaps.Clear();
				cmd.CommandText = String.Format("select * from {0} order by {1};", Table, FldName);
				reader = cmd.ExecuteReader ();
				while ((fLoad) && (reader.Read())) {
					TMapInfoDB map = new TMapInfoDB ();
					if ((fLoad = map.LoadFromReader (reader, ref strErr)) == true)
						arMaps.Add (map);
				}
				fLoad = true;
			}
			catch (Exception e) {
				strErr = e.Message;
				fLoad = false;
			}
			finally {
				if (reader != null)
					reader.Close ();
			}
			return (fLoad);
		}
//-----------------------------------------------------------------------------
		private bool LoadFromReader (SqlDataReader reader, ref string strErr) {
			bool fRead = false;

			try {
				Clear ();
				ID = TMisc.ToIntDef (reader[FldID].ToString ());
				Name = TMisc.GetSqlText (reader[FldName].ToString ());
				File = TMisc.GetSqlText (reader[FldFile].ToString ());
				fRead = true;
			}
			catch (Exception ex) {
				strErr = ex.Message;
				fRead = false;
			}
			return (fRead);
		}
	}
}
