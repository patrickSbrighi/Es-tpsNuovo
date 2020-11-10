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

namespace EsTPS
{
    /// <summary>
    /// Logica di interazione per VediCd.xaml
    /// </summary>
    public partial class VediCd : Window
    {
        public VediCd(CD cd)
        {
            InitializeComponent();
            lstBrani.ItemsSource = cd;
            lblAutore.Content = cd.Autore;
            lblTitolo.Content = cd.Titolo;
        }
    }
}
