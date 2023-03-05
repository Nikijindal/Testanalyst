using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using PracticeCode1.Pages;
using PracticeCode1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode1.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(driver);

            HomePage HomePageObj = new HomePage();
            HomePageObj.GoToTMPage(driver);

        }

        [Test,Order(1),Description("Check if user is able to create new record")]
        public void CreateTMTests()
        {
            TMPage TMPageObj = new TMPage();
            TMPageObj.CreateTM(driver);

        }
        [Test,Order(2), Description("Check if user is able to Edit already created record")]
        public void EditTMTests()
        {
            TMPage TMPageObj = new TMPage();
            TMPageObj.EditTM(driver);
        }

        [Test,Order(3), Description("Check if user is able to delete the edited record")]
        public void DeleteTMTests()
        {
            TMPage TMPageObj = new TMPage();
            TMPageObj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}
