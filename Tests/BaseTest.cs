using bookingTestTask.Helpers;
using bookingTestTask.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace bookingTestTask.Tests
{

    public class BaseTest
    {
        protected IWebDriver driver;
        protected DataModel.DataModel dataModel;

        [SetUp]
        public virtual void SetUp()
        {
            InitializeData();
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(dataModel.SiteUrl);
        }

        [TearDown]
        public virtual void TearDown()
        {
            driver.Quit();
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

        public HomePage GetHomePage()
        {
            return new HomePage(GetDriver());
        }
        private void InitializeData()
        {
            dataModel = new DataReader().ReadDataFromTestData();
        }
        public SignInPage GetSignInPage()
        {
            return new SignInPage(GetDriver());
        }

        public SearchResultsPage GetSearchResultsPage()
        {
            return new SearchResultsPage(GetDriver());
        }

        public DatePicker GetDatePicker()
        {
            return new DatePicker(GetDriver());
        }
        
    }
}