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

namespace CalculatorUnitedTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassCalc cc = new ClassCalc();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            cc.BeregnAlt(Convert.ToInt32(TextboxTal1.Text), Convert.ToInt32(TextboxTal2.Text));

            LabelPlus.Content = cc.resPlus.ToString();
            LabelMinus.Content = cc.resMinus.ToString();
            LabelGange.Content = cc.resGange.ToString();
            LabelDividere.Content = cc.resDiv.ToString();
        }


    }
}
