using System.Management;

namespace TnAConfigureProgram
{
    internal class NetworkManagement
    {
        internal void setIP(int index, string ip_address, string subnet_mask)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((uint)objMO["Index"] == index)
                {
                    if ((bool)objMO["IPEnabled"])
                    {
                        ManagementBaseObject setIP;
                        ManagementBaseObject newIP =
                            objMO.GetMethodParameters("EnableStatic");

                        newIP["IPAddress"] = new string[] { ip_address };
                        newIP["SubnetMask"] = new string[] { subnet_mask };

                        setIP = objMO.InvokeMethod("EnableStatic", newIP, null);
                    }
                }
            }
        }

        public void setDHCP()
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                        var ndns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                        ndns["DNSServerSearchOrder"] = null;

                        var enableDhcp = objMO.InvokeMethod("EnableDHCP", null, null);
                        var setDns = objMO.InvokeMethod("SetDNSServerSearchOrder", ndns, null);
                }
            }
        }
    }
}
