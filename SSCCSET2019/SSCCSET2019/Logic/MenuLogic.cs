using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SSCCSET2019.Pages;

namespace SSCCSET2019.Logic
{
    public class MenuLogic
    {
        IWebDriver driver;
        Dictionary<string, Item> menu = new Dictionary<string, Item>();
        public MenuLogic()
        {

            var MenuItems = driver.FindElements(By.XPath("//*[@id='adminmenu']/li"));

            foreach (var current in MenuItems)
            {
                var listSubitem = current.FindElements(By.XPath("/li")).ToList();
                Item item = new Item(current, listSubitem);
                menu.Add(current.Text ,item);
            }
        }
        void SelectTab(string tab)
        {
            menu[tab].ClickOnRootItem();
        }
    }
}
