using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SSCCSET2019.Pages.AllPostsPage;

namespace SSCCSET2019.Logic
{
    class AllPostsPageLogic
    {
        AllPosts allPostsPage;
        private IWebDriver driver;

        public AllPostsPageLogic(IWebDriver driver)
        {
            this.driver = driver;
            allPostsPage = new AllPosts(driver);
        }

        public AllPosts FocusApplyButton(int index)
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(allPostsPage.GetApplyButtons()[index]);
            builder.Perform();

            return allPostsPage;
        }

        public AllPosts FocusFiltersButton()
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(allPostsPage.GetFinterBtn());
            builder.Perform();

            return allPostsPage;
        }

        public AllPosts DisplayAllPosts()
        {
            allPostsPage.ClickAllPostsLabel();

            return allPostsPage;
        }

        public AllPosts DisplayPublishedPosts()
        {
            allPostsPage.ClickAllPostsLabel();

            return allPostsPage;
        }

        public AllPosts Filter(int dateIndex = -1, int categoryIndex = -1)
        { 
            if (dateIndex != -1)
                allPostsPage.SetDateByIndex(dateIndex-1);
            if (categoryIndex != -1)
                allPostsPage.SetCategoryByIndex(categoryIndex-1);
            allPostsPage.ClickApplyFilters();

            return allPostsPage;
        }

        public AllPosts HoverPost(int index)
        {
            var posts = allPostsPage.GetRecordsList();
            Actions builder = new Actions(driver);
            builder.MoveToElement(posts[index-1].GetPostElement());
            builder.Perform();

            return new AllPosts(driver,index-1);
        }
    }
}
