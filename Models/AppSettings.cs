using System;
using System.Collections.Generic;
using System.Text;

namespace MobileTest.Models
{
    public class AppSettings
    {
        public Device[] Devices { get; set; }
    }
    public class Device
    {
        public string PlatformName { get; set; }
        public LocalSettings LocalSettings { get; set; }
    }
    public class LocalSettings
    {
        public string uuid { get; set; }
        public string DeviceName { get; set; }
        public string AppPackage { get; set; }
        public string AppActivity { get; set; }
    }
}
