using System;
using System.Diagnostics;
using System.IO;

namespace TnAConfigureProgram
{
    class ExecuteBatch
    {
        public void ExecuteBatchCommand()
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\Programs\DBConn\DBConnect";
            string subFoldersAndFile = @"Box Sync\Tna\TnA Configs\Programs\DBConn\DBConnect\DBConnect.bat";

            var batPath = Path.Combine(userProfile, subFolders);
            var batPath1 = Path.Combine(userProfile, subFoldersAndFile);

            int ExitCode;
            ProcessStartInfo pInfo;
            Process p;

            pInfo = new ProcessStartInfo(batPath1);
            pInfo.CreateNoWindow = true;
            pInfo.UseShellExecute = false;
            pInfo.WorkingDirectory = batPath;
            pInfo.RedirectStandardError = true;
            pInfo.RedirectStandardOutput = true;

            p = Process.Start(pInfo);
            p.WaitForExit();

            ExitCode = p.ExitCode;

            p.Close();
        }
    }
}
