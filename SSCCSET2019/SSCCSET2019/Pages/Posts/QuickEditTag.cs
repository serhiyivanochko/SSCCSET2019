using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SSCCSET2019.Pages.Posts
{
    class QuickEditTag
    {
        private IWebDriver driver;
        private IWebElement inputName;
        private IWebElement inputSlug;
        private IWebElement cancelButton;
        private IWebElement updateTagButton;

        public QuickEditTag(IWebDriver driver)
        {
            this.driver = driver;
            inputSlug = driver.FindElement(By.CssSelector(".wp-list-table.widefat.fixed.striped.tags")).FindElement(By.XPath("//*[@name='slug']"));
            cancelButton = driver.FindElement(By.CssSelector(".cancel.button.alignleft"));
            inputName = driver.FindElement(By.XPath("//*[@name='name']"));
            updateTagButton = driver.FindElement(By.CssSelector(".save.button.button-primary.alignright"));
        }
        public Tags ClickCancelButton()
        {
            cancelButton.Click();
            return new Tags(driver);
        }
        public QuickEditTag ClickUpdateTagButton()
        {
            updateTagButton.Click();
            return this;
        }
        public QuickEditTag ClearInputName()
        {
            inputName.Clear();
            return this;
        }
        public QuickEditTag ClearInputSlug()
        {
            inputSlug.Clear();
            return this;
        }
        public QuickEditTag EditInputName(string newName)
        {
            inputName.SendKeys(newName);
            return this;
        }
        public QuickEditTag EditInputSlug(string newSlug)
        {
            inputSlug.SendKeys(newSlug);
            return this;
        }
        public QuickEditTag ClickInputName()
        {
            inputName.Click();
            return this;
        }
        public QuickEditTag ClickInputSlug()
        {
            inputSlug.Click();
            return this;
        }
    }
}