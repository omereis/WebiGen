/*****************************************************************************\
|                                  WebiGen                                    |
|                                 RadAdd.cs                                   |
\*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------------------------------------
namespace WebiGen {
	public class TRadAdd {
		private DateTime? m_dtStart;
		private DateTime? m_dtEnd;
		private uint m_dtDoseReset;
		private double m_dSampling;
		private double m_dMin;
		private double m_dMax;
		private double m_dAvg;
		private double m_dStdDev;
//----------------------------------------------------------------------------
		public DateTime? Start {get{return(m_dtStart);}set{m_dtStart=value;}}
		public DateTime? End {get{return(m_dtEnd);}set{m_dtEnd=value;}}
		public uint DoseReset {get{return(m_dtDoseReset);}set{m_dtDoseReset=value;}}
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
			Start        = null;
			End          = null;
			DoseReset    = 0;
			SamplingRate = 0;
			Min          = 0;
			Max          = 0;
			Average      = 0;
			StdDev       = 0;
		}
//----------------------------------------------------------------------------
		public void AssignAll (TRadAdd other) {
			Start = other.Start;
			End = other.End;
			DoseReset    = other.DoseReset;
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
			return ((IsRangeValid()) && (IsTimesValid()));
		}
//----------------------------------------------------------------------------
		public int CountByDates () {
			int nCount;

			try {
				TimeSpan ts = End.Value - Start.Value;
				nCount = (int) ((ts.TotalSeconds / SamplingRate) + 0.5);
			}
			catch (Exception ex) {
				Console.WriteLine (ex.Message);
				nCount = -1;
			}
			return  (nCount);
		}
//----------------------------------------------------------------------------
		public static void GetRandBetweem (ref double[] aValues, int nCount, double dMin, double dMax) {
			Random rand = new Random ();
			double dRandMin, dRandMax;
			aValues = new double [nCount];
			aValues[0] = dRandMin = dRandMax = rand.NextDouble ();
			for (int n=1 ; n < aValues.Length; n++) {
				aValues[n] = rand.NextDouble ();
				if (dRandMin > aValues[n])
					dRandMin = aValues[n];
				if (dRandMax < aValues[n])
					dRandMax = aValues[n];
			}
			for (int n=0 ; n < aValues.Length; n++)
				aValues[n] = aValues[n] - dRandMin;
			for (int n=0 ; n < aValues.Length; n++)
				aValues[n] = aValues[n] / dRandMax;
			for (int n=0 ; n < aValues.Length; n++)
				aValues[n] = aValues[n] * (dMax - dMin) + dMin;
			
		}
//----------------------------------------------------------------------------
		public bool Generate (TPointInfo pt, ref TRadValue[] aRad) {
			int nCount = CountByDates ();

			if (nCount > 0) {
				//TimeSpan ts;
				double[] aValues = null;
				GetRandBetweem (ref aValues, nCount, Min, Max);
				if (aValues != null) {
					aRad = new TRadValue[nCount];
					DateTime dt = Start.Value;
					double dDose = 0;
					for (int n=0 ; n < nCount ; n++) {
						aRad[n] = new TRadValue();
						aRad[n].SampleTime = dt;
						aRad[n].PointID = pt.PointID;
						aRad[n].Rate = (float) aValues[n];
						//ts = aRad[n].SampleTime.Value - Start.Value;
						if ((aRad[n].SampleTime.Value - Start.Value).TotalHours > DoseReset)
						//if (ts.TotalHours > DoseReset)
							dDose = 0;
						else
							dDose += aValues[n];
						aRad[n].Dose = (float) dDose;
						dt = dt.AddSeconds (SamplingRate);
					}
				}

			}
			else
				aRad = null;
			return (nCount > 0);
		}
	}
}
