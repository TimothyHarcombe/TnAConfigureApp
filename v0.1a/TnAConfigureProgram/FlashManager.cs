using System;
using System.Diagnostics;
using System.IO;

namespace TnAConfigureProgram
{
    class FlashManager
    {   
        public void FlashFileCopyLeft(string dPaste)
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\Programs\LifeLoc frimware\Left arrow\*.*";

            var dCopy = Path.Combine(userProfile, subFolders);

            Xcopy(dCopy, dPaste);
        }

        public void FlashFileCopyRight(string dPaste)
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\Programs\LifeLoc frimware\Right arrow\*.*";

            var dCopy = Path.Combine(userProfile, subFolders);

            Xcopy(dCopy, dPaste);
            
        }

        public void FormatFlash(string driveLetter, string fileSystem, string volumeName)
        {
            Process format = new Process();
            
            format.StartInfo.FileName = "cmd.exe";
            format.StartInfo.RedirectStandardInput = true;
            format.StartInfo.RedirectStandardOutput = true;
            format.StartInfo.CreateNoWindow = true;
            format.StartInfo.UseShellExecute = false;
            format.Start();

            format.StandardInput.WriteLine("format {0} /y /fs:{1} /v:{2} /q", driveLetter, fileSystem, volumeName);
            format.StandardInput.Flush();
            format.StandardInput.Close();
            format.WaitForExit();
            Console.WriteLine(format.StandardOutput.ReadToEnd());
        }

        public void Xcopy(string dCopy, string dPaste)
        {
            Process xcopy = new Process();

            xcopy.StartInfo.FileName = "xcopy";
            xcopy.StartInfo.CreateNoWindow = false;
            xcopy.StartInfo.UseShellExecute = false;
            xcopy.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            xcopy.StartInfo.Arguments = "\"" + dCopy + "\"" + " " + "\"" + dPaste + "\"" + @" /y /I";
            xcopy.Start();
            xcopy.WaitForExit();
        }
    }
}
