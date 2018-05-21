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

namespace TR.Cloud
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuPopupButton_OnClick(object sender, RoutedEventArgs e)
        {
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn_Repair_Click(object sender, RoutedEventArgs e)
        {
            //stackPanelRight.Children.Clear();
            //UserControl userControl = null;
            //userControl = new CustomerRepairUserControl();
            StateMonitoringCards stateMonitoringCards = new StateMonitoringCards();
            stackPanelRight.Children.Add(stateMonitoringCards);
        }
    }
}