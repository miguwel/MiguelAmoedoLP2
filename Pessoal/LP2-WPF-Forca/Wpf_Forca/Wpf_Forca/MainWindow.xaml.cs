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

namespace Wpf_Forca
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string chave = "";
        string c = "";
        int vidas = 5;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_In_Click(object sender, RoutedEventArgs e)
        {
            chave = txt_In.Text;
            txt_In.Clear();
            for(int i = 0; i < chave.Length; i++)
            {
                if (chave[i] != ' ')
                    c = c + "*";

                else
                    c = c + " ";
            }

            txt_In.Text = c;
            txt_vidas.Text = string.Format("Tens mais {0} tentativas", vidas);
        }

        private void btn_A_Click(object sender, RoutedEventArgs e)
        {
            int test = 0;
            int i = 0;
            char[] x = new char[c.Length];
            x = c.ToCharArray(0, c.Length);
            while (i < chave.Length)
            {
                if (chave[i] == 'a' || chave[i] == 'A')
                {
                    x[i] = 'A';
                    test = 1;
                }
            }
            c = x.ToString();

            if (test == 0)
                vidas--;

            txt_In.Text = c;
        }

        private void btn_B_Click(object sender, RoutedEventArgs e)
        {
            int test = 0;
            int i = 0;
            char[] x = new char[c.Length];
            x = c.ToCharArray(0,c.Length);
            while (i < chave.Length)
            {
                if (chave[i] == 'b' || chave[i] == 'B')
                {
                    x[i] = 'B';
                    test = 1;
                }
            }
            c = x.ToString();

            if (test == 0)
                vidas--;

            txt_In.Text = c;
        }
    }
}
