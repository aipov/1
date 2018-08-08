using System;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [TestMethod]
        public void TestMethod1()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://site2017.ingos.ru/travel/abroad/calc/");
            driver.Manage().Window.FullScreen();
            driver.FindElement(By.XPath("//span[@class='multiselect__empty ng-scope']")).Click();
            driver.Quit();
        }

    }
}