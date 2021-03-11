using AventStack.ExtentReports;
using InvestmentManagement.BaseClass;
using InvestmentManagement.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UI_InvestmentMangement.PageObjects;

namespace InvestmentManagement.TestScripts
{
    [TestFixture]
    class DebtSummary : BaseTest
    {
        BaseTest baseTest = new BaseTest();
        [Test, Category("Regression Test")]
        public void CreateNewLoanWithFixedInterest()
        {
            try
            {
                test = extent.CreateTest("CreateNewLoanWithFixedInterest").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                debt.ClickdebtSummary();
                debt.AddLoanWithFixedInterest();
                Thread.Sleep(2000);
                String currentDate = DateTime.Now.ToString("MM/dd/yyyy");
                debt.CLickEditLoanDetails();
                String originationDate = debt.GetNewLoanOriginationdate();
                Assert.IsTrue(originationDate == currentDate, "new loan creation failed");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
                driver.Quit();
            }
        }
        [Test, Category("Regression Test")]
        public void CreateNewLoanWithFloatingInterest()
        {
            try
            {
                test = extent.CreateTest("CreateNewLoanWithFloatingInterest").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                debt.ClickdebtSummary();
                debt.AddLoanWithFloatingInterest();
                Thread.Sleep(2000);
                String currentDate = DateTime.Now.ToString("MM/dd/yyyy");
                debt.CLickEditLoanDetails();
                String originationDate = debt.GetNewLoanOriginationdate();
                Assert.IsTrue(originationDate == currentDate, "new loan creation failed");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Regression Test")]
        [Description("Verify user can add new lender or lender type")]
        public void AddNewLenderAndLenderType()
        {
            try
            {
                test = extent.CreateTest("CreateNewLoanWithFloatingInterest").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.ClickAddLoanButton();
                Thread.Sleep(2000);
                Boolean res = debt.AddNewLenderAndLenderType();
                Assert.IsTrue(res == true, "New lender got created");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Regression Test")]
        [Description("Verify user can add new loan type")]
        public void AddNewLoanType()
        {
            try
            {
                test = extent.CreateTest("CreateNewLoanWithFloatingInterest").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.ClickAddLoanButton();
                Thread.Sleep(2000);
                Boolean res = debt.AddNewLoanType();
                Assert.IsTrue(res == true, "New loan Type gets added");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify Search works for Both Fund A and Fund B")]
        public void DebtSearchWorksForBothTheFunds()
        {
            try
            {
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                test = extent.CreateTest("DebtSearchWorksForBothTheFunds").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                //Verify search works on fund A
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                int countbeforesearchA = debt.RowsBeforeSearch();
                int countaftersearchA = debt.RowsafterSearchForProperty();
                Assert.IsTrue(countbeforesearchA > countaftersearchA, "Search does not work");

                //Verify search works on fund B
                funds.ClickFundBTab();
                driver.Navigate().Refresh();
                Thread.Sleep(3000);
                debt.ClickdebtSummary();
                int countbeforesearchB = debt.RowsBeforeSearch();
                int countaftersearchB = debt.RowsafterSearchForProperty();
                Assert.IsTrue(countbeforesearchB > countaftersearchB, "Search does not work");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify download works on debt summary for both the funds")]
        public void DownLoadDebtSummaryReportsForFunds()
        {
            try
            {
                test = extent.CreateTest("DownLoadDebtSummaryReportsForFunds").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);

                //Verify download works for Fund A
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.DownloadDebtReportForFundA();
                funds.ClickFundBTab();
                Thread.Sleep(3000);
                debt.DownloadDebtReportForFundB();
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify sort by works on debt summary for both the funds")]
        public void Debt_SortByOptionforBothTheFunds()
        {
            try
            {
                test = extent.CreateTest(" Debt_SortByOptionforBothTheFunds").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                //Verify download works for Fund A
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.Debt_ClickOptionsInSortBy();
                Boolean desc = debt.Debt_SelectDescending();
                Assert.True(desc == true, "Descending does not work");
                Thread.Sleep(3000);
                //Verify Ascending works as expected
                Boolean Asc = debt.Debt_SelectAscending();
                Assert.True(Asc == true, "Ascending does not work");
                funds.ClickFundBTab();
                Thread.Sleep(3000);
                debt.Debt_ClickOptionsInSortBy();
                Boolean desc1 = debt.Debt_SelectDescending();
                Assert.True(desc1 == true, "Descending does not work");
                Thread.Sleep(3000);
                //Verify Ascending works as expected
                Boolean Asc1 = debt.Debt_SelectAscending();
                Assert.True(Asc1 == true, "Ascending does not work");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify user can change view to table or card")]
        public void Debt_VerifyChangeViewWorksForFundA_B()
        {
            try
            {
                test = extent.CreateTest("Debt_VerifyChangeViewWorksForFundA_B").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                //Verify user can switch to list view
                Boolean lview = debt.Debt_ChangeToListView();
                Assert.IsTrue(lview == true, "View not changed to list view");

                //Verify switch view works on fund B
                driver.Navigate().Refresh();
                funds.ClickFundBTab();
                debt.ClickdebtSummary();
                Boolean cview = debt.Debt_ChangeToCardView();
                Assert.IsTrue(cview == true, "View not changed to card view");
                funds.ClickFundATab();
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify user navigates to Loan details from debt summary and back to debt summary Fund A")]
        public void Debt_UserNavigatesToLoanAndbackToDebtFundA()
        {
            try
            {
                test = extent.CreateTest("Debt_UserNavigatesToLoanAndbackToDebtFundA").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                String Screentitle = debt.NavigateToLoanDetails();
                Assert.AreEqual("Details", Screentitle, "User is not navigated to loan details");
                String debttab = debt.NavigateBackToDebt();
                Assert.AreEqual("DEBT SUMMARY", debttab, "User is not navigated to debt summary details");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify user navigates to Loan details from debt summary and back to debt summary Fund B")]
        public void Debt_UserNavigatesToLoanAndbackToDebtFundB()
        {
            try
            {
                test = extent.CreateTest("Debt_VerifyChangeViewWorksForFundA_B").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                funds.ClickFundBTab();
                String Screentitle = debt.NavigateToLoanDetails();
                Assert.AreEqual("Details", Screentitle, "User is not navigated to loan details");
                String debttab = debt.NavigateBackToDebt();
                Assert.AreEqual("DEBT SUMMARY", debttab, "User is not navigated to debt summary details");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify card labels displayed on debt summary")]
        public void DebtSummary_VerifyCardLabels()
        {
            try
            {
                test = extent.CreateTest("DebtSummary_VerifyCardLabels").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                funds.ClickDebtSummary();
                String label1 = debt.ReturnCardLabel1();
                String label2 = debt.ReturnCardLabel2();
                String label3 = debt.ReturnCardLabel3();
                String label4 = debt.ReturnCardLabel4();
                String label5 = debt.ReturnCardLabel5();
                String label6 = debt.ReturnCardLabel6();
                Assert.IsTrue(label1 == "Lender Name:", $"Expected:'Lender Name:' does not match Actual:{label1}");
                Assert.IsTrue(label2 == "Lender Type:", $"Expected:'Lender Type:' does not match Actual:{label2}");
                Assert.IsTrue(label3 == "Loan Type:", $"Expected:'Loan Type:' does not match Actual:{label3}");
                Assert.IsTrue(label4 == "Current Maturity:", $"Expected:'Current Maturity:' does not match Actual:{label4}");
                Assert.IsTrue(label5 == "Outstanding Amount:", $"Expected:'Outstanding Amount:' does not match Actual:{label5}");
                Assert.IsTrue(label6 == "Months To Maturity:", $"Expected:'Months To Maturity:' does not match Actual:{label6}");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify column labels displayed on debt summary first four")]
        public void DebtSummary_VerifyListViewColumnLabels_FirstFour()
        {
            try
            {
                test = extent.CreateTest("DebtSummary_VerifyListViewColumnLabels_FirstFour").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                funds.ClickDebtSummary();
                debt.Debt_ChangeToListView();
                String label1 = navigation.ReturnListViewColumnLabel1();
                String label2 = navigation.ReturnListViewColumnLabel2();
                String label3 = navigation.ReturnListViewColumnLabel3();
                String label4 = navigation.ReturnListViewColumnLabel4();
                Assert.IsTrue(label1 == "Property Name", $"Expected:'Property Name' does not match Actual:{label1}");
                Assert.IsTrue(label2 == "Date Of Loan", $"Expected:'Date Of Loan' does not match Actual:{label2}");
                Assert.IsTrue(label3 == "Lender", $"Expected:'Lender' does not match Actual:{label3}");
                Assert.IsTrue(label4 == "Current Maturity", $"Expected:'Current Maturity' does not match Actual:{label4}");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify column labels displayed on debt summary")]
        public void DebtSummary_VerifyListViewColumnLabels_LastFive()
        {
            try
            {
                test = extent.CreateTest("DebtSummary_VerifyListViewColumnLabels_LastFive").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                funds.ClickDebtSummary();
                debt.Debt_ChangeToListView();
                String label5 = navigation.ReturnListViewColumnLabel5();
                String label6 = navigation.ReturnListViewColumnLabel6();
                String label7 = navigation.ReturnListViewColumnLabel7();
                String label8 = navigation.ReturnListViewColumnLabel8();
                String label9 = navigation.ReturnListViewColumnLabel9();
                Assert.IsTrue(label5 == "Current Debt", $"Expected:'Current Debt' does not match Actual:{label5}");
                Assert.IsTrue(label6 == "Total Loan", $"Expected:'Total Loan' does not match Actual:{label6}");
                Assert.IsTrue(label7 == "Interest Rate", $"Expected:'Interest Rate' does not match Actual:{label7}");
                Assert.IsTrue(label8 == "Outstanding", $"Expected:'Outstanding' does not match Actual:{label8}");
                Assert.IsTrue(label9 == "Months To", $"Expected:'Outstanding Amount:' does not match Actual:{label9}");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify new loan displays on debt summary screen")]
        public void DebtSummary_VerifyNewLoanDisplayedOnDebtSummary()
        {
            try
            {
                test = extent.CreateTest("DebtSummary_VerifyNewLoanDisplayedOnDebtSummary").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                Thread.Sleep(3000);
                funds.ClickDebtSummary();
                int numOfCardsBefore = debt.NumberOfCardsPresent();
                debt.AddLoanWithFixedInterest();
                debt.NavigateBackToDebt();
                driver.Navigate().Refresh();
                funds.ClickDebtSummary();
                int numOfCardsAfter = debt.NumberOfCardsPresent();
                Assert.IsTrue(numOfCardsBefore + 1 == numOfCardsAfter, "New loan created does not reflect on debt summary");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Regression Test")]
        [Description("All dropdown fields are mandatory in add loan details")]
        public void AddLoan_VerifyAddLoanAllDropdownFieldsAreMandatory()
        {
            try
            {
                test = extent.CreateTest("AddLoan_VerifyAddLoanAllDropdownFieldsAreMandatory").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                Thread.Sleep(3000);
                funds.ClickDebtSummary();
                debt.AddLoan_LenderNameIsMandatory();
                String alert1 = debt.CaptureAlertMessage();
                Assert.IsTrue(alert1 == "All Fields are mandatory", "Loan can be addedd without lender details");

                debt.AddLoan_PropertyNameIsMandatory();
                String alert2 = debt.CaptureAlertMessage();
                Assert.IsTrue(alert2 == "All Fields are mandatory", "Loan can be addedd without property name details");

                debt.AddLoan_LoanTypeIsMandatory();
                String alert3 = debt.CaptureAlertMessage();
                Assert.IsTrue(alert3 == "All Fields are mandatory","Loan can be addedd without loan type details" );
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Regression Test")]
        [Description("All fields are mandatory in add loan details")]
        public void AddLoan_VerifyAddLoanAllFieldsAreMandatory()
        {
            try
            {
                test = extent.CreateTest("AddLoan_VerifyAddLoanAllFieldsAreMandatory").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                Thread.Sleep(3000);
                funds.ClickDebtSummary();
                debt.AddLoan_TotalLoanCommitmentIsMandatory();
                String alert1 = debt.CaptureAlertMessage();
                Assert.IsTrue(alert1 == "All Fields are mandatory", "Loan can be addedd without commitment details");

                debt.AddLoan_OriginationDateIsMandatory();
                String alert2 = debt.CaptureAlertMessage();
                Assert.IsTrue(alert2 == "All Fields are mandatory", "Loan can be addedd without origination date details");

                debt.AddLoan_InitialMaturityIsMandatory();
                String alert3 = debt.CaptureAlertMessage();
                Assert.IsTrue(alert3 == "All Fields are mandatory", "Loan can be addedd without Initial Maturity details");

                debt.AddLoan_InterestRateTypeIsMandatory();
                String alert4 = debt.CaptureAlertMessage();
                Assert.IsTrue(alert4 == "All Fields are mandatory", "Loan can be addedd without interest rate details");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Regression Test")]
        public void VerifyCurrentMonthsTomaturityFieldLogic()
        {
            try
            {
                test = extent.CreateTest("VerifyCurrentMonthsTomaturityFieldLogic").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickLoanMaintenanceOption();
                debt.AddLoanWithFixedInterest();
                debt.NavigateBackToDebt();
                debt.ReturnCurrentMaturityOflatestLoan();
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
