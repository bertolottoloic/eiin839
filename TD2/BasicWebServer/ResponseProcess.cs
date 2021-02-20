using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer
{
    class ResponseProcess
    {
        public static string Response(HttpListenerRequest request) {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\kynor\Documents\Cours\SI4\SOC\eiin839\TD2\MyMethod\bin\Debug\netcoreapp3.1\MyMethod.exe"; // Specify exe name.
            start.Arguments = request.Url.Query; // Specify arguments.
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            //
            // Start the process.
            //
            using (Process process = Process.Start(start))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
