using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using SSCCSET2019.Pages;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Data.ApplicationSource;
using System.Threading;



namespace SSCCSET2019.Logic
{
    class ScreenSettingsLogic
    {
        private IWebDriver driver;
        public ScreenSettings SubmitCheckBoxesPageLogic(ScreenSettings.Page p)
        {
            ScreenSettings screen = new ScreenSettings(Driver.GetDriver());
            screen.AuthorClick(Pages.ScreenSettings.Page.AllNotes);
            screen.CatedoriesClick(Pages.ScreenSettings.Page.AllNotes);
            screen.TagsClick(Pages.ScreenSettings.Page.AllNotes);
            screen.CommentsClick(Pages.ScreenSettings.Page.AllNotes);
            screen.DateClick(Pages.ScreenSettings.Page.AllNotes);
            screen.ViewAsListClick(Pages.ScreenSettings.Page.AllNotes);
            screen.ViewTheDetailsClick(Pages.ScreenSettings.Page.AllNotes);
            screen.NumbersOfNotesClick(Pages.ScreenSettings.Page.AllNotes);
            screen.NumbersOfNotesClear(Pages.ScreenSettings.Page.AllNotes);
            screen.NumbersOfNotesSetText(Pages.ScreenSettings.Page.AllNotes);
            screen.ApplyClick(Pages.ScreenSettings.Page.AllNotes);

            return new ScreenSettings (Driver.GetDriver()); ;
        }
        public ScreenSettings EnterTheNotesPageLogic()
        {
            ScreenSettings screen = new ScreenSettings(Driver.GetDriver());
            screen.NumbersOfNotesClick(Pages.ScreenSettings.Page.AllNotes);
            screen.NumbersOfNotesClear(Pages.ScreenSettings.Page.AllNotes);
            screen.NumbersOfNotesSetText(Pages.ScreenSettings.Page.AllNotes);
            screen.ApplyClick(Pages.ScreenSettings.Page.AllNotes);

            return new ScreenSettings(Driver.GetDriver()); ;
        }

    }
}
