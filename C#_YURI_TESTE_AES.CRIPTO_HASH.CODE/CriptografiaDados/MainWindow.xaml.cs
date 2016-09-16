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

namespace CriptografiaDados
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonMD5_Click(object sender, RoutedEventArgs e)
        {
            txtResposta.Text =  Helpers.CriptografiaHash.GetMD5Hash(txtSemCript.Text);
        }

        private void buttonSHA1_Click(object sender, RoutedEventArgs e)
        {
            txtResposta.Text = Helpers.CriptografiaHash.GerarSHA1_2(txtSemCript.Text);
        }

        private void buttonCriptSim_Click(object sender, RoutedEventArgs e)
        {
            txtCript.Text = Helpers.CriptografiaSimetrica.Encrypt(txtSemCript.Text);
        }

        private void buttonDecriptSim_Click(object sender, RoutedEventArgs e)
        {
            txtSemCript.Text = Helpers.CriptografiaSimetrica.Decrypt(txtCript.Text);
        }

        
        }
    }
}
