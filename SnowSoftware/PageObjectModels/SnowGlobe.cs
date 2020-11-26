using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SnowSoftware.Driver;

namespace SnowSoftware.PageObjectModels
{
    public class SnowGlobe
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        private By SearchInput = By.XPath("//input[@placeholder='How can we help?']");
        private By ReleaseNotes = By.XPath("//li[contains(@class,'all suggestion')][6]");

        public SnowGlobe()
        {
            driver = WebDriver.GetDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        [Obsolete]
        public SnowGlobe InputSearchField(String text)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(SearchInput));
            driver.FindElement(SearchInput).SendKeys(text);
            return this;
        }

        [Obsolete]
        public SnowGlobe ClickReleaseNotes()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(ReleaseNotes));
            driver.FindElement(ReleaseNotes).Click();
            return this;
        }
    }
}
