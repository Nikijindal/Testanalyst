using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PracticeCode1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode1.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(driver);

            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToTMPage(driver);

        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
