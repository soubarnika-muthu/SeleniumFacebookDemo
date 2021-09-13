/*Project: Automation Testing using Selenium-FaceBook 
 *Author: Soubarnika Muthu V
 *Date: 09/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace SeleniumDemo_FB.Pages
{
    public class LoginPage
    {

        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

        }
        [FindsBy(How = How.Id, Using = "email")]

        public IWebElement email;

        [FindsBy(How = How.Id, Using = "pass")]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "login")]
        public IWebElement loginbt;

    }
}
