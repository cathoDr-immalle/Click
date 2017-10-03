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

namespace Click
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Teller = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Knop1_Click(object sender, RoutedEventArgs e)
        {
            Teller = Teller + 1;
            Knop1.Content = Teller;
        }
    }
}
