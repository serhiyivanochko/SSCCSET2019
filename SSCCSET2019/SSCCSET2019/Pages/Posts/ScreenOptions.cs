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
    class ScreenOptions : Tags
    {
        private IWebDriver driver;

        protected IWebElement columnsLabel;
        protected IWebElement descriptionCheckBox;
        protected IWebElement descriptionCheckBoxLabel;
        protected IWebElement slugCheckBox;
        protected IWebElement slugCheckBoxLabel;
        protected IWebElement countCheckBox;
        protected IWebElement countCheckBoxLabel;
        protected IWebElement paginationLabel;
        protected IWebElement numberOfItemsPerPageLabel;
        protected IWebElement editPostNumber;
        protected IWebElement applyButton;

        public ScreenOptions(IWebDriver driver) : base(driver)
        {
            columnsLabel = driver.FindElement(By.XPath("//*[@id='adv - settings']/fieldset[1]/legend"));
            descriptionCheckBox = driver.FindElement(By.XPath("//*[@id='description - hide']"));
            descriptionCheckBoxLabel = driver.FindElement(By.XPath("//*[@id='adv - settings']/fieldset[1]/label[1]"));
            slugCheckBox = driver.FindElement(By.XPath("//*[@id='slug - hide']"));
            slugCheckBoxLabel = driver.FindElement(By.XPath("//*[@id='adv - settings']/fieldset[1]/label[2]"));
            countCheckBox = driver.FindElement(By.XPath("//*[@id='posts - hide']"));
            countCheckBoxLabel = driver.FindElement(By.XPath("//*[@id='adv - settings']/fieldset[1]/label[3]"));
            paginationLabel = driver.FindElement(By.XPath("//*[@id='adv - settings']/fieldset[2]/legend"));
            numberOfItemsPerPageLabel = driver.FindElement(By.XPath("//*[@id='adv - settings']/fieldset[2]/label"));
            editPostNumber = driver.FindElement(By.XPath("//*[@id='edit_post_tag_per_page']"));
            applyButton = driver.FindElement(By.XPath("//*[@id='screen - options - apply']"));


        }

        public string GetColumnsLabel()
        {
            return columnsLabel.Text;
        }

        public string GetPaginationLabel()
        {
            return paginationLabel.Text;
        }

        public string GetNumberOfItemsPerPageLabel()
        {
            return numberOfItemsPerPageLabel.Text;
        }

        public void ClickApplyButton()
        {
            applyButton.Click();
        }
    }
}
