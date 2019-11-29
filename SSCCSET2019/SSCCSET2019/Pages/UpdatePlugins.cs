using OpenQA.Selenium;

namespace SSCCSET2019.Pages
{
    class UpdatePlugins
    {
        IWebDriver driver;
        public UpdatePluginsElements elements;

        public UpdatePlugins(IWebDriver webDriver) 
        { 
            this.driver = webDriver;
            elements = new UpdatePluginsElements(driver);
        }
    }
}
