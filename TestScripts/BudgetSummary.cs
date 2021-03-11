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
    class BudgetSummary: BaseTest
    {
       // BaseTest baseTest = new BaseTest();
        [Test, Category("Sanity Test")]
        [Description("Navigation to development budget screen")]
        public void VerifyNavigationToDevelopmentBudgetScreen()
        {
            //try
            //{
                test = extent.CreateTest("VerifyNavigationToDevelopmentBudgetScreen").Info("Test Started");
                //Verify user navigated to development budget summary screen
                BudgetSummaryPage budget = new BudgetSummaryPage(BaseTest.driver);
                Thread.Sleep(2000);
                var screentitle = budget.UserLandsOnDevelopmentBudget();
                Assert.AreEqual("Development Budget Summary", screentitle, "Unable to reach development budget landing screen");             
                test.Log(Status.Pass, "Test Case Passed");
            //}
            //catch (Exception e)
            //{
            //    test.Log(Status.Fail, "Test Case Failed");
            //    baseTest.TakeScreenshot();
            //    Console.WriteLine(e.StackTrace);
            //}
        }
        [Test, Category("Sanity Test")]
        [Description("Verify all user can switch between views")]
        public void VerifySwitchingBetweenViews()
        {
            //try
            //{
                test = extent.CreateTest("VerifySwitchingBetweenViews").Info("Test Started");
                //Verify user can switch between card and list view
                BudgetSummaryPage budget = new BudgetSummaryPage(BaseTest.driver);
                budget.ClickBudgetSummaryMenu();
                Thread.Sleep(3000);

                //Verify user can switch to list view
                Boolean lview = budget.ChangeToListView();
                Assert.IsTrue(lview == true, "View not changed to list view");
                driver.Navigate().Refresh();
                Thread.Sleep(5000);

                //Verify user can switch to card view
                Boolean cview = budget.ChangeToCardView();
                Assert.IsTrue(cview == true, "View not changed to card view");
                test.Log(Status.Pass, "Test Case Passed");
            //}
            //catch (Exception e)
            //{
            //    test.Log(Status.Fail, "Test Case Failed");
            //    baseTest.TakeScreenshot();
            //    Console.WriteLine(e.StackTrace);
            //}
        }
        [Test, Category("Sanity Test")]
        [Description("Verify search works when different property names are called")]
        public void VerifySearchWorksExpectedOnBudgetScreen()
        {
            //try
            //{
                test = extent.CreateTest("VerifySearchWorksExpected").Info("Test Started");
                BudgetSummaryPage budget = new BudgetSummaryPage(BaseTest.driver);
                budget.ClickBudgetSummaryMenu();
                Thread.Sleep(3000);

                //Verify search works as expected
                int searchbefore = budget.RowsBeforeSearch();
                int searchafter = budget.RowsafterSearchForProperty();
                Assert.True(searchafter < searchbefore, "Search does not work");
                test.Log(Status.Pass, "Test Case Passed");
            //}
            //catch (Exception e)
            //{
            //    test.Log(Status.Fail, "Test Case Failed");
            //    baseTest.TakeScreenshot();
            //    Console.WriteLine(e.StackTrace);
            //}
        }

        [Test, Category("Sanity Test")]
        [Description("Verify sort by options work as expected")]
        public void VerifySortByWorksInDevelopmentBudget()
        {
            test = extent.CreateTest("VerifySortByWorksInDevelopmentBudget").Info("Test Started");
            BudgetSummaryPage budget = new BudgetSummaryPage(BaseTest.driver);
            budget.ClickBudgetSummaryMenu();
            Thread.Sleep(3000);
            budget.TestSortByInBudget();

            //Verify descending works as expected
            Thread.Sleep(3000);
            Boolean desc = budget.SelectDescending();
            Assert.True(desc == true, "Descending does not work");
            Thread.Sleep(3000);
            //Verify Ascending works as expected
            Boolean Asc = budget.SelectAscending();
            Assert.True(Asc == true, "Ascending does not work");
            test.Log(Status.Pass, "Test Case Passed");
            //}
            //catch (Exception e)
            //{
            //    test.Log(Status.Fail, "Test Case Failed");
            //    baseTest.TakeScreenshot();
            //    Console.WriteLine(e.StackTrace);
            //}
        }
        [Test, Category("Sanity Test")]
        [Description("Verify user navigates to property details and back to budget landing screen")]
        public void UserNavigatesToPropDetailsAndBackToLanding()
        {
            try
            {
                test = extent.CreateTest("UserNavigatesToPropDetailsAndBackToLanding").Info("Test Started");
                BudgetSummaryPage budget = new BudgetSummaryPage(BaseTest.driver);
                budget.ClickBudgetSummaryMenu();
                Thread.Sleep(3000);
                String screentitle = budget.NavigateToBudgetDetails();
                Assert.AreEqual("Details", screentitle, "User does not reach to property details screen");
                String landingtitle = budget.NavigateBackToDevelopmentLandingScreen();
                Assert.AreEqual("Development Budget Summary", landingtitle, "User does not reach to budget landing screen");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify user can Search different properties in budget details screen")]
        public void SearchOptionOnBudgetSummaryScreen()
        {
            try
            {
                test = extent.CreateTest("UserNavigatesToPropDetailsAndBackToLanding").Info("Test Started");
                BudgetSummaryPage budget = new BudgetSummaryPage(BaseTest.driver);
                budget.ClickBudgetSummaryMenu();
                Thread.Sleep(3000);
                budget.NavigateToBudgetDetails();
                budget.SearchInPropertyDetails();
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify user can download budget summary report for a job")]
        public void DownloadingBudgetSummaryReport()
        {
            try
            {
                test = extent.CreateTest("UserNavigatesToPropDetailsAndBackToLanding").Info("Test Started");
                BudgetSummaryPage budget = new BudgetSummaryPage(BaseTest.driver);
                budget.ClickBudgetSummaryMenu();
                Thread.Sleep(3000);
                budget.NavigateToBudgetDetails();
                budget.downloadDevBudgetSummary();
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify card labels displayed on development budget screen")]
        public void DevelopmentBudget_VerifyCardLabels()
        {
            try
            {
                String l1 = "Job Code:";
                String l2 = "Property Name:";
                String l3 = "Invoiced Amount:";
                String l4 = "New Budget Amount:";
                String l5 = "Over Budget Amount:";
                test = extent.CreateTest("DevelopmentBudget_VerifyCardLabels").Info("Test Started");
                BudgetSummaryPage budget = new BudgetSummaryPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickBudgetSummaryOption();
                String label1 = budget.CardView_ReturnJobCodelabel();
                Assert.IsTrue(l1==label1, $"Label on screen '{label1}' does not match expected '{l1}'");
                String label2 = budget.CardView_ReturnPropertyNamelabel();
                Assert.IsTrue(l2 == label2, $"Label on screen '{label2}' does not match expected '{l2}'");
                String label3 = budget.CardView_ReturnInvoicedAmountlabel();
                Assert.IsTrue(l3 == label3, $"Label on screen '{label3}' does not match expected '{l3}'");
                String label4 = budget.CardView_ReturnNewBudgetlabel();
                Assert.IsTrue(l4 == label4, $"Label on screen '{label4}' does not match expected '{l4}'");
                String label5 = budget.CardView_ReturnOverBudgetlabel();
                Assert.IsTrue(l5 == label5, $"Label on screen '{label5}' does not match expected '{l5}'");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify list view column labels displayed on development budget screen")]
        public void DevelopmentBudget_VerifyListViewColumnLabels()
        {
            try
            {
                String l1 = "Job Code";
                String l2 = "Job Description";
                String l3 = "Property Name";
                String l4 = "Invoiced Amount";
                String l5 = "New Budget Amount";
                String l6 = "Over Budget Amount";
                test = extent.CreateTest("DevelopmentBudget_VerifyListViewColumnLabels").Info("Test Started");
                BudgetSummaryPage budget = new BudgetSummaryPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickBudgetSummaryOption();
                budget.ChangeToListView();
                String label1 = budget.ListView_ReturnJobCodelabel();
                Assert.IsTrue(l1 == label1, $"Label on screen '{label1}' does not match expected '{l1}'");
                String label2 = budget.ListView_ReturnJobDescriptionlabel();
                Assert.IsTrue(l2 == label2, $"Label on screen '{label2}' does not match expected '{l2}'");
                String label3 = budget.ListView_ReturnPropertyNamelabel();
                Assert.IsTrue(l3 == label3, $"Label on screen '{label3}' does not match expected '{l3}'");
                String label4 = budget.ListView_ReturnInvoicedAmountlabel();
                Assert.IsTrue(l4 == label4, $"Label on screen '{label4}' does not match expected '{l4}'");
                String label5 = budget.ListView_ReturnNewBudgetAmountlabel();
                Assert.IsTrue(l5 == label5, $"Label on screen '{label5}' does not match expected '{l5}'");
                String label6 = budget.ListView_ReturnOverBudgetAmountlabel();
                Assert.IsTrue(l6 == label6, $"Label on screen '{label6}' does not match expected '{l6}'");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
        [Test, Category("Sanity Test")]
        [Description("Verify list view column labels displayed on development budget details screen")]
        public void BudgetDetails_VerifyListViewColumnLabels()
        {
            try
            {
                String l1 = "Category Code";
                String l2 = "Category Description";
                String l3 = "Revised Budget";
                String l4 = "To-Date Spent";
                String l5 = "Over Budget";
                test = extent.CreateTest("BudgetDetails_VerifyListViewColumnLabels").Info("Test Started");
                BudgetSummaryPage budget = new BudgetSummaryPage(BaseTest.driver);
                NavigationMenuPage navigation = new NavigationMenuPage(BaseTest.driver);
                navigation.ClickMainMenu();
                navigation.ClickBudgetSummaryOption();
                budget.NavigateToBudgetDetails();
                String label1 = budget.DetailsScreenListView_ReturnCategoryCodelabel();
                Assert.IsTrue(l1 == label1, $"Label on screen '{label1}' does not match expected '{l1}'");
                String label2 = budget.DetailsScreenListView_ReturnCategoryDescriptionlabel();
                Assert.IsTrue(l2 == label2, $"Label on screen '{label2}' does not match expected '{l2}'");
                String label3 = budget.DetailsScreenListView_ReturnRevisedBudgetlabel();
                Assert.IsTrue(l3 == label3, $"Label on screen '{label3}' does not match expected '{l3}'");
                String label4 = budget.DetailsScreenListView_ReturnToDateSpentlabel();
                Assert.IsTrue(l4 == label4, $"Label on screen '{label4}' does not match expected '{l4}'");
                String label5 = budget.DetailsScreenListView_ReturnOverBudgetlabel();
                Assert.IsTrue(l5 == label5, $"Label on screen '{label5}' does not match expected '{l5}'");

                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
