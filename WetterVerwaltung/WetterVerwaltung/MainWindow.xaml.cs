using System.Windows;
using System.Windows.Controls;
using WetterVerwaltung.Klassen;

namespace WetterVerwaltung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        IO_Controller ioc = new IO_Controller();
        int DataGridIndex;

        public MainWindow()
        {
            InitializeComponent();
            FillDataGrid();
        }

        public void FillDataGrid()
        {
            Grid1.ItemsSource = ioc.wv.stationslist;
        }

        private void BTN_RELOAD_Click(object sender, RoutedEventArgs e)
        {
        }

        private void BTN_GRAPH_Click(object sender, RoutedEventArgs e)
        {
            ScottPlotView sPV = new ScottPlotView(ioc, DataGridIndex);
            sPV.Show();
            this.Close();
        }

        private void BTN_SAVE_Click(object sender, RoutedEventArgs e)
        {
            ioc.wv.WriteCSV();
        }

        private void BTN_DBSAVE_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in ioc.wv.stationslist)
            {
                ioc.wv.create(item.S_ID, item.Standort, item.Betreiber);
            }
        }

        public void Grid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGridIndex = Grid1.SelectedIndex;
            DebugIndex.Content = DataGridIndex;
        }
    }
}
