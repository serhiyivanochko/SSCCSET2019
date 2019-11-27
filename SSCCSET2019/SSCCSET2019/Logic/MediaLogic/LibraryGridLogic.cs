using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;
using SSCCSET2019.Pages.Media;
using SSCCSET2019.Tools.Driver;

namespace SSCCSET2019.Logic
{
    class LibraryGridLogic
    {
        public List<string> SearchElementByText(string input)
        {
            LibraryGrid library = new LibraryGrid(Driver.GetDriver());
            library.TextFieldClick();
            library.TextFieldClear();
            library.TextFieldInput(input);
            //Thread.Sleep(2000); /// TODO
            //var wait = new WebDriverWait(library.driver, new System.TimeSpan(10)); // Is this ok to send driver like this?
            
            return library.GetListItemsName();
        }
        public string AddNewItem(string name)
        {
            LibraryGrid library = new LibraryGrid(Driver.GetDriver());
            library.OpenAddNewPopUp();
            library.SelectFileButtonClick();
            SendKeys.SendWait($@"D:\{name}");
            SendKeys.SendWait(@"{Enter}");
            Thread.Sleep(2000);
            return name;
        }
        public int DeleteItem(int index, string action)
        {
            LibraryGrid library = new LibraryGrid(Driver.GetDriver());
            library.OpenDeleteItemBar();
            library.SelectItem(index);
            library.DeleteItemButtonClick();
            library.HandleAlertWindow(action);
            Thread.Sleep(2000);
            return library.GetCurrentItems();
        }
        public LibraryGrid OrderByGrid()
        {
            LibraryGrid order = new LibraryGrid(Driver.GetDriver());
            order.ShowGridSortingButtonClick();
            return new LibraryGrid(Driver.GetDriver());
        }
        /// TODO: someone else class
        //public LibraryList OrderByList()
        //{
        //    LibraryGrid order = new LibraryGrid(driver);
        //    order.ShowListSortingButtonClick();
        //    return new LibraryList();
        //}

        public int GetElementsFilteredByType(string type)
        {
            LibraryGrid library = new LibraryGrid(Driver.GetDriver());
            library.SetDropDownTypeValue(type);
            Thread.Sleep(2000);
            return library.GetListItemsName().Count;
        }
        public int GetElementsFilteredByData(string data)
        {
            LibraryGrid library = new LibraryGrid(Driver.GetDriver());
            library.SetDropDownDataValue(data);
            Thread.Sleep(2000);
            return library.GetListItemsName().Count;
        }
        /// TODO: someone else class
        //public Help OpenHelp()
        //{
        //    LibraryGrid library = new LibraryGrid(driver);
        //    library.HelpButtonClick();
        //   return new Help(driver);
        //}
    }
}
