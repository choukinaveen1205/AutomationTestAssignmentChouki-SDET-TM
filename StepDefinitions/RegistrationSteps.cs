using TechTalk.SpecFlow;
using OpenQA.Selenium;
using AutomationTestStore.Framework.Pages;
using AutomationTestStore.Framework.Drivers;
using FluentAssertions;

namespace AutomationTestStore.Framework.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        private readonly IWebDriver _driver;
        private readonly RegistrationPage _page;

        public RegistrationSteps(ScenarioContext context)
        {
            _driver = new DriverManager(context).GetDriver();
            _page = new RegistrationPage(_driver);
        }

        [Given(@"User navigates to registration page")]
        public void Navigate()
        {
            _page.Navigate();
        }

        [When(@"User enters valid registration details")]
        public void Fill()
        {
            _page.FillForm();
        }

        [When(@"User submits registration form")]
        public void Submit()
        {
            _page.Submit();
        }

        [When(@"User submits empty registration form")]
        public void Empty()
        {
            _page.Submit();
        }

        [Then(@"Account should be created successfully")]
        public void Success()
        {
            _driver.Url.Should().Contain("success");
        }

        [Then(@"Registration error messages should be displayed")]
        public void Error()
        {
            _page.GetError().Should().NotBeNull();
        }
    }
}