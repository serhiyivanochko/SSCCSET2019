using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace SSCCSET2019.Pages.HomePage
{
    class ActivityElements
    {
        private bool isVisible = true;
        public ReplyElements replyElements = null;
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
        Actions actions;
        
        public ActivityElements(IWebDriver driver)
        {
            actions = new Actions(driver);
            this.driver = driver;
            hideShow = driver.FindElement(By.XPath(@"//*[@id='dashboard_activity']/button/span[2]"));
            commentator = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/p[1]/cite/a"));
            comment = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/blockquote/p"));
            approve = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/p[2]/span[1]"));
            unapprove = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/p[2]/span[2]"));
            reply = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/p[2]/span[3]/button"));
            edit = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/p[2]/span[4]"));
            spam = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/p[2]/span[5]"));
            trash = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/p[2]/span[6]"));
            view = driver.FindElement(By.XPath(@"//*[@id='comment-1']/div/p[2]/span[7]"));
            allComments = driver.FindElement(By.XPath(@"//*[@id='latest-comments']/ul[2]/li[1]/a"));
            mineComment = driver.FindElement(By.XPath(@"//*[@id='latest-comments']/ul[2]/li[2]/a"));
            pendingComment = driver.FindElement(By.XPath(@"//*[@id='latest-comments']/ul[2]/li[3]/a"));
            approvedComment = driver.FindElement(By.XPath(@"//*[@id='latest-comments']/ul[2]/li[4]/a"));
            spamcomment = driver.FindElement(By.XPath(@"//*[@id='latest-comments']/ul[2]/li[5]/a"));
            trashComment = driver.FindElement(By.XPath(@"//*[@id='latest-comments']/ul[2]/li[6]/a"));
            //undo = driver.FindElement(By.XPath(@"//*[@id='undo-1']/div/span/a"));

        }
        private void MakeVisible() {
            actions.MoveToElement(comment);
            actions.Perform();
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

        public ActivityElements ClickOnReply()
        {
            MakeVisible();
            reply.Click();
            if (replyElements==null)
            {
                replyElements = new ReplyElements(driver);
                return this;
            }
            else
            {
                replyElements = null;
                return null;
            }

        }
        
        public ActivityElements ClickOnApprove()
        {
            MakeVisible();
            approve.Click();
            return this;

        }
       public ActivityElements ClickOnUnapprove()
        {
            MakeVisible();
            unapprove.Click();
            return this;

        }
       

        public string GetComentText()
        {
            if (isVisible)
            {
                return comment.Text;
            }
            else
            {
                return null;
            }
           
        }

        public ActivityElements ClickToApproveComent()
        {
            if (isVisible)
            {
                approve.Click();
                return this;
            }
            else
            {
                return null;
            }
            
        }
        public ActivityElements ClickToUnapproveComent()
        {
            if (isVisible)
            {
                unapprove.Click();
                return this;
            }
            else
            {
                return null;
            }
            
        }
        
    }

    class ReplyElements : ActivityElements
    {
        IWebDriver driver;
        
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
        public ReplyElements(IWebDriver driver):base(driver)
        {
            this.driver = driver;
            TollbarBtnB = driver.FindElement(By.Id("qt_replycontent_strong"));
            TollbarBtnI = driver.FindElement(By.Id("qt_replycontent_em"));
            TollbarBtnLink = driver.FindElement(By.Id("qt_replycontent_link"));
            TollbarBtnQoute = driver.FindElement(By.Id("qt_replycontent_block"));
            TollbarBtnDel = driver.FindElement(By.Id("qt_replycontent_del"));
            TollbarBtnIns = driver.FindElement(By.Id("qt_replycontent_ins"));
            TollbarBtnImg = driver.FindElement(By.Id("qt_replycontent_img"));
            TollbarBtnUl = driver.FindElement(By.Id("qt_replycontent_ul"));
            TollbarBtnOl = driver.FindElement(By.Id("qt_replycontent_ol"));
            TollbarBtnLi = driver.FindElement(By.Id("qt_replycontent_li"));
            TollbarBtnCode = driver.FindElement(By.Id("qt_replycontent_code"));
            TollbarBtnCloseTag = driver.FindElement(By.Id("qt_replycontent_close"));
            replyTextField = driver.FindElement(By.XPath(@"//*[@id='replycontent']"));
            replyApprove = driver.FindElement(By.Id("replybtn"));
            replyCancel = driver.FindElement(By.XPath(@"//*[@id='replysubmit']/p/button[2]"));
        }
        public ActivityElements ClickCancelReplyButton() 
        {
            replyCancel.Click();
            replyElements = null;
            return new ActivityElements(driver);
        }

        public ActivityElements SetTextInReplyTextField(string str)
        {
            if (replyElements != null)
            {
                replyTextField.SendKeys(str);
                return this;
            }
            else
            {
                return null;
            }

        }
        public ActivityElements ClickOnReplyTextField()
        {
            if (replyElements != null)
            {
                replyTextField.Click();
                return this;
            }
            else
            {
                return null;
            }
        }

        public ActivityElements ClearReplyTextField()
        {
            if (replyElements != null)
            {
                replyTextField.Clear();
                return this;
            }
            else
            {
                return null;
            }
        }
        public string GetTeaxtFromReplyTextField()
        {
            if (replyElements != null)
            {
                
                return replyTextField.Text;
            }
            else
            {
                return null;
            }

        }

        public ActivityElements ClickApproveReplyToComment()
        {
            if (replyElements != null)
            {
                replyApprove.Click();
                replyElements = null;
                return this;
            }
            else
            {
                return null;
            }

        }
        public ActivityElements ClickCancelReplyToComment()
        {
            if (replyElements != null)
            {
                replyCancel.Click();
                replyElements = null;
                return this;
            }
            else
            {
                return null;
            }

        }
    }
}
