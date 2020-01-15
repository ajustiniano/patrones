using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones
{
  public  class DriverManagerFactory
    {
        public static DriverManager GetManager(Browsers browser) {
            DriverManager drivermanager;
            switch (browser) {
                case Browsers.chrome:
                    drivermanager = new ChromeManager();
                    break;
                default:
                    drivermanager = null;
                    break;
            }
            return drivermanager;

        }
    }
}
