using NUnit.Framework;

namespace SeleniumDemo_FB
{
    public class Tests:BaseClass.BaseClass
    {

        [Test]
        public void Input_Email_Password()
        {
            Pages.LoginPage.Assert_Titleof_Webpage(driver);
            Pages.LoginPage.Login_To_Facebook(driver);
        }
        
    }
}