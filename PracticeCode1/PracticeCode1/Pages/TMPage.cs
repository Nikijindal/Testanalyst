using OpenQA.Selenium;
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

            // Select time option from Typecode dropdown list 

            IWebElement typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typecodedropdown.Click();
            Thread.Sleep(1000);

            IWebElement timeselectdropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeselectdropdown.Click();


            // Pass value in code field 
            IWebElement codebox = driver.FindElement(By.Id("Code"));
            codebox.SendKeys("Test2023");


            // Pass value in description
            IWebElement descriptionbox = driver.FindElement(By.Id("Description"));
            descriptionbox.SendKeys("TestOnly");

            // Pass value in Price field 
            IWebElement priceunit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceunit.SendKeys("6000");
            Thread.Sleep(1000);

            // Click on save button
            IWebElement savebtn = driver.FindElement(By.Id("SaveButton"));
            savebtn.Click();
            Thread.Sleep(3000);

            // Click on lastpage
            IWebElement lastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]"));
            lastpage.Click();
            Thread.Sleep(2000);

            IWebElement record = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]")); ////*[@id="tmsGrid"]/div[3]/table/tbody/tr[2]/td[5]/a[1]

            if (record.Text == "Test2023")
            {
                Console.WriteLine("New record added successfully");
            }
            else
            {
                Console.WriteLine("record not added");
            }

            

        }
        public void EditTM(IWebDriver driver)
        {
            // Click on edit button to edit record

            IWebElement editbtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]")); ////*[@id="tmsGrid"]/div[3]/table/tbody/tr[2]/td[5]/a[1]
            editbtn.Click();

            // Clear code field
            IWebElement codeedit = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            codeedit.Clear();

            // Enter new record in Code field
            IWebElement codebtn = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            codebtn.SendKeys("Gets2023");

            //Click on save button after editing record
            IWebElement editsavebtn = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
            editsavebtn.Click();
            Thread.Sleep(3000);



            // Go to last page after editing record

            IWebElement editlastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")); ////*[@id="tmsGrid"]/div[4]/a[4]/span
            editlastpage.Click();
            Thread.Sleep(2000);

            IWebElement Editedrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (Editedrecord.Text == "Gets2023")
            {
                Console.WriteLine("Record is edited successfully");
            }
            else
            {
                Console.WriteLine("Record not Editted");
            }
             
        }

        public void DeleteTM(IWebDriver driver)
        {
            // Go to last page again for deletion
            IWebElement DLlastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")); ////*[@id="tmsGrid"]/div[4]/a[4]/span
            DLlastpage.Click();
            Thread.Sleep(5000);

            //Click on Delete button 
            IWebElement deletebtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deletebtn.Click();
            Thread.Sleep(2000);

            // Click on OK button on popup box
           IAlert al = driver.SwitchTo().Alert();
            al.Accept();
            Thread.Sleep(2000);


            IWebElement deletedrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if(deletedrecord.Text == "Gets2023")
            {
                Console.WriteLine("Record is not deleted");
            }
            else
            {
                Console.WriteLine("Record deleted successfully");
            }

            driver.Quit();
            
            
            
            
        }
    }
}
