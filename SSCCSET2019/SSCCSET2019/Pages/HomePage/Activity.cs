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


        IWebElement hide_show;
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

        IWebElement TollbarBtn_b;
        IWebElement TollbarBtn_i;
        IWebElement TollbarBtn_link;
        IWebElement TollbarBtn_qoute;
        IWebElement TollbarBtn_del;
        IWebElement TollbarBtn_ins;
        IWebElement TollbarBtn_img;
        IWebElement TollbarBtn_ul;
        IWebElement TollbarBtn_ol;
        IWebElement TollbarBtn_li;
        IWebElement TollbarBtn_code;
        IWebElement TollbarBtn_closeTag;

        IWebElement replyTextField;
        IWebElement reply_approve;
        IWebElement reply_cancel;


        public Activity()
        {

            hide_show = driver.FindElement(By.XPath(@"//*[@id='dashboard_activity']/button/span[2]"));
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



            TollbarBtn_b = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[1]']"));
            TollbarBtn_i = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[2]']"));
            TollbarBtn_link = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[3]']"));
            TollbarBtn_qoute = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[4]']"));
            TollbarBtn_del = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[5]']"));
            TollbarBtn_ins = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[6]']"));
            TollbarBtn_img = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[7]']"));
            TollbarBtn_ul = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[8]']"));
            TollbarBtn_ol = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[9]']"));
            TollbarBtn_li = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[10]']"));
            TollbarBtn_code = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[11]']"));
            TollbarBtn_closeTag = driver.FindElement(By.XPath(@"//*[@id='qt_replycontent_toolbar/input[12]']"));

            replyTextField = driver.FindElement(By.XPath(@"//*[@id='replycontent']"));
            reply_approve = driver.FindElement(By.Id("replybtn"));
            reply_cancel = driver.FindElement(By.XPath(@"//*[@id='replysubmit']/p/button[2]"));


        }

        public void HideOrShowActivity()
        {
            hide_show.Click();
        }

        public void WriteReply(string str)
        {

            replyTextField.SendKeys(str);
        }

        public string GetComentText()
        {

            return comment.Text;
        }

        public void ApproveComent() {
            approve.Click();
        }
        public void UnapproveComent() {
            unapprove.Click();
        }
        public void ApproveReplyToComment()
        {
            reply_approve.Click();
        }
        public void CancelReplyToComment()
        {
            reply_cancel.Click();
        }


    }
}  
