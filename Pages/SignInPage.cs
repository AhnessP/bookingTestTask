using OpenQA.Selenium;
using bookingTestTask.Decorators;

namespace bookingTestTask.Pages;

public class SignInPage:BasePage
{
    public SignInPage(IWebDriver driver) : base(driver)
    {
        
    }
    private IWebElement _inputEmailField => driver.FindElement(By.XPath("//input[@type='email']"));
    private IWebElement _submitButton => driver.FindElement(By.XPath("//button[@type='submit']"));
    private IWebElement _emailAlertMessage => driver.FindElement(By.XPath("//div[@role='alert']"));

    public void WaitAndClickInputEmailField(int timeToWait)
    {
        _inputEmailField.WaitAndClick(driver, timeToWait);
    }
    public void WaitAndSendKeysToInputEmailField(int timeToWait,string email)
    {
        _inputEmailField.WaitAndSendKeys(driver,timeToWait, email);
    }
    
    public bool WaitAndCheckIfInvalidEmailAlertExists(int timeToWait)
    {
        return _emailAlertMessage.WaitElementAndCheckIfDisplayed(driver, timeToWait);
    }
    public void WaitAndClickSubmitButton(int timeToWait)
    {
        _submitButton.WaitAndClick(driver, timeToWait);
    }
    
}