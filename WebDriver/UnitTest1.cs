using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebDriver
{
    [TestClass]
    public class WikipediaSearchTest
    {
        [TestMethod]
        public void Search_FindResults_ResultsIsShown()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl("http://en.wikipedia.org/wiki/Main_Page");
         IWebElement searchInput = driver.FindElement(By.Id("searchInput"));
            searchInput.SendKeys("Christiaan Barnard");
            
        }
    }
}
