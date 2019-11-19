using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using NUnit.Framework;

namespace SSCCSET2019.Pages.AllPostsPage
{
    class AllPosts
    {
        private IWebDriver driver;

        protected IWebElement AllLabelText { get; set; }
        protected IWebElement PublishedLabelText { get; set; }
        protected IWebElement AllPostsCountText { get; set; }
        protected IWebElement PublishedPostsCountText { get; set; }
        //TODO: public IWebElement BulkActionSelectorTop { get; set; } Проверить сделал ли макс список 


        protected List<IWebElement> ApplyBtn { get; set; }





        protected SelectElement SelectDate { get; set; }
        protected SelectElement SelectCategory { get; set; }



        protected IWebElement FilterBtn { get; set; }


        //TODO:Добавить нижнюю лейблу
        protected IWebElement DisplayingSumLabel { get; set; }



        #region TableHeaders
        public List<IWebElement> SelectAllRecordsCheck { get; set; }
        public List<IWebElement> TableHeaderNameBtns { get; set; }
        public List<IWebElement> TableHeaderNameText { get; set; }

        public List<IWebElement> TableHeaderAuthorText { get; set; }

        public List<IWebElement> TableHeaderCategoriesText { get; set; }

        public List<IWebElement> TableHeaderTegsText { get; set; }

        public List<IWebElement> TableHeaderCommentsBtns { get; set; }

        public List<IWebElement> TableHeaderDateBtns { get; set; }
        public List<IWebElement> TableHeaderDateText { get; set; }
        #endregion




        public List<RecordItem> Records { get; set; }



        public AllPosts(IWebDriver myDriver)
        {
            driver = myDriver;
            AllLabelText = driver.FindElement(By.XPath("//li[@class='all']/a"));
            AllPostsCountText = driver.FindElement(By.XPath("//li[@class='all']/a/span"));
            PublishedLabelText = driver.FindElement(By.XPath("//li[@class='publish']/a"));
            PublishedPostsCountText = driver.FindElement(By.XPath(@"//li[@class='publish']/a/span"));
            //BulkActionSelectorTop = driver.FindElement(By.Id("bulk-action-selector-top"));

            ApplyBtn = new List<IWebElement>();
            ApplyBtn.Add(driver.FindElement(By.Id("doaction")));
            ApplyBtn.Add(driver.FindElement(By.Id("doaction2")));


            SelectDate = new SelectElement(driver.FindElement(By.Id("filter-by-date")));
            SelectCategory = new SelectElement(driver.FindElement(By.Id("cat")));
            FilterBtn = driver.FindElement(By.Id("post-query-submit"));
            DisplayingSumLabel = driver.FindElement(By.XPath("//span[@class='displaying-num']"));

            Records = InitializeRecordsList(driver.FindElements(By.ClassName("iedit")));


            SelectAllRecordsCheck = new List<IWebElement>();
            SelectAllRecordsCheck.AddRange(driver.FindElements(By.ClassName("column-cb")));

            TableHeaderNameBtns = new List<IWebElement>();
            TableHeaderNameBtns.AddRange(driver.FindElements(By.XPath("//th[contains(@class, 'manage-column') and contains(@class, 'column-title')]/a")));
            TableHeaderNameText = new List<IWebElement>();
            TableHeaderNameText.AddRange(driver.FindElements(By.XPath("//th[contains(@class, 'manage-column') and contains(@class, 'column-title')]/a/span")));

            TableHeaderAuthorText = new List<IWebElement>();
            TableHeaderAuthorText.AddRange(driver.FindElements(By.XPath("//th[contains(@class, 'manage-column') and contains(@class, 'column-author')]")));

            TableHeaderCategoriesText = new List<IWebElement>();
            TableHeaderCategoriesText.AddRange(driver.FindElements(By.XPath("//th[contains(@class, 'manage-column') and contains(@class, 'column-categories')]")));


            TableHeaderTegsText = new List<IWebElement>();
            TableHeaderTegsText.AddRange(driver.FindElements(By.XPath("//th[contains(@class, 'manage-column') and contains(@class, 'column-tags')]")));

            TableHeaderCommentsBtns = new List<IWebElement>();
            TableHeaderCommentsBtns.AddRange(driver.FindElements(By.XPath("//th[contains(@class, 'manage-column') and contains(@class, 'column-comments')]/a")));

            TableHeaderDateBtns = new List<IWebElement>();
            TableHeaderDateBtns.AddRange(driver.FindElements(By.XPath("//th[contains(@class, 'manage-column') and contains(@class, 'column-date')]/a")));
            TableHeaderDateText = new List<IWebElement>();
            TableHeaderDateText.AddRange(driver.FindElements(By.XPath("//th[contains(@class, 'manage-column') and contains(@class, 'column-date')]/a/span[1]")));
        }


        private List<RecordItem> InitializeRecordsList(IReadOnlyCollection<IWebElement> elements)
        {
            List<RecordItem> records = new List<RecordItem>();
            foreach (var record in elements)
            {
                records.Add(new RecordItem(record));
            }

            return records;
        }


        public string GetTextFromAllRecordsLabel()
        {
            return AllLabelText.Text;
        }

        public AllPosts ClickAllPostsLabel()
        {
            AllLabelText.Click();
            return this;
        }

        public string GetTextFromPublishedRecordsLabel()
        {
            return PublishedLabelText.Text;
        }

        public AllPosts ClickPublishedLabel()
        {
            PublishedLabelText.Click();
            return this;
        }

        //TODO: Добавить нижнюю лейблу в лист 
        public string GetTextFromAllPostsCount()
        {
            return AllPostsCountText.Text;
        }

        public string GetTextFromPublishedPostsCount()
        {
            return AllPostsCountText.Text;
        }

        public AllPosts ClickApplyChanges(int index)
        {
            ApplyBtn[index].Click();
            return this;
        }
        public AllPosts FocusApplyButton(int index)
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(ApplyBtn[index]);
            builder.Perform();
            return this;
        }


        //DATE SELECT
        public List<string> GetListOfDates()
        {
            List<string> dates = new List<string>();
            foreach (var current in SelectDate.Options)
            {
                dates.Add(current.Text);
            }
            return dates;
        }

        public string GetSelectedDate()
        {
            return SelectDate.SelectedOption.Text;
        }

        public AllPosts SetDateByText(string text)
        {
            SelectDate.SelectByText(text);
            return this;
        }
        public AllPosts SetDateByIndex(int index)
        {
            SelectDate.SelectByIndex(index);
            return this;
        }
        public AllPosts SetDateByValue(string value)
        {
            SelectDate.SelectByValue(value);
            return this;
        }

        //CATEGORY SELECT
        public List<string> GetListOfCategories()
        {
            List<string> categories = new List<string>();
            foreach (var cat in SelectCategory.Options)
            {
                categories.Add(cat.Text);
            }

            return categories;
        }

        public string GetSelectedCategory()
        {
            return SelectCategory.SelectedOption.Text;
        }

        public AllPosts SetCategoryByText(string text)
        {
            SelectCategory.SelectByText(text);
            return this;
        }

        public AllPosts SetCategoryByIndex(int index)
        {
            SelectCategory.SelectByIndex(index);
            return this;
        }

        public AllPosts SetCategoryByValue(string value)
        {
            SelectCategory.SelectByValue(value);
            return this;
        }

        public AllPosts ClickApplyFilters()
        {
            FilterBtn.Click();
            return this;
        }
        public AllPosts FocusApplyFiltersButton()
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(FilterBtn);
            builder.Perform();
            return this;
        }

        //TODO:Добавить лист
        public string GetDisplayingNumText()
        {
            return DisplayingSumLabel.Text;
        }


        public AllPosts CheckAllRecordsInTable(int index)
        {
            if (!SelectAllRecordsCheck[index].Selected)
            {
                SelectAllRecordsCheck[index].Click();
            }
            return this;
        }

        public AllPosts UncheckAllRecordsInTable(int index)
        {
            if (SelectAllRecordsCheck[index].Selected)
            {
                SelectAllRecordsCheck[index].Click();
            }
            return this;
        }

        public AllPosts ClickHeaderNameButton(int index)
        {
            TableHeaderNameBtns[index].Click();
            return this;
        }

        public string GetTextFromHeaderNameLabel(int index)
        {
            return TableHeaderNameText[index].Text;
        }

        public string GetTextFromHeaderAuthorLabel(int index)
        {
            return TableHeaderAuthorText[index].Text;
        }

        public string GetTextFromHeaderCategoryLabel(int index)
        {
            return TableHeaderCategoriesText[index].Text;
        }
        public string GetTextFromHeaderTagLabel(int index)
        {
            return TableHeaderTegsText[index].Text;
        }

        public AllPosts ClickHeaderCommentButton(int index)
        {
            TableHeaderCommentsBtns[index].Click();
            return this;
        }

        public AllPosts ClickHeaderDateButton(int index)
        {
            TableHeaderDateBtns[index].Click();
            return this;
        }

        public string GetTextFromHeaderDateLabel(int index)
        {
            return TableHeaderDateText[index].Text;
        }

        public List<RecordItem> GetRecordsList()
        {
            return Records;
        }
    }
}
