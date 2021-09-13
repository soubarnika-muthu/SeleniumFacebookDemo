/*Project: Automation Testing using Selenium-FaceBook 
 *Author: Soubarnika Muthu V
 *Date: 09/09/2021
 */
using NUnit.Framework;

namespace SeleniumDemo_FB
{
    public class Tests: BaseClass.BaseClass
    {

        [Test]
        public void TestInput_Password()
        {
            DoAction.DoAction.Assert_Titleof_Webpage(driver);
            DoAction.DoAction.LogintoFacebook(driver);
           
        }


    }
}