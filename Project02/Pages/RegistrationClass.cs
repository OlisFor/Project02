using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.DevTools.V105.Page;
using Project02.StepDefinitions;
using Project02.StepDefinitions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02.Pages
{
    public class RegistrationClass
    {
        IWebDriver driver;
        

        IWebElement RegisterHere => driver.FindElement(By.XPath("//*[@id=\"login_form\"]/table/tbody/tr[7]/td/a"));
        IWebElement Usernamefield => driver.FindElement(By.XPath("//*[@id=\"username\"]"));
        IWebElement PasswordField => driver.FindElement(By.XPath("//*[@id=\"password\"]"));
        IWebElement ConfirmPasswordField => driver.FindElement(By.XPath("//*[@id=\"re_password\"]"));
        IWebElement  FullNameField =>driver.FindElement(By.XPath("//*[@id=\"full_name\"]"));
        IWebElement EmailField => driver.FindElement(By.XPath("//*[@id=\"email_add\"]"));
        IWebElement CaptchaTextField => driver.FindElement(By.XPath("//*[@id=\"captcha-form\"]"));
        IWebElement TermsCheck  =>driver.FindElement(By.XPath("//*[@id=\"tnc_box\"]"));
        IWebElement RegisterButton => driver.FindElement(By.XPath("//*[@id=\"Submit\"]"));
       

        public RegistrationClass()
        {
            driver = Hooks1.driver;
        }
        public void LaunchURl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void ClickNewUserRegisterHere ()
        {
            RegisterHere.Click();
        }

        public void RegistrationDetails (Table table)
        {
            var dictionary = TableExtension.ToDictionary(table);
            var test = dictionary["usernname"];

            Usernamefield.SendKeys(dictionary["Username"]);

            PasswordField.SendKeys(dictionary["Password"]);

            ConfirmPasswordField.SendKeys(dictionary["Confirm Password"]);

            FullNameField.SendKeys(dictionary["Full Name"]);

            EmailField.SendKeys(dictionary["Email Address"]);


        }

      
        public void EnterCaptcha()
        {

        }

        public void ClickTerms()
        {
            TermsCheck.Click();
        }
        public void ClickRegister()
        {
            RegisterButton.Click();
        }

}
}
