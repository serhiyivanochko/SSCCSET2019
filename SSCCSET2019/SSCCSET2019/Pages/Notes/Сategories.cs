using OpenQA.Selenium;
namespace SSCCSET2019.Pages.Notes
{
    class Сategories
    {
        IWebDriver driver;


        IWebElement name = driver.FindElement(By.Id("tag-name"));
        IWebElement nameDescription = driver.FindElement(By.Id("//*[@id=\"addtag\"]/div[1]/p"));
        IWebElement partOfURL = driver.FindElement(By.Id("tag-slug"));
        IWebElement partOfURLDescription = driver.FindElement(By.Id("//*[@id=\"addtag\"]/div[2]/p"));
        IWebElement fatherCategory = driver.FindElement(By.Id("postform"));
        IWebElement fatherCategoryDescription = driver.FindElement(By.Id("//*[@id=\"addtag\"]/div[3]/p"));
        IWebElement description = driver.FindElement(By.Id("tag-description"));
        IWebElement descriptionForDescription = driver.FindElement(By.XPath("//*[@id=\"addtag\"]/div[4]/p"));
        IWebElement submit = driver.FindElement(By.Id("submit"));
        IWebElement WordPressURL = driver.FindElement(By.XPath("//*[@id=/\"footer-thankyou\"]/a"));


        IWebElement screenSettings = driver.FindElement(By.Id("show-settings-link"));
        IWebElement column = driver.FindElement(By.XPath("//*[@id=\"adv - settings\"]/fieldset[1]/legend"));
        IWebElement includeDecription = driver.FindElement(By.Id("description-hide"));
        IWebElement includePartURL = driver.FindElement(By.Id("slug-hide"));
        IWebElement includeCount = driver.FindElement(By.Id("posts-hide"));
        IWebElement maxNumber = driver.FindElement(By.Id("edit_category_per_page"));
        IWebElement btnSubmitSettings = driver.FindElement(By.Id("screen-options-apply"));


        IWebElement help = driver.FindElement(By.Id("contextual-help-link"));
        IWebElement overviewHelp = driver.FindElement(By.XPath("//*[@id=\"tab - link - overview\"]/a"));
        IWebElement overviewHelp = driver.FindElement(By.Id("tab-panel-overview"));
        IWebElement addCategoriesHelp = driver.FindElement(By.XPath("//*[@id=\"tab - link - adding - terms\"]/a"));
        IWebElement addCategoriesTextHelp = driver.FindElement(By.Id("tab-panel-adding-terms"));
        IWebElement documentationHelp = driver.FindElement(By.XPath("//*[@id=\"contextual - help - columns\"]/div[2]/p[2]/a"));
        IWebElement forumHelp = driver.FindElement(By.XPath("//*[@id=\"contextual - help - columns\"]/div[2]/p[3]/a"));
        IWebElement rightPanelHelp = driver.FindElement(By.XPath("//*[@id=\"contextual - help - columns\"]/div[2]"));


        IWebElement editCategoryToFind = driver.FindElement(By.Id("tag-search-input"));
        IWebElement btnFindCategory = driver.FindElement(By.Id("search-submit"));


        IWebElement checkBoxSelectAll_upper = driver.FindElement(By.Id("cb-select-all-1"));
        IWebElement checkBoxSelectAll_lower = driver.FindElement(By.Id("cb-select-all-2"));
        IWebElement sortByName_upper = driver.FindElement(By.XPath("//*[@id=\"name\"]/a/span[2]"));
        IWebElement sortByName_lower = driver.FindElement(By.XPath("//*[@id=\"posts - filter\"]/table/tfoot/tr/th[1]/a/span[2]"));
        IWebElement sortByURL_upper = driver.FindElement(By.XPath("//*[@id=\"slug\"]/a/span[2]"));
        IWebElement sortByURL_lower = driver.FindElement(By.XPath("//*[@id=\"posts - filter\"]/table/tfoot/tr/th[3]/a/span[2]"));
        IWebElement actionSelector_upper = driver.FindElement(By.Id("bulk-action-selector-top"));
        IWebElement apply_upper = driver.FindElement(By.Id("doaction"));
        IWebElement actionSelector_lower = driver.FindElement(By.Id("bulk-action-selector-bottom"));
        IWebElement apply_lower = driver.FindElement(By.Id("doaction2"));
        IWebElement numberOfElements_upper = driver.FindElement(By.XPath("//*[@id=\"posts - filter\"]/div[1]/div[2]/span[1]"));
        IWebElement numberOfElements_lower = driver.FindElement(By.XPath("//*[@id=\"posts - filter\"]/div[2]/div[2]/span[1]"));


        IWebElement transformCategoryInMarkURL = driver.FindElement(By.XPath("//*[@id=\"col - right\"]/div/div/p[2]/a"));
        IWebElement descriptionBox = driver.FindElement(By.XPath("//*[@id=\"col-right\"]/div/div"));
        IWebElement version = driver.FindElement(By.Id("footer-upgrade"));

    }
}
