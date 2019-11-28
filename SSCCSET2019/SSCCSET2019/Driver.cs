using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    
    public class Driver
    {
        private static Driver instance;
        public IWebDriver driver;

        private Driver()
        {
            driver = new ChromeDriver();
        }
        public static Driver GetInstance()
        {
            if (instance == null)
            {
                instance = new Driver();
                return instance;

            }
        }
    }
}
