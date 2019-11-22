using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace SSCCSET2019.Pages
{
    
    class ScreenSettings
    {
        public enum Pages
        {
            Main,
            Updates,
            AllNotes,
            AddNew,
            Categories,
            Tags,
            Library,
            AddNewFile,
            AllPages,
            AddNewPage,
            Comments,
            Themes,
            Settings,
            Widgets, 
            Menu,
            Editor,
            SettedPlugins,
            AddNewPlugin,
            EditorOfPlugins,
            AllCustoms,
            AddCustom,
            YourAccount,
            Available,
            Export,
            Import,
            HealthOfSite,
            ExportData,
            RemoveData,
            AtAll,
            Writing,
            Reading,
            Talking,
            Mediafiles,
            PermanentLink,
            Confidence
        }
        IWebDriver driver;
        public void BrowserStart()
        {
            driver = new FirefoxDriver();
        }
        //Mainpage
        private IWebElement in_sight;
        private IWebElement activity;
        private IWebElement quick_draft;
        private IWebElement news_of_wordpress;
        private IWebElement welcome;
        private IWebElement author;
        private IWebElement categories;
        private IWebElement tags;
        private IWebElement comments;
        private IWebElement date;
        private IWebElement numbers_of_notes;
        private IWebElement apply;
        private IWebElement view_as_list;
        private IWebElement view_the_details;
        private IWebElement description;
        private IWebElement part_of_the_link;
        private IWebElement number;
        private IWebElement downloaded_for;
        private IWebElement response;
        private IWebElement sent;
        private IWebElement pages;
        private IWebElement posts;
        private IWebElement customs_link;
        private IWebElement goal_of_link;
        private IWebElement title_atributes;
        private IWebElement class_css;
        private IWebElement xfn;
        private IWebElement email;
        private IWebElement role;
        public ScreenSettings(Pages p)
        {
            switch (p)
            {
                case Pages.Main:
                    in_sight = driver.FindElement(By.Name("dashboard_right_now-hide"));
                    activity = driver.FindElement(By.Name("dashboard_activity-hide"));
                    quick_draft = driver.FindElement(By.Name("dashboard_quick_press-hide"));
                    news_of_wordpress = driver.FindElement(By.Name("dashboard_primary-hide"));
                    welcome = driver.FindElement(By.Id("wp_welcome_panel-hide"));
                    break;
                case Pages.Updates:
                    break;
                case Pages.AllNotes:
                    author = driver.FindElement(By.Name("author-hide"));
                    categories = driver.FindElement(By.Name("categories-hide"));
                    tags = driver.FindElement(By.Name("tags-hide"));
                    comments = driver.FindElement(By.Name("comments-hide"));
                    date = driver.FindElement(By.Name("date-hide"));
                    numbers_of_notes = driver.FindElement(By.Id("edit_post_per_page"));
                    view_as_list = driver.FindElement(By.Id("list-view-mode"));
                    view_the_details = driver.FindElement(By.Id("expert-view-mode"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                case Pages.AddNew:
                    break;
                case Pages.Categories:
                    description = driver.FindElement(By.Name("description-hide"));
                    part_of_the_link = driver.FindElement(By.Name("slug-hide"));
                    number = driver.FindElement(By.Name("posts-hide"));
                    numbers_of_notes = driver.FindElement(By.Id("edit_category_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                case Pages.Tags:
                    description = driver.FindElement(By.Name("description-hide"));
                    part_of_the_link = driver.FindElement(By.Name("slug-hide"));
                    number = driver.FindElement(By.Name("posts-hide"));
                    numbers_of_notes = driver.FindElement(By.Id("edit_post_tag_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                case Pages.Library:
                    author = driver.FindElement(By.Name("author-hide"));
                    downloaded_for = driver.FindElement(By.Name("parent-hide"));
                    comments = driver.FindElement(By.Name("comments-hide"));
                    date = driver.FindElement(By.Name("date-hide"));
                    numbers_of_notes = driver.FindElement(By.Id("upload_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                case Pages.AddNewFile:
                    break;
                case Pages.AllPages:
                    author = driver.FindElement(By.Name("author-hide"));
                    comments = driver.FindElement(By.Name("comments-hide"));
                    date = driver.FindElement(By.Name("date-hide"));
                    numbers_of_notes = driver.FindElement(By.Id("edit_page_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                case Pages.AddNewPage:
                    break;
                case Pages.Comments:
                    author = driver.FindElement(By.Name("author-hide"));
                    response = driver.FindElement(By.Name("response-hide"));
                    sent = driver.FindElement(By.Name("date-hide"));
                    numbers_of_notes = driver.FindElement(By.Id("edit_comments_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                case Pages.Themes:
                    break;
                case Pages.Settings:
                    break;
                case Pages.Widgets:
                    break;
                case Pages.Menu:
                    pages = driver.FindElement(By.Name("add-post-type-page-hide"));
                    posts = driver.FindElement(By.Name("add-post-type-post-hide"));
                    customs_link = driver.FindElement(By.Name("add-custon-links-hide"));
                    categories = driver.FindElement(By.Name("add-category-hide"));
                    tags = driver.FindElement(By.Name("add-post-tag-hide"));
                    goal_of_link = driver.FindElement(By.Name("link-target-hide"));
                    title_atributes = driver.FindElement(By.Name("title-attribute-hide"));
                    class_css = driver.FindElement(By.Name("css-classes-hide"));
                    xfn = driver.FindElement(By.Name("xfn-hide"));
                    description = driver.FindElement(By.Name("description-hide"));
                    break;
                case Pages.Editor:
                    break;
                case Pages.SettedPlugins:
                    description = driver.FindElement(By.Name("description-hide"));
                    numbers_of_notes = driver.FindElement(By.Id("plugins_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                case Pages.AddNewPlugin:
                    break;
                case Pages.EditorOfPlugins:
                    break;
                case Pages.AllCustoms:
                    email = driver.FindElement(By.Name("email-hide"));
                    role = driver.FindElement(By.Name("role-hide"));
                    posts = driver.FindElement(By.Name("posts-hide"));
                    numbers_of_notes = driver.FindElement(By.Id("users_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                case Pages.AddCustom:
                    break;
                case Pages.YourAccount:
                    break;
                case Pages.Available:
                    break;
                case Pages.Import:
                    break;
                case Pages.Export:
                    break;
                case Pages.HealthOfSite:
                    break;
                case Pages.ExportData:
                    numbers_of_notes = driver.FindElement(By.Id("export_personal_data_requests_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));

                    break;
                case Pages.RemoveData:
                    numbers_of_notes = driver.FindElement(By.Id("remove_personal_data_requests_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                case Pages.AtAll:
                    break;
                case Pages.Writing:
                    break;
                case Pages.Reading:
                    break;
                case Pages.Talking:
                    break;
                case Pages.Mediafiles:
                    break;
                case Pages.PermanentLink:
                    break;
                case Pages.Confidence:
                    break;
            }
        }
        public ScreenSettings InSightSubmit(Pages p)
        {
            if (in_sight != null)
            {
                in_sight.Click();
            }
            return this;
        }
        public ScreenSettings ActivitySubmit(Pages p)
        {
            if (activity!= null){
                activity.Click(); }
            return this;
        }
        public ScreenSettings QuickDraftSubmit(Pages p)
        {
            if (quick_draft != null)
            {
                quick_draft.Click();
            }
            return this;
        }
        public ScreenSettings NewsOfWordpressSubmit(Pages p)
        {
            if (news_of_wordpress != null)
            {
                news_of_wordpress.Click();
            }
            return this;
        }
        public ScreenSettings WelcomeSubmit(Pages p)
        {
            if (welcome != null)
            {
                welcome.Click();
            }
            return this;
        }
        public ScreenSettings AuthorClick(Pages p)
        {
            if (author != null)
            {
                author.Click();
            }
            return this;
        }
        public ScreenSettings CatedoriesClick(Pages p)
        {
            if (categories != null)
            {
                categories.Click();
            }
            return this;
        }
        public ScreenSettings TagsClick(Pages p)
        {
            if (tags != null)
            {
                tags.Click();
            }
            return this;
        }
        public ScreenSettings CommentsClick(Pages p)
        {
            if (comments != null)
            {
                comments.Click();
            }
            return this;
        }
        public ScreenSettings DateClick(Pages p)
        {
            if (date != null)
            {
                date.Click();
            }
            return this;
        }
        public ScreenSettings NumbersOfNotesClick(Pages p)
        {
            if (numbers_of_notes != null)
            {
                numbers_of_notes.Click();
            }
            return this;
        }
        public ScreenSettings NumbersOfNotesClear(Pages p)
        {
            if (numbers_of_notes != null)
            {
                numbers_of_notes.Clear();
            }
            return this;
        }
        public string NumbersOfNotesSetText(Pages p)
        {
            if (numbers_of_notes != null)
            {
                return numbers_of_notes.Text;
            }
            return "";
        }
        public ScreenSettings ApplyClick(Pages p)
        {
            if (apply != null)
            {
                apply.Click();
            }
            return this;
        }
        public ScreenSettings ViewAsListClick(Pages p)
        {
            if (view_as_list != null)
            {
                view_as_list.Click();
            }
            return this;
        }
        public ScreenSettings ViewTheDetailsClick(Pages p)
        {
            if (view_the_details != null)
            {
                view_the_details.Click();
            }
            return this;
        }
        public ScreenSettings DescriptionClick(Pages p)
        {
            if (description != null)
            {
                description.Click();
            }
            return this;
        }
        public ScreenSettings PartOfTheLinkClick(Pages p)
        {
            if (part_of_the_link != null)
            {
                part_of_the_link.Click();
            }
            return this;
        }
        public ScreenSettings NumberClick(Pages p)
        {
            if (number != null)
            {
                number.Click();
            }
            return this;
        }
        public ScreenSettings DownloadedForClick(Pages p)
        {
            if (downloaded_for != null)
            {
                downloaded_for.Click();
            }
            return this;
        }
        public ScreenSettings ResponseClick(Pages p)
        {
            if (response != null)
            {
                response.Click();
            }
            return this;
        }
        public ScreenSettings SentClick(Pages p)
        {
            if (sent != null)
            {
                sent.Click();
            }
            return this;
        }
        public ScreenSettings PagesClick(Pages p)
        {
            if (pages != null)
            {
                pages.Click();
            }
            return this;
        }
        public ScreenSettings PostsClick(Pages p)
        {
            if (posts != null)
            {
                posts.Click();
            }
            return this;
        }
        public ScreenSettings CustomsLinkClick(Pages p)
        {
            if (customs_link != null)
            {
                customs_link.Click();
            }
            return this;
        }
        public ScreenSettings GoalOfLinkClick(Pages p)
        {
            if (goal_of_link != null)
            {
                goal_of_link.Click();
            }
            return this;
        }
        public ScreenSettings TitleAtributesClick(Pages p)
        {
            if (title_atributes != null)
            {
                title_atributes.Click();
            }
            return this;
        }
        public ScreenSettings ClassCssClick(Pages p)
        {
            if (class_css != null)
            {
                class_css.Click();
            }
            return this;
        }
        public ScreenSettings XfnClick(Pages p)
        {
            if (xfn != null)
            {
                xfn.Click();
            }
            return this;
        }
        public ScreenSettings EmailClick(Pages p)
        {
            if (email != null)
            {
                email.Click();
            }
            return this;
        }
        public ScreenSettings RoleClick(Pages p)
        {
            if (role != null)
            {
                role.Click();
            }
            return this;
        }
    }
}


            