using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones.Framework
{
   public class BasePage
    {
        public static  IWebDriver driver;
        public   void SetDriver(IWebDriver driver) {
            BasePage.driver = driver;
        }

    }
}
