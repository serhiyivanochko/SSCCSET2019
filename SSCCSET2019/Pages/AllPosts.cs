using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace SSCCSET2019.Pages
{
    public class AllPosts
    {
        IWebDriver driver = new ChromeDriver();
        IWebElement postsLabel;
        IWebElement addNewButton;
        IWebElement screenOptionsDropDown;
        IWebElement helpDropDown;
        IWebElement bulkActionSelectorDown;
        IWebElement applyButton;

        public AllPosts()
        {
            postsLabel = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/h1"));
            addNewButton = driver.FindElement(By.XPath("//*[@id='wpbody-content']/div[3]/a"));
            screenOptionsDropDown = driver.FindElement(By.Id("show-settings-link"));
            helpDropDown = driver.FindElement(By.Id("contextual-help-link"));
            bulkActionSelectorDown = driver.FindElement(By.Id("bulk-action-selector-bottom"));
            applyButton = driver.FindElement(By.Id("doaction2"));            
        }


        public string GetPostLabel()
        {
            return postsLabel.Text;

        }

        public string ClickAddNewButton()
        {
            return driver.Url;
        }

        public string GetNameAddNewButton()
        {
            return addNewButton.Text;
        }

        public string ClickApplyButton()
        {
            return driver.Url;
        }



    }
}
