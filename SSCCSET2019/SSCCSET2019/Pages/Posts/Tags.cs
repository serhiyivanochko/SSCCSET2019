using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace SSCCSET2019.Pages.Tags
{
    class Tags
    {
        private IWebDriver driver;

        protected IWebElement actionSelectorTop;
        protected IWebElement actionSelectorBotton;
        protected IWebElement doActionTopButton;
        protected IWebElement doActionBottonButton;
        protected IWebElement checkBoxAllTop;
        protected IWebElement checkBoxAllBotton;
        protected IWebElement nameSortingIndicatorTop;
        protected IWebElement descriptionSortingIndicatorTop;
        protected IWebElement slugSortingIndicatorTop;
        protected IWebElement countSortingIndicatorTop;
        protected IWebElement nameSortingIndicatorBotton;
        protected IWebElement descriptionSortingIndicatorBotton;
        protected IWebElement slugSortingIndicatorBotton;
        protected IWebElement countSortingIndicatorBotton;
        protected IWebElement searchBoxTags;
        protected IWebElement searchTagsButton;
        protected IWebElement textUnderBottonBulkAction;
        protected IWebElement noItemsLabel;
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
        protected IWebElement textUnderTheNameLabel;
        protected IWebElement textUnderTheSlugLabel;
        protected IWebElement textUnderTheDescriptionLabel;

        protected List<IWebElement> listOfAddedTags;
        protected IWebElement tagsTable;

        public Tags(IWebDriver driver)
        {
            this.driver = driver;

            actionSelectorTop = driver.FindElement(By.Id("bulk-action-selector-top"));
            doActionTopButton = driver.FindElement(By.Id("doaction1"));
            actionSelectorBotton = driver.FindElement(By.Id("bulk - action - selector - bottom"));
            doActionBottonButton = driver.FindElement(By.Id("doaction2"));
            checkBoxAllBotton = driver.FindElement(By.Id("cb - select - all - 2"));
            checkBoxAllTop = driver.FindElement(By.Id("cb - select - all - 1"));

            countSortingIndicatorBotton = driver.FindElement(By.TagName("thead")).FindElement(By.Id("posts"));
            slugSortingIndicatorBotton = driver.FindElement(By.TagName("thead")).FindElement(By.Id("slug"));
            descriptionSortingIndicatorBotton = driver.FindElement(By.TagName("thead")).FindElement(By.Id("description"));
            nameSortingIndicatorBotton = driver.FindElement(By.TagName("thead")).FindElement(By.Id("name"));
            displayingNumberOfTags = driver.FindElement(By.ClassName("displaying-num"));
            nameOfVersion = driver.FindElement(By.Id("footer-upgrade"));


            tagsTable = driver.FindElement(By.Id("the-list"));

            listOfAddedTags = tagsTable.FindElements(By.TagName("tr")).ToList();


            countSortingIndicatorTop = driver.FindElement(By.TagName("tfoot")).FindElement(By.Id("posts"));
            slugSortingIndicatorTop = driver.FindElement(By.TagName("tfoot")).FindElement(By.Id("slug"));
            descriptionSortingIndicatorTop = driver.FindElement(By.TagName("tfoot")).FindElement(By.Id("description"));
            nameSortingIndicatorTop = driver.FindElement(By.TagName("tfoot")).FindElement(By.Id("name"));

            searchBoxTags = driver.FindElement(By.Id("tag-search-input"));
            searchTagsButton = driver.FindElement(By.Id("search-submit"));

            textUnderBottonBulkAction = driver.FindElement(By.XPath(@"//*[@id='col - right']/div/div/p"));
            convertHyperlink = driver.FindElement(By.XPath(@"/html/body/div[2]/div[2]/div[2]/div[1]/div[3]/div[2]/div[2]/div/div/p/a"));

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

        public Tags ClickDoActionTopButton()
        {
            doActionTopButton.Click();
            return this;
        }

        public Tags ClickDoActionBottonButton()
        {
            doActionBottonButton.Click();
            return this;
        }

        public Tags ClickTopNameSortingIndicator()
        {
            nameSortingIndicatorTop.Click();
            return this;
        }
        public Tags ClickTopDescriptionSortingIndicator()
        {
            descriptionSortingIndicatorTop.Click();
            return this;
        }
        public Tags ClickTopSlugSortingIndicator()
        {
            slugSortingIndicatorTop.Click();
            return this;
        }
        public Tags ClickTopCountSortingIndicator()
        {
            countSortingIndicatorTop.Click();
            return this;
        }
        public Tags ClickBottonNameSortingIndicator()
        {
            nameSortingIndicatorBotton.Click();
            return this;
        }
        public Tags ClickBottonDescriptionSortingIndicator()
        {
            descriptionSortingIndicatorBotton.Click();
            return this;
        }
        public Tags ClickBottonSlugSortingIndicator()
        {
            slugSortingIndicatorBotton.Click();
            return this;
        }
        public Tags ClickBottonCountSortingIndicator()
        {
            countSortingIndicatorBotton.Click();
            return this;
        }

        public void ClickTopActionSelector()
        {
            actionSelectorTop.Click();
        }

        public void ClickBottonActionSelector()
        {
            actionSelectorBotton.Click();
        }

        public void ClickHyperLink()
        {
            convertHyperlink.Click();
        }

        public void ClickGetVersionLink()
        {
            nameOfVersion.Click();
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

        public void ClickCheckAll()
        {
            checkBoxAllTop.Click();
        }
    }

}
