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
       private IWebElement _nextMonthSlider => driver.FindElement(By.XPath("//div[contains(@class, 'next')]"));
       //private IWebElement _desiredCheckInDate => driver.FindElement(By.XPath("//span[@aria-label='1 December 2022']"));
       private IWebElement _desiredCheckInDate => driver.FindElement(By.XPath("//td[@data-date='2022-12-01']"));
       //private IWebElement _desiredCheckOutDate => driver.FindElement(By.XPath("//span[@aria-label='31 December 2022']"));
       private IWebElement _desiredCheckOutDate => driver.FindElement(By.XPath("//td[@data-date='2022-12-31']"));
       private IWebElement _signInButton => driver.FindElement(By.XPath("//span[contains(text(), 'Sign in')][1]"));
       private IWebElement _myProfileIdentificator =>
           driver.FindElement(By.XPath("span[@id='profile-menu-trigger--title']"));
       
       
        
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

        public void WaitAndClickNextMonthSlider(int timeToWait)
        {
            for (int i = 0; i < 3; i++)
            {
                _nextMonthSlider.WaitAndClick(driver,timeToWait); 
            }
        }

        public void WaitAndClickDesiredCheckInDate(int timeToWait)
        {
            _desiredCheckInDate.WaitElementAndCheckIfDisplayed(driver, timeToWait);
            Actions action =new Actions(driver);
            action.DoubleClick(_desiredCheckInDate).Build().Perform();
        }

        public void WaitAndClickDesiredCheckOutDate(int timeToWait)
        {
            _desiredCheckOutDate.WaitElementAndCheckIfDisplayed(driver, timeToWait);
            Actions action =new Actions(driver);
            action.ClickAndHold(_desiredCheckOutDate).Click().Build().Perform();
        }

        public void WaitAndClickSubmitSearchButton(int timeToWait)
        {
            _submitSearchButton.WaitAndClick(driver, timeToWait);
        }

        public void WaitAndClickDesiredDestinationItem(int timeToWait)
        {
            _desiredDestinationItem.WaitAndClick(driver,timeToWait);
        }
        
        public bool WaitAndCheckIfProfileIdentificatorIsDisplayed(int timeToWait)
        {
            return _myProfileIdentificator.WaitElementAndCheckIfDisplayed(driver,timeToWait);
        }

        public void ClickCheckIn()
        {
            _desiredCheckInDate.Click();
        }
        public void ClickCheckOut()
        {
            _desiredCheckOutDate.Click();
        }

    }


    