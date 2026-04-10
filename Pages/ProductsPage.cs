using OpenQA.Selenium;

namespace AutomationTestStore.Framework.Pages
{
    public class ProductsPage
    {
        private IWebDriver driver;

        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By searchBox = By.Id("filter_keyword");
        private By searchBtn = By.XPath("//button[@title='Go']");
        private By product = By.XPath("//div[@class='product']");
        private By noProduct = By.XPath("//div[contains(text(),'No products')]");

        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://automationteststore.com/");
        }

        public void Search(string text)
        {
            driver.FindElement(searchBox).SendKeys(text);
            driver.FindElement(searchBtn).Click();
        }

        public bool IsProductDisplayed()
        {
            return driver.FindElements(product).Count > 0;
        }

        public bool IsNoProduct()
        {
            return driver.FindElements(noProduct).Count > 0;
        }
    }
}