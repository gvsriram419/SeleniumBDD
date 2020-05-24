using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumBDD
{
    public  class PageObjectClass1
    {
 
        IWebDriver driver;
        By Titlechecker = By.XPath("(//a[@title='Sign in to Guru'])[1]");
        By Login = By.XPath("//*[@id='app']/div/div/div/div[1]/div/form/input[1]");
        By Password = By.Name("password");
        By Submit = By.XPath("//button[contains(text(),'Log in')]");

        //Contructor
        public PageObjectClass1(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void TitleCheck()
        {
            driver.FindElement(Titlechecker).Click();
        }

        public void LoginCheck()
        {
            driver.FindElement(Login).SendKeys("Hello");
        }

        public void PasswordCheck()
        {
            driver.FindElement(Password).SendKeys("HelloSaiRam");
        }

        public void SubmitCheck()
        {
            driver.FindElement(Submit).Click();
        }


    }
}
