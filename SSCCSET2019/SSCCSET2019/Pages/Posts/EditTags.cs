using OpenQA.Selenium;

namespace SSCCSET2019.Pages.Posts
{
    class EditTags
    {
        IWebDriver driver;

        IWebElement nameLabel;
        IWebElement slugLabel;
        IWebElement descriptionLabel;
        IWebElement nameEdit;
        IWebElement slugEdit;
        IWebElement descriptionEdit;
        IWebElement updateButton;
        IWebElement deleteButton;

        public EditTags(IWebDriver driver)
        {
            this.driver = driver;
            nameLabel = driver.FindElement(By.XPath("//*[@id='edittag']/table/tbody/tr[1]/th/label"));
            slugLabel = driver.FindElement(By.XPath("//*[@id='edittag']/table/tbody/tr[2]/th/label"));
            descriptionLabel = driver.FindElement(By.XPath("//*[@id='edittag']/table/tbody/tr[3]/th/label"));
            nameEdit = driver.FindElement(By.XPath("//*[@id='name']"));
            slugEdit = driver.FindElement(By.XPath("//*[@id='slug']"));
            descriptionEdit = driver.FindElement(By.XPath("//*[@id='description']"));
            updateButton = driver.FindElement(By.XPath("//*[@id='edittag']/div/input"));
            deleteButton = driver.FindElement(By.XPath("//*[@id='delete - link']/a"));
        }

        public EditTags ClickInputName()
        {
            nameEdit.Click();
            return this;
        }
        public EditTags ClickInputSlug()
        {
           slugEdit.Click();
            return this;
        }
        public EditTags ClickInputDescription()
        {
            descriptionEdit.Click();
            return this;
        }
        public EditTags ClearInputName()
        {
            nameEdit.Clear();
            return this;
        }
        public EditTags ClearInputSlug()
        {
            slugEdit.Clear();
            return this;
        }
        public EditTags ClearInputDescription()
        {
            descriptionEdit.Clear();
            return this;
        }
        public EditTags EditInputName(string newName)
        {
            nameEdit.SendKeys(newName);
            return this;
        }
        public EditTags EditInputSlug(string newSlug)
        {
            slugEdit.SendKeys(newSlug);
            return this;
        }
        public EditTags EditInputDescription(string newDescription)
        {
            descriptionEdit.SendKeys(newDescription);
            return this;
        }
        public string GetNameLabel()
        {
            return nameLabel.Text;
        }
        public string GetSlugLabel()
        {
            return slugLabel.Text;
        }
        public string GetDescriptionLabel()
        {
            return descriptionLabel.Text;
        }
        public void UpdateButtonClick()
        {
            updateButton.Click();
        }
        public void DeleteButtonClick()
        {
            deleteButton.Click();
        }
    }
}

