using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ScottPlot;
using Microsoft.Win32;
using color = System.Drawing.Color;
using WetterVerwaltung.Klassen;

namespace WetterVerwaltung
{
    /// <summary>
    /// Interaktionslogik für ScottPlotView.xaml
    /// </summary>
    public partial class ScottPlotView : Window
    {
        IO_Controller ioc = new IO_Controller();

        public ScottPlotView(IO_Controller ioc,int index)
        {
            InitializeComponent();
            this.ioc = ioc;
            ShowGraph(index);
        }
        public void ShowGraph(int index)
        {
            double[] x = new double[ioc.wv.stationslist[index].messungslist.Count];
            double[] y = new double[ioc.wv.stationslist[index].messungslist.Count];
            for (int i = 0; i < ioc.wv.stationslist[index].messungslist.Count; i++)
            {
                x[i] = Convert.ToDouble(ioc.wv.stationslist[index].messungslist[i].Datum.Replace(":", "."));
                y[i] = ioc.wv.stationslist[index].messungslist[i].Min_5cm;
            }
            Plot1.plt.PlotScatter(x, y, color.Pink);
            Plot1.plt.Grid(lineStyle: LineStyle.Dot);
            Plot1.plt.Legend();
            Plot1.Render();
        }

        private void BTN_Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sFD = new SaveFileDialog();
            sFD.Filter = "Images (.png) | *.png;";
            if (true)
            {
                Plot1.plt.SaveFig(sFD.FileName);
            }

        }
    }
}
