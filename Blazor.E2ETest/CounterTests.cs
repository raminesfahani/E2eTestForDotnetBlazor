using Blazor.E2ETest.Pages;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Blazor.E2ETest
{
    public class CounterTests: IDisposable
    {
        private readonly IWebDriver _driver;
        private readonly CounterPage _page;

        public CounterTests()
        {
            _driver = new ChromeDriver();
            _page = new CounterPage(_driver);
            _page.Navigate();

            _driver.GetWait(20000, 500).Until(driver => driver.FindElement(By.XPath("//main")));
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        [Fact]
        public void CounterPage_InInitialRender_CounterShouldBeZero()
        {
            // Act
            var result = _page.GetResultText();

            // Assert
            result.Should().Contain("0");
        }


        [Fact]
        public void CounterPage_OnClickBtn_CounterMustBeOne()
        {
            // Act
            _page.ClickOnClickMeBtn();
            var result = _page.GetResultText();

            // Assert
            result.Should().Contain("1");
        }
    }
}
