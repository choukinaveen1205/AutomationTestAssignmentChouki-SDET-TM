using OpenQA.Selenium;
using System;

namespace AutomationTestStore.Framework.Pages
{
    public class RegistrationPage
    {
        private IWebDriver driver;

        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://automationteststore.com/index.php?rt=account/create");
        }

        private By firstName = By.Id("AccountFrm_firstname");
        private By email = By.Id("AccountFrm_email");
        private By password = By.Id("AccountFrm_password");
        private By submit = By.XPath("//button[@title='Continue']");
        private By error = By.XPath("//div[contains(@class,'alert-danger')]");

        public void FillForm()
        {
            driver.FindElement(firstName).SendKeys("John");
            driver.FindElement(email).SendKeys("test" + DateTime.Now.Ticks + "@mail.com");
            driver.FindElement(password).SendKeys("Password123");
        }

        public void Submit()
        {
            driver.FindElement(submit).Click();
        }

        public string GetError()
        {
            return driver.FindElement(error).Text;
        }
    }
}