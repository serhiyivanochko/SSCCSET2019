using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCCSET2019.Data.ApplicationSource
{
    class ApplicationSource
    {
        private static string browserName;

        public static string GetBrowserName()
        {
            if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "geckodriver.exe")))
            {
                browserName = "Firefox";
            }
            else if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "chromedriver.exe")))
            {
                browserName = "Chrome";
            }
            else if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "IEDriverServer.exe")))
            {
                browserName = "InternetExplorer";
            }
            else
            {
                throw new FileNotFoundException(AppDomain.CurrentDomain.BaseDirectory + "don`t exist browser driver");
            }
            return browserName;
        }

    }
}
