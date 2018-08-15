using System;
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
            driver.Navigate().GoToUrl("http://localhost/litecart/admin/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//input[@name='username']")).SendKeys("admin");
            driver.FindElement(By.CssSelector("[name='password']")).SendKeys("admin");
            //альтернативные варианты
            //driver.FindElement(By.Name("password")).SendKeys("admin");
            //driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("admin");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.FindElement(By.XPath("//*[@title='My Store']"));
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=appearance&doc=template']")).Click();
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=appearance&doc=logotype']")).Click();
            driver.FindElement(By.XPath("//span[contains(text(),'Catalog')]")).Click();
            driver.FindElement(By.XPath("//h1[contains(text(),'Catalog')]"));
            driver.FindElement(By.Id("doc-product_groups")).Click();
            driver.Title.Equals("Product Groups   | My Store");
            //driver.FindElement(By.CssSelector("#doc-option_groups")).Click();
            //driver.FindElement(By.CssSelector(".languages")).Click();
            //альтернативный вариант
            driver.FindElement(By.ClassName("languages")).Click();
            driver.FindElement(By.Id("doc-option_groups")).Click();
            driver.FindElement(By.Id("doc-manufacturers")).Click();
            driver.FindElement(By.Id("doc-suppliers")).Click();
            driver.FindElement(By.Id("doc-delivery_statuses")).Click();
            //driver.FindElement(By.XPath("//*[contains(@title,'Delivery Statuses | My Store')]"));
            driver.FindElement(By.Id("doc-sold_out_statuses")).Click();
            driver.FindElement(By.XPath("//li[@id='doc-sold_out_statuses']")).Click();
            driver.FindElement(By.XPath("//li[contains(@id,'quantity_units')]")).Click();
            driver.FindElement(By.Id("doc-csv")).Click();
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=countries&doc=countries']")).Click();
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=currencies&doc=currencies']")).Click();
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=customers&doc=customers']")).Click();
            driver.FindElement(By.Id("doc-csv")).Click();
            driver.FindElement(By.Id("doc-newsletter")).Click();
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=geo_zones&doc=geo_zones']")).Click();
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=languages&doc=languages']")).Click();
            driver.FindElement(By.Id("doc-storage_encoding")).Click();
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=modules&doc=jobs']")).Click();
            driver.FindElement(By.XPath("//h1[contains(text(),' Job Modules')]"));
            driver.FindElement(By.Id("doc-customer")).Click();
            driver.FindElement(By.Id("doc-shipping")).Click();
            driver.FindElement(By.Id("doc-payment")).Click();
            driver.FindElement(By.Id("doc-order_total")).Click();
            driver.FindElement(By.Id("doc-order_success")).Click();
            driver.FindElement(By.Id("doc-order_action")).Click();
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=orders&doc=orders']")).Click();
            driver.FindElement(By.XPath("//h1[contains(text(),'Orders')]"));
            driver.FindElement(By.Id("doc-order_statuses")).Click();
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=pages&doc=pages']")).Click();
            driver.FindElement(By.XPath("//h1[contains(text(),'Pages')]"));
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=reports&doc=monthly_sales']")).Click();
            driver.FindElement(By.XPath("//li[@id='doc-most_sold_products']")).Click();
            driver.FindElement(By.Id("doc-most_shopping_customers")).Click();
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=settings&doc=store_info']")).Click();
            driver.FindElement(By.XPath("//h1[contains(text(),'Settings')]"));
            driver.FindElement(By.Id("doc-defaults")).Click();
            driver.FindElement(By.Id("doc-general")).Click();
            driver.FindElement(By.Id("doc-listings")).Click();
            driver.FindElement(By.Id("doc-images")).Click();
            driver.FindElement(By.Id("doc-checkout")).Click();
            driver.FindElement(By.Id("doc-advanced")).Click();
            driver.FindElement(By.Id("doc-security")).Click();
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=slides&doc=slides']")).Click();
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=tax&doc=tax_classes']")).Click();
            driver.FindElement(By.Id("doc-tax_rates")).Click();
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=translations&doc=search']")).Click();
            driver.FindElement(By.Id("doc-scan")).Click();
            driver.FindElement(By.Id("doc-csv")).Click();
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=users&doc=users']")).Click();
            driver.FindElement(By.XPath("//a[@href='http://localhost/litecart/admin/?app=vqmods&doc=vqmods']")).Click();
            driver.FindElement(By.XPath("//h1[contains(text(),'Qmods')]"));
            driver.Quit();
        }

    }
}