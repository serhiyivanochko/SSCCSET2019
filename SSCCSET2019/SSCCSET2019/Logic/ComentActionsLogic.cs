using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSCCSET2019.SSCCSET2019.Pages.CommentActionsPage;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace CommentActionsLogicPage
{
    public class CommentActionsLogicPage // потрібно поміняти назви сторінок на назви page з коментарями
    {
        protected IWebDriver driver;
        public CommentActionsPage InputSeachTop(string text)
        {
            CommentActionsPage items = new CommentActionsPage();
            items.ClickSearchTop();
            items.ClearSearchTop();
            items.SetSearchTop(text);
            items.ClickButtonSearch();
            return new CommentActionsPage(); // need to change
        }
        public CommentActionsPage SubmitCommentType(string commentType)
        {
            CommentActionsPage items = new CommentActionsPage();
            items.SetCommentTypeSelect(commentType);
            items.ClickCommentTypeSubmitButton();
            return new CommentActionsPage(); // need to change
        }
        public CommentActionsPage SubmitFilterType(string filterType)
        {
            CommentActionsPage items = new CommentActionsPage();
            items.SetFilterTypeSelect(filterType);
            items.ClickCommentTypeSubmitButton();
            return new CommentActionsPage(); // need to change
        }
        public CommentActionsPage CountOfElements(int a) // need to be done
        {

        }
    }

}
