using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using PracticeCode1.Pages;
using PracticeCode1.Utilities;
using System;
using TechTalk.SpecFlow;

namespace PracticeCode1.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        LoginPage LoginPageObj = new LoginPage();
        HomePage HomePageObj = new HomePage();
        TMPage TMPageObj = new TMPage();


        [Given(@"I logged into turnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            // Open chrome browser
            driver = new ChromeDriver();

            // Login page
            
            LoginPageObj.LoginActions(driver);
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            HomePageObj.GoToTMPage(driver);
        }

        [When(@"I create new Time and Material record")]
        public void WhenICreateNewTimeAndMaterialRecord()
        {
            TMPageObj.CreateTM(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newCode = TMPageObj.GetCode(driver);
            string newDescription = TMPageObj.GetDescription(driver);
            string newPrice = TMPageObj.GetPrice(driver);

            Assert.That(newCode == "Test2023", "Actual & expected code does not match");
            Assert.That(newDescription == "T20", "Actual & expected description does not match");
            Assert.That(newPrice == "$6,000.00", "Actual & expected price does not match");

        }

        //[When(@"I update '([^']*)' on existing time and material record")]
        //public void WhenIUpdateOnExistingTimeAndMaterialRecord(string description)
        //{
        //    TMPageObj.EditTM(driver,description);
        //}

        //[Then(@"The record should have updated '([^']*)'")]
        //public void ThenTheRecordShouldHaveUpdated(string description)
        //{
            
        //}

        [When(@"I update '([^']*)','([^']*)','([^']*)' on existing time and material record")]
        public void WhenIUpdateOnExistingTimeAndMaterialRecord(string description, string code, string price)
        {
            TMPageObj.EditTM(driver, description,code,price);
        }
        [Then(@"The record should have updated '([^']*)','([^']*)','([^']*)'")]
        public void ThenTheRecordShouldHaveUpdated(string description, string code, string price)
        {
           string editedDescription = TMPageObj.GetEditedDescription(driver);
           string editedCode = TMPageObj.GetEditedCode(driver);
           string editedPrice = TMPageObj.GetEditedPrice(driver);

            Assert.That(editedDescription == description, "Actual & edited description does not match");
            Assert.That(editedCode == code, "Actual & edited description does not match");
            Assert.That(editedPrice == price, "Actual & edited description does not match");
        }


    }
}
