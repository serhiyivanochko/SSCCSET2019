using System;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Pages;

namespace SSCCSET2019.Logic
{
    class UpdatesPageLogic
    {
        public void MainUpdatesCheck()
        {
            UpdatesPage updatesPage = new UpdatesPage(Driver.GetDriver());
            updatesPage.CheckUpdates(); // якщо воно переходить на іншу сторінку має чи та сторінка equals тій шо я задам сам чи як? 
            //Assert.AreEqual(?? , "http://localhost/wp1/wp-admin/update-core.php?force-check=1");
        }
        public void AboutWordpress()
        {
            UpdatesPage updatesPage = new UpdatesPage(Driver.GetDriver());
            updatesPage.AboutButton(); 
            //Assert.AreEqual(?? , "http://localhost/wp1/wp-admin/update-core.php?force-check=1");
        }
        /*public string UpdatePlugins()    сторінка оновлення , пропадає якщо один раз оновити!
        {
            updatesPage.SelectAllPlugins();
            updatesPage.UpdatePlugins();
            return "http://localhost/wp1/wp-admin/update-core.php?action=do-plugin-upgrade";
        }*/
    }
}
