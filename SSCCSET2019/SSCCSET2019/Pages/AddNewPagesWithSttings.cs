using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SSCCSET2019.Pages
{
    class AddNewPagesWithSttings
    {
        IWebDriver driver;

        IWebElement document;
        IWebElement statusVisibility;
        IWebElement buttonPublic;
        IWebElement immediately;
        IWebElement checkboxControlOne;
        IWebElement stickToTheTop;
        IWebElement checkboxControlTwo;
        IWebElement pendingReview;
        IWebElement categories;
        IWebElement checkboxThree;
        IWebElement withoutHeading;
        IWebElement addNewCategori;
        IWebElement tags;
        IWebElement addNewTag;
        IWebElement componentsFormToken;
        IWebElement featuredImage;
        IWebElement buttonFeaturedImage;
        IWebElement excerpt;
        IWebElement writeAnExecerpt;
        IWebElement learnMore;
        IWebElement textareaControl;
        IWebElement externalLink;
        IWebElement discussion;
        IWebElement checkboxControlFour;
        IWebElement checkboxControlFive;
        IWebElement block;
        IWebElement noBlock;
        IWebElement arrowOne;
        IWebElement arrowTwo;
        IWebElement arrowThree;
        IWebElement arrowFour;
        IWebElement arrowFive;
        IWebElement arrowSix;
        IWebElement close;





        public AddNewPagesWithSttings(IWebDriver driver)
        {
            this.driver = driver;
            document = driver.FindElement(By.ClassName("components-button components-panel__body-toggle"));
            statusVisibility = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[1]/h2/button"));
            arrowOne = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[1]/h2/button/span/svg"));
            buttonPublic = driver.FindElement(By.ClassName("components-button edit-post-post-visibility__toggle is-link"));
            immediately = driver.FindElement(By.Id("edit-post-post-schedule__toggle-0"));
            checkboxControlOne = driver.FindElement(By.XPath(@"//*[@id='inspector - checkbox - control - 0']"));
            stickToTheTop = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[1]/div[3]/div/div/label"));
            checkboxControlTwo = driver.FindElement(By.XPath(@"//*[@id='inspector - checkbox - control - 1']"));
            pendingReview = driver.FindElement(By.ClassName("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[1]/div[4]/div/div/label"));

            categories = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[2]/h2/button"));
            arrowTwo = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[2]/h2/button/span/svg"));
            checkboxThree = driver.FindElement(By.Id("editor-post-taxonomies-hierarchical-term-1"));
            withoutHeading = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[2]/div/div/label"));
            addNewCategori = driver.FindElement(By.ClassName("components-button editor-post-taxonomies__hierarchical-terms-add is-link"));

            tags = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[3]/h2/button"));
            arrowThree = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[3]/h2/button/span/svg"));
            addNewTag = driver.FindElement(By.ClassName("components-form-token-field__label"));
            componentsFormToken = driver.FindElement(By.Id("components-form-token-input-1"));

            featuredImage = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[4]/h2/button"));
            arrowFour = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[4]/h2/button/span/svg"));
            buttonFeaturedImage = driver.FindElement(By.ClassName("components-button editor-post-featured-image__toggle"));

            excerpt = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[5]/h2/button"));
            arrowFive = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[5]/h2/button/span/svg"));
            writeAnExecerpt = driver.FindElement(By.ClassName("components-base-control__label"));
            learnMore= driver.FindElement(By.ClassName("components-external-link"));
            textareaControl = driver.FindElement(By.Id("inspector-textarea-control-2"));
            externalLink = driver.FindElement(By.ClassName("components-external-link"));

            discussion = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[6]/h2/button"));
            arrowSix = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[1]/h2/button/span/svg"));
            checkboxControlFour = driver.FindElement(By.XPath(@"//*[@id='inspector - checkbox - control - 2']"));
            checkboxControlFive = driver.FindElement(By.XPath(@"//*[@id='inspector - checkbox - control - 3']"));

            block = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[2]/ul/li[2]/button "));
            noBlock = driver.FindElement(By.ClassName("edit-post-sidebar__panel-tab "));
            close = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[2]/button/svg"));

        

        }
        public AddNewPagesWithSttings ClickDocument()
        {
            document.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickPublic()
        {
            buttonPublic.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickImmediately()
        {
            immediately.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickcCheckboxControlOne()
        {
            checkboxControlOne.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickcCheckboxControlTwo()
        {
            checkboxControlTwo.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickcCategories()
        {
            categories.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickcCheckboxControlThree()
        {
            checkboxThree.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickAddNewCategori()
        {
            addNewCategori.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickTags()
        {
            tags.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickComponentsForm()
        {
            componentsFormToken.Click();
            return this;
        }
        public AddNewPagesWithSttings ClearComponentsForm()
        {
            componentsFormToken.Clear();
            return this;
        }
        public AddNewPagesWithSttings InputComponentsForm(string text)
        {
            componentsFormToken.SendKeys(text);
            return this;
        }
        public AddNewPagesWithSttings SubmitComponentsForm()
        {
            componentsFormToken.Submit();
            return this;
        }
        public AddNewPagesWithSttings ClickFeaturedImage()
        {
            featuredImage.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickButtonFeaturedImage()
        {
            buttonFeaturedImage.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickExcerpt()
        {
            excerpt.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickTextarea()
        {
            textareaControl.Click();
            return this;
        }
        public AddNewPagesWithSttings ClearTextarea()
        {
            textareaControl.Clear();
            return this;
        }
        public AddNewPagesWithSttings ClickExternalLink()
        {
            externalLink.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickDiscussion()
        {
            discussion.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickcCheckboxControlFour()
        {
            checkboxControlFour.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickcCheckboxControlFive()
        {
            checkboxControlFive.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickcBlock()
        {
            block.Click();
            return this;
        }
        public AddNewPagesWithSttings ClickcClose()
        {
            close.Click();
            return this;
        }
    }
}
