using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace EsTPS
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Brano> _brani;
        private ObservableCollection<CD> _cd;
        public MainWindow()
        {
            InitializeComponent();
            _brani = new ObservableCollection<Brano>();
            _cd = new ObservableCollection<CD>();
        }
        public MainWindow(ObservableCollection<Brano> brani, ObservableCollection<CD> cd)
        {
            InitializeComponent();
            _brani = brani;
            _cd = cd;
        }

        private void btnAddSong_Click(object sender, RoutedEventArgs e)
        {
            CreaBrano crea = new CreaBrano(_brani, _cd);
            crea.Show();
            this.Close();
        }

        private void btnAddCd_Click(object sender, RoutedEventArgs e)
        {
            CreaCd crea = new CreaCd(_brani, _cd);
            crea.Show();
            this.Close();
        }

        private void btnVediCd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CD cd = lstCd.SelectedItem;
                VediCd finestra = new VediCd(cd);
                finestra.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVediBrano_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Brano brano = (Brano) lstBrani.SelectedItem;
                VediBrano finestra = new VediBrano(brano);
                finestra.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
