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

namespace projektDyscypiny
{
    /// <summary>
    /// Interaction logic for TurniejDwaOgnie.xaml
    /// </summary>
    public partial class TurniejDwaOgnie : Page
    {
        public TurniejDwaOgnie()
        {
            InitializeComponent();
        }

        private void WynikiTurniejuClick(object sender, RoutedEventArgs e)
        {
            ((MainWindow)System.Windows.Application.Current.MainWindow).GlowneOkno.Content = new WynikiDwaOgnie();
        }
    }
}
