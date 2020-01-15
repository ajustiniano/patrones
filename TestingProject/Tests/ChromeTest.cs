using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patrones;
using TestingProject.Pages;

namespace TestingProject
{
    [TestClass]
    public class ChromeTest :BaseTest
    {
        ChromePage chromePage = new ChromePage();
        [TestMethod]
        public void VerifyCountResult()
        {
            chromePage.GotoURL("http://google.com");
            chromePage= chromePage.SearchText("automation");
            
        }
    }
}
