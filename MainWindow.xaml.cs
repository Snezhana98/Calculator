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
                    Vivod = new ClassCalc();
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
                else
                {
                    VerhVivodPrimera.Text = Vivod.SecondDigit + " " + Vivod.k + " " + Vivod.FirstDigit;
                    //VvodPrimera.Text = Vivod.res().ToString();
                }
            }
        }

        private void ClickZnak(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                Vivod.ZnakString = btn.Content.ToString();
                Vivod.k = Vivod.ZnakString;
                VerhVivodPrimera.Text = Vivod.k + " " + Vivod.FirstDigit;
                
               
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
                    
                }
            }
        }
    }
}
