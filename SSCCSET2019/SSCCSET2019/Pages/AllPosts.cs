using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SSCCSET2019.Pages
{
    class AllPosts
    {
        IWebDriver driver = Driver.GetInstance().driver;

        IWebElement allLabel;
        IWebElement publishedLabel;
        IWebElement allPostsCount;
        IWebElement publishedPostsCount;
        IWebElement bulkActionSelectorTop;
        IWebElement applyBtn;
        IWebElement filterByDateSelector;
        IWebElement categorySelector;
        IWebElement filterBtn;
        IWebElement displayingSumLabel;



        public AllPosts()
        {
            allLabel = driver.FindElement(By.XPath(@"//li[@class='all']/a"));
            allPostsCount = driver.FindElement(By.XPath(@"//li[@class='all']/a/span"));
            publishedLabel = driver.FindElement(By.XPath("//li[@class='published']/a"));
            publishedPostsCount = driver.FindElement(By.XPath(@"//li[@class='published']/span"));
            bulkActionSelectorTop = driver.FindElement(By.Id("bulk-action-selector-top"));
            applyBtn = driver.FindElement(By.Id("doaction"));
            filterByDateSelector = driver.FindElement(By.Id("filter-by-date"));
            categorySelector = driver.FindElement(By.Id("cat"));
            filterBtn = driver.FindElement(By.Id("post-query-submit"));
            displayingSumLabel = driver.FindElement(By.XPath("//span[@class='displaying-num']"));
            driver.FindElement(By.Id(""));
        }

        public string GetAllLabel()
        {
            return allLabel.Text;
        }

        public string GetAllPostsCount()
        {
            return allPostsCount.Text;
        }



    }
}
