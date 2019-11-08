using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCCSET2019.Pages.Tags
{
    class Tags
    {
        IWebDriver driver = Driver.GetDriver();

        IWebElement bulkActionSelectorTop;
        IWebElement bulkActionSelectorBotton;
        IWebElement doActionTopButton;
        IWebElement doActionBottonButton;
        IWebElement checkBoxAllTop;
        IWebElement checkBoxAllBotton;
        IWebElement sortingIndicatorTopOne;
        IWebElement sortingIndicatorTopTwo;
        IWebElement sortingIndicatorTopThree;
        IWebElement sortingIndicatorTopFour;
        IWebElement sortingIndicatorBottonOne;
        IWebElement sortingIndicatorBottonTwo;
        IWebElement sortingIndicatorBottonThree;
        IWebElement sortingIndicatorBottonFour;
        IWebElement searchBoxTags;
        IWebElement searchTagsButton;
        IWebElement textBetweenSortingIndicators;
        IWebElement textUnderBottonBulkAction;

        public Tags()
        {
            bulkActionSelectorTop = driver.FindElement(By.Id("bulk-action-selector-top"));
            doActionTopButton = driver.FindElement(By.Id("doaction1"));
            bulkActionSelectorBotton = driver.FindElement(By.Id("bulk - action - selector - bottom"));
            doActionBottonButton = driver.FindElement(By.Id("doaction2"));
            checkBoxAllBotton = driver.FindElement(By.XPath(@"//*[@id='cb - select - all - 2']"));
            checkBoxAllTop = driver.FindElement(By.XPath(@"//*[@id='cb - select - all - 1']"));
            sortingIndicatorBottonFour = driver.FindElement(By.XPath(@"//*[@id='posts - filter']/table/tfoot/tr/th[4]/a/span[1]"));
            sortingIndicatorBottonThree = driver.FindElement(By.XPath(@"//*[@id='posts - filter']/table/tfoot/tr/th[3]/a/span[1]"));
            sortingIndicatorBottonTwo = driver.FindElement(By.XPath(@"//*[@id='posts - filter']/table/tfoot/tr/th[2]/a/span[1]"));
            sortingIndicatorBottonOne = driver.FindElement(By.XPath(@"//*[@id='posts - filter']/table/tfoot/tr/th[1]/a/span[1]"));
            sortingIndicatorTopFour = driver.FindElement(By.XPath(@"//*[@id='posts']/a/span[1]"));
            sortingIndicatorTopOne = driver.FindElement(By.XPath(@"//*[@id='name']/a/span[1]"));
            sortingIndicatorTopThree = driver.FindElement(By.XPath(@"//*[@id='slug']/a/span[1]"));
            sortingIndicatorTopTwo = driver.FindElement(By.XPath(@"//*[@id='description']/a/span[1]"));
            searchBoxTags = driver.FindElement(By.Id("tag-search-input"));
            searchTagsButton = driver.FindElement(By.Id("search-submit"));
            textBetweenSortingIndicators = driver.FindElement(By.XPath(@"//*[@id='the - list']/tr/td"));
            textUnderBottonBulkAction = driver.FindElement(By.XPath(@"//*[@id='col - right']/div/div/p"));
        }
   
    }
}
