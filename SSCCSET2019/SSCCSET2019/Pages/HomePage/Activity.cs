using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCCSET2019.Pages.HomePage
{
    class Activity
    {
        IWebDriver driver;


        IWebElement hideShow;
        IWebElement commentator;
        IWebElement comment;
        IWebElement view;
        IWebElement spam;
        IWebElement trash;
        IWebElement reply;
        IWebElement approve;
        IWebElement unapprove;
        IWebElement edit;
        IWebElement undo;


        IWebElement allComments;
        IWebElement mineComment;
        IWebElement approvedComment;
        IWebElement trashComment;
        IWebElement spamcomment;
        IWebElement pendingComment;

        IWebElement TollbarBtnB;
        IWebElement TollbarBtnI;
        IWebElement TollbarBtnLink;
        IWebElement TollbarBtnQoute;
        IWebElement TollbarBtnDel;
        IWebElement TollbarBtnIns;
        IWebElement TollbarBtnImg;
        IWebElement TollbarBtnUl;
        IWebElement TollbarBtnOl;
        IWebElement TollbarBtnLi;
        IWebElement TollbarBtnCode;
        IWebElement TollbarBtnCloseTag;

        IWebElement replyTextField;
        IWebElement replyApprove;
        IWebElement replyCancel;


        public Activity()
        {

            hideShow = driver.FindElement(By.XPath(@"//*[@id='dashboard_activity']/button/span[2]"));
            commentator = driver.FindElement(By.XPath(@"//*[@id='comment - 1']/div/p[1]/cite/a"));
            comment = driver.FindElement(By.XPath(@"//*[@id='comment - 1']/div/blockquote/p"));
            approve = driver.FindElement(By.XPath(@"//*[@id='comment - 1']/div/p[2]/span[1]"));
            unapprove = driver.FindElement(By.XPath(@"//*[@id='comment - 1']/div/p[2]/span[2]"));
            reply = driver.FindElement(By.XPath(@"//*[@id='comment - 1']/div/p[2]/span[3]"));
            edit = driver.FindElement(By.XPath(@"//*[@id='comment - 1']/div/p[2]/span[4]"));
            spam = driver.FindElement(By.XPath(@"//*[@id='comment - 1']/div/p[2]/span[5]"));
            trash = driver.FindElement(By.XPath(@"//*[@id='comment - 1']/div/p[2]/span[6]"));
            view = driver.FindElement(By.XPath(@"//*[@id='comment - 1']/div/p[2]/span[7]"));
            undo = driver.FindElement(By.XPath(@"//*[@id='undo - 1']/div/span/a"));

            allComments = driver.FindElement(By.XPath(@"//*[@id='latest - comments']/ul[2]/li[1]/a"));
            mineComment = driver.FindElement(By.XPath(@"//*[@id='latest - comments']/ul[2]/li[2]/a"));
            pendingComment = driver.FindElement(By.XPath(@"//*[@id='latest - comments']/ul[2]/li[3]/a"));
            approvedComment = driver.FindElement(By.XPath(@"//*[@id='latest - comments']/ul[2]/li[4]/a"));
            spamcomment = driver.FindElement(By.XPath(@"//*[@id='latest - comments']/ul[2]/li[5]/a"));
            trashComment = driver.FindElement(By.XPath(@"//*[@id='latest - comments']/ul[2]/li[6]/a"));



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

        public Activity HideOrShowActivity()
        {
            hideShow.Click();
            return this;
        }
        
        public Activity SetTextInReplyTextField(string str)
        {

            replyTextField.SendKeys(str);
            return this;
        }
         public Activity ClickOnReplyTextField()
        {

            replyTextField.Click();
            return this;
        }

        public Activity ClearReplyTextField()
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

        public Activity ClickToApproveComent() 
        {
            approve.Click();
            return this;
        }
        public Activity ClickToUnapproveComent() 
        {
            unapprove.Click();
            return this;
        }
        public Activity ClickTApproveReplyToComment()
        {
            replyApprove.Click();
            return this;
        }
        public Activity ClickCancelReplyToComment()
        {
            replyCancel.Click();
            return this;
        }


    }
}  
