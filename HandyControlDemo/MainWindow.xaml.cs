using HandyControl.Data;
using Microsoft.Win32;
using System;
using System.Linq;
using System.Management;
using System.Windows;

namespace HandyControlDemo
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");

            var buildNumber = Convert.ToInt32(registryKey.GetValue("CurrentBuild"));
            var buildNumber2 = Convert.ToInt32(registryKey.GetValue("CurrentMajorVersionNumber"));
            var buildNumber3 = Convert.ToInt32(registryKey.GetValue("CurrentMinorVersionNumber"));

            var info = new SystemVersionInfo(buildNumber2, buildNumber3, buildNumber);
            

            MessageBox.Show(info.Major + " " + info.Minor + " " + info.Build);
        }
        
    }
}