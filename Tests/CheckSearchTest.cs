using NUnit.Framework;
using bookingTestTask.Pages;


namespace bookingTestTask.Tests
{

    class CheckSearchTest : BaseTest
    {
        HomePage homePage;
        SearchResultsPage searchResultsPage;
        DatePicker datePicker;
        

        [Test]
        public void CheckSearchResultsAreRelevant()
        {
            homePage = GetHomePage();
            homePage.WaitAndClickAcceptCookiesButton(dataModel.TimeToWait);
            homePage.WaitAndClickInputDestinationField(dataModel.TimeToWait);
            homePage.WaitAndSendKeysToInputDestinationField(dataModel.TimeToWait, dataModel.Destination);
            homePage.ImplicitWait(dataModel.TimeToWait);
            homePage.WaitAndClickDesiredDestinationItem(dataModel.TimeToWait);
            homePage.ImplicitWait(dataModel.TimeToWait);
            homePage.WaitAndClickDatePickerField(dataModel.TimeToWait);
            datePicker = GetDatePicker();
            datePicker.ImplicitWait(dataModel.TimeToWait);
            datePicker.ChooseDateFromDatePicker(dataModel.CheckInMonth, dataModel.CheckInDay, dataModel.CheckOutDay);
            homePage.WaitAndClickSubmitSearchButton(dataModel.TimeToWait);
            searchResultsPage = GetSearchResultsPage();
            searchResultsPage.WaitForPageLoad(dataModel.TimeToWait);
            var expectedResultsCount = searchResultsPage.CountResults();
            var actualResultsAddresses= searchResultsPage.CountRightDestinationSetted();
            var actualResultsDates = searchResultsPage.CountRightDatesSetted();
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedResultsCount, actualResultsAddresses, 
                    "Destination doesn't appears correctly on each search result");
                Assert.AreEqual(expectedResultsCount, actualResultsDates,
                    "Dates are not setted correctly on each search result");
            });
        }

    }
}