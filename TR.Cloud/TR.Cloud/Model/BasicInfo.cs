using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.Cloud.Model
{
    public class DeviceInfo : INotifyPropertyChanged
    {
        private string deviceModel;
        private string softWareVersion;
        private string massVersion;

        public string DeviceModel
        {
            get => deviceModel; set
            {
                deviceModel = value;
                OnPropertyChanged("DeviceModel");
            }
        }

        public string SoftWareVersion
        {
            get => softWareVersion; set
            {
                softWareVersion = value;
                OnPropertyChanged("SoftWareVersion");
            }
        }

        public string MassVersion
        {
            get => massVersion; set
            {
                massVersion = value;
                OnPropertyChanged("SoftWareVersion");
            }
        }

        public void SetValue(DeviceInfo newDeviceInfo)
        {
            if (newDeviceInfo == null)
                return;
            this.DeviceModel = newDeviceInfo.DeviceModel;
            this.SoftWareVersion = newDeviceInfo.SoftWareVersion;
            this.MassVersion = newDeviceInfo.MassVersion;
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