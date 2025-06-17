/*****************************************************************************\
|                                  WebiGen                                    |
|                             DelValueParams.cs                               |
\*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------------------------------
using OmerEisCommon;
//-----------------------------------------------------------------------------
namespace WebiGen {
	public enum ERadValueOp {RVO_NONE, RVO_DEL_LT, RVO_DEL_EQ, RVO_DEL_GT, RVO_DEL_BY_DATE, RVO_INSERT};
	public class TDelValueParams {
		private double m_dValue;
		private ERadValueOp m_op;
		private DateTime? m_dtFrom;
		private DateTime? m_dtUntil;
//-----------------------------------------------------------------------------
		public double Value {get{return (m_dValue);}set{m_dValue=value;}}
		public ERadValueOp Op {get{return (m_op);}set{m_op=value;}}
		public DateTime? From  {get{return (m_dtFrom);}set{m_dtFrom=value;}}
		public DateTime? Until {get{return (m_dtUntil);}set{m_dtUntil=value;}}
//-----------------------------------------------------------------------------
		public TDelValueParams () {
			Clear ();
		}
//-----------------------------------------------------------------------------
		public TDelValueParams (ERadValueOp op) {
			Clear ();
			Op = op;
		}
//-----------------------------------------------------------------------------
		public TDelValueParams (TDelValueParams other) {
			AssignAll (other);
		}
//-----------------------------------------------------------------------------
		public void Clear () {
			Value = 0;
			Op    = ERadValueOp.RVO_NONE;
			From  = null;
			Until = null;
		}
//-----------------------------------------------------------------------------
		private void AssignAll (TDelValueParams other) {
			Value = other.Value;
			Op = other.Op;
			From  = other.From;
			Until = other.Until;
		}
//-----------------------------------------------------------------------------
		public bool Upload (DateTime dtFrom, DateTime dtUntil) {
			Op = ERadValueOp.RVO_DEL_BY_DATE;
			From = dtFrom;
			Until= dtUntil;
			return (From > Until);
		}
//-----------------------------------------------------------------------------
		public bool Upload (bool fLt, bool fEq, bool fGt, string strValue) {
			Value = TMisc.ToDoubleDef (strValue);
			if (fLt)
				Op = ERadValueOp.RVO_DEL_LT;
			else if (fEq)
				Op = ERadValueOp.RVO_DEL_EQ;
			else if (fGt)
				Op = ERadValueOp.RVO_DEL_GT;
			else
				Op = ERadValueOp.RVO_NONE;
			return (IsValid() && (Op != ERadValueOp.RVO_NONE));
		}
//-----------------------------------------------------------------------------
		public bool IsValid() {
			bool fValid = false;

			if (Op == ERadValueOp.RVO_DEL_BY_DATE) {
				if ((From != null) & (Until != null)) {
					if (From.Value > Until.Value) {
						DateTime? dt = From.Value;
						From = Until.Value;
						Until = dt.Value;
					}
					fValid = true;
				}
			}
			else {
				if ((Op == ERadValueOp.RVO_DEL_LT) || (Op == ERadValueOp.RVO_DEL_EQ) || (Op == ERadValueOp.RVO_DEL_GT))
					fValid = true;
			}
			return (fValid);
		}
//-----------------------------------------------------------------------------
		public static bool IsValid (bool fLt, bool fEq, bool fGt, string strValue) {
			bool fValid = false;

			if ((fValid = TMisc.IsValidDouble (strValue)) == true)
				fValid = fLt || fEq || fGt;
			return (fValid);
		}
//-----------------------------------------------------------------------------
		public static string GetOpString (TDelValueParams del_param) {
			string strOp;

			if (del_param != null) {
				if (del_param.Op == ERadValueOp.RVO_DEL_LT)
					strOp = "<";
				else if (del_param.Op == ERadValueOp.RVO_DEL_EQ)
					strOp = "=";
				else if (del_param.Op == ERadValueOp.RVO_DEL_GT)
					strOp = ">";
				else
					strOp = "";
			}
			else
				strOp = "";
			return (strOp);
		}
//-----------------------------------------------------------------------------
	}
}
