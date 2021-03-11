using InvestmentManagement.BaseClass;
using InvestmentManagement.PageObjects;
using NUnit.Framework;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_InvestmentMangement.PageObjects;
using AventStack.ExtentReports.Model;
using TestAttribute = NUnit.Framework.TestAttribute;

namespace UI_InvestmentMangement.TestScripts
{
    [TestFixture]
    class AboutUs : BaseTest
    {

        BaseTest baseTest = new BaseTest();

        [Test, Category("Sanity Test")]
        public void VerifytheUserManualDownload()
        {
            try
            {
                test = extent.CreateTest("VerifytheUserManualDownload").Info("Test Started");
                AboutUsPage AbtUs = new AboutUsPage(BaseTest.driver);
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickOnAboutUs();
                bool res = AbtUs.DownloadUserManual();
                Assert.IsTrue(res == true, "Download Failed");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }


        [Test, Category("Sanity Test")]
        public void VerifyNavigationToHomePage()
        {
            try
            {
                test = extent.CreateTest("VerifyNavigationToHomePage").Info("Test Started");
                AboutUsPage AbtUs = new AboutUsPage(BaseTest.driver);
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickOnAboutUs();
                bool res = AbtUs.checkHomePageNavigation();
                Assert.IsTrue(res == true, "Failed to navigate to Home ");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }

        [Test, Category("Sanity Test")]
        [Description("Verify version sequence in the tabel")]
        public void VerifytheVersionSequence()
        {
            try
            {
                test = extent.CreateTest("VerifytheVersionSequence").Info("Test Started");
                AboutUsPage AbtUs = new AboutUsPage(BaseTest.driver);
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickOnAboutUs();
                bool res = AbtUs.VersionSequence();
                Assert.IsTrue(res == true, "Sequence is Failed ");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }



    }
}
