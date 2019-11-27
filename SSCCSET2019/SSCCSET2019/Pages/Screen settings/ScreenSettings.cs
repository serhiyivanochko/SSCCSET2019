using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SSCCSET2019.Tools.Driver;

namespace SSCCSET2019.Pages
{
    
    public class ScreenSettings
    {
        
        public enum Page
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
      private IWebDriver driver;
        
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
        public ScreenSettings(Page p)
        {
            switch (p)
            {
                case Page.Main:
                    in_sight = driver.FindElement(By.Name("dashboard_right_now-hide"));
                    activity = driver.FindElement(By.Name("dashboard_activity-hide"));
                    quick_draft = driver.FindElement(By.Name("dashboard_quick_press-hide"));
                    news_of_wordpress = driver.FindElement(By.Name("dashboard_primary-hide"));
                    welcome = driver.FindElement(By.Id("wp_welcome_panel-hide"));
                    break;
                case Page.Updates:
                    break;
                case Page.AllNotes:
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
                case Page.AddNew:
                    break;
                case Page.Categories:
                    description = driver.FindElement(By.Name("description-hide"));
                    part_of_the_link = driver.FindElement(By.Name("slug-hide"));
                    number = driver.FindElement(By.Name("posts-hide"));
                    numbers_of_notes = driver.FindElement(By.Id("edit_category_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                case Page.Tags:
                    description = driver.FindElement(By.Name("description-hide"));
                    part_of_the_link = driver.FindElement(By.Name("slug-hide"));
                    number = driver.FindElement(By.Name("posts-hide"));
                    numbers_of_notes = driver.FindElement(By.Id("edit_post_tag_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                case Page.Library:
                    author = driver.FindElement(By.Name("author-hide"));
                    downloaded_for = driver.FindElement(By.Name("parent-hide"));
                    comments = driver.FindElement(By.Name("comments-hide"));
                    date = driver.FindElement(By.Name("date-hide"));
                    numbers_of_notes = driver.FindElement(By.Id("upload_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                //case Page.AddNewFile:
                //    break;
                case Page.AllPages:
                    author = driver.FindElement(By.Name("author-hide"));
                    comments = driver.FindElement(By.Name("comments-hide"));
                    date = driver.FindElement(By.Name("date-hide"));
                    numbers_of_notes = driver.FindElement(By.Id("edit_page_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                //case Page.AddNewPage:
                //    break;
                case Page.Comments:
                    author = driver.FindElement(By.Name("author-hide"));
                    response = driver.FindElement(By.Name("response-hide"));
                    sent = driver.FindElement(By.Name("date-hide"));
                    numbers_of_notes = driver.FindElement(By.Id("edit_comments_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                //case Page.Themes:
                //    break;
                //case Page.Settings:
                //    break;
                //case Page.Widgets:
                //    break;
                case Page.Menu:
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
                //case Page.Editor:
                //    break;
                case Page.SettedPlugins:
                    description = driver.FindElement(By.Name("description-hide"));
                    numbers_of_notes = driver.FindElement(By.Id("plugins_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                //case Page.AddNewPlugin:
                //    break;
                //case Page.EditorOfPlugins:
                //    break;
                case Page.AllCustoms:
                    email = driver.FindElement(By.Name("email-hide"));
                    role = driver.FindElement(By.Name("role-hide"));
                    posts = driver.FindElement(By.Name("posts-hide"));
                    numbers_of_notes = driver.FindElement(By.Id("users_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                //case Page.AddCustom:
                //    break;
                //case Page.YourAccount:
                //    break;
                //case Page.Available:
                //    break;
                //case Page.Import:
                //    break;
                //case Page.Export:
                //    break;
                //case Page.HealthOfSite:
                //    break;
                case Page.ExportData:
                    numbers_of_notes = driver.FindElement(By.Id("export_personal_data_requests_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                case Page.RemoveData:
                    numbers_of_notes = driver.FindElement(By.Id("remove_personal_data_requests_per_page"));
                    apply = driver.FindElement(By.Name("screen-options-apply"));
                    break;
                //case Page.AtAll:
                //    break;
                //case Page.Writing:
                //    break;
                //case Page.Reading:
                //    break;
                //case Page.Talking:
                //    break;
                //case Page.Mediafiles:
                //    break;
                //case Page.PermanentLink:
                //    break;
                //case Page.Confidence:
                //    break;

            }
        }
        public ScreenSettings(IWebDriver driver) 
        {
            this.driver = driver;
            VerifyWebElement();
        }
        private void VerifyWebElement()
        {
            IWebElement elem = in_sight;
            elem = activity;
            elem = quick_draft;
            elem = news_of_wordpress;
            elem = welcome;
            elem = author;
            elem = categories;
            elem = tags;
            elem = comments;
            elem = date;
            elem = numbers_of_notes;
            elem = apply;
            elem = view_as_list;
            elem = view_the_details;
            elem = description;
            elem = part_of_the_link;
            elem = number;
            elem = downloaded_for;
            elem = response;
            elem = sent;
            elem = pages;
            elem = posts;
            elem = customs_link;
            elem = goal_of_link;
            elem = title_atributes;
            elem = class_css;
            elem = xfn;
            elem = email;
            elem = role;
            
        }
        public ScreenSettings InSightSubmit(Page p)
        {
            if (in_sight != null)
            {
                in_sight.Click();
            }
            return this;
        }
        public ScreenSettings ActivitySubmit(Page p)
        {
            if (activity!= null){
                activity.Click(); }
            return this;
        }
        public ScreenSettings QuickDraftSubmit(Page p)
        {
            if (quick_draft != null)
            {
                quick_draft.Click();
            }
            return this;
        }
        public ScreenSettings NewsOfWordpressSubmit(Page p)
        {
            if (news_of_wordpress != null)
            {
                news_of_wordpress.Click();
            }
            return this;
        }
        public ScreenSettings WelcomeSubmit(Page p)
        {
            if (welcome != null)
            {
                welcome.Click();
            }
            return this;
        }
        public ScreenSettings AuthorClick(Page p)
        {
            if (author != null)
            {
                author.Click();
            }
            return this;
        }
        public ScreenSettings CatedoriesClick(Page p)
        {
            if (categories != null)
            {
                categories.Click();
            }
            return this;
        }
        public ScreenSettings TagsClick(Page p)
        {
            if (tags != null)
            {
                tags.Click();
            }
            return this;
        }
        public ScreenSettings CommentsClick(Page p)
        {
            if (comments != null)
            {
                comments.Click();
            }
            return this;
        }
        public ScreenSettings DateClick(Page p)
        {
            if (date != null)
            {
                date.Click();
            }
            return this;
        }
        public ScreenSettings NumbersOfNotesClick(Page p)
        {
            if (numbers_of_notes != null)
            {
                numbers_of_notes.Click();
            }
            return this;
        }
        public ScreenSettings NumbersOfNotesClear(Page p)
        {
            if (numbers_of_notes != null)
            {
                numbers_of_notes.Clear();
            }
            return this;
        }
        public string NumbersOfNotesSetText(Page p)
        {
            if (numbers_of_notes != null)
            {
                return numbers_of_notes.Text;
            }
            return "";
        }
        public ScreenSettings ApplyClick(Page p)
        {
            if (apply != null)
            {
                apply.Click();
            }
            return this;
        }
        public ScreenSettings ViewAsListClick(Page p)
        {
            if (view_as_list != null)
            {
                view_as_list.Click();
            }
            return this;
        }
        public ScreenSettings ViewTheDetailsClick(Page p)
        {
            if (view_the_details != null)
            {
                view_the_details.Click();
            }
            return this;
        }
        public ScreenSettings DescriptionClick(Page p)
        {
            if (description != null)
            {
                description.Click();
            }
            return this;
        }
        public ScreenSettings PartOfTheLinkClick(Page p)
        {
            if (part_of_the_link != null)
            {
                part_of_the_link.Click();
            }
            return this;
        }
        public ScreenSettings NumberClick(Page p)
        {
            if (number != null)
            {
                number.Click();
            }
            return this;
        }
        public ScreenSettings DownloadedForClick(Page p)
        {
            if (downloaded_for != null)
            {
                downloaded_for.Click();
            }
            return this;
        }
        public ScreenSettings ResponseClick(Page p)
        {
            if (response != null)
            {
                response.Click();
            }
            return this;
        }
        public ScreenSettings SentClick(Page p)
        {
            if (sent != null)
            {
                sent.Click();
            }
            return this;
        }
        public ScreenSettings PagesClick(Page p)
        {
            if (pages != null)
            {
                pages.Click();
            }
            return this;
        }
        public ScreenSettings PostsClick(Page p)
        {
            if (posts != null)
            {
                posts.Click();
            }
            return this;
        }
        public ScreenSettings CustomsLinkClick(Page p)
        {
            if (customs_link != null)
            {
                customs_link.Click();
            }
            return this;
        }
        public ScreenSettings GoalOfLinkClick(Page p)
        {
            if (goal_of_link != null)
            {
                goal_of_link.Click();
            }
            return this;
        }
        public ScreenSettings TitleAtributesClick(Page p)
        {
            if (title_atributes != null)
            {
                title_atributes.Click();
            }
            return this;
        }
        public ScreenSettings ClassCssClick(Page p)
        {
            if (class_css != null)
            {
                class_css.Click();
            }
            return this;
        }
        public ScreenSettings XfnClick(Page p)
        {
            if (xfn != null)
            {
                xfn.Click();
            }
            return this;
        }
        public ScreenSettings EmailClick(Page p)
        {
            if (email != null)
            {
                email.Click();
            }
            return this;
        }
        public ScreenSettings RoleClick(Page p)
        {
            if (role != null)
            {
                role.Click();
            }
            return this;
        }
    }
}


            