/*Project: Automation Testing using Selenium-FaceBook 
 *Author: Soubarnika Muthu V
 *Date: 09/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumDemo_FB.Pages;


namespace SeleniumDemo_FB.DoAction
{
    public  class DoAction
    {
        public static LoginPage login;

        public static void Assert_Titleof_Webpage(IWebDriver driver)
        {
            string title1 = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void LogintoFacebook(IWebDriver driver)
        {
            login = new LoginPage(driver);
            login.email.SendKeys("abc@gmail.com");
            System.Threading.Thread.Sleep(20);
            login.password.SendKeys("1234");
            login.loginbt.Click();
        }
    }
}