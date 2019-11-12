<<<<<<< HEAD
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace SSCCSET2019.Pages.Tags

{
    class Tags
    {
        IWebDriver driver;

        IWebElement bulkActionSelectorTop;
        IWebElement bulkActionSelectorBotton;
        IWebElement doActionTopButton;
        IWebElement doActionBottonButton;
        IWebElement checkBoxAllTop;
        IWebElement checkBoxAllBotton;
        IWebElement sortingIndicatorTop1;
        IWebElement sortingIndicatorTop2;
        IWebElement sortingIndicatorTop3;
        IWebElement sortingIndicatorTop4;
        IWebElement sortingIndicatorBotton1;
        IWebElement sortingIndicatorBotton2;
        IWebElement sortingIndicatorBotton3;
        IWebElement sortingIndicatorBotton4;
        IWebElement searchBoxTags;
        IWebElement searchTagsButton;
        IWebElement textUnderBottonBulkAction;
        IWebElement noItemsLabel;
        IWebElement hyperlink;

        List<IWebElement> listOfAddedTags;
        IWebElement tagsTable;

        IWebElement screenOptionsDropDown;
        IWebElement helpDropDown;
        IWebElement nameEdit;
        IWebElement slugEdit;
        IWebElement descriptionEdit;
        IWebElement addNewTagButton;
        IWebElement tagsLabel;
        IWebElement addNewTagLabel;
        IWebElement nameLabel;
        IWebElement textUnderTheNameLabel;
        IWebElement textUnderTheSlugLabel;
        IWebElement textUnderTheDescriptionLabel;


        public Tags(IWebDriver driver)
        {
            this.driver = driver;

            bulkActionSelectorTop = driver.FindElement(By.Id("bulk-action-selector-top"));
            doActionTopButton = driver.FindElement(By.Id("doaction1"));
            bulkActionSelectorBotton = driver.FindElement(By.Id("bulk - action - selector - bottom"));
            doActionBottonButton = driver.FindElement(By.Id("doaction2"));
            checkBoxAllBotton = driver.FindElement(By.Id("cb - select - all - 2"));
            checkBoxAllTop = driver.FindElement(By.Id("cb - select - all - 1"));

            sortingIndicatorBotton4 = driver.FindElement(By.TagName("thead")).FindElement(By.Id("posts"));
            sortingIndicatorBotton3 = driver.FindElement(By.TagName("thead")).FindElement(By.Id("slug"));
            sortingIndicatorBotton2 = driver.FindElement(By.TagName("thead")).FindElement(By.Id("description"));
            sortingIndicatorBotton1 = driver.FindElement(By.TagName("thead")).FindElement(By.Id("name"));


            tagsTable = driver.FindElement(By.Id("the-list"));

            listOfAddedTags = tagsTable.FindElements(By.TagName("tr")).ToList();


            sortingIndicatorTop4 = driver.FindElement(By.TagName("tfoot")).FindElement(By.Id("posts"));
            sortingIndicatorTop3 = driver.FindElement(By.TagName("tfoot")).FindElement(By.Id("slug"));
            sortingIndicatorTop2 = driver.FindElement(By.TagName("tfoot")).FindElement(By.Id("description"));
            sortingIndicatorTop1 = driver.FindElement(By.TagName("tfoot")).FindElement(By.Id("name"));

            searchBoxTags = driver.FindElement(By.Id("tag-search-input"));
            searchTagsButton = driver.FindElement(By.Id("search-submit"));

            textUnderBottonBulkAction = driver.FindElement(By.XPath(@"//*[@id='col - right']/div/div/p"));
            hyperlink = driver.FindElement(By.XPath(@"/html/body/div[2]/div[2]/div[2]/div[1]/div[3]/div[2]/div[2]/div/div/p/a"));

            screenOptionsDropDown = driver.FindElement(By.Id("show-settings-link"));
            helpDropDown = driver.FindElement(By.Id("contextual-help-link-wrap"));
            nameEdit = driver.FindElement(By.Id("tag-name"));
            slugEdit = driver.FindElement(By.Id("tag-slug"));
            descriptionEdit = driver.FindElement(By.Id("tag-description"));
            addNewTagButton = driver.FindElement(By.Id("submit"));
            tagsLabel = driver.FindElement(By.XPath("//*[@id='wpbody - content']/div[3]/h1"));
            addNewTagLabel = driver.FindElement(By.XPath("//*[@id='col - left']/div/div/h2"));
            nameLabel = driver.FindElement(By.XPath("//*[@id='addtag']/div[1]/label"));
            textUnderTheNameLabel = driver.FindElement(By.XPath("//*[@id='addtag']/div[1]/p"));
            textUnderTheSlugLabel = driver.FindElement(By.XPath("//*[@id='addtag']/div[2]/p"));
            textUnderTheDescriptionLabel = driver.FindElement(By.XPath("//*[@id='addtag']/div[3]/p"));
        }

        public void ClearSearchTagsBox()
        {
            searchBoxTags.Clear();
        }

        public void ClickSearchTagsButton()
        {
            searchTagsButton.Click();
        }

        public void InputSearchTagsBox(string searchedTag)
        {
            searchBoxTags.SendKeys(searchedTag);
        }

        public void ClickSearchTagsBox()
        {
            searchBoxTags.Click();
        }

        public void ClickDoActionTopButton()
        {
            doActionTopButton.Click();
        }

        public void ClickDoActionBottonButton()
        {
            doActionBottonButton.Click();
        }

        public string GetTagsLabel()
        {
            return tagsLabel.Text;
        }

        public string GetAddNewTagLabel()
        {
            return addNewTagLabel.Text;
        }

        public string GetNameLabel()
        {
            return nameLabel.Text;
        }

        public string GetTextUnderTheNameLabel()
        {
            return textUnderTheNameLabel.Text;
        }

        public string GetTextUnderTheSlugLabel()
        {
            return textUnderTheSlugLabel.Text;
        }

        public string GetTextUnderTheDescriptionLabel()
        {
            return textUnderTheDescriptionLabel.Text;
        }

        public void ClickAddNewTagButton()
        {
            addNewTagButton.Click();
        }

    }

}
