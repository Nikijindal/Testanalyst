using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PracticeCode1.Utilities;
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
            // IMPLICIT & EXPLICIT Wait code
            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")));

           
            IWebElement adminbtn = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminbtn.Click();
            Thread.Sleep(1000);

            Wait.WaitToBeClickable(driver,"XPath","/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 5);

            // Navigate to time & material  page
            IWebElement timematerialbtn = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timematerialbtn.Click();
        }

        public void GoToEmployeePage(IWebDriver driver) 
        {
            IWebElement adminbtn1 = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminbtn1.Click();
            Thread.Sleep(1000);

            IWebElement employeeopt = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeeopt.Click();

        }
    }
}
