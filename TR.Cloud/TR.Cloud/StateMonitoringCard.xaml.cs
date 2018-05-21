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
using TR.Cloud.Model;

namespace TR.Cloud
{
    /// <summary>
    /// StateMonitoringCard.xaml 的交互逻辑
    /// </summary>
    public partial class StateMonitoringCard : UserControl
    {
        #region private

        private TRDeviceStation trStation = null;

        #endregion private

        #region Public Property

        public TRDeviceStation TrStation { get => trStation; set => trStation = value; }

        #endregion Public Property

        public StateMonitoringCard()
        {
            InitializeComponent();
        }

        public StateMonitoringCard(TRDeviceStation tRDeviceStation)
        {
            InitializeComponent();
            IniBinding();
            SetValue(tRDeviceStation);
        }

        private void IniBinding()
        {
            trStation = new TRDeviceStation();

            textStatus.SetBinding(TextBox.TextProperty, new Binding("/Name") { Source = trStation });
            textInfo.SetBinding(TextBox.TextProperty, new Binding("/Provinces/Name") { Source = trStation });
            textDeviceNO.SetBinding(TextBox.TextProperty, new Binding("/Provinces/Citys/Name") { Source = trStation });
            textIP.SetBinding(TextBox.TextProperty, new Binding("/Provinces/Citys/Name") { Source = trStation });
        }

        private bool SetValue(TRDeviceStation tRDeviceStation)
        {
            if (tRDeviceStation == null)
                return false;
            trStation = tRDeviceStation;
            return true;
        }
    }
}