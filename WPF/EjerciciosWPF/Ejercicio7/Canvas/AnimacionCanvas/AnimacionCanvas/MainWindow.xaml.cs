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
using System.Windows.Threading;

namespace AnimacionCanvas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double max_x;
        private double max_y;
        private double y=0;
        private double x=0;
        private int direccion=0;
        private bool parada = true;
        DispatcherTimer t = new DispatcherTimer();

        private int cambiarDir()
        {
            Random r = new Random();
            int nuevaDir = r.Next(1, 4);
            if (nuevaDir == direccion)
            {
                nuevaDir = direccion >= 3 ? 2 : 3;
            }
            return nuevaDir;
        }

        public MainWindow()
        {
            InitializeComponent();

            direccion = cambiarDir();
            max_y = can.Height;
            max_x = can.Width;
            t.Interval = TimeSpan.FromSeconds(0.001);
            t.Tick += timer_Tick;
            t.Start();
            parada = true;

            y = Canvas.GetTop(imgStarMuerte);
            x = Canvas.GetLeft(imgStarMuerte);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Canvas.SetTop(imgStarMuerte, y);
            Canvas.SetLeft(imgStarMuerte, x);

            switch (direccion)
            {
                case 1: //Izquierda-arriba
                    y -= 1;
                    x -= 1;
                    if (y <= 0) //Reviso si me salgo por arriba
                        direccion = 2;
                    else if (x <= 0) //Reviso si me salgo por la izq.
                        direccion = 3;

                    break;

                case 2: //Izquierda-abajo
                    y += 1;
                    x -= 1;

                    if (y + imgStarMuerte.Height >= max_y) //Reviso si me salgo por abajo
                        direccion = 1;
                    else if (x <= 0) //Reviso si me salgo por la izq.
                        direccion = 4;
                    break;

                case 3: //Derecha-arriba
                    y -= 1;
                    x += 1;

                    if (y <= 0) //Reviso si me salgo por arriba.
                        direccion = 4;
                    else if (x + imgStarMuerte.Width >= max_x) //Reviso si me salgo por la der.
                    {
                        direccion = 1;
                    }
                    break;

                case 4: //Derecha-abajo
                    y += 1;
                    x += 1;

                    if (y + imgStarMuerte.Height >= max_y)//Reviso si me salgo por abajo.
                        direccion = 3;
                    else if (x + imgStarMuerte.Width >= max_x)//Reviso si me salgo por la der.
                        direccion = 2;
                    break;                  
            }
            laCoordenadas.Content = "x=" + x + " y=" + y;
            // laCoordenadas.Content = max_x + " " + max_y;
            Canvas.SetTop(imgStarMuerte, y);
            Canvas.SetLeft(imgStarMuerte, x);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (winCanvas.WindowState == WindowState.Maximized)
            {
                Height = SystemParameters.MaximizedPrimaryScreenHeight;
                Width = SystemParameters.MaximizedPrimaryScreenWidth;
            }

            can.Height = this.Height - 30;
            can.Width = this.Width - 10;
            max_y = can.Height;
            max_x = can.Width;
        }

        private void WinCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                if (parada)
                    t.Stop();
                else
                    t.Start();
                parada = !parada;
            }
        }

        private void ImgStarMuerte_MouseEnter(object sender, MouseEventArgs e)
        {
            imgStarMuerte.MouseEnter -= imgStarMuerte_MouseEnter;
            direccion = cambiarDir();
            imgStarMuerte.MouseEnter += imgStarMuerte_MouseEnter;
        }

        private void imgStarMuerte_MouseEnter(object sender, MouseEventArgs e)
        {
            t.IsEnabled = !t.IsEnabled;
        }
    }
}
