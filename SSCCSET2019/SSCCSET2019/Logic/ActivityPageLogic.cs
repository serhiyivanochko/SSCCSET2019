using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SSCCSET2019.Pages.HomePage;
using SSCCSET2019.Tools.Driver;

namespace SSCCSET2019.Logic
{
    class ActivityPageLogic
    {
        IWebDriver driver = Driver.GetDriver();
        public void MakeReply(string replyText) 
        {
            Activity act = new Activity(driver);
            act.elements.ClickOnReply()
            .ClickOnReplyTextField()
            .ClearReplyTextField()
            .SetTextInReplyTextField(replyText)
            .ClickApproveReplyToComment();
        }
    }
}
