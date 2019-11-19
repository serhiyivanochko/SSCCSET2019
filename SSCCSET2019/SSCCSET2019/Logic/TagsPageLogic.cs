using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSCCSET2019.Pages.Posts.AddedTags;
using SSCCSET2019.Pages.Tags;
using SSCCSET2019.Tools.Driver;
using SSCCSET2019.Data.ApplicationSource;
using OpenQA.Selenium;

namespace SSCCSET2019.Logic
{
    class TagsPageLogic
    {
        public Tags AddNewTagsWithSlugAndDescription(string tagName, string slug, string description, IWebDriver driver)
        {
            Tags tags = new Tags(driver);
            tags.ClearNameEdit();
            tags.ClickNameEdit();
            tags.InputName(tagName);
            tags.ClearSlugEdit();
            tags.ClickSlugEdit();
            tags.InputSlug(slug);
            tags.ClearDescriptionEdit();
            tags.ClickDescriptionEdit();
            tags.InputDescription(description);
            tags.ClickAddNewTagButton();
            return tags;
        }
        public Tags AddNewTagsWithSlug(string tagName, string slug, IWebDriver driver)
        {
            Tags tags = new Tags(driver);
            tags.ClearNameEdit();
            tags.ClickNameEdit();
            tags.InputName(tagName);
            tags.ClearSlugEdit();
            tags.ClickSlugEdit();
            tags.InputSlug(slug);
            tags.ClickAddNewTagButton();
            return tags;
        }

    }
}
