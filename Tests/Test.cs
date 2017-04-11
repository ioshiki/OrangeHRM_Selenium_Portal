using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class Tests
{
    //initalize variables for navigation and username/password input fields.
    static IWebDriver driver = new ChromeDriver();
    static IWebElement user, password; 

        static void Main()
        {
        //create a string called "url" for the driver to call.
        //Helps make it so that you do not have to change the url parameter everytime 
        string url = "http://opensource.demo.orangehrmlive.com";
        driver.Navigate().GoToUrl(url);

        //scans the username and password input fields and sends the login values 
        user = driver.FindElement(By.Name("txtUsername"));
        user.SendKeys("fiona.grace");

        password = driver.FindElement(By.Name("txtPassword"));
        password.SendKeys("fiona.grace");

        //Clicks the submit button to log on to our portal
        IWebElement buttonclick = driver.FindElement(By.Name("Submit"));
        
        //pauses for 3 seconds before hitting clicking the submit button
        Thread.Sleep(3000);
        buttonclick.Click();


        //waits 7 seconds before quitting.
        Thread.Sleep(7000);
        driver.Quit();
    

        
        }
    
}
