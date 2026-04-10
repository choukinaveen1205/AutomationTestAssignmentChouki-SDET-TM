using TechTalk.SpecFlow;
using OpenQA.Selenium;
using AutomationTestStore.Framework.Pages;
using AutomationTestStore.Framework.Drivers;
using FluentAssertions;

namespace AutomationTestStore.Framework.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _page;

        public LoginSteps(ScenarioContext context)
        {
            _driver = new DriverManager(context).GetDriver();
            _page = new LoginPage(_driver);
        }

        [Given(@"User navigates to login page")]
        public void Navigate()
        {
            _page.Navigate();
        }

        [When(@"User enters valid username and password")]
        public void ValidLogin()
        {
            _page.Login("testuser", "Password123");
        }

        [When(@"User enters invalid username and password")]
        public void InvalidLogin()
        {
            _page.Login("wrong", "wrong123");
        }

        [When(@"Clicks on login button")]
        public void ClickLogin() { }

        [Then(@"User should be logged in successfully")]
        public void VerifySuccess()
        {
            _driver.Url.Should().Contain("account");
        }

        [Then(@"Login error message should be displayed")]
        public void VerifyError()
        {
            _page.GetError().Should().Contain("Error");
        }
    }
}