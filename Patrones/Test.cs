using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Patrones
{
    [TestClass]
    public class Test: Base    {

        public Test()
        {
            Browser = Browsers.chrome;
        }

      
        [TestMethod]
        public void GoogleTitleTest()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            string title = driver.Title;
            Assert.AreEqual(title, "Google");
           

        }

        [TestCleanup]
        public void CleanUp() {
            driver.Quit();
        }
    }
}
