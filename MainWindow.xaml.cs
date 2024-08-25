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
using MyProyecto;

namespace WpfApp1
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
        
        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            if (int.TryParse(txtA.Text, out int a) &&
                int.TryParse(txtB.Text, out int b) &&
                int.TryParse(txtC.Text, out int c) &&
                int.TryParse(txtD.Text, out int d) &&
                int.TryParse(txtE.Text, out int f))
            {
                // Los valores se han convertido correctamente, ahora puedes usarlos según tus necesidades
                // Por ejemplo, puedes llamar a tu lógica existente de consola
                //Console.WriteLine($"Ecuación recibida: {a}x^2 + {b}y^2 + {c}x + {d}y + {f} = 0");
                Plano p1 = new Plano(a, b, c, d, f, "n");
                Plano nuevo = p1.CrearFigura();
                resultadoTextBlock.Text = (nuevo.ToString());

                // O realizar cualquier otra operación con los valores
            }
            else
            {
                // Manejar el caso en el que la entrada no sea válida
                MessageBox.Show("Ingrese valores numéricos válidos en todas las casillas.", "Error de entrada");
            }
        }
    }
}