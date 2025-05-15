/*****************************************************************************\
|                                  WebiGen                                    |
|                                 RadAdd.cs                                   |
\*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------------------------------------
namespace WebiGen {
	public class TRadAdd {
		private DateTime? m_dtStart;
		private DateTime? m_dtEnd;
		private double m_dSampling;
		private double m_dMin;
		private double m_dMax;
		private double m_dAvg;
		private double m_dStdDev;
//----------------------------------------------------------------------------
		public DateTime? Start {get{return(m_dtStart);}set{m_dtStart=value;}}
		public DateTime? End {get{return(m_dtEnd);}set{m_dtEnd=value;}}
		public double SamplingRate {get{return(m_dSampling);}set{m_dSampling=value;}}
		public double Min {get{return(m_dMin);}set{m_dMin=value;}}
		public double Max {get{return(m_dMax);}set{m_dMax=value;}}
		public double Average {get{return(m_dAvg);}set{m_dAvg=value;}}
		public double StdDev {get{return(m_dStdDev);}set{m_dStdDev=value;}}
//----------------------------------------------------------------------------
		public TRadAdd () {
			Clear ();
		}
//----------------------------------------------------------------------------
		public TRadAdd (TRadAdd other) {
			AssignAll (other);
		}
//----------------------------------------------------------------------------
		public void Clear () {
			Start = null;
			End   = null;
			SamplingRate = 0;
			Min = 0;
			Max = 0;
			Average = 0;
			StdDev = 0;
		}
//----------------------------------------------------------------------------
		public void AssignAll (TRadAdd other) {
			Start = other.Start;
			End = other.End;
			SamplingRate = other.SamplingRate;
			Min = other.Min;
			Max = other.Max;
			Average = other.Average;
			StdDev = other.StdDev;
		}
//----------------------------------------------------------------------------
		public bool IsTimesValid() {
			bool fValid = false;

			if ((Start != null) && End != null)
				if (End > Start)
					if (SamplingRate > 0)
						fValid = true;
			return (fValid);
		}
//----------------------------------------------------------------------------
		public bool IsRangeValid() {
			bool fValid = false;

			if (Min < Max)
				if (Average > 0)
					fValid = true;
			return (fValid);
		}
//----------------------------------------------------------------------------
		public bool IsValid() {
			return ((IsTimesValid()) && (IsTimesValid()));
		}
	}
}
