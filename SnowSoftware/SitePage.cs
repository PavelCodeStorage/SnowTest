using System;
using OpenQA.Selenium;
using SnowSoftware.Driver;

namespace SnowSoftware
{
    class SitePage
    {
        private IWebDriver driver;

        public SitePage()
        {
            driver = WebDriver.GetDriver();
        }

        // Method open specific site (Depends on URL)
        public void NavigateToTheSite(String url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }
    }
}
