using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SSCCSET2019.Pages.Posts

{
    class AddedTags
    {
        private IWebDriver driver;
        private IWebElement descriptionTextElement;
        private IWebElement slugTextElement;
        private IWebElement countTagsElement;
        private IWebElement tagNameElement;
        private IWebElement editTagsButton;
        private IWebElement quickEditButton;
        private IWebElement deleteButton;
        private IWebElement viewButton;
        private IWebElement tagColumn;
        private IWebElement checkbox;
        private List<IWebElement> colList;

        public AddedTags(IWebElement tagColumn, IWebDriver driver)
        {
            this.tagColumn = tagColumn;
            this.driver = driver;
            checkbox = driver.FindElement(By.XPath("//*[@name='delete_tags[]']"));
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

        public AddedTags CheckCheckbox()
        {
            checkbox.Click();
            return this;
        }
        public EditTags EditTagsClick()
        {
            editTagsButton.Click();
            return new EditTags(driver);
        }
        public AddedTags QuickEditTagsClick()
        {
            quickEditButton.Click();
            return this;
        }
        public AddedTags DeleteTagsClick()
        {
            deleteButton.Click();
            return this;
        }
        public AddedTags ViewTagsClick()
        {
            viewButton.Click();
            return this;
        }





    }
}
