using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AutomationTestStore.Framework.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _context;
        private IWebDriver _driver;

        public Hooks(ScenarioContext context)
        {
            _context = context;
        }

        [BeforeScenario]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            _context["driver"] = _driver;
        }

        [AfterScenario]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}