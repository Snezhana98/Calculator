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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        ClassCalc Vivod;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickChislo(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                if (Vivod == null)
                {
                    Vivod = new ClassCalc();
                    VerhVivodPrimera.Text = "";
                }

                    int n = int.Parse(btn.Content.ToString());
                VvodPrimera.Text = n.ToString();

                if (Vivod.ZnakString == null)

                    Vivod.FirstDigit = n;
                else
                {
                    Vivod.SecondDigit = n;
                    Vivod.proverka = n;
                }
            }
        }

        private void ClickSbros(object sender, RoutedEventArgs e)
        {
            VvodPrimera.Text = "0";
            VerhVivodPrimera.Text = "";
            Vivod = null;
        }

        private void ClickRavno(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                if (Vivod.ZnakString == "div" && Vivod.SecondDigit == 0 && Vivod.proverka == 0)
                {
                    VvodPrimera.Text = "Деление на 0";
                    Vivod.proverka = 1;
                }
                else if (Vivod.ZnakString == "kvad")
                {
                    VvodPrimera.Text = Vivod.res().ToString();
                }
                else
                {
                    VerhVivodPrimera.Text = Vivod.FirstDigit + " " + Vivod.k + " " + Vivod.SecondDigit;
                    VvodPrimera.Text = Vivod.res().ToString();
                }
                Vivod = null;
            }
        }

        private void ClickZnak(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                Vivod.ZnakString = btn.Content.ToString();
                Vivod.k = Vivod.ZnakString;
                if (Vivod.ZnakString != "x^2")
                VerhVivodPrimera.Text = Vivod.FirstDigit + " " + Vivod.k;
                else VerhVivodPrimera.Text = Vivod.FirstDigit + "^2 ";

                switch (Vivod.ZnakString)
                    {
                        case "+":
                            Vivod.ZnakString = "plus";
                            break;
                        case "-":
                            Vivod.ZnakString = "minus";
                            break;
                        case "*":
                            Vivod.ZnakString = "mul";
                            break;
                        case "/":
                            Vivod.ZnakString = "div";
                            break;
                    case "x^2":
                        Vivod.ZnakString = "kvad";
                        break;

                }
            }
        }
    }
}
