using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;


namespace bookingTestTask.Pages;
public class DatePicker:BasePage
{
    public DatePicker(IWebDriver driver) : base(driver)
    {
       
    }
    private IWebElement _monthPickerMonthList => driver.FindElement(By.XPath("//div[@class='bui-calendar__month']"));
    private IList<IWebElement> _dateList => driver.FindElements(By.XPath("(//tbody)[1]//tr//td/span/span"));
    private IWebElement _nextMonthSlider => driver.FindElement(By.XPath("//div[contains(@class, 'next')]"));

    public void ChooseDateFromDatePicker(string checkInMonth, string checkInDay, string checkOutDay)
    {
        while (true)
        {
            string month = _monthPickerMonthList.Text;
            if (month.Equals(checkInMonth))
            {
                break;
            }
            _nextMonthSlider.Click();
        }
        
        _dateList.First(day => day.Text.Equals(checkInDay)).Click();
        
        _dateList.First(day=>day.Text.Equals(checkOutDay)).Click();
    }
}