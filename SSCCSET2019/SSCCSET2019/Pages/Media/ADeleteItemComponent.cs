﻿using OpenQA.Selenium;
using SSCCSET2019.Tools.Driver;
using System.Collections.Generic;
using System.Linq;

namespace SSCCSET2019.Pages.Media
{
    class DeleteItem
    {
        private IWebDriver driver;
        public IWebElement DelPermButton { get { return driver.FindElement(By.CssSelector("button.button:nth-child(5)")); } }
        public IWebElement CancelBut { get { return driver.FindElement(By.CssSelector("button.button:nth-child(8)")); } }
        public DeleteItem(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
    public abstract class ADeleteItemComponent
    {
        private  IWebDriver driver;
        protected IWebElement _bulkButton { get { return driver.FindElement(By.CssSelector("button.button:nth-child(8)")); } }
        protected IWebElement _noMediaItem { get { return driver.FindElement(By.CssSelector(".no-media")); } }
        protected List<IWebElement> _allItems { get { return InitializeItemsList(driver.FindElements(By.CssSelector(".save-ready"))); } }
        private DeleteItem _deleteItem;
        public ADeleteItemComponent(IWebDriver driver)
        {
            this.driver = driver;
            VerifyWebElement();
        }
        #region Initialize
        private void VerifyWebElement()
        {
            List<IWebElement> elem;
            IWebElement temp = _bulkButton;
            if (_noMediaItem.Displayed)
            {
                temp = _noMediaItem;
            }
            else
            {
                elem = _allItems;
            }
        }
        private List<IWebElement> InitializeItemsList(IReadOnlyCollection<IWebElement> elements)
        {
            List<IWebElement> list = new List<IWebElement>();
            foreach (var current in elements)
            {
                list.Add(current);
            }
            return list;
        }
        #endregion Initialize
        #region AtomicOperations
        //DeleteItemAction
        public void BulkButtonClick()
        {
            _bulkButton.Click();
        }
        public bool IsNoMediaItemDispayed()
        {
            return _noMediaItem.Displayed;
        }
        public void DeleteItemButtonClick()
        {
            _deleteItem.DelPermButton.Click();
        }
        public int GetCurrentItems()
        {
            List<IWebElement> temp = _allItems;
            return temp.Count();
        }
        #endregion

        #region Functional DeleteItem
        //DeleteItem
        public void OpenDeleteItemBar()
        {
            BulkButtonClick();
            _deleteItem = new DeleteItem(Driver.GetDriver());
        }
        public void SelectItem(int index)
        {
            if (!IsNoMediaItemDispayed())
            {
                _allItems.ElementAt(index).Click();
            }
            
        }
        public void HandleAlertWindow(string action)
        {
            string accept = "accept";
            string dismiss = "cancel";
            if (action == accept)
            {
                driver.SwitchTo().Alert().Accept();
            }
            else if (action == dismiss)
            {
                driver.SwitchTo().Alert().Dismiss();
            }
        }
        public LibraryGrid CloseDeleteItemBar()
        {
            _deleteItem.CancelBut.Click();
            return new LibraryGrid(Driver.GetDriver());
        }
        #endregion
    }
}
