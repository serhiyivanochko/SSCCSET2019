using System;
using OpenQA.Selenium;
namespace SSCCSET2019.Pages.Notes
{
    class Сategories
    {
        IWebDriver driver;


        IWebElement name;
        IWebElement nameDescription;
        IWebElement partOfURL;
        IWebElement partOfURLDescription;
        IWebElement fatherCategory;
        IWebElement fatherCategoryDescription;
        IWebElement description;
        IWebElement descriptionForDescription;
        IWebElement submit;
        IWebElement WordPressURL;


        IWebElement screenSettings;
        IWebElement column;
        IWebElement includeDecription;
        IWebElement includePartURL;
        IWebElement includeCount;
        IWebElement maxNumber;
        IWebElement btnSubmitSettings;


        IWebElement help;
        IWebElement overviewHelp;
        IWebElement addCategoriesHelp;
        IWebElement addCategoriesTextHelp;
        IWebElement documentationHelp;
        IWebElement forumHelp;
        IWebElement rightPanelHelp;


        IWebElement editCategoryToFind;
        IWebElement btnFindCategory;


        IWebElement checkBoxSelectAll_upper;
        IWebElement checkBoxSelectAll_lower;
        IWebElement sortByName_upper;
        IWebElement sortByName_lower;
        IWebElement sortByURL_upper;
        IWebElement sortByURL_lower;
        IWebElement actionSelector_upper;
        IWebElement apply_upper;
        IWebElement actionSelector_lower;
        IWebElement apply_lower;
        IWebElement numberOfElements_upper;
        IWebElement numberOfElements_lower;


        IWebElement transformCategoryInMarkURL;
        IWebElement descriptionBox;
        IWebElement version;

        public Сategories(IWebDriver driver)
        {
            this.driver = driver;
            this.name = driver.FindElement(By.Id("tag-name"));
            this.nameDescription = driver.FindElement(By.Id("//*[@id=\"addtag\"]/div[1]/p"));
            this.partOfURL = driver.FindElement(By.Id("tag-slug"));
            this.partOfURLDescription = driver.FindElement(By.Id("//*[@id=\"addtag\"]/div[2]/p"));
            this.fatherCategory =driver.FindElement(By.Id("parent"));
            this.fatherCategoryDescription = driver.FindElement(By.Id("//*[@id=\"addtag\"]/div[3]/p"));
            this.description = driver.FindElement(By.Id("tag-description"));
            this.descriptionForDescription =  driver.FindElement(By.XPath("//*[@id=\"addtag\"]/div[4]/p"));
            this.submit = driver.FindElement(By.Id("submit"));
            WordPressURL = driver.FindElement(By.XPath("//*[@id=/\"footer-thankyou\"]/a"));
            this.screenSettings = driver.FindElement(By.Id("show-settings-link"));
            this.column = driver.FindElement(By.XPath("//*[@id=\"adv - settings\"]/fieldset[1]/legend"));
            this.includeDecription = driver.FindElement(By.Id("description-hide"));
            this.includePartURL = driver.FindElement(By.Id("slug-hide"));
            this.includeCount = driver.FindElement(By.Id("posts-hide"));
            this.maxNumber = driver.FindElement(By.Id("edit_category_per_page"));
            this.btnSubmitSettings = driver.FindElement(By.Id("screen-options-apply"));
            this.help = driver.FindElement(By.Id("contextual-help-link"));
            this.overviewHelp = driver.FindElement(By.XPath("//*[@id=\"tab - link - overview\"]/a"));
            this.addCategoriesHelp = driver.FindElement(By.XPath("//*[@id=\"tab - link - adding - terms\"]/a"));
            this.addCategoriesTextHelp = driver.FindElement(By.Id("tab-panel-adding-terms"));
            this.documentationHelp = driver.FindElement(By.XPath("//*[@id=\"contextual - help - columns\"]/div[2]/p[2]/a"));
            this.forumHelp = driver.FindElement(By.XPath("//*[@id=\"contextual - help - columns\"]/div[2]/p[3]/a"));
            this.rightPanelHelp = driver.FindElement(By.XPath("//*[@id=\"contextual - help - columns\"]/div[2]"));
            this.editCategoryToFind = driver.FindElement(By.Id("tag-search-input"));
            this.btnFindCategory = driver.FindElement(By.Id("search-submit"));
            this.checkBoxSelectAll_upper = driver.FindElement(By.Id("cb-select-all-1"));
            this.checkBoxSelectAll_lower = driver.FindElement(By.Id("cb-select-all-2"));
            this.sortByName_upper = driver.FindElement(By.XPath("//*[@id=\"name\"]/a/span[2]"));
            this.sortByName_lower = driver.FindElement(By.XPath("//*[@id=\"posts - filter\"]/table/tfoot/tr/th[1]/a/span[2]"));
            this.sortByURL_upper = driver.FindElement(By.XPath("//*[@id=\"slug\"]/a/span[2]"));
            this.sortByURL_lower = driver.FindElement(By.XPath("//*[@id=\"posts - filter\"]/table/tfoot/tr/th[3]/a/span[2]"));
            this.actionSelector_upper = driver.FindElement(By.Id("bulk-action-selector-top"));
            this.apply_upper = driver.FindElement(By.Id("doaction"));
            this.actionSelector_lower = driver.FindElement(By.Id("bulk-action-selector-bottom"));
            this.apply_lower = driver.FindElement(By.Id("doaction2"));
            this.numberOfElements_upper = driver.FindElement(By.XPath("//*[@id=\"posts - filter\"]/div[1]/div[2]/span[1]"));
            this.numberOfElements_lower = driver.FindElement(By.XPath("//*[@id=\"posts - filter\"]/div[2]/div[2]/span[1]"));
            this.transformCategoryInMarkURL = driver.FindElement(By.XPath("//*[@id=\"col - right\"]/div/div/p[2]/a"));
            this.descriptionBox = driver.FindElement(By.XPath("//*[@id=\"col-right\"]/div/div"));
            this.version = driver.FindElement(By.Id("footer-upgrade"));
        }
    }
}
