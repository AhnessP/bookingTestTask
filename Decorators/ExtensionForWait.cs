using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace bookingTestTask.Decorators
{

    public static class ExtensionForWait
    {
        public static void WaitAndClick(this IWebElement element, IWebDriver driver, int timeToWait)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeToWait));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }

        public static void WaitAndSendKeys(this IWebElement element, IWebDriver driver, int timeToWait, string text)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeToWait));
            wait.Until(driver => element.Displayed);
            element.SendKeys(text);
        }

        public static bool WaitElementAndCheckIfDisplayed(this IWebElement element, IWebDriver driver, int timeToWait)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeToWait));
            wait.Until(driver => element.Displayed);
            return element.Displayed;
        }
    }
}


