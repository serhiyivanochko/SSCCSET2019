using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SSCCSET2019.Pages.AllPostsPage
{
    class RecordItem
    {
        private IWebElement postWebElement;

        #region Always visible elements
        private IWebElement recordCheck;
        private IWebElement authorName;
        private IWebElement categoryName;
        private List<IWebElement> tegs;
        private IWebElement commentsApprovedBtn;
        private IWebElement commentsApprovedCountText;
        private IWebElement dateOfPublication;
        #endregion

        #region Visible on hover elements
        private IWebElement editBtn;
        private IWebElement quickEditBtn;
        private IWebElement trashBtn;
        private IWebElement viewBtn;
        #endregion

        public RecordItem(IWebElement record, bool IsHovered = false)
        {
            postWebElement = record;

            #region Always visible elements initialization
            recordCheck = record.FindElement(By.XPath(".//th[@class='check-column']/input"));
            authorName = record.FindElement(By.ClassName("row-title"));
            categoryName = record.FindElement(By.XPath(".//td[contains(@class, 'categories') and contains(@class, 'column-categories')]/a"));
            tegs = new List<IWebElement>();
            tegs.AddRange(record.FindElements(By.XPath(".//td[contains(@class, 'tags') and contains(@class, 'column-tags')]/a")));
            commentsApprovedBtn = record.FindElement(By.ClassName("post-com-count-approved"));
            commentsApprovedCountText = record.FindElement(By.ClassName("comment-count-approved"));
            dateOfPublication = record.FindElement(By.XPath("//td[contains(@class, 'date')]/abbr"));
            #endregion
            if (IsHovered)
            {
                editBtn = record.FindElement(By.XPath("//span[@class='edit']/a"));
                quickEditBtn = record.FindElement(By.ClassName("editinline"));
                trashBtn = record.FindElement(By.XPath("//span[@class='trash']/a"));
                viewBtn = record.FindElement(By.XPath("//span[@class='view']/a"));
            }
        }

        public IWebElement GetPostElement()
        {
            return postWebElement;
        }
    }
}
