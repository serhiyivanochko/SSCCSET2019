using OpenQA.Selenium;
using System.Threading;

namespace SSCCSET2019.Pages.HomePage
{
    class AtGlance
    {
        IWebDriver driver;
        public AtGlanceElements elements;
        public AtGlance(IWebDriver driver) 
        {
            this.driver = driver;
            elements = new AtGlanceElements(driver);
        }
        
    }
}
   

