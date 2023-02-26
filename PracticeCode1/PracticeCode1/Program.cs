// Invoke browser

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
Thread.Sleep(1000);

// Hit Url - Launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
// Identify username textbox and enter username
IWebElement usernametextbox = driver.FindElement(By.Id("UserName"));
usernametextbox.SendKeys("hari");
// Identify password textbox and enter password
IWebElement pwdtextbox = driver.FindElement(By.Id("Password"));
pwdtextbox.SendKeys("123123");
// Click submit
IWebElement loginBtn = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginBtn.Click();
// Check if user has successfully logged in 
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("User has logged in successfully");
}
else
{
    Console.WriteLine("login unsuccessful");
}

//create new time record 

IWebElement adminbtn = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
adminbtn.Click();
Thread.Sleep(1000);

// Navigate to time & material  page
IWebElement timematerialbtn = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timematerialbtn.Click();
// Click on create new button

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
codebox.SendKeys("February2023");


// Pass value in description
IWebElement descriptionbox = driver.FindElement(By.Id("Description"));
descriptionbox.SendKeys("February23");

// Pass value in Price field 
IWebElement priceunit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceunit.SendKeys("12");
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

if (record.Text == "February2023")
{
    Console.WriteLine("New record added successfully");
}
else 
{
    Console.WriteLine("record not added");
}

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

//Click on Delete button 
IWebElement deletebtn = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
deletebtn.Click();
Thread.Sleep(2000);

// Click on OK button on popup box
IAlert al = driver.SwitchTo().Alert();
al.Accept();
Thread.Sleep(2000);


IWebElement deleterecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if (deleterecord.Text == "Gets2023") 
{
    Console.WriteLine("Record has not been deleted successfully");
}
else
{
    Console.WriteLine("Record is deleted successfully");
}


driver.Quit();

