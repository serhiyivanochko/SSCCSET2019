using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SSCCSET2019;
namespace SSCCSET2019.Pages.Posts

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
        IWebElement checkbox;
        List<IWebElement> colList;

        public AddedTags(IWebElement tagColumn, IWebDriver driver)
        {
            this.tagColumn = tagColumn;
            this.driver = driver;
            checkbox = driver.FindElement(By.XPath("//input[@type='checkbox']"));
            colList = InitializeColList(tagColumn.FindElements(By.TagName("td")));
            descriptionTextElement = colList[1];
            slugTextElement = colList[2];
            countTagsElement = colList[3];
            tagNameElement = colList[0];
            editTagsButton = tagColumn.FindElement(By.ClassName("edit"));
            quickEditButton = tagColumn.FindElement(By.ClassName("inline"));
            deleteButton = tagColumn.FindElement(By.ClassName("delete")); ;
            viewButton = tagColumn.FindElement(By.ClassName("view"));
        }

        public void SetActiveActionButton()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(tagColumn.FindElement(By.ClassName("name"))).Perform();
        }
        private List<IWebElement> InitializeColList(IReadOnlyCollection<IWebElement> elements)
        {
            List<IWebElement> tags = new List<IWebElement>();
            foreach (var record in elements)
            {
                tags.Add(record);
            }
            return tags;
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

        public EditTags EditTagsClick()
        {
            editTagsButton.Click();
            return new EditTags(driver);
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



    }
}