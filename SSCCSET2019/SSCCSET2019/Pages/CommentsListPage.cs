using NUnit.Framework;
using OpenQA.Selenium;
namespace Comments
{
   public class CommentsPage
    {
       
        IWebDriver driver;
        IWebElement check_author1;
        IWebElement check_author2;
        IWebElement author_label1;
        IWebElement author_label2;
        IWebElement comment_label1;
        IWebElement comment_label2;
        IWebElement responded1;
        IWebElement responded2;
        IWebElement sender1;
        IWebElement sender2;
        CommentsPage(IWebDriver driver)
        {
            //driver = new OpenQA.Selenium.Chrome.ChromeDriver();
           
            check_author1 = driver.FindElement(By.Id("cb-select-all-1"));
            check_author2 = driver.FindElement(By.Id("cb-select-all-2"));
            author_label1 = driver.FindElement(By.XPath("//*[@id=\"author\"]/a/span[1]"));
            author_label2 = driver.FindElement(By.XPath("//*[@id=\"comments - form\"]/table/tfoot/tr/th[1]/a/span[1]"));
            comment_label1 = driver.FindElement(By.Id("comment"));
            comment_label2 = driver.FindElement(By.XPath("//*[@id=\"comments - form\"]/table/tfoot/tr/th[2]"));
            responded1 = driver.FindElement(By.XPath("IWebElement comment_label = driver.FindElement(By.Id(\"comment\"));"));
            responded2 = driver.FindElement(By.XPath("//*[@id=\"comments - form\"]/table/tfoot/tr/th[3]/a/span[1]"));
            sender1 = driver.FindElement(By.XPath("//*[@id=\"date\"]/a/span[1]"));
            sender2 = driver.FindElement(By.XPath("//*[@id=\"comments - form\"]/table/tfoot/tr/th[4]/a/span[1]"));
        }
        public void ClickUpperCheckAuthor()
        {
            check_author1.Click();
        }
        public bool CheckUpperCheckAuthor()
        {
            return check_author1.Enabled;
        }
        public bool CheckLowerCheckAuthor()
        {
            return check_author2.Enabled;
        }
        public void ClickLowerCheckAuthor()
        {
            check_author2.Click();
        }
        public string GetUpperAuthorLabelText()
        {
            return author_label1.Text;
        }
        public string GetLowerAuthorLabelText()
        {
            return author_label1.Text;
        }
        public void ClickUpperAuthorLabel()
        {
            author_label1.Click();
        }
        public void ClickLowerAuthorLabel()
        {
            author_label2.Click();
        }
        public string GetUpperCommentLabel()
        {
            return comment_label1.Text;
        }
        public string GetLowerCommentLabel()
        {
            return comment_label2.Text;
        }
        public string GetUpperResponedText()
        {
            return responded1.Text;
        }
        public string GetLowerResponedText()
        {
            return responded2.Text;
        }
        public string GetUpperSenderText()
        {
            return sender1.Text;
        }
        public string GetLowerSenderText()
        {
            return sender2.Text;
        }
        public void ClickUpperResponded()
        {
            responded1.Click();
        }
        public void ClickLowerResponded()
        {
            responded2.Click();
        }
        public void ClickUpperSender()
        {
            sender1.Click();
        }
        public void ClickLowerSender()
        {
            sender2.Click();
        }
    }
   
}