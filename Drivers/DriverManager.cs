using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomationTestStore.Framework.Drivers
{
    public class DriverManager
    {
        private readonly ScenarioContext _context;

        public DriverManager(ScenarioContext context)
        {
            _context = context;
        }

        public IWebDriver GetDriver()
        {
            return _context.Get<IWebDriver>("driver");
        }
    }
}