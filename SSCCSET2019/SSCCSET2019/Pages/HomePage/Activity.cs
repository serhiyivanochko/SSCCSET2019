using OpenQA.Selenium;

namespace SSCCSET2019.Pages.HomePage
{
    class Activity
    {
        IWebDriver driver;
        public ActivityElements elements;

        public Activity(IWebDriver driver) 
        {
            this.driver = driver;
            elements = new ActivityElements(driver);
        }
    }
}
