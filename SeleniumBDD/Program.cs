using Google/**/.Protobuf.WellKnownTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumBDD
{
   
    [Test]
    public class Program
    {
       // IWebDriver driver;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Here");
            IWebDriver driver = new ChromeDriver();
            PageObjectClass1 page = new PageObjectClass1(driver);
            driver.Navigate().GoToUrl("https://help.getguru.com/articles/cMEdM8Mi/Setting-up-Board-Permissions");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait.TotalSeconds.Equals(50);
            page.TitleCheck();
            page.LoginCheck();
            page.PasswordCheck();
            page.SubmitCheck();
            driver.Quit();
        }


























































    }

}
