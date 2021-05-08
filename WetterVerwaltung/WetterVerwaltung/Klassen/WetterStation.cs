using System;
using System.Collections.Generic;
using System.Text;

namespace WetterVerwaltung
{
    class WetterStation
    {
        internal List<WetterMessung> messungslist = new List<WetterMessung>();

        private int s_ID;

        public int S_ID
        {
            get { return s_ID; }
            set { s_ID = value; }
        }
        private string standort;

        public string Standort
        {
            get { return standort; }
            set { standort = value; }
        }
        private string betreiber;

        public string Betreiber
        {
            get { return betreiber; }
            set { betreiber = value; }
        }
        public WetterStation()
        {

        }
        public WetterStation(int S_ID, string Standort, string Betreiber)
        {
            this.S_ID = S_ID;
            this.Standort = Standort;
            this.Betreiber = Betreiber;
        }
    }
}
