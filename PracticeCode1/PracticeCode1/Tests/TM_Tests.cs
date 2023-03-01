// Invoke browser

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PracticeCode1.Pages;
using System.Threading;

IWebDriver driver = new ChromeDriver();

LoginPage LoginPageObj = new LoginPage();
LoginPageObj.LoginActions(driver);

HomePage HomePageObj = new HomePage();
HomePageObj.GoToTMPage(driver);

TMPage TMPageObj= new TMPage();
TMPageObj.CreateTM(driver);
TMPageObj.EditTM(driver);
TMPageObj.DeleteTM(driver);


/* Check if user has successfully logged in 
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("User has logged in successfully");
}
else
{
    Console.WriteLine("login unsuccessful");
}
*/
//create new time record 


// Click on create new button





