using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_Pagefactory_Training.TestCases
{
    class LoginTest
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.store.demoqa.com";

            // Click on search box 
            driver.FindElement(By.XPath("//a[@class='noo-search']")).Click();
            //input[@name='s']

            //enter search term dress into search box
            driver.FindElement(By.XPath("//input[@name='s']")).SendKeys("dress");

            //Press enter
            driver.FindElement(By.XPath("//input[@name='s']")).SendKeys(Keys.Return);

            //Click on favourite on one dress - need to hover and click
            //driver.FindElement(By.Id("1473")).Click();


            // Close the driver
            //driver.Quit();

        }
    }
}
