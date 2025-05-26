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
	public enum EDelValueOp {DVO_NONE, DVO_LT, DVO_EQ, DVO_GT};
	public class TDelValueParams {
		private double m_dValue;
		private EDelValueOp m_op;
//-----------------------------------------------------------------------------
		public double Value {get{return (m_dValue);}set{m_dValue=value;}}
		public EDelValueOp Op {get{return (m_op);}set{m_op=value;}}
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
			Op = EDelValueOp.DVO_NONE;
		}
//-----------------------------------------------------------------------------
		private void AssignAll (TDelValueParams other) {
			Value = other.Value;
			Op = other.Op;
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
		public static bool IsValid (bool fLt, bool fEq, bool fGt, string strValue) {
			bool fValid = false;

			if ((fValid = TMisc.IsValidDouble (strValue)) == true)
				fValid = fLt || fEq || fGt;
			return (fValid);
		}
	}
}
