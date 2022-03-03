using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //   ChromeDriver driver = new ChromeDriver();

            IWebDriver driver = new ChromeDriver(@"C:\Tools\chromedriver98");
            driver.Url = "https://d18u5zoaatmpxx.cloudfront.net/#/";

            IWebElement inputBox = driver.FindElement(By.Id("forename"));
            IWebElement submitBtn = driver.FindElement(By.Id("submit"));
            IWebElement popup = driver.FindElement(By.ClassName("mr-auto"));
            
            inputBox.Clear();
            inputBox.SendKeys("Harsh");
            submitBtn.Click();
            //Assert.AreEqual(popup.Text, "Hello Harsh");


            //var element = driver.FindElements(By.TagName("h1"));
            //     IWebElement headerelement = null;
            // foreach (var item in element)
            //  {
            //   if (item.Text == "web development") {
            //       headerelement = item;
            //        break;
            //  }
            //   }
            //  Assert.IsTrue(headerelement.Displayed);
            // }


            //}
        }
    }
}
