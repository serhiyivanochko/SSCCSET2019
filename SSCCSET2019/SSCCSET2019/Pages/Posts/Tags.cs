using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using SSCCSET2019.Pages.Posts.AddedTags;

namespace SSCCSET2019.Pages.Tags
{
    class Tags
    {
        private IWebDriver driver;
        private IWebElement actionSelector;
        private IWebElement doActionButton;
        private IWebElement checkBoxAll;
        private IWebElement nameSortingIndicator;
        private IWebElement descriptionSortingIndicator;
        private IWebElement slugSortingIndicator;
        private IWebElement countSortingIndicator;
        private IWebElement searchBoxTags;
        private IWebElement searchTagsButton;
        private IWebElement textUnderBottonBulkAction;
        private IWebElement convertHyperlink;
        private IWebElement displayingNumberOfTags;
        private IWebElement nameOfVersion;
        private IWebElement screenOptionsDropDown;
        private IWebElement helpDropDown;
        private IWebElement nameEdit;
        private IWebElement slugEdit;
        private IWebElement descriptionEdit;
        private IWebElement addNewTagButton;
        private IWebElement tagsLabel;
        private IWebElement addNewTagLabel;
        private IWebElement nameLabel;
        private IWebElement tagsTable;
        private SelectElement elementAction;
        public List<AddedTags> listOfAddedTags;

        public Tags(IWebDriver driver)
        {
            this.driver = driver;
            elementAction = new SelectElement(driver.FindElement(By.Id("bulk-action-selector-top")));
            actionSelector = driver.FindElement(By.Id("bulk-action-selector-top"));
            doActionButton = driver.FindElement(By.Id("doaction"));
            checkBoxAll = driver.FindElement(By.Id("cb-select-all-1"));
            displayingNumberOfTags = driver.FindElement(By.ClassName("displaying-num"));
            nameOfVersion = driver.FindElement(By.Id("footer-upgrade"));
            tagsTable = driver.FindElement(By.Id("the-list"));
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
            listOfAddedTags = CheckEnabledTags();
        }

        private List<AddedTags> CheckEnabledTags()
        {
            try
            {
                driver.FindElement(By.ClassName("no-items"));
                return null;
            }
            catch (NoSuchElementException)
            {
                return InitializeTagsList(tagsTable.FindElements(By.TagName("tr")).ToList());
         
            }
        }
        private List<AddedTags> InitializeTagsList(IReadOnlyCollection<IWebElement> elements)
        {
            List<AddedTags> tags = new List<AddedTags>();
            foreach (var record in elements)
            {
                tags.Add(new AddedTags(record, driver));
            }
            return tags;
        }
        public Tags DeleteActionClick()
        {
            elementAction.SelectByText("Delete");
            return this;
        }
        public Tags ClearSearchTagsBox()
        {
            searchBoxTags.Clear();
            return this;
        }
        public Tags ClickSearchTagsButton()
        {
            searchTagsButton.Click();
            return this;
        }
        public Tags InputSearchTagsBox(string searchedTag)
        {
            searchBoxTags.SendKeys(searchedTag);
            return this;
        }
        public Tags ClickSearchTagsBox()
        {
            searchBoxTags.Click();
            return this;
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
        public Tags ClickDescriptionSortingIndicator()
        {
            descriptionSortingIndicator.Click();
            return this;
        }
        public Tags ClickSlugSortingIndicator()
        {
            slugSortingIndicator.Click();
            return this;
        }
        public Tags ClickCountSortingIndicator()
        {
            countSortingIndicator.Click();
            return this;
        }
        public Tags ClickActionSelector()
        {
            actionSelector.Click();
            return this;
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
        public Tags ClickAddNewTagButton()
        {
            addNewTagButton.Click();
            return this;
        }
        public Tags ClickCheckAll()
        {
            checkBoxAll.Click();
            return this;
        }
        public Tags InputName(string tagName)
        {
            nameEdit.SendKeys(tagName);
            return this;
        }
        public Tags InputSlug(string slug)
        {
            slugEdit.SendKeys(slug);
            return this;
        }
        public Tags InputDescription(string description)
        {
            descriptionEdit.SendKeys(description);
            return this;
        }
        public Tags ClearNameEdit()
        {
            nameEdit.Clear();
            return this;
        }
        public Tags ClearSlugEdit()
        {
            slugEdit.Clear();
            return this;
        }
        public Tags ClearDescriptionEdit()
        {
            descriptionEdit.Clear();
            return this;
        }
        public Tags ClickNameEdit()
        {
            nameEdit.Click();
            return this;
        }
        public Tags ClickSlugEdit()
        {
            slugEdit.Click();
            return this;
        }
        public Tags ClickDescriptionEdit()
        {
            descriptionEdit.Click();
            return this;
        }
    }
}
