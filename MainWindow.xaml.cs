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

namespace PR_22._102_Abdrahmanov_Variant1
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
            string s = tbNum.ToString();

            try
            {
                if (s.Length != 12)
                {
                    throw new Exception("Число должно состоять из 12 цифр!");
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка");
            }            
        }
    }
}
