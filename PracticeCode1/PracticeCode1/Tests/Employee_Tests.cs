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
    public class Employee_Tests:CommonDriver 
    {
        EmployeePage employeePageObj = new EmployeePage();      
        HomePage homePageObj= new HomePage();
       
        

        [Test,Order(1)]
        public void CreateEmployee()
        {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.CreateEmployee(driver);
        }

        [Test, Order(2)]
         public void EditEmployee()
         {
             homePageObj.GoToEmployeePage(driver);
             employeePageObj.EditEmployee(driver);   

         }

     [Test,Order(3)]
     public void DeleteEmployee() 
     {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.DeleteEmployee(driver);
     }

    
    }
}
