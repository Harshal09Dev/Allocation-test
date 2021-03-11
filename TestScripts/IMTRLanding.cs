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
    class IMTR : BaseTest
    {
        BaseTest baseTest = new BaseTest();

        [Test, Category("Sanity Test")]
        [Description("Verify IMTR Performance Screen Perforance Statastices")]
        public void VerifyGraphsTitlesDisplayed()
        {
            try
            {
                test = extent.CreateTest("VerifyGraphsTitlesDisplayed").Info("Test Started");
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                //Navigation to IMTR screen
                imtr.ClickTrackRecordOnInMenu();
                Thread.Sleep(3000);

                //Below steps verifies graph titles for Total SF
                String sftitle = imtr.GetTotalSFGraphTitles();
                String sfsubtitle = imtr.GetTotalSFSubTitle();
                Assert.AreEqual("TOTAL SF", sftitle, "SFGraph title does not match");
                Assert.AreEqual("SF of Ongoing Deals", sfsubtitle, "SFGraph sub title does not match");

                //Below steps verifies graph titles for Equity Invested
                String eqtitle = imtr.GetTotalEquityInvestedTitles();
                String eqsubtitle = imtr.GetTotalEquityInvestedSubTitle();
                Assert.AreEqual("EQUITY INVESTED", eqtitle, "EQGraph title does not match");
                Assert.AreEqual("Equity Invested in Ongoing Deals", eqsubtitle, "EQGraph sub title does not match");

                //Below steps verifies graph titles for Equity Invested
                String occtitle = imtr.GetOccupanyGraphTitle();
                String OccSubtitle = imtr.GetOccupanyGraphSubTitle();
                Assert.AreEqual("OCCUPANCY RATE", occtitle, " Occupancy Graph title does not match");
                Assert.AreEqual("Current Occupancy", OccSubtitle, "Occupancy Graph sub title does not match");
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
        [Description("Verify user can download report from IMTR")]
        public void DownloadIMTRReportsforOngoingAndSold()
        {
            try
            {
                test = extent.CreateTest("DownloadIMTRReportsforOngoingAndSold").Info("Test Started");
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                imtr.ClickTrackRecordOnInMenu();
                //Verify Download works for ongoing deals
                imtr.ClickOngoingDeals();
                imtr.DownloadReportForAllDeals();

                //Verify Download works for Sold deals
                Thread.Sleep(3000);
                imtr.ClickSoldDeals();
                imtr.DownloadReportForAllDeals();
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
        [Description("Verify number of deals on performance stats and in table matches")]
        public void NumberOfDealsfromTileandTablematches()
        {
            try
            {
                test = extent.CreateTest("NumberOfDealsfromTileandTablematches").Info("Test Started");
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                //Count of deals from performance highlights page
                int OngoingDealsOntitle = imtr.GetNumOfOngoingDealsOnTile();
                int SoldDealsOntitle = imtr.GetNumOfSoldDealsOnTile();
                //Verification on sold count matches from tile and table
                imtr.ClickOngoingDeals();
                int OngoingDealsInTable = imtr.GetNumOfOngoingDealsInTable();
                Assert.IsTrue(OngoingDealsOntitle == OngoingDealsInTable, $"Count displayed on performance {OngoingDealsOntitle} does not match count in table {OngoingDealsInTable}");
                //Verification on sold count matches from tile and table                
                imtr.ClickSoldDeals();
                int SoldDealsInTable = imtr.GetNumOfSoldDealsInTable();
                Assert.IsTrue(SoldDealsOntitle == SoldDealsInTable, $"Count displayed on performance {SoldDealsOntitle} does not match count in table {SoldDealsInTable}");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Smoke Testing")]
        [Description("Verify search works for ongoing and sold deals")]
        public void VerifyOSearchWorksForOngoingAndSoldDeals()
        {
            try
            {
                test = extent.CreateTest("VerifyOSearchWorksForOngoingAndSoldDeals").Info("Test Started");
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();

                //Verify search works as expected for ongoing deals
                imtr.ClickOngoingDeals();
                int searchbefore = imtr.RowsBeforeSearch();
                int searchafter = imtr.RowsafterSearchForProperty();
                Assert.True(searchafter < searchbefore, "Search does not work");

                //Verify search works as expected for sold deals
                driver.Navigate().Refresh();
                imtr.ClickSoldDeals();
                Thread.Sleep(2000);
                int sbefore = imtr.RowsBeforeSearch();
                int safter = imtr.RowsafterSearchForProperty();
                Assert.True(safter < sbefore, "Search does not work");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
                driver.Close();
            }
        }
        [Test, Category("Regression Test")]
        [Description("User can navigate to IMTR property details from Ongoing and sold deals")]
        public void NavigationToIMTRDetails()
        {
            try
            {
                test = extent.CreateTest("NavigationToIMTRDetails").Info("Test Started");
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();

                //Navigation from Ongoing deals
                imtr.ClickOngoingDeals();
                imtr.NavigateToIMTRPropDetail();
                String title_Ongoing = imtr.UserLandsOnPropertyDeatilsScreen();
                Assert.AreEqual(title_Ongoing, "Track Record", "User does not reach to IM Property details");

                //Navigation from Sold deals
                imtr.ClickInvestMentTrackRecordFromIMTR();
                imtr.ClickSoldDeals();
                imtr.NavigateToIMTRPropDetail();
                String title_sold = imtr.UserLandsOnPropertyDeatilsScreen();
                Assert.AreEqual(title_sold, "Track Record", "User does not reach to IM Property details");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
                driver.Close();
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify user can switch views by clicking grid sign")]
        public void SwitchingBetweenViewsOnOngoingandSoldDeals()
        {
            try
            {
                test = extent.CreateTest("SwitchingBetweenViewsOnOngoingandSoldDeals").Info("Test Started");
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();

                //Verify change view works for ongoing deals
                imtr.ClickOngoingDeals();
                Thread.Sleep(2000);
                Boolean lview = imtr.ChangeToListView();
                Assert.IsTrue(lview == true, "List View is not displayed");

                //Verify change view works for sold deals
                Thread.Sleep(3000);
                imtr.ClickSoldDeals();
                Boolean cview = imtr.ChangeToCardView();
                Assert.IsTrue(cview == true, "card View is not displayed");
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
        [Description("Verify sort By option works for ongoing and sold deals")]
        public void VerifySortByOptions()
        {
            try
            {
                test = extent.CreateTest("VerifySortByOptions").Info("Test Started");
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();

                //Verify Sort By for ongoing deals
                imtr.ClickOngoingDeals();
                //Verify descending works as expected
                imtr.ClickOptionsInSortBy();
                Boolean desc = imtr.SelectDescending();
                Assert.True(desc == true, "Descending does not work");
                Thread.Sleep(3000);
                //Verify Ascending works as expected
                Boolean Asc = imtr.SelectDescending();
                Assert.True(Asc == true, "Ascending does not work");

                //Verify Sort by for Sold Deals
                driver.Navigate().Refresh();
                Thread.Sleep(3000);
                imtr.ClickSoldDeals();
                imtr.ChangeToView();
                imtr.ClickOptionsInSortBy();
                Boolean desc1 = imtr.SelectDescending();
                Assert.True(desc1 == true, "Descending does not work");
                Boolean Asc1 = imtr.SelectDescending();
                Assert.True(Asc1 == true, "Ascending does not work");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Smoke Test")]
        [Description("Verify tab labels displayed on IMTR landing screen")]
        public void IMTR_VerifyTabLabelsDisplayed()
        {
            try
            {
                test = extent.CreateTest("IMTROngoinDeals_VerifyCardLabels").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                String label1 = imtr.ReturnPerformanceHighlightsTabLabel();
                String label2 = imtr.ReturnOngoingDealTabLabel();
                String label3 = imtr.ReturnSoldDealTabLabel();
                Assert.IsTrue(label1 == "PERFORMANCE HIGHLIGHTS", $"Expected:'PERFORMANCE HIGHLIGHTS' does not match Actual:{label1}");
                Assert.IsTrue(label2 == "ONGOING DEALS", $"Expected:'ONGOING DEALS' does not match Actual:{label2}");
                Assert.IsTrue(label3 == "SOLD DEALS", $"Expected:'SOLD DEALS' does not match Actual:{label3}");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify card labels displayed on IMTr Landing Ongoing Deals")]
        public void IMTROngoinDeals_VerifyCardLabels()
        {
            try
            {
                test = extent.CreateTest("IMTROngoinDeals_VerifyCardLabels").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                String label1 = navigation.ReturnCardLabel1();
                String label2 = navigation.ReturnCardLabel2();
                String label3 = navigation.ReturnCardLabel3();
                String label4 = navigation.ReturnCardLabel4();
                String label5 = navigation.ReturnCardLabel5();
                String label6 = navigation.ReturnCardLabel6();
                Assert.IsTrue(label1 == "Market:", $"Expected:'Market:' does not match Actual:{label1}");
                Assert.IsTrue(label2 == "Product Type:", $"Expected:'Product Type:' does not match Actual:{label2}");
                Assert.IsTrue(label3 == "Purchase Price:", $"Expected:'Purchase Price:' does not match Actual:{label3}");
                Assert.IsTrue(label4 == "Sold Price:", $"Expected:'Sold Price:' does not match Actual:{label4}");
                Assert.IsTrue(label5 == "Deal Type:", $"Expected:'Deal Type:' does not match Actual:{label5}");
                Assert.IsTrue(label6 == "RSF:", $"Expected:'RSF:' does not match Actual:{label6}");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify card labels displayed on IMTr Landing Sold Deals")]
        public void IMTRSoldDeals_VerifyCardLabels()
        {
            try
            {
                test = extent.CreateTest("IMTRSoldDeals_VerifyCardLabels").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickSoldDeals();
                String label1 = navigation.ReturnCardLabel1();
                String label2 = navigation.ReturnCardLabel2();
                String label3 = navigation.ReturnCardLabel3();
                String label4 = navigation.ReturnCardLabel4();
                String label5 = navigation.ReturnCardLabel5();
                String label6 = navigation.ReturnCardLabel6();
                Assert.IsTrue(label1 == "Market:", $"Expected:'Market:' does not match Actual:{label1}");
                Assert.IsTrue(label2 == "Product Type:", $"Expected:'Product Type:' does not match Actual:{label2}");
                Assert.IsTrue(label3 == "Purchase Price:", $"Expected:'Purchase Price:' does not match Actual:{label3}");
                Assert.IsTrue(label4 == "Sold Price:", $"Expected:'Sold Price:' does not match Actual:{label4}");
                Assert.IsTrue(label5 == "Deal Type:", $"Expected:'Deal Type:' does not match Actual:{label5}");
                Assert.IsTrue(label6 == "RSF:", $"Expected:'RSF:' does not match Actual:{label6}");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify column labels displayed on IMTr Ongoing deals")]
        public void IMTROngoingDeals_VerifyListViewColumnLabels()
        {
            try
            {
                test = extent.CreateTest("IMTROngoingDeals_VerifyListViewColumnLabels").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                imtr.ChangeToListView();
                String label1 = imtr.ReturnListViewColumnLabel1();
                String label2 = imtr.ReturnListViewColumnLabel2();
                String label3 = imtr.ReturnListViewColumnLabel3();
                String label4 = imtr.ReturnListViewColumnLabel4();
                String label5 = imtr.ReturnListViewColumnLabel5();
                String label6 = imtr.ReturnListViewColumnLabel6();
                String label7 = imtr.ReturnListViewColumnLabel7();
                Assert.IsTrue(label1 == "Property Name", $"Expected:'Property Name' does not match Actual:{label1}");
                Assert.IsTrue(label2 == "Market", $"Expected:'Market' does not match Actual:{label2}");
                Assert.IsTrue(label3 == "Co-Investor", $"Expected:'C-Investor' does not match Actual:{label3}");
                Assert.IsTrue(label4 == "Property Type", $"Expected:'Property Type' does not match Actual:{label4}");
                Assert.IsTrue(label5 == "Lender", $"Expected:'Lender' does not match Actual:{label5}");
                Assert.IsTrue(label6 == "Acquisition Date", $"Expected:'Acquisition Date' does not match Actual:{label6}");
                Assert.IsTrue(label7 == "RSF", $"Expected:'RSF' does not match Actual:{label7}");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }

        [Test, Category("Sanity Test")]
        [Description("Verify column labels displayed on IMTr Sold deals")]
        public void IMTRSoldDeals_VerifyListViewColumnLabels()
        {
            try
            {
                test = extent.CreateTest("IMTRSoldDeals_VerifyListViewColumnLabels").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickSoldDeals();
                imtr.ChangeToListView();
                String label1 = imtr.ReturnListViewColumnLabel1();
                String label2 = imtr.ReturnListViewColumnLabel2();
                String label3 = imtr.ReturnListViewColumnLabel3();
                String label4 = imtr.ReturnListViewColumnLabel4();
                String label5 = imtr.ReturnListViewColumnLabel5();
                String label6 = imtr.ReturnListViewColumnLabel6();
                String label7 = imtr.ReturnListViewColumnLabel7();
                Assert.IsTrue(label1 == "Property Name", $"Expected:'Property Name' does not match Actual:{label1}");
                Assert.IsTrue(label2 == "Market", $"Expected:'Market' does not match Actual:{label2}");
                Assert.IsTrue(label3 == "Co-Investor", $"Expected:'C-Investor' does not match Actual:{label3}");
                Assert.IsTrue(label4 == "Property Type", $"Expected:'Property Type' does not match Actual:{label4}");
                Assert.IsTrue(label5 == "Disposition Date", $"Expected:'Disposition Date' does not match Actual:{label5}");
                Assert.IsTrue(label6 == "RSF", $"Expected:'RSF' does not match Actual:{label6}");
                Assert.IsTrue(label7 == "Sold Price", $"Expected:'Sold Price' does not match Actual:{label7}");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }

        [Test, Category("Regression Test")]
        [Description("Verify capitalization with null data")]
        public void VerifyCapitalizationWithNullData()
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
                //imtr.SerachProperty();
                imtr.clickOnCard();
                Thread.Sleep(5000);
                bool res = imtr.capitalizationNullData();
                Assert.IsTrue(res == true, "Values are not upaded to hyphen ");

            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }

        [Test, Category("Regression Test")]
        [Description("Verify General Information with null data")]
        public void VerifyGenralInformationNullData()
        {
            try
            {
                test = extent.CreateTest("VerifyGenralInformationNullData").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                Thread.Sleep(3000);
                // imtr.SerachProperty();
                imtr.clickOnCard();
                Thread.Sleep(5000);
                bool res = imtr.GenralInformation();
                Assert.IsTrue(res == true, "Values are not upaded to hyphen/null ");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }

        [Test, Category("Regression Test")]
        [Description("Verify General 3rd party sponsor return with null data")]
        public void Verify3rdPartySponsorReturnNullData()
        {
            try
            {
                test = extent.CreateTest("Verify3rdPartySponsorReturnNullData").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                Thread.Sleep(3000);
                // imtr.SerachProperty();
                imtr.clickOnCard();
                Thread.Sleep(5000);
                bool res = imtr.ThirdpartySponsorReturn();
                Assert.IsTrue(res == true, "Values are not upaded to hyphen/null ");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }


        [Test, Category("Regression Test")]
        [Description("Verify sponsor return with null data")]
        public void VerifySponsorReturnNullData()
        {
            try
            {
                test = extent.CreateTest("VerifySponsorReturnNullData").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                Thread.Sleep(3000);
                // imtr.SerachProperty();
                imtr.clickOnCard();
                Thread.Sleep(5000);
                bool res = imtr.SponsorReturn();
                Assert.IsTrue(res == true, "Values are not upaded to hyphen/null ");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }


        [Test, Category("Regression Test")]
        [Description("Verify Investor return with null data")]
        public void VerifyInvestorReturnNullData()
        {
            try
            {
                test = extent.CreateTest("VerifyInvestorReturnNullData").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                Thread.Sleep(3000);
                // imtr.SerachProperty();
                imtr.clickOnCard();
                Thread.Sleep(5000);
                bool res = imtr.InvestorReturn();
                Assert.IsTrue(res == true, "Values are not upaded to hyphen/null ");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }

        [Test, Category("Regression Test")]
        [Description("Verify Total return with null data")]
        public void VerifyTotalReturnNullData()
        {
            try
            {
                test = extent.CreateTest("VerifyInvestorReturnNullData").Info("Test Started");
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                IMTRLandingPage imtr = new IMTRLandingPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickTrackRecordOption();
                imtr.ClickOngoingDeals();
                Thread.Sleep(3000);
                // imtr.SerachProperty();
                imtr.clickOnCard();
                Thread.Sleep(5000);
                bool res = imtr.PurchaseVsExit();
                Assert.IsTrue(res == true, "Values are not upaded to hyphen/null ");
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
