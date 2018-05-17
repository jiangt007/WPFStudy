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
using ShowMeTheXAML;

namespace WM.TR.RMS
{
    /// <summary>
    /// Interaction logic for Cards.xaml
    /// </summary>
    public partial class Cards : UserControl
    {
        public Cards()
        {
            InitializeComponent();
        }

        private void Flipper_OnIsFlippedChanged(object sender, RoutedPropertyChangedEventArgs<bool> e)
        {
            System.Diagnostics.Debug.WriteLine("Card is flipped = " + e.NewValue);
        }

        public void AddCard()
        {
            //mainPanel.ad
        }

        private void AddProgramControl(DeviceStatus status)
        {
            XamlDisplay xamlDisplay = new XamlDisplay()
            {
                Margin = new Thickness(0, 0, 0, 0),
                VerticalContentAlignment = VerticalAlignment.Top
            };
        }
    }

    public class DeviceStatus
    {
        private string deviceName;
        private string ip;
        private string status;
        private string content;
    }
}