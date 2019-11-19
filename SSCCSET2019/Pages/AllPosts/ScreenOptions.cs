
using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace SSCCSET2019.Pages
{
    public class ScreenOptionsDropDown : AllPosts
    {

        IWebDriver driver;
        IWebElement authorCheckBox;
        IWebElement categoriesCheckBox;
        IWebElement tagsCheckBox;
        IWebElement commentsCheckBox;
        IWebElement dateCheckBox;
        IWebElement paginationLabel;
        IWebElement applyButtonSO;
        IWebElement listViewCheckbox;
        IWebElement excerptViewCheckbox;
        IWebElement numberOfItemsField;


        public ScreenOptionsDropDown(IWebDriver driver)
        {
            this.driver = driver; 
            authorCheckBox = driver.FindElement(By.Id("author-hide"));//
            categoriesCheckBox = driver.FindElement(By.Id("categories-hide"));//

            tagsCheckBox = driver.FindElement(By.Id("tags-hide"));//

            commentsCheckBox = driver.FindElement(By.Id("comments-hide"));
            dateCheckBox = driver.FindElement(By.Id("date-hide"));
            paginationLabel = driver.FindElement(By.XPath("//*[@id='adv - settings']/fieldset[2]/legend"));
            applyButton = driver.FindElement(By.Id("screen-options-apply"));
            listViewCheckbox = driver.FindElement(By.Id("list-view-mode"));
            excerptViewCheckbox = driver.FindElement(By.Id("excerpt-view-mode"));

            numberOfItemsField = driver.FindElement(By.Id("edit_post_per_page"));



        }


        public ScreenOptionsDropDown ClickAuthorCheckBox()
        {
            authorCheckBox.Click();
            return this;
        }

        public bool GetAuthorCheckBoxValue()
        {
            return this.authorCheckBox.Selected;
        }

        public ScreenOptionsDropDown ClickTagsCheckBox()
        {
            tagsCheckBox.Click();
            return this;
        }

        public bool GetTagsCheckBoxValue()
        {
            return this.tagsCheckBox.Selected;
        }

        public ScreenOptionsDropDown ClickCategoriesCheckBox()
        {
            categoriesCheckBox.Click();
            return this;
        }

        public bool GetCategoriesCheckBoxValue()
        {
            return this.categoriesCheckBox.Selected;
        }




        public ScreenOptionsDropDown ClickCommentsCheckBox()
        {
            commentsCheckBox.Click();
            return this;
        }

        public bool GetCommentsCheckBoxValue()
        {
            return this.commentsCheckBox.Selected;
        }

        public ScreenOptionsDropDown ClickDateCheckBox()
        {
            dateCheckBox.Click();
            return this;
        }

        public bool GetDateCheckBoxValue()
        {
            return this.dateCheckBox.Selected;
        }

        public ScreenOptionsDropDown ClickPaginationLabel()
        {
            paginationLabel.Click();
            return this;
        }

        public ScreenOptionsDropDown ClickApplyButtonSO()
        {
            applyButtonSO.Click();
            return this;
        }

        public ScreenOptionsDropDown ClickListViewCheckbox()
        {
            listViewCheckbox.Click();
            return this;
        }

        public bool GetListViewCheckbox()
        {
            return this.listViewCheckbox.Selected;
        }

        public ScreenOptionsDropDown ClickExcerptViewCheckbox()
        {
            excerptViewCheckbox.Click();
            return this;
        }

        public bool GetExcerptViewCheckbox()
        {
            return this.excerptViewCheckbox.Selected;
        }

        public ScreenOptionsDropDown NumberOfItemsFieldUp()
        {
            numberOfItemsField.SendKeys(Keys.Up);

            return this;
        }

        public ScreenOptionsDropDown NumberOfItemsFieldDown()
        {
            numberOfItemsField.SendKeys(Keys.Down);

            return this;
        }

    }
}
