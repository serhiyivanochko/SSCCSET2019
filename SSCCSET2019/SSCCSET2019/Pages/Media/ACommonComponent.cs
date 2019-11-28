using OpenQA.Selenium;

namespace SSCCSET2019.Pages.Media
{
    class AddNewItem
    {
        private IWebDriver driver;
        public IWebElement SelectFileBut { get { return driver.FindElement(By.CssSelector(".button-hero")); } }
        public IWebElement CloseAddNewBut { get { return driver.FindElement(By.CssSelector(".close")); } }
        public AddNewItem(IWebDriver driver)
        {
            this.driver = driver;
        }
        
    }
    public abstract class ACommonComponent : ADeleteItemComponent
    {
        public IWebDriver driver;
        //AddNewItem
        private IWebElement _addNewBut { get { return driver.FindElement(By.CssSelector(".page-title-action")); } }
        private AddNewItem _addNewItem;
        public ACommonComponent(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            VerifyWebElements();
        }
        private void VerifyWebElements()
        {
            IWebElement temp = _addNewBut;
        }
        #region AtomicOperations
        //AddNewButton
        public void AddNewButtonClick()
        {
            _addNewBut.Click();
        }
        public void SelectFileButtonClick()
        {
            _addNewItem.SelectFileBut.Click();
        }
        public void CloseAddNewButtonClick()
        {
            _addNewItem.CloseAddNewBut.Click();
        }
        #endregion

        #region Functional AddNewItem
        //AddNewItem
        public void OpenAddNewPopUp()
        {
            AddNewButtonClick();
            _addNewItem = new AddNewItem(driver);
        }
        #endregion
    }
}
