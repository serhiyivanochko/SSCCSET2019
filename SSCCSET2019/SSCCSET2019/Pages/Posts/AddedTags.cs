using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SSCCSET2019;
namespace SSCCSET2019.Pages.Posts.AddedTags

{
    class AddedTags
    {
        IWebDriver driver;
        IWebElement descriptionTextElement;
        IWebElement slugTextElement;
        IWebElement countTagsElement;
        IWebElement tagNameElement;
        IWebElement editTagsButton;
        IWebElement quickEditButton;
        IWebElement deleteButton;
        IWebElement viewButton;
        IWebElement tagColumn;

        public AddedTags(IWebElement tagColumn, IWebDriver driver)
        {
            this.tagColumn = tagColumn;
            this.driver = driver;
            descriptionTextElement = FindDescriptionTextElement();
            slugTextElement = tagColumn.FindElement(By.ClassName("slug column-slug"));
            countTagsElement = tagColumn.FindElement(By.ClassName("posts column-posts"));
            tagNameElement = tagColumn.FindElement(By.ClassName("row-title"));
            editTagsButton = tagColumn.FindElement(By.ClassName("edit"));
            quickEditButton = tagColumn.FindElement(By.ClassName("inline hide-if-no-js"));
            deleteButton = tagColumn.FindElement(By.ClassName("delete")); ;
            viewButton = tagColumn.FindElement(By.ClassName("view"));
        }

        public void SetActiveActionButton()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(tagColumn.FindElement(By.ClassName("name column-name has-row-actions column-primary")));
        }

        public string GetSlugText()
        {
            return slugTextElement.Text;
        }
        public string GetCountOfTags()
        {
            return countTagsElement.Text;
        }
        public string GetTagsName()
        {
            return tagNameElement.Text;
        }
        public string GetDescriptionText()
        {
            return descriptionTextElement.Text;
        }

        public void EditTagsClick()
        {
            editTagsButton.Click();
        }
        public void QuickEditTagsClick()
        {
            quickEditButton.Click();
        }
        public void DeleteTagsClick()
        {
            deleteButton.Click();
        }
        public void ViewTagsClick()
        {
            viewButton.Click();
        }

        private IWebElement FindDescriptionTextElement()
        {
            IWebElement descriptionText;
            try
            {
                descriptionText = tagColumn.FindElement(By.TagName("p"));
            }
            catch (NoSuchElementException)
            {
               descriptionText = tagColumn.FindElement(By.ClassName("description column-description")).FindElement(By.ClassName("screen-reader-text)"));
            }
            return descriptionText;
        }
    }
}
