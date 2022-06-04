using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.E2ETest.Pages
{
    public class CounterPage
    {
        private readonly IWebDriver _driver;
        private const string Uri = "https://localhost:7191/counter";
        private IWebElement _clickMeBtnElement => _driver.FindElement(By.XPath("//button[text()= 'Click me']"));
        private IWebElement _resultElement => _driver.FindElement(By.XPath("//p[@role= 'status']"));

        public CounterPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Navigate() => _driver.Navigate().GoToUrl(Uri);

        public void ClickOnClickMeBtn() => _clickMeBtnElement.Click();
        public string GetResultText() => _resultElement.Text;
    }
}
