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
    class Asset_BasisAndDebtTab : BaseTest
    {
        BaseTest baseTest = new BaseTest();
        [Test, Category("Sanity Test")]
        [Description("Verify correct labels are displayed in in debt info details")]
        public void VerifyLabelsDisplayedInDebtInfo()
        {
            try
            {
                test = extent.CreateTest("VerifyLabelsDisplayedInDebtInfo").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                Boolean res = basis.VerifyDebtInfoLabelsWhenLoanDetailsArePresent();
                Assert.IsTrue(res == true, "Verify labels in debt info are not correct");
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
        [Description("Verify correct labels are displayed in Current Capitalization")]
        public void VerifyLabelsDisplayedInCurrentCapitalization()
        {
            try
            {
                test = extent.CreateTest("VerifyLabelsDisplayedInCurrentCapitalization").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                String loanBal = basis.ReturnCurrentCapitalization_LoanBalance();
                String fundEq = basis.ReturnCurrentCapitalization_FundEquity();
                String streamEq = basis.ReturnCurrentCapitalization_StreamEquity();
                String totalCapita = basis.ReturnCurrentCapitalization_TotalCapitalization();
                String positiveCash = basis.ReturnCurrentCapitalization_PositiveCashFlow();
                String distributions = basis.ReturnCurrentCapitalization_DistributionsLabel();
                String netAssets = basis.ReturnCurrentCapitalization_NetCurrentAssets();
                String netCapita = basis.ReturnCurrentCapitalization_NetCapitalization();
                Assert.IsTrue(loanBal == "Loan Balance", "Loan Balance label is not displayed correct");
                Assert.IsTrue(fundEq == "Fund Equity", "Fund Equity label is not displayed correct");
                Assert.IsTrue(streamEq == "Stream Equity", "Stream equity label is not displayed correct");
                Assert.IsTrue(totalCapita == "TOTAL CAPITALIZATION", "Total capitalization label is not displayed correct");
                Assert.IsTrue(positiveCash == "Positive Cashflow", "Positive Cashflow label is not displayed correct");
                Assert.IsTrue(distributions == "Distributions", "Distributions label is not displayed correct");
                Assert.IsTrue(netAssets == "Net Current Assets", "Net Current Assets label is not displayed correct");
                Assert.IsTrue(netCapita == "NET CAPITALIZATION", "Net capitalization label is not displayed correct");
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
        [Description("Verify correct labels are displayed in estimated fully funded Capitalization")]
        public void VerifyLabelsDisplayedInEstimatedFullyFunded()
        {
            try
            {
                test = extent.CreateTest("VerifyLabelsDisplayedInEstimatedFullyFunded").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                String loanBal = basis.ReturnEstimatedFullyFundedCapitalization_LoanBalance();
                String fundEq = basis.ReturnEstimatedFullyFundedCapitalization_FundEquity();
                String streamEq = basis.ReturnEstimatedFullyFundedCapitalization_StreamEquity();
                String totalCapita = basis.ReturnEstimatedFullyFundedCapitalization_TotalCapitalization();
                Assert.IsTrue(loanBal == "Loan Balance", "Loan Balance label is not displayed correct");
                Assert.IsTrue(fundEq == "Fund Equity", "Fund Equity label is not displayed correct");
                Assert.IsTrue(streamEq == "Stream Equity", "Stream equity label is not displayed correct");
                Assert.IsTrue(totalCapita == "TOTAL EST FULLY FUNDED CAPITALIZATION", "Total est fully funded capitalization label is not displayed correct");
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
        [Description("Verify field titles shown in Current Cost basis")]
        public void VerifyLabelsDisplayedInCurrentCostBasis()
        {
            try
            {
                test = extent.CreateTest("VerifyLabelsDisplayedInCurrentCostBasis").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(2000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                basis.ClickBasisAnddebtTab();
                String purchasePrice = basis.ReturnCurrentCostbasis_PurchasePrice();
                Assert.IsTrue(purchasePrice == "Purchase Price", "Purchase Price field is missing or label is incorrect");
                String acqLoanCost = basis.ReturnCurrentCostbasis_AcquisitionLoanCosts();
                Assert.IsTrue(acqLoanCost == "Acquisition & Loan Costs", "Acquisition & Loan Cost field is missing or label is incorrect");
                String previousAcq = basis.ReturnCurrentCostbasis_PreviousAcqLoanCost();
                Assert.IsTrue(previousAcq == "Previous Acquisition & Loan Cost", "Previous Acquisition & Loan Cost field is missing or label is incorrect");
                String renovation = basis.ReturnCurrentCostbasis_RenovationCapitalCosts();
                Assert.IsTrue(renovation == "Renovation Capital Costs", "Renovation Capital Costs field is missing or label is incorrect");
                String leasingCost = basis.ReturnCurrentCostbasis_LeasingCostsImprovements();
                Assert.IsTrue(leasingCost == "Leasing Costs & Improvements", "Leasing Costs & Improvements field is missing or label is incorrect");
                String equipment = basis.ReturnCurrentCostbasis_Equipment();
                Assert.IsTrue(equipment == "Equipment", "Equipment field is missing or label is incorrect");
                String carryCoast = basis.ReturnCurrentCostbasis_CarryCost();
                Assert.IsTrue(carryCoast == "Carry Cost", "Carry Cost field is missing or label is incorrect");
                String total = basis.ReturnCurrentCostbasis_TotalCurrentCostBasis();
                Assert.IsTrue(total == "TOTAL CURRENT COST BASIS", "Carry Cost field is missing or label is incorrect");
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
        [Description("Verify user can edit positive cashflow in current capitalization")]
        public void VerifyEditWorksCurrentCapitalization_PositiveCashflow()
        {
            try
            {
                test = extent.CreateTest("VerifyEditWorksCurrentCapitalization_PositiveCashflow").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                Boolean res = basis.Edit_CurrentCapitalizationPositiveCashFlow();
                Assert.IsTrue(res == true, "Verify positive cashflow is not editable");
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
        [Description("Verify user can edit estimated fully funded section is editable")]
        public void VerifyEditWorksEstimatedFullyFundedSectionISEditable()
        {
            try
            {
                test = extent.CreateTest("VerifyEditWorksEstimatedFullyFundedSectionISEditabl").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                Boolean loanBal = basis.Edit_EstimatedFullyFundedLoanBalance();
                Boolean fundEq = basis.Edit_EstimatedFullyFundedFundEquity();
                Boolean streamEq = basis.Edit_EstimatedFullyFundedStreamEquity();
                Assert.IsTrue(loanBal == true && fundEq == true && streamEq == true, "Verify estimated fully funded section is not editable");
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
        [Description("Verify user can edit current cost basis section")]
        public void VerifyEditWorksCurrentCostBasisISEditable()
        {
            try
            {
                test = extent.CreateTest("VerifyEditWorksCurrentCostBasisISEditable").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                Boolean AcquL = basis.EditCurrentCostBasis_UpdatePreviousAcquisition();
                Boolean carryCost = basis.CurrentCostBasis_UpdateCarryCost();
                Assert.IsTrue(AcquL == true && carryCost == true, "Verify current cost basis section is not editable");
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
        [Description("Verify calculation for 'Total capitalization=Loan balance + Fund + Stream equity'")]
        public void CurrentCapitalization_CalculationForTotalCapitalization()
        {
            try
            {
                test = extent.CreateTest("CurrentCapitalization_CalculationForTotalCapitalization").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                int present = basis.CurrentCapitalization_PresentValue_TotalCapitalization();
                int Calculated = basis.CurrentCapitalization_CalculatedValue_TotalCapitalization();
                Assert.IsTrue(present == Calculated, "Verify total capitalization value is incorrect");
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
        [Description("Verify calculation for 'Net capitalization=Total Capital+Postive-distributions-NetAssets'")]
        public void CurrentCapitalization_CalculationForNetCapitalization()
        {
            try
            {
                test = extent.CreateTest("CurrentCapitalization_CalculationForNetCapitalization").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                int present = basis.CurrentCapitalization_PresentValue_NetCapitalization();
                int Calculated = basis.CurrentCapitalization_CalculatedValue_NetCapitalization();
                Assert.IsTrue(present == Calculated, "Verify net capitalization value is incorrect");
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
        [Description("Verify calculation for 'Total capitalization=Loan balance + Fund + Stream equity'")]
        public void EstimatedFullyFundedCalculationForTotalCapitalization()
        {
            try
            {
                test = extent.CreateTest("EstimatedFullyFundedCalculationForTotalCapitalization").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                int present = basis.EstimatedFullyFunded_PresentValue_TotalCapitalization();
                int Calculated = basis.EstimatedFullyFunded_CalculatedValue_TotalCapitalization();
                Assert.IsTrue(present == Calculated, "Verify net capitalization value is incorrect");
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
        [Description("Verify calculation for total current cost basis")]
        public void CurrentCostBasisCalculationForTotalCurrentCostBasis()
        {
            try
            {
                test = extent.CreateTest("CurrentCostBasisCalculationForTotalCurrentCostBasis").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                int present = basis.CurrentCostBasis_PresentValueTotalCurrentCostBasisValue();
                int Calculated = basis.CurrentCostBasis_CalculatedTotalCurrentCostBasisValue();
                Assert.IsTrue(present == Calculated, "Verify net capitalization value is incorrect");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Smoke Test")]
        [Description("Verify minimize option works for all sections")]
        public void MaximizeAndMinimizeWorksForAllSections()
        {
            try
            {
                test = extent.CreateTest("MaximizeAndMinimizeWorksForAllSections").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                Boolean debt = basis.DebtInfo_VerifyMinimizeMaximize();
                Boolean currCost = basis.CurrentCostBasis_VerifyMinimizeMaximize();
                Boolean currCapit = basis.CurrentCapitalization_VerifyMinimizeMaximize();
                Boolean estimt = basis.EstimatedFullyFunded_VerifyMinimizeMaximize();
                Assert.IsTrue(debt == currCapit == currCost == estimt == true, "Maximize, minimize does not work for all sections");
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
        [Description("Verify QuadReal equity field is displayed only for River south")]
        public void VerifyQuadRealEquityISDisplayedOnlyForRiverSouth()
        {
            try
            {
                test = extent.CreateTest("MaximizeAndMinimizeWorksForAllSections").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                String quadRealCurr = basis.CurrentCapitalization_QuadRealEquity();
                String quadRealEstimated = basis.EstimatedFullyFunded_QuadRealEquity();
                Assert.IsTrue(quadRealCurr == "QuadReal Equity", "QuadReal equity field is not displayed for Current capitalization");
                Assert.IsTrue(quadRealEstimated == "QuadReal Equity", "QuadReal equity field is not displayed for estimated fully funded capitalization");
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
        [Description("Verify DRA equity field is displayed only for Quorum")]
        public void VerifyDRAEquityISDisplayedOnlyForQuorum()
        {
            try
            {
                test = extent.CreateTest("MaximizeAndMinimizeWorksForAllSections").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                String DRACurr = basis.CurrentCapitalization_DRAEquity();
                String DRAEstimated = basis.EstimatedFullyFunded_DRAEquity();
                Assert.IsTrue(DRACurr == "DRA Equity", "DRA equity field is not displayed for Current capitalization");
                Assert.IsTrue(DRAEstimated == "DRA Equity", "DRA equity field is not displayed for estimated fully funded capitalization");
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
        [Description("Verify no data change made message displayed when no changes made in basis and debt section")]
        public void BasisAndDebtSummary_VerifyNoDataChangesmadeMessageDisplayed()
        {
            try
            {
                String noChangesmade = "No changes made in data...";
                test = extent.CreateTest("BasisAndDebtSummary_VerifyNoDataChangesmadeMessageDisplayed").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                String alert1 = basis.CurrentCapitalization_VerifyErrorNoChangesmade();
                Assert.IsTrue(alert1 == noChangesmade, $"CurrentCapitalization_ Expected error '{noChangesmade}' does not match actual '{alert1}'");

                String alert2 = basis.CurrentCostBasis_VerifyErrorNoChangesmade();
                Assert.IsTrue(alert2 == noChangesmade, $"CurrentCostBasis_ Expected error '{noChangesmade}' does not match actual '{alert2}'");

                String alert3 = basis.EstimatedFullyFunded_VerifyErrorNoChangesmade();
                Assert.IsTrue(alert3 == noChangesmade, $"EstimatedFullyFunded_ Expected error '{noChangesmade}' does not match actual '{alert3}'");
                test.Log(Status.Pass, "Test Case Passed");
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
        [Description("Verify Per Square feet value for Purchase Price and acquisition loan in current cost basis")]
        public void BasisAndDebtCCB_PSFValuesPruchaseAndAcquisitionLoan()
        {
            try
            {
                test = extent.CreateTest("BasisAndDebtCCB_PSFValuesPruchaseAndAcquisitionLoan").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                double PurchaseActualValue = basis.CurrentCostBasis_ReturnActualPurchasePricePSFValue();
                double PurchaseCalculatedValue = basis.CurrentCostBasis_CalculatePurchasePricePSFValue();
                Assert.IsTrue(PurchaseActualValue == PurchaseCalculatedValue, $"Value shown on screen {PurchaseActualValue} does not match calculated {PurchaseCalculatedValue}");
                double AcquActualValue = basis.CurrentCostBasis_ReturnActualAcquisitionLoanCostPSFValue();
                double AcquCalculatedValue = basis.CurrentCostBasis_CalculateAcquisitionLoanCostPSFValue();
                Assert.IsTrue(AcquActualValue == AcquCalculatedValue, $"Value shown on screen {AcquActualValue} does not match calculated {AcquCalculatedValue}");
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
        [Description("Verify Per Square feet value for Previous Loan cost and renovation in current cost basis")]
        public void BasisAndDebt_PSFValuesPreeviousLoanAndRenovation()
        {
            try
            {
                test = extent.CreateTest("BasisAndDebt_PSFValuesPreeviousLoanAndRenovation").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                double PreActualValue = basis.CurrentCostBasis_ReturnActualPreviousAcquisitionPSFValue();
                double PreCalculatedValue = basis.CurrentCostBasis_CalculatePreviousAcquisitionPSFValue();
                Assert.IsTrue(PreActualValue == PreCalculatedValue, $"Value shown on screen {PreActualValue } does not match calculated {PreCalculatedValue}");
                double RenovatnActualValue = basis.CurrentCostBasis_ReturnActualAcquisitionLoanCostPSFValue();
                double RenovatnCalculatedValue = basis.CurrentCostBasis_CalculateAcquisitionLoanCostPSFValue();
                Assert.IsTrue(RenovatnActualValue == RenovatnCalculatedValue, $"Value shown on screen {RenovatnActualValue} does not match calculated {RenovatnCalculatedValue}");
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
        [Description("Verify Per Square feet value for leasing cost and equipment in current cost basis")]
        public void BasisAndDebtCCB_PSFValuesleasingCostAndEquipment()
        {
            try
            {
                test = extent.CreateTest("BasisAndDebtCCB_PSFValuesleasingCostAndEquipment").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                double LeaseActualValue = basis.CurrentCostBasis_ReturnActualLeasingCostPSFValue();
                double LeaseCalculatedValue = basis.CurrentCostBasis_CalculateLeasingCostsPSFValue();
                Assert.IsTrue(LeaseActualValue == LeaseCalculatedValue, $"Value shown on screen {LeaseActualValue } does not match calculated {LeaseCalculatedValue}");
                double EquipActualValue = basis.CurrentCostBasis_ReturnActualEquipmentPSFValue();
                double EquipCalculatedValue = basis.CurrentCostBasis_CalculateEquipmentPSFValue();
                Assert.IsTrue(EquipActualValue == EquipCalculatedValue, $"Value shown on screen {EquipActualValue} does not match calculated {EquipCalculatedValue}");
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
        [Description("Verify Per Square feet value for carry cost and total current cost basis in current cost basis")]
        public void BasisAndDebtCCB_PSFValuesForCarryCostAndLeasingCost()
        {
            try
            {
                test = extent.CreateTest("BasisAndDebtCCB_PSFValuesForCarryCostAndLeasingCost").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                double carryActualValue = basis.CurrentCostBasis_ReturnActualCarryCostPSFValue();
                double carryCalculatedValue = basis.CurrentCostBasis_CalculateCarryCostPSFValue();
                Assert.IsTrue(carryActualValue == carryCalculatedValue, $"Value shown on screen {carryActualValue } does not match calculated {carryCalculatedValue}");
                double totalActualValue = basis.CurrentCostBasis_ReturnActualEquipmentPSFValue();
                double totalCalculatedValue = basis.CurrentCostBasis_CalculateEquipmentPSFValue();
                Assert.IsTrue(totalActualValue == totalCalculatedValue, $"Value shown on screen {totalActualValue} does not match calculated {totalCalculatedValue}");
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
        [Description("Verify table tiltes in basis and debt info section")]
        public void BasisAndDebtInfo_VerifySeactionHeaderTitles()
        {
            try
            {
                String debt = "DEBT INFORMATION";
                String Capitalization = "CURRENT CAPITALIZATION";
                String CCostBasis = "CURRENT COST BASIS";
                String estimated = "ESTIMATED FULLY FUNDED CAPITALIZATION";
                test = extent.CreateTest("BasisAndDebtInfo_VerifySeactionHeaderTitles").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                String title1 = basis.ReturnTableTitle1_DebtInfo();
                Assert.IsTrue(title1 == debt, $"Title on screen '{title1}' does not match expected '{debt}'");
                String title2 = basis.ReturnTableTitle2_CurrentCapitalization();
                Assert.IsTrue(title2 == Capitalization, $"Title on screen '{title2}' does not match expected '{Capitalization}'");
                String title3 = basis.ReturnTableTitle3_CurrentCostBasis();
                Assert.IsTrue(title3 == CCostBasis, $"Title on screen '{title3}' does not match expected '{CCostBasis}'");
                String title4 = basis.ReturnTableTitle4_EstimatedFullyFunded();
                Assert.IsTrue(title4 == estimated, $"Title on screen '{title4}' does not match expected '{estimated}'");
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
        [Description("Verify Per Square feet value for loan balance, fund equity, stream equity and total capitalization")]
        public void CurrentCapitalization_PSFValuesForFirstFourFields()
        {
            try
            {
                test = extent.CreateTest("CurrentCapitalization_PSFValuesForFirstFourFields").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                double ActualValue1 = basis.CurrentCapitalization_ReturnActualLoanBalancePSFValue();
                double CalculatedValue1 = basis.CurrentCapitalization_CalculateLoanBalancePSFValue();
                Assert.IsTrue(ActualValue1 == CalculatedValue1, $"Value shown on screen {ActualValue1} does not match calculated {CalculatedValue1}");
                double ActualValue2 = basis.CurrentCapitalization_ReturnActualFundEquityPSFValue();
                double CalculatedValue2 = basis.CurrentCapitalization_CalculateFundEquityPSFValue();
                Assert.IsTrue(ActualValue2 == CalculatedValue2, $"Value shown on screen {ActualValue2} does not match calculated {CalculatedValue2}");
                double ActualValue3 = basis.CurrentCapitalization_ReturnActualStreamEquityPSFValue();
                double CalculatedValue3 = basis.CurrentCapitalization_CalculateStreamEquityPSFValue();
                Assert.IsTrue(ActualValue3 == CalculatedValue3, $"Value shown on screen {ActualValue3} does not match calculated {CalculatedValue3}");
                double ActualValue4 = basis.CurrentCapitalization_ReturnActualTotalCapitalizationPSFValue();
                double CalculatedValue4 = basis.CurrentCapitalization_CalculateTotalCapitalizationPSFValue();
                Assert.IsTrue(ActualValue4 == CalculatedValue4, $"Value shown on screen {ActualValue4} does not match calculated {CalculatedValue4}");
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
        [Description("Verify Per Square feet value for positive cashflow, distributions, net current assets and net capitalization")]
        public void CurrentCapitalization_PSFValuesForLastFourFields()
        {
            try
            {
                test = extent.CreateTest("CurrentCapitalization_PSFValuesForLastFourFields").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                double ActualValue1 = basis.CurrentCapitalization_ReturnActualPositiveCashflowPSFValue();
                double CalculatedValue1 = basis.CurrentCapitalization_CalculatePositiveCashflowPSFValue();
                Assert.IsTrue(ActualValue1 == CalculatedValue1, $"Value shown on screen {ActualValue1} does not match calculated {CalculatedValue1}");
                double ActualValue2 = basis.CurrentCapitalization_ReturnActualDistributionsPSFValue();
                double CalculatedValue2 = basis.CurrentCapitalization_CalculateDistributionsPSFValue();
                Assert.IsTrue(ActualValue2 == CalculatedValue2, $"Value shown on screen {ActualValue2} does not match calculated {CalculatedValue2}");
                double ActualValue3 = basis.CurrentCapitalization_ReturnActualNetCurrentAssetsPSFValue();
                double CalculatedValue3 = basis.CurrentCapitalization_CalculateNetCurrentAssetsPSFValue();
                Assert.IsTrue(ActualValue3 == CalculatedValue3, $"Value shown on screen {ActualValue3} does not match calculated {CalculatedValue3}");
                double ActualValue4 = basis.CurrentCapitalization_ReturnActualNetCapitalizationPSFValue();
                double CalculatedValue4 = basis.CurrentCapitalization_CalculateNetCapitalizationPSFValue();
                Assert.IsTrue(ActualValue4 == CalculatedValue4, $"Value shown on screen {ActualValue4} does not match calculated {CalculatedValue4}");
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
        [Description("Verify estimated fully funded Building NRA values for each field")]
        public void EstimatedFullyFunded_PSFValuesForAllFields()
        {
            try
            {
                test = extent.CreateTest("EstimatedFullyFunded_PSFValuesForAllFields").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                Asset_BasisAndDebtTabPage basis = new Asset_BasisAndDebtTabPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                asset.NavigateToPropertyDetails();
                basis.ClickBasisAnddebtTab();
                double ActualValue1 = basis.EstimatedCapitalization_ReturnActualLoanBalancePSFValue();
                double CalculatedValue1 = basis.EstimatedCapitalization_CalculateLoanBalancePSFValue();
                Assert.IsTrue(ActualValue1 == CalculatedValue1, $"Value shown on screen {ActualValue1} does not match calculated {CalculatedValue1}");
                double ActualValue2 = basis.EstimatedCapitalization_ReturnActualFundEquityPSFValue();
                double CalculatedValue2 = basis.EstimatedCapitalization_CalculateFundEquityPSFValue();
                Assert.IsTrue(ActualValue2 == CalculatedValue2, $"Value shown on screen {ActualValue2} does not match calculated {CalculatedValue2}");
                double ActualValue3 = basis.EstimatedCapitalization_ReturnActualStreamEquityPSFValue();
                double CalculatedValue3 = basis.EstimatedCapitalization_CalculateStreamEquityPSFValue();
                Assert.IsTrue(ActualValue3 == CalculatedValue3, $"Value shown on screen {ActualValue3} does not match calculated {CalculatedValue3}");
                double ActualValue4 = basis.EstimatedCapitalization_ReturnActualTotalcapitalizationPSFValue();
                double CalculatedValue4 = basis.EstimatedCapitalization_CalculateTotalCapitaPSFValue();
                Assert.IsTrue(ActualValue4 == CalculatedValue4, $"Value shown on screen {ActualValue4} does not match calculated {CalculatedValue4}");
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
