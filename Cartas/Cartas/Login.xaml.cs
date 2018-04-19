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

namespace Cartas
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        public Login()
        {
            InitializeComponent();
        }

        //metodo para validar si los valores son numericos
        private bool EsNumero(string numero)
        {
            try
            {
                int x = Convert.ToInt32(numero);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //si los valores ingresados no son numericos muestro mensaje con errorprovider
            if (!EsNumero(pozo1.Text) || (!EsNumero(pozo2.Text)))
            {
                MessageBox.Show("Debe Ingresar Valores Numericos");
                pozo1.Text = "";
                pozo2.Text = "";
                pozo1.Focus();
            }
            else
            {
                int a = (Convert.ToInt32(pozo1.Text));
                int b = (Convert.ToInt32(pozo2.Text));
                int juego = 1;
                MainWindow m = new MainWindow(a, b, juego);
                m.Show();
                this.Close();
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //si los valores ingresados no son numericos muestro mensaje con errorprovider
            if (!EsNumero(pozo3.Text))
            {
                MessageBox.Show("Debe Ingresar Valores Numericos");
                pozo3.Text = "";
                pozo3.Focus();
            }
            else
            {
                int a = (Convert.ToInt32(pozo3.Text)); 
                int b = (Convert.ToInt32(pozo3.Text));
                int juego = 2;
                MainWindow m = new MainWindow(a, b,juego);
                m.Show();
                this.Close();
            }
        }
    }
}
