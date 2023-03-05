using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V108.Tethering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode1.Pages
{
    public class EmployeePage
    {
        public void CreateEmployee(IWebDriver driver)
        {
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
            Thread.Sleep(2000);

            // enter name of employee
            IWebElement enterName = driver.FindElement(By.Id("Name"));
            enterName.SendKeys("Nikita");

            // enter username of employee
            IWebElement enterUsername = driver.FindElement(By.Id("Username"));
            enterUsername.SendKeys("nikita.jin");

            // enter contact number
            IWebElement enterContactnumber = driver.FindElement(By.Id("ContactDisplay"));
            enterContactnumber.SendKeys("12345");

            // enter password
            IWebElement enterPwd = driver.FindElement(By.Id("Password"));
            enterPwd.SendKeys("Practicework12@");

            // Re-type password
            IWebElement retypepwd = driver.FindElement(By.Id("RetypePassword"));
            retypepwd.SendKeys("Practicework12@");

            // Click on admin box
            IWebElement adminbox = driver.FindElement(By.Id("IsAdmin"));
            adminbox.Click();

            // Enter Vehicle type
            IWebElement vehicletextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicletextbox.SendKeys("Mazda");

            // enter group
            IWebElement enterGroup = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            enterGroup.Click();
            Thread.Sleep(3000);

            // select from group list 
            IWebElement groupdropdown = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]"));
            groupdropdown.Click();
            Thread.Sleep(3000);


            // click on save button 
            IWebElement savebtn1 = driver.FindElement(By.Id("SaveButton"));
            savebtn1.Click();

            // click on administrationbutton
            IWebElement adminbtn1 = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminbtn1.Click();
            Thread.Sleep(1000);

            // click on Employee option from dropdown
            IWebElement empopt = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            empopt.Click();
            Thread.Sleep(2000);

            // Go to last page 

            IWebElement lastPage2 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastPage2.Click();
            Thread.Sleep(5000);

            // Check the name record to confirm if it was entered successfully
            IWebElement lastaddedrecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(lastaddedrecord.Text == "Nikita", "Record is not added");

        }

       public void EditEmployee(IWebDriver driver) 
       {
            // Go to last page
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(5000);

            //Inspect last add record
            //IWebElement newaddedRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            //if (newaddedRecord.Text == "Nikita")
            //{
            //    driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]")).Click();
            //    Thread.Sleep(5000);
            //}
            //else
            //{
            //    Assert.Fail("Record to be editted does not match newly added record");
            //}

            // Click on Edit button on the last added record
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]")).Click();

            // clear name field

            IWebElement editname = driver.FindElement(By.Id("Name"));
            editname.Clear();

            // Enter new record in name field
            driver.FindElement(By.Id("Name")).SendKeys("Niki");

            //Click on Save button
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(3000);

            // Click on Back to list 
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a")).Click();
            Thread.Sleep(3000);

            // go to lastpage
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(3000);

            IWebElement neweditedrecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(neweditedrecord.Text == "Niki", "Record is not edited");
            
       }

        public void DeleteEmployee(IWebDriver driver) 
        {
            // Go to last Page 
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")).Click();
            Thread.Sleep(5000);

            // Click on delete button
            driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]")).Click();
            Thread.Sleep(2000);

            driver.SwitchTo().Alert().Accept();
            
            Thread.Sleep(4000);

            IWebElement deletedname = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(deletedname.Text != "Niki", "Record hasn't been deleted");
        }
    }
}
