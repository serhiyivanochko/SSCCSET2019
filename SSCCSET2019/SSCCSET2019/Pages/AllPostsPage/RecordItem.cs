using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SSCCSET2019.Pages.AllPostsPage
{
    class RecordItem
    {
        protected IWebElement RecordCheck;
        protected IWebElement AuthorName;
        protected IWebElement CategoryName;
        protected List<IWebElement> Tegs;


        protected IWebElement CommentsApprovedBtn;
        protected IWebElement CommentsApprovedCountText;

        protected IWebElement DateOfPublication;



        public RecordItem(IWebElement record)
        {
            RecordCheck = record.FindElement(By.XPath(".//th[@class='check-column']/input"));
            AuthorName = record.FindElement(By.ClassName("row-title"));
            CategoryName = record.FindElement(By.XPath(".//td[contains(@class, 'categories') and contains(@class, 'column-categories')]/a"));
            Tegs = new List<IWebElement>();
            Tegs.AddRange(record.FindElements(By.XPath(".//td[contains(@class, 'tags') and contains(@class, 'column-tags')]/a")));

           // CommentsApprovedBtn = record

        }


    }
}
