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
using static System.Math;
using static WpfApp11.Page1;

namespace WpfApp11
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
    Dat dat1;
        public Page2(Dat dat)
        {
            InitializeComponent();
            dat1 = dat;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        public void GetInfo(double a , double b , double c)
        {
            double M = (a + Pow(b, 2)) / c;
            double k = (int)M % 3;
            double y = 0;
            switch (M)
            {
                case 0: y = Log(a / b); break;
                case 1: y = Exp(M + c); break;
                default: y = Sqrt(Abs(Pow(a + b, 2) + c)); break;
            }
            Otv.Text = $"{y}";
            double v = dat1.X + y;
            symm.Text = $"{v}";
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(A.Text);
            double b = double.Parse(B.Text);
            double c = double.Parse(C.Text);
            GetInfo(a, b, c);
        }
    }
}
