using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SSCCSET2019
{
    public class Driver
    {
        private static Driver instance;
        public IWebDriver driver = new ChromeDriver();

        private Driver()
        {
        }

        public static Driver getInstance()
        {
            if (instance == null)
                instance = new Driver();

            return instance;
        }
    }
}
