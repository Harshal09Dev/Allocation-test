using AventStack.ExtentReports;
using InvestmentManagement.BaseClass;
using InvestmentManagement.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using UI_InvestmentMangement.PageObjects;

namespace InvestmentManagement.TestScripts
{
    [TestFixture]
    class ContingentLiability : BaseTest
    {
        BaseTest baseTest = new BaseTest();
        [Test, Category("Sanity Test")]
        [Description("Navigation and verify download, as of date elements on screen")]
        public void VerifyContingentLiabilityLandingScreen()
        {
            try
            {
                test = extent.CreateTest("VerifyContingentLiabilityLandingScreen").Info("Test Started");
                //Verify user navigated to Schedule of contingent liability screen
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                var ContingentTitle = contingent.ClickContingentOption();
                Assert.AreEqual("Schedule of Contingent Liabilities", ContingentTitle, "Unable to reach schedule landing screen");

                //Verify as of  date and download works for all months 
                Thread.Sleep(2000);
                contingent.DownloadExcel();
                Assert.Pass();
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
        [Description("Verify all user can switch between views")]
        public void VerifySwitchingBetweenViews()
        {
            try
            {
                test = extent.CreateTest("VerifySwitchingBetweenViews").Info("Test Started");
                //Verify user can switch between card and list view
                ContingentLiabilityPage contingent = new PageObjects.ContingentLiabilityPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickContingentLiabilityOption();
                Thread.Sleep(3000);

                //Verify user can switch to list view
                Boolean lview = contingent.ChangeToListView();
                Assert.IsTrue(lview == true, "View not changed to list view");
                driver.Navigate().Refresh();
                Thread.Sleep(5000);

                //Verify user can switch to card view
                Boolean cview = contingent.ChangeToCardView();
                Assert.IsTrue(cview == true, "View not changed to card view");
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
        [Description("Verify sort by options work as expected")]
        public void VerifySortByWorks()
        {
            try
            {
                test = extent.CreateTest("VerifySortByWorks").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickContingentLiabilityOption();
                Thread.Sleep(3000);
                //Verify sort by works as expected
                contingent.TestSortBy();

                //Verify descending works as expected
                Thread.Sleep(3000);
                Boolean desc = contingent.SelectDescending();
                Assert.True(desc == true, "Descending does not work");

                Thread.Sleep(3000);
                //Verify Ascending works as expected
                Boolean Asc = contingent.SelectAscending();
                Assert.True(Asc == true, "Ascending does not work");
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
        [Description("Verify search works when different property names are called")]
        public void VerifySearchWorksExpected()
        {
            try
            {
                test = extent.CreateTest("VerifySearchWorksExpected").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickContingentLiabilityOption();
                Thread.Sleep(3000); Thread.Sleep(5000);

                //Verify search works as expected
                int searchbefore = contingent.RowsBeforeSearch();
                int searchafter = contingent.RowsafterSearchForProperty();
                Assert.True(searchafter < searchbefore, "Search does not work");
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
        [Description("Verify user navigates to property details and back to landing screen")]
        public void UserNavigatesToPropDetails()
        {
            try
            {
                test = extent.CreateTest("UserNavigatesToPropDetails").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickContingentLiabilityOption();
                Thread.Sleep(3000); String screentitle = contingent.NavigationToPropDetails();
                Assert.AreEqual("Details", screentitle, "User does not reach to property details screen");
                String landingtitle = contingent.BackToLandingScreen();
                Assert.AreEqual("Schedule of Contingent Liabilities", landingtitle, "User does not reach to landing screen");
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
        [Description("Verify General Info and Schedule of contingent laibility sections are present and minimize and maximize work")]
        public void VerifyMimimizeMaximizeWorks()
        {
            try
            {
                test = extent.CreateTest("VerifyPropertyDetailSections").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                //Pre-requisite: User navigates to contingent property details screen
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickContingentLiabilityOption();
                Thread.Sleep(3000);
                contingent.NavigationToPropDetails();
                Thread.Sleep(3000);

                //Verify minimize maximize works
                Boolean GenMin = contingent.ClickMinimizeMaximizeGenInfo();
                Assert.IsTrue(GenMin == true, "Minimize does not work");
                Boolean schemin = contingent.ClickMinimizeMaximizeScheCon();
                Assert.IsTrue(schemin == true, "Minimize does not work");
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
        [Description("Verify General Info and Schedule of contingent laibility sections are present and minimize and maximize work")]
        public void VerifyPropertyDetailSections()
        {
            try
            {
                test = extent.CreateTest("VerifyPropertyDetailSections").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                //Pre-requisite: User navigates to contingent property details screen
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickContingentLiabilityOption();
                Thread.Sleep(3000);
                contingent.NavigationToPropDetails();
                Thread.Sleep(3000);


                //Verify General information section is present();
                String title1 = contingent.SendGeneralInfoTitle();
                Assert.AreEqual("GENERAL INFORMATION", title1, "General Information section is not present");

                //Verify General information section is present
                Thread.Sleep(3000);
                String title2 = contingent.SendScheduleOfContingenttitle();
                Assert.AreEqual("SCHEDULE OF CONTINGENT LIABILITIES", title2, "SCHEDULE OF CONTINGENT LIABILITIES section is not present");
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
        [Description("Verify SRP Percent Edit works as expected")]
        public void EditAndsaveContingentLiabilityDetails()
        {
            try
            {
                test = extent.CreateTest("EditAndsaveContingentLiabilityDetails").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                //Pre-requisite: User navigates to contingent property details screen
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickContingentLiabilityOption();
                Thread.Sleep(3000);
                contingent.NavigationToPropDetails();
                Thread.Sleep(3000);
                contingent.ClickEditOnSchedule();
                Console.WriteLine("Driver reached here");

                //Verify Update SRP Percent works                
                Boolean value = contingent.UpdateSRPPercent();
                Assert.IsTrue(value == true, "SRP Percent Edit does not work");

                Thread.Sleep(3000);
                contingent.ClickEditOnSchedule();
                Boolean value1 = contingent.UpdateNetWothCovenant();
                Assert.IsTrue(value1 == true, "Net worth covenant Edit does not work");

                Thread.Sleep(3000);
                contingent.ClickEditOnSchedule();
                Boolean value2 = contingent.UpdateLiquidityCovenant();
                Assert.IsTrue(value2 == true, "Liquidity Covenant Edit does not work");
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
        [Description("Verify contingent liability selection works as expected")]
        public void EditContingentLiabilityDropdown()
        {
            try
            {
                test = extent.CreateTest("EditContingentLiabilityDropdown").Info("Test Started");
                ContingentLiabilityPage contingent = new PageObjects.ContingentLiabilityPage(BaseTest.driver);
                //Pre-requisite: User navigates to contingent property details screen
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickContingentLiabilityOption();
                Thread.Sleep(3000);
                contingent.NavigationToPropDetails();
                Thread.Sleep(3000);
                //Verify Update SRP Percent works
                contingent.ClickEditOnSchedule();
                Thread.Sleep(3000);
                Boolean res = contingent.UpdateContigentLiabilityOptions();
                Assert.IsTrue(res == true, "All options does not save");
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
        [Description("Verify card labels for contingent liability Screen")]
        public void VerifyLabelsForContingentLiabilityCard()
        {
            try
            {
                test = extent.CreateTest("VerifyLabelsForContingentLiabilityCard").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                //Pre-requisite: User navigates to contingent property details screen
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickContingentLiabilityOption();
                Thread.Sleep(3000);
                //Verifying labels present on contingent liability card
                String market = contingent.CardsLabel_ReturnMarketLabel();
                String productTyp = contingent.CardsLabel_ReturnProductTypeLabel();
                String SRPOwn = contingent.CardsLabel_ReturnSRPOwnershipLabel();
                String loanCommit = contingent.CardsLabel_ReturnTotalLoanCommitmentLabel();
                String netCovenant = contingent.CardsLabel_ReturnNetCovenantLabel();
                String liquidity = contingent.CardsLabel_ReturnLiquidCovenantLabel();
                Assert.IsTrue(market == "Market:", "Incorrect market label is displayed on card view");
                Assert.IsTrue(productTyp == "Product Type:", "Incorrect product type label is displayed on card view");
                Assert.IsTrue(SRPOwn == "SRP, LP Ownership%:", "Incorrect SRP, LP Ownership% label is displayed on card view");
                Assert.IsTrue(loanCommit == "Total Loan Commitment:", "Incorrect Total Loan Commitment label is displayed on card view");
                Assert.IsTrue(netCovenant == "Net Worth Covenant:", "Incorrect market label is displayed on card view");
                Assert.IsTrue(liquidity == "Liquidity Covenant:", "Incorrect market label is displayed on card view");
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
        [Description("Verify column labels for list view contingent liability properties")]
        public void VerifyColumnLabelsforListViewContingentLiability()
        {
            try
            {
                test = extent.CreateTest("VerifyLabelsForContingentLiabilityCard").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                //Pre-requisite: User navigates to contingent property details screen
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickContingentLiabilityOption();
                Thread.Sleep(3000);
                //Verifying labels present on contingent liability card
                contingent.ChangeToListView();
                String propertyname = contingent.ListView_ReturnPropertyNameLabel();
                String market = contingent.ListView_ReturnMarketLabel();
                String productTyp = contingent.ListView_ReturnProductTypeLabel();
                String SRPOwn = contingent.ListView_ReturnSRPOwnershipLabel();
                String loanCommit = contingent.ListView_ReturnTotalLoanCommitmentLabel();
                String netCovenant = contingent.ListView_ReturnNetCovenantLabel();
                String liquidity = contingent.ListView_ReturnLiquidityCovenantLabel();
                Assert.IsTrue(propertyname == "Property Name", "Incorrect property name label is displayed on card view");
                Assert.IsTrue(market == "Market", "Incorrect market label is displayed on card view");
                Assert.IsTrue(productTyp == "Product Type", "Incorrect product type label is displayed on card view");
                Assert.IsTrue(SRPOwn == "SRP, LP Ownership%", "Incorrect SRP, LP Ownership% label is displayed on card view");
                Assert.IsTrue(loanCommit == "Total Loan Commitment", "Incorrect Total Loan Commitment label is displayed on card view");
                Assert.IsTrue(netCovenant == "Net Worth Covenant", "Incorrect market label is displayed on card view");
                Assert.IsTrue(liquidity == "Liquidity Covenant", "Incorrect market label is displayed on card view");
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
        public void VerifyFieldslabelInGeneralInformationSection_FirstFive()
        {
            try
            {
                test = extent.CreateTest("VerifyFieldslabelInGeneralInformationSection_FirstFive").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                //Pre-requisite: User navigates to contingent property details screen
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickContingentLiabilityOption();
                Thread.Sleep(3000);
                //Verifying labels present on contingent liability card
                contingent.NavigationToPropDetails();
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
        public void VerifyFieldslabelInGeneralInformationSection_MiddleFive()
        {
            try
            {
                test = extent.CreateTest("VerifyFieldslabelInGeneralInformationSection_MiddleFive").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                //Pre-requisite: User navigates to contingent property details screen
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickContingentLiabilityOption();
                Thread.Sleep(3000);
                //Verifying labels present on contingent liability card
                contingent.NavigationToPropDetails();
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
        public void VerifyFieldslabelInGeneralInformationSection_LastSix()
        {
            try
            {
                test = extent.CreateTest("VerifyFieldslabelInGeneralInformationSection_LastSix").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                //Pre-requisite: User navigates to contingent property details screen
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickContingentLiabilityOption();
                Thread.Sleep(3000);
                //Verifying labels present on contingent liability card
                contingent.NavigationToPropDetails();
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
        [Description("Verify field labels for schedule of contingent liability section")]
        public void VerifyFieldslabelContingentLiabilitySection()
        {
            try
            {
                test = extent.CreateTest("VerifyFieldslabelContingentLiabilitySection").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                //Pre-requisite: User navigates to contingent property details screen
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickContingentLiabilityOption();
                Thread.Sleep(3000);
                //Verifying labels present on contingent liability card
                contingent.NavigationToPropDetails();
                String srpOwn = contingent.ContingentLiability_ReturnSRPPercentLabel();
                String totalcom = contingent.ContingentLiability_ReturnLoanCommitmentLabel();
                String netWorth = contingent.ContingentLiability_ReturnNetworthCovenantLabel();
                String liquiditySect = contingent.ContingentLiability_ReturnLiquidityCovenantLabel();
                String continLia = contingent.ContingentLiability_ReturnContingentLiabilityLabel();
                Assert.IsTrue(srpOwn == "SRP, LP Ownership%", "Incorrect SRP, LP Ownership% label is displayed on card view");
                Assert.IsTrue(totalcom == "Total Loan Commitment", "Incorrect Total Loan Commitment label is displayed on card view");
                Assert.IsTrue(netWorth == "Net Worth Covenant", "Incorrect Net Worth Covenant label is displayed on card view");
                Assert.IsTrue(liquiditySect == "Liquidity Covenant", "Incorrect Liquidity Covenant label is displayed on card view");
                Assert.IsTrue(continLia == "Contingent Liabilities", "Incorrect Contingent Liabilities label is displayed on card view");
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
        [Description("Verify no data change made message displayed when no changes made")]
        public void VerifyNoDataChangesmadeMessageDisplayed()
        {
            try
            {
                test = extent.CreateTest("VerifyNoDataChangesmadeMessageDisplayed").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                //Pre-requisite: User navigates to contingent property details screen
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickContingentLiabilityOption();
                Thread.Sleep(3000);
                //Verifying labels present on contingent liability card
                contingent.NavigationToPropDetails();
                String alertText = contingent.VerifyErrorNoChangesmade();
                Assert.IsTrue(alertText=="No changes Made in data...", "Incorrect message displayed");
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

        [Description("Verify user can save null values")]
        public void VerifyUserCanSaveNullValues()
        {
            try
            {
                test = extent.CreateTest("VerifyUserCanSaveNullValues").Info("Test Started");
                ContingentLiabilityPage contingent = new ContingentLiabilityPage(BaseTest.driver);
                //Pre-requisite: User navigates to contingent property details screen
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickContingentLiabilityOption();
                Thread.Sleep(3000);
                //Verifying labels present on contingent liability card
                contingent.NavigationToPropDetails();
                Boolean res = contingent.ClearInputFields();
                Assert.IsTrue(res == true, "User can not save null values");
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
    }
}

