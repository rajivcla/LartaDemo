using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LartaDemo
{
    public class WeatherItem : DifferenceItem
    {
        public int MxT { get; set; }
        public int MnT { get; set; }
        public int AvT { get; set; }
        public int HDDay { get; set; }
        public double AvDP { get; set; }
        public int lHrP { get; set; }
        public double TPcpn { get; set; }
        public string WxType { get; set; }
        public int PDir { get; set; }
        public double AvSp { get; set; }
        public int Dir { get; set; }
        public int MxS { get; set; }
        public double SkyC { get; set; }
        public int MxR { get; set; }
        public int MnR { get; set; }
        public double AvSLP { get; set; }

        public WeatherItem(params string[] s) : base()
        {
            Name = s[0];
            Int32.TryParse(s[1].Replace("*", string.Empty), out int mxT); // min / max value stored with * so remove it
            MxT = mxT;
            Int32.TryParse(s[2].Replace("*",string.Empty), out int mnT);
            MnT = mnT;
            Int32.TryParse(s[3], out int avT);
            AvT = avT;
            Int32.TryParse(s[4], out int hDDay);
            HDDay = hDDay;
            double.TryParse(s[5], out double avDP);
            AvDP = avDP;
            Int32.TryParse(s[6], out int lhrP);
            lHrP = lhrP;
            Double.TryParse(s[7], out double tPcpn);
            TPcpn = tPcpn;
            s[8] = WxType;
            Int32.TryParse(s[9], out int pDir);
            PDir = pDir;
            double.TryParse(s[10], out double avSp);
            AvSp = avSp;
            Int32.TryParse(s[11], out int dir);
            Dir = dir;
            Int32.TryParse(s[12].Replace("*", string.Empty), out int mxS);
            MxS = mxS;
            double.TryParse(s[13], out double skyC);
            SkyC = skyC;
            Int32.TryParse(s[14], out int mxR);
            MxR = mxR;
            Int32.TryParse(s[15], out int mnR);
            MnR = mnR;
            double.TryParse(s[16], out double avSLP);
            AvSLP = avSLP;

            Difference = MxT - MnT;
        }

        //public override string DisplayText()
        //{
        //    return $"Day #{Name} had the smallest difference of {Difference} degrees between max & min temperature";
        //}

        public WeatherItem() { }

    }
}
