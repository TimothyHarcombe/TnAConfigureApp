using System.Diagnostics;
using System.Management;
using System.Net.NetworkInformation;

namespace TnAConfigureProgram
{
    internal class NetworkManagement
    {
        internal void setIP(string nic_adapter, string ip_address, string subnet_mask)
        {
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface ip set address \"" + nic_adapter + "\" static "+ ip_address +" "+ subnet_mask);
            p.StartInfo = psi;
            psi.UseShellExecute = false;
            p.Start();
            p.Close();
        }

        public void setDHCP(string nic_adapter)
        {
            string adapterDESC;

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapters in nics)
            {
                if (adapters.Name == nic_adapter)
                {
                    adapterDESC = adapters.Description;

                    ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
                    ManagementObjectCollection objMOC = objMC.GetInstances();

                    foreach (ManagementObject objMO in objMOC)
                    {
                        if ((bool)objMO["IPEnabled"])
                        {
                            if (!objMO["Description"].Equals(adapterDESC))
                                continue;

                            var ndns = objMO.GetMethodParameters("SetDNSServerSearchOrder");
                            ndns["DNSServerSearchOrder"] = null;

                            var enableDhcp = objMO.InvokeMethod("EnableDHCP", null, null);
                            var setDns = objMO.InvokeMethod("SetDNSServerSearchOrder", ndns, null);
                        }
                    }
                }
            }
        }
    }
}
