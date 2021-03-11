using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using RazorEngine.Compilation.ImpromptuInterface.Optimization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InvestmentManagement.PageObjects
{
    class ContingentLiabilityPage
    {
        private IWebDriver driver;
        public ContingentLiabilityPage(IWebDriver driver)
        {
            if (driver != null)
            {
                this.driver = driver;
            }
            else
            {
                Console.WriteLine("driver is null");
            }
        }
        //locators for Contingent liability landing screen
        By MenuIcon = By.XPath("//input[@class='menu_checkbox']");
        //By MaintenanceDropdown = By.XPath("//div[@class='menu']/div[2]/div[2]/div/a");
        By ContingentOption = By.XPath("//div[@class='menu']/div[2]/div[5]/div/a");
        By ContinLandingTitle = By.XPath("//div/div/div[3]/div/div/div/div/div");
        //By AsOfDate = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div[2]/select");
        By DownloadButton = By.XPath("//div[@class='maintenance-card-body']/div/div[3]/button[1]");
        By FilterIcon = By.XPath("//div[@class='maintenance-card-body']/div/div[3]/button[3]");
        By SortByWin = By.XPath("//div[3]/ul/li[2]/div");
        By SearchText = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div/span");
        By SearchInputBox = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div/span/input");
        By SortByOptions = By.XPath("//div[3]/ul/li/div/div/select");
        By Ascending = By.XPath("//div[3]/ul/li[2]/div/label/span");
        By Descending = By.XPath("//div[3]/ul/li[2]/div/label[2]/span");
        By Changeview = By.XPath("//div[@class='maintenance-card-body']/div/div[3]/button[2]");
        By CardView = By.XPath("//div/div/div[3]/div/div/div/div[2]/div[2]/div/div/div/div");
        By ListView = By.XPath("//div/div/div[3]/div/div/div/div[2]/div[2]/div/div/div/div/div/div/div/div");
        By tableAll = By.XPath("//div[@class='rt-table']/div[2]");
        By EntriesIntable = By.XPath("//div[@class='rt-table']/div[2]/div/div/div");
        By cardBody = By.XPath("//div/div/div[3]/div/div/div/div[2]/div[2]/div/div/div/div");
        By PropertyDetails = By.XPath("//div/div/div[3]/div/div/div/div/div[2]");
        By BackTolanding = By.XPath("//div/div/div[3]/div/div/div/div/div");
        By NumOfCards = By.XPath("//div/div/div[3]/div/div/div/div[2]/div[2]/div");

        //Locators for contingent property details screen
        By GeneralInfo = By.XPath("//label[contains(text(),'General Information')]");
        By Contingentlia = By.XPath("//label[contains(text(),'Schedule of Contingent Liabilities')]");
        By GenMini = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div[2]/div/div/div/div/div/div[2]");
        By ScheMini = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div[2]/div/div/div/div/div[3]/div[3]");
        //By EditSche = By.XPath("//*[name()='svg']/*[local-name()='path']");
        By EditSche = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div[2]/div[2]/div/div/div/div[3]/div[2]");
        By PropertyName = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div[2]/div/div/div/div[2]/div[2]");
        By Save = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div[2]/div[2]/div/div/div/div[3]/div[2]");
        By SRPPercent = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div/span");
        By SRPPercentValue = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div/span/input");
        By NetWorthCove = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div[2]/div[2]/div/div/div[2]/div[3]/div[2]/div/span/input");
        By NetWorthCoveValue = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div[2]/div[2]/div/div/div[2]/div[3]/div[2]/div/span");
        By Liquididty = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div[2]/div[2]/div/div/div[2]/div[4]/div[2]/div/span/input");
        By Liquididtyvalue = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div[2]/div[2]/div/div/div[2]/div[4]/div[2]/div/span");
        By CongSuggestions = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div[2]/div[2]/div/div/div[2]/div[5]/div[2]/div/span/div/div/div/div[2]/div[2]");
        By CongSelected = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div[2]/div[2]/div/div/div[2]/div[5]/div[2]/div/span/div/div/div/div/button");
        By TypeToSearch = By.XPath("//div/div/div[3]/div/div/div/div[2]/div/div[2]/div[2]/div/div/div[2]/div[5]/div[2]/div/span/div/div/div/div[2]/div/input");

        //Locators to access common as of date option
        By AsOfDate = By.XPath("//input[@id='as-of-date-box-header']");

        //Locators for card field labels
        By MarketLabel = By.XPath("//div[@class='card-main-body']/div[2]/div[1]/div/span");
        By ProductTypeLabel = By.XPath("//div[@class='card-main-body']/div[2]/div[2]/div/span[1]");
        By SRPOwnerShipLabel = By.XPath("//div[@class='card-main-body']/div[2]/div[3]/div/span[1]");
        By TotalLoanCommitmentLabel = By.XPath("//div[@class='card-main-body']/div[2]/div[5]/div/span[1]");
        By NetWorthCovenantLabel = By.XPath("//div[@class='card-main-body']/div[2]/div[6]/div/span[1]");
        By LiquididtyCovenantLabel = By.XPath("//div[@class='card-main-body']/div[2]/div[7]/div/span[1]");

        //Locators for list view column labels
        By lv_PropertyNameLabel = By.XPath("//div[@class='rt-tr']/div[1]/div/span");
        By lv_MarketLabel = By.XPath("//div[@class='rt-tr']/div[2]/div/span");
        By lv_ProductTypeLabel = By.XPath("//div[@class='rt-tr']/div[3]/div/span");
        By lv_SRPOwnerShipLabel = By.XPath("//div[@class='rt-tr']/div[4]/div/span");
        By lv_TotalLoanCommitmentLabel = By.XPath("//div[@class='rt-tr']/div[5]/div/span");
        By lv_NetWorthCovenantLabel = By.XPath("//div[@class='rt-tr']/div[6]/div/span");
        By lv_LiquididtyCovenantLabel = By.XPath("//div[@class='rt-tr']/div[7]/div/span");

        //Locators for labels in general info
        By GI_YardiPropCode = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[1]/div/div/label");
        By GI_PropertyName = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[2]/div/div/label");
        By GI_AcquisitionDate = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[3]/div/div/label");
        By GI_Dispositiondate = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[4]/div/div/label");
        By GI_Market = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[5]/div/div/label");
        By GI_ProductType = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[6]/div/div/label");
        By GI_Dealtype = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[7]/div/div/label");
        By GI_SourcingMethod = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[8]/div/div/label");
        By GI_Coinvestor = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[9]/div/div/label");
        By GI_Lender = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[10]/div/div/label");
        By GI_RSF = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[11]/div/div/label");
        By GI_PurchasePrice = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[12]/div/div/label");
        By GI_SoldPrice = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[13]/div/div/label");
        By GI_HoldDays = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[14]/div/div/label");
        By GI_HoldMonths = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[15]/div/div/label");
        By GI_Status = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[16]/div/div/label");

        //Locators for labels in contingent Liability
        By SC_SRPOwnership = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div/div/div[2]/div[1]/div/div/label");
        By SC_LoanCommitment = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div/div/div[2]/div[2]/div/div/label");
        By SC_NetWorthCovenant = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div/div/div[2]/div[3]/div/div/label");
        By SC_LiquidityCovenant = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div/div/div[2]/div[4]/div/div/label");
        By SC_ContingentLiability = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div/div/div[2]/div[5]/div/div/label");

        //Locators 
        By NoChanges = By.XPath("//div[@class='mainContainer']/div/div/div/div/div/div[2]");

        public String ClickContingentOption()
        {
            Thread.Sleep(3000);
            driver.FindElement(MenuIcon).Click();
            Thread.Sleep(2000);
            driver.FindElement(ContingentOption).Click();
            Thread.Sleep(5000);
            String screentitle = driver.FindElement(ContinLandingTitle).Text;
            return screentitle;
        }
        public void DownloadExcel()
        {
            driver.FindElement(DownloadButton).Click();
        }
        public void SelectAsOfDate()
        {
            driver.FindElement(AsOfDate).Click();
            IList<IWebElement> asofdate = driver.FindElements(AsOfDate);
            int total = asofdate.Count;
            for (int i = 0; i < total; i++)
            {
                Thread.Sleep(2000);
                driver.FindElement(AsOfDate).Click();
                driver.FindElement(DownloadButton).Click();
                driver.FindElement(AsOfDate).Click();
                Thread.Sleep(2000);
            }
        }
        public bool ChangeToListView()
        {
            var elementToClick = driver.FindElement(Changeview);
            Actions action = new Actions(driver);
            action.Click(elementToClick).Build().Perform();
            Thread.Sleep(3000);
            bool lview = driver.FindElement(ListView).Displayed;
            return lview;
        }
        public bool ChangeToCardView()
        {
            var elementToClick = driver.FindElement(Changeview);
            Actions action = new Actions(driver);
            action.Click(elementToClick).Build().Perform();
            Thread.Sleep(3000);
            bool cview = driver.FindElement(CardView).Displayed;
            return cview;
        }
        public int RowsBeforeSearch()
        {
            //IWebElement table1 = driver.FindElement(NumOfCards);
            IList<IWebElement> listOfRows = driver.FindElements(NumOfCards);
            int NumofRowsbefore = listOfRows.Count;
            return NumofRowsbefore;
        }
        public int RowsafterSearchForProperty()
        {
            //Code to see total rows present in the table            
            driver.FindElement(SearchInputBox).SendKeys("Stream");
            driver.FindElement(SearchInputBox).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            IList<IWebElement> listOfRows1 = driver.FindElements(NumOfCards);
            int NumofRowsafter = listOfRows1.Count;
            return NumofRowsafter;
        }
        public void TestSortBy()
        {
            driver.FindElement(FilterIcon).Click();
            SelectElement sortby = new SelectElement(driver.FindElement(SortByOptions));
            for (int i = 1; i < 7; i++)
            {
                sortby.SelectByIndex(i);
                driver.FindElement(Descending).Click();
                driver.FindElement(Ascending).Click();
                Thread.Sleep(1000);
            }
        }
        public Boolean SelectDescending()
        {
            driver.FindElement(Descending).Click();
            Boolean desc = driver.FindElement(Descending).Enabled;
            return desc;
        }
        public Boolean SelectAscending()
        {
            driver.FindElement(Ascending).Click();
            Boolean asce = driver.FindElement(Ascending).Enabled;
            return asce;
        }
        public Boolean FilterDisabled()
        {
            driver.FindElement(FilterIcon).Click();
            Boolean res = driver.FindElement(SortByWin).Displayed;
            return res;
        }
        public String NavigationToPropDetails()
        {
            Thread.Sleep(1000);
            driver.FindElement(cardBody).Click();
            Thread.Sleep(1000);
            String title = driver.FindElement(PropertyDetails).Text;
            return title;

        }
        public String BackToLandingScreen()
        {
            driver.FindElement(BackTolanding).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(SearchText));
            String screentitle = driver.FindElement(ContinLandingTitle).Text;
            return screentitle;
        }
        public String SendGeneralInfoTitle()
        {
            String GenInfo = driver.FindElement(GeneralInfo).Text;
            return GenInfo;
        }
        public String SendScheduleOfContingenttitle()
        {
            String title = driver.FindElement(Contingentlia).Text;
            return title;
        }
        public Boolean ClickMinimizeMaximizeGenInfo()
        {
            driver.FindElement(GenMini).Click();
            Thread.Sleep(2000);
            driver.FindElement(GenMini).Click();
            Thread.Sleep(2000);
            Boolean res = driver.FindElement(PropertyName).Displayed;
            return res;
        }
        public Boolean ClickMinimizeMaximizeScheCon()
        {
            driver.FindElement(ScheMini).Click();
            Thread.Sleep(2000);
            driver.FindElement(ScheMini).Click();
            Thread.Sleep(2000);
            Boolean res = driver.FindElement(PropertyName).Displayed;
            return res;
        }
        public void ClickEditOnSchedule()
        {
            try
            {
                var elementToClick = driver.FindElement(EditSche);
                Actions action = new Actions(driver);
                action.Click(elementToClick).Build().Perform();
            }
            //action.DoubleClick(elementToClick).Build().Perform();
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        public Boolean UpdateSRPPercent()
        {
            driver.FindElement(SRPPercentValue).Click();
            driver.FindElement(SRPPercentValue).Clear();
            driver.FindElement(SRPPercentValue).SendKeys("2");
            driver.FindElement(Save).Click();
            Thread.Sleep(1000);
            String percent = driver.FindElement(SRPPercent).Text;
            //int actvalue = int.Parse(percent);
            if (percent == "2.00%")
            {
                return true;
            }
            else
                return false;
        }
        public Boolean UpdateNetWothCovenant()
        {
            driver.FindElement(NetWorthCove).Click();
            driver.FindElement(NetWorthCove).Clear();
            driver.FindElement(NetWorthCove).SendKeys("5000");
            driver.FindElement(Save).Click();
            String net = driver.FindElement(NetWorthCoveValue).Text;
            //int actvalue = int.Parse(net);
            if (net == "$5,000")
            {
                return true;
            }
            else
                return false;
        }
        public Boolean UpdateLiquidityCovenant()
        {
            driver.FindElement(Liquididty).Click();
            driver.FindElement(Liquididty).Clear();
            driver.FindElement(Liquididty).SendKeys("5000");
            driver.FindElement(Save).Click();
            Thread.Sleep(5000);
            String net = driver.FindElement(Liquididtyvalue).Text;
            //int actvalue = int.Parse(net);
            if (net == "$5,000")
            {
                return true;
            }
            else
                return false;
        }
        public Boolean UpdateContigentLiabilityOptions()
        {
            IList<IWebElement> listOfRows = driver.FindElements(CongSelected);
            int total = listOfRows.Count;
            for (int i = 0; i < total; i++)
            {
                driver.FindElement(CongSelected).Click();
            }
            driver.FindElement(TypeToSearch).Click();
            IList<IWebElement> listOfRows1 = driver.FindElements(CongSuggestions);
            int total1 = listOfRows.Count;
            for (int i = 0; i < total1; i++)
            {
                driver.FindElement(CongSuggestions).Click();
            }
            driver.FindElement(Save).Click();
            int selected = listOfRows.Count;
            if (selected == total1)
            {
                return true;
            }
            else { return false; }
        }
        public String CardsLabel_ReturnMarketLabel()
        {
            String label = driver.FindElement(MarketLabel).Text;
            return label;
        }
        public String CardsLabel_ReturnProductTypeLabel()
        {
            String label = driver.FindElement(ProductTypeLabel).Text;
            return label;
        }
        public String CardsLabel_ReturnSRPOwnershipLabel()
        {
            String label = driver.FindElement(SRPOwnerShipLabel).Text;
            return label;
        }
        public String CardsLabel_ReturnTotalLoanCommitmentLabel()
        {
            String label = driver.FindElement(TotalLoanCommitmentLabel).Text;
            return label;
        }
        public String CardsLabel_ReturnNetCovenantLabel()
        {
            String label = driver.FindElement(NetWorthCovenantLabel).Text;
            return label;
        }
        public String CardsLabel_ReturnLiquidCovenantLabel()
        {
            String label = driver.FindElement(LiquididtyCovenantLabel).Text;
            return label;
        }
        public String ListView_ReturnPropertyNameLabel()
        {
            String label = driver.FindElement(lv_PropertyNameLabel).Text;
            return label;
        }
        public String ListView_ReturnMarketLabel()
        {
            String label = driver.FindElement(lv_MarketLabel).Text;
            return label;
        }
        public String ListView_ReturnProductTypeLabel()
        {
            String label = driver.FindElement(lv_ProductTypeLabel).Text;
            return label;
        }
        public String ListView_ReturnSRPOwnershipLabel()
        {
            String label = driver.FindElement(lv_SRPOwnerShipLabel).Text;
            return label;
        }
        public String ListView_ReturnTotalLoanCommitmentLabel()
        {
            String label = driver.FindElement(lv_TotalLoanCommitmentLabel).Text;
            return label;
        }
        public String ListView_ReturnNetCovenantLabel()
        {
            String label = driver.FindElement(lv_NetWorthCovenantLabel).Text;
            return label;
        }
        public String ListView_ReturnLiquidityCovenantLabel()
        {
            String label = driver.FindElement(lv_LiquididtyCovenantLabel).Text;
            return label;
        }
        public String GeneralInformation_ReturnYardiCodeLabel()
        {
            String fieldlabel = driver.FindElement(GI_YardiPropCode).Text;
            return fieldlabel;
        }
        public String GeneralInformation_ReturnPropertyNameLabel()
        {
            String fieldlabel = driver.FindElement(GI_PropertyName).Text;
            return fieldlabel;
        }
        public String GeneralInformation_ReturnAcquisitionDateLabel()
        {
            String fieldlabel = driver.FindElement(GI_AcquisitionDate).Text;
            return fieldlabel;
        }
        public String GeneralInformation_ReturnDispositionDateLabel()
        {
            String fieldlabel = driver.FindElement(GI_Dispositiondate).Text;
            return fieldlabel;
        }
        public String GeneralInformation_ReturnMarketLabel()
        {
            String fieldlabel = driver.FindElement(GI_Market).Text;
            return fieldlabel;
        }
        public String GeneralInformation_ReturnProductTypeLabel()
        {
            String fieldlabel = driver.FindElement(GI_ProductType).Text;
            return fieldlabel;
        }
        public String GeneralInformation_ReturnDealTypeLabel()
        {
            String fieldlabel = driver.FindElement(GI_Dealtype).Text;
            return fieldlabel;
        }
        public String GeneralInformation_ReturnSourcingMethodLabel()
        {
            String fieldlabel = driver.FindElement(GI_SourcingMethod).Text;
            return fieldlabel;
        }
        public String GeneralInformation_ReturnCoinvestorLabel()
        {
            String fieldlabel = driver.FindElement(GI_Coinvestor).Text;
            return fieldlabel;
        }
        public String GeneralInformation_ReturnLenderLabel()
        {
            String fieldlabel = driver.FindElement(GI_Lender).Text;
            return fieldlabel;
        }
        public String GeneralInformation_ReturnRSFLabel()
        {
            String fieldlabel = driver.FindElement(GI_RSF).Text;
            return fieldlabel;
        }
        public String GeneralInformation_ReturnPurchasePriceLabel()
        {
            String fieldlabel = driver.FindElement(GI_PurchasePrice).Text;
            return fieldlabel;
        }
        public String GeneralInformation_ReturnSoldPriceLabel()
        {
            String fieldlabel = driver.FindElement(GI_SoldPrice).Text;
            return fieldlabel;
        }
        public String GeneralInformation_ReturnHoldDaysLabel()
        {
            String fieldlabel = driver.FindElement(GI_HoldDays).Text;
            return fieldlabel;
        }
        public String GeneralInformation_ReturnHoldMonthsLabel()
        {
            String fieldlabel = driver.FindElement(GI_HoldMonths).Text;
            return fieldlabel;
        }
        public String GeneralInformation_ReturnStatusLabel()
        {
            String fieldlabel = driver.FindElement(GI_Status).Text;
            return fieldlabel;
        }
        public String ContingentLiability_ReturnSRPPercentLabel()
        {
            String fieldlabel = driver.FindElement(SC_SRPOwnership).Text;
            return fieldlabel;
        }
        public String ContingentLiability_ReturnLoanCommitmentLabel()
        {
            String fieldlabel = driver.FindElement(SC_LoanCommitment).Text;
            return fieldlabel;
        }
        public String ContingentLiability_ReturnNetworthCovenantLabel()
        {
            String fieldlabel = driver.FindElement(SC_NetWorthCovenant).Text;
            return fieldlabel;
        }
        public String ContingentLiability_ReturnLiquidityCovenantLabel()
        {
            String fieldlabel = driver.FindElement(SC_LiquidityCovenant).Text;
            return fieldlabel;
        }
        public String ContingentLiability_ReturnContingentLiabilityLabel()
        {
            String fieldlabel = driver.FindElement(SC_ContingentLiability).Text;
            return fieldlabel;
        }
        public String VerifyErrorNoChangesmade()
        {
            driver.FindElement(EditSche).Click();
            driver.FindElement(EditSche).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(NoChanges));
            var elementToClick = driver.FindElement(NoChanges);
            String alertMessage= elementToClick.Text;
            return alertMessage;
        }
        public Boolean ClearInputFields()
        {
            driver.FindElement(EditSche).Click();
            driver.FindElement(SRPPercent).Clear();
            driver.FindElement(NetWorthCove).Clear();
            driver.FindElement(Liquididty).Clear();
            driver.FindElement(Save).Click();
            String srp = driver.FindElement(SRPPercentValue).Text;
            String netC = driver.FindElement(NetWorthCoveValue).Text;
            String liqui = driver.FindElement(Liquididtyvalue).Text;
            if (srp == "-"&& netC == "-"&& liqui == "-")
            {
                return true;
            }
            return false;
        }      

    }
}

