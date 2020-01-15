using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
  public abstract class DriverManager
    {
        public IWebDriver driver;
        public abstract void StartDriver();
        public void StopDriver()
        {
            driver.Quit();
        }
        public IWebDriver GetDriver() {
            StartDriver();
            return driver;
        }

    }
}
