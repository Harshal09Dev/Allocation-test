using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InvestmentManagement.PageObjects
{
    class AssetSummaryPage
    {
        private IWebDriver driver;
        public AssetSummaryPage(IWebDriver driver)
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
        //Logging In Locators
        By LoginUN = By.XPath("//input[@id='i0116']");
        By Next = By.XPath("//input[@id='idSIButton9']");
        By Password = By.XPath("//input[@id='i0118']");
        By SignIn = By.XPath("//input[@id='idSIButton9']");

        By asOfDate = By.XPath("//input[@id='as-of-date-box-header']");

        //Common menu locators
        By menu = By.XPath("//input[@class='menu_checkbox']");
        By fundsdropdwon = By.XPath("//div/div/div[2]/div/div[5]/div/div[2]/div/div/a");
        By fundAdrop = By.XPath("//div/div/div[2]/div/div[5]/div/div[2]/div/div[2]/div/div/a");
        By fundBdrop = By.XPath("//div/div/div[2]/div/div[5]/div/div[2]/div/div[2]/div[2]/div/a");

        //Funds Tab and asset, debt buttons
        By FundATab = By.XPath("//div/div/div[3]/div/div/button");
        By FundBTab = By.XPath("//div/div/div[3]/div/div[2]/button");
        By PerformanceSummary = By.XPath("//div[@class='MuiTabs-flexContainer']/button[1]/span");
        By PortfolioSummary = By.XPath("//div[@class='MuiTabs-flexContainer']/button[2]/span");
        By DebtSummary = By.XPath("//div[@class='MuiTabs-flexContainer']/button[3]/span");
        By AssetSummary = By.XPath("//div/div/div/div[2]/header/div/div/div/button[2]/span");

        //Performance highlights locators
        By TotalCommitment = By.XPath("//div[@class='tabBoxContainer']/div/div/div[2]/div[1]/div/div[2]");
        By Contributions = By.XPath("//div[@class='tabBoxContainer']/div/div/div[2]/div[2]/div/div[2]");
        By Distributions = By.XPath("//div[@class='tabBoxContainer']/div/div/div[2]/div[3]/div/div[2]");
        By UnfundedCommitment = By.XPath("//div[@class='tabBoxContainer']/div/div/div[2]/div[4]/div/div[2]");
        By AccumulatedPref = By.XPath("//div[@class='tabBoxContainer']/div/div/div[2]/div[5]/div/div[2]");
        By CuurentCostOfCapital = By.XPath("//div[@class='tabBoxContainer']/div/div/div[2]/div[6]/div/div[2]");
        By CapitalAmount = By.XPath("//div[@id='multiLineChartCt']");
        By ContriDistri = By.XPath("//div[@id='stackedBarChartCt']");

        //Asset Summary and Debt Summary landing screen contents
        By SearchInput = By.XPath("//div[@id='stickytypeheader']/div/div/div/span[2]/input");
        By Download = By.XPath("//button[@id='menu-button--menu--1']");
        By DownladFundA = By.XPath("//div[@id='menu--1']/div[1]");
        By DownloadFundB = By.XPath("//div[@id='menu--1']/div[2]");
        By ChangeView = By.XPath("//div[@id='stickytypeheader']/div/div/div[2]/button");
        By Filter = By.XPath("//div[@id='stickytypeheader']/div/div/div[2]/button[2]");
        By FilterDropdown = By.XPath("//div[3]/ul/li/div/div[2]");
        By FilterOptions = By.XPath("//div[3]/ul/li/div/div/select/option");
        By Ascending = By.XPath("//div[3]/ul/li[2]/div/label[1]/span");
        By Descending = By.XPath("//div[3]/ul/li[2]/div/label[2]/span");
        By NumOfcards = By.XPath("//div[@id='stickytypeheader']/div/div[2]/div");
        By CardBody = By.XPath("//div[@id='stickytypeheader']/div/div[2]/div");
        By ListView = By.XPath("//div[@id='stickytypeheader']/div/div[2]/div/div/div/div/div/div[1]/div[1]/div");
        By PropDetails_Asset = By.XPath("//div/div/div[3]/div/div/div/div/div[1]");

        //Locators from card in portfolio summary
        By Card_Leased = By.XPath("//div[@class='card-main-body']/div[2]/div[1]/div/span");
        By Card_CurrentDebt= By.XPath("//div[@class='card-main-body']/div[2]/div[2]/div/span");
        By Card_Contributions= By.XPath("//div[@class='card-main-body']/div[2]/div[3]/div/span");
        By Card_Distribtuions= By.XPath("//div[@class='card-main-body']/div[2]/div[4]/div/span");
        By Card_TotalBasis= By.XPath("//div[@class='card-main-body']/div[2]/div[5]/div/span");
        By Card_TotalBasisPsf = By.XPath("//div[@class='card-main-body']/div[2]/div[6]/div/span");

        //Locators from list view in portfolio summary
        By List_PropertyName = By.XPath("//div[@class='rt-thead -header']/div/div[1]/div/span");
        By List_Acquisition = By.XPath("//div[@class='rt-thead -header']/div/div[2]/div/span");
        By List_LeasedPercent = By.XPath("//div[@class='rt-thead -header']/div/div[3]/div/span");
        By List_CurrentDebt = By.XPath("//div[@class='rt-thead -header']/div/div[4]/div/span");
        By List_CurrentLeve = By.XPath("//div[@class='rt-thead -header']/div/div[5]/div/span");
        By List_Basis= By.XPath("//div[@class='rt-thead -header']/div/div[6]/div/span");
        By List_BasisPSF = By.XPath("//div[@class='rt-thead -header']/div/div[7]/div/span");
        By List_NOI= By.XPath("//div[@class='rt-thead -header']/div/div[8]/div/span");
        By List_CashONCash = By.XPath("//div[@class='rt-thead -header']/div/div[9]/div/span");
        By List_COCYield= By.XPath("//div[@class='rt-thead -header']/div/div[10]/div/span");
        By List_Distributions= By.XPath("//div[@class='rt-thead -header']/div/div[11]/div/span");
        By List_NetEquity = By.XPath("//div[@class='rt-thead -header']/div/div[12]/div/span");
        By List_NetEquityPsf = By.XPath("//div[@class='rt-thead -header']/div/div[13]/div/span");
        By List_Contributions= By.XPath("//div[@class='rt-thead -header']/div/div[14]/div/span");


        public Boolean UserLandsOnFundPortfolioSummary()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(PortfolioSummary));
            var funda = driver.FindElement(PortfolioSummary).Displayed;
            return funda;
        }
        public void selectPreviousMonth()
        {
            driver.FindElement(asOfDate).Click();
            IList list = driver.FindElements(asOfDate);
        }
        public void ClickPerformanceSummary()
        {
            driver.FindElement(PerformanceSummary).Click();
        }
        public void ClickDebtSummary()
        {
            driver.FindElement(DebtSummary).Click();
        }
        public String ReturnPerformanceSummaryTablabel()
        {
            driver.FindElement(PerformanceSummary).Click();
            String label = driver.FindElement(PerformanceSummary).Text;
            return label;
        }
        public String ReturnPortfolioSummaryTablabel()
        {
            String label = driver.FindElement(PortfolioSummary).Text;
            return label;
        }
        public String ReturnDebtSummaryTablabel()
        {
            driver.FindElement(DebtSummary).Click();
            String label = driver.FindElement(DebtSummary).Text;
            return label;
        }
        public String GetTotalCommitmentTitle()
        {
            Thread.Sleep(1000);
            var totalcommitment = driver.FindElement(TotalCommitment).Text;
            return totalcommitment;
        }
        public String GetContributionsTitle()
        {
            Thread.Sleep(1000);
            var contributions = driver.FindElement(Contributions).Text;
            return contributions;
        }
        public String GetDistributionsTitle()
        {
            Thread.Sleep(1000);
            var distributions = driver.FindElement(Distributions).Text;
            return distributions;
        }
        public String GetUnfundedCommitmentTitle()
        {
            Thread.Sleep(1000);
            var unfundedComm = driver.FindElement(UnfundedCommitment).Text;
            return unfundedComm;
        }
        public String GetAccumulatedPrefTitle()
        {
            Thread.Sleep(1000);
            var var = driver.FindElement(AccumulatedPref).Text;
            return var;
        }
        public String GetCurrentCostOfCapitalTitle()
        {
            Thread.Sleep(1000);
            var var = driver.FindElement(CuurentCostOfCapital).Text;
            return var;
        }
        public void DownloadReportForFunds()
        {
            driver.FindElement(Download).Click();
            driver.FindElement(DownladFundA).Click();
            Thread.Sleep(2000);
            driver.FindElement(Download).Click();
            driver.FindElement(DownloadFundB).Click();
            Thread.Sleep(2000);
        }
        public void ClickFundATab()
        {
            driver.FindElement(FundATab).Click();
        }
        public void ClickFundBTab()
        {
            driver.FindElement(FundBTab).Click();
        }
        public void ClickAssetSummary()
        {
            driver.FindElement(menu).Click();
            driver.FindElement(AssetSummary).Click();
        }
        public void SelectFundsFromDropdwon()
        {
            driver.FindElement(menu).Click();
            driver.FindElement(fundAdrop).Click();
        }
        public int RowsBeforeSearch()
        {
            //IWebElement table1 = driver.FindElement(NumOfCards);
            IList<IWebElement> listOfRows = driver.FindElements(NumOfcards);
            int NumofRowsbefore = listOfRows.Count;
            return NumofRowsbefore;
        }
        public int RowsafterSearchForProperty()
        {
            //Code to see total rows present in the table            
            driver.FindElement(SearchInput).SendKeys("SRP");
            driver.FindElement(SearchInput).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            IList<IWebElement> listOfRows1 = driver.FindElements(NumOfcards);
            int NumofRowsafter = listOfRows1.Count;
            return NumofRowsafter;
        }
        public bool ChangeToListView()
        {
            var elementToClick = driver.FindElement(ChangeView);
            Actions action = new Actions(driver);
            action.Click(elementToClick).Build().Perform();
            Thread.Sleep(3000);
            bool lview = driver.FindElement(ListView).Displayed;
            return lview;
        }
        public bool ChangeToCardView()
        {
            var elementToClick = driver.FindElement(ChangeView);
            Actions action = new Actions(driver);
            action.Click(elementToClick).Build().Perform();
            Thread.Sleep(3000);
            bool cview = driver.FindElement(CardBody).Displayed;
            return cview;
        }
        public void ClickOptionsInSortBy()
        {
            driver.FindElement(Filter).Click();
            driver.FindElement(FilterDropdown).Click();
            SelectElement sortby = new SelectElement(driver.FindElement(FilterOptions));
            IList<IWebElement> ElementCount = sortby.Options;
            int total = ElementCount.Count;
            for (int i = 1; i < total; i++)
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
        public string NavigateToPropertyDetails()
        {
            int cards= driver.FindElements(CardBody).Count();
            if (cards < 1) 
            { 
            
            }
            driver.FindElement(CardBody).Click();
            String title = driver.FindElement(PropDetails_Asset).Text;
            return title;
        }
        public Boolean NavigateToAssetSummaryBack()
        {
            driver.FindElement(PropDetails_Asset).Click();
            Boolean res = driver.FindElement(AssetSummary).Displayed;
            return res;
        }
        public String CardView_ReturnLeasedPercentLabel()
        {
            String label=driver.FindElement(Card_Leased).Text;
            return label;
        }
        public String CardView_ReturnCurrentDebtLabel()
        {
            String label = driver.FindElement(Card_CurrentDebt).Text;
            return label;
        }
        public String CardView_ReturnDistributionslabel()
        {
            String label = driver.FindElement(Card_Distribtuions).Text;
            return label;
        }
        public String CardView_ReturnContributionsLabel()
        {
            String label = driver.FindElement(Card_Contributions).Text;
            return label;
        }
        public String CardView_ReturnTotalBasisLabel()
        {
            String label = driver.FindElement(Card_TotalBasis).Text;
            return label;
        }
        public String CardView_ReturnTotalBasisPSFLabel()
        {
            String label = driver.FindElement(Card_TotalBasisPsf).Text;
            return label;
        }
        public String ListView_ReturnPropertyNamelabel()
        {
            String label = driver.FindElement(List_PropertyName).Text;
            return label;
        }
        public String ListView_ReturnAcquisitionlabel()
        {
            String label = driver.FindElement(List_Acquisition).Text;
            return label;
        }
        public String ListView_ReturnPercentLeasedlabel()
        {
            String label = driver.FindElement(List_LeasedPercent).Text;
            return label;
        }
        public String ListView_ReturnCurrentDebtlabel()
        {
            String label = driver.FindElement(List_CurrentDebt).Text;
            return label;
        }
        public String ListView_ReturnCurrentLeveragelabel()
        {
            String label = driver.FindElement(List_CurrentLeve).Text;
            return label;
        }
        public String ListView_ReturnBasislabel()
        {
            String label = driver.FindElement(List_Basis).Text;
            return label;
        }
        public String ListView_ReturnBasisPSFlabel()
        {
            String label = driver.FindElement(List_BasisPSF).Text;
            return label;
        }
        public String ListView_ReturnNOIlabel()
        {
            String label = driver.FindElement(List_NOI).Text;
            return label;
        }
        public String ListView_ReturnCashOnCashlabel()
        {
            String label = driver.FindElement(List_CashONCash).Text;
            return label;
        }
        public String ListView_ReturnCOCYieldlabel()
        {
            String label = driver.FindElement(List_COCYield).Text;
            return label;
        }
        public String ListView_ReturnDistributionslabel()
        {
            String label = driver.FindElement(List_Distributions).Text;
            return label;
        }
        public String ListView_ReturnNetEquitylabel()
        {
            String label = driver.FindElement(List_NetEquity).Text;
            return label;
        }
        public String ListView_ReturnNetEquityPSFlabel()
        {
            String label = driver.FindElement(List_NetEquityPsf).Text;
            return label;
        }
        public String ListView_ReturnContributionslabel()
        {
            String label = driver.FindElement(List_Contributions).Text;
            return label;
        }
    }
}
