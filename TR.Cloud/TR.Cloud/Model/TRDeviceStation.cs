using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.Cloud.Model
{
    public class TRDeviceStation
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

        public string SerialNo { get => serialNo; set => serialNo = value; }
        public string Ip { get => ip; set => ip = value; }
        public DeviceInfo Device { get => deviceInfo; set => deviceInfo = value; }
        public RealTimeSatus Satus { get => realTimeSatus; set => realTimeSatus = value; }
    }
}