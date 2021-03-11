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

namespace UI_InvestmentMangement.TestScripts
{
    [TestFixture]
    class Asset_OperatingSummaryAndMaps : BaseTest
    {
        BaseTest baseTest = new BaseTest();
        [Test, Category("Sanity Test")]
        [Description("Verify user navigates to map of the property")]
        public void Maps_VerifyUserOpensMapOfTheProperty()
        {
            try
            {
                test = extent.CreateTest("Maps_VerifyUserOpensMapOfTheProperty").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                Asset_OperatingSummaryAndMapsPage operating = new Asset_OperatingSummaryAndMapsPage(BaseTest.driver);
                operating.clickMapsTab();
                String propSelected = operating.ReturnCurrentPropertySelected();
                String propnameonMaps = operating.VerifyPropertyNameOnMapScreen();
                Assert.IsTrue(propSelected == propnameonMaps, "User does not navigate to maps");
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
        [Description("Verify selected property names and name on maps match")]
        public void Maps_VerifyUserCanSeePropertyNamesonMapPopUp()
        {
            try
            {
                test = extent.CreateTest("Maps_VerifyUserOpensMapOfTheProperty").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                Asset_OperatingSummaryAndMapsPage operating = new Asset_OperatingSummaryAndMapsPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                assetdetails.selectPropertyWithIndustrialType();
                operating.clickMapsTab();
                String propSelected = operating.ReturnCurrentPropertySelected();
                String propnameonMaps = operating.VerifyPropertyNameOnMapScreen();
                Assert.IsTrue(propSelected == propnameonMaps, "User does not navigate to maps");
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
        [Description("Verify user can click View property in google map")]
        public void Maps_OpenPropertyAddressInGoogleMap()
        {
            try
            {
                test = extent.CreateTest("Maps_OpenPropertyAddressInGoogleMap").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_OperatingSummaryAndMapsPage operating = new Asset_OperatingSummaryAndMapsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                operating.clickMapsTab();
                Boolean res = operating.NavigateToViewInGoogleMaps();
                Assert.IsTrue(res == true, "Google map links does not open in new tab");
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
        [Description("Verify labels for each field in KPI section")]
        public void KPI_VerifyFieldLabels()
        {
            try
            {
                test = extent.CreateTest("KPI_VerifyFieldLabels").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_OperatingSummaryAndMapsPage operating = new Asset_OperatingSummaryAndMapsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                operating.ClickOperatingSummarytab();
                String occupancy = operating.KPI_VerifyLabelOccupancy();
                String InPlaceRent = operating.KPI_VerifyLabelinPlaceRent();
                String Yoc = operating.KPI_VerifyLabelYOC();
                String CashOnCash = operating.KPI_VerifyLabelCashOnCash();
                String DebtYeild = operating.KPI_VerifyLabelDebtYield();
                String dscr = operating.KPI_VerifyLabelDSCR();
                Assert.IsTrue(occupancy == "Occupancy", $"Expected:'Occupancy' does not match actual {occupancy}");
                Assert.IsTrue(InPlaceRent == "In Place Avg Rent", $"Expected:'In Place Avg Rent' does not match actual {InPlaceRent}");
                Assert.IsTrue(Yoc == "YOC", $"Expected:'YOC' does not match actual {Yoc}");
                Assert.IsTrue(CashOnCash == "Cash on Cash Yield", $"Expected:'Cash on Cash Yield' does not match actual {CashOnCash}");
                Assert.IsTrue(DebtYeild == "Debt Yield", $"Expected:'Debt Yield' does not match actual {DebtYeild}");
                Assert.IsTrue(dscr == "DSCR", $"Expected:'DSCR' does not match actual {dscr}");
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
        [Description("Verify labels for column header in KPI section")]
        public void KPI_VerifyColumnHeaderLabels()
        {
            try
            {
                test = extent.CreateTest("KPI_VerifyColumnHeaderLabels").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_OperatingSummaryAndMapsPage operating = new Asset_OperatingSummaryAndMapsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                operating.ClickOperatingSummarytab();
                String actual = operating.KPI_VerifyColumnLabelActual();
                String budget = operating.KPI_VerifyColumnLabelBudget();
                String Proforma = operating.KPI_VerifyColumnLabelProforma();
                Assert.IsTrue(actual == "YTD Actual", $"Expected:'YTD Actual' does not match actual {actual}");
                Assert.IsTrue(budget == "YTD Budget", $"Expected:'YTD Budget' does not match actual {budget}");
                Assert.IsTrue(Proforma == "YTD Proforma", $"Expected:'YTD Proforma' does not match actual {Proforma}");
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
        [Description("Verify calculation for occupancy rate")]
        public void KPI_VerifyCalculationForOccupancy()
        {
            try
            {
                test = extent.CreateTest("KPI_VerifyColumnHeaderLabels").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_OperatingSummaryAndMapsPage operating = new Asset_OperatingSummaryAndMapsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                int expected = operating.ReturnLeasedPercentValue();
                operating.ClickOperatingSummarytab();
                int actual = operating.ReturnOccupancyValue();
                Assert.IsTrue(expected == actual, $"Leased percent:{expected} does not match occupancy in KPI:{actual}");
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
        [Description("Verify correct labels are displayed when Monthly is selected")]
        public void OperatingSummary_VerifyMonthlyIsSelected()
        {
            try
            {
                test = extent.CreateTest("OperatingSummary_VerifyMonthlyIsSelected").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_OperatingSummaryAndMapsPage operating = new Asset_OperatingSummaryAndMapsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                operating.ClickOperatingSummarytab();
                String label1 = operating.OperatingSummary_ReturnColumnLablel1();
                String label2 = operating.OperatingSummary_ReturnColumnLablel2();
                String label3 = operating.OperatingSummary_ReturnColumnLablel3();
                Assert.IsTrue(label1 == "MTD Actual" && label2 == "MTD Budget" && label3 == "MTD Proforma", $"Operating summary label{label1} does not macth with actual");
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
        [Description("Verify correct labels are displayed when YTD is selected")]
        public void OperatingSummary_VerifyYTDIsSelected()
        {
            try
            {
                test = extent.CreateTest("OperatingSummary_VerifyYTDIsSelected").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_OperatingSummaryAndMapsPage operating = new Asset_OperatingSummaryAndMapsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                operating.ClickOperatingSummarytab();
                operating.RadioButton_SelectYTD();
                String label1 = operating.OperatingSummary_ReturnColumnLablel1();
                String label2 = operating.OperatingSummary_ReturnColumnLablel2();
                String label3 = operating.OperatingSummary_ReturnColumnLablel3();
                Assert.IsTrue(label1 == "YTD Actual" && label2 == "YTD Budget" && label3 == "YTD Proforma", $"Operating summary label{label1} does not macth with actual");
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
        [Description("Verify correct labels are displayed when yearly is selected")]
        public void OperatingSummary_VerifyYearlyIsSelected()
        {
            try
            {
                test = extent.CreateTest("OperatingSummary_VerifyYearlyIsSelected").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_OperatingSummaryAndMapsPage operating = new Asset_OperatingSummaryAndMapsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                operating.ClickOperatingSummarytab();
                operating.RadioButton_SelectYearly();
                String label1 = operating.OperatingSummary_ReturnColumnLablel1();
                String label2 = operating.OperatingSummary_ReturnColumnLablel2();
                String label3 = operating.OperatingSummary_ReturnColumnLablel3();
                Assert.IsTrue(label1 == "Yearly Actual" && label2 == "Yearly Budget" && label3 == "Yearly Proforma", $"Operating summary label{label1} does not macth with actual");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Description("Verify correct minimize maximize works for KPI")]
        [Test, Category("Sanity Test")]
        public void KPI_VerifyMaximizeAndMinimizeWorks()
        {
            try
            {
                test = extent.CreateTest("KPI_VerifyMaximizeAndMinimizeWorks").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_OperatingSummaryAndMapsPage operating = new Asset_OperatingSummaryAndMapsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                operating.ClickOperatingSummarytab();
                Boolean res = operating.KPI_minimizeWorks();
                Assert.IsTrue(res == true, "KPI minimize maximize works");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Description("Verify correct minimize maximize works for Operating Summary")]
        [Test, Category("Sanity Test")]
        public void OperatingSummary_VerifyMaximizeAndMinimizeWorks()
        {
            try
            {
                test = extent.CreateTest("OperatingSummary_VerifyMaximizeAndMinimizeWorks").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_OperatingSummaryAndMapsPage operating = new Asset_OperatingSummaryAndMapsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                Thread.Sleep(4000);
                operating.ClickOperatingSummarytab();
                Boolean res = operating.OperatingSummary_minimizeWorks();
                Assert.IsTrue(res == true, "Operating Summary minimize maximize works");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Description("Verify correct DSCR calculations for KPI section")]
        [Test, Category("Regression Test")]
        public void KPI_VerifyDSCRCalculation()
        {
            try
            {
                test = extent.CreateTest("KPI_VerifyDSCRCalculation").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_OperatingSummaryAndMapsPage operating = new Asset_OperatingSummaryAndMapsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                asset.NavigateToPropertyDetails();
                operating.ClickOperatingSummarytab();
                operating.RadioButton_SelectYTD();
                double originalDscr = operating.OriginalDSCRvalue();
                double calculatedDscr = operating.CalculatedDSCRvalue();
                Assert.IsTrue(originalDscr == calculatedDscr, $"Value displayed in KPI:{originalDscr} does not match:{calculatedDscr} ");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Description("Verify calculation debt yield=(Total NOI Actual )*12/Month(ME_Date))/Loan Balance")]
        [Test, Category("Regression Test")]
        public void KPI_VerifyDebtYeildCalculation()
        {
            try
            {
                test = extent.CreateTest("KPI_VerifyDebtYeildCalculation").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_OperatingSummaryAndMapsPage operating = new Asset_OperatingSummaryAndMapsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                asset.NavigateToPropertyDetails();
                operating.ClickOperatingSummarytab();
                operating.RadioButton_SelectYTD();
                double original = operating.KPI_ActualDebtYieldValue();
                double calculated = operating.KPI_Calculate_DebtYieldValue();
                Assert.IsTrue(original == calculated, $"Value displayed in KPI:'{original}' does not match:'{calculated}'");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Description("Verify calculation YOC=(Total NOI Actual *12/Month(ME_Date))/Net Capitalization")]
        [Test, Category("Regression Test")]
        public void KPI_VerifyYOCCalculation()
        {
            try
            {
                test = extent.CreateTest("KPI_VerifyYOCCalculation").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_OperatingSummaryAndMapsPage operating = new Asset_OperatingSummaryAndMapsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                asset.NavigateToPropertyDetails();
                operating.ClickOperatingSummarytab();
                double original = operating.KPI_ActualYOCValue();
                double calculated = operating.KPI_Calculate_YOCValue();
                Assert.IsTrue(original == calculated, $"Value displayed in KPI:'{original}' does not match:'{calculated}'");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Description("Verify calculation Cash-on-Cash Yield= (Total NOI Actual - Total Debt Service Actual )*12/Month(ME_Date)) /Total Equity")]
        [Test, Category("Regression Test")]
        public void KPI_VerifyCashOnCashCalculation()
        {
            try
            {
                test = extent.CreateTest("KPI_VerifyCashOnCashCalculation").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_OperatingSummaryAndMapsPage operating = new Asset_OperatingSummaryAndMapsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                asset.NavigateToPropertyDetails();
                operating.ClickOperatingSummarytab();
                operating.RadioButton_SelectYTD();
                double original = operating.KPI_ActualCachOnCashYieldValue();
                double calculated = operating.KPI_Calculate_CachOnCashValue();
                Assert.IsTrue(original == calculated, $"Value displayed in KPI:'{original}' does not match:'{calculated}'");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Description("Verify calculation inPlaceRent Yield= (Total NOI Actual *12/Month(ME_Date))/Current Leased % / Building NRA")]
        [Test, Category("Regression Test")]
        public void KPI_VerifyinPlaceRentCalculation()
        {
            try
            {
                test = extent.CreateTest("KPI_VerifyinPlaceRentCalculation").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_OperatingSummaryAndMapsPage operating = new Asset_OperatingSummaryAndMapsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                asset.NavigateToPropertyDetails();
                operating.ClickOperatingSummarytab();
                double original = operating.KPI_ActualInPlaceRentValue();
                double calculated = operating.KPI_Calculate_InPlaceRentValue();
                Assert.IsTrue(original==calculated, $"Value in KPI:'{original}' does not match:'{calculated}'");
                test.Log(Status.Pass, "Test Case passed");
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
