using System.Collections.Generic;
using System.Linq;
using bookingTestTask.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
namespace bookingTestTask.Component;

public class DatePickerComponent:BasePage
{
    public DatePickerComponent(IWebDriver driver) : base(driver)
    {
       
    }
    [FindsBy(How = How.XPath, Using = "//td[@class='bui-calendar__date']")]
    private IList<IWebElement> _datePickerDaysList;
    [FindsBy(How = How.XPath, Using = "//div[@class='bui-calendar__month']")]
    private IWebElement _monthPickerMonthList;
    
    

    [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'next')]")]
    private IWebElement _arrowForSwitchingMonth;

    public void ChooseDateFromDatePicker(string checkInMonth, string checkInDay)
    {
        while (true)
        {
            string month = _monthPickerMonthList.Text;
            if (month.Equals(checkInMonth))
            {
                break;
            }
            else
            {
                _arrowForSwitchingMonth.Click();
            }
        }

    }
}