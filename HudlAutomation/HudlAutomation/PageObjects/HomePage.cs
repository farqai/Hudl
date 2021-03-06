﻿using HudlAutomation.Utilities;
using OpenQA.Selenium;

namespace HudlAutomation.PageObjects
{
    class HomePage
    {
        private readonly IWebDriver _webDriver;
        private readonly WebDriverExtension _extension;
        private readonly By _loginBtn = By.LinkText("Log in");

        public HomePage(IWebDriver driver)
        {
            this._webDriver = driver;
            _extension = new WebDriverExtension(driver);
        }

        public void GoToLoginPage()
        {
            _webDriver.FindElement(_loginBtn).Click();
        }
    }
}