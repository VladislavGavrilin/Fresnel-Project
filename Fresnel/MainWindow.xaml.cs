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

namespace Fresnel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SetupFresnel setupFresnel; 
        public MainWindow()
        {
            InitializeComponent();
            setupFresnel = new SetupFresnel();
            this.DataContext = setupFresnel;

        }
        private void applyInitials(object sender, RoutedEventArgs e)
        {
            stepResult.Text = setupFresnel.StepCalculation(Convert.ToDouble(customFreq.Text), Convert.ToDouble(customHeight.Text), Convert.ToDouble(customWidth.Text), Convert.ToDouble(customDist.Text), Convert.ToDouble(customRpArea.Text)).ToString();
            cutResult.Text = "Changed cut";
            calcAreaResult.Text = "Changed area";

        }

    }
}
