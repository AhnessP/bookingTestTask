using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace bookingTestTask.Pages;

    public class BasePage
    {
        protected readonly IWebDriver driver;

        protected BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ImplicitWait(int timeToWait)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeToWait);
        }
        public void WaitForPageLoad(int timeToWait)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeToWait));
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }
        public string GetPageUrl()
        {
            return driver.Url;
        }
      
    }
