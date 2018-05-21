using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.Cloud.Model
{
    public class RealTimeSatus
    {
        private string status;
        private bool isAlarm;
        private string alarmMassList;
        private string user;

        public string Status { get => status; set => status = value; }
        public bool IsAlarm { get => isAlarm; set => isAlarm = value; }
        public string AlarmMassList { get => alarmMassList; set => alarmMassList = value; }
        public string User { get => user; set => user = value; }
    }
}