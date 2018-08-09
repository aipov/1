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
                        driver.Navigate().GoToUrl("https://www.google.com/");
                        driver.Manage().Window.Maximize();
                        driver.FindElement(By.Name("q")).SendKeys("webdriver");
                        driver.FindElement(By.XPath("//input[@value='Поиск в Google']")).Click();
                       // driver.Quit();
        }

    }
}