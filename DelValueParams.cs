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
	public enum EDelValueOp {DVO_NONE, DVO_LT, DVO_EQ, DVO_GT, DVO_BY_DATE};
	public class TDelValueParams {
		private double m_dValue;
		private EDelValueOp m_op;
		private DateTime? m_dtFrom;
		private DateTime? m_dtUntil;
//-----------------------------------------------------------------------------
		public double Value {get{return (m_dValue);}set{m_dValue=value;}}
		public EDelValueOp Op {get{return (m_op);}set{m_op=value;}}
		public DateTime? From  {get{return (m_dtFrom);}set{m_dtFrom=value;}}
		public DateTime? Until {get{return (m_dtUntil);}set{m_dtUntil=value;}}
//-----------------------------------------------------------------------------
		public TDelValueParams () {
			Clear ();
		}
//-----------------------------------------------------------------------------
		public TDelValueParams (TDelValueParams other) {
			AssignAll (other);
		}
//-----------------------------------------------------------------------------
		public void Clear () {
			Value = 0;
			Op    = EDelValueOp.DVO_NONE;
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
			Op = EDelValueOp.DVO_BY_DATE;
			From = dtFrom;
			Until= dtUntil;
			return (From > Until);
		}
//-----------------------------------------------------------------------------
		public bool Upload (bool fLt, bool fEq, bool fGt, string strValue) {
			Value = TMisc.ToDoubleDef (strValue);
			if (fLt)
				Op = EDelValueOp.DVO_LT;
			else if (fEq)
				Op = EDelValueOp.DVO_EQ;
			else if (fGt)
				Op = EDelValueOp.DVO_GT;
			else
				Op = EDelValueOp.DVO_NONE;
			return (Op != EDelValueOp.DVO_NONE);
		}
//-----------------------------------------------------------------------------
		public bool IsValid() {
			bool fValid = false;

			if (Op == EDelValueOp.DVO_BY_DATE) {
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
				if ((Op == EDelValueOp.DVO_LT) || (Op == EDelValueOp.DVO_EQ) || (Op == EDelValueOp.DVO_GT))
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
	}
}
