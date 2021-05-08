using System;
using System.Collections.Generic;
using System.Text;

namespace WetterVerwaltung
{
    class WetterMessung
    {
        private int stations_ID;

        public int Stations_ID
        {
            get { return stations_ID; }
            set { stations_ID = value; }
        }
        private string datum;

        public string Datum
        {
            get { return datum; }
            set { datum = value; }
        }
        private double min_5cm;

        public double Min_5cm
        {
            get { return min_5cm; }
            set { min_5cm = value; }
        }
        public WetterMessung()
        {

        }
        public WetterMessung(int Stations_ID, string Datum, double Min_5cm)
        {
            this.Stations_ID = Stations_ID;
            this.Datum = Datum;
            this.Min_5cm = Min_5cm;
        }
    }
}
