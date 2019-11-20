using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Data.ApplicationSource;
using OpenQA.Selenium;
using SSCCSET2019.Pages;
using static SSCCSET2019.Pages.UpdatesPage;

namespace SSCCSET2019.Logic
{
    class UpdatesPageLogic
    {
        UpdatesPage updatesPage;
        public string UpdatePlugins()
        {
            updatesPage.SelectAllPlugins();
            updatesPage.UpdatePlugins();
            return "http://localhost/wp1/wp-admin/update-core.php?action=do-plugin-upgrade";
        }
    }
}
