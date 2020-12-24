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

namespace WpfApp4._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double[] massive = new double[int.Parse(count.Text)];
                int peremennaya = 0;
                Random generator = new Random();
                for (int counter = 0; counter < massive.Length; counter++)
                {
                    massive[counter] = Math.Round(generator.Next(1, 51) - generator.NextDouble(), 2);
                    result.Text += massive[counter].ToString() + "  ";
                    if (massive[counter] > massive[0])
                    {
                        peremennaya++;
                    }
                }
                result.Text += Environment.NewLine + peremennaya;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
