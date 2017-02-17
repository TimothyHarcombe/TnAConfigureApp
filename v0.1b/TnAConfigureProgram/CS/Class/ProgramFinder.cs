using System;
using System.Diagnostics;
using System.IO;

namespace TnAConfigureProgram
{
    class ProgramFinder
    {
        internal void ProgramStarter(string subFolders)
        {
            ProcessStartInfo start = new ProcessStartInfo();

            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var path = Path.Combine(userProfile, subFolders);
            start.FileName = path;
            start.WindowStyle = ProcessWindowStyle.Normal;
            start.CreateNoWindow = true;

            using (Process prog = Process.Start(start))
            {
                if (!prog.CloseMainWindow())
                {
                    prog.Close();
                }
                else
                {
                    if (!prog.WaitForExit(2000))
                    {
                        prog.Kill();
                    }
                }
            }
        }
    }
}
