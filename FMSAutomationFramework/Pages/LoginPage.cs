using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CertsureAutomationFramework.Helpers;
using SeleniumExtras.PageObjects;
using System;
using System.Reflection;
using OpenQA.Selenium.Remote;

namespace CertsureAutomationFramework.Pages
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.PartialLinkText, Using = "Register/ Login")]
        public IWebElement LoginRegisterLink { get; set; }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement UsernameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PasswordTextBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type ='submit']")]
        public IWebElement LoginButton { get; set; }
        public DashboardPage LoginAsAdmin(TestContext context)
        {
            driver.Navigate().GoToUrl(context.Properties["SFURL"].ToString());
            LoginRegisterLink.Click();

            UsernameTextBox.SendKeys(context.Properties["SFUN"].ToString());
            PasswordTextBox.SendKeys(context.Properties["SFPW"].ToString());
            LoginButton.Click();

            return NOCSPageHelper.DashboardPage;
        }

    }



}
