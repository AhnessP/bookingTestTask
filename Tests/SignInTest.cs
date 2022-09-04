using NUnit.Framework;
using bookingTestTask.Pages;

namespace bookingTestTask.Tests;

[TestFixture]
public class SignInTest:BaseTest 
{
   
    HomePage homePage;
    SignInPage signInPage;

    [SetUp]
    public void SetUp()
    {
        homePage = GetHomePage();
        homePage.WaitAndClickSignInButton(dataModel.TimeToWait);
        signInPage = GetSignInPage();
    }
    
    [Test]
    public void CheckUserIsUnableToSignInWithInvalidEmail()
    {
        signInPage.WaitAndClickInputEmailField(dataModel.TimeToWait);
        signInPage.WaitForPageLoad(dataModel.TimeToWait);
        signInPage.WaitAndSendKeysToInputEmailField(dataModel.TimeToWait,dataModel.InvalidEmail);
        signInPage.WaitAndClickSubmitButton(dataModel.TimeToWait);
        Assert.IsTrue(signInPage.WaitAndCheckIfInvalidEmailAlertExists(dataModel.TimeToWait),
            "User is able to sign in with invalid email" );
    }
    [Test]
    public void CheckUserIsUnableToSignInWithoutEmail()
    {
        signInPage.WaitAndClickSubmitButton(dataModel.TimeToWait);
        Assert.IsTrue(signInPage.WaitAndCheckIfInvalidEmailAlertExists(dataModel.TimeToWait),
            "User is able to sign in without email" );
    }

}