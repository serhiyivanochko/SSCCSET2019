using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SSCCSET2019.Pages
{
    class EditRecordPage
    {
        IWebDriver driver = Driver.GetInstance().driver;

        IWebElement elemement;



        public EditRecordPage()
        {
            elemement = driver.FindElement(By.Id("1"));
        }
    }
}
