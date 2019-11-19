using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SSCCSET2019.Pages.AllPostsPage
{
    class RecordItem
    {
        private IWebElement recordCheck;
        private IWebElement authorName;
        private IWebElement categoryName;
        private List<IWebElement> tegs;
        private IWebElement commentsApprovedBtn;
        private IWebElement commentsApprovedCountText;
        private IWebElement dateOfPublication;

        public RecordItem(IWebElement record)
        {
            recordCheck = record.FindElement(By.XPath(".//th[@class='check-column']/input"));
            authorName = record.FindElement(By.ClassName("row-title"));
            categoryName = record.FindElement(By.XPath(".//td[contains(@class, 'categories') and contains(@class, 'column-categories')]/a"));
            tegs = new List<IWebElement>();
            tegs.AddRange(record.FindElements(By.XPath(".//td[contains(@class, 'tags') and contains(@class, 'column-tags')]/a")));
            //commentsApprovedBtn = record

        }


    }
}
