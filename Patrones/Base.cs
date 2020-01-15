using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
   public  class Base
    {
        public Browsers Browser { get; set; }       
        public IWebDriver driver;
        
        public Base()
        {
            
            if (Browser == Browsers.chrome)
            {
                driver = new ChromeDriver();
              
            }
            else if (Browser == Browsers.firefox)
            {

            }
        }

        public Base(Browsers browser) {
            this.Browser = browser;
        }

           
    }
}
