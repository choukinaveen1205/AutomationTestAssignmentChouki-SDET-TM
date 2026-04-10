using OpenQA.Selenium;

namespace AutomationTestStore.Framework.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://automationteststore.com/index.php?rt=account/login");
        }

        private By username = By.Id("loginFrm_loginname");
        private By password = By.Id("loginFrm_password");
        private By loginBtn = By.XPath("//button[@title='Login']");
        private By errorMsg = By.XPath("//div[contains(@class,'alert-danger')]");

        public void Login(string user, string pass)
        {
            driver.FindElement(username).SendKeys(user);
            driver.FindElement(password).SendKeys(pass);
            driver.FindElement(loginBtn).Click();
        }

        public string GetError()
        {
            return driver.FindElement(errorMsg).Text;
        }
    }
}