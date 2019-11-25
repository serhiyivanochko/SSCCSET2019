using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SSCCSET2019.Pages.Posts;

namespace SSCCSET2019.Pages.Posts.QuickEditTag
{
    class QuikEditTag : Tags
    {
        IWebDriver driver;

        IWebElement quickEditLabel;
        IWebElement nameLabel;
        IWebElement slugLabel;
        IWebElement inputName;
        IWebElement inputSlug;
        IWebElement cancelButton;
        IWebElement updateTagButton;


        public QuikEditTag(IWebDriver driver) : base(driver)
        {
            quickEditLabel = driver.FindElement(By.XPath("//*[@id='edit-2']/td/fieldset/legend"));
            nameLabel = driver.FindElement(By.XPath("//*[@id='edit-2']/td/fieldset/div/label[1]/span[1]"));
            slugLabel = driver.FindElement(By.XPath("//*[@id='edit-2']/td/fieldset/div/label[2]/span[1]"));
            inputName = driver.FindElement(By.XPath("//*[@id='edit-2']/td/fieldset/div/label[1]/span[2]/input"));
            inputSlug = driver.FindElement(By.XPath("//*[@id='edit-2']/td/fieldset/div/label[2]/span[2]/input"));
            cancelButton = driver.FindElement(By.XPath("//*[@id='edit-2']/td/div/button[1]"));
            updateTagButton = driver.FindElement(By.XPath("//*[@id='edit-2']/td/div/button[2]"));
        }

        public Tags ClickCancelButton()
        {
            cancelButton.Click();
            return new Tags(driver);
        }
        public QuikEditTag ClickUpdateTagButton()
        {
            updateTagButton.Click();
            return this;
        }

        public QuikEditTag ClearInputName()
        {
            inputName.Clear();
            return this;
        }

        public QuikEditTag ClearInputSlug()
        {
            inputSlug.Clear();
            return this;
        }

        public QuikEditTag EditInputName(string newName)
        {
            inputName.SendKeys(newName);
            return this;
        }

        public QuikEditTag EditInputSlug(string newSlug)
        {
            inputSlug.SendKeys(newSlug);
            return this;
        }

        public QuikEditTag ClickInputName()
        {
            inputName.Click();
            return this;
        }

        public QuikEditTag ClickInputSlug()
        {
            inputSlug.Click();
            return this;
        }
    }
}
