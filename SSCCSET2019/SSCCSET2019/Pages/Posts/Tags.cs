using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

using System;
using System.Collections.Generic;
using System.Linq;

namespace SSCCSET2019.Pages.Tags
{
    class Tags
    {
        private IWebDriver driver;
        protected IWebElement actionSelector;
        protected IWebElement doActionButton;
        protected IWebElement checkBoxAll;
        protected IWebElement nameSortingIndicator;
        protected IWebElement descriptionSortingIndicator;
        protected IWebElement slugSortingIndicator;
        protected IWebElement countSortingIndicator;
        protected IWebElement searchBoxTags;
        protected IWebElement searchTagsButton;
        protected IWebElement textUnderBottonBulkAction;
        protected IWebElement convertHyperlink;
        protected IWebElement displayingNumberOfTags;
        protected IWebElement nameOfVersion;
        protected IWebElement screenOptionsDropDown;
        protected IWebElement helpDropDown;
        protected IWebElement nameEdit;
        protected IWebElement slugEdit;
        protected IWebElement descriptionEdit;
        protected IWebElement addNewTagButton;
        protected IWebElement tagsLabel;
        protected IWebElement addNewTagLabel;
        protected IWebElement nameLabel;
        protected List<IWebElement> listOfAddedTags;
        protected IWebElement tagsTable;

        public Tags(IWebDriver driver)
        {
            this.driver = driver;
            actionSelector = driver.FindElement(By.Id("bulk-action-selector-top"));
            doActionButton = driver.FindElement(By.Id("doaction"));
            checkBoxAll = driver.FindElement(By.Id("cb-select-all-1"));
            displayingNumberOfTags = driver.FindElement(By.ClassName("displaying-num"));
            nameOfVersion = driver.FindElement(By.Id("footer-upgrade"));
            tagsTable = driver.FindElement(By.Id("the-list"));
            listOfAddedTags = tagsTable.FindElements(By.TagName("tr")).ToList();
            countSortingIndicator = driver.FindElement(By.TagName("thead")).FindElement(By.Id("posts"));
            slugSortingIndicator = driver.FindElement(By.TagName("thead")).FindElement(By.Id("slug"));
            descriptionSortingIndicator = driver.FindElement(By.TagName("thead")).FindElement(By.Id("description"));
            nameSortingIndicator = driver.FindElement(By.TagName("thead")).FindElement(By.Id("name"));
            searchBoxTags = driver.FindElement(By.Id("tag-search-input"));
            searchTagsButton = driver.FindElement(By.Id("search-submit"));
            textUnderBottonBulkAction = driver.FindElement(By.XPath(@"//*[@id='col-right']/div/div/p"));
            convertHyperlink = driver.FindElement(By.CssSelector("div.form-wrap:nth-child(2) > p:nth-child(1) > a:nth-child(1)"));
            screenOptionsDropDown = driver.FindElement(By.Id("show-settings-link"));
            helpDropDown = driver.FindElement(By.Id("contextual-help-link-wrap"));
            nameEdit = driver.FindElement(By.Id("tag-name"));
            slugEdit = driver.FindElement(By.Id("tag-slug"));
            descriptionEdit = driver.FindElement(By.Id("tag-description"));
            addNewTagButton = driver.FindElement(By.Id("submit"));
            tagsLabel = driver.FindElement(By.ClassName("wp-heading-inline"));
            addNewTagLabel = driver.FindElement(By.XPath("//*[@id='col-left']/div/div/h2"));
            nameLabel = driver.FindElement(By.XPath("//*[@id='addtag']/div[1]/label"));
        }

        public void ClearSearchTagsBox()
        {
            searchBoxTags.Clear();
        }
        public Tags ClickSearchTagsButton()
        {
            searchTagsButton.Click();
            return this;
        }
        public void InputSearchTagsBox(string searchedTag)
        {
            searchBoxTags.SendKeys(searchedTag);
        }
        public void ClickSearchTagsBox()
        {
            searchBoxTags.Click();
        }
        public Tags ClickDoActionButton()
        {
            doActionButton.Click();
            return this;
        }
        public Tags ClickNameSortingIndicator()
        {
            nameSortingIndicator.Click();
            return this;
        }
        public Tags ClickTDescriptionSortingIndicator()
        {
            descriptionSortingIndicator.Click();
            return this;
        }
        public Tags ClickTSlugSortingIndicator()
        {
            slugSortingIndicator.Click();
            return this;
        }
        public Tags ClickCountSortingIndicator()
        {
            countSortingIndicator.Click();
            return this;
        }
        public void Click‘ctionSelector()
        {
            actionSelector.Click();
        }
        public string ClickHyperLink()
        {
            convertHyperlink.Click();
            return "http://localhost/wordpress/wp-admin/import.php";
        }
        public string ClickGetVersionLink()
        {
            nameOfVersion.Click();
            return "http://localhost/wordpress/wp-admin/update-core.php";
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
        public void ClickAddNewTagButton()
        {
            addNewTagButton.Click();
        }
        public void ClickCheckAll()
        {
            checkBoxAll.Click();
        }
    }
}
