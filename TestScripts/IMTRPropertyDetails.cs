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
    class IMTRPropertyDetails : BaseTest
    {
        BaseTest baseTest = new BaseTest();

        [Test, Category("Regression Test")]
        public void VerifyPropertyTypeIsOngoing()
        {
            BaseTest baseTest = new BaseTest();
            try
            {
                test = extent.CreateTest("VerifyPropertyTypeIsOngoing").Info("Test Started");
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                imtr.ClickTrackRecordOnInMenu();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                String dealtype = imtrPropdetails.ReturnPropertyDealType();
                Assert.AreEqual("Ongoing", dealtype, "Property is not ongoing property");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        //[Test]
        [Test, Category("Regression Test")]
        public void VerifyPropertyTypeIsSold()
        {
            BaseTest baseTest = new BaseTest();
            try
            {
                test = extent.CreateTest("VerifyPropertyTypeIsOngoing").Info("Test Started");
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                imtr.ClickTrackRecordOnInMenu();
                Thread.Sleep(3000);
                imtr.ClickSoldDeals();
                imtr.NavigateToIMTRPropDetail();
                String dealtype = imtrPropdetails.ReturnPropertyDealType();
                Assert.AreEqual("Sold", dealtype, "Property is not ongoing property");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Regression Test")]
        public void IMTR_GeneralInfoPropertyNameAndAcuqisitionDateisEditable()
        {
            try
            {
                test = extent.CreateTest("IMTR_GeneralInfoPropertyNameAndAcuqisitionDateisEditable").Info("Test Started");
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                Thread.Sleep(3000);
                imtr.NavigateToIMTRPropDetail();
                Boolean propname = imtrPropdetails.GI_EditAndUpdatePropertyName();
                Boolean acqu = imtrPropdetails.GI_EditAndUpdateAcquisitiondate();
                Boolean dispodate = imtrPropdetails.GI_EditAndUpdateDispositionDate();
                Assert.IsTrue(propname == acqu == dispodate == true, "General Information Edit for property name, acquisition date and disposition date do not work");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Regression Test")]
        public void IMTR_GeneralInfoAllDropdownsAreEditable()
        {
            try
            {
                test = extent.CreateTest("IMTR_GeneralInfoAllDropdownsAreEditable").Info("Test Started");
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                Boolean market = imtrPropdetails.GI_EditAndUpdatePMarketValue();
                Assert.IsTrue(market == true, "Market field is not editable");
                Boolean proType = imtrPropdetails.GI_EditAndUpdateProductType();
                Assert.IsTrue(proType == true, "product type field is not editable");
                Boolean dealType = imtrPropdetails.GI_EditAndUpdateDealType();
                Assert.IsTrue(dealType == true, "deal type field is not editable");
                Boolean source = imtrPropdetails.GI_EditAndUpdateSourcingMethod();
                Assert.IsTrue(source == true, "sourcing method field is not editable");
                Boolean coinvest = imtrPropdetails.GI_EditAndUpdateCoInvestor();
                Assert.IsTrue(coinvest == true, "Co invest field is not editable");
                Boolean lender = imtrPropdetails.GI_EditAndUpdateLenderName();
                Assert.IsTrue(lender == true, "lender field is not editable");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Regression Test")]
        public void IMTR_GeneralInfoPurchasePriceAndRSFFieldsAreEditable()
        {
            try
            {
                test = extent.CreateTest("IMTR_GeneralInfoPurchasePriceAndRSFFieldsAreEditable").Info("Test Started");
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                Boolean purchase = imtrPropdetails.GI_EditAndUpdatePurchasePrice();
                Assert.IsTrue(purchase == true, "Purchase Price field is not editable");
                Boolean rsf = imtrPropdetails.GI_EditAndUpdateRSFValue();
                Assert.IsTrue(rsf == true, "RSF field is not editable");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        //[Test]
        [Test, Category("Regression Test")]
        public void UpdateExitPriceFromPurchaseVsExit()
        {
            try
            {
                test = extent.CreateTest("UpdateExitPriceFromPurchaseVsExit").Info("Test Started");
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                Boolean res = imtrPropdetails.EditAndUpdateExitPrice();
                Assert.IsTrue(res == true, "Exit Price Value not correctly updated");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }

        [Test, Category("Regression Test")]
        public void IMTRDetails_EditAndUpdateCapitalization()
        {
            try
            {
                test = extent.CreateTest("IMTRDetails_EditAndUpdateCapitalization").Info("Test Started");
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                Boolean debt = imtrPropdetails.Capitalization_EditandUpdateDebtField();
                Assert.IsTrue(debt == true, "Debt Value is not correctly updated");
                Boolean eQ1 = imtrPropdetails.Capitalization_EditandUpdateInvestorEquity();
                Assert.IsTrue(eQ1 == true, "Investor equity Value is not correctly updated");
                Boolean eQ2 = imtrPropdetails.Capitalization_EditandUpdateStreamEquity();
                Assert.IsTrue(eQ2 == true, "Stream Equity Value is not correctly updated");
                Boolean eQ3 = imtrPropdetails.Capitalization_EditandUpdateOutsideEquityEquity();
                Assert.IsTrue(eQ3 == true, "Outside Equity Value is not correctly updated");
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
        public void UpdateEquitiesAndConfirmTotalReturns()
        {
            try
            {
                test = extent.CreateTest("UpdateEquitiesAndConfirmTotalReturns").Info("Test Started");
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                imtr.ClickTrackRecordOnInMenu();
                Thread.Sleep(3000);
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                imtrPropdetails.EditAndInvestorEquity();
                imtrPropdetails.EditAndUpdate3rdPartyEquity();
                imtrPropdetails.EditAndUpdateSponsorReturns();
                String res = imtrPropdetails.CheckTotalReturns();
                Assert.IsTrue(res == "15,000", "Sum of equities is not correct");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        //[Test]
        [Test, Category("Sanity Test")]
        public void MaximizeAndMinimizeForAllSection()
        {
            try
            {
                test = extent.CreateTest("MaximizeAndMinimizeForAllSection").Info("Test Started");
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                imtr.ClickTrackRecordOnInMenu();
                Thread.Sleep(3000);
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                imtrPropdetails.Capitalization_MaximizeMinimize();
                imtrPropdetails.Investor_MaximizeMinimize();
                imtrPropdetails.SponsorEquity_MaximizeMinimize();
                imtrPropdetails.ThirdParty_MaximizeMinimize();
                imtrPropdetails.PurchasePrice_MaximizeMinimize();
                Boolean res = imtrPropdetails.GeneralInfo_MaximizeMinimize();
                Assert.True(res == true, "Maximize minimize does not work");
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
        [Description("Verify section labels in IMTr details screen")]
        public void IMTRDetails_VerifySectionTitles()
        {
            try
            {
                test = extent.CreateTest("IMTRDetails_VerifySectionTitles(").Info("Test Started");
                //Pre-requisite: User navigates to contingent property details screen
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                Thread.Sleep(3000);
                //Verifying section titles
                String section1 = imtrPropdetails.ReturnGeneralInfoSectionLabel();
                Assert.IsTrue(section1 == "GENERAL INFORMATION", $"Expected-'GENERAL INFORMATION' section title does not match actual{section1}");

                String section2 = imtrPropdetails.ReturnPurchaseVsExitSectionlabel();
                Assert.IsTrue(section2 == "PURCHASE VS. EXIT", $"Expected-'PURCHASE VS. EXIT' section title does not match actual{section2}");

                String section3 = imtrPropdetails.ReturnCapitalizationSectionlabel();
                Assert.IsTrue(section3 == "CAPITALIZATION", $"Expected-'CAPITALIZATION' section title does not match actual{section3}");

                String section4 = imtrPropdetails.ReturnThirdPartyEquitySectionlabel();
                Assert.IsTrue(section4 == "3RD - PARTY SPONSOR RETURNS", $"3RD - PARTY SPONSOR RETURNS' section title does not match actual{section4}");

                String section5 = imtrPropdetails.ReturnSponsorEquitySectionlabel();
                Assert.IsTrue(section5 == "SPONSOR RETURNS - STREAM", $"Expected-'SPONSOR RETURNS - STREAM' section title does not match actual{section5}");

                String section6 = imtrPropdetails.ReturnInvestorEquitySectionlabel();
                Assert.IsTrue(section6 == "INVESTOR RETURNS", $"Expected-'INVESTOR RETURNS' section title does not match actual{section6}");

                String section7 = imtrPropdetails.ReturnTotalEquitySectionlabel();
                Assert.IsTrue(section7 == "TOTAL RETURNS", $"Expected-'TOTAL RETURNS' section title does not match actual{section7}");
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
        [Description("Verify field labels for general information- first five fields")]
        public void IMTR_VerifyFieldslabelInGeneralInformationSection_FirstFive()
        {
            try
            {
                test = extent.CreateTest("IMTR_VerifyFieldslabelInGeneralInformationSection_FirstFive").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                //Pre-requisite: User navigates to contingent property details screen
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                Thread.Sleep(3000);
                //Verifying labels present on contingent liability card
                String yardicode = contingent.GeneralInformation_ReturnYardiCodeLabel();
                String propName = contingent.GeneralInformation_ReturnPropertyNameLabel();
                String Acquisi = contingent.GeneralInformation_ReturnAcquisitionDateLabel();
                String DispoD = contingent.GeneralInformation_ReturnDispositionDateLabel();
                String market = contingent.GeneralInformation_ReturnMarketLabel();
                Assert.IsTrue(yardicode == "Yardi Property Code", "Incorrect Yardi property code label is displayed on card view");
                Assert.IsTrue(propName == "Property Name", "Incorrect property name label is displayed on card view");
                Assert.IsTrue(Acquisi == "Acquisition Date", "Incorrect product type label is displayed on card view");
                Assert.IsTrue(DispoD == "Disposition Date", "Incorrect SRP, LP Ownership% label is displayed on card view");
                Assert.IsTrue(market == "Market", "Incorrect Total Loan Commitment label is displayed on card view");
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
        [Description("Verify field labels for general information- middle five fields")]
        public void IMTR_VerifyFieldslabelInGeneralInformationSection_MiddleFive()
        {
            try
            {
                test = extent.CreateTest("IMTR_VerifyFieldslabelInGeneralInformationSection_MiddleFive").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                Thread.Sleep(3000);
                String prodType = contingent.GeneralInformation_ReturnProductTypeLabel();
                String dealT = contingent.GeneralInformation_ReturnDealTypeLabel();
                String source = contingent.GeneralInformation_ReturnSourcingMethodLabel();
                String coInvest = contingent.GeneralInformation_ReturnCoinvestorLabel();
                String lender = contingent.GeneralInformation_ReturnLenderLabel();
                Assert.IsTrue(prodType == "Product Type", "Incorrect product Type label is displayed on card view");
                Assert.IsTrue(dealT == "Deal Type", "Incorrect deal Type label is displayed on card view");
                Assert.IsTrue(source == "Sourcing Method", "Incorrect sourcing method label is displayed on card view");
                Assert.IsTrue(coInvest == "Co-Investor", "Incorrect Co-Investor label is displayed on card view");
                Assert.IsTrue(lender == "Lender", "Incorrect lender label is displayed on card view");
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
        [Description("Verify field labels for general information- last six fields")]
        public void IMTR_VerifyFieldslabelInGeneralInformationSection_LastSix()
        {
            try
            {
                test = extent.CreateTest("IMTR_VerifyFieldslabelInGeneralInformationSection_LastSix").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                Thread.Sleep(3000);
                String rsf = contingent.GeneralInformation_ReturnRSFLabel();
                String purchasePr = contingent.GeneralInformation_ReturnPurchasePriceLabel();
                String soldPrice = contingent.GeneralInformation_ReturnSoldPriceLabel();
                String holdDays = contingent.GeneralInformation_ReturnHoldDaysLabel();
                String holdMonths = contingent.GeneralInformation_ReturnHoldMonthsLabel();
                String status = contingent.GeneralInformation_ReturnStatusLabel();
                Assert.IsTrue(rsf == "RSF", "Incorrect RSF label is displayed on card view");
                Assert.IsTrue(purchasePr == "Purchase Price", "Incorrect purchase Price label is displayed on card view");
                Assert.IsTrue(soldPrice == "Sold Price", "Incorrect sold price label is displayed on card view");
                Assert.IsTrue(holdDays == "Hold Days", "Incorrect hold days label is displayed on card view");
                Assert.IsTrue(holdMonths == "Hold Months", "Incorrect hold months label is displayed on card view");
                Assert.IsTrue(status == "Status", "Incorrect status label is displayed on card view");
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
        [Description("Verify field labels for general information- last six fields")]
        public void IMTR_VerifyFieldslabelInPurchaseAndExistPrice()
        {
            try
            {
                test = extent.CreateTest("IMTR_VerifyFieldslabelInPurchaseAndExistPrice").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                Thread.Sleep(3000);
                String totalCost = imtrPropdetails.PurchasePriceAndExistPrice_ReturnTotalCostBasislabel();
                String exitPrice = imtrPropdetails.PurchasePriceAndExistPrice_ReturnExitPricelabel();
                Assert.IsTrue(totalCost == "Total Cost Basis", $"Expected:'Total Cost Basis' does not match actual:{totalCost}");
                Assert.IsTrue(exitPrice == "Exit Price", $"Expected:'Exit Price' does not match actual:{exitPrice}");
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
        //[Test]
        [Test, Category("Regression Test")]
        [Description("Verify field labels for capitalization")]
        public void IMTR_VerifyFieldslabelInCapitalization()
        {
            try
            {
                test = extent.CreateTest("IMTR_VerifyFieldslabelInCapitalization").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                Thread.Sleep(3000);
                String label1 = imtrPropdetails.Capitalization_ReturnTotalCapitalabel();
                String label2 = imtrPropdetails.Capitalization_ReturnDebtlabel();
                String label3 = imtrPropdetails.Capitalization_ReturnTotalequitylabel();
                String label4 = imtrPropdetails.Capitalization_ReturnLTClabel();
                String label5 = imtrPropdetails.Capitalization_ReturnInvestorEquitylabel();
                String label6 = imtrPropdetails.Capitalization_ReturnStreamEquityExitPricelabel();
                String label7 = imtrPropdetails.Capitalization_ReturnOutsideSponsorlabel();
                Assert.IsTrue(label1 == "Total Capitalization", $"Expected:'Total Capitalization' does not match actual:{label1}");
                Assert.IsTrue(label2 == "Debt", $"Expected:'Debt' does not match actual:{label2}");
                Assert.IsTrue(label3 == "Total Equity", $"Expected:'Total Equity' does not match actual:{label3}");
                Assert.IsTrue(label4 == "LTC", $"Expected:'LTC' does not match actual:{label4}");
                Assert.IsTrue(label5 == "Investor Equity", $"Expected:'Investor Equity' does not match actual:{label5}");
                Assert.IsTrue(label6 == "Stream Sponsor Equity", $"Expected:'Stream Sponsor Equity' does not match actual:{label6}");
                Assert.IsTrue(label7 == "Outside Sponsor Equity", $"Expected:'Outside Sponsor Equity' does not match actual:{label7}");
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
        //[Test]
        [Test, Category("Sanity Test")]
        [Description("Verify field labels for distributions fields")]
        public void IMTR_VerifyFieldslabelInDistributionsSection()
        {
            try
            {
                test = extent.CreateTest("IMTR_VerifyFieldslabelInCapitalization").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                Thread.Sleep(3000);
                String label1 = imtrPropdetails.ThirdPartySponsor_ReturnDistributionsReturnsLabel();
                String label2 = imtrPropdetails.StreamSponsor_ReturnDistributionsLabel();
                String label3 = imtrPropdetails.InvestorSponsor_ReturnDistributionslabel();
                String label4 = imtrPropdetails.TotalReturns_ReturnDistributionsLabel();
                Assert.IsTrue(label1 == "3rd-Party Sponsor Distributions", $"Expected:'3rd-Party Sponsor Distributions' does not match actual:{label1}");
                Assert.IsTrue(label2 == "Stream Sponsor Distributions", $"Expected:'Stream Sponsor Distributions' does not match actual:{label2}");
                Assert.IsTrue(label3 == "Investor Distributions", $"Expected:'Investor Distributions' does not match actual:{label3}");
                Assert.IsTrue(label4 == "Total Distributions", $"Expected:'Total Distributions' does not match actual:{label4}");
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
        [Description("Verify no data change made message displayed when no changes made in general info section")]
        public void GeneralInfo_VerifyNoDataChangesmadeMessageDisplayed()
        {
            try
            {
                test = extent.CreateTest("GeneralInfo_VerifyNoDataChangesmadeMessageDisplayed").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                String alertText = imtrPropdetails.GeneralInfo_VerifyErrorNoChangesmade();
                Assert.IsTrue(alertText == "No changes made in data...", $"Expected error 'No changes made in data...' does not match actual{alertText}");
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
        [Description("Verify no data change made message displayed-in purchase Vs exit section")]
        public void PurchaseVsExit_VerifyNoDataChangesmadeMessageDisplayed()
        {
            try
            {
                test = extent.CreateTest("PurchaseVsExit_VerifyNoDataChangesmadeMessageDisplayed").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                String alertText = imtrPropdetails.PurchaseVsExit_VerifyErrorNoChangesmade();
                Assert.IsTrue(alertText == "No changes made in data...", $"Expected error 'No changes made in data...' does not match actual{alertText}");
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
        [Description("Verify no data change made message displayed-in capitalization section")]
        public void capitalization_VerifyNoDataChangesmadeMessageDisplayed()
        {
            try
            {
                test = extent.CreateTest("capitalization_VerifyNoDataChangesmadeMessageDisplayed").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                String alertText = imtrPropdetails.Capitalization_VerifyErrorNoChangesmade();
                Assert.IsTrue(alertText == "No changes made in data...", $"Expected error 'No changes made in data...' does not match actual{alertText}");
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
        [Description("Verify no data change made message displayed-in Third Party section section")]
        public void ThirdPartyDistributions_VerifyNoDataChangesmadeMessageDisplayed()
        {
            try
            {
                test = extent.CreateTest("ThirdPartyDistributions_VerifyNoDataChangesmadeMessageDisplayed").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                String alertText = imtrPropdetails.ThirdPartyEquity_VerifyErrorNoChangesmade();
                Assert.IsTrue(alertText == "No changes made in data...", $"Expected error 'No changes made in data...' does not match actual{alertText}");
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
        [Description("Verify no data change made message displayed-in Sponsor distribtions section")]
        public void SponsorDistributions_VerifyNoDataChangesmadeMessageDisplayed()
        {
            try
            {
                test = extent.CreateTest("SponsorDistributions_VerifyNoDataChangesmadeMessageDisplayed").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                String alertText = imtrPropdetails.SponsorEquity_VerifyErrorNoChangesmade();
                Assert.IsTrue(alertText == "No changes made in data...", $"Expected error 'No changes made in data...' does not match actual{alertText}");
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
        [Description("Verify no data change made message displayed-in investor distribtions section")]
        public void InvestorDistributions_VerifyNoDataChangesmadeMessageDisplayed()
        {
            try
            {
                test = extent.CreateTest("InvestorDistributions_VerifyNoDataChangesmadeMessageDisplayed").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                String alertText = imtrPropdetails.Investorequity_VerifyErrorNoChangesmade();
                Assert.IsTrue(alertText == "No changes made in data...", $"Expected error 'No changes made in data...' does not match actual{alertText}");
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
        [Description("Verify total capitalization=Debt amount+ Total equity")]
        public void Capitalization_VerifyTotalCapitalizationCalculation()
        {
            try
            {
                test = extent.CreateTest("Capitalization_VerifyTotalCapitalizationCalculation(").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                int actualValue = imtrPropdetails.Capitalization_ReturnCurrentTotalCapitalizationValue();
                int calculatedValue = imtrPropdetails.Capitalization_CalculateTotalCapitalizationValue();
                Assert.IsTrue(actualValue == calculatedValue, $"Value on screen {actualValue} does not match calculated {calculatedValue}");
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
        [Description("Verify total equity =  InvestoreQ + streameQ + OutsideeQ")]
        public void Capitalization_VerifyTotalEquityCalculation()
        {
            try
            {
                test = extent.CreateTest("Capitalization_VerifyTotalEquityCalculation").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                int actualValue = imtrPropdetails.Capitalization_ReturnTotalEquityAmount();
                int calculatedValue = imtrPropdetails.Capitalization_CalculateTotalEquityValue();
                Assert.IsTrue(actualValue == calculatedValue, $"Value on screen {actualValue} does not match calculated {calculatedValue}");
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
        [Description("Verify LTC =  debt/(debt+ equity)")]
        public void Capitalization_VerifyLTCCalculation()
        {
            try
            {
                test = extent.CreateTest("Capitalization_VerifyLTCCalculation").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                double actualValue = imtrPropdetails.Capitalization_ReturnActualLTCValue();
                double calculatedValue = imtrPropdetails.Capitalization_CalculatedLTCValue();
                Assert.IsTrue(actualValue == calculatedValue, $"Value on screen {actualValue} does not match calculated {calculatedValue}");
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
        [Description("Verify error message displayed when only sold price is saved")]
        public void GeneralInfo_VerifyErrorMessageDisplayedWhenSoldPriceIsSaved()
        {
            try
            {
                test = extent.CreateTest("GeneralInfo_VerifyErrorMessageDisplayedWhenSoldPriceIsSaved").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                IMTRPropertyDetailsPage imtrPropdetails = new IMTRPropertyDetailsPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                String alertText = imtrPropdetails.GI_EditAndUpdateSoldPrice();
                double calculatedValue = imtrPropdetails.Capitalization_CalculatedLTCValue();
                Assert.IsTrue(alertText == "Please enter Disposition Date and sold Price to sell a property.", $"Expected error 'Please enter Disposition Date and sold Price to sell a property.' does not match actual{alertText}");
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
        [Description("Verify Archive property should get removed from landing screen")]
        public void ArchiveIMTROngoingDeals()
        {
            try
            {
                test = extent.CreateTest("ArchiveIMTROngoingDeals").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                Thread.Sleep(3000);
                imtr.clickOnCard();
                int NumberOfLoanBeforeArchive = imtr.CountNumberOfLoan();
                imtr.clickOnArchiveIcon();
                int NumberOfLoanAfterArchive = imtr.CountNumberOfLoan();
                Assert.IsTrue(NumberOfLoanBeforeArchive > NumberOfLoanAfterArchive, "Failed to archived loan");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }



        [Test, Category("Regression Test")]
        [Description("Verify error text keeping disposition date filled and  sold price empty ")]
        public void VerifyAlertTextForOngoingDealsKeepingSoldPriceEmpty()
        {
            try
            {
                test = extent.CreateTest("VerifyAlertTextForOngoingDealsKeepingSoldPriceEmpty").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                Thread.Sleep(3000);
                imtr.SerachProperty();
                imtr.clickOnCard();
                imtr.clickOnEditIcon();
                Thread.Sleep(5000);
                bool res = imtr.DispositionDate();
                Assert.IsTrue(res == true, "Failed to get the error message");



            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }

        [Test, Category("Regression Test")]
        [Description("Verify error text keeping sold price filled and dispostion date empty ")]
        public void VerifyAlertTextForOngoingDealsKeepingDateEmpty()
        {
            try
            {
                test = extent.CreateTest("VerifyAlertTextForOngoingDealsKeepingDispostionDateEmpty").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                Thread.Sleep(3000);
                imtr.SerachProperty();
                imtr.clickOnCard();
                imtr.clickOnEditIcon();
                Thread.Sleep(5000);
                bool res = imtr.SoldPrice();
                Assert.IsTrue(res == true, "Failed to get the error message");

            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }



        [Test, Category("Regression Test")]
        [Description("Verify Property Status ongoing to sold")]
        public void VerifyPropertyStatusOngoingToSold()
        {
            try
            {
                test = extent.CreateTest("VerifyPropertyStatusOngoingToSold").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                Thread.Sleep(3000);
                int NumberOfLoanBeforeOngoing = imtr.CountNumberOfLoan();
                imtr.SerachProperty();
                imtr.clickOnCard();
                Thread.Sleep(5000);
                imtr.PropertyStatus();
                imtr.ClickOngoingDeals();
                int NumberOfLoanAfterSold = imtr.CountNumberOfLoan();
                Assert.IsTrue(NumberOfLoanBeforeOngoing > NumberOfLoanAfterSold, "Failed to changed the status to sold");


                //bool res = imtr.SoldPrice();
                //Assert.IsTrue(res == true, "Failed to get the error message");



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
