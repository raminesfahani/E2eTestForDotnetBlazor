using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.E2ETest
{
    public static class Helper
    {
        public static WebDriverWait GetWait(this IWebDriver webDriver, int timeoutMilliseconds = 2000, int intervalMilliseconds = 500, params Type[] exceptionTypes)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(timeoutMilliseconds))
            {
                PollingInterval = TimeSpan.FromMilliseconds(intervalMilliseconds)
            };
            wait.IgnoreExceptionTypes(exceptionTypes);
            return wait;
        }
    }
}
