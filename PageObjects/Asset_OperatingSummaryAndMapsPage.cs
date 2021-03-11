using OpenQA.Selenium;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UI_InvestmentMangement.PageObjects
{
    class Asset_OperatingSummaryAndMapsPage
    {
        private IWebDriver driver;
        public Asset_OperatingSummaryAndMapsPage(IWebDriver driver)
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
        //Locators for Map section
        By PropertyName = By.XPath("//div[@class='gm-style-iw gm-style-iw-c']/div/div/div/div[1]");
        By MapLink = By.XPath("//div[@class='gm-style-iw gm-style-iw-c']/div/div/div/div[4]/a");
        By OperatingSumTab = By.XPath("//div[@class='property_main_container']/div[3]/div[1]/div/div/button[3]/div");
        By MapTab = By.XPath("//div[@class='property_main_container']/div[3]/div[1]/div/div/button[4]/div");
        By propSelected = By.XPath("//div[@class='property_main_container']/div/div/div/div/span[1]");

        //Locators for KPI Section
        By SliderX = By.XPath("//div[@class='tab-workspace']/div/div/div/div[2]");
        By OperatingTable = By.XPath("//div[@class='tab-workspace']/div/div/div/div[3]");
        By occupancyLabel = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div[2]/div[2]/div/div/label");
        By inPlaceLabel = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div[2]/div[3]/div/div/label");
        By yOCLabel = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div[2]/div[4]/div/div/label");
        By cashOnCashLabel = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div[2]/div[5]/div/div/label");
        By debtYeildLabel = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div[2]/div[6]/div/div/label");
        By dscrLabel = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div[2]/div[6]/div/div/label");

        By occupancyActual = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div[2]/div[2]/div[2]/div/div/span[1]");
        By inPlaceActual = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div[2]/div[3]/div[2]/div/div/span[1]");
        By yOCActual = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div[2]/div[4]/div[2]/div/div/span[1]");
        By cashOnCashActual = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div[2]/div[5]/div[2]/div/div/span[1]");
        By debtYeildActual = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div[2]/div[6]/div[2]/div/div/span[1]");
        By dscrActual = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div[2]/div[7]/div[2]/div/div/span[1]");

        By CurrentLeasedUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[11]/div[2]/div/div/span");
        By BuildingNRAUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[7]/div[2]/div/div/span");

        //"//div[@class='tab-workspace']/div/div/div/div[4]/div/div[2]/div[2]/div[2]/div/div/span[1]"
        By KPIHeaderActual = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div[2]/div[2]/div[2]/div/div/span[1]");
        By KPIHeaderBudget = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div[2]/div[2]/div[2]/div/div/span[2]");
        By KPIHeaderProforma = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div[2]/div[2]/div[2]/div/div/span[3]");

        //Locators for radio buttons
        By monthLyLabel = By.XPath("//div[@class='slider-radio-group']/label[1]");
        By YTDLabel = By.XPath("//div[@class='slider-radio-group']/label[2]");
        By yearlyLabel = By.XPath("//div[@class='slider-radio-group']/label[3]");
        //Locators for operating summary header
        By OpColumnLabel1 = By.XPath("//div[@class='tab-workspace']/div/div/div/div[3]/div/div[2]/div/div/div/div/div[2]/div[1]/label");
        By OpColumnLabel2 = By.XPath("//div[@class='tab-workspace']/div/div/div/div[3]/div/div[2]/div/div/div/div/div[2]/div[2]/label");
        By OpColumnLabel3 = By.XPath("//div[@class='tab-workspace']/div/div/div/div[3]/div/div[2]/div/div/div/div/div[2]/div[3]/label");
        //locators for operating summary minimize and maximize

        By Min_Operating = By.XPath("//div[@class='tab-workspace']/div/div/div/div[3]/div/div/div[3]/div[4]");
        By Min_KPI = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div/div[3]/div[2]");

        //Operating Summary
        By NOIValue = By.XPath("//div[@class='slideTableData']/div[4]/div[2]/div/div/span");
        By DebtTotal = By.XPath("//div[@class='slideTableData']/div[15]/div[2]/div/div/span");

        //Table headers
        By title_KPI = By.XPath("//div[@class='tab-workspace']/div/div/div/div[4]/div/div/div[2]/div/label");
        By title_Operating = By.XPath("//div[@class='tab-workspace']/div/div/div/div[3]/div/div/div[2]/div/label");
        By KPI_AsOfDate = By.XPath("//span[@class='extra-info-toggel']");
        By loanBalanceValue = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[2]/div[2]/div/div/span");
        By BasisDebtTab = By.XPath("//div[@class='property_main_container']/div[3]/div[1]/div/div/button[2]/div");
        By netCapitaValue = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[9]/div[2]/div/div/span");
        By fundEquityValue = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[3]/div[2]/div/div/span");
        By streamEquityValue = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[4]/div[2]/div/div/span");
        By GeneralTab = By.XPath("//div[@class='property_main_container']/div[3]/div[1]/div/div/button[1]/div");

        public void clickMapsTab()
        {
            driver.FindElement(MapTab).Click();
        }
        public String VerifyPropertyNameOnMapScreen()
        {
            String propNameOnMap = driver.FindElement(PropertyName).Text;
            return propNameOnMap;
        }
        public Boolean NavigateToViewInGoogleMaps()
        {
            driver.FindElement(MapLink).Click();
            var browserTabs = driver.WindowHandles;
            driver.SwitchTo().Window(browserTabs[1]);
            String mapURL = driver.Url;
            driver.Close();
            driver.SwitchTo().Window(browserTabs[0]);
            if (mapURL.Contains("en-US"))
            {
                return true;
            }
            return false;
        }
        public String ReturnCurrentPropertySelected()
        {
            String Propselect = driver.FindElement(propSelected).Text;
            return Propselect;
        }
        public String KPI_VerifyLabelOccupancy()
        {
            String occupL = driver.FindElement(occupancyLabel).Text;
            return occupL;
        }
        public String KPI_VerifyLabelinPlaceRent()
        {
            String inPlace = driver.FindElement(inPlaceLabel).Text;
            return inPlace;
        }
        public String KPI_VerifyLabelYOC()
        {
            String YOC = driver.FindElement(yOCLabel).Text;
            return YOC;
        }
        public String KPI_VerifyLabelCashOnCash()
        {
            String CashOnCash = driver.FindElement(cashOnCashLabel).Text;
            return CashOnCash;
        }
        public String KPI_VerifyLabelDebtYield()
        {
            String DebtY = driver.FindElement(debtYeildLabel).Text;
            return DebtY;
        }
        public String KPI_VerifyLabelDSCR()
        {
            String dSCR = driver.FindElement(dscrLabel).Text;
            return dSCR;
        }
        public String KPI_VerifyColumnLabelActual()
        {
            String actual = driver.FindElement(KPIHeaderActual).Text;
            return actual;
        }
        public String KPI_VerifyColumnLabelBudget()
        {
            String budget = driver.FindElement(KPIHeaderBudget).Text;
            return budget;
        }
        public String KPI_VerifyColumnLabelProforma()
        {
            String proforma = driver.FindElement(KPIHeaderProforma).Text;
            return proforma;
        }
        public void ClickOperatingSummarytab()
        {
            driver.FindElement(OperatingSumTab).Click();
        }
       
        public int ReturnOccupancyValue()
        {
            String actual = driver.FindElement(occupancyActual).Text;
            String withoutPercent = actual.Replace("%", String.Empty);
            double value = double.Parse(withoutPercent);
            int rounded = (int)Math.Round(value);
            return rounded;
        }
        public int ReturnLeasedPercentValue()
        {
            String actual = driver.FindElement(CurrentLeasedUpdated).Text;
            String withoutPercent = actual.Replace("%", String.Empty);
            int value = int.Parse(withoutPercent);
            return value;
        }
        public void RadioButton_SelectYTD()
        {
            driver.FindElement(YTDLabel).Click();
        }
        public void RadioButton_SelectYearly()
        {
            driver.FindElement(yearlyLabel).Click();
        }
        public void RadioButton_SelectMonthly()
        {
            driver.FindElement(monthLyLabel).Click();
        }
        public String OperatingSummary_ReturnColumnLablel1()
        {
            String label1 = driver.FindElement(OpColumnLabel1).Text;
            return label1;
        }
        public String OperatingSummary_ReturnColumnLablel2()
        {
            String label2 = driver.FindElement(OpColumnLabel2).Text;
            return label2;
        }
        public String OperatingSummary_ReturnColumnLablel3()
        {
            String label3 = driver.FindElement(OpColumnLabel3).Text;
            return label3;
        }
        public Boolean OperatingSummary_minimizeWorks()
        {
            driver.FindElement(Min_Operating).Click();
            Thread.Sleep(1000);
            driver.FindElement(Min_Operating).Click();
            Boolean res = driver.FindElement(OpColumnLabel1).Displayed;
            return res;
        }
        public Boolean KPI_minimizeWorks()
        {
            driver.FindElement(Min_KPI).Click();
            Thread.Sleep(1000);
            driver.FindElement(Min_KPI).Click();
            Boolean res = driver.FindElement(KPIHeaderActual).Displayed;
            return res;
        }
        public int ReturnNOIValue()
        {
            String OriginalValue=driver.FindElement(NOIValue).Text;
            if (OriginalValue == "-")
            {
                return 0;
            }
            String withoutcomma = OriginalValue.Replace(",", String.Empty);
            int final = int.Parse(withoutcomma);            
            return final;        
        }
        public int ReturnTotalDebtService()
        {
            String OriginalValue = driver.FindElement(DebtTotal).Text;
            if (OriginalValue == "-")
            {
                return 0;
            }
            String withoutcomma = OriginalValue.Replace(",", String.Empty);
            int final = int.Parse(withoutcomma);
            return final;
        }
        public double OriginalDSCRvalue()
        {
            String OriginalValue = driver.FindElement(dscrActual).Text;
            if (OriginalValue == "-")
            {
                return 0;
            }
            String withoutcomma = OriginalValue.Replace("x", String.Empty);
            double final = double.Parse(withoutcomma);
            return final;
        }
        public double CalculatedDSCRvalue()
        {
            int noi = ReturnNOIValue();
            int debtService = ReturnTotalDebtService();
            double calculation = noi / debtService;
            return calculation;
        }
        public double KPI_ActualDebtYieldValue()
        {
            String OriginalValue = driver.FindElement(debtYeildActual).Text;
            if (OriginalValue == "-")
                {
                    return 0;
                }
            String withoutcomma = OriginalValue.Replace("%", String.Empty);
            double final = double.Parse(withoutcomma);
            return final;
        }
        public int KPI_ReturnCurrentMonthValueNumber()
        {
            String asofDate = driver.FindElement(KPI_AsOfDate).Text;
            String seperateMonth = asofDate.Split('/')[0];
            String removeAsof = seperateMonth.Replace("As of ", String.Empty);
            if (removeAsof.Contains("0"))
            {
                String value = removeAsof.Replace("0", String.Empty);
                int mValue = int.Parse(value);
                return mValue;
            }
            int monthValue = int.Parse(seperateMonth);
            return monthValue;
        }
        public int CurrentCapitalization_ReturnLoanBalanceValue()
        {
            driver.FindElement(BasisDebtTab).Click();
            String currentValue = driver.FindElement(loanBalanceValue).Text;
            driver.FindElement(OperatingSumTab).Click();
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        //Yield on Debt= (Total NOI Actual )*12/Month(ME_Date)) / Loan Balance
        public double KPI_Calculate_DebtYieldValue()
        {
            int noi = ReturnNOIValue();
            int monthValue = KPI_ReturnCurrentMonthValueNumber();
            int loanBalance = CurrentCapitalization_ReturnLoanBalanceValue();
            double debtValue = ((noi*12)/monthValue)/loanBalance;
            double final = debtValue * 100;
            return final; 
        }
        //NOI Yield on Cost = (Total NOI Actual *12/Month(ME_Date)) / Net Capitalization
        public double KPI_ActualYOCValue()
        {
            RadioButton_SelectYTD();
            String OriginalValue = driver.FindElement(yOCActual).Text;
            if (OriginalValue == "-")
            {
                return 0;
            }
            String withoutcomma = OriginalValue.Replace("%", String.Empty);
            double final = double.Parse(withoutcomma);
            return final;
        }
        public int CurrentCapitalization_PresentValue_NetCapitalization()
        {
            driver.FindElement(BasisDebtTab).Click();
            String currentValue = driver.FindElement(netCapitaValue).Text;
            driver.FindElement(OperatingSumTab).Click();
            if (currentValue == "-")
            {
                return 0;
            }
            String removeSpace = currentValue.Replace(",", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public double KPI_Calculate_YOCValue()
        {
            int noi = ReturnNOIValue();
            int monthValue = KPI_ReturnCurrentMonthValueNumber();
            int netcapitalization = CurrentCapitalization_PresentValue_NetCapitalization();
            double debtValue = ((noi*12)/monthValue)/netcapitalization;
            double final = debtValue * 100;
            return final;
        }
        //Cash-on-Cash Yield= ((Total NOI Actual - Total Debt Service Actual )*12/Month(ME_Date)) / Total Equity  (it includes Fund Equity, Stream Equity and DRA Equity)
        public double KPI_ActualCachOnCashYieldValue()
        {
            String OriginalValue = driver.FindElement(cashOnCashActual).Text;
            if (OriginalValue == "-")
            {
                return 0;
            }
            String withoutcomma = OriginalValue.Replace("%", String.Empty);
            double final = double.Parse(withoutcomma);
            return final;
        }
        public int CurrentCapitalization_ReturnFundEquityValue()
        {
            driver.FindElement(BasisDebtTab).Click();
            String currentValue = driver.FindElement(fundEquityValue).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int CurrentCapitalization_ReturnStreamEquityValue()
        {
            String currentValue = driver.FindElement(streamEquityValue).Text;
            driver.FindElement(OperatingSumTab).Click();
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        //Cash-on-Cash Yield= ((Total NOI Actual - Total Debt Service Actual )*12/Month(ME_Date)) / Total Equity 
        public double KPI_Calculate_CachOnCashValue()
        {
            int noi = ReturnNOIValue();
            int totaldebt = ReturnTotalDebtService();
            int monthValue = KPI_ReturnCurrentMonthValueNumber();
            int fundEquity = CurrentCapitalization_ReturnFundEquityValue();
            int streamEquity = CurrentCapitalization_ReturnStreamEquityValue();
            double debtValue = (((noi-totaldebt)*12)/monthValue)/(fundEquity+streamEquity);
            double final = debtValue * 100;
            return final;
        }
        //For In Place Avg Rent= (Total NOI Actual *12/Month(ME_Date)) / Current Leased % / Building NRA
        public double KPI_ActualInPlaceRentValue()
        {
            String OriginalValue = driver.FindElement(inPlaceActual).Text;
            if (OriginalValue == "-")
            {
                return 0;
            }
            String withoutdollar = OriginalValue.Replace("$", String.Empty);
            String withoutNNN = withoutdollar.Replace("/SF NNN", String.Empty);//$1.18/SF NNN
            double final = double.Parse(withoutNNN);
            return final;
        }
        public int GeneralAsset_ReturnLeasedPercentValue()
        {
            driver.FindElement(GeneralTab).Click();
            String OriginalValue = driver.FindElement(CurrentLeasedUpdated).Text;
            if (OriginalValue == "-")
            {
                return 0;
            }
            String withoutdollar = OriginalValue.Replace("%", String.Empty);
            int final = int.Parse(withoutdollar);
            return final;
        }
        public int GeneralAssetSummary_ReturnBUildingNRaValue()
        {
            String nra = driver.FindElement(BuildingNRAUpdated).Text;
            driver.FindElement(OperatingSumTab).Click();
            if (nra == "-")
            { return 0; }
            String NRaWithoutComma = nra.Replace(",", String.Empty);
            int Buildingnra = int.Parse(NRaWithoutComma);
            return Buildingnra;
        }
        //For In Place Avg Rent= (Total NOI Actual *12/Month(ME_Date)) / Current Leased % / Building NRA
        public double KPI_Calculate_InPlaceRentValue()
        {
            int noi = ReturnNOIValue();
            int monthValue = KPI_ReturnCurrentMonthValueNumber();
            int currentLeased = GeneralAsset_ReturnLeasedPercentValue();
            int nra = GeneralAssetSummary_ReturnBUildingNRaValue();
            double inPlaceRent = ((noi*12)/monthValue)/(currentLeased/100)/nra;
            double final = inPlaceRent * 100;
            return final;
        }
    }
}
