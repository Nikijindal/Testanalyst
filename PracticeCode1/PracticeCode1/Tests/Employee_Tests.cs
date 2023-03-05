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
    public class Employee_Tests:CommonDriver 
    {
        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            HomePage homePageObj= new HomePage();
            homePageObj.GoToEmployeePage(driver);
        }

        [Test,Order(1)]
        public void CreateEmployee()
        {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmployee(driver);
        }

        [Test, Order(2)]
         public void EditEmployee()
          {
              EmployeePage employeePageObj = new EmployeePage();
              employeePageObj.EditEmployee(driver);   

          }

     [Test,Order(3)]
     public void DeleteEmployee() 
     {
         EmployeePage employeePageObj = new EmployeePage();
         employeePageObj.DeleteEmployee(driver);
     }

    [TearDown]
        public void Cleanup() 
        {
        
            driver.Quit();
        }
    }
}
