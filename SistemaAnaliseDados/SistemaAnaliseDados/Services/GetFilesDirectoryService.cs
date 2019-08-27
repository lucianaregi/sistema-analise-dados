using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace SistemaAnaliseDados.Services
{
    public static class GetFilesDirectoryService
    {
       private static string sourceDirectory = AppDomain.CurrentDomain.BaseDirectory + @"Data\In";

        public static IEnumerable<string> SellerFiles()
        {           
            IEnumerable<string> filelocations = Directory.GetFiles(sourceDirectory, "001*", SearchOption.AllDirectories).Select(x => Path.GetFileNameWithoutExtension(x));
            return filelocations;
        }

        public static IEnumerable<string> ClientFiles()
        {
            IEnumerable<string> filelocations = Directory.GetFiles(sourceDirectory, "002*", SearchOption.AllDirectories).Select(x => Path.GetFileNameWithoutExtension(x));
            return filelocations;
        }

        public static IEnumerable<string> SaleFiles()
        {
            IEnumerable<string> filelocations = Directory.GetFiles(sourceDirectory, "003*", SearchOption.AllDirectories).Select(x => Path.GetFileNameWithoutExtension(x));
            return filelocations;
        }
        public static int CountFiles()
        {
            return Directory.GetFiles(sourceDirectory).Length;
        }
    }
}