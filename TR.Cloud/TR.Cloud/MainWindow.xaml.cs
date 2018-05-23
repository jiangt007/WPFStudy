﻿using System;
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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private StateMonitoringCards stateMonitoringCards = new StateMonitoringCards();

        public MainWindow()
        {
            InitializeComponent();
            Button_Click(null, null);
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
            stackPanelRight.Children.Add(stateMonitoringCards);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void buttonTest_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Test();
        }

        private int index = 0;

        private void Test()
        {
            index++;
            TRDeviceStation deviceInfo = new TRDeviceStation();
            deviceInfo.SerialNo = "TR-2000DC-170";
            deviceInfo.Ip = "192.168.1.1 " + index.ToString();
            deviceInfo.Device.DeviceModel = "TR-2000DC" + index.ToString();
            deviceInfo.Device.SoftWareVersion = "1.1.1701" + index.ToString();
            deviceInfo.Device.MassVersion = "9.19.11.1" + index.ToString();

            deviceInfo.Satus.Status = "正在检测" + index.ToString();
            deviceInfo.Satus.IsAlarm = true;
            deviceInfo.Satus.AlarmMassList = "TNT HMX" + index.ToString();
            deviceInfo.Satus.User = "SurperUser";
            stateMonitoringCards.AddCard(deviceInfo);
        }
    }
}