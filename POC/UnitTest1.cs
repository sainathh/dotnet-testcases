using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace POC
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            String path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;// Path.GetDirectoryName(Directory.GetCurrentDirectory());
            IWebDriver driver = new ChromeDriver(path+"\\POC\\Drivers\\");
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
    }
}
