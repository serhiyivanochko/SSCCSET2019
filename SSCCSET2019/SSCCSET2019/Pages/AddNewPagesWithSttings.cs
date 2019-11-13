using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SSCCSET2019.Pages
{
    class AddNewPagesWithSttings
    {
        IWebDriver driver = new ChromeDriver();

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





        public AddNewPagesWithSttings()
        {
            document = driver.FindElement(By.ClassName("components-button components-panel__body-toggle"));
            statusVisibility = driver.FindElement(By.ClassName("components-button components-panel__body-toggle")).FindElement(By.LinkText("Status & Visibility"));
            arrowOne = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[1]/h2/button/span/svg"));
            buttonPublic = driver.FindElement(By.ClassName("components-button edit-post-post-visibility__toggle is-link"));
            immediately = driver.FindElement(By.Id("edit-post-post-schedule__toggle-0"));
            checkboxControlOne = driver.FindElement(By.XPath(@"//*[@id='inspector - checkbox - control - 0']"));
            stickToTheTop = driver.FindElement(By.ClassName("components-checkbox-control__label")).FindElement(By.LinkText("Stick to the top of the blog"));
            checkboxControlTwo = driver.FindElement(By.XPath(@"//*[@id='inspector - checkbox - control - 1']"));
            pendingReview = driver.FindElement(By.ClassName("components -checkbox-control__label")).FindElement(By.LinkText("Pending Review"));

            categories = driver.FindElement(By.ClassName("components-button components-panel__body-toggle")).FindElement(By.LinkText("Categories"));
            arrowTwo = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[2]/h2/button/span/svg"));
            checkboxThree = driver.FindElement(By.Id("editor-post-taxonomies-hierarchical-term-1"));
            withoutHeading = driver.FindElement(By.LinkText("Без рубрики"));
            addNewCategori = driver.FindElement(By.ClassName("components-button editor-post-taxonomies__hierarchical-terms-add is-link"));

            tags = driver.FindElement(By.ClassName("components-button components-panel__body-toggle")).FindElement(By.LinkText("Tags"));
            arrowThree = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[3]/h2/button/span/svg"));
            addNewTag = driver.FindElement(By.ClassName("components-form-token-field__label"));
            componentsFormToken = driver.FindElement(By.Id("components-form-token-input-1"));

            featuredImage = driver.FindElement(By.ClassName("components-button components-panel__body-toggle")).FindElement(By.LinkText("Featured Image"));
            arrowFour = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[4]/h2/button/span/svg"));
            buttonFeaturedImage = driver.FindElement(By.ClassName("components-button editor-post-featured-image__toggle"));

            excerpt = driver.FindElement(By.ClassName("components-button components-panel__body-toggle")).FindElement(By.LinkText("Excerpt"));
            arrowFive = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[5]/h2/button/span/svg"));
            writeAnExecerpt = driver.FindElement(By.ClassName("components-base-control__label"));
            learnMore= driver.FindElement(By.ClassName("components-external-link"));
            textareaControl = driver.FindElement(By.Id("inspector-textarea-control-2"));
            externalLink = driver.FindElement(By.ClassName("components-external-link"));

            discussion = driver.FindElement(By.ClassName("components-button components-panel__body-toggle")).FindElement(By.LinkText("Discussion"));
            arrowSix = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[1]/h2/button/span/svg"));
            checkboxControlFour = driver.FindElement(By.XPath(@"//*[@id='inspector - checkbox - control - 2']"));
            checkboxControlFive = driver.FindElement(By.XPath(@"//*[@id='inspector - checkbox - control - 3']"));

            block = driver.FindElement(By.ClassName("edit-post-sidebar__panel-tab ")).FindElement(By.LinkText("block"));
            noBlock = driver.FindElement(By.ClassName("edit-post-sidebar__panel-tab "));
            close = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[2]/button/svg"));

        

        }
        public void ClickDocument()
        {
            document.Click();
        }
        public void ClickPublic()
        {
            buttonPublic.Click();
        }
        public void ClickImmediately()
        {
            immediately.Click();
        }
        public void ClickcCheckboxControlOne()
        {
            checkboxControlOne.Click();
        }
        public void ClickcCheckboxControlTwo()
        {
            checkboxControlTwo.Click();
        }
        public void ClickcCategories()
        {
            categories.Click();
        }
        public void ClickcCheckboxControlThree()
        {
            checkboxThree.Click();
        }
        public void ClickAddNewCategori()
        {
            addNewCategori.Click();
        }
        public void ClickTags()
        {
            tags.Click();
        }
        public void ClickComponentsForm()
        {
            componentsFormToken.Click();
        }
        public void ClearComponentsForm()
        {
            componentsFormToken.Clear();
        }
        public void InputComponentsForm(string text)
        {
            componentsFormToken.SendKeys(text);
        }
        public void SubmitComponentsForm()
        {
            componentsFormToken.Submit();
        }
        public void ClickFeaturedImage()
        {
            featuredImage.Click();
        }
        public void ClickButtonFeaturedImage()
        {
            buttonFeaturedImage.Click();
        }
        public void ClickExcerpt()
        {
            excerpt.Click();
        }
        public void ClickTextarea()
        {
            textareaControl.Click();
        }
        public void ClearTextarea()
        {
            textareaControl.Clear();
        }
        public void ClickExternalLink()
        {
            externalLink.Click();
        }
        public void ClickDiscussion()
        {
            discussion.Click();
        }
        public void ClickcCheckboxControlFour()
        {
            checkboxControlFour.Click();
        }
        public void ClickcCheckboxControlFive()
        {
            checkboxControlFive.Click();
        }
        public void ClickcBlock()
        {
            block.Click();
        }
        public void ClickcClose()
        {
            close.Click();
        }
    }
}
