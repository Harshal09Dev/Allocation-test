using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using UI_InvestmentMangement;

namespace InvestmentManagement.BaseClass
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public ExtentTest test = null;
        public ExtentReports extent = new ExtentReports();

        [OneTimeSetUp]
        public void extentStart()
        {

            string reportPath = TestSettings.Default.ReportFilePath + "\\" + DateTime.Now.ToString("ddMMyyyy") + "\\Report";
            if (!Directory.Exists(reportPath))
            {
                Directory.CreateDirectory(reportPath);
            }
            reportPath += "\\report.html";
            var htmlReporter = new ExtentV3HtmlReporter(reportPath);
            extent.AttachReporter(htmlReporter);
        }
        [SetUp]
        //[TestCaseSource("DataDrivenTesting")]
        public static void Open()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");
            options.AddArgument("start-maximized");
            // options.AddArgument("--headless");
            options.AddArgument("no-sandbox");
            options.AddArgument("--user-agent=Chrome/77");

            driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(5));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = TestSettings.Default.WebURL;
            Thread.Sleep(2000);
            if (driver.Url.StartsWith("https://login"))
            {
                login();
            }
        }
        private static void login()
        {
            By loginTextBoxX = By.XPath("//*[@id=\"i0116\"]");
            By loginNextBtnX = By.XPath("//*[@id=\"idSIButton9\"]");
            By passWordTextBoxX = By.XPath("//input[@id='i0118']"); // By.XPath("/html/body/div/form[1]/div/div/div[1]/div[2]/div[2]/div/div[2]/div/div[2]/div/div[2]/input");// By.XPath("//*[@id=\"i0118\"]");
            By signinBtnX = By.XPath("//*[@id=\"idSIButton9\"]");
            By popUpNoBtnX = By.XPath("//*[@id=\"idBtn_Back\"]");

            var loginTextBox = driver.FindElement(loginTextBoxX);
            loginTextBox.Clear();
            loginTextBox.SendKeys(TestSettings.Default.LoginUserId);

            var loginNextBtn = driver.FindElement(loginNextBtnX);
            loginNextBtn.Click();

            //var passWordTextBox = driver.FindElement(passWordTextBoxX);
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(passWordTextBoxX));
            var elementToClick = driver.FindElement(passWordTextBoxX);
            //Actions action = new Actions(driver);
            //action.Click(elementToClick).Build().Perform();
            Thread.Sleep(2000);
            elementToClick.SendKeys(TestSettings.Default.LoginPassword);

            var signinBtn = driver.FindElement(signinBtnX);
            signinBtn.Click();
            Thread.Sleep(5);
        }
        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
        [OneTimeTearDown]
        public void CloseReport()
        {
            extent.Flush();
        }
        //static IList DataDrivenTesting()
        //{
        //    ArrayList urlList = new ArrayList();
        //    urlList.Add("https://testim.streamrealty.com");
        //    urlList.Add("https://devim.streamrealty.com");
        //    urlList.Add("https://stgaeim.streamrealty.com");
        //    return urlList;
        //}
        public void TakeScreenshot()
        {
            try
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                //screenshot.SaveAsFile(DateTime.Now.ToShortDateString()+".png", ScreenshotImageFormat.Png);
                string screenShotPath = TestSettings.Default.ReportFilePath + "\\" + DateTime.Now.ToString("ddMMyyyy") + "\\Screenshot";
                if (!Directory.Exists(screenShotPath))
                {
                    Directory.CreateDirectory(screenShotPath);
                }
                screenShotPath += "\\" + DateTime.Now.ToString("yyyyMMMdd_hh.mm.ss.fff") + ".png";

                // string filename = string.Format("C:\\Users\\shilpa.shinde\\source\\repos\\UI_InvestmentMangement\\Screenshots\\{0}.png", DateTime.Now.ToString("yyyyMMMdd_hh.mm.ss.fff"));
                screenshot.SaveAsFile(screenShotPath, ScreenshotImageFormat.Png);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}