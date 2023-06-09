using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationDemoProject.utilities;

namespace TestAutomationDemoProject.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage() 
        {
            driver = Hooks1.driver;
        
        }
        IWebDriver driver;

        IWebElement FirstName => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(2) > input"));
        IWebElement LastName => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(3) > input"));
        IWebElement Address => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(2) > div > textarea"));
        IWebElement Email => driver.FindElement(By.CssSelector("#eid > input:nth-child(1)"));
        IWebElement PhoneNumber => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(4) > div > input"));
        IWebElement Password => driver.FindElement(By.XPath("//*[@id=\"firstpassword\"]"));
        IWebElement ConfirmPassword => driver.FindElement(By.XPath("//*[@id=\"secondpassword\"]"));
        IWebElement Submit => driver.FindElement(By.XPath("//*[@id=\"submitbtn\"]"));
       
        
        
        public void EnterFirstName() 
        {
            FirstName.SendKeys("AYO");
        }
     
        public void EnterLastName() 
        {
            LastName.SendKeys("Mide");
        
        }
    
        public void EnterAddress() 
        {
            Address.SendKeys("12 london street");
        
        }
        
        public void EnterEmail() 
        {
            Email.SendKeys("mide@g.com");
        }
    
        public void EnterPhoneNumber() 
        {
            PhoneNumber.SendKeys("09032024681");
        
        }
        
        public void EnterPassword() 
        { 
         Password.SendKeys("Ayo123");
        
        }
         
        public void EnterConfirmPassword()
        {
            ConfirmPassword.SendKeys("Ayo123");

        }
    
       public void ClickOnSubmit() 
        { 
        Submit.Click();
        
        }

        public void NavigateToWebsite() 
        {
            driver.Navigate().GoToUrl("https://demo.automationtesting.in/Register.html");
        
        }
    
    
    
    
    
   
    
    
    }
}
