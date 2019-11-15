using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace SSCCSET2019.SSCCSET2019.Pages.CommentActionsPage
{
    public class CommentActionsPage
    {
        protected IWebDriver driver;
        public SelectElement CommentTypeSelect
        { get { return new SelectElement(driver.FindElement(By.Id("bulk-action-selector-top"))); } }
        public IWebElement CommentTypeSubmitButton 
        { get { return driver.FindElement(By.Id("doaction")); } }
        public SelectElement FilterTypeSelect 
        { get { return new SelectElement(driver.FindElement(By.Id("filter-by-comment-type"))); } }
        public IWebElement FilterTypeSubmitButton 
        { get { return driver.FindElement(By.Id("post-query-submit")); } }
        public IWebElement CountElementsLabel
        { get { return driver.FindElement(By.XPath("//*[@id='comments - form']/div[1]/div[3]/span[1]")); } }
        public IWebElement SearchTop 
        { get { return driver.FindElement(By.Id("comment-search-input")); } }
        public IWebElement ButtonSearch
        { get { return driver.FindElement(By.Id("search-submit"));  } }      
        public string GetCountElementsLabelText()
        {
            return CountElementsLabel.Text;
        }
        public CommentActionsPage ClickCommentTypeSubmitButton()
        {
            CommentTypeSubmitButton.Click();
            return this;
        }
        public string GetCommentTypeSubmitButtonText()
        {
            return CommentTypeSubmitButton.Text;
        }
        public CommentActionsPage ClickFilterTypeSelectSubmitButtonTop2()
        {
            FilterTypeSubmitButton.Click();
            return this;
        }
        public string GetFilterTypeSubmitButtonText()
        {
            return FilterTypeSubmitButton.Text;
        }
        public string GetCommentTypeSelectText()
        {
            return CommentTypeSelect.AllSelectedOptions[0].Text;
        }
        public CommentActionsPage SetCommentTypeSelect(string commentType)
        {
            CommentTypeSelect.SelectByText(commentType);
            return this;
        }
        public string GetFilterTypeSelectText()
        {
            return FilterTypeSelect.AllSelectedOptions[0].Text;
        }
        public CommentActionsPage SetFilterTypeSelect(string filterType)
        {
            FilterTypeSelect.SelectByText(filterType);
            return this;
        }
        public CommentActionsPage ClickButtonSearch()
        {
            ButtonSearch.Click();
            return this;
        }
        public string GetButtonSearchText()
        {
            return ButtonSearch.Text;
        }
        public string GetSearchTopInputText()
        {
            return this.SearchTop.Text;
        }
        public CommentActionsPage SetSearchTop(string text)
        {          
            this.SearchTop.SendKeys(text);
            return this;
        }
        public CommentActionsPage ClearSearchTop()
        {
            SearchTop.Clear();
            return this;
        }
        public CommentActionsPage ClickSearchTop()
        {
            SearchTop.Click();
            return this;
        }
    }
    


}
