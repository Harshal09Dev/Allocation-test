
using InvestmentManagement.BaseClass;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UI_InvestmentMangement.TestScripts;
namespace UI_InvestmentMangement.PageObjects
{
    class AboutUsPage
    {



        private IWebDriver driver;
        public AboutUsPage(IWebDriver driver)
        {
            if (driver != null)
            {
                this.driver = driver;
            }
            else
            {
                Console.WriteLine("driver is null");
            }
        }

        //about us xpath 
        By aboutUs = By.XPath("//span[@class='header']");
        By DowloadUserManual = By.XPath("//span[@class='badge download']");
        By PortSummaryHome = By.XPath("//span[contains(text(),'Portfolio Summary')]");
        By HomeIcon = By.XPath("//div[@class='app-icon-container']");
        By VersionValueL = By.XPath("//*[@id='root']/div/div[3]/div/div[5]/div[2]/div/div[1]/div[2]/div[1]/div/div[1]/span");
        By VersionValues = By.XPath("//span[contains(text(),'5.0')]");

        public string checkAbouUs()
        {
            string AboutText = driver.FindElement(aboutUs).Text;
            return AboutText;

        }
        public bool IsElementPresent()
        {
            try
            {
                driver.FindElement(DowloadUserManual);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool checkHomePageNavigation()
        {
            driver.FindElement(HomeIcon).Click();
            Thread.Sleep(4000);
            try
            {
                driver.FindElement(PortSummaryHome);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }
        public bool VersionSequence()
        {
            string num1 = driver.FindElement(VersionValueL).Text;
            String DOTRemove1 = num1.Replace(".", String.Empty);
            int value1 = int.Parse(DOTRemove1);
            Console.WriteLine(value1);

            string num2 = driver.FindElement(VersionValues).Text;
            String DOTRemove2 = num2.Replace(".", String.Empty);
            int value2 = int.Parse(DOTRemove2);
            Console.WriteLine(value2);


            if (value1 > value2)
            {
                return true;
            }
            else
            {
                return false;

            }

        }

        public bool DownloadUserManual()
        {
            bool res = IsElementPresent();
            if (res == true)
            {
                driver.FindElement(DowloadUserManual).Click();
                return true;
            }
            else

            {
                return false;
            }



        }

        public void DownloadedFileCheck()
        {
            Thread.Sleep(9000);
            driver.FindElement(DowloadUserManual).Click();
            Thread.Sleep(9000);
            bool fileexsit = false;
            string ExpectedFile = @"C:\Users\GS-1638\Downloads\Investment Management User Manual 6.0.pdf";
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", @"C:\Users\GS-1638\Downloads");
            try
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
                wait.Until<bool>(x => fileexsit = File.Exists(ExpectedFile));

                FileInfo FileINFORMATION = new FileInfo(ExpectedFile);
                //



                Assert.AreEqual(FileINFORMATION.Name, "Investment Management User Manual 6.0.pdf");
                Assert.AreEqual(FileINFORMATION.FullName, ExpectedFile);
                Console.WriteLine(FileINFORMATION.FullName);
                Console.WriteLine(ExpectedFile);
                Console.WriteLine("File checked");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {

                if (File.Exists(ExpectedFile))
                {
                    File.Delete(ExpectedFile);
                    Thread.Sleep(5000);

                }
            }

        }

    }
}
