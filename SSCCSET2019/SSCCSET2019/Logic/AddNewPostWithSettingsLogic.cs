using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSCCSET2019.Pages;
using SSCCSET2019.Data;
using SSCCSET2019.Tools;
using System.Threading;


namespace SSCCSET2019.Logic
{
    class AddNewPostWithSettingsLogic
    {
        public void OpenCategoriesBlock()
        {
            AddNewPostsWithSettings addNewPosts = new AddNewPostsWithSettings(Driver.GetDriver());
            addNewPosts.ClickArrowTwo();
        }
        public void OpenTagsBlock()
        {
            AddNewPostsWithSettings addNewPosts = new AddNewPostsWithSettings(Driver.GetDriver());
            addNewPosts.ClickArrowThree();

        }
        public void OpenFeaturedImageBlock()
        {
            AddNewPostsWithSettings addNewPosts = new AddNewPostsWithSettings(Driver.GetDriver());
            addNewPosts.ClickArrowFour();
        }
        public void OpenExcerptBlock()
        {
            AddNewPostsWithSettings addNewPosts = new AddNewPostsWithSettings(Driver.GetDriver());
            addNewPosts.ClickArrowFive();
        }
        public void OpenDiscussionBlock()
        {
            AddNewPostsWithSettings addNewPosts = new AddNewPostsWithSettings(Driver.GetDriver());
            addNewPosts.ClickArrowSix();
        }
        public void SetPublicVisibility()
        {
            AddNewPostsWithSettings addNewPosts = new AddNewPostsWithSettings(Driver.GetDriver());
            addNewPosts.ClickButtonVisibility();
            addNewPosts.ClickPublicVisibility();
        }
        public void SetPrivateVisibility()
        {
            AddNewPostsWithSettings addNewPosts = new AddNewPostsWithSettings(Driver.GetDriver());
            addNewPosts.ClickButtonVisibility();
            addNewPosts.ClickPrivateVisibility();
        }
        public void SetPasswordProtectedVisibility()
        {

            AddNewPostsWithSettings addNewPosts = new AddNewPostsWithSettings(Driver.GetDriver());
            addNewPosts.ClickButtonVisibility();
            addNewPosts.ClickPasswordProtectedVisibility();
        }
        public void SetStickToTheTopOfTheBlog()
        {
            AddNewPostsWithSettings addNewPosts = new AddNewPostsWithSettings(Driver.GetDriver());
            addNewPosts.ClickcCheckboxControlOne();
        }
        public void SetPendingReview()
        {
            AddNewPostsWithSettings addNewPosts = new AddNewPostsWithSettings(Driver.GetDriver());
            addNewPosts.ClickcCheckboxControlTwo();
        }
        public void SetAllowComments()
        {
            AddNewPostsWithSettings addNewPosts = new AddNewPostsWithSettings(Driver.GetDriver());
            addNewPosts.ClickcCheckboxControlFour();
        }
        public void SetAllowPingbacksAndTrackbacks()
        {
            AddNewPostsWithSettings addNewPosts = new AddNewPostsWithSettings(Driver.GetDriver());
            addNewPosts.ClickcCheckboxControlFive();
        }
    }
}
