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

namespace WpfApp11
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

         public class Dat
        {
            public double X{get;set;} ;
            public void GetInfo()
            {
                if (X > 0)
                {
                    X -= 8;
                }
                else if (X < 0)
                {
                    X += 6;
                }
                else
                {
                    X = 10;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dat dat = new Dat();
            dat.X = double.Parse(A.Text);
            dat.GetInfo();
            B.Text = $"{dat.X}";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Dat dat = new Dat();
            dat.X = double.Parse(A.Text);
            dat.GetInfo();
            NavigationService.Navigate(new Page2(dat));
        }
    }
}
