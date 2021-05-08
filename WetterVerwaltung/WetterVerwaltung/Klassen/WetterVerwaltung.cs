using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using Microsoft.Win32;



namespace WetterVerwaltung.Klassen
{
    class WetterVerwaltung
    {
        private DB_Connection dbc = new DB_Connection();
        internal List<WetterStation> stationslist = new List<WetterStation>();
        // fill data to list
        public WetterVerwaltung() 
        {
            for (int i = 0; i < 20; i++)
            {
                WetterStation w = new WetterStation(i, $"A{i}", $"B{i}");
                w.messungslist.Add(new WetterMessung(i, $"10:{i}:00", i));
                stationslist.Add(w);
               // FEHLER -> stationslist.Add(new WetterStation(i, $"A{i}", $"B{i}").messungslist.Add(new WetterMessung(i, $"2021-03-20 10:{i}:00", i)));
            }
        }
        // crud
        public void create(int S_ID, string Standort, string Betreiber)
        {
            string qry = $"INSERT INTO Wetterstation(S_ID, Standort, Betreiber) VALUES ('{S_ID}', '{Standort}', '{Betreiber}');";
            dbc.SetData(qry);
            stationslist.Add(new WetterStation()
            {
                S_ID = S_ID,
                Standort = Standort,
                Betreiber = Betreiber
            });
        }
        public void readAll()
        {
            string qry = "SELECT * FROM Wetterstation;";
            dbc.GetDataTable(qry);
        }
        // Save to CSV C:\Users\Admin\Desktop\WetterVerwaltung
        public void WriteCSV()
        {
            SaveFileDialog sFD = new SaveFileDialog();
            sFD.Filter = "CSV (*.csv)| *.csv";

            if (sFD.ShowDialog() == true)
            {
                string Filepath = Path.GetFullPath(sFD.FileName);
                using (var writer = new StreamWriter(Filepath))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteHeader<WetterStation>();
                    csv.NextRecord();

                    foreach (var item in stationslist)
                    {
                        csv.WriteRecord(item);
                        csv.NextRecord();
                    }
                    csv.Flush();
                }
            }
        }
    }
}
