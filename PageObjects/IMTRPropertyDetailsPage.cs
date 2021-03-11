using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UI_InvestmentMangement.PageObjects
{
    class IMTRPropertyDetailsPage
    {
        private IWebDriver driver;
        public IMTRPropertyDetailsPage(IWebDriver driver)
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
        //Edit section locatiors
        By EditGeneralInfo = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[1]/div/div/div[1]/div[3]/div[2]");
        By EditPurchaseExit = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div/div[2]/div/div/div[3]/div[2]");
        //"//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[1]"
        By EditCapitalization = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[1]/div/div/div[3]/div[2]");
        By Edit3rdPartyDis = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[2]/div/div/div[3]/div[2]");
        By EditSponsorDis = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[3]/div/div/div[3]/div[2]");
        By EditInvestorReturns = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[4]/div/div/div[3]/div[2]");
        By TotalReturns = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[5]/div/div[2]/div/div[2]/div/div/span");

        //section titles()
        By Section_GeneralInfo = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div[1]/div/div/div[2]/div/label");
        By Section_PurchaseVsExit = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div[2]/div/div/div[2]/div/label");
        By Section_Capitalization = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div/div[2]/div/label");
        By Section_ThirdPartyEquity = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[2]/div/div/div[2]/div/label");
        By Section_SponsorEquity = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[3]/div/div/div[2]/div/label");
        By Section_InvestorEquity = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[4]/div/div/div[2]/div/label");
        By Section_TotalEquity = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[5]/div/div/div[2]/div/label");


        //Updating value for each field from each of the sections
        By InputPurchasePrice = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div/div/div/div[2]/div[12]/div[2]/div/div/span/input");
        By YardiPropCode = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div/div/div/div[2]/div/div/div/label");
        By PurchasePriceValue = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div/div/div/div[2]/div[12]/div[2]/div/div/span");
        By InputExitPrice = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div/div[2]/div/div[2]/div[2]/div[2]/div/div/span/input");
        By UpdatedExitPrice = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div/div[2]/div/div[2]/div[2]/div[2]/div/div/span");
        By Update3RdPartyDis = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[2]/div/div[2]/div/div[2]/div/div/span/input");
        By UpdateSponsoryDis = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[3]/div/div[2]/div/div[2]/div/div/span/input");
        By UpdateInvestorDis = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[4]/div/div[2]/div/div[2]/div/div/span/input");
        By PropertyStatus = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div/div/div/div[2]/div[16]/div[2]/div/div/span");

        //Input and updated fields in capitalization
        By cap_UpdatedTotalcaptn = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[1]/div[2]/div/div/span");
        By cap_UpdatedTotalEquity = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[3]/div[2]/div/div/span");
        By cap_UpdatedLTC = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[4]/div[2]/div/div/span");

        By cap_InputDebt = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[2]/div[2]/div/div/span/input");
        By cap_UpdatedDebt = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[2]/div[2]/div/div/span");
        By cap_InputInvestoreQ = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[5]/div[2]/div/div/span/input");
        By cap_UpdatedInvestoreQ = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[5]/div[2]/div/div/span");
        By cap_InputStreaeQ = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[6]/div[2]/div/div/span/input");
        By cap_UpdatedStreameQ = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[6]/div[2]/div/div/span");
        By cap_InputOutsideeQ = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[7]/div[2]/div/div/span/input");
        By cap_UpdatedOutsideeQ = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[7]/div[2]/div/div/span");

        //Checking maximize and minimize for each section
        By GeneralInfo_Maximize = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[1]/div/div/div[1]/div[3]/div[3]");
        By Purchase_Maximize = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div/div[2]/div/div/div[3]/div[3]");
        By Capitalization_Maximize = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[1]/div/div/div[3]/div[3]");
        By ThirdParty_Maximize = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[2]/div/div/div[3]/div[3]");
        By Sponsor_Maximize = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[3]/div/div/div[3]/div[3]");
        By Investor_Maximize = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[4]/div/div/div[3]/div[3]");
        //Locators for purchase Vs.exit price
        By TotalCostlabel = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div[2]/div/div[2]/div[1]/div/div/label");
        By ExistPriceLabel = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div[2]/div/div[2]/div[2]/div/div/label");

        //Locators in capitalization
        By TotalCapitalizationLabel = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[1]/div/div/label");
        By DebtLabel = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[2]/div/div/label");
        By TotalEquityLabel = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[3]/div/div/label");
        By LTCLabel = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[4]/div/div/label");
        By InvestorEqLabel = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[5]/div/div/label");
        By StreamEqLabel = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[6]/div/div/label");
        By OutsideSponsorLabel = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[1]/div/div[2]/div[7]/div/div/label");
        //"//div[@class='row col-xs-12 no-padding']/div[2]/div[2]/div/div[2]/div[1]/div/div/label"

        By ThirdDistributionsLabel = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[2]/div/div[2]/div[1]/div/div/label");
        By StreamDistributionsLabel = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[3]/div/div[2]/div[1]/div/div/label");
        By InvestorDistributionsLabel = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[4]/div/div[2]/div[1]/div/div/label");
        By TotalDistributionsLabel = By.XPath("//div[@class='row col-xs-12 no-padding']/div[2]/div[5]/div/div[2]/div[1]/div/div/label");

        //Locators to edit each field from each section
        By GI_PropertyNameInput = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[2]/div[2]/div/div/span/input");
        By GI_AcquisitionDateInput = By.XPath("//div[@class='react-datepicker-wrapper']/div/input");
        By GI_DispositiondateInput = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[4]/div/div/label");
        By GI_MarketInput = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[5]/div[2]/div/div/span/select");
        By GI_ProductTypeInput = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[6]/div[2]/div/div/span/select");
        By GI_DealtypeInput = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[7]/div[2]/div/div/span/select");
        By GI_SourcingMethodInput = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[8]/div[2]/div/div/span/select");
        By GI_CoinvestorInput = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[9]/div[2]/div/div/span/select");
        By GI_LenderInput = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[10]/div[2]/div/div/span/select");
        By GI_RSFInput = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[11]/div[2]/div/div/span/input");
        By GI_PurchasePriceInput = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[12]/div[2]/div/div/span/input");
        By GI_SoldPriceInput = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[13]/div[2]/div/div/span/input");

        //Locators to to see updated value
        By GI_PropertyNameUpdated = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[2]/div[2]/div/div/span");
        By GI_AcquisitionDateUpdated = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[3]/div[2]/div/div/span");
        By GI_DispositiondateUpdated = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[4]/div[2]/div/div/span");
        By GI_MarketUpdated = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[5]/div[2]/div/div/span");
        By GI_ProductTypeUpdated = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[6]/div[2]/div/div/span");
        By GI_DealtypeUpdated = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[7]/div[2]/div/div/span");
        By GI_SourcingMethodUdpdated = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[8]/div[2]/div/div/span");
        By GI_CoinvestorUpdated = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[9]/div[2]/div/div/span");
        By GI_LenderUpdated = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[10]/div[2]/div/div/span");
        By GI_RSFUpdated = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[11]/div[2]/div/div/span");
        By GI_PurchasePriceUpdated = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[12]/div[2]/div/div/span");
        By GI_SoldPriceUpdated = By.XPath("//div[@class='row col-xs-12 no-padding']/div[1]/div/div/div[2]/div[13]/div[2]/div/div/span");

        By NoChangesMade = By.XPath("//div[@class='mainContainer']/div/div/div/div/div/div[2]");

        public void ClickEditButtonGeneralInfo()
        {
            try
            {
                var elementToClick = driver.FindElement(EditGeneralInfo);
                Actions action = new Actions(driver);
                action.Click(elementToClick).Build().Perform();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        public String ReturnPropertyDealType()
        {
            String dealtype = driver.FindElement(PropertyStatus).Text;
            return dealtype;
        }
        public Boolean EditAndUpdateExitPrice()
        {
            String existingValue = driver.FindElement(UpdatedExitPrice).Text;
            String withoutComma = existingValue.Replace(",", String.Empty);
            int existingV = int.Parse(withoutComma);
            int newValue = existingV + 10000;
            String valueToEnter = newValue.ToString();
            String formatted = String.Format("{0:n0}", newValue);
            driver.FindElement(EditPurchaseExit).Click();
            driver.FindElement(InputExitPrice).Click();
            driver.FindElement(InputExitPrice).Clear();
            driver.FindElement(InputExitPrice).SendKeys(valueToEnter);
            driver.FindElement(EditPurchaseExit).Click();
            Thread.Sleep(2000);
            String updatedValue = driver.FindElement(UpdatedExitPrice).Text;
            if (formatted == updatedValue)
            {
                return true;
            }
            return false;
        }
        public void EditAndUpdate3rdPartyEquity()
        {
            try
            {
                var elementToClick = driver.FindElement(Edit3rdPartyDis);
                Actions action = new Actions(driver);
                action.Click(elementToClick).Build().Perform();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            driver.FindElement(Update3RdPartyDis).Clear();
            driver.FindElement(Update3RdPartyDis).SendKeys("5000");
            driver.FindElement(Edit3rdPartyDis).Click();
        }
        public void EditAndInvestorEquity()
        {
            try
            {
                var elementToClick = driver.FindElement(EditInvestorReturns);
                Actions action = new Actions(driver);
                action.Click(elementToClick).Build().Perform();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            driver.FindElement(UpdateInvestorDis).Clear();
            driver.FindElement(UpdateInvestorDis).SendKeys("5000");
            driver.FindElement(EditInvestorReturns).Click();
        }
        public void EditAndUpdateSponsorReturns()
        {
            try
            {
                var elementToClick = driver.FindElement(EditSponsorDis);
                Actions action = new Actions(driver);
                action.Click(elementToClick).Build().Perform();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            driver.FindElement(UpdateSponsoryDis).Clear();
            driver.FindElement(UpdateSponsoryDis).SendKeys("5000");
            driver.FindElement(EditSponsorDis).Click();
        }
        public String CheckTotalReturns()
        {
            String totalreturns = driver.FindElement(TotalReturns).Text;
            return totalreturns;
        }
        public Boolean GeneralInfo_MaximizeMinimize()
        {
            var elementToClick = driver.FindElement(GeneralInfo_Maximize);
            Actions action = new Actions(driver);
            action.Click(elementToClick).Build().Perform();
            driver.FindElement(GeneralInfo_Maximize).Click();
            String res = driver.FindElement(YardiPropCode).Text;
            if (res == "Yardi Property Code")
            {
                return true;
            }
            return false;
        }
        public void PurchasePrice_MaximizeMinimize()
        {
            var elementToClick = driver.FindElement(Purchase_Maximize);
            Actions action = new Actions(driver);
            action.Click(elementToClick).Build().Perform();
            driver.FindElement(Purchase_Maximize).Click();
        }
        public void Capitalization_MaximizeMinimize()
        {
            var elementToClick = driver.FindElement(Capitalization_Maximize);
            Actions action = new Actions(driver);
            action.Click(elementToClick).Build().Perform();
            driver.FindElement(Capitalization_Maximize).Click();
        }
        public void SponsorEquity_MaximizeMinimize()
        {
            var elementToClick = driver.FindElement(Sponsor_Maximize);
            Actions action = new Actions(driver);
            action.Click(elementToClick).Build().Perform();
            driver.FindElement(Sponsor_Maximize).Click();
        }
        public void Investor_MaximizeMinimize()
        {
            var elementToClick = driver.FindElement(Investor_Maximize);
            Actions action = new Actions(driver);
            action.Click(elementToClick).Build().Perform();
            driver.FindElement(Investor_Maximize).Click();
        }
        public void ThirdParty_MaximizeMinimize()
        {
            var elementToClick = driver.FindElement(ThirdParty_Maximize);
            Actions action = new Actions(driver);
            action.Click(elementToClick).Build().Perform();
            driver.FindElement(ThirdParty_Maximize).Click();
        }
        public String PurchasePriceAndExistPrice_ReturnTotalCostBasislabel()
        {
            String label = driver.FindElement(TotalCostlabel).Text;
            return label;
        }
        public String PurchasePriceAndExistPrice_ReturnExitPricelabel()
        {
            String label = driver.FindElement(ExistPriceLabel).Text;
            return label;
        }
        public String Capitalization_ReturnTotalCapitalabel()
        {
            String label = driver.FindElement(TotalCapitalizationLabel).Text;
            return label;
        }
        public String Capitalization_ReturnDebtlabel()
        {
            String label = driver.FindElement(DebtLabel).Text;
            return label;
        }
        public String Capitalization_ReturnTotalequitylabel()
        {
            String label = driver.FindElement(TotalEquityLabel).Text;
            return label;
        }
        public String Capitalization_ReturnLTClabel()
        {
            String label = driver.FindElement(LTCLabel).Text;
            return label;
        }
        public String Capitalization_ReturnInvestorEquitylabel()
        {
            String label = driver.FindElement(InvestorEqLabel).Text;
            return label;
        }
        public String Capitalization_ReturnStreamEquityExitPricelabel()
        {
            String label = driver.FindElement(StreamEqLabel).Text;
            return label;
        }
        public String Capitalization_ReturnOutsideSponsorlabel()
        {
            String label = driver.FindElement(OutsideSponsorLabel).Text;
            return label;
        }
        public String ThirdPartySponsor_ReturnDistributionsReturnsLabel()
        {
            String label = driver.FindElement(ThirdDistributionsLabel).Text;
            return label;
        }
        public String StreamSponsor_ReturnDistributionsLabel()
        {
            String label = driver.FindElement(StreamDistributionsLabel).Text;
            return label;
        }
        public String InvestorSponsor_ReturnDistributionslabel()
        {
            String label = driver.FindElement(InvestorDistributionsLabel).Text;
            return label;
        }
        public String TotalReturns_ReturnDistributionsLabel()
        {
            String label = driver.FindElement(TotalDistributionsLabel).Text;
            return label;
        }
        public String ReturnGeneralInfoSectionLabel()
        {
            String label = driver.FindElement(Section_GeneralInfo).Text;
            return label;
        }
        public String ReturnPurchaseVsExitSectionlabel()
        {
            String label = driver.FindElement(Section_PurchaseVsExit).Text;
            return label;
        }
        public String ReturnCapitalizationSectionlabel()
        {
            String label = driver.FindElement(Section_Capitalization).Text;
            return label;
        }
        public String ReturnThirdPartyEquitySectionlabel()
        {
            String label = driver.FindElement(Section_ThirdPartyEquity).Text;
            return label;
        }
        public String ReturnSponsorEquitySectionlabel()
        {
            String label = driver.FindElement(Section_SponsorEquity).Text;
            return label;
        }
        public String ReturnInvestorEquitySectionlabel()
        {
            String label = driver.FindElement(Section_InvestorEquity).Text;
            return label;
        }
        public String ReturnTotalEquitySectionlabel()
        {
            String label = driver.FindElement(Section_TotalEquity).Text;
            return label;
        }
        public Boolean GI_EditAndUpdatePropertyName()
        {
            ClickEditButtonGeneralInfo();
            String existingValue = driver.FindElement(GI_PropertyNameUpdated).Text;
            String NewValue = existingValue + "Test";
            driver.FindElement(GI_PropertyNameInput).Clear();
            driver.FindElement(GI_PropertyNameInput).SendKeys(NewValue);
            driver.FindElement(EditGeneralInfo).Click();
            Thread.Sleep(2000);
            String finalValue = driver.FindElement(GI_PropertyNameUpdated).Text;
            if (finalValue.Contains("Test"))
            {
                return true;
            }
            return false;
        }
        public Boolean GI_EditAndUpdateAcquisitiondate()
        {
            driver.FindElement(EditGeneralInfo).Click();
            String existingValue = driver.FindElement(GI_AcquisitionDateUpdated).Text;
            driver.FindElement(GI_AcquisitionDateInput).SendKeys(Keys.Clear);
            driver.FindElement(GI_AcquisitionDateInput).SendKeys("20");
            driver.FindElement(GI_PropertyNameInput).Click();
            driver.FindElement(EditGeneralInfo).Click();
            Thread.Sleep(2000);
            String finalValue = driver.FindElement(GI_AcquisitionDateUpdated).Text;
            if (finalValue.Contains("20"))
            {
                return true;
            }
            return false;
        }
        public Boolean GI_EditAndUpdateDispositionDate()
        {
            driver.FindElement(EditGeneralInfo).Click();
            driver.FindElement(GI_DispositiondateInput).Clear();
            String ValueToBe = DateTime.Now.ToString("MM/dd/yyyy");
            driver.FindElement(GI_DispositiondateInput).SendKeys(ValueToBe);
            driver.FindElement(GI_PropertyNameInput).Click();
            driver.FindElement(EditGeneralInfo).Click();
            Thread.Sleep(2000);
            String finalValue = driver.FindElement(GI_DispositiondateUpdated).Text;
            if (ValueToBe == finalValue)
            {
                return true;
            }
            return false;
        }
        public String GI_ReturnUpdatedPMarketValue()
        {
            String austin = "SAU - Austin";
            String denver = "SDEN - Denver";
            String currentvalue = driver.FindElement(GI_MarketUpdated).Text;
            driver.FindElement(EditGeneralInfo).Click();
            driver.FindElement(GI_MarketInput).Click();
            SelectElement market = new SelectElement(driver.FindElement(GI_MarketInput));
            if (currentvalue == austin)
            {
                market.SelectByText("SDEN - Denver");
                driver.FindElement(EditGeneralInfo).Click();
                return denver;
            }
            market.SelectByText("SAU - Austin");
            driver.FindElement(EditGeneralInfo).Click();
            return austin;
        }
        public Boolean GI_EditAndUpdatePMarketValue()
        {
            String UpdatedValue = GI_ReturnUpdatedPMarketValue();
            String currentvalue = driver.FindElement(GI_MarketUpdated).Text;
            if (UpdatedValue == currentvalue)
            {
                return true;
            }
            return false;
        }
        public String GI_ReturnUpdatedProductTypeValue()
        {
            String land = "Land";
            String office = "Office";
            String currentvalue = driver.FindElement(GI_ProductTypeUpdated).Text;
            driver.FindElement(EditGeneralInfo).Click();
            driver.FindElement(GI_ProductTypeInput).Click();
            SelectElement Allitems = new SelectElement(driver.FindElement(GI_ProductTypeInput));
            if (currentvalue == land)
            {
                Allitems.SelectByText("Office");
                driver.FindElement(EditGeneralInfo).Click();
                return office;
            }
            Allitems.SelectByText("Land");
            driver.FindElement(EditGeneralInfo).Click();
            return land;
        }
        public Boolean GI_EditAndUpdateProductType()
        {
            String UpdatedValue = GI_ReturnUpdatedProductTypeValue();
            String currentvalue = driver.FindElement(GI_ProductTypeUpdated).Text;
            if (UpdatedValue == currentvalue)
            {
                return true;
            }
            return false;
        }
        public String GI_ReturnUpdatedDealTypeValue()
        {
            String land = "Land";
            String development = "Development";
            String currentvalue = driver.FindElement(GI_DealtypeUpdated).Text;
            driver.FindElement(EditGeneralInfo).Click();
            driver.FindElement(GI_DealtypeInput).Click();
            SelectElement Allitems = new SelectElement(driver.FindElement(GI_DealtypeInput));
            if (currentvalue == land)
            {
                Allitems.SelectByText("Development");
                driver.FindElement(EditGeneralInfo).Click();
                return development;
            }
            Allitems.SelectByText("Land");
            driver.FindElement(EditGeneralInfo).Click();
            return land;
        }
        public Boolean GI_EditAndUpdateDealType()
        {
            String UpdatedValue = GI_ReturnUpdatedDealTypeValue();
            String currentvalue = driver.FindElement(GI_DealtypeUpdated).Text;
            if (UpdatedValue == currentvalue)
            {
                return true;
            }
            return false;
        }
        public String GI_ReturnUpdatedSourcingMethodValue()
        {
            String limitedPro = "Limited Process";
            String offMarket = "Off Market";
            String currentvalue = driver.FindElement(GI_SourcingMethodUdpdated).Text;
            driver.FindElement(EditGeneralInfo).Click();
            driver.FindElement(GI_SourcingMethodInput).Click();
            SelectElement Allitems = new SelectElement(driver.FindElement(GI_SourcingMethodInput));
            if (currentvalue == limitedPro)
            {
                Allitems.SelectByText("Off Market");
                driver.FindElement(EditGeneralInfo).Click();
                return offMarket;
            }
            Allitems.SelectByText("Limited Process");
            driver.FindElement(EditGeneralInfo).Click();
            return limitedPro;
        }
        public Boolean GI_EditAndUpdateSourcingMethod()
        {
            String UpdatedValue = GI_ReturnUpdatedSourcingMethodValue();
            String currentvalue = driver.FindElement(GI_SourcingMethodUdpdated).Text;
            if (UpdatedValue == currentvalue)
            {
                return true;
            }
            return false;
        }
        public String GI_ReturnUpdatedCoinvestorValue()
        {
            String metLife = "MetLife";
            String priInvestor = "Private Investor";
            String currentvalue = driver.FindElement(GI_CoinvestorUpdated).Text;
            driver.FindElement(EditGeneralInfo).Click();
            driver.FindElement(GI_CoinvestorInput).Click();
            SelectElement Allitems = new SelectElement(driver.FindElement(GI_CoinvestorInput));
            if (currentvalue == metLife)
            {
                Allitems.SelectByText("Private Investor");
                driver.FindElement(EditGeneralInfo).Click();
                return priInvestor;
            }
            Allitems.SelectByText("MetLife");
            driver.FindElement(EditGeneralInfo).Click();
            return metLife;
        }
        public Boolean GI_EditAndUpdateCoInvestor()
        {
            String UpdatedValue = GI_ReturnUpdatedCoinvestorValue();
            String currentvalue = driver.FindElement(GI_CoinvestorUpdated).Text;
            if (UpdatedValue == currentvalue)
            {
                return true;
            }
            return false;
        }
        public String GI_ReturnUpdatedLenderValue()
        {
            String midland = "Midland";
            String aetna = "Aetna";
            String currentvalue = driver.FindElement(GI_LenderUpdated).Text;
            driver.FindElement(EditGeneralInfo).Click();
            driver.FindElement(GI_LenderInput).Click();
            SelectElement Allitems = new SelectElement(driver.FindElement(GI_LenderInput));
            if (currentvalue == midland)
            {
                Allitems.SelectByText("Aetna");
                driver.FindElement(EditGeneralInfo).Click();
                return aetna;
            }
            Allitems.SelectByText("Midland");
            driver.FindElement(EditGeneralInfo).Click();
            return midland;
        }
        public Boolean GI_EditAndUpdateLenderName()
        {
            String UpdatedValue = GI_ReturnUpdatedLenderValue();
            String currentvalue = driver.FindElement(GI_LenderUpdated).Text;
            if (UpdatedValue == currentvalue)
            {
                return true;
            }
            return false;
        }
        public Boolean GI_EditAndUpdatePurchasePrice()
        {
            String existingValue = driver.FindElement(GI_PurchasePriceUpdated).Text;
            String withoutDollar = existingValue.Replace("$", String.Empty);
            String withoutComma = withoutDollar.Replace(",", String.Empty);
            int existingV = int.Parse(withoutComma);
            int newValue = existingV + 1000;
            String valueToEnter = newValue.ToString();
            String formatted = String.Format("{0:n0}", newValue);
            driver.FindElement(EditGeneralInfo).Click();
            driver.FindElement(GI_PurchasePriceInput).Click();
            driver.FindElement(GI_PurchasePriceInput).Clear();
            driver.FindElement(GI_PurchasePriceInput).SendKeys(valueToEnter);
            driver.FindElement(EditGeneralInfo).Click();
            Thread.Sleep(2000);
            String updatedValue = driver.FindElement(GI_PurchasePriceUpdated).Text;
            String updatedwithoutDollar = updatedValue.Replace("$", String.Empty);
            if (formatted == updatedwithoutDollar)
            {
                return true;
            }
            return false;
        }
        public Boolean GI_EditAndUpdateRSFValue()
        {
            String existingValue = driver.FindElement(GI_RSFUpdated).Text;
            String withoutComma = existingValue.Replace(",", String.Empty);
            int existingV = int.Parse(withoutComma);
            int newValue = existingV + 1000;
            String valueToEnter = newValue.ToString();
            String formatted = String.Format("{0:n0}", newValue);
            driver.FindElement(EditGeneralInfo).Click();
            driver.FindElement(GI_RSFInput).Click();
            driver.FindElement(GI_RSFInput).Clear();
            driver.FindElement(GI_RSFInput).SendKeys(valueToEnter);
            driver.FindElement(EditGeneralInfo).Click();
            Thread.Sleep(2000);
            String updatedValue = driver.FindElement(GI_RSFUpdated).Text;
            if (formatted == updatedValue)
            {
                return true;
            }
            return false;
        }
        public String GI_EditAndUpdateSoldPrice()
        {
            driver.FindElement(EditGeneralInfo).Click();
            driver.FindElement(GI_SoldPriceInput).Click();
            driver.FindElement(GI_SoldPriceInput).Clear();
            driver.FindElement(GI_SoldPriceInput).SendKeys("20000");
            driver.FindElement(EditGeneralInfo).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(NoChangesMade));
            var elementToClick = driver.FindElement(NoChangesMade);
            String alertMessage = elementToClick.Text;
            return alertMessage;
        }

        public int Capitalization_ReturnExistingDebtValue()
        {
            String existingValue = driver.FindElement(cap_UpdatedDebt).Text;
            if (existingValue == "-")
            {
                return 10000;
            }
            String withoutComma = existingValue.Replace(",", String.Empty);
            int existingV = int.Parse(withoutComma);
            int newValue = existingV + 1000;
            return newValue;
        }
        public Boolean Capitalization_EditandUpdateDebtField()
        {
            int newValue = Capitalization_ReturnExistingDebtValue();
            String valueToEnter = newValue.ToString();
            String formatted = String.Format("{0:n0}", newValue);
            driver.FindElement(EditCapitalization).Click();
            driver.FindElement(cap_InputDebt).Click();
            driver.FindElement(cap_InputDebt).Clear();
            driver.FindElement(cap_InputDebt).SendKeys(valueToEnter);
            driver.FindElement(EditCapitalization).Click();
            Thread.Sleep(2000);
            String updatedValue = driver.FindElement(cap_UpdatedDebt).Text;
            if (formatted == updatedValue)
            {
                return true;
            }
            return false;
        }
        public int Capitalization_ReturnExistingInvestorequityValue()
        {
            String existingValue = driver.FindElement(cap_UpdatedInvestoreQ).Text;
            if (existingValue == "-")
            {
                return 10000;
            }
            String withoutComma = existingValue.Replace(",", String.Empty);
            int existingV = int.Parse(withoutComma);
            int newValue = existingV + 1000;
            return newValue;
        }
        public Boolean Capitalization_EditandUpdateInvestorEquity()
        {
            int newValue = Capitalization_ReturnExistingInvestorequityValue();
            String valueToEnter = newValue.ToString();
            String formatted = String.Format("{0:n0}", newValue);
            driver.FindElement(EditCapitalization).Click();
            driver.FindElement(cap_InputInvestoreQ).Click();
            driver.FindElement(cap_InputInvestoreQ).Clear();
            driver.FindElement(cap_InputInvestoreQ).SendKeys(valueToEnter);
            driver.FindElement(EditCapitalization).Click();
            Thread.Sleep(2000);
            String updatedValue = driver.FindElement(cap_UpdatedInvestoreQ).Text;
            if (formatted == updatedValue)
            {
                return true;
            }
            return false;
        }
        public int Capitalization_ReturnExistingStreamequityValue()
        {
            String existingValue = driver.FindElement(cap_UpdatedStreameQ).Text;
            if (existingValue == "-")
            {
                return 10000;
            }
            String withoutComma = existingValue.Replace(",", String.Empty);
            int existingV = int.Parse(withoutComma);
            int newValue = existingV + 1000;
            return newValue;
        }
        public Boolean Capitalization_EditandUpdateStreamEquity()
        {
            int newValue = Capitalization_ReturnExistingStreamequityValue();
            String valueToEnter = newValue.ToString();
            String formatted = String.Format("{0:n0}", newValue);
            driver.FindElement(EditCapitalization).Click();
            driver.FindElement(cap_InputStreaeQ).Click();
            driver.FindElement(cap_InputStreaeQ).Clear();
            driver.FindElement(cap_InputStreaeQ).SendKeys(valueToEnter);
            driver.FindElement(EditCapitalization).Click();
            Thread.Sleep(2000);
            String updatedValue = driver.FindElement(cap_UpdatedStreameQ).Text;
            if (formatted == updatedValue)
            {
                return true;
            }
            return false;
        }
        public int Capitalization_ReturnExistingOutsidEequityValue()
        {
            String existingValue = driver.FindElement(cap_UpdatedOutsideeQ).Text;
            if (existingValue == "-")
            {
                return 10000;
            }
            String withoutComma = existingValue.Replace(",", String.Empty);
            int existingV = int.Parse(withoutComma);
            int newValue = existingV + 1000;
            return newValue;
        }
        public Boolean Capitalization_EditandUpdateOutsideEquityEquity()
        {
            int newValue = Capitalization_ReturnExistingOutsidEequityValue();
            String valueToEnter = newValue.ToString();
            String formatted = String.Format("{0:n0}", newValue);
            driver.FindElement(EditCapitalization).Click();
            driver.FindElement(cap_InputOutsideeQ).Click();
            driver.FindElement(cap_InputOutsideeQ).Clear();
            driver.FindElement(cap_InputOutsideeQ).SendKeys(valueToEnter);
            driver.FindElement(EditCapitalization).Click();
            Thread.Sleep(2000);
            String updatedValue = driver.FindElement(cap_UpdatedOutsideeQ).Text;
            if (formatted == updatedValue)
            {
                return true;
            }
            return false;
        }
        public String GeneralInfo_VerifyErrorNoChangesmade()
        {
            driver.FindElement(EditGeneralInfo).Click();
            driver.FindElement(EditGeneralInfo).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(NoChangesMade));
            var elementToClick = driver.FindElement(NoChangesMade);
            String alertMessage = elementToClick.Text;
            return alertMessage;
        }
        public String PurchaseVsExit_VerifyErrorNoChangesmade()
        {
            driver.FindElement(EditPurchaseExit).Click();
            driver.FindElement(EditPurchaseExit).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(NoChangesMade));
            var elementToClick = driver.FindElement(NoChangesMade);
            String alertMessage = elementToClick.Text;
            return alertMessage;
        }
        public String Capitalization_VerifyErrorNoChangesmade()
        {
            driver.FindElement(EditCapitalization).Click();
            driver.FindElement(EditCapitalization).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(NoChangesMade));
            var elementToClick = driver.FindElement(NoChangesMade);
            String alertMessage = elementToClick.Text;
            return alertMessage;
        }
        public String ThirdPartyEquity_VerifyErrorNoChangesmade()
        {
            driver.FindElement(Edit3rdPartyDis).Click();
            driver.FindElement(Edit3rdPartyDis).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(NoChangesMade));
            var elementToClick = driver.FindElement(NoChangesMade);
            String alertMessage = elementToClick.Text;
            return alertMessage;
        }
        public String SponsorEquity_VerifyErrorNoChangesmade()
        {
            driver.FindElement(EditSponsorDis).Click();
            driver.FindElement(EditSponsorDis).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(NoChangesMade));
            var elementToClick = driver.FindElement(NoChangesMade);
            String alertMessage = elementToClick.Text;
            return alertMessage;
        }
        public String Investorequity_VerifyErrorNoChangesmade()
        {
            driver.FindElement(EditInvestorReturns).Click();
            driver.FindElement(EditInvestorReturns).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(NoChangesMade));
            var elementToClick = driver.FindElement(NoChangesMade);
            String alertMessage = elementToClick.Text;
            return alertMessage;
        }
        public int Capitalization_ReturnCurrentTotalCapitalizationValue()
        {
            String actualvalue = driver.FindElement(cap_UpdatedTotalcaptn).Text;
            if (actualvalue == "-")
            {
                return 0;
            }
            String withoutComma = actualvalue.Replace(",", String.Empty);
            int actualAmount = int.Parse(withoutComma);
            return actualAmount;
        }
        public int Capitalization_ReturnDebtAmount()
        {
            String debtValue = driver.FindElement(cap_UpdatedDebt).Text;
            if (debtValue == "-")
            {
                return 0;
            }
            String debtwithoutComma = debtValue.Replace(",", String.Empty);
            int debtAmount = int.Parse(debtwithoutComma);
            return debtAmount;
        }
        public int Capitalization_ReturnTotalEquityAmount()
        {
            String equityValue = driver.FindElement(cap_UpdatedTotalEquity).Text;
            if (equityValue == "-")
            {
                return 0;
            }
            String equitywithoutComma = equityValue.Replace(",", String.Empty);
            int equityAmount = int.Parse(equitywithoutComma);
            return equityAmount;
        }
        public int Capitalization_CalculateTotalCapitalizationValue()
        {
            int debtAmount = Capitalization_ReturnDebtAmount();
            int equityAmount = Capitalization_ReturnTotalEquityAmount();
            int calculatedAmount = debtAmount + equityAmount;
            return calculatedAmount;
        }
        public int Capitalization_ReturnInvestorAmount()
        {
            String actualValue = driver.FindElement(cap_UpdatedInvestoreQ).Text;
            if (actualValue == "-")
            {
                return 0;
            }
            String valueWithoutComma = actualValue.Replace(",", String.Empty);
            int finalamount = int.Parse(valueWithoutComma);
            return finalamount;
        }
        public int Capitalization_ReturnStreamEquityAmount()
        {
            String actualValue = driver.FindElement(cap_UpdatedStreameQ).Text;
            if (actualValue == "-")
            {
                return 0;
            }
            String valueWithoutComma = actualValue.Replace(",", String.Empty);
            int finalamount = int.Parse(valueWithoutComma);
            return finalamount;
        }
        public int Capitalization_ReturnOutsideEquityAmount()
        {
            String actualValue = driver.FindElement(cap_UpdatedOutsideeQ).Text;
            if (actualValue == "-")
            {
                return 0;
            }
            String valueWithoutComma = actualValue.Replace(",", String.Empty);
            int finalamount = int.Parse(valueWithoutComma);
            return finalamount;
        }
        public int Capitalization_CalculateTotalEquityValue()
        {
            int InvestorEquity = Capitalization_ReturnInvestorAmount();
            int StreamEquity = Capitalization_ReturnStreamEquityAmount();
            int OutsideEquity = Capitalization_ReturnOutsideEquityAmount();
            int calculatedAmount = InvestorEquity + StreamEquity + OutsideEquity;
            return calculatedAmount;
        }
        public double Capitalization_ReturnActualLTCValue()
        {
            String actualValue = driver.FindElement(cap_UpdatedLTC).Text;
            if (actualValue == "-")
            {
                return 0;
            }
            String valueWithoutComma = actualValue.Replace("%", String.Empty);
            double finalamount = double.Parse(valueWithoutComma);
            double final = Math.Round(finalamount);
            return final;
        }
        public double Capitalization_CalculatedLTCValue()
        {
            int debt = Capitalization_ReturnDebtAmount();
            Double debtINDouble = Convert.ToDouble(debt);
            int equity = Capitalization_ReturnTotalEquityAmount();
            Double equityINDouble = Convert.ToDouble(equity);
            double total = debt + equity;
            double CalculatedLTC = (debtINDouble / total) * 100;
            double final = Math.Round(CalculatedLTC);
            return final;
        }
    }
}
