using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;                                         /*******************************/
using System.Windows.Controls;                                /************  Maycol  *********/
using System.Windows.Data;                                    /************  Torres  *********/
using System.Windows.Documents;                               /*******************************/
using System.Windows.Input;                                  
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cartas
{

    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        Random r = new Random();
        int n, respuesta;
        string[] lista = new string[54];
        int[] indice = new int[54];

        public int pozo1;
        public int pozo2;
        public int v1;
        public int v2;
        public int juego;
        

        public MainWindow(int a, int b, int c) /********** VARIABLE C DETERMINA SI JUEGA VS PERSONA O PC *********/
        {
            InitializeComponent();
            barajarMazo1();
            sacarCarta.IsEnabled = false;

            juego = c;
            pozo1=a;
            pozo2=b;
            labelganancia1.Content = pozo1;
            labelganancia2.Content = pozo2;
            if (juego == 2)
            {
                apuesta2.IsEnabled = false;
                labelApuestajugador2.Content = "Apuesta Computador";
            }
        }

        /********************************************************************PRINCIPALES FUNCIONES*******************************************************************/

        //Funcion para buscar el elemento repetido en el arreglo
        public int buscar(int [] indice, int n){
            for (int i = 0; i < 54; i++)
            {
                if (indice[i] == n)
                    return 1;  
            }
            return 0;          
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

        //Ingresar cartas al mazo
        public void barajarMazo1() //Barajar el primer mazo
        {
            /************************************  LLENAR LISTA CON LAS CARTAS  *****************************************/
            lista[0] = "2T";   lista[1] = "2D";   lista[2] = "2P";   lista[3] = "2C";
            lista[4] = "3T";   lista[5] = "3D";   lista[6] = "3P";   lista[7] = "3C";
            lista[8] = "4T";   lista[9] = "4D";   lista[10] = "4P";  lista[11] = "4C";
            lista[12] = "5T";  lista[13] = "5D";  lista[14] = "5P";  lista[15] = "5C";
            lista[16] = "6T";  lista[17] = "6D";  lista[18] = "6P";  lista[19] = "6C";
            lista[20] = "7T";  lista[21] = "7D";  lista[22] = "7P";  lista[23] = "7C";
            lista[24] = "8T";  lista[25] = "8D";  lista[26] = "8P";  lista[27] = "8C";
            lista[28] = "9T";  lista[29] = "9D";  lista[30] = "9P";  lista[31] = "9C";
            lista[32] = "10T"; lista[33] = "10D"; lista[34] = "10P"; lista[35] = "10C";
            lista[36] = "JT";  lista[37] = "JD";  lista[38] = "JP";  lista[39] = "JC";
            lista[40] = "QT";  lista[41] = "QD";  lista[42] = "QP";  lista[43] = "QC";
            lista[44] = "KT";  lista[45] = "KD";  lista[46] = "KP";  lista[47] = "KC";
            lista[48] = "C1";  lista[49] = "C2";  lista[50] = "AT";  lista[51] = "AD";
            lista[52] = "AP";  lista[53] = "AC";


            //LLenar arreglo con -1
            for (int i = 0; i < 54; i++)
            {
                indice[i] = -1;
            }
            //Generar valores alterorios de indice sin repetir
            for (int i = 0; i < 54; i++)
            {

                n = r.Next(0, 54);
                respuesta = buscar(indice, n);
                if (respuesta == 1)
                    i--;
                else
                    indice[i] = n;

            }
        }


        /******************************************************************** FIN PRINCIPALES FUNCIONES *******************************************************************/




        /****************************************************************************** BOTONES ************************************************************************/
        
        public int valor = 0, i=-1;
        
        private void Button_Click_1(object sender, RoutedEventArgs e)  //BOTON PARA SACAR CARTAS
        {
            apuesta1.Text="";
            apuesta2.Text = "";
            botonConfirmarApuesta.IsEnabled = true;
            sacarCarta.IsEnabled = false;
            confirmar.Content = "Ingrese apuestas para comenzar";
            i++;
            if (valor< 54)
            {
                //indice[0] = 48;
                //indice[1] = 49;
                //Mostrar en mazo 1            
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri("D:/Inacap/2 año/Taller de progra III/WPF/Cartas/" + lista[indice[valor]] + ".png");
                bi3.EndInit();        
                mazo1.Stretch = Stretch.Fill;
                mazo1.Source = bi3;

               /////////////////////////////// //comprobar la carta mayor///////////////////////////////////////
                if (indice[valor] == 48 && indice[valor + 1] == 49)
                {
                    anuncio.Foreground = Brushes.Black;
                    anuncio.Content = "EMPATE";
                    pozo1 = pozo1 + v1;
                    pozo2 = pozo2 + v2;
                    labelganancia1.Content = pozo1;
                    labelganancia2.Content = pozo2;
                }

                else if (indice[valor] > indice[valor + 1])
                {
                    anuncio.Foreground = Brushes.Blue;
                    anuncio.Content = "Gana Jugador 1";
                    pozo1 = pozo1 + v1 + v2;
                    labelganancia1.Content = pozo1;
                    //v1 = 0;
                }
                else
                {
                    anuncio.Foreground = Brushes.Red;
                    anuncio.Content = "Gana Jugador 2 ";
                    pozo2 = pozo2 + v1 + v2;
                    labelganancia2.Content = pozo2;
                    //v2 = 0;
                }
                /////////////////////////////// //FIN comprobar la carta mayor///////////////////////////////////////
                valor++;
                //Mostrar en mazo 2
                BitmapImage bi4 = new BitmapImage();
                bi4.BeginInit();
                bi4.UriSource = new Uri("D:/Inacap/2 año/Taller de progra III/WPF/Cartas/" + lista[indice[valor]] + ".png");
                bi4.EndInit();
                mazo2.Stretch = Stretch.Fill;
                mazo2.Source = bi4;

                if (i == 0)
                {
                    //Mostrar basura
                    BitmapImage bi5 = new BitmapImage();
                    bi5.BeginInit();
                    bi5.UriSource = new Uri("D:/Inacap/2 año/Taller de progra III/WPF/Cartas/dorso2.png");
                    bi5.EndInit();
                    basura.Stretch = Stretch.Fill;
                    basura.Source = bi5;
                }
                if (i == 1)
                {
                    //Mostrar basura1
                    BitmapImage bi6 = new BitmapImage();
                    bi6.BeginInit();
                    bi6.UriSource = new Uri("D:/Inacap/2 año/Taller de progra III/WPF/Cartas/dorso2.png");
                    bi6.EndInit();
                    basura1.Stretch = Stretch.Fill;
                    basura1.Source = bi6;
                }
                if (i == 2)
                {

                    //Mostrar basura2
                    BitmapImage bi7 = new BitmapImage();
                    bi7.BeginInit();
                    bi7.UriSource = new Uri("D:/Inacap/2 año/Taller de progra III/WPF/Cartas/dorso2.png");
                    bi7.EndInit();
                    basura2.Stretch = Stretch.Fill;
                    basura2.Source = bi7;
                }
                if (i == 3)
                {

                    //Mostrar basura3
                    BitmapImage bi8 = new BitmapImage();
                    bi8.BeginInit();
                    bi8.UriSource = new Uri("D:/Inacap/2 año/Taller de progra III/WPF/Cartas/dorso2.png");
                    bi8.EndInit();
                    basura3.Stretch = Stretch.Fill;
                    basura3.Source = bi8;
                }

                valor++;
            }
            else
                MessageBox.Show("Se acabaron las cartas");
            
            
        }
    

        private void Button_Click_2(object sender, RoutedEventArgs e) //BOTON CONFIRMAR APUESTA
        {
            if(juego ==2){ //Si un jugador esta jugando vs el compu
                if (apuesta1.Text.Equals("") || (!EsNumero(apuesta1.Text)))
                    MessageBox.Show("Complete los campos de apuesta para comenzar");
                else
                {
                    v1 = Convert.ToInt32(apuesta1.Text);
                    v2 = v1 + (v1 / 4);
                    apuesta2.Text = v2.ToString();
                }
            }

            //si los valores ingresados no son numericos muestro mensaje 
            if (!EsNumero(apuesta1.Text) || (!EsNumero(apuesta2.Text)))
            {
                MessageBox.Show("Debe Ingresar Valores Numericos");
                apuesta1.Text = "";
                apuesta2.Text = "";
                apuesta1.Focus();
            }
            else
            {
                confirmar.Content = "";


                if (apuesta1.Text.Equals("") || apuesta2.Text.Equals(""))
                    MessageBox.Show("Complete los campos de apuesta para comenzar");
                else
                {
                    if (juego == 1) //Si estan jugando 2 jugadores
                    {
                        v1 = Convert.ToInt32(apuesta1.Text);
                        v2 = Convert.ToInt32(apuesta2.Text);
                    }

                    if (v1 > pozo1 || v2 > pozo2)
                    {
                        MessageBox.Show("El monto para apostar supera el pozo");
                        apuesta1.Text = "";
                        apuesta2.Text = "";

                    }
                    else
                    {
                        if (v1 <= pozo1 && v2 <= pozo2)
                        {
                            pozo1 = pozo1 - v1;
                            pozo2 = pozo2 - v2;
                            labelganancia1.Content = pozo1;
                            labelganancia2.Content = pozo2;
                            botonConfirmarApuesta.IsEnabled = false;
                            sacarCarta.IsEnabled = true;
                        }

                    }
                }


            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //BOTON CERRAR JUEGO
        {
            Login l = new Login();
            l.Show();
            this.Close();

        }

        
    }
}
   


