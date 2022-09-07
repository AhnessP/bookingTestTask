using bookingTestTask.Decorators;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace bookingTestTask.Pages;

    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            
        } 
        
        private IWebElement _acceptCookiesButton => driver.FindElement(By.XPath("//button[text()='Accept']"));
        
        private IWebElement _inputDestinationField => driver.FindElement(By.XPath("//input[contains(@aria-label, 'destination')]")); 
        
        private IWebElement _datePickerField => driver.FindElement(By.XPath("//div[@class='xp__dates xp__group']"));
        
        private IWebElement _submitSearchButton => driver.FindElement(By.XPath("//span[contains(@class, 'submit-text')]"));
        
        private IWebElement _desiredDestinationItem => driver.FindElement(By.XPath("//li[contains(@data-label, 'New York')][1]"));
        
        private IWebElement _signInButton => driver.FindElement(By.XPath("//span[contains(text(), 'Sign in')][1]"));
       
       public void WaitAndClickAcceptCookiesButton(int timeToWait)
       {
           _acceptCookiesButton.WaitAndClick(driver, timeToWait);
       }
       
       public void WaitAndSendKeysToInputDestinationField(int timeToWait, string destination)
       {
            _inputDestinationField.WaitAndSendKeys(driver,timeToWait, destination);
       }

       public void WaitAndClickInputDestinationField(int timeToWait)
       {
            _inputDestinationField.WaitAndClick(driver, timeToWait);
       }
        
        
       public void WaitAndClickDatePickerField(int timeToWait)
       {
            _datePickerField.WaitElementAndCheckIfDisplayed(driver, timeToWait);
            Actions action =new Actions(driver);
            action.DoubleClick(_datePickerField).Build().Perform();
       }
       
       public void WaitAndClickSignInButton(int timeToWait)
       {
            _signInButton.WaitAndClick(driver, timeToWait);
       }

       public void WaitAndClickSubmitSearchButton(int timeToWait)
       {
            _submitSearchButton.WaitAndClick(driver, timeToWait);
       }

       public void WaitAndClickDesiredDestinationItem(int timeToWait)
       {
            _desiredDestinationItem.WaitAndClick(driver,timeToWait);
       }
        

    }


    
