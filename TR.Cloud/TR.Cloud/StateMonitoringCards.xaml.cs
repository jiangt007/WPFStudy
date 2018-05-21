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
    /// StateMonitoringCardsUserControl.xaml 的交互逻辑
    /// </summary>
    public partial class StateMonitoringCards : UserControl
    {
        private Dictionary<string, TRDeviceStation> dicDeviceInfo = new Dictionary<string, TRDeviceStation>();

        public StateMonitoringCards()
        {
            InitializeComponent();
            Test();
        }

        public void AddCard(TRDeviceStation deviceInfo)
        {
            if (dicDeviceInfo.ContainsKey(deviceInfo.SerialNo))
            {
                dicDeviceInfo[deviceInfo.SerialNo] = deviceInfo;
            }
            else
            {
                dicDeviceInfo.Add(deviceInfo.SerialNo, deviceInfo);
                StateMonitoringCard stateMonitoringCard = new StateMonitoringCard(dicDeviceInfo[deviceInfo.SerialNo]);
                this.cardsWarpPanel.Children.Add(stateMonitoringCard);
            }
        }

        private void Test()
        {
            for (int i = 1; i < 20; i++)
            {
                TRDeviceStation deviceInfo = new TRDeviceStation();
                deviceInfo.SerialNo = "TR-2000DC-170" + i.ToString();
                deviceInfo.Ip = "192.168.1.1";
                deviceInfo.Device.DeviceModel = "TR-2000DC";
                deviceInfo.Device.SoftWareVersion = "1.1.1701";
                deviceInfo.Device.MassVersion = "9.19.11.1";

                deviceInfo.Satus.Status = "正在检测";
                deviceInfo.Satus.IsAlarm = true;
                deviceInfo.Satus.AlarmMassList = "TNT HMX";
                deviceInfo.Satus.User = "SurperUser";
                AddCard(deviceInfo);
            }
        }
    }
}