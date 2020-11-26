using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SnowSoftware.Driver
{
    public static class WebDriver
    {
        private static IWebDriver driver;

        public static void CreateDriver()
        {
            driver = new ChromeDriver("/Users/paveldovgan/Desktop/SnowSoftware/SnowSoftware/resources");
          
        }

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                throw new SystemException("WebDriver has not been initialised!");
            }
            return driver;
        }

        public static void QuitDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }

}
