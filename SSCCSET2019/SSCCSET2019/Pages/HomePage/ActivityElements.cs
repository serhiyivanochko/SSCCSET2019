using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCCSET2019.Pages.HomePage
{
    class ActivityElements
    {
        private bool isVisible = true;
        private IWebDriver driver;
        private IWebElement hideShow;
        private IWebElement commentator;
        private IWebElement comment;
        private IWebElement view;
        private IWebElement spam;
        private IWebElement trash;
        private IWebElement reply;
        private IWebElement approve;
        private IWebElement unapprove;
        private IWebElement edit;
        private IWebElement undo;
        private IWebElement allComments;
        private IWebElement mineComment;
        private IWebElement approvedComment;
        private IWebElement trashComment;
        private IWebElement spamcomment;
        private IWebElement pendingComment;
        private IWebElement TollbarBtnB;
        private IWebElement TollbarBtnI;
        private IWebElement TollbarBtnLink;
        private IWebElement TollbarBtnQoute;
        private IWebElement TollbarBtnDel;
        private IWebElement TollbarBtnIns;
        private IWebElement TollbarBtnImg;
        private IWebElement TollbarBtnUl;
        private IWebElement TollbarBtnOl;
        private IWebElement TollbarBtnLi;
        private IWebElement TollbarBtnCode;
        private IWebElement TollbarBtnCloseTag;
        private IWebElement replyTextField;
        private IWebElement replyApprove;
        private IWebElement replyCancel;
        public ActivityElements(IWebDriver driver)
        {
            hideShow = driver.FindElement(By.XPath(@"//*[@id='dashboard_activity']/button/span[2]"));
            commentator = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/p[1]/cite/a"));
            comment = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/blockquote/p"));
            approve = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/p[2]/span[1]"));
            unapprove = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/p[2]/span[2]"));
            reply = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/p[2]/span[3]"));
            edit = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/p[2]/span[4]"));
            spam = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/p[2]/span[5]"));
            trash = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/p[2]/span[6]"));
            view = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/p[2]/span[7]"));
            undo = driver.FindElement(By.XPath(@"//*[@id='undo-1']/div/span/a"));
            allComments = driver.FindElement(By.XPath(@"//*[@id='latest-comments']/ul[2]/li[1]/a"));
            mineComment = driver.FindElement(By.XPath(@"//*[@id='latest-comments']/ul[2]/li[2]/a"));
            pendingComment = driver.FindElement(By.XPath(@"//*[@id='latest-comments']/ul[2]/li[3]/a"));
            approvedComment = driver.FindElement(By.XPath(@"//*[@id='latest-comments']/ul[2]/li[4]/a"));
            spamcomment = driver.FindElement(By.XPath(@"//*[@id='latest-comments']/ul[2]/li[5]/a"));
            trashComment = driver.FindElement(By.XPath(@"//*[@id='latest-comments']/ul[2]/li[6]/a"));
            TollbarBtnB = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[1]']"));
            TollbarBtnI = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[2]']"));
            TollbarBtnLink = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[3]']"));
            TollbarBtnQoute = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[4]']"));
            TollbarBtnDel = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[5]']"));
            TollbarBtnIns = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[6]']"));
            TollbarBtnImg = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[7]']"));
            TollbarBtnUl = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[8]']"));
            TollbarBtnOl = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[9]']"));
            TollbarBtnLi = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[10]']"));
            TollbarBtnCode = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[11]']"));
            TollbarBtnCloseTag = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[12]']"));
            replyTextField = driver.FindElement(By.XPath(@"//*[@id='replycontent']"));
            replyApprove = driver.FindElement(By.Id("replybtn"));
            replyCancel = driver.FindElement(By.XPath(@"//*[@id='replysubmit']/p/button[2]"));
        }

        public ActivityElements HideOrShowActivity()
        {
            hideShow.Click();
            if (hideShow.GetAttribute("aria-expanded") == "true")
            {
                isVisible = false;
            }
            else
            {
                isVisible = true;
            }
            return this;
        }

        public ActivityElements SetTextInReplyTextField(string str)
        {
            replyTextField.SendKeys(str);
            return this;
        }
        public ActivityElements ClickOnReplyTextField()
        {
            replyTextField.Click();
            return this;
        }

        public ActivityElements ClearReplyTextField()
        {
            replyTextField.Clear();
            return this;
        }
        public string GetTeaxtFromReplyTextField()
        {
            return replyTextField.Text;
        }

        public string GetComentText()
        {
            return comment.Text;
        }

        public ActivityElements ClickToApproveComent()
        {
            approve.Click();
            return this;
        }
        public ActivityElements ClickToUnapproveComent()
        {
            unapprove.Click();
            return this;
        }
        public ActivityElements ClickTApproveReplyToComment()
        {
            replyApprove.Click();
            return this;
        }
        public ActivityElements ClickCancelReplyToComment()
        {
            replyCancel.Click();
            return this;
        }
    }
}
