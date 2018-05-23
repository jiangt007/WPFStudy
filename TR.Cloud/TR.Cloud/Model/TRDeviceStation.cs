using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.Cloud.Model
{
    public class TRDeviceStation : INotifyPropertyChanged
    {
        private string serialNo;
        private string ip;

        private DeviceInfo deviceInfo;
        private RealTimeSatus realTimeSatus;

        public TRDeviceStation()
        {
            deviceInfo = new DeviceInfo();
            realTimeSatus = new RealTimeSatus();
        }

        public string SerialNo
        {
            get => serialNo;
            set
            {
                serialNo = value;
                OnPropertyChanged("SerialNo");
            }
        }

        public string Ip
        {
            get => ip;
            set
            {
                ip = value;
                OnPropertyChanged("Ip");
            }
        }

        public DeviceInfo Device { get => deviceInfo; set => deviceInfo = value; }
        public RealTimeSatus Satus { get => realTimeSatus; set => realTimeSatus = value; }

        public void SetValue(TRDeviceStation newStation)
        {
            if (newStation == null)
                return;
            this.SerialNo = newStation.SerialNo;
            this.Ip = newStation.Ip;
            this.Device.SetValue(newStation.Device);
            this.Satus.SetValue(newStation.Satus);
        }

        #region 数据属性发生改变事件

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion 数据属性发生改变事件
    }
}