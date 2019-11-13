using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SSCCSET2019.Help_and_ScreenParameters
{
    public class Contextual_help
    { IWebDriver driver;

        //contextual-help-sidebar
        public IWebElement MoreInfoLabel
        { get { return driver.FindElement(By.XPath("//*[@id='contextual-help-columns']/div[2]/p[1]/strong")); } }
        public IWebElement CommentsDocs
        { get { return driver.FindElement(By.XPath("//*[contains (@href,'https://codex.wordpress.org/Administration_Screens#Comments')]")); } }
        public IWebElement CommentsSpamDocs
        { get { return driver.FindElement(By.XPath("//*contains (@href,'https://codex.wordpress.org/Comment_Spam')]")); } }
        public IWebElement HotKeyDocs
        { get { return driver.FindElement(By.XPath("//* [contains (@href,'https://codex.wordpress.org/Keyboard_Shortcuts')]")); } }
        public IWebElement SupportForum
        { get { return driver.FindElement(By.XPath("//* [contains (@href,'https://uk.wordpress.org/support/')]")); } }

        //contextual-help-back

        public IWebElement ContextualHelpBack
        { get { return driver.FindElement(By.Id("contextual-help-back")); } }

        //contextual-help-tabs
        public IWebElement Overview
        { get { return driver.FindElement(By.Id("tab-link-overview")); } }
        public IWebElement ModeratingComments
        { get { return driver.FindElement(By.Id("tab - link - moderating - comments")); } }


    }
}
