using System.Collections.Generic;
using System.Windows.Forms;
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
            return library.GetListItemsName();
        }
        public string AddNewItem(string name)
        {
            LibraryGrid library = new LibraryGrid(Driver.GetDriver());
            library.OpenAddNewPopUp();
            library.SelectFileButtonClick();
            SendKeys.SendWait($@"D:\{name}");
            SendKeys.SendWait(@"{Enter}");
            return name;
        }
        public LibraryGrid DeleteItem(int index, string action)
        {
            LibraryGrid library = new LibraryGrid(Driver.GetDriver());
            library.OpenDeleteItemBar();
            library.SelectItem(index);
            library.DeleteItemButtonClick();
            library.HandleAlertWindow(action);
            return new LibraryGrid(Driver.GetDriver());
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
            
            return library.GetListItemsName().Count;
        }
        public int GetElementsFilteredByData(string date)
        {
            LibraryGrid library = new LibraryGrid(Driver.GetDriver());
            library.SetDropDownDataValue(date);
            
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
