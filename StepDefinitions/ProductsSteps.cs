using TechTalk.SpecFlow;
using OpenQA.Selenium;
using AutomationTestStore.Framework.Pages;
using AutomationTestStore.Framework.Drivers;
using FluentAssertions;

namespace AutomationTestStore.Framework.StepDefinitions
{
    [Binding]
    public class ProductSteps
    {
        private readonly IWebDriver _driver;
        private readonly ProductsPage _page;

        public ProductSteps(ScenarioContext context)
        {
            _driver = new DriverManager(context).GetDriver();
            _page = new ProductsPage(_driver);
        }

        [Given(@"User is on home page")]
        public void Home()
        {
            _page.Navigate();
        }

        [When(@"User searches for a valid product")]
        public void ValidSearch()
        {
            _page.Search("shirt");
        }

        [When(@"User searches for an invalid product")]
        public void InvalidSearch()
        {
            _page.Search("xyz123");
        }

        [Then(@"Product should be displayed")]
        public void Product()
        {
            _page.IsProductDisplayed().Should().BeTrue();
        }

        [Then(@"No product message should be displayed")]
        public void NoProduct()
        {
            _page.IsNoProduct().Should().BeTrue();
        }
    }
}