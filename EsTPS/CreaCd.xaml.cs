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
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace EsTPS
{
    /// <summary>
    /// Logica di interazione per CreaCd.xaml
    /// </summary>
    public partial class CreaCd : Window
    {
        private ObservableCollection<Brano> _brani;
        private ObservableCollection<CD> _cd;
        private ObservableCollection<Brano> _braniCd;
        public CreaCd(ObservableCollection<Brano> brani, ObservableCollection<CD> cd)
        {
            InitializeComponent();
            _brani = brani;
            _cd = cd;
            _braniCd = new ObservableCollection<Brano>();
            RiempiLst();
        }

        private void RiempiLst()
        {
            lstBraniCd.ItemsSource = _braniCd;
            lstBraniTot.ItemsSource = _brani;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Brano brano = (Brano)lstBraniTot.SelectedItem;
                _brani.Remove(brano);
                _braniCd.Add(brano);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Brano brano = (Brano)lstBraniCd.SelectedItem;
                _braniCd.Remove(brano);
                _brani.Add(brano);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConferma_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CD cd = new CD(txtTitolo.Text, txtAutore.Text, _braniCd);
                _cd.Add(cd);
                MainWindow main = new MainWindow(_brani, _cd);
                main.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
