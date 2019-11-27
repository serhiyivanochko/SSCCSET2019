using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace SSCCSET2019
{
    class Help
    {
        List<Option> options;
        List<Description> description;
        List<Url> urls;
        public enum PageEnum {WorkshopMain, WorkShopUpdate, AllRecords, Categories, Marks, Library, AddNewMediafile, AllPagesPages, Comments, Themes, Vidgets, Menu, ThemeEdditor, InstalledPlagins, AddNewPlagin, PlaginEdditor, AllUsers, AddNewUser, MyAccount, AvailibleInstruments, Import, Export, GeneralSettings, WriteSettings,  ReadSettings, DiscussionSettings, MediafilesSettings, PermanentLinksSettings};

        public Help(PageEnum pageName)
        {
            options = new List<Option>();
            switch (pageName)
            {
                case PageEnum.WorkshopMain:
                    options.Add(new Option("overview"));
                    options.Add(new Option("help-navigation"));
                    options.Add(new Option("help-layout"));
                    options.Add(new Option("help-overview"));
                    break;
                case PageEnum.WorkShopUpdate:
                    options.Add(new Option("overview"));
                    options.Add(new Option("how-to-update"));
                    break;
                case PageEnum.AllRecords:
                    options.Add(new Option("overview"));
                    options.Add(new Option("screen-content"));
                    options.Add(new Option("action-links"));
                    options.Add(new Option("bulk-links"));
                    break;
                case PageEnum.Categories:
                    options.Add(new Option("overview"));
                    options.Add(new Option("additing-terms"));
                    break;
                case PageEnum.Marks:
                    options.Add(new Option("overview"));
                    options.Add(new Option("additing-terms"));
                    break;
                case PageEnum.Library:
                    options.Add(new Option("overview"));
                    options.Add(new Option("action-links"));
                    options.Add(new Option("attaching-files"));
                    break;
                case PageEnum.AddNewMediafile:
                    options.Add(new Option("overview"));
                    break;
                case PageEnum.AllPagesPages:
                    options.Add(new Option("overview"));
                    options.Add(new Option("moderating-comments"));
                    break;
                case PageEnum.Comments:
                    options.Add(new Option("overview"));
                    options.Add(new Option("moderating-comments"));
                    break;
                case PageEnum.Themes:
                    options.Add(new Option("overview"));
                    options.Add(new Option("adding-theme"));
                    options.Add(new Option("customize-preview-themes"));
                    break;
                case PageEnum.Vidgets:
                    options.Add(new Option("overview"));
                    options.Add(new Option("removing-reusing"));
                    options.Add(new Option("missing-widgets"));
                    options.Add(new Option("custom-html-widget"));
                    break;
                case PageEnum.Menu:
                    options.Add(new Option("menu-management"));
                    options.Add(new Option("editing-menus"));
                    break;
                case PageEnum.ThemeEdditor:
                    options.Add(new Option("overview"));
                    break;
                case PageEnum.InstalledPlagins:
                    options.Add(new Option("overview"));
                    options.Add(new Option("compatibility-problems"));
                    break;
                case PageEnum.AddNewPlagin:
                    options.Add(new Option("overview"));
                    options.Add(new Option("adding-plugins"));
                    break;
                case PageEnum.PlaginEdditor:
                    options.Add(new Option("overview"));
                    break;
                case PageEnum.AllUsers:
                    options.Add(new Option("overview"));
                    options.Add(new Option("screen-content"));
                    options.Add(new Option("action-links"));
                    break;
                case PageEnum.AddNewUser:
                    options.Add(new Option("overview"));
                    options.Add(new Option("user-roles"));
                    break;
                case PageEnum.MyAccount:
                    options.Add(new Option("overview"));
                    break;
                case PageEnum.AvailibleInstruments:
                    options.Add(new Option("converter"));
                    break;
                case PageEnum.Import:
                    options.Add(new Option("overview"));
                    break;
                case PageEnum.Export:
                    options.Add(new Option("overview"));
                    break;
                case PageEnum.GeneralSettings:
                    options.Add(new Option("overview"));
                    break;
                case PageEnum.WriteSettings:
                    options.Add(new Option("overview"));
                    options.Add(new Option("overview"));
                    options.Add(new Option("options-postemail"));
                    options.Add(new Option("options-services"));
                    break;
                case PageEnum.ReadSettings:
                    options.Add(new Option("overview"));
                    options.Add(new Option("site-visibility"));
                    break;
                case PageEnum.DiscussionSettings:
                    options.Add(new Option("overview"));
                    break;
                case PageEnum.MediafilesSettings:
                    options.Add(new Option("overview"));
                    break;
                case PageEnum.PermanentLinksSettings:
                    options.Add(new Option("overview"));
                    options.Add(new Option("permalink-settings"));
                    options.Add(new Option("custom-structure"));
                    break;
            }
        }
    }
    public class Option
    {
        IWebElement name;

        public Option(string id)
        {
            name = Get(By.Id($"tab-link-{id}"));
        }
        public string click()
        {
            name.Click();
            return new Description("");
        }
    }
    public class Description
    {
        IWebElement description;
        public string GetText()
        { return description.GetText(); }
    }
    public class Url
    {

    }
}
