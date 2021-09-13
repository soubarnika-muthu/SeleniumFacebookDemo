/*Project: Automation Testing using Selenium-FaceBook 
 *Author: Soubarnika Muthu V
 *Date: 09/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


namespace SeleniumDemo_FB.BaseClass
{
    public class BaseClass
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            //implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            
            //Explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }
        [TearDown]
        public void shutdown()
        {
            driver.Close();
        }
    }
}
