using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
    class TextStrategy
    {
        IWebDriver driver;
        public void Search(string searchFor)
        {
            driver.FindElement(By.Id("")).SendKeys(searchFor);
        }
    }
}
