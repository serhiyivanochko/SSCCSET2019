using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSCCSET2019.Pages.Posts.QuickEditTag;
using SSCCSET2019.Pages.Posts;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Data.ApplicationSource;
using OpenQA.Selenium;

namespace SSCCSET2019.Logic.TagsPageLogic
{
    class TagsPageLogic
    {
        public Tags UpdateTagWithNameAndSlug(string tagName, string slug)
        {
            QuikEditTag tags = new QuikEditTag(Driver.GetDriver());
            tags.ClearInputName();
            tags.ClickInputName();
            tags.EditInputName(tagName);
            tags.ClearInputSlug();
            tags.ClickInputSlug();
            tags.EditInputSlug(slug);
            tags.ClickUpdateTagButton();
            return new Tags(Driver.GetDriver());
        }
    }
}
