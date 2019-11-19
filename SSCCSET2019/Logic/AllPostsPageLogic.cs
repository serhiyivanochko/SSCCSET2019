using System;
using SSCCSET2019.Pages;
namespace SSCCSET2019.Logic
{
    public class AllPostsPageLogic
    {
        public AllPosts SearchPage(string pageTitle)
        {
            AllPosts page = new AllPosts();
            page.searchTextField.Clear();
            page.SetTextInSearchTextField(pageTitle);
            page.ClickSearchButton();
            return page;
        }
        public AllPosts BulkActionsSelect(int index)
        {
            AllPosts page = new AllPosts();
            page.SetaBulkActionSelectorByIndex(index);
            page.ClickApplyButton();
            return page;

        }

        public AllPostsPageLogic()
        {
        }



    }
}
