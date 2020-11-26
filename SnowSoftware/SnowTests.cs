using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SnowSoftware.Driver;
using SnowSoftware.PageObjectModels;

namespace SnowSoftware
{
    [AllureNUnit]
    public class Tests
    {

        private SitePage site;
        private Menu menu;
        private SnowGlobe snowGlobe;
        private ReleaseNotes releaseNotes;

        [SetUp]
        public void Setup()
        {
            WebDriver.CreateDriver();
            site = new SitePage();
            menu = new Menu();
            snowGlobe = new SnowGlobe();
            releaseNotes = new ReleaseNotes();

        }

        [AllureTag("Smoke")]
        [Test(Description = "Check Exist 'Snow License Manager 9.7.1 Release Note'")]
        [System.Obsolete]
        public void CheckReleaseNotes()
        {
            site.NavigateToTheSite("https://www.snowsoftware.com");
            menu.ClickOnSuccessMenu();
            snowGlobe.InputSearchField("Snow License Manager")
                     .ClickReleaseNotes();

            Assert.AreEqual(releaseNotes.getTitleText(), "Release Notes: Snow License Manager 9.7.1");
            Assert.AreEqual(releaseNotes.getArticleNumber(), "000013119");
        }


        [TearDown]
        public void After()
        {
            WebDriver.QuitDriver();
        }
    }
}