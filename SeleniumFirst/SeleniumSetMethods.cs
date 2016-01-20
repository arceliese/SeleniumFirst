using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public static class SeleniumSetMethods
    {
        //EnterText
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //Click into a button, checkbox, option etc
        public static void Click(this IWebElement element)
        {
            element.Click();
        }

        //Selecting a drop down control
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);           
        }

        //Wait for object
        public static void WaitForObject(By element)
        {
            WebDriverWait wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementIsVisible(element));
        }
    }
}