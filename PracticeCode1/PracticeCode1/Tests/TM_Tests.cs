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
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {
        HomePage HomePageObj = new HomePage();
        TMPage TMPageObj = new TMPage();

        
        [Test,Order(1),Description("Check if user is able to create new record")]
        public void CreateTMTests()
        {
            HomePageObj.GoToTMPage(driver);
            TMPageObj.CreateTM(driver);

        }
        [Test,Order(2), Description("Check if user is able to Edit already created record")]
        public void EditTMTests()
        {
            HomePageObj.GoToTMPage(driver);
            TMPageObj.EditTM(driver);
        }

        [Test,Order(3), Description("Check if user is able to delete the edited record")]
        public void DeleteTMTests()
        {
            HomePageObj.GoToTMPage(driver);
            TMPageObj.DeleteTM(driver);
        }

    }
}
