using NUnit.Framework;
using OpenQA.Selenium;
using PracticeCode1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode1.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {

            IWebElement createNewbutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewbutton.Click();
            Thread.Sleep(1000);

            // Select time option from Typecode dropdown list 

            IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodeDropdown.Click();
            Thread.Sleep(1000);

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();


            // Pass value in code field 
            IWebElement codebox = driver.FindElement(By.Id("Code"));
            codebox.SendKeys("Test2023");


            // Pass value in description
            IWebElement descriptionbox = driver.FindElement(By.Id("Description"));
            descriptionbox.SendKeys("T20");

            // Pass value in Price field 
            IWebElement priceunit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceunit.SendKeys("6000");



            // Click on save button
            IWebElement savebtn = driver.FindElement(By.Id("SaveButton"));
            savebtn.Click();
            Thread.Sleep(5000);


            // Click on lastpage
            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastpage.Click();
            Thread.Sleep(5000);

        }

            //IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            //Thread.Sleep(1000);

            //Assert.That(newcode.Text == "Test2023", "Actual & expected code does not match");
           
            
            //if (record.Text == "Test2023")
            //{
            //    //Console.WriteLine("New record added successfully");
            //    Assert.Pass("New record added successfully");
            //}
            //else
            //{
            //    Assert.Fail("record not added");
            //}

        public string GetCode(IWebDriver driver)
        {
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return actualCode.Text;
        }

        public string GetDescription(IWebDriver driver) 
        {
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return actualDescription.Text;
        }

        public string GetPrice(IWebDriver driver) 
        {
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return actualPrice.Text;
            
        }
        
        public void EditTM(IWebDriver driver,string description,string code,string price)
        {

           //Go to last page 
           Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]", 5);
           
            driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
            
            // Thread.Sleep(8000);

            IWebElement recordtoBeEdited = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            // // Click on edit button to edit record
            if (recordtoBeEdited.Text == "Test2023")
            {
                IWebElement lastRecordEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                lastRecordEdit.Click();
            }
            else
            {
                Assert.Fail("Record to be edited not found");
            }

            
            //IWebElement editbtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]")); ////*[@id="tmsGrid"]/div[3]/table/tbody/tr[2]/td[5]/a[1]
            //editbtn.Click();

            // Clear code field
            IWebElement codeedit = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            codeedit.Clear();

            // Enter new record in Code field
            IWebElement codeTextBox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            codeTextBox.SendKeys(code);
            Thread.Sleep(1500);

            // Clear description field
            IWebElement descriptionedit = driver.FindElement(By.Id("Description"));
            descriptionedit.Clear();
            descriptionedit.SendKeys(description);
            Thread.Sleep(1500);

            IWebElement priceedit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceedit.Clear();
            priceedit.SendKeys(price);
            Thread.Sleep(1500);



            //Click on save button after editing record
            IWebElement editsavebtn = driver.FindElement(By.Id("SaveButton"));
            editsavebtn.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 3);


            // Go to last page after editing record

            IWebElement editlastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")); ////*[@id="tmsGrid"]/div[4]/a[4]/span
            editlastpage.Click();
            Thread.Sleep(8000);

            IWebElement editedrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(3000);

            Assert.That(editedrecord.Text == "Get2023", "Record is not editted");
            //if (Editedrecord.Text == "Get2023")
            //{
            //    Console.WriteLine("Record is edited successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Record not Editted");
            //}
             
        }

        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement createdDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return createdDescription.Text;
        }

        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement createdCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return createdCode.Text;
        }

        public string GetEditedPrice(IWebDriver driver)
        {
            IWebElement createdPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));
            return createdPrice.Text;
        }
        public void DeleteTM(IWebDriver driver)
        {
            // Go to last Page
            Thread.Sleep(5000);
            IWebElement GotolastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            GotolastPage.Click();
            Thread.Sleep(8000);

            IWebElement recordtobeDeleted = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (recordtobeDeleted.Text == "Get2023") 
            {
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(5000); 
            }
            else
            {
                Assert.Fail("Record to be deleted not found");
            }

            IAlert al = driver.SwitchTo().Alert();
            al.Accept();
            Thread.Sleep(8000);
            IWebElement deletedRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(5000);

            Assert.That(deletedRecord.Text != "Get2023", "Record hasn't been deleted");

        }

        

    }
}
