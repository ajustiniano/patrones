using Patrones;
using OpenQA.Selenium;
using Patrones.Framework;

namespace TestingProject.Pages
{
  public class ChromePage : BasePage
    {       
        public IWebElement SearchTextBox { get { return driver.FindElement(By.Name("q")); } }

        public ChromePage SearchText(string text) {
            SearchTextBox.SendKeys(text);
            return this;
        }

        public ChromePage GotoURL(string url)
        {
            driver.Navigate().GoToUrl(url);
            return new ChromePage();
        }
    }
}
