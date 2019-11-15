using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCCSET2019
{
    class ApplicationSource
    { 
        public static string BrowserName { get; private set; }
        public static void SetBrowser(string browserName)
        {
            BrowserName = browserName;
        }
    }
}
