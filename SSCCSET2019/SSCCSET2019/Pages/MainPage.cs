using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;

namespace WordPressTest.Pages
{
    class Console_Page
    {
        static IWebDriver Driver = new ChromeDriver();
        //Оголошення головних елеметів сторінки

        //Header
        IWebElement button_settings = Driver.FindElement(By.XPath("//*[@id='welcome - panel']/div/div/div[1]/a[1]"));
        IWebElement link_theme = Driver.FindElement(By.XPath("//*[@id='welcome - panel']/div/div/div[1]/p/a"));
        IWebElement link_firstRecord = Driver.FindElement(By.XPath("//*[@id='welcome - panel']/div/div/div[2]/ul/li[1]/a"));
        IWebElement link_createPage = Driver.FindElement(By.XPath("//*[@id='welcome - panel']/div/div/div[2]/ul/li[2]/a"));
        IWebElement link_setMainPage = Driver.FindElement(By.XPath("//*[@id='welcome - panel']/div/div/div[2]/ul/li[3]/a"));
        IWebElement link_lookSite = Driver.FindElement(By.XPath("//*[@id='welcome - panel']/div/div/div[2]/ul/li[4]/a"));

        IWebElement link_vidgets = Driver.FindElement(By.XPath("//*[@id='welcome - panel']/div/div/div[3]/ul/li[1]/div/a[1]"));
        IWebElement link_menu = Driver.FindElement(By.XPath("//*[@id='welcome - panel']/div/div/div[3]/ul/li[1]/div/a[2]"));
        IWebElement link_turnOffComments = Driver.FindElement(By.XPath("//*[@id='welcome - panel']/div/div/div[3]/ul/li[2]/a"));
        IWebElement link_learnMore = Driver.FindElement(By.ClassName("welcome-panel-close"));
        //Quick draft

        IWebElement headline = Driver.FindElement(By.Id("title"));
        IWebElement content = Driver.FindElement(By.Id("content"));
        IWebElement button_save = Driver.FindElement(By.Id("save-post"));
        IWebElement button_hide = Driver.FindElement(By.XPath("//*[@id='dashboard_quick_press']/button"));

        //Подивитись до типу повернення адаптивних методів 
        public void buttonClick()
        {
            button_settings.Click();
        }
        public void Link_theme()
        {
            link_theme.Click();
        }
        public void Link_firstRecord()
        {
            link_firstRecord.Click();
        }
        public void Link_createPage()
        {
            link_createPage.Click();
        }
        public void Link_setMainPage()
        {
            link_setMainPage.Click();
        }
        public void Link_lookSite()
        {
            link_lookSite.Click();
        }
        public void Link_vidgets()
        {
            link_vidgets.Click();
        }
        public void Link_menu()
        {
            link_menu.Click();
        }
        public void Link_turnOffComments()
        {
            link_turnOffComments.Click();
        }
        public void Link_learnMore()
        {
            link_learnMore.Click();
        }
        public string Get_headline()
        {
            return headline.Text;
        }
        public void write_Content(string str)
        {
            content.Clear();
            content.SendKeys(str);
        }
        public void Button_save()
        {
            button_save.Click();
        }
        public void Button_hide()
        {
            button_hide.Click();
        }


    }
}