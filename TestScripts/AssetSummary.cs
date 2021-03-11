using AventStack.ExtentReports;
using InvestmentManagement.BaseClass;
using InvestmentManagement.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UI_InvestmentMangement.PageObjects;
using UI_InvestmentMangement.TestScripts;

namespace InvestmentManagement.TestScripts
{
    [TestFixture]
    class AssetSummary : BaseTest
    {
        BaseTest baseTest = new BaseTest();
        [Test, Category("Sanity Test")]
        [Description("Verify user lands on performance and titles on tile for Fund A")]
        public void PerformanceSummaryForFundA()
        {
            try
            {
                test = extent.CreateTest("PerformanceSummaryForFundA").Info("Test Started");
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                //Verification user lands on Fund A, performance Summary when logged in
                var checkfunda = funds.UserLandsOnFundPortfolioSummary();
                Assert.IsTrue(checkfunda == true, "Login Unsuccessful");
                //Verification first four titles show correct values
                funds.ClickPerformanceSummary();
                var totalcommitment = funds.GetTotalCommitmentTitle();
                Assert.AreEqual("Total Commitment", totalcommitment, $"Expected:'Total Commitment' does not match Actual{totalcommitment}");
                var contributions = funds.GetContributionsTitle();
                Assert.AreEqual("Contribution", contributions, $"Expected:'Contribution' does not match Actual{contributions}");
                var distributions = funds.GetDistributionsTitle();
                Assert.AreEqual("Distributions", distributions, $"Expected:'Distributions' does not match Actual{distributions}");
                var unfundedcommitment = funds.GetUnfundedCommitmentTitle();
                Assert.AreEqual("Unfunded Commitment", unfundedcommitment, $"Expected:'Unfunded Commitment' does not match Actual{unfundedcommitment}");
                var accumulatedPref = funds.GetAccumulatedPrefTitle();
                Assert.AreEqual("Accumulated Pref", accumulatedPref, $"Expected:'Accumulated Pref' does not match Actual{accumulatedPref}");
                var currentCost = funds.GetCurrentCostOfCapitalTitle();
                Assert.AreEqual("Current Cost Of Capital", currentCost, $"Expected:'Current Cost Of Capital' does not match Actual{currentCost}");
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
        [Description("Verify user lands on performance and titles on tile for Fund B")]
        public void PerformanceSummaryForFundB()
        {
            try
            {
                test = extent.CreateTest("PerformanceSummaryForFundB").Info("Test Started");
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                //Verification to confirm titles on Performance Summary for Fund B
                funds.ClickFundBTab();
                funds.ClickPerformanceSummary();
                var totalcommitment = funds.GetTotalCommitmentTitle();
                Assert.AreEqual("Total Commitment", totalcommitment, $"Expected:'Total Commitment' does not match Actual{totalcommitment}");
                var contributions = funds.GetContributionsTitle();
                Assert.AreEqual("Contribution", contributions, $"Expected:'Contribution' does not match Actual{contributions}");
                var distributions = funds.GetDistributionsTitle();
                Assert.AreEqual("Distributions", distributions, $"Expected:'Distributions' does not match Actual{distributions}");
                var unfundedcommitment = funds.GetUnfundedCommitmentTitle();
                Assert.AreEqual("Unfunded Commitment", unfundedcommitment, $"Expected:'Unfunded Commitment' does not match Actual{unfundedcommitment}");
                var accumulatedPref = funds.GetAccumulatedPrefTitle();
                Assert.AreEqual("Accumulated Pref", accumulatedPref, $"Expected:'Accumulated Pref' does not match Actual{accumulatedPref}");
                var currentCost = funds.GetCurrentCostOfCapitalTitle();
                Assert.AreEqual("Current Cost Of Capital", currentCost, $"Expected:'Current Cost Of Capital' does not match Actual{currentCost}");
                test.Log(Status.Pass, "Test Case passed");
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
        [Description("Verify download works on asset summary for both the funds")]
        public void DownLoadReportsFunds()
        {
            try
            {
                test = extent.CreateTest("DownLoadReportsFunds").Info("Test Started");
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                //Verify download works for Fund A
                Thread.Sleep(3000);
                funds.SelectFundsFromDropdwon();
                funds.ClickAssetSummary();
                funds.DownloadReportForFunds();
                Thread.Sleep(3000);
                funds.ClickFundBTab();
                driver.Navigate().Refresh();
                funds.ClickAssetSummary();
                funds.DownloadReportForFunds();
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
        [Test, Category("Sanity Test")]
        [Description("Verify Search works for Both Fund A and Fund B")]
        public void SearchWorksForBothTheFunds()
        {
            try
            {
                test = extent.CreateTest("SearchWorksForBothTheFunds").Info("Test Started");
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                //Verify search works on fund A
                funds.SelectFundsFromDropdwon();
                funds.ClickAssetSummary();
                int countbeforesearchA = funds.RowsBeforeSearch();
                int countaftersearchA = funds.RowsafterSearchForProperty();
                Assert.IsTrue(countbeforesearchA > countaftersearchA, "Search does not work");

                //Verify search works on fund B
                funds.ClickFundBTab();
                driver.Navigate().Refresh();
                funds.ClickAssetSummary();
                int countbeforesearchB = funds.RowsBeforeSearch();
                int countaftersearchB = funds.RowsafterSearchForProperty();
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
        [Description("Verify Change View works for Both Fund A and Fund B")]
        public void verifyChangeViewWorksForFundA_B()
        {
            try
            {
                test = extent.CreateTest("verifyChangeViewWorksForFundA_B").Info("Test Started");
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                funds.SelectFundsFromDropdwon();
                funds.ClickAssetSummary();
                //Verify user can switch to list view
                Boolean lview = funds.ChangeToListView();
                Assert.IsTrue(lview == true, "View not changed to list view");
                driver.Navigate().Refresh();
                Thread.Sleep(5000);

                //Verify switch view works on fund B
                funds.ClickFundBTab();
                driver.Navigate().Refresh();
                funds.ClickAssetSummary();
                Boolean cview = funds.ChangeToCardView();
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
        [Description("Verify Sort By works for Both Fund A and Fund B")]
        public void VerifySortbyWorks()
        {
            try
            {
                test = extent.CreateTest("VerifySortbyWorks").Info("Test Started");
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                funds.SelectFundsFromDropdwon();
                funds.ClickAssetSummary();
                //Verify Sort By for Fund A
                funds.ClickOptionsInSortBy();
                //Verify descending works as expected                
                Boolean desc = funds.SelectDescending();
                Assert.True(desc == true, "Descending does not work");
                Thread.Sleep(3000);
                //Verify Ascending works as expected
                Boolean Asc = funds.SelectAscending();
                Assert.True(Asc == true, "Ascending does not work");

                //Verify sort by works for Fund B
                funds.ClickFundBTab();
                driver.Navigate().Refresh();
                funds.ClickAssetSummary();
                funds.ClickOptionsInSortBy();
                Boolean desc1 = funds.SelectDescending();
                Assert.True(desc1 == true, "Descending does not work");
                Boolean Asc1 = funds.SelectAscending();
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
        [Description("Verify User navigates to property Details Screen")]
        public void NavigationFromFundsToAssetSummary()
        {
            try
            {
                test = extent.CreateTest("NavigationFromFundsToAssetSummary").Info("Test Started");
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                funds.SelectFundsFromDropdwon();
                funds.ClickAssetSummary();
                //Verify user navigates to property details from asset summary Fund A
                String title = funds.NavigateToPropertyDetails();
                Assert.AreEqual("Asset Summary", title, "User lands on Asset Summary Screen");
                Boolean res = funds.NavigateToAssetSummaryBack();
                Assert.IsTrue(res == true, "User does not navigated back to asset summary detail");

                //Verify user navigates to property details from asset summary Fund B
                String title1 = funds.NavigateToPropertyDetails();
                Assert.AreEqual("Asset Summary", title1, "User lands on Asset Summary Screen");
                Boolean res1 = funds.NavigateToAssetSummaryBack();
                Assert.IsTrue(res1 == true, "User does not navigated back to asset summary detail");
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
        [Description("Verify tab labels displayed for funds screen")]
        public void FundsScreen_TabLabelsDisplayed()
        {
            try
            {
                test = extent.CreateTest("FundsScreen_TabLabelsDisplayed").Info("Test Started");
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                String portfolio = funds.ReturnPortfolioSummaryTablabel();
                String debt = funds.ReturnDebtSummaryTablabel();
                String performance = funds.ReturnPerformanceSummaryTablabel();
                Assert.IsTrue(portfolio=="Portfolio Summary", $"Expected:'Portfolio Summary' does not match actual{portfolio}");
                Assert.IsTrue(debt == "Debt Summary", $"Expected:'Debt Summary' does not match actual{debt}");
                Assert.IsTrue(performance == "Performance Summary", $"Expected:'Performance Summary' does not match actual{performance}");
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
        [Description("Verify labels for portfolio summary card")]
        public void PortfolioSummary_VerifyCardLabels()
        {
            try
            {
                test = extent.CreateTest("PortfolioSummary_VerifyCardLabels").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                String leasedPercent = funds.CardView_ReturnLeasedPercentLabel();
                String currDebt = funds.CardView_ReturnCurrentDebtLabel();
                String disTri = funds.CardView_ReturnDistributionslabel();
                String totalBasis = funds.CardView_ReturnTotalBasisLabel();
                String totalBasisPSF = funds.CardView_ReturnTotalBasisPSFLabel();
                String Contribu = funds.CardView_ReturnContributionsLabel();
                Assert.IsTrue(leasedPercent == "Leased Percentage:", $"Expected:'Leased Percentage:' does not match Actual {leasedPercent}");
                Assert.IsTrue(currDebt=="Current Debt:", $"Expected:'Current Debt:' does not match actual {currDebt}");
                Assert.IsTrue(disTri=="Distributions:", $"Expected:'Distributions:' does not actual {disTri}");
                Assert.IsTrue(totalBasis=="Total Basis:", $"Expected:'Total Basis:' does not match actual{totalBasis}");
                Assert.IsTrue(totalBasisPSF=="Total Basis SF:", $"Expected:'Total Basis SF:' does not match actual{totalBasisPSF}");
                Assert.IsTrue(Contribu == "Contributions:", $"Expected:'Contributions:' does not match actual{totalBasisPSF}");
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
        [Description("Verify portfolio summary table column labels first six")]
        public void PortfolioSummary_VerifyListColumnLabels()
        {
            try
            {
                test = extent.CreateTest("PortfolioSummary_VerifyCardLabels").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                funds.ChangeToListView();
                String propName = funds.ListView_ReturnPropertyNamelabel();
                String acqu = funds.ListView_ReturnAcquisitionlabel();
                String percentLeased = funds.ListView_ReturnPercentLeasedlabel();
                String currentDebt = funds.ListView_ReturnCurrentDebtlabel();
                String currentLeve = funds.ListView_ReturnCurrentLeveragelabel();
                String basisT = funds.ListView_ReturnBasislabel();
                String basisPSF = funds.ListView_ReturnBasisPSFlabel();
                Assert.IsTrue(propName == "Property Name", $"Expected:'Property Name' does not match Actual {propName}");
                Assert.IsTrue(acqu == "Acquisition Date", $"Expected:'Acquisition Date' does not match actual {acqu}");
                Assert.IsTrue(percentLeased == "% Leased", $"Expected:'% Leased' does not match actual {percentLeased}");
                Assert.IsTrue(currentDebt == "Current Debt", $"Expected:'Current Debt:' does not actual {currentDebt}");
                Assert.IsTrue(currentLeve == "Current Leverage", $"Expected:'Current Leverage' does not match actual{currentLeve}");
                Assert.IsTrue(basisT == "Basis $", $"Expected:'Basis $' does not match actual{basisT}");
                Assert.IsTrue(basisPSF == "Basis psf", $"Expected:'Basis psf' does not match actual{basisPSF}");
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
        [Description("Verify portfolio summary table column labels last six")]
        public void PortfolioSummary_VerifyListColumnLabelsLastSix()
        {
            try
            {
                test = extent.CreateTest("PortfolioSummary_VerifyListColumnLabelsLastSix").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage funds = new AssetSummaryPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                funds.ChangeToListView();
                String noi = funds.ListView_ReturnNOIlabel();
                String cashOnCash = funds.ListView_ReturnCashOnCashlabel();
                String COCYield = funds.ListView_ReturnCOCYieldlabel();
                String distributions = funds.ListView_ReturnDistributionslabel();
                String netEquity = funds.ListView_ReturnNetEquitylabel();
                String netEquityPSF = funds.ListView_ReturnNetEquityPSFlabel();
                String contributions = funds.ListView_ReturnContributionslabel();
                Assert.IsTrue(noi == "NOI", $"Expected:'NOI' does not match Actual {noi}");
                Assert.IsTrue(cashOnCash == "Cash On Cash", $"Expected:'Cash On Cash' does not match actual {cashOnCash}");
                Assert.IsTrue(COCYield == "COC Yield", $"Expected:'COC Yield' does not match actual {COCYield}");
                Assert.IsTrue(distributions == "Distributions", $"Expected:'Distributions' does not actual {distributions}");
                Assert.IsTrue(netEquity == "Net Equity", $"Expected:'Net Equity' does not match actual{netEquity}");
                Assert.IsTrue(netEquityPSF == "Net Equity psf", $"Expected:'Net Equity psf' does not match actual{netEquityPSF}");
                Assert.IsTrue(contributions == "Contributions", $"Expected:'Contributions' does not match actual{contributions}");
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
