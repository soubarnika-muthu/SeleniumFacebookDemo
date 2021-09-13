/*Project: Automation Testing using Selenium-FaceBook 
 *Author: Soubarnika Muthu V
 *Date: 09/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumDemo_FB.Pages
{
    public class LoginPage
    {

        public static void Assert_Titleof_Webpage(IWebDriver driver)
        {
            string title1 = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void Login_To_Facebook(IWebDriver driver)
        {
            //Iwebelement interface
            IWebElement email = driver.FindElement(By.Name("email"));
            //Sendkeys method to type text 
            email.SendKeys("abc@gmail.com");

            IWebElement password = driver.FindElement(By.Id("pass"));
            password.SendKeys("12345");

            IWebElement login = driver.FindElement(By.Name("login"));
            login.Click();

            //implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //Explicit wait

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }

    }
}
