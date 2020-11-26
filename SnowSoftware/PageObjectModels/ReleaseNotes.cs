using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SnowSoftware.Driver;

namespace SnowSoftware.PageObjectModels
{
    public class ReleaseNotes
    {

        private IWebDriver driver;
        private WebDriverWait wait;

        private By releaseNotesLabel = By.XPath("//div[contains(@class,'header__title')]/span");
        private By articleNumber = By.XPath("//li[@role='listitem'][1]//span[@data-aura-class='uiOutputText']");

        public ReleaseNotes()
        {
            driver = WebDriver.GetDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }

        [Obsolete]
        public String getTitleText()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(releaseNotesLabel));
            return driver.FindElement(releaseNotesLabel).Text;
        }

        [Obsolete]
        public String getArticleNumber()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(releaseNotesLabel));
            return driver.FindElement(articleNumber).Text;
        }
    }
}
