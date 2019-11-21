using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SSCCSET2019.Pages
{
    class MainPage
    {
        static IWebDriver Driver = new ChromeDriver();

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

        IWebElement button_header_close = Driver.FindElement(By.XPath("//*[@id='welcome-panel']/a"));

        //Quick draft
        IWebElement headline = Driver.FindElement(By.Id("title"));
        IWebElement content = Driver.FindElement(By.Id("content"));
        IWebElement button_save = Driver.FindElement(By.Id("save-post"));
        IWebElement button_hide = Driver.FindElement(By.XPath("//*[@id='dashboard_quick_press']/button"));

        //News 
        IWebElement button_close = Driver.FindElement(By.ClassName("toggle-indicator"));
        IWebElement button_edit = Driver.FindElement(By.ClassName("dashicons dashicons-edit"));
        IWebElement town_input = Driver.FindElement(By.Id("community-events-location"));
        IWebElement button_send = Driver.FindElement(By.Id("community-events-submit"));
        IWebElement button_cancel = Driver.FindElement(By.ClassName("community-events-cancel button-link"));
        IWebElement link_1 = Driver.FindElement(By.XPath("//*[@id='dashboard_primary']/div/div[4]/div[1]/ul/li/a"));
        IWebElement link_2 = Driver.FindElement(By.XPath("//*[@id='dashboard_primary']/div/div[4]/div[2]/ul/li[1]/a"));
        IWebElement link_3 = Driver.FindElement(By.XPath("//*[@id='dashboard_primary']/div/div[4]/div[2]/ul/li[2]/a"));
        IWebElement link_4 = Driver.FindElement(By.XPath("//*[@id='dashboard_primary']/div/div[4]/div[2]/ul/li[3]/a"));
        IWebElement link_meetings = Driver.FindElement(By.XPath("//*[@id='dashboard_primary']/div/p/a[1]"));
        IWebElement link_wordcamp = Driver.FindElement(By.XPath("//*[@id='dashboard_primary']/div/p/a[2]"));
        IWebElement link_news = Driver.FindElement(By.XPath("//*[@id='dashboard_primary']/div/p/a[3]"));

        //Atomic methods

        //Header
        public MainPage buttonClick()
        {
            button_settings.Click();
            return this;
        }
        public MainPage clickOn_Link_theme()
        {
            link_theme.Click();
            return this;
        }
        public MainPage Link_firstRecord()
        {
            link_firstRecord.Click();
            return this;
        }
        public MainPage Link_createPage()
        {
            link_createPage.Click();
            return this;
        }
        public MainPage Link_setMainPage()
        {
            link_setMainPage.Click();
            return this;
        }
        public MainPage Link_lookSite()
        {
            link_lookSite.Click();
            return this;
        }
        public MainPage Link_vidgets()
        {
            link_vidgets.Click();
            return this;
        }
        public MainPage Link_menu()
        {
            link_menu.Click();
            return this;
        }
        public MainPage Link_turnOffComments()
        {
            link_turnOffComments.Click();
            return this;
        }
        public MainPage Link_learnMore()
        {
            link_learnMore.Click();
            return this;
        }
        public MainPage Button_header_close()
        {
            button_header_close.Click();
            return this;
        }
        //Quick Draft
        public MainPage click_on_input_in_headline()
        {
            headline.Click();
            return this;

        }
        public MainPage clear_input_in_headline()
        {
            headline.Clear();
            return this;

        }
        public MainPage sendKeys_in_input_in_headline(string str)
        {
            headline.SendKeys(str);
            return this;
        }
        public MainPage click_on_input_Content()
        {
            content.Click();
            return this;
        }
        public MainPage clear_input_Content()
        {
            content.Clear();
            return this;
        }
        public MainPage sendKeys_in_input_Content(string str)
        {
            content.SendKeys(str);
            return this;
        }
        public MainPage Button_save()
        {
            button_save.Click();
            return this;
        }
        public MainPage Button_hide()
        {
            button_hide.Click();
            return this;
        }
        //News
        public MainPage Button_close()
        {
            button_close.Click();
            return this;
        }
        public MainPage Button_edit()
        {
            button_edit.Click();
            return this;
        }
        public MainPage click_on_town_input()
        {
            town_input.Click();
            return this;
        }
        public MainPage clear_town_input()
        {
            town_input.Clear();
            return this;
        }
        public MainPage sendKeys_in_town_input(string str)
        {
            town_input.SendKeys(str);
            return this;
        }
        public MainPage Button_send()
        {
            button_send.Click();
            return this;
        }
        public MainPage Button_cancel()
        {
            button_cancel.Click();
            return this;
        }
        public MainPage click_Link_1()
        {
            link_1.Click();
            return this;
        }
        public MainPage click_Link_2()
        {
            link_2.Click();
            return this;
        }
        public MainPage click_Link_3()
        {
            link_3.Click();
            return this;
        }
        public MainPage click_Link_4()
        {
            link_4.Click();
            return this;
        }
        public MainPage click_Link_meetings()
        {
            link_meetings.Click();
            return this;
        }
        public MainPage click_Link_wordcamp()
        {
            link_wordcamp.Click();
            return this;
        }
        public MainPage click_Link_news()
        {
            link_news.Click();
            return this;
        }
    }
}
