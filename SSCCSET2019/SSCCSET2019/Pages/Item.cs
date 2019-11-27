using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SSCCSET2019.Pages
{
    class Item
    {
        
        IWebElement option;
        List<IWebElement> items = new List<IWebElement>();

        public Item(IWebElement _option, List<IWebElement> _items)
        {
            option = _option;
            items = _items;
        }

        public void ClickOnRootItem()
        {
            option.Click();
        }
        

        
    }
}
