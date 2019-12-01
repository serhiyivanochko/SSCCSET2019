using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SSCCSET2019.Pages.Media
{
    public class LibraryGrid : ACommonComponent
    {
        private new IWebDriver driver;

        protected IWebElement _showGrid { get { return driver.FindElement(By.CssSelector(".view-grid")); } }
        private IWebElement _showList { get { return driver.FindElement(By.CssSelector(".view-list")); } }
        private IWebElement _textField { get { return driver.FindElement(By.Id("media-search-input")); } }
        private IWebElement _helpButton {get { return driver.FindElement(By.Id("contextual-help-link")); } }
        private List<string> _items { get { return InitializeItemsNameList(driver.FindElements(By.CssSelector(".save-ready"))); } }
        private SelectElement _dropdownType { get { return new SelectElement(driver.FindElement(By.Id("media-attachment-filters"))); } }
        private SelectElement _dropdownData { get { return new SelectElement(driver.FindElement(By.Id("media-attachment-date-filters"))); } }
        public LibraryGrid(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            VerifyWebElement();
        }
        #region Initialization
        private void VerifyWebElement()
        {
            IWebElement elem = _showGrid;
            elem = _showList;
            elem = _textField;
            elem = _helpButton;
            SelectElement select = _dropdownData;
            select = _dropdownType;
        }
        private List<string> InitializeItemsNameList(ReadOnlyCollection<IWebElement> elements)
        {
            List<string> list = new List<string>();
            foreach (var current in elements)
            {
                list.Add(current.GetAttribute("aria-label"));
            }
            return list;
        }
        #endregion

        #region AtomicOperations
        public List<string> GetListItemsName()
        {
            var temp = _items;
            return temp;
        }
        //Text field
        public void TextFieldClear()
        {
            _textField.Clear();
        }
        public void TextFieldClick()
        {
            _textField.Click();
        }
        public void TextFieldInput(string input)
        {
            _textField.SendKeys(input);
        }
        public string GetTextFieldInput()
        {
            return _textField.Text;
        }
        //DropDowns
        public LibraryGrid SetDropDownTypeValue(string type)
        {
            _dropdownType.SelectByText(type);
            return this;
        }
        public LibraryGrid SetDropDownDataValue(string data)
        {
            _dropdownData.SelectByText(data);
            return this;
        }
        //GridSortingButton
        public LibraryGrid ShowGridSortingButtonClick()
        {
            _showGrid.Click();
            return this;
        }
        //HelpButton
        public void HelpButtonClick()
        {
            _helpButton.Click();
        }
        ///TODO: someone else class
        //public void ShowListSortingButtonClick()
        //{
        //    showList.Click();
        //}
        #endregion
    }
}
