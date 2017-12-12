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
        string In = "";
        string c = "";
        int vidas = 5;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_In_Click(object sender, RoutedEventArgs e)
        {
            In = txt_In.Text;
            txt_In.Clear();
            for(int i = 0; i < In.Length; i++)
            {
                if (In[i] != ' ')
                    c = c + "*";

                else
                    c = c + " ";
            }

            txt_Vidas.Text = Convert.ToString(vidas);
            txt_In.Text = string.Empty;
            txt_string.Text = c;
        }

        private void verificarLetra(char letra)
        {
            int test = 0;
            int i = 0;
            char[] x = new char[c.Length];
            x = c.ToCharArray(0, c.Length);
            while (i < In.Length)
            {
                if (char.ToUpper(In[i]) == letra)
                {
                    x[i] = letra;
                    test = 1;
                }
                i++;
            }
            c = new string(x);

            if (test == 0)
                vidas--;

            txt_Vidas.Text = vidas.ToString();
            txt_string.Text = c;
        }
       
       //-----------------------------------------------------------------------------------------------------------------------------------------
        private void btn_A_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('A');
            btn_A.IsEnabled = false;
        }

        private void btn_B_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('B');
            btn_A.IsEnabled = false;
        }

        private void btn_C_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('C');
            btn_A.IsEnabled = false;
        }

        private void btn_D_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('D');
            btn_A.IsEnabled = false;
        }

        private void btn_E_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('E');
            btn_A.IsEnabled = false;
        }

        private void btn_F_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('F');
            btn_A.IsEnabled = false;
        }

        private void btn_G_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('G');
            btn_A.IsEnabled = false;
        }

        private void btn_H_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('H');
            btn_A.IsEnabled = false;
        }

        private void btn_I_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('I');
            btn_A.IsEnabled = false;
        }

        private void btn_J_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('J');
            btn_A.IsEnabled = false;
        }

        private void btn_K_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('K');
            btn_A.IsEnabled = false;
        }

        private void btn_L_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('L');
            btn_A.IsEnabled = false;
        }

        private void btn_M_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('M');
            btn_A.IsEnabled = false;
        }

        private void btn_N_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('N');
            btn_A.IsEnabled = false;
        }

        private void btn_O_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('O');
            btn_A.IsEnabled = false;
        }

        private void btn_P_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('P');
            btn_A.IsEnabled = false;
        }

        private void btn_Q_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('Q');
            btn_A.IsEnabled = false;
        }

        private void btn_R_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('R');
            btn_A.IsEnabled = false;
        }

        private void btn_S_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('S');
            btn_A.IsEnabled = false;
        }

        private void btn_T_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('T');
            btn_A.IsEnabled = false;
        }

        private void btn_U_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('U');
            btn_A.IsEnabled = false;
        }

        private void btn_V_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('V');
            btn_A.IsEnabled = false;
        }

        private void btn_W_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('W');
            btn_A.IsEnabled = false;
        }

        private void btn_X_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('X');
            btn_A.IsEnabled = false;
        }

        private void btn_Y_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('Y');
            btn_A.IsEnabled = false;
        }

        private void btn_Z_Click(object sender, RoutedEventArgs e)
        {
            verificarLetra('Z');
            btn_A.IsEnabled = false;
        }

        

        
    }
}
