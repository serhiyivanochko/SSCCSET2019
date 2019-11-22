using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Data.ApplicationSource;
using OpenQA.Selenium;
using SSCCSET2019.Pages;

namespace SSCCSET2019.Logic
{
    class UpdatesPageLogic
    {
        UpdatesPage updatesPage;
        public UpdatesPageLogic()
        {
            ApplicationSource.SetBrowser("chrome");
            var driver = Driver.GetDriver();
            updatesPage = new UpdatesPage(driver);
        }
        public void MainUpdatesCheck()
        {
            updatesPage.CheckUpdates(); // якщо воно переходить на іншу сторінку має чи та сторінка equals тій шо я задам сам чи як? 
            //Assert.AreEqual(?? , "http://localhost/wp1/wp-admin/update-core.php?force-check=1");
        }
        /*public string UpdatePlugins()    сторінка оновлення , пропадає якщо один раз одновити!
        {
            updatesPage.SelectAllPlugins();
            updatesPage.UpdatePlugins();
            return "http://localhost/wp1/wp-admin/update-core.php?action=do-plugin-upgrade";
        }*/
    }
}
