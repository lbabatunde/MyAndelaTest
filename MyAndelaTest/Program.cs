using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAndelaTest
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://qa.my.andela.com/login");
            IWebElement EmailAddress = driver.FindElement(By.Id("okta-signin-username"));
            EmailAddress.SendKeys("test-engineer@andela.com");
            IWebElement PassWord = driver.FindElement(By.Id("okta-signin-password"));
            PassWord.SendKeys("Wonder_123");
            driver.FindElement(By.Id("okta-signin-submit")).Click();
            // Click on add skills 
            driver.FindElement(By.XPath("/html/body/app-root/div/mat-sidenav-container/mat-sidenav-content/app-resume/app-tabs/app-engineer-about/div/app-skills-and-tools/section/div[1]/span/app-button[2]/button")).Click();
            IWebElement SkillName = driver.FindElement(By.Id("skillname"));
            SkillName.SendKeys("Oracle Database");
            IWebElement ProficiencyLevel = driver.FindElement(By.Id("mat-select-value"));
            ProficiencyLevel.SendKeys("Beginner");
            IWebElement Experience = driver.FindElement(By.Id("years-label"));
            Experience.SendKeys("2");
            driver.FindElement(By.Id("mat-button-wrapper")).Click();
            Assert.IsTrue(driver.PageSource.Contains("Oracle database"));


        }
    }
}
