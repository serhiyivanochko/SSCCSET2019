using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace SSCCSET2019.SSCCSET2019.Pages.CommentActionsPage
{
    public class CommentActionsPage : ATopCommentAndResponse 
    {
        public const string VALUE_ATTRIBUTE = "value";
        public SelectElement CommentTypeSelect { get; private set; }
        public IWebElement CommentTypeSubmitButton { get; private set; }
        public SelectElement FilterTypeSelect { get; private set; }
        public IWebElement FilterTypeSubmitButton { get; private set; }
        public IWebElement CountElementsLabel { get; private set; }
        public IWebElement SearchTop { get; private set; }
        public IWebElement ButtonSearch { get; private set; }
        public CommentActionsPage(IWebDriver driver) : base(driver)
        {          
            CommentTypeSelect = new SelectElement(driver.FindElement(By.Id("bulk-action-selector-top")));
            IWebElement CommentTypeSubmitButton = driver.FindElement(By.Id("doaction"));
            FilterTypeSelect = new SelectElement(driver.FindElement(By.Id("filter-by-comment-type")));
            IWebElement FilterTypeSubmitButton = driver.FindElement(By.Id("post-query-submit"));
            IWebElement CountElementsLabel = driver.FindElement(By.XPath("//*[@id='comments - form']/div[1]/div[3]/span[1]"));
            IWebElement SearchTop = driver.FindElement(By.Id("comment-search-input"));
            IWebElement ButtonSearch = driver.FindElement(By.Id("search-submit"));
        }

        public string GetCountElementsLabelText()
        {
            return CountElementsLabel.Text;
        }
        public void ClickCommentTypeSubmitButton()
        {
            CommentTypeSubmitButton.Click();
        }
        public string GetCommentTypeSubmitButtonText()
        {
            return CommentTypeSubmitButton.Text;
        }
        public void ClickFilterTypeSelectSubmitButtonTop2()
        {
            FilterTypeSubmitButton.Click();
        }
        public string GetFilterTypeSubmitButtonText()
        {
            return FilterTypeSubmitButton.Text;
        }
        public string GetCommentTypeSelectText()
        {
            return CommentTypeSelect.AllSelectedOptions[0].Text;
        }
        public void SetCommentTypeSelect1(string commentType)
        {
            CommentTypeSelect.SelectByText(commentType);
        }
        public string GetFilterTypeSelectText()
        {
            return FilterTypeSelect.AllSelectedOptions[0].Text;
        }
        public void SetFilterTypeSelect(string filterType)
        {
            FilterTypeSelect.SelectByText(filterType);
        }
        public void ButtonSearchClick()
        {
            ButtonSearch.Click();
        }
        public string GetButtonSearchText()
        {
            return ButtonSearch.Text;
        }
        public string GetSearchTopInputText()
        {
            return SearchTop.GetAttribute(VALUE_ATTRIBUTE);
        }
        public void SetSearchTop(string text)
        {
            SearchTop.Click();
            SearchTop.Clear();
        }
        public void ClearSearchTop()
        {
            SearchTop.Clear();
        }
    }
}
