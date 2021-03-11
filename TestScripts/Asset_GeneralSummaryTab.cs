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
    class Asset_GeneralSummaryTab : BaseTest
    {
        BaseTest baseTest = new BaseTest();
        //[Test, Order (1)]

        [Test, Category("Sanity Test")]
        [Description("Verify stacking plan is displayed when office type is selected")]
        public void StackingPlanForOfficeType()
        {
            try
            {
                test = extent.CreateTest("StackingPlanForOfficeType").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithOfficeType();
                String type = assetdetails.ReturnProductType();
                Boolean stacking = assetdetails.StackingPlanIsDisplayed();
                Assert.IsTrue(type == " Office", "Verify office type selected is not office");
                Assert.IsTrue(stacking == true, "Verify no stacking plan is displayed when product type is office");
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
        [Description("Verify site plan is displayed when industrial type is selected")]
        public void SitePlanForIndustrialAndOthersType()
        {
            try
            {
                test = extent.CreateTest("SitePlanForIndustrialAndOthersType").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption(); Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithIndustrialType();
                String type = assetdetails.ReturnProductType();
                Boolean site = assetdetails.sitePlanIsDisplayed();
                Assert.IsTrue(type == " Industrial" && site == true, "Site plan category is selected when product type is office");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        //[Test]- Core Factor has been removed from office type properties
        [Test, Category("Regression Test")]
        [Description("Verify core factor is displayed when office type is selected")]
        public void CoreFactorDisplayedFroOfficeType()
        {
            try
            {
                test = extent.CreateTest("CoreFactorDisplayedFroOfficeType").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithOfficeType();
                String type = assetdetails.ReturnProductType();
                Thread.Sleep(3000);
                Boolean core = assetdetails.ShowCoreFactor();
                Assert.IsTrue(type == " Office" && core == true, "Core factor is not displayed");
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
        [Description("Verify industrial details are displayed when industrial type is selected")]
        public void IndustrialDetailsForIndustrialProductType()
        {
            try
            {
                test = extent.CreateTest("IndustrialDetailsForIndustrialProductType").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithIndustrialType();
                String type = assetdetails.ReturnProductType();
                Boolean industrial = assetdetails.ShowIndustrial();
                Assert.IsTrue(type == " Industrial" && industrial == true, "Industrial details are not displayed for property having industrial as product type");
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
        [Description("Verify site plan is displayed when retail product type is selected")]
        public void SitePlanForRetailProductType()
        {
            try
            {
                test = extent.CreateTest("SitePlanForRetailProductType").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption(); Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithRetailType();
                String type = assetdetails.ReturnProductType();
                Boolean site = assetdetails.sitePlanIsDisplayed();
                Assert.IsTrue(type == " Retail" && site == true, "Site plan category is not selected when product type is Retail");
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
        [Description("Verify industrial details are not displayed when retail product type is selected")]
        public void IndustrialDetailsNotDisplayedForRetailType()
        {
            try
            {
                test = extent.CreateTest("IndustrialDetailsNotDisplayedForRetailType").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithRetailType();
                String type = assetdetails.ReturnProductType();
                Boolean industrial = assetdetails.ShowIndustrial();
                Assert.IsTrue(type == " Retail" && industrial == true, "Industrial details displayed when product type is Retail");
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
        [Description("Verify asset Summary Report is downloaded")]
        public void DownaloadAssetSummaryReport()
        {
            try
            {
                test = extent.CreateTest("IndustrialDetailsNotDisplayedForRetailType").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.DownloadAssetSummaryReport();
                Assert.Pass("Download excel icon is clickable");
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
        [Description("Verify Minimize and maximize button works")]
        public void MaximizeAndMinimizeButtonWorks()
        {
            try
            {
                test = extent.CreateTest("MaximizeAndMinimizeButtonWorks").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                Boolean status = assetdetails.MaximizeMiniMize();
                Assert.IsTrue(status == true, "Maximize does not work");
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
        [Description("Verify field titles shown in general asset summary for fund A property")]
        public void GeneralAsset_ValidateFieldTitlesFundA()
        {
            try
            {
                test = extent.CreateTest("GeneralAsset_ValidateFieldTitlesFundA").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                String location = assetdetails.GeneralAsset_LocationField();
                Assert.IsTrue(location == "Location", "Location field is missing or label is incorrect");
                String fund = assetdetails.GeneralAsset_FundField();
                Assert.IsTrue(fund == "Fund", "Fund field is missing or label is incorrect");
                String yearbuilt = assetdetails.GeneralAsset_YearBuiltField();
                Assert.IsTrue(yearbuilt == "Year Built", "Year Built field is missing or label is incorrect");
                String market = assetdetails.GeneralAsset_MarketField();
                Assert.IsTrue(market == "Market", "Market field is missing or label is incorrect");
                String submarket = assetdetails.GeneralAsset_SubmarketField();
                Assert.IsTrue(submarket == "Submarket", "Submarket field is missing or label is incorrect");
                String prodType = assetdetails.GeneralAsset_ProductTypeField();
                Assert.IsTrue(prodType == "Product Type", "Product Type field is missing or label is incorrect");
                String buildingNRA = assetdetails.GeneralAsset_BuildingNRAField();
                Assert.IsTrue(buildingNRA == "Building NRA", "Building NRA field is missing or label is incorrect");
                String acquisitionDate = assetdetails.GeneralAsset_AcquisitionDateField();
                Assert.IsTrue(acquisitionDate == "Acquisition Date", "Acquisition date field is missing or label is incorrect");
                String yearRenovated = assetdetails.GeneralAsset_YearRenovatedField();
                Assert.IsTrue(yearRenovated == "Year Renovated", "Year renovated field is missing or label is incorrect");
                String monthsOwned = assetdetails.GeneralAsset_MonthsOwnedField();
                Assert.IsTrue(monthsOwned == "Months Owned", "Months owned field is missing or label is incorrect");
                String leasedPercent = assetdetails.GeneralAsset_CurrentLeasedField();
                Assert.IsTrue(leasedPercent == "Current Leased %", "Current Leased % field is missing or label is incorrect");
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
        [Description("Verify field titles shown in general asset summary for fund B property")]
        public void GeneralAsset_ValidateFieldTitlesFundB()
        {
            try
            {
                test = extent.CreateTest("GeneralAsset_ValidateFieldTitlesFundB").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(2000);
                navigation.ClickFundBTab();
                Thread.Sleep(2000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                String location = assetdetails.GeneralAsset_LocationField();
                Assert.IsTrue(location == "Location", "Location field is missing or label is incorrect");
                String fund = assetdetails.GeneralAsset_FundField();
                Assert.IsTrue(fund == "Fund", "Fund field is missing or label is incorrect");
                String yearbuilt = assetdetails.GeneralAsset_YearBuiltField();
                Assert.IsTrue(yearbuilt == "Year Built", "Year Built field is missing or label is incorrect");
                String market = assetdetails.GeneralAsset_MarketField();
                Assert.IsTrue(market == "Market", "Market field is missing or label is incorrect");
                String submarket = assetdetails.GeneralAsset_SubmarketField();
                Assert.IsTrue(submarket == "Submarket", "Submarket field is missing or label is incorrect");
                String prodType = assetdetails.GeneralAsset_ProductTypeField();
                Assert.IsTrue(prodType == "Product Type", "Product Type field is missing or label is incorrect");
                String buildingNRA = assetdetails.GeneralAsset_BuildingNRAField();
                Assert.IsTrue(buildingNRA == "Building NRA", "Building NRA field is missing or label is incorrect");
                String acquisitionDate = assetdetails.GeneralAsset_AcquisitionDateField();
                Assert.IsTrue(acquisitionDate == "Acquisition Date", "Acquisition date field is missing or label is incorrect");
                String yearRenovated = assetdetails.GeneralAsset_YearRenovatedField();
                Assert.IsTrue(yearRenovated == "Year Renovated", "Year renovated field is missing or label is incorrect");
                String monthsOwned = assetdetails.GeneralAsset_MonthsOwnedField();
                Assert.IsTrue(monthsOwned == "Months Owned", "Months owned field is missing or label is incorrect");
                String leasedPercent = assetdetails.GeneralAsset_CurrentLeasedField();
                Assert.IsTrue(leasedPercent == "Current Leased %", "Current Leased % field is missing or label is incorrect");
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
        [Description("Verify field titles shown in Reversion summary for fund A property")]
        public void ReversionSummary_ValidateFieldTitlesFundA()
        {
            try
            {
                test = extent.CreateTest("ReversionSummary_ValidateFieldTitlesFundA").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(2000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                String dispositionDDate = assetdetails.ReverSionSummary_DispositionDate();
                Assert.IsTrue(dispositionDDate == "Disposition Date", "Disposition field is missing or label is incorrect");
                String dispositionMonth = assetdetails.ReverSionSummary_DispositionMonth();
                Assert.IsTrue(dispositionMonth == "Disposition Month", "Disposition Month field is missing or label is incorrect");
                String estSalesPrice = assetdetails.ReverSionSummary_EstimatedSalesPrice();
                Assert.IsTrue(estSalesPrice == "Estimated Sales Price", "Estimated Sales Price field is missing or label is incorrect");
                String estSalesPSF = assetdetails.ReverSionSummary_EstimatedPricePSF();
                Assert.IsTrue(estSalesPSF == "Est.Sales Price PSF", "Est.Sales Price PSF field is missing or label is incorrect");
                String residualCap = assetdetails.ReverSionSummary_ResidualcapRate();
                Assert.IsTrue(residualCap == "Residual Cap Rate", "Residual Cap Rate field is missing or label is incorrect");
                String dealIRR = assetdetails.ReverSionSummary_DealIRR();
                Assert.IsTrue(dealIRR == "Deal IRR", "Deal IRR field is missing or label is incorrect");
                String returnMultiple = assetdetails.ReverSionSummary_ReturnMultiple();
                Assert.IsTrue(returnMultiple == "Return Multiple", "Return Multiple field is missing or label is incorrect");
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
        [Description("Verify field titles shown in Reversion summary for fund B property")]
        public void ReversionSummary_ValidateFieldTitlesFundB()
        {
            try
            {
                test = extent.CreateTest("ReversionSummary_ValidateFieldTitlesFundB").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(2000);
                navigation.ClickFundBTab();
                Thread.Sleep(2000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                String dispositionDDate = assetdetails.ReverSionSummary_DispositionDate();
                Assert.IsTrue(dispositionDDate == "Disposition Date", "Disposition field is missing or label is incorrect");
                String dispositionMonth = assetdetails.ReverSionSummary_DispositionMonth();
                Assert.IsTrue(dispositionMonth == "Disposition Month", "Disposition Month field is missing or label is incorrect");
                String estSalesPrice = assetdetails.ReverSionSummary_EstimatedSalesPrice();
                Assert.IsTrue(estSalesPrice == "Estimated Sales Price", "Estimated Sales Price field is missing or label is incorrect");
                String estSalesPSF = assetdetails.ReverSionSummary_EstimatedPricePSF();
                Assert.IsTrue(estSalesPSF == "Est.Sales Price PSF", "Est.Sales Price PSF field is missing or label is incorrect");
                String residualCap = assetdetails.ReverSionSummary_ResidualcapRate();
                Assert.IsTrue(residualCap == "Residual Cap Rate", "Residual Cap Rate field is missing or label is incorrect");
                String dealIRR = assetdetails.ReverSionSummary_DealIRR();
                Assert.IsTrue(dealIRR == "Deal IRR", "Deal IRR field is missing or label is incorrect");
                String returnMultiple = assetdetails.ReverSionSummary_ReturnMultiple();
                Assert.IsTrue(returnMultiple == "Return Multiple", "Return Multiple field is missing or label is incorrect");
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
        [Description("Verify field titles shown in Current Cost basis for fund A property")]
        public void CurrentCostBasis_ValidateFieldTitlesFundA()
        {
            try
            {
                test = extent.CreateTest("ReversionSummary_ValidateFieldTitlesFundA").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(2000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                String purchasePrice = assetdetails.CurrentCostbasis_PurchasePrice();
                Assert.IsTrue(purchasePrice == "Purchase Price", "Purchase Price field is missing or label is incorrect");
                String acqLoanCost = assetdetails.CurrentCostbasis_AcquisitionLoanCosts();
                Assert.IsTrue(acqLoanCost == "Acquisition & Loan Costs", "Acquisition & Loan Cost field is missing or label is incorrect");
                String previousAcq = assetdetails.CurrentCostbasis_PreviousAcqLoanCost();
                Assert.IsTrue(previousAcq == "Previous Acquisition & Loan Cost", "Previous Acquisition & Loan Cost field is missing or label is incorrect");
                String renovation = assetdetails.CurrentCostbasis_RenovationCapitalCosts();
                Assert.IsTrue(renovation == "Renovation Capital Costs", "Renovation Capital Costs field is missing or label is incorrect");
                String leasingCost = assetdetails.CurrentCostbasis_LeasingCostsImprovements();
                Assert.IsTrue(leasingCost == "Leasing Costs & Improvements", "Leasing Costs & Improvements field is missing or label is incorrect");
                String equipment = assetdetails.CurrentCostbasis_Equipment();
                Assert.IsTrue(equipment == "Equipment", "Equipment field is missing or label is incorrect");
                String carryCoast = assetdetails.CurrentCostbasis_CarryCost();
                Assert.IsTrue(carryCoast == "Carry Cost", "Carry Cost field is missing or label is incorrect");
                String total = assetdetails.CurrentCostbasis_TotalCurrentCostBasis();
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
        [Test, Category("Sanity Test")]
        [Description("Verify field titles shown in Current Cost basis for fund B property")]
        public void CurrentCostBasis_ValidateFieldTitlesFundB()
        {
            try
            {
                test = extent.CreateTest("ReversionSummary_ValidateFieldTitlesFundB").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(2000);
                navigation.ClickFundBTab();
                Thread.Sleep(2000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                String purchasePrice = assetdetails.CurrentCostbasis_PurchasePrice();
                Assert.IsTrue(purchasePrice == "Purchase Price", "Purchase Price field is missing or label is incorrect");
                String acqLoanCost = assetdetails.CurrentCostbasis_AcquisitionLoanCosts();
                Assert.IsTrue(acqLoanCost == "Acquisition & Loan Costs", "Acquisition & Loan Cost field is missing or label is incorrect");
                String previousAcq = assetdetails.CurrentCostbasis_PreviousAcqLoanCost();
                Assert.IsTrue(previousAcq == "Previous Acquisition & Loan Cost", "Previous Acquisition & Loan Cost field is missing or label is incorrect");
                String renovation = assetdetails.CurrentCostbasis_RenovationCapitalCosts();
                Assert.IsTrue(renovation == "Renovation Capital Costs", "Renovation Capital Costs field is missing or label is incorrect");
                String leasingCost = assetdetails.CurrentCostbasis_LeasingCostsImprovements();
                Assert.IsTrue(leasingCost == "Leasing Costs & Improvements", "Leasing Costs & Improvements field is missing or label is incorrect");
                String equipment = assetdetails.CurrentCostbasis_Equipment();
                Assert.IsTrue(equipment == "Equipment", "Equipment field is missing or label is incorrect");
                String carryCoast = assetdetails.CurrentCostbasis_CarryCost();
                Assert.IsTrue(carryCoast == "Carry Cost", "Carry Cost field is missing or label is incorrect");
                String total = assetdetails.CurrentCostbasis_TotalCurrentCostBasis();
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
        [Description("Verify edit field works in general asset section")]
        public void GeneralAssetdetails_EditVerification()
        {
            try
            {
                test = extent.CreateTest("GeneralAssetdetails_EditVerification").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(2000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                Boolean edityearbuilt = assetdetails.UpdateGeneralAssetDetails_YearBuilt();
                Boolean editsubmarket = assetdetails.UpdateGeneralAssetDetails_SubMarket();
                Boolean edityrenovated = assetdetails.UpdateGeneralAssetDetails_YearRenovated();
                Assert.IsTrue(edityearbuilt == true && editsubmarket == true && edityrenovated == true, "Edit does not work in general asset summary");
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
        [Description("Verify edit field works in reversion summary, updating disposition and estimated sales price")]
        public void ReversionSummarydetails_EditVerification_FirstTwoFields()
        {
            try
            {
                test = extent.CreateTest("GeneralAssetdetails_EditVerification").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(2000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                Boolean dispoDate = assetdetails.UpdateReversionSummary_Dispositiondate();
                Boolean estimatedSalesP = assetdetails.UpdateReversionSummary_EstimatedSalesPrice();
                Assert.IsTrue(dispoDate == true && estimatedSalesP == true, "Edit does not work in reversion summary");
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
        [Description("Verify edit field works for Deal IRR, Multiple return and residual cap rate")]
        public void ReversionSummarydetails_EditVerifcation_LastThreeFields()
        {
            try
            {
                test = extent.CreateTest("ReversionSummarydetails_EditVerifcation_LastThreeFields").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(2000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                Boolean multipReturn = assetdetails.UpdateReversionSummary_MultipleReturn();
                Boolean dealIRR = assetdetails.UpdateReversionSummary_DealIRR();
                Boolean residualCa = assetdetails.UpdateReversionSummary_ResidualCapRate();
                Assert.IsTrue(multipReturn == true && dealIRR == residualCa == true, "Edit does not work in reversion summary for residual cap, multiple or residual");
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
        [Description("Verify disposition month value is caluclated correctly Disposition date- Acquisition date")]
        public void ReversionSummarydetails_DispositionMonthCalculation()
        {
            try
            {
                test = extent.CreateTest("ReversionSummarydetails_DispositionMonthCalculation").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(2000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                int CalculatedDisposionMonth = assetdetails.ReversionSummary_CalculateDispositionMonth();
                int ActualDispositionMonth = assetdetails.ReversionSummary_ReadDispositionMonthValue();
                Assert.IsTrue(CalculatedDisposionMonth == ActualDispositionMonth, "Incorrect disposition month value is calculated");
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
        [Description("Verify estimated sales price PSF calculated correctly")]
        public void ReversionSummarydetails_EstimatedSalesPSFCalculations()
        {
            try
            {
                test = extent.CreateTest("ReversionSummarydetails_DispositionMonthCalculation").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(2000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                Boolean estimatedPSF = assetdetails.ReversionSummary_EstimatedSalesPricePSF_calculation();
                Assert.IsTrue(estimatedPSF == true, "Incorrect estimated PSF value is calculated");
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
        [Description("Verify Total Current Cost Basis Total matches with calculated value")]
        public void CurrentCostBasis_TotalMatchesCalculatedvalue()
        {
            try
            {
                test = extent.CreateTest("ReversionSummarydetails_DispositionMonthCalculation").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(2000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                int ActualTotal = assetdetails.CurrentCostBasis_ReadTotalCurrentCostBasisValue();
                int CalculatedTotal = assetdetails.CurrentCostBasis_CalculateTotalCurrentCostBasisValue();
                Assert.IsTrue(ActualTotal == CalculatedTotal, "Incorrect total shown for cureent cost basis");
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
        [Description("Verify industrial details can be updated")]
        public void IndustrialDetailsCanBeUpdated()
        {
            try
            {
                test = extent.CreateTest("IndustrialDetailsCanBeUpdated").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithIndustrialType();
                Boolean indus = assetdetails.UpdateIndustrialDetails();
                Assert.IsTrue(indus == true, "Industrial details can not be updated");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        //[Test]- Core factors section is removed from the page
        [Test, Category("Regression Test")]
        [Description("Verify core factor details can be updated")]
        public void CoreFactorDetailsCanBeUpdated()
        {
            try
            {
                test = extent.CreateTest("CoreFactorDetailsCanBeUpdated").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithOfficeType();
                Boolean coreF = assetdetails.UpdateCorefactorValue();
                Assert.IsTrue(coreF == true, "Core factor details can not be updated");
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
        [Description("Verify images can be uploaded in site plan")]
        public void ImagesCanBeUploadedInSitePlan()
        {
            try
            {
                test = extent.CreateTest("ImagesCanBeUploadedInSitePlan").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithIndustrialType();
                Boolean res = assetdetails.UploadImagesInSitePlan();
                Assert.IsTrue(res == true, "Images can be uploaded in site plan");
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
        [Description("Verify labels for upload images button changes on category selection")]
        public void UploadImagesButtonLabelChangeWithRespectToCategory()
        {
            try
            {
                test = extent.CreateTest("UploadImagesButtonLabelChangeWithRespectToCategory").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                asset.NavigateToPropertyDetails();
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithIndustrialType();
                Boolean res = assetdetails.VerifyButtonLabelsWithRespecToImageCategory();
                Assert.IsTrue(res == true, "No correct labels are displayed for image categories");
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
        [Description("Verify Per Square feet value for Purchase Price and acquisition loan in current cost basis")]
        public void CurrentCostbasis_PSFValuesPruchaseAndAcquisitionLoan()
        {
            try
            {
                test = extent.CreateTest("CurrentCostbasis_PSFValuesPruchaseAndAcquisitionLoan").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                double PurchaseActualValue = assetdetails.CurrentCostBasis_ReturnActualPurchasePricePSFValue();
                double PurchaseCalculatedValue = assetdetails.CurrentCostBasis_CalculatePurchasePricePSFValue();
                Assert.IsTrue(PurchaseActualValue == PurchaseCalculatedValue, $"Value shown on screen {PurchaseActualValue} does not match calculated {PurchaseCalculatedValue}");
                double AcquActualValue = assetdetails.CurrentCostBasis_ReturnActualAcquisitionLoanCostPSFValue();
                double AcquCalculatedValue = assetdetails.CurrentCostBasis_CalculateAcquisitionLoanCostPSFValue();
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
        [Test, Category("Regression Test")]
        [Description("Verify Per Square feet value for Previous Loan cost and renovation in current cost basis")]
        public void CurrentCostbasis_PSFValuesPreeviousLoanAndRenovation()
        {
            try
            {
                test = extent.CreateTest("CurrentCostbasis_PSFValuesPreeviousLoanAndRenovation").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                double PreActualValue = assetdetails.CurrentCostBasis_ReturnActualPreviousAcquisitionPSFValue();
                double PreCalculatedValue = assetdetails.CurrentCostBasis_CalculatePreviousAcquisitionPSFValue();
                Assert.IsTrue(PreActualValue == PreCalculatedValue, $"Value shown on screen {PreActualValue } does not match calculated {PreCalculatedValue}");
                double RenovatnActualValue = assetdetails.CurrentCostBasis_ReturnActualAcquisitionLoanCostPSFValue();
                double RenovatnCalculatedValue = assetdetails.CurrentCostBasis_CalculateAcquisitionLoanCostPSFValue();
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
       [Test]
        [Description("Verify Per Square feet value for leasing cost and equipment in current cost basis")]
        public void CurrentCostbasis_PSFValuesleasingCostAndEquipment()
        {
            try
            {
                test = extent.CreateTest("CurrentCostbasis_PSFValuesleasingCostAndEquipment").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                double LeaseActualValue = assetdetails.CurrentCostBasis_ReturnActualLeasingCostPSFValue();
                double LeaseCalculatedValue = assetdetails.CurrentCostBasis_CalculateLeasingCostsPSFValue();
                Assert.IsTrue(LeaseActualValue == LeaseCalculatedValue, $"Value shown on screen {LeaseActualValue } does not match calculated {LeaseCalculatedValue}");
                double EquipActualValue = assetdetails.CurrentCostBasis_ReturnActualEquipmentPSFValue();
                double EquipCalculatedValue = assetdetails.CurrentCostBasis_CalculateEquipmentPSFValue();
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
        public void CurrentCostbasis_PSFValuesForCarryCostAndLeasingCost()
        {
            try
            {
                test = extent.CreateTest("CurrentCostbasis_PSFValuesForCarryCostAndLeasingCost").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                double carryActualValue = assetdetails.CurrentCostBasis_ReturnActualCarryCostPSFValue();
                double carryCalculatedValue = assetdetails.CurrentCostBasis_CalculateCarryCostPSFValue();
                Assert.IsTrue(carryActualValue == carryCalculatedValue, $"Value shown on screen {carryActualValue } does not match calculated {carryCalculatedValue}");
                double totalActualValue = assetdetails.CurrentCostBasis_ReturnActualEquipmentPSFValue();
                double totalCalculatedValue = assetdetails.CurrentCostBasis_CalculateEquipmentPSFValue();
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
        [Description("Verify no data change made message displayed when no changes made in general asset section")]
        public void GeneralAssetSUmmary_VerifyNoDataChangesmadeMessageDisplayed()
        {
            try
            {
                String noChangesmade = "No changes made in data...";
                test = extent.CreateTest("GeneralAssetSUmmary_VerifyNoDataChangesmadeMessageDisplayed").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                String alert1 = assetdetails.GeneralAssetSummary_VerifyErrorNoChangesmade();
                Assert.IsTrue(alert1 == noChangesmade, $"AssetSummary_ Expected error '{noChangesmade}' does not match actual '{alert1}'");

                String alert2 = assetdetails.ReversionSummary_VerifyErrorNoChangesmade();
                Assert.IsTrue(alert2 == noChangesmade, $"Reversion Summary_ Expected error '{noChangesmade}' does not match actual '{alert2}'");

                String alert3 = assetdetails.CurrentCostBasis_VerifyErrorNoChangesmade();
                Assert.IsTrue(alert3 == noChangesmade, $"CurrentCostBasis_ Expected error '{noChangesmade}' does not match actual '{alert3}'");
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
        [Description("Verify user can not enter incorrect year in year built or year renovated")]
        public void GeneralAssetSUmmary_VerifyEnterCorrectYearDisplayed()
        {
            try
            {
                String errorText = "Please enter correct year.";
                test = extent.CreateTest("GeneralAssetSUmmary_VerifyEnterCorrectYearDisplayed").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                asset.NavigateToPropertyDetails();
                String alert1 = assetdetails.GeneralAssetSummary_VerifyYearBuiltErrorEnterCorrectYear();
                Assert.IsTrue(alert1 == errorText, $"Expected error '{errorText}' does not match actual '{alert1}'");

                String alert2 = assetdetails.GeneralAssetSummary_VerifyYearRenovatedErrorEnterCorrectYear();
                Assert.IsTrue(alert2 == errorText, $"Expected error '{errorText}' does not match actual '{alert2}'");

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

        [Test, Category("Regression Test")]
        [Description("Verify no changes made error displays in industrial details")]
        public void IndustrialDetails_VerifyNoChangesMadeDisplayed()
        {
            try
            {
                String noChangesmade = "No changes made in data...";
                test = extent.CreateTest("GeneralAssetSUmmary_VerifyNoDataChangesmadeMessageDisplayed").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                Thread.Sleep(3000);
                asset.NavigateToPropertyDetails();
                assetdetails.selectPropertyWithIndustrialType();
                String alert1 = assetdetails.IndustrialDetails_VerifyErrorNoChangesmade();
                Assert.IsTrue(alert1 == noChangesmade, $"Industrial Details_ Expected error '{noChangesmade}' does not match actual '{alert1}'");
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
        [Description("Verify user can see floor details by clicking floor")]
        public void StackingPlan_FloorDetailsShowedByClickingFloor()
        {
            try
            {
                test = extent.CreateTest("StackingPlan_FloorDetailsShowedByClickingFloor").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickPropertyMaintenanceOption();
                asset.NavigateToPropertyDetails();
                assetdetails.selectPropertyWithOfficeType();
                Boolean alert1 = assetdetails.StackingPlan_FloorDetailsAreDisplayed();
                Assert.IsTrue(alert1 == true, "Stacking details are not displayed");
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


        [Test, Category("Regression Test")]
        [Description("Verify general asset summart with null data")]
        public void VerifyGenralAssetSummarytablewithNullData()
        {
            try
            {
                test = extent.CreateTest("VerifyGenralAssetSummarytablewithNullData").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithIndustrialTypeForImageUpload();
                asset.NavigateToPropertyDetails();
                bool res = assetdetails.GenralAssetSummaryWithNullData();

                Assert.IsTrue(res == true, "Faild to update to null values");
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
        [Description("Verify reversion asset summart with null data")]
        public void VerifyReversionSummarytablewithNullData()
        {
            try
            {
                test = extent.CreateTest("VerifyRevisionSummarytablewithNullData").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithIndustrialTypeForImageUpload();
                asset.NavigateToPropertyDetails();
                bool res = assetdetails.ReversionSummaryWithNullData();

                Assert.IsTrue(res == true, "Faild to update to null values");
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
        [Description("Verify Total Current Cost Basis with null data")]
        public void VerifyTotalCurrentCostBasistablewithNullData()
        {
            try
            {
                test = extent.CreateTest("VerifyTotalCurrentCosttablewithNullData").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithIndustrialTypeForImageUpload();
                asset.NavigateToPropertyDetails();
                bool res = assetdetails.TotalCurrentCostBasisWithNullData();

                Assert.IsTrue(res == true, "Faild to update to null values");
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
        [Description("Verify images can be uploaded in Property Image")]
        public void ImagesCanBeUploadedInPropertyImage()
        {
            try
            {
                test = extent.CreateTest("ImagesCanBeUploadedInPropertyImage").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithIndustrialTypeForImageUpload();
                asset.NavigateToPropertyDetails();
                assetdetails.ClickOnPropertyImage();
                bool res = assetdetails.UploadPropertyImages();
                Thread.Sleep(5000);
                Assert.IsTrue(res == true, "Failed to upload the image");
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
        [Description("Verify  image  can be replaced and uploaded in Property Image")]
        public void ImagesCanBeReplacedAndUploadedInPropertyImage()
        {
            try
            {
                test = extent.CreateTest("ImagesCanBeReplacedAndUploadedInPropertyImage").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithIndustrialTypeForImageUpload();
                asset.NavigateToPropertyDetails();
                assetdetails.ClickOnPropertyImage();
                bool res = assetdetails.UploadImageAndReplace();
                Thread.Sleep(5000);
                Assert.IsTrue(res == true, "Failed to upload the image");
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
        [Description("Verify  image  can be replaced and uploaded in Site Plan")]
        public void ImagesCanBeReplacedAndUploadedInSitePlan()
        {
            try
            {
                test = extent.CreateTest("ImagesCanBeReplacedAndUploadedInSitePlan").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithIndustrialTypeForImageUpload();
                asset.NavigateToPropertyDetails();
                assetdetails.ClickOnSitePlanImage();
                bool res = assetdetails.UploadImageAndReplace();
                Thread.Sleep(5000);
                Assert.IsTrue(res == true, "Failed to upload the image");
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
        [Description("Verify  image  can be replaced and uploaded in Other Docs")]
        public void ImagesCanBeReplacedAndUploadedInOtherDocs()
        {
            try
            {
                test = extent.CreateTest("ImagesCanBeReplacedAndUploadedInOtherDocs").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithIndustrialTypeForImageUpload();
                asset.NavigateToPropertyDetails();
                assetdetails.ClickOnOtherDocs();
                bool res = assetdetails.UploadImageAndReplaceinOtherDoc();
                Thread.Sleep(5000);
                Assert.IsTrue(res == true, "Failed to upload the image");
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
        [Description("Verify images can be downloaded in Property Image")]
        public void ImagesCanBeDownloadedInPropertyImage()
        {
            try
            {
                test = extent.CreateTest("ImagesCanBeDownloadedInPropertyImage").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithIndustrialTypeForImageUpload();
                asset.NavigateToPropertyDetails();
                assetdetails.ClickOnPropertyImage();
                bool res = assetdetails.UploadPropertyImages();
                Thread.Sleep(5000);
                Assert.IsTrue(res == true, "Failed to upload the image");
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
        [Description("Verify images can be deleted in Property Image")]
        public void ImagesCanBeDeletedInPropertyImage()
        {
            try
            {
                test = extent.CreateTest("ImagesCanBeUpDeletedInProperty").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithIndustrialTypeForImageUpload();
                asset.NavigateToPropertyDetails();
                assetdetails.ClickOnPropertyImage();
                bool res = assetdetails.DeletePropertyImage();
                Thread.Sleep(5000);
                Assert.IsTrue(res == true, "Failed to delete the immage/image is not avaialable to delete");
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
        [Description("Verify images can be deleted in Site Plan")]
        public void ImagesCanBeDeletedInSitePlan()
        {
            try
            {
                test = extent.CreateTest("ImagesCanBeDeletedInSitePlan").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithIndustrialTypeForImageUpload();
                asset.NavigateToPropertyDetails();
                assetdetails.ClickOnSitePlanImage();
                bool res = assetdetails.DeleteSiteImage();
                Thread.Sleep(5000);
                Assert.IsTrue(res == true, "Failed to delted the image / Image is not available");
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
        [Description("Verify files can be deleted in Site Docs")]
        public void FilesCanBeDeletedInSiteDocs()
        {
            try
            {
                test = extent.CreateTest("FilesCanBeDeletedInSiteDocs").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                Thread.Sleep(3000);
                AssetSummaryPage asset = new AssetSummaryPage(BaseTest.driver);
                AssetPropertyDetailsPage assetdetails = new AssetPropertyDetailsPage(BaseTest.driver);
                assetdetails.selectPropertyWithIndustrialTypeForImageUpload();
                asset.NavigateToPropertyDetails();
                assetdetails.ClickOnOtherDocs();
                bool res = assetdetails.DeleteOtherDoc();
                Thread.Sleep(5000);
                Assert.IsTrue(res == true, "Failed to delted the image / Image is not available");
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
