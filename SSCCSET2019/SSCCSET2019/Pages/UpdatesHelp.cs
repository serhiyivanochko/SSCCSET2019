using OpenQA.Selenium;

namespace SSCCSET2019.Pages
{
    class UpdatesHelp
    {
        IWebDriver driver;
        public UpdatesHelpElements elements;
        public UpdatesHelp(IWebDriver driver)
        {
            this.driver = driver;
            elements = new UpdatesHelpElements(driver);
        }
    }
}
