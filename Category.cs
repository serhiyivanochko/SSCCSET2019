using System;
using OpenQA.Selenium;
namespace SSCCSET2019.Pages.Notes
{
    class Category
    {
        private IWebDriver driver;

        private IWebElement CheckBox;
        private IWebElement Title;
        private IWebElement Edit;
        private IWebElement Property;
        private IWebElement Delete;
        private IWebElement Review;
        private IWebElement PartOfLink;

        public Category(IWebDriver driver,string id)
        {
            this.driver = driver;
            CheckBox =driver.FindElement(By.Id("cb-select-"+id[id.Length-1]));
            Title = driver.FindElement(By.XPath(String.Format("//*[@id=\"%s\"]/td[1]/strong/a", id)));
            Edit = driver.FindElement(By.XPath(String.Format("//*[@id=\"%s\"]/td[1]/div[2]/span[1]/a", id)));
            Delete = driver.FindElement(By.XPath(String.Format("//*[@id=\"%s\"]/td[1]/div[2]/span[3]/button", id)));
            Review = driver.FindElement(By.XPath(String.Format("//*[@id=\"%s\"]/td[1]/div[2]/span[4]/a", id)));
            Property = driver.FindElement(By.XPath(String.Format("//*[@id=\"%s\"]/td[1]/div[2]/span[2]/a", id)));
            PartOfLink = driver.FindElement(By.XPath(String.Format("//*[@id=\"%s\"]/td[3]", id))); 
        }
    }
}
