using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TnAConfigureProgram.CS.Class
{
    class Telnet
    {
        public void Gateway(string region, string site, string area)
        {
            byte[] data = new byte[1024];
            string line, stringData;

            int counter = 0;

            TcpClient server;

            try
            {
                server = new TcpClient("100.100.100.100", 23);
            }
            catch (SocketException)
            {
                MessageBox.Show("Unable to connect to GateWay. \n\n* See if the Firmware is the correct Firmware\n* Reset the Network card.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            StreamReader file = new StreamReader(pathDir + "\\" + region + "\\" + site + "\\" + area);
            NetworkStream ns = server.GetStream();
            int recv = ns.Read(data, 0, data.Length);
            stringData = Encoding.ASCII.GetString(data, 0, recv);
            Console.WriteLine(stringData);
            byte[] space = Encoding.ASCII.GetBytes(Environment.NewLine);
            ns.Write(space, 0, space.Length);
            ns.Flush();

            while ((line = file.ReadLine()) != null)
            {
                try
                {
                    counter++;
                    byte[] lines = Encoding.ASCII.GetBytes(line + Environment.NewLine);
                    ns.Write(lines, 0, lines.Length);
                    ns.Flush();
                    data = new byte[1024];
                    recv = ns.Read(data, 0, data.Length);
                    stringData = Encoding.ASCII.GetString(data, 0, recv);
                    Console.WriteLine(stringData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    ns.Close();
                    server.Close();
                }
            }

            MessageBox.Show("GateWay has been configured.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
