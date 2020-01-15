using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
   public class ChromeManager :  DriverManager
    {
        public override void StartDriver() {
            driver = new ChromeDriver();
        }
    }
}
