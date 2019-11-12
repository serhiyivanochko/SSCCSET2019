using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace SSCCSET2019.Pages
{
    public class AllPosts
    {
        IWebDriver driver;


        protected IWebElement postsLabel;
        protected IWebElement addNewButton;

        protected IWebElement screenOptionsDropDown;
        protected IWebElement helpDropDown;

         protected IWebElement applyButton;

        protected IWebElement searchTextField;
        protected IWebElement searchButton;

        protected SelectElement bulkActionSelectorDown;
       



        public AllPosts(IWebDriver driver)
        {
             this.driver =driver;

            postsLabel = driver.FindElement(By.ClassName("wp-heading-inline"));
            addNewButton = driver.FindElement(By.ClassName("page-title-action"));

            screenOptionsDropDown = driver.FindElement(By.Id("show-settings-link"));

            helpDropDown = driver.FindElement(By.Id("contextual-help-link"));

            applyButton = driver.FindElement(By.Id("doaction2"));
            searchTextField = driver.FindElement(By.Id("post-search-input"));
            searchButton = driver.FindElement(By.Id("search-submit"));
            bulkActionSelectorDown = new SelectElement(driver.FindElement(By.Id("bulk-action-selector-bottom")));


        }


        public string GetPostLabel()
        {
            return postsLabel.Text;

        }

        public AllPosts ClickPostLabel()
        {
            postsLabel.Click();
            return this;

        }



        public AllPosts ClickAddNewButton()
        {
            addNewButton.Click();
            return this;
        }

        public AllPosts ClickApplyButton()
        {
            applyButton.Click();
            return this;
        }

        public AllPosts ClickSearchButton()
        {
            searchButton.Click();
            return this;
        }

        public AllPosts SetTextInSearchTextField(string text)
        {
            searchTextField.SendKeys(text);
            return this;
        }

        public string GetNameAddNewButton()
        {
            return addNewButton.Text;
        }

   

        public List<string> GetListOfBulkSelector()
        {
            List<string> list = new List<string>();
            foreach (var current in this.bulkActionSelectorDown.Options)
            {
                list.Add(current.Text);
            }
            return list;
        }

        public AllPosts SetaBulkActionSelectorValue(string value)
        {
            bulkActionSelectorDown.DeselectByValue(value);
            return this;
        }



    }
}
