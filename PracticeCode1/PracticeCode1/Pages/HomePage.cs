using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode1.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver) 
        {
            IWebElement adminbtn = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminbtn.Click();
            Thread.Sleep(1000);

            // Navigate to time & material  page
            IWebElement timematerialbtn = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timematerialbtn.Click();
        }
    }
}
