using System;
using OpenQA.Selenium;
namespace SSCCSET2019.Pages.Notes
{
    class Сategories
    {
        private IWebDriver driver;


        private IWebElement name;
        private IWebElement nameDescription;
        private IWebElement partOfURL;
        private IWebElement partOfURLDescription;
        private IWebElement fatherCategory;
        private IWebElement fatherCategoryDescription;
        private IWebElement description;
        private IWebElement descriptionForDescription;
        private IWebElement submit;
        private IWebElement WordPressURL;

        private IWebElement enterCategoryToFind;
        private IWebElement btnFindCategory;


        private IWebElement checkBoxSelectAll_upper;
        private IWebElement checkBoxSelectAll_lower;
        private IWebElement sortByName_upper;
        private IWebElement sortByName_lower;
        private IWebElement sortByURL_upper;
        private IWebElement sortByURL_lower;
        private IWebElement actionSelector_upper;
        private IWebElement apply_upper;
        private IWebElement actionSelector_lower;
        private IWebElement apply_lower;
        private IWebElement numberOfElements_upper;
        private IWebElement numberOfElements_lower;


        private IWebElement transformCategoryInMarkURL;
        private IWebElement descriptionBox;
        private IWebElement version;

        public Сategories(IWebDriver driver)
        {
            this.driver = driver;
            this.name = driver.FindElement(By.Id("tag-name"));
            this.nameDescription = driver.FindElement(By.Id("//*[@id=\"addtag\"]/div[1]/p"));
            this.partOfURL = driver.FindElement(By.Id("tag-slug"));
            this.partOfURLDescription = driver.FindElement(By.Id("//*[@id=\"addtag\"]/div[2]/p"));
            this.fatherCategory = driver.FindElement(By.Id("parent"));
            this.fatherCategoryDescription = driver.FindElement(By.Id("//*[@id=\"addtag\"]/div[3]/p"));
            this.description = driver.FindElement(By.Id("tag-description"));
            this.descriptionForDescription = driver.FindElement(By.XPath("//*[@id=\"addtag\"]/div[4]/p"));
            this.submit = driver.FindElement(By.Id("submit"));
            WordPressURL = driver.FindElement(By.XPath("//*[@id=/\"footer-thankyou\"]/a"));
            this.enterCategoryToFind = driver.FindElement(By.Id("tag-search-input"));
            this.btnFindCategory = driver.FindElement(By.Id("search-submit"));
            this.checkBoxSelectAll_upper = driver.FindElement(By.Id("cb-select-all-1"));
            this.checkBoxSelectAll_lower = driver.FindElement(By.Id("cb-select-all-2"));
            this.sortByName_upper = driver.FindElement(By.XPath("//*[@id=\"name\"]/a/span[2]"));
            this.sortByName_lower = driver.FindElement(By.XPath("//*[@id=\"posts - filter\"]/table/tfoot/tr/th[1]/a/span[2]"));
            this.sortByURL_upper = driver.FindElement(By.XPath("//*[@id=\"slug\"]/a/span[2]"));
            this.sortByURL_lower = driver.FindElement(By.XPath("//*[@id=\"posts - filter\"]/table/tfoot/tr/th[3]/a/span[2]"));
            this.actionSelector_upper = driver.FindElement(By.Id("bulk-action-selector-top"));
            this.apply_upper = driver.FindElement(By.Id("doaction"));
            this.actionSelector_lower = driver.FindElement(By.Id("bulk-action-selector-bottom"));
            this.apply_lower = driver.FindElement(By.Id("doaction2"));
            this.numberOfElements_upper = driver.FindElement(By.XPath("//*[@id=\"posts - filter\"]/div[1]/div[2]/span[1]"));
            this.numberOfElements_lower = driver.FindElement(By.XPath("//*[@id=\"posts - filter\"]/div[2]/div[2]/span[1]"));
            this.transformCategoryInMarkURL = driver.FindElement(By.XPath("//*[@id=\"col - right\"]/div/div/p[2]/a"));
            this.descriptionBox = driver.FindElement(By.XPath("//*[@id=\"col-right\"]/div/div"));
            this.version = driver.FindElement(By.Id("footer-upgrade"));
        }

        public void ClickName()
        {
            name.Click();
        }

        public bool IsNameEnable()
        {
            return name.Enabled;
        }

        public bool IsNameDescriptionDisplayed()
        {
            return nameDescription.Displayed;
        }

        public void PartOfURLClick()
        {
            partOfURL.Click();
        }

        public bool PartOfURLEnable()
        {
            return partOfURL.Enabled;
        }

        public bool PartOfURLDescriptionDisplayed()
        {
            return partOfURLDescription.Displayed;
        }

        public void FatherCategoryClick()
        {
            fatherCategory.Click();
        }

        public bool FatherCategoryEnable()
        {
            return fatherCategory.Enabled;
        }

        public bool FatherCategoryDescriptionDisplayed()
        {
            return fatherCategoryDescription.Displayed;
        }
        
        public void DescriptionClick()
        {
            description.Click();
        }
        public bool DescriptionEnable()
        {
           return description.Enabled;
        }
        public bool DescriptionForDescriptionDisplayed()
        {
            return descriptionForDescription.Displayed;
        }

        public void SubmitClick()
        {
            submit.Click();
        }
        public bool SubmitEnable()
        {
            return submit.Displayed;
        }
        public void WordpressURLClick()
        {
            WordPressURL.Click();
        }
        public bool WordpressURLEnable()
        {
            return WordPressURL.Enabled;
        }
        public void EnterCategoryToFindClick()
        {
            enterCategoryToFind.Click();
        }
        public bool enterCategoryToFindEnable()
        {
            return enterCategoryToFind.Enabled;
        }
        public void BtnFindCategoryClick()
        {
            btnFindCategory.Click();
        }
        public bool BtnFindCategoryEnable()
        {
            return btnFindCategory.Enabled;
        }
        public void CheckBoxSelectAll_upperClick()
        {
            checkBoxSelectAll_upper.Click();
        }
        public bool CheckBoxSelectAll_upperEnable()
        {
            return checkBoxSelectAll_upper.Enabled;
        }
        public bool checkBoxSelectAll_upperChecked()
        {
            return checkBoxSelectAll_upper.Selected;
        }
        public void CheckBoxSelectAll_lowerClick()
        {
            checkBoxSelectAll_lower.Click();
        }
        public bool CheckBoxSelectAll_lowerEnable()
        {
            return checkBoxSelectAll_lower.Enabled;
        }
        public bool checkBoxSelectAll_lowerChecked()
        {
            return checkBoxSelectAll_lower.Selected;
        }
        public void SortByName_upperClick()
        {
            sortByName_upper.Click();
        }

        public bool SortByName_upperEnable()
        {
             return  sortByName_upper.Enabled;
        }
        public void SortByName_lowerClick()
        {
            sortByName_lower.Click();
        }

        public bool SortByName_lowerEnable()
        {
            return sortByName_lower.Enabled;
        }

        public void SortByURL_upperClick()
        {
            sortByURL_upper.Click();
        }

        public bool SortByURL_upperEnable()
        {
            return sortByURL_upper.Enabled;
        }
        public void SortByURL_lowerClick()
        {
            sortByURL_lower.Click();
        }

        public bool SortByURL_lowerEnable()
        {
            return sortByURL_lower.Enabled;
        }
        public void ActionSelector_upperClick()
        {
            actionSelector_upper.Click();
        }
        public bool ActionSelector_upperEnable()
        {
            return actionSelector_upper.Enabled;
        }
        public void ActionSelector_lowerClick()
        {
            actionSelector_lower.Click();
        }
        public bool ActionSelector_lowerEnable()
        {
            return actionSelector_lower.Enabled;
        }
        public void Apply_upperClick()
        {
            apply_upper.Click();
        }
        public bool Apply_upperEnable()
        {
            return apply_upper.Enabled;
        }
        public void Apply_lowerClick()
        {
            apply_lower.Click();
        }
        public bool Apply_lowerEnable()
        {
            return apply_lower.Enabled;
        }
        public void NumberOfElements_upperClick()
        {
            numberOfElements_upper.Click();
        }
        public bool NumberOfElements_upperEnable()
        {
            return numberOfElements_upper.Enabled;
        }

        public void NumberOfElements_lowerClick()
        {
            numberOfElements_lower.Click();
        }
        public bool NumberOfElements_lowerEnable()
        {
            return numberOfElements_lower.Enabled;
        }
        public void TransformCategoryInMarkURLClick()
        {
            transformCategoryInMarkURL.Click();
        }
        public bool TransformCategoryInMarkURLEnable()
        {
            return transformCategoryInMarkURL.Enabled;
        }
        public bool DescriptionBoxDisplayed()
        {
            return descriptionBox.Displayed;
        }
        public bool VersionDisplayed()
        {
            return version.Displayed;
        }
    }
}
