using OpenQA.Selenium;
using Project02.StepDefinitions.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02.Pages
{
    public class Signinpage
    {
        IWebDriver driver;

        IWebElement UsernameHere => driver.FindElement(By.XPath("//*[@id=\"username\"]"));
        IWebElement PasswordHere => driver.FindElement(By.XPath("//*[@id=\"password\"]"));
        IWebElement LoginButton => driver.FindElement(By.XPath("//*[@id=\"login\"]"));
        IWebElement SignoutButton => driver.FindElement(By.XPath(""));

    
        public Signinpage()
        {
            driver = Hooks1.driver;
        }
        public void LaunchUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void EnterUsername()
        {
            UsernameHere.SendKeys("lawaltidjaniyinoussa@gmail.com");
        }
        public void EnterPassword()
        {
            PasswordHere.SendKeys("work365daysAyear");
        }
        public void ClickLoginButton()
        {
            LoginButton.Click();
        }
    }


}  

