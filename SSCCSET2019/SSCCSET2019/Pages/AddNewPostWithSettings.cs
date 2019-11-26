using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;



namespace SSCCSET2019.Pages
{
    class AddNewPostsWithSettings
    {
        protected IWebDriver driver;
        protected IWebElement document;
        protected IWebElement statusAndVisibility;
        protected IWebElement buttonVisibility;
        protected IWebElement immediately;
        protected IWebElement checkboxControlOne;
        protected IWebElement stickToTheTop;
        protected IWebElement checkboxControlTwo;
        protected IWebElement pendingReview;
        protected IWebElement categories;
        protected IWebElement checkboxThree;
        protected IWebElement withoutHeading;
        protected IWebElement addNewCategori;
        protected IWebElement tags;
        protected IWebElement addNewTag;
        protected IWebElement componentsFormToken;
        protected IWebElement featuredImage;
        protected IWebElement buttonFeaturedImage;
        protected IWebElement excerpt;
        protected IWebElement writeAnExecerpt;
        protected IWebElement learnMore;
        protected IWebElement textareaControl;
        protected IWebElement externalLink;
        protected IWebElement discussion;
        protected IWebElement checkboxControlFour;
        protected IWebElement checkboxControlFive;
        protected IWebElement arrowOne;
        protected IWebElement arrowTwo;
        protected IWebElement arrowThree;
        protected IWebElement arrowFour;
        protected IWebElement arrowFive;
        protected IWebElement arrowSix;
        protected IWebElement publicVisibility;
        protected IWebElement privateVisibility;
        protected IWebElement passwordProtectedVisibility;
        public AddNewPostsWithSettings(IWebDriver driver)
        {
            this.driver = driver;
            document = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[2]/ul/li[1]/button"));
            statusAndVisibility = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[1]/h2/button"));
            arrowOne = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[1]/h2/button"));
            buttonVisibility = driver.FindElement(By.CssSelector(".components-button.edit-post-post-visibility__toggle.is-link"));
            immediately = driver.FindElement(By.Id("edit-post-post-schedule__toggle-0"));
            checkboxControlOne = driver.FindElement(By.XPath(@"//*[@id='inspector-checkbox-control-0']"));
            stickToTheTop = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[1]/div[3]/div/div/label"));
            checkboxControlTwo = driver.FindElement(By.XPath(@"//*[@id='inspector-checkbox-control-1']"));
            pendingReview = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[1]/div[4]/div/div/label"));
            categories = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[2]/h2/button"));
            arrowTwo = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[2]/h2/button"));           
            tags = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[3]/h2/button"));
            arrowThree = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[3]/h2/button"));            
            featuredImage = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[4]/h2/button"));
            arrowFour = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[4]/h2/button"));           
            arrowFive = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[5]/h2/button"));
            excerpt = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[5]/h2/button"));
            arrowSix = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[6]/h2/button"));
            discussion = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[4]/div[1]/div/div/div/div[4]/div/div[3]/div[6]/h2/button"));
        }

        //TODO: Set normal waiting
        public CategoryTwo ClickArrowTwo()
        {
            categories.Click();
            Thread.Sleep(1000);
            return new CategoryTwo(driver);
        }
        public CategoryThree ClickArrowThree()
        {
            tags.Click();
            Thread.Sleep(1000);
            return new CategoryThree(driver);
        }
        public CategoryFour ClickArrowFour()
        {
            featuredImage.Click();
            Thread.Sleep(1000);
            return new CategoryFour(driver);
        }
        public CategoryFive ClickArrowFive()
        {
            excerpt.Click();
            Thread.Sleep(1000);
            return new CategoryFive(driver);
        }
        public CategorySix ClickArrowSix()
        {
            discussion.Click();
            Thread.Sleep(1000);
            return new CategorySix(driver);
        }

        public PostVisibility ClickPublicVisibility()
        {
            publicVisibility.Click();
            return new PostVisibility(driver);
        }
        public PostVisibility ClickPrivateVisibility()
        {
            privateVisibility.Click();
            return new PostVisibility(driver);
        }
        public PostVisibility ClickPasswordProtectedVisibility()
        {
            passwordProtectedVisibility.Click();
            return new PostVisibility(driver);
        }


        public AddNewPostsWithSettings ClickDocument()
        {
            document.Click();
            return this;
        }
        public AddNewPostsWithSettings ClickButtonVisibility()
        {
            buttonVisibility.Click();
            return this;
        }
        public AddNewPostsWithSettings ClickImmediately()
        {
            immediately.Click();
            return this;
        }
        public AddNewPostsWithSettings ClickcCheckboxControlOne()
        {
            checkboxControlOne.Click();
            return this;
        }
        public AddNewPostsWithSettings ClickcCheckboxControlTwo()
        {
            checkboxControlTwo.Click();
            return this;
        }
        public AddNewPostsWithSettings ClickcCategories()
        {
            categories.Click();
            return this;
        }
        public AddNewPostsWithSettings ClickcCheckboxControlThree()
        {
            checkboxThree.Click();
            return this;
        }
        public AddNewPostsWithSettings ClickAddNewCategori()
        {
            addNewCategori.Click();
            return this;
        }
        public AddNewPostsWithSettings ClickTags()
        {
            tags.Click();
            return this;
        }
        public AddNewPostsWithSettings ClickComponentsForm()
        {
            componentsFormToken.Click();
            return this;
        }
        public AddNewPostsWithSettings ClearComponentsForm()
        {
            componentsFormToken.Clear();
            return this;
        }
        public AddNewPostsWithSettings InputComponentsForm(string text)
        {
            componentsFormToken.SendKeys(text);
            return this;
        }
        public AddNewPostsWithSettings SubmitComponentsForm(string text)
        {
            componentsFormToken.Submit();
            return this;
        }


        public AddNewPostsWithSettings SubmitComponentsForm()
        {
            componentsFormToken.Submit();
            return this;
        }
        public AddNewPostsWithSettings ClickFeaturedImage()
        {
            featuredImage.Click();
            return this;
        }
        public AddNewPostsWithSettings ClickButtonFeaturedImage()
        {
            buttonFeaturedImage.Click();
            return this;
        }
        public AddNewPostsWithSettings ClickExcerpt()
        {
            excerpt.Click();
            return this;
        }
        public AddNewPostsWithSettings ClickTextarea()
        {
            textareaControl.Click();
            return this;
        }
        public AddNewPostsWithSettings ClearTextarea()
        {
            textareaControl.Clear();
            return this;
        }
        public AddNewPostsWithSettings ClickExternalLink()
        {
            externalLink.Click();
            return this;
        }
        public AddNewPostsWithSettings ClickDiscussion()
        {
            discussion.Click();
            return this;
        }
        public AddNewPostsWithSettings ClickcCheckboxControlFour()
        {
            checkboxControlFour.Click();
            return this;
        }
        public AddNewPostsWithSettings ClickcCheckboxControlFive()
        {
            checkboxControlFive.Click();
            return this;
        }

    }
}
