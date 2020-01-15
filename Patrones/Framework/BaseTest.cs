using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Patrones.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{   
    public class BaseTest
    {
        private DriverManager driverManager;
        private  IWebDriver driver;
        static BasePage basePage;
      
        [TestInitialize]
        public void Init()
        {
            driverManager = DriverManagerFactory.GetManager(Browsers.chrome);
            driver = driverManager.GetDriver();
            basePage = new BasePage();
            basePage.SetDriver(driver);
        }
       
        [TestCleanup]
        public void TestCleanUp() {
            driverManager.StopDriver();
        }
    }
}
