using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        private TRDeviceStation trStation = new TRDeviceStation();

        #endregion private

        #region Public Property

        public TRDeviceStation TrStation { get => trStation; set => trStation = value; }

        #endregion Public Property

        public StateMonitoringCard()
        {
            InitializeComponent();
            IniBinding();
        }

        public StateMonitoringCard(TRDeviceStation tRDeviceStation)
        {
            InitializeComponent();
            IniBinding();
            ReflashData(tRDeviceStation);
        }

        private void IniBinding()
        {
            if (trStation == null)
                trStation = new TRDeviceStation();
            this.textStatus.SetBinding(TextBlock.TextProperty, new Binding() { Path = new PropertyPath("Satus.Status"), Source = trStation });
            this.textInfo.SetBinding(TextBlock.TextProperty, new Binding() { Path = new PropertyPath("Satus.AlarmMassList"), Source = trStation });
            this.textDeviceNO.SetBinding(TextBlock.TextProperty, new Binding() { Path = new PropertyPath("SerialNo"), Source = trStation });
            this.textIP.SetBinding(TextBlock.TextProperty, new Binding() { Path = new PropertyPath("Ip"), Source = trStation });
        }

        public bool ReflashData(TRDeviceStation tRDeviceStation)
        {
            trStation.SetValue(tRDeviceStation);
            return true;
        }
    }
}