using System.Collections.Generic;
using OpenQA.Selenium;
using System.Linq;


namespace bookingTestTask.Pages;
public class SearchResultsPage :BasePage
{
    public SearchResultsPage(IWebDriver driver) : base(driver)
    {
        
    }
    
    private IList<IWebElement> _searchResultsList => driver.FindElements(By.XPath("//div[@data-testid='property-card']"));
    private IList<IWebElement> _settedDestinationsList => driver.FindElements(By.XPath("//span[@data-testid='address']"));
    private IList<IWebElement> _settedDatesList => driver.FindElements(By.XPath("//div[@data-testid='price-for-x-nights']"));

    public int CountResults()
    {
        return  _searchResultsList.Count();
    }

    public int CountRightDestinationSetted()
    {
        return _settedDestinationsList.Select(address => address.Text.Contains("New York")).Count();
    }

    public int CountRightDatesSetted()
    {
        return _settedDatesList.Select(dates => dates.Text.Contains("30 nights")).Count();
    }
    
}