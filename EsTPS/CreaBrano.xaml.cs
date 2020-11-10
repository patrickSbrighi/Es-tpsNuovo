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
    /// Logica di interazione per CreaBrano.xaml
    /// </summary>
    public partial class CreaBrano : Window
    {
        private ObservableCollection<Brano> _brani;
        private ObservableCollection<CD> _cd;
        public CreaBrano(ObservableCollection<Brano> brani, ObservableCollection<CD> cd)
        {
            InitializeComponent();
            _brani = brani;
            _cd = cd;
        }

        private void btnConferma_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Brano brano = new Brano(txtTitolo.Text, txtAutore.Text, float.Parse(txtDurata.Text));
                _brani.Add(brano);
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
