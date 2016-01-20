//This is test change 3

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {               
        static void Main(string[] args)
        {          
                
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            
            //Navigate to Google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }

        [Test]   
        public void ExecuteTest()
        {
            //Login to Application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObjects pageEA = pageLogin.Login("execute", "automation");
            pageEA.FillUserForm("T", "Torres", "Arcy");
          
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
