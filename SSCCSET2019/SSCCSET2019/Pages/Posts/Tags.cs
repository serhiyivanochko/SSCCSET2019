using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SSCCSET2019.Pages.Posts
{
    class Tags
    {
       private IWebDriver driver;

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

        public Tags(IWebDriver driver)
        {
            this.driver = driver;

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

        public void ClickScreenOptionsDropDown()
        {
            screenOptionsDropDown.Click();
        }

        public void ClickHelpDropDown()
        {
            helpDropDown.Click();
        }

        public void ClickAddNewTagButton()
        {
            addNewTagButton.Click();
        }
    }
} 