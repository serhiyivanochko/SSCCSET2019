using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;




namespace SSCCSET2019.Pages
{

    class Mediafiles
    {
        IWebDriver driver;
        public void BrowserStart()
        {
            driver = new FirefoxDriver();
        }
        IWebElement media__lib;
        IWebElement add_new;
        IWebElement all_mediafiles;
        IWebElement alldates;
        IWebElement select_several;
        IWebElement search_object;
        IWebElement help;
        public Mediafiles(){
            media__lib = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/h1"));
            add_new= driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/a"));
            all_mediafiles = driver.FindElement(By.XPath("//*[@id='media - attachment - filters']"));
            alldates = driver.FindElement(By.XPath("//*[@id='media - attachment - date - filters']"));
            select_several = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div[1]/div[3]/div[2]/div[4]/div/div[3]/div[1]/button[2]"));
            search_object = driver.FindElement(By.XPath("//*[@id='media - search - input']"));
            help = driver.FindElement(By.XPath("//*[@id='contextual - help - link']"));


        }

    }
}
