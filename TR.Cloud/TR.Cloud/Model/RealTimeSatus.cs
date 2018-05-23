using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.Cloud.Model
{
    public class RealTimeSatus : INotifyPropertyChanged
    {
        private string status;
        private bool isAlarm;
        private string alarmMassList;
        private string user;

        public string Status
        {
            get => status; set
            {
                status = value;
                OnPropertyChanged("Status");
            }
        }

        public bool IsAlarm
        {
            get => isAlarm; set
            {
                isAlarm = value;
                OnPropertyChanged("IsAlarm");
            }
        }

        public string AlarmMassList
        {
            get => alarmMassList; set
            {
                alarmMassList = value;
                OnPropertyChanged("AlarmMassList");
            }
        }

        public string User
        {
            get => user; set
            {
                user = value;
                OnPropertyChanged("AlarmMassList");
            }
        }

        public void SetValue(RealTimeSatus newRealTimeSatus)
        {
            if (newRealTimeSatus == null)
                return;
            this.Status = newRealTimeSatus.Status;
            this.IsAlarm = newRealTimeSatus.IsAlarm;
            this.AlarmMassList = newRealTimeSatus.AlarmMassList;
            this.User = newRealTimeSatus.User;
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