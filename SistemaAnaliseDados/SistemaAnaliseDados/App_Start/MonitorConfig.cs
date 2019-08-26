using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SistemaAnaliseDados.App_Start
{
    public class MonitorConfig
    {
        public static void RegisterWatchers()
        {
            var fsw = new FileSystemWatcher
            {
                Path = AppDomain.CurrentDomain.BaseDirectory + @"Data\In",
                EnableRaisingEvents = true,
                IncludeSubdirectories = false
            };

            fsw.Created += new FileSystemEventHandler(OnCreated);
        }

        static void OnCreated(object sender, FileSystemEventArgs e)
        {
           
        }
    }
}