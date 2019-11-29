using System;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Pages;

namespace SSCCSET2019.Logic
{
    class UpdatesPageLogic
    {
        public UpdatesPage MainUpdatesCheck()
        {
            UpdatesPage updatesPage = new UpdatesPage(Driver.GetDriver());
            updatesPage.CheckUpdates();
            return new UpdatesPage(Driver.GetDriver());
        }
        /*public UpdatesPage AboutWordpress()
        {
            UpdatesPage updatesPage = new UpdatesPage(Driver.GetDriver());
            updatesPage.AboutButton();
            return new UpdatesPage(Driver.GetDriver());
        }*/
        public UpdatesPage UpdatePlugins()    //сторінка оновлення , пропадає якщо один раз оновити!
        {
            UpdatesPage updatesPage = new UpdatesPage(Driver.GetDriver());
            updatesPage.SelectAllPlugins();
            updatesPage.UpdatePlugins();
            return new UpdatesPage(Driver.GetDriver());
        }
    }
}
