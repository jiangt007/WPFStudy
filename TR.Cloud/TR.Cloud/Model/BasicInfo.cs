using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.Cloud.Model
{
    public class DeviceInfo
    {
        private string deviceModel;
        private string softWareVersion;
        private string massVersion;
        public string DeviceModel { get => deviceModel; set => deviceModel = value; }
        public string SoftWareVersion { get => softWareVersion; set => softWareVersion = value; }
        public string MassVersion { get => massVersion; set => massVersion = value; }
    }
}