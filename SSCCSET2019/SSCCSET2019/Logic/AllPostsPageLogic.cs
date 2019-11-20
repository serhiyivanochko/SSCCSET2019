using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SSCCSET2019.Pages.AllPostsPage;

namespace SSCCSET2019.Logic
{
    class AllPostsPageLogic
    {
        private IWebDriver driver;


        public AllPostsPageLogic()
        {
        }

        public AllPosts FocusApplyButton(int index)
        {
            AllPosts allPosts = new AllPosts();
            Actions builder = new Actions(driver);
            builder.MoveToElement(allPosts.GetApplyButtons()[index]);
            builder.Perform();
            return allPosts;
        }

        public AllPosts FocusFiltersButton()
        {
            AllPosts allPosts = new AllPosts();
            Actions builder = new Actions(driver);
            builder.MoveToElement(allPosts.GetFinterBtn());
            builder.Perform();
            return allPosts;
        }

        public AllPosts DisplayAllPosts()
        {
            AllPosts allPosts = new AllPosts();
            allPosts.ClickAllPostsLabel();
            return allPosts;
        }

        public AllPosts DisplayPublishedPosts()
        {
            AllPosts allPosts = new AllPosts();
            allPosts.ClickAllPostsLabel();
            return allPosts;
        }

        public AllPosts Filter(int dateIndex = -1, int categoryIndex = -1)
        { 
            AllPosts allPosts = new AllPosts();
            if (dateIndex != -1)
                allPosts.SetDateByIndex(dateIndex);
            if (categoryIndex != -1)
                allPosts.SetCategoryByIndex(categoryIndex);
            allPosts.ClickApplyFilters();
            return new AllPosts();
        }

        public AllPosts HoverPost(int index)
        {
            AllPosts allPostsPage = new AllPosts();
            var posts = allPostsPage.GetRecordsList();
            Actions builder = new Actions(driver);
            builder.MoveToElement(posts[index-1].GetPostElement());
            builder.Perform();
            return new AllPosts(index-1);
        }
    }
}
