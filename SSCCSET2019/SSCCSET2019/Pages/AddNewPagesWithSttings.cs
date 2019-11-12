using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCCSET2019.Pages
{
    class AddNewPagesWithSttings
    {
        IWebDriver driver = new ChromeDriver();

        IWebElement document;
        IWebElement statusVisibility;
        IWebElement postVisibility;
        IWebElement postSchedule;
        IWebElement checkboxControlOne;
        IWebElement stickToTheTop;
        IWebElement checkboxControlTwo;
        IWebElement pendingReview;
        IWebElement categories;
        IWebElement checkboxThree;
        IWebElement withoutHeading;
        IWebElement componentsButtonEditor;
        IWebElement tags;
        IWebElement addNewTag;
        IWebElement componentsFormToken;
        IWebElement featuredImage;
        IWebElement postFeaturedImage;
        IWebElement excerpt;
        IWebElement writeAnExecerpt;
        IWebElement learnMore;
        IWebElement textareaControl;
        IWebElement externalLink;
        IWebElement discussion;
        IWebElement checkboxControlTen;
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
            postVisibility = driver.FindElement(By.ClassName("components-button edit-post-post-visibility__toggle is-link"));
            postSchedule = driver.FindElement(By.Id("edit-post-post-schedule__toggle-0"));
            checkboxControlOne = driver.FindElement(By.Id("inspector-checkbox-control-6"));
            stickToTheTop = driver.FindElement(By.ClassName("components-checkbox-control__label")).FindElement(By.LinkText("Stick to the top of the blog"));
            checkboxControlTwo = driver.FindElement(By.Id("inspector-checkbox-control-7"));
            pendingReview = driver.FindElement(By.ClassName("components-checkbox-control__label")).FindElement(By.LinkText("Pending Review"));
            categories = driver.FindElement(By.ClassName("components-button components-panel__body-toggle")).FindElement(By.LinkText("Categories"));
            arrowTwo = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[2]/h2/button/span/svg"));
            checkboxThree = driver.FindElement(By.Id("editor-post-taxonomies-hierarchical-term-1"));
            withoutHeading = driver.FindElement(By.LinkText("Без рубрики"));
            componentsButtonEditor = driver.FindElement(By.ClassName("components-button editor-post-taxonomies__hierarchical-terms-add is-link"));
            tags = driver.FindElement(By.ClassName("components-button components-panel__body-toggle")).FindElement(By.LinkText("Tags"));
            arrowThree = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[3]/h2/button/span/svg"));
            addNewTag = driver.FindElement(By.ClassName("components-form-token-field__label"));
            componentsFormToken = driver.FindElement(By.Id("components-form-token-input-1"));
            featuredImage = driver.FindElement(By.ClassName("components-button components-panel__body-toggle")).FindElement(By.LinkText("Featured Image"));
            arrowFour = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[4]/h2/button/span/svg"));
            postFeaturedImage = driver.FindElement(By.ClassName("components-button editor-post-featured-image__toggle"));
            excerpt = driver.FindElement(By.ClassName("components-button components-panel__body-toggle")).FindElement(By.LinkText("Excerpt"));
            arrowFive = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[5]/h2/button/span/svg"));
            writeAnExecerpt = driver.FindElement(By.ClassName("components-base-control__label"));
            learnMore= driver.FindElement(By.ClassName("components-external-link"));
            textareaControl = driver.FindElement(By.Id("inspector-textarea-control-2"));
            externalLink = driver.FindElement(By.ClassName("components-external-link"));
            discussion = driver.FindElement(By.ClassName("components-button components-panel__body-toggle")).FindElement(By.LinkText("Discussion"));
            arrowSix = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[3]/div[1]/h2/button/span/svg"));
            checkboxControlFour = driver.FindElement(By.Id("inspector-checkbox-control-4"));
            checkboxControlFive = driver.FindElement(By.Id("inspector-checkbox-control-5"));
            block = driver.FindElement(By.ClassName("edit-post-sidebar__panel-tab ")).FindElement(By.LinkText("block"));
            noBlock = driver.FindElement(By.ClassName("edit-post-sidebar__panel-tab "));
            close = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[1]/div/div/div/div[4]/div/div[2]/button/svg"));

        }

    }
}
