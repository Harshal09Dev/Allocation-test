using InvestmentManagement.BaseClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UI_InvestmentMangement.TestScripts;

namespace UI_InvestmentMangement.PageObjects
{
    class Asset_BasisAndDebtTabPage
    {
        private IWebDriver driver;
        public Asset_BasisAndDebtTabPage(IWebDriver driver)
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
        By BasisDebtTab = By.XPath("//div[@class='property_main_container']/div[3]/div[1]/div/div/button[2]/div");

        //Edit and max min button for all tab
        By max_DebtInfo = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div/div/div/div[3]/div[2]");
        By NoData_DebtInfo = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div/div/div[2]");
        By edit_CurrentCapita = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div/div[3]/div[2]");
        By max_CurrentCapita = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div/div[3]/div[3]");
        By edit_CurrentCostBasis = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[1]/div[3]/div[2]");
        By max_CurrentCostBasis = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[1]/div[3]/div[3]");
        By edit_EstimatedFully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[1]/div[3]/div[2]");
        By max_EstimatedFully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[1]/div[3]/div[3]");

        //Header ttitle for each section
        By title_DebtInfo = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div/div/div/div[2]/div/label");
        By title_CurrentCapita = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div/div[2]/div/label");
        By title_CurrentCostBasis = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[1]/div[2]/div/label");
        By title_EstimatedFully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[1]/div[2]/div/label");

        //Field labels in current capitalization
        By loanBalance = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[2]/div/div/label");
        By QualRealEquity = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[3]/div/div/label");
        By DRAEquity = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[3]/div/div/label");
        By fundEquity = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[3]/div/div/label");
        By streamEquity = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[4]/div/div/label");
        By totalCapita = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[5]/div/div/label");
        By positiveCashFlow = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[6]/div/div/label");
        By distributions = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[7]/div/div/label");
        By netCurrentAssets = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[8]/div/div/label");
        By netCapita = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[9]/div/div/label");
        //field values in current capitalization
        By loanBalanceValue = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[2]/div[2]/div/div/span");
        By fundEquityValue = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[3]/div[2]/div/div/span");
        By streamEquityValue = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[4]/div[2]/div/div/span");
        By totalCapitaValue = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[5]/div[2]/div/div/span");
        By positiveCashFlowValue = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[6]/div[2]/div/div/span");
        By distributionsValue = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[7]/div[2]/div/div/span");
        By netCurrentAssetsValue = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[8]/div[2]/div/div/span");
        By netCapitaValue = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[9]/div[2]/div/div/span");
        //Building NRA values in current capitalization
        By loanBalanceNRA = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[2]/div[2]/div[2]/div/span");
        By fundEquityNRA = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[3]/div[2]/div[2]/div/span");
        By streamEquityNRA = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[4]/div[2]/div[2]/div/span");
        By totalCapitaNRA = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[5]/div[2]/div[2]/div/span");
        By positiveCashFlowNRA = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[6]/div[2]/div[2]/div/span");
        By distributionsNRA = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[7]/div[2]/div[2]/div/span");
        By netCurrentAssetsNRA = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[8]/div[2]/div[2]/div/span");
        By netCapitaNRA = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[9]/div[2]/div[2]/div/span");

        By BuildingNRAUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[7]/div[2]/div/div/span");
        By GeneralTab = By.XPath("//div[@class='property_main_container']/div[3]/div[1]/div/div/button[1]/div");

        By positiveCashFlowInput = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div[2]/div/div[2]/div[6]/div[2]/div/div/span/input");

        //fields labels n values in current cost basis
        By SubuHeader = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div/div/div[1]/label[1]");
        By PurchasePrice = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[2]/div/div[1]/label[1]");
        By AcquisitionloanCosts = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[3]/div/div[1]/label[1]");
        By PreviousAcquisition = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[4]/div/div[1]/label[1]");
        By RenovationCapital = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[5]/div/div[1]/label[1]");
        By LeasingCosts = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[6]/div/div[1]/label[1]");
        By Equipment = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[7]/div/div[1]/label[1]");
        By CarryCost = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[8]/div/div[1]/label[1]");
        By TotalCostBasis = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[9]/div/div[1]/label[1]");

        By PurchasePriceValue = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[2]/div[2]/div[1]/div/span");
        By AcquisitionloanCostsValue = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[3]/div[2]/div[1]/div/span");
        By PreviousAcquisitionValue = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[4]/div[2]/div[1]/div/span");
        By RenovationCapitalValue = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[5]/div[2]/div[1]/div/span");
        By LeasingCostsValue = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[6]/div[2]/div[1]/div/span");
        By EquipmentValue = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[7]/div[2]/div[1]/div/span");
        By CarryCostValue = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[8]/div[2]/div[1]/div/span");
        By TotalCostBasisValue = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[9]/div[2]/div[1]/div/span");

        //Locators to see building nra value for current cost basis table
        By PurchasePriceNRA = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[2]/div[2]/div[2]/div/span");
        By AcquisitionloanCostsNRA = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[3]/div[2]/div[2]/div/span");
        By PreviousAcquisitionNRA = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[4]/div[2]/div[2]/div/span");
        By RenovationCapitalNRA = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[5]/div[2]/div[2]/div/span");
        By LeasingCostsNRA = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[6]/div[2]/div[2]/div/span");
        By EquipmentNRA = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[7]/div[2]/div[2]/div/span");
        By CarryCostNRA = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[8]/div[2]/div[2]/div/span");
        By TotalCostBasisNRA = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[9]/div[2]/div[2]/div/span");


        //Editable values
        By PreviousAcquisitionInput = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[4]/div[2]/div[1]/div/span/input");
        By CarryCostInput = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[8]/div[2]/div[1]/div/span/input");
        By TotalCostBasisInput = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[1]/div/div[2]/div[9]/div[2]/div[1]/div/span/input");

        By AlertText = By.XPath("//div[@class='mainContainer']/div/div/div/div/div/div[2]");

        //Fields label and values in estimated fully funded
        By loanBalancefully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[2]/div/div/label");
        By QuadRealEquityfully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[5]/div/div/label");
        By DRAEquityfully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[3]/div/div/label");
        By fundEquityfully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[3]/div/div/label");
        By streamEquityfully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[4]/div/div/label");
        By totalCapitafully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[5]/div/div/label");
        By loanBalanceValueFully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[2]/div[2]/div/div/span");
        By fundEquityValueFully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[3]/div[2]/div/div/span");
        By streamEquityValueFully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[4]/div[2]/div/div/span");
        By totalCapitaValueFully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[5]/div[2]/div/div/span");
        //Input 
        By loanBalanceInputFully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[2]/div[2]/div/div/span/input");
        By fundEquityInputully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[3]/div[2]/div/div/span/input");
        By streamEquityInputFully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[4]/div[2]/div/div/span/input");

        //Locators for per square feet value in estimated fully funded
        By loanBalanceNRAFully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[2]/div[2]/div[2]/div/span");
        By fundEquityNRAFully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[3]/div[2]/div[2]/div/span");
        By streamEquityNRAFully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[4]/div[2]/div[2]/div/span");
        By totalCapitaNRAFully = By.XPath("//div[@class='tab-workspace']/div/div/div[2]/div[2]/div/div[2]/div[5]/div[2]/div[2]/div/span");

        //field labels in debt information
        By lender = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div/div/div[2]/div[1]/div/div/label");
        By totalCommitment = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div/div/div[2]/div[2]/div/div/label");
        By currentEffective = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div/div/div[2]/div[3]/div/div/label");
        By spreadOver = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div/div/div[2]/div[4]/div/div/label");
        By currentLoanToCost = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div/div/div[2]/div[5]/div/div/label");
        By debtTerms = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div/div/div[2]/div[6]/div/div/label");
        By extenTions = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div/div/div[2]/div[7]/div/div/label");
        By maturity = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div/div/div[2]/div[8]/div/div/label");
        By amortization = By.XPath("//div[@class='tab-workspace']/div/div/div[1]/div/div/div[2]/div[9]/div/div/label");

        // Current Cost Basis 
        By EditSaveIcon_CCB = By.XPath("//label[text()='Current Cost Basis']/parent::div/parent::div/parent::div/div[3]/div[2]");
        By PreAcqLoanCost_CCB = By.XPath("//label[text()='Purchase Price']/parent::div/parent::div/parent::div/parent::div/div[4]/div[2]/div[1]/div/span/input");
        By CarryCost_CCB = By.XPath("//label[text()='Purchase Price']/parent::div/parent::div/parent::div/parent::div/div[8]/div[2]/div[1]/div/span/input");

        By PreAcqLoanCost_CCB_Text = By.XPath("//label[text()='Purchase Price']/parent::div/parent::div/parent::div/parent::div/div[4]/div[2]/div[1]/div/span");
        By CarryCost_CCB_Text = By.XPath("//label[text()='Purchase Price']/parent::div/parent::div/parent::div/parent::div/div[8]/div[2]/div[1]/div/span");

        //Estimated Fully Funded Capitalization
        By EditSaveIcon_EFFC = By.XPath("//label[text()='Estimated Fully Funded Capitalization']/parent::div/parent::div/parent::div/div[3]/div[2]");
        By LoanBalance_EFFC = By.XPath("//label[text()='Loan Balance']/parent::div/parent::div/parent::div/parent::div/div[2]/div[2]/div[1]/div/span/input");
        By FundEquity_EFFC = By.XPath("//label[text()='Loan Balance']/parent::div/parent::div/parent::div/parent::div/div[3]/div[2]/div[1]/div/span/input");
        By StreamEquity_EFFC = By.XPath("//label[text()='Loan Balance']/parent::div/parent::div/parent::div/parent::div/div[4]/div[2]/div[1]/div/span/input");

        By LoanBalance_EFFC_Text = By.XPath("//label[text()='Loan Balance']/parent::div/parent::div/parent::div/parent::div/div[2]/div[2]/div[1]/div/span");
        By FundEquity_EFFC_Text = By.XPath("//label[text()='Loan Balance']/parent::div/parent::div/parent::div/parent::div/div[3]/div[2]/div[1]/div/span");
        By StreamEquity_EFFC_Text = By.XPath("//label[text()='Loan Balance']/parent::div/parent::div/parent::div/parent::div/div[4]/div[2]/div[1]/div/span");


        //Current Capitalization
        By EditSaveIcon_CC = By.XPath("//label[text()='Current Capitalization']/parent::div/parent::div/parent::div/div[3]/div[2]");
        By PostiveCashFlow_CC = By.XPath("//label[text()='Loan Balance']/parent::div/parent::div/parent::div/parent::div/div[6]/div[2]/div[1]/div/span/input");

        By PostiveCashFlow_CC_Text = By.XPath("//label[text()='Loan Balance']/parent::div/parent::div/parent::div/parent::div/div[6]/div[2]/div[1]/div/span");



        public string CaptureText()
        {
            try
            {
                string CapturedText = driver.FindElement(AlertText).Text;
                return CapturedText;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "No pop up";
            }


        }
        public void ClickOnEditSaveIcon(By value)
        {
            driver.FindElement(value).Click();
            Thread.Sleep(2000);
        }
        public void ClearFields(By value)
        {
            driver.FindElement(value).Click();
        }

        public bool EstimatedFullyFundedCapitalization()
        {
            ClickOnEditSaveIcon(EditSaveIcon_EFFC);
            ClearFields(LoanBalance_EFFC);
            ClearFields(FundEquity_EFFC);
            ClearFields(StreamEquity_EFFC);
            ClickOnEditSaveIcon(EditSaveIcon_EFFC);
            string value = CaptureText();
            if (value == "No pop up")
            {
                string value1 = driver.FindElement(LoanBalance_EFFC_Text).Text;
                string value2 = driver.FindElement(FundEquity_EFFC_Text).Text;
                String value3 = driver.FindElement(StreamEquity_EFFC_Text).Text;
                if (value1 == "-" && value2 == "-" && value3 == "-")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }

        }
        public bool CurrentCostBasisWithNullData()
        {
            ClickOnEditSaveIcon(EditSaveIcon_CCB);
            ClearFields(PreAcqLoanCost_CCB);
            ClearFields(CarryCost_CCB);
            ClickOnEditSaveIcon(EditSaveIcon_CCB);
            string value = CaptureText();
            if (value == "No pop up")
            {
                string value1 = driver.FindElement(PreAcqLoanCost_CCB_Text).Text;
                string value2 = driver.FindElement(CarryCost_CCB_Text).Text;
                if (value1 == "-" && value2 == "-")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }

        }

        public bool CurrentCapitalizationWithNullData()
        {
            ClickOnEditSaveIcon(EditSaveIcon_CC);
            ClearFields(PostiveCashFlow_CC);
            ClickOnEditSaveIcon(EditSaveIcon_CC);
            string value = CaptureText();
            if (value == "No pop up")
            {
                string value1 = driver.FindElement(PostiveCashFlow_CC_Text).Text;
                if (value1 == "-")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }

        }
        public void ClickBasisAnddebtTab()
        {
            Thread.Sleep(5000);
            driver.FindElement(BasisDebtTab).Click();
        }
        public String DebtInfoReturnLenderLabel()
        {
            String lenderLabel = driver.FindElement(lender).Text;
            return lenderLabel;
        }
        public String DebtInfoReturnTotalCommitmentLabel()
        {
            String commit = driver.FindElement(totalCommitment).Text;
            return commit;
        }
        public String DebtInfoReturnCurrentEffectiveLabel()
        {
            String currentEffe = driver.FindElement(currentEffective).Text;
            return currentEffe;
        }
        public String DebtInfoReturnSpreadOverLabel()
        {
            String spread = driver.FindElement(spreadOver).Text;
            return spread;
        }
        public String DebtInfoReturnCurrentLoanToCostLabel()
        {
            String loanCost = driver.FindElement(currentLoanToCost).Text;
            return loanCost;
        }
        public String DebtInfoReturnDebtTermsLabel()
        {
            String debtT = driver.FindElement(debtTerms).Text;
            return debtT;
        }
        public String DebtInfoReturnExtentionLabel()
        {
            String exe = driver.FindElement(extenTions).Text;
            return exe;
        }
        public String DebtInfoReturnMaturityLabel()
        {
            String matur = driver.FindElement(maturity).Text;
            return matur;
        }
        public String DebtInfoReturnAmortizationLabel()
        {
            String amorti = driver.FindElement(amortization).Text;
            return amorti;
        }
        public Boolean VerifyDebtInfoLabelsWhenLoanDetailsArePresent()
        {
            String noData = driver.FindElement(NoData_DebtInfo).Text;
            if (noData == "No Data Available")
            {
                return true;
            }
            Boolean res = CollectLabelsForDebtInfoSection();
            return res;
        }
        public Boolean CollectLabelsForDebtInfoSection()
        {
            String lender = DebtInfoReturnLenderLabel();
            String totalCommit = DebtInfoReturnTotalCommitmentLabel();
            String currentEffe = DebtInfoReturnCurrentEffectiveLabel();
            String spread = DebtInfoReturnSpreadOverLabel();
            String currentLoan = DebtInfoReturnCurrentLoanToCostLabel();
            String debtTerms = DebtInfoReturnDebtTermsLabel();
            String extention = DebtInfoReturnExtentionLabel();
            String maturit = DebtInfoReturnMaturityLabel();
            String amort = DebtInfoReturnAmortizationLabel();
            if (lender == "Lender" && totalCommit == "Total Commitment" && currentEffe == "Current Effective Interest Rate"
                && spread == "Spread over 1-Month LIBOR (bps)" && currentLoan == "Current Loan to Cost Ratio" &&
                debtTerms == "Debt Terms (Years)" && extention == "Extension" && maturit == "Maturity" && amort == "Amortization")
            {

                return true;
            }
            return false;
            Random randomGenerator = new Random();
        }
        public String ReturnTableTitle1_DebtInfo()
        {
            String title = driver.FindElement(title_DebtInfo).Text;
            return title;
        }
        public String ReturnTableTitle2_CurrentCapitalization()
        {
            String title = driver.FindElement(title_CurrentCapita).Text;
            return title;
        }
        public String ReturnTableTitle3_CurrentCostBasis()
        {
            String title = driver.FindElement(title_CurrentCostBasis).Text;
            return title;
        }
        public String ReturnTableTitle4_EstimatedFullyFunded()
        {
            String title = driver.FindElement(title_EstimatedFully).Text;
            return title;
        }

        public String ReturnCurrentCapitalization_LoanBalance()
        {
            String loanB = driver.FindElement(loanBalance).Text;
            return loanB;
        }
        public String ReturnCurrentCapitalization_FundEquity()
        {
            String var = driver.FindElement(fundEquity).Text;
            return var;
        }
        public String ReturnCurrentCapitalization_StreamEquity()
        {
            String var = driver.FindElement(streamEquity).Text;
            return var;
        }
        public String ReturnCurrentCapitalization_TotalCapitalization()
        {
            String var = driver.FindElement(totalCapita).Text;
            return var;
        }
        public String ReturnCurrentCapitalization_PositiveCashFlow()
        {
            String var = driver.FindElement(positiveCashFlow).Text;
            return var;
        }
        public String ReturnCurrentCapitalization_DistributionsLabel()
        {
            String dist = driver.FindElement(distributions).Text;
            return dist;
        }
        public String ReturnCurrentCapitalization_NetCurrentAssets()
        {
            String netCur = driver.FindElement(netCurrentAssets).Text;
            return netCur;
        }
        public String ReturnCurrentCapitalization_NetCapitalization()
        {
            String var = driver.FindElement(netCapita).Text;
            return var;
        }
        public String ReturnEstimatedFullyFundedCapitalization_LoanBalance()
        {
            String loanB = driver.FindElement(loanBalancefully).Text;
            return loanB;
        }
        public String ReturnEstimatedFullyFundedCapitalization_FundEquity()
        {
            String var = driver.FindElement(fundEquityfully).Text;
            return var;
        }
        public String ReturnEstimatedFullyFundedCapitalization_StreamEquity()
        {
            String var = driver.FindElement(streamEquityfully).Text;
            return var;
        }
        public String ReturnEstimatedFullyFundedCapitalization_TotalCapitalization()
        {
            String var = driver.FindElement(totalCapitafully).Text;
            return var;
        }
        public String ReturnCurrentCostbasis_PurchasePrice()
        {
            String purchasePrice = driver.FindElement(PurchasePrice).Text;
            return purchasePrice;
        }
        public String ReturnCurrentCostbasis_AcquisitionLoanCosts()
        {
            String acquisitionLoan = driver.FindElement(AcquisitionloanCosts).Text;
            return acquisitionLoan;
        }
        public String ReturnCurrentCostbasis_PreviousAcqLoanCost()
        {
            String previousAcquisition = driver.FindElement(PreviousAcquisition).Text;
            return previousAcquisition;
        }
        public String ReturnCurrentCostbasis_RenovationCapitalCosts()
        {
            String renovation = driver.FindElement(RenovationCapital).Text;
            return renovation;
        }
        public String ReturnCurrentCostbasis_LeasingCostsImprovements()
        {
            String leasingCost = driver.FindElement(LeasingCosts).Text;
            return leasingCost;
        }
        public String ReturnCurrentCostbasis_Equipment()
        {
            String equipment = driver.FindElement(Equipment).Text;
            return equipment;
        }
        public String ReturnCurrentCostbasis_CarryCost()
        {
            String carryCost = driver.FindElement(CarryCost).Text;
            return carryCost;
        }
        public String ReturnCurrentCostbasis_TotalCurrentCostBasis()
        {
            String totalCurrentCost = driver.FindElement(TotalCostBasis).Text;
            return totalCurrentCost;
        }
        public Boolean Edit_CurrentCapitalizationPositiveCashFlow()
        {
            String actualPositive = driver.FindElement(positiveCashFlowValue).Text;
            driver.FindElement(edit_CurrentCapita).Click();
            driver.FindElement(positiveCashFlowInput).Clear();
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(10000, 25000);
            String value = "19" + randomInt;
            driver.FindElement(positiveCashFlowInput).SendKeys(value);
            driver.FindElement(edit_CurrentCapita).Click();
            String newPositive = driver.FindElement(positiveCashFlowValue).Text;
            if (actualPositive != newPositive)
            {
                return true;
            }
            return false;
        }
        public Boolean Edit_EstimatedFullyFundedLoanBalance()
        {
            String actualValue = driver.FindElement(loanBalanceValueFully).Text;
            driver.FindElement(edit_EstimatedFully).Click();
            driver.FindElement(loanBalanceInputFully).Clear();
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(10000, 25000);
            String value = "19" + randomInt;
            driver.FindElement(loanBalanceInputFully).SendKeys(value);
            driver.FindElement(edit_EstimatedFully).Click();
            String updatedValue = driver.FindElement(loanBalanceValueFully).Text;
            if (actualValue != updatedValue)
            {
                return true;
            }
            return false;
        }
        public Boolean Edit_EstimatedFullyFundedFundEquity()
        {
            String actualValue = driver.FindElement(fundEquityValueFully).Text;
            driver.FindElement(edit_EstimatedFully).Click();
            driver.FindElement(fundEquityInputully).Clear();
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(10000, 25000);
            String value = "19" + randomInt;
            driver.FindElement(fundEquityInputully).SendKeys(value);
            driver.FindElement(edit_EstimatedFully).Click();
            String updatedValue = driver.FindElement(fundEquityValueFully).Text;
            if (actualValue != updatedValue)
            {
                return true;
            }
            return false;
        }
        public Boolean Edit_EstimatedFullyFundedStreamEquity()
        {
            String actualValue = driver.FindElement(streamEquityValueFully).Text;
            driver.FindElement(edit_EstimatedFully).Click();
            driver.FindElement(streamEquityInputFully).Clear();
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(10000, 25000);
            String value = "19" + randomInt;
            driver.FindElement(streamEquityInputFully).SendKeys(value);
            driver.FindElement(edit_EstimatedFully).Click();
            String updatedValue = driver.FindElement(streamEquityValueFully).Text;
            if (actualValue != updatedValue)
            {
                return true;
            }
            return false;
        }
        public Boolean EditCurrentCostBasis_UpdatePreviousAcquisition()
        {
            String currentPreviousAcq = driver.FindElement(PreviousAcquisitionValue).Text;
            driver.FindElement(edit_CurrentCostBasis).Click();
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(100000, 100000000);
            String randomValue = "2" + randomInt;
            driver.FindElement(PreviousAcquisitionInput).Clear();
            driver.FindElement(PreviousAcquisitionInput).SendKeys(randomValue);
            driver.FindElement(edit_CurrentCostBasis).Click();
            String updatedPreviousAcq = driver.FindElement(PreviousAcquisitionValue).Text;
            if (currentPreviousAcq != updatedPreviousAcq)
            {
                return true;
            }
            else
                return false;
        }
        public Boolean CurrentCostBasis_UpdateCarryCost()
        {
            String currentCarryCost = driver.FindElement(CarryCostValue).Text;
            driver.FindElement(edit_CurrentCostBasis).Click();
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(100000, 100000000);
            String randomValue = "2" + randomInt;
            driver.FindElement(CarryCostInput).Clear();
            driver.FindElement(CarryCostInput).SendKeys(randomValue);
            driver.FindElement(edit_CurrentCostBasis).Click();
            String updatedCarryCost = driver.FindElement(CarryCostValue).Text;
            if (currentCarryCost != updatedCarryCost)
            {
                return true;
            }
            else
                return false;
        }
        public int CurrentCapitalization_ReturnLoanBalanceValue()
        {
            String currentValue = driver.FindElement(loanBalanceValue).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int CurrentCapitalization_ReturnFundEquityValue()
        {
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
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int CurrentCapitalization_PresentValue_TotalCapitalization()
        {
            String currentValue = driver.FindElement(totalCapitaValue).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int CurrentCapitalization_CalculatedValue_TotalCapitalization()
        {
            int loanB = CurrentCapitalization_ReturnLoanBalanceValue();
            int fundE = CurrentCapitalization_ReturnFundEquityValue();
            int streamE = CurrentCapitalization_ReturnStreamEquityValue();
            int calculatedValue = loanB + fundE + streamE;
            return calculatedValue;
        }
        public int CurrentCapitalization_ReturnPositiveCashFlowValue()
        {
            String currentValue = driver.FindElement(positiveCashFlowValue).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int CurrentCapitalization_ReturnDistributionsValue()
        {
            String currentValue = driver.FindElement(distributionsValue).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int CurrentCapitalization_ReturnNetCurrentAssetsValue()
        {
            String currentValue = driver.FindElement(netCurrentAssetsValue).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int CurrentCapitalization_PresentValue_NetCapitalization()
        {
            String currentValue = driver.FindElement(netCapitaValue).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int CurrentCapitalization_CalculatedValue_NetCapitalization()
        {
            int totalcapitalization = CurrentCapitalization_PresentValue_TotalCapitalization();
            int positiveCash = CurrentCapitalization_ReturnPositiveCashFlowValue();
            int distri = CurrentCapitalization_ReturnDistributionsValue();
            int netAssetv = CurrentCapitalization_ReturnNetCurrentAssetsValue();
            int calculatedValue = totalcapitalization + positiveCash - distri - netAssetv;
            return calculatedValue;
        }
        public int EstimatedFullyFunded_ReturnLoanBalancevalue()
        {
            String currentValue = driver.FindElement(loanBalanceValueFully).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int EstimatedFullyFunded_ReturnFundEquityvalue()
        {
            String currentValue = driver.FindElement(fundEquityValueFully).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int EstimatedFullyFunded_ReturnStreamEquityValue()
        {
            String currentValue = driver.FindElement(streamEquityValueFully).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int EstimatedFullyFunded_PresentValue_TotalCapitalization()
        {
            String currentValue = driver.FindElement(totalCapitaValueFully).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int EstimatedFullyFunded_CalculatedValue_TotalCapitalization()
        {
            int fullyLoan = EstimatedFullyFunded_ReturnLoanBalancevalue();
            int fullyFund = EstimatedFullyFunded_ReturnFundEquityvalue();
            int fullyStream = EstimatedFullyFunded_ReturnStreamEquityValue();
            int total = fullyLoan + fullyFund + fullyStream;
            return total;
        }
        public int CurrentCostBasis_ReturnPurchasePriceCal()
        {
            String currentValue = driver.FindElement(PurchasePriceValue).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int CurrentCostBasis_ReturnAcquisitionAndLoanCostsCalCal()
        {
            String currentValue = driver.FindElement(AcquisitionloanCostsValue).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int CurrentCostBasis_ReturnPreviousAcquisitionLoanCostCal()
        {
            String currentValue = driver.FindElement(PreviousAcquisitionValue).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int CurrentCostBasis_ReturnRenovationCapitalCostsCal()
        {
            String currentValue = driver.FindElement(RenovationCapitalValue).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int CurrentCostBasis_ReturnLeasigCostsAndImprovementsCal()
        {
            String currentValue = driver.FindElement(LeasingCostsValue).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int CurrentCostBasis_ReturnEquipmentCal()
        {
            String currentValue = driver.FindElement(EquipmentValue).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int CurrentCostBasis_ReturnCarryCostCal()
        {
            String currentValue = driver.FindElement(CarryCostValue).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int CurrentCostBasis_CalculatedTotalCurrentCostBasisValue()
        {
            int purchase = CurrentCostBasis_ReturnPurchasePriceCal();
            int AcquisitionAndLoanCosts = CurrentCostBasis_ReturnAcquisitionAndLoanCostsCalCal();
            int PreviousAcqAndLoanCost = CurrentCostBasis_ReturnPreviousAcquisitionLoanCostCal();
            int Renovation = CurrentCostBasis_ReturnRenovationCapitalCostsCal();
            int LeasingCostsAndImprove = CurrentCostBasis_ReturnLeasigCostsAndImprovementsCal();
            int equipment = CurrentCostBasis_ReturnEquipmentCal();
            int carryCost = CurrentCostBasis_ReturnCarryCostCal();
            int CalculatedTotal = purchase + AcquisitionAndLoanCosts + PreviousAcqAndLoanCost + Renovation + LeasingCostsAndImprove + equipment + carryCost;
            return CalculatedTotal;
        }
        public int CurrentCostBasis_PresentValueTotalCurrentCostBasisValue()
        {
            String currentTotal = driver.FindElement(TotalCostBasisValue).Text;
            String removecomma = currentTotal.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public Boolean DebtInfo_VerifyMinimizeMaximize()
        {
            driver.FindElement(max_DebtInfo).Click();
            driver.FindElement(max_DebtInfo).Click();
            Boolean res = driver.FindElement(lender).Displayed;
            return res;
        }
        public Boolean CurrentCapitalization_VerifyMinimizeMaximize()
        {
            driver.FindElement(max_CurrentCapita).Click();
            driver.FindElement(max_CurrentCapita).Click();
            Boolean res = driver.FindElement(totalCapita).Displayed;
            return res;
        }
        public Boolean CurrentCostBasis_VerifyMinimizeMaximize()
        {
            driver.FindElement(max_CurrentCostBasis).Click();
            driver.FindElement(max_CurrentCostBasis).Click();
            Boolean res = driver.FindElement(TotalCostBasis).Displayed;
            return res;
        }
        public Boolean EstimatedFullyFunded_VerifyMinimizeMaximize()
        {
            driver.FindElement(max_EstimatedFully).Click();
            driver.FindElement(max_EstimatedFully).Click();
            Boolean res = driver.FindElement(totalCapitafully).Displayed;
            return res;
        }
        public String CurrentCapitalization_QuadRealEquity()
        {
            AssetPropertyDetailsPage assetPage = new AssetPropertyDetailsPage(BaseTest.driver);
            assetPage.selectPropertyRiverSouth();
            String equity = driver.FindElement(QualRealEquity).Text;
            return equity;
        }
        public String CurrentCapitalization_DRAEquity()
        {
            AssetPropertyDetailsPage assetPage = new AssetPropertyDetailsPage(BaseTest.driver);
            assetPage.selectPropertyQuorum();
            String equity = driver.FindElement(DRAEquity).Text;
            return equity;
        }
        public String EstimatedFullyFunded_QuadRealEquity()
        {
            String equity = driver.FindElement(QuadRealEquityfully).Text;
            return equity;
        }
        public String EstimatedFullyFunded_DRAEquity()
        {
            String equity = driver.FindElement(DRAEquityfully).Text;
            return equity;
        }
        public String CurrentCapitalization_VerifyErrorNoChangesmade()
        {
            driver.FindElement(edit_CurrentCapita).Click();
            driver.FindElement(edit_CurrentCapita).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(AlertText));
            String alertMessage = driver.FindElement(AlertText).Text;
            return alertMessage;
        }
        public String CurrentCostBasis_VerifyErrorNoChangesmade()
        {
            driver.FindElement(edit_CurrentCostBasis).Click();
            driver.FindElement(edit_CurrentCostBasis).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(AlertText));
            String alertMessage = driver.FindElement(AlertText).Text;
            return alertMessage;
        }
        public String EstimatedFullyFunded_VerifyErrorNoChangesmade()
        {
            driver.FindElement(edit_EstimatedFully).Click();
            driver.FindElement(edit_EstimatedFully).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(AlertText));
            String alertMessage = driver.FindElement(AlertText).Text;
            return alertMessage;
        }
        public int GeneralAssetSummary_ReturnBUildingNRaValue()
        {
            driver.FindElement(GeneralTab).Click();
            String nra = driver.FindElement(BuildingNRAUpdated).Text;
            driver.FindElement(BasisDebtTab).Click();
            if (nra == "-")
            { return 0; }
            String NRaWithoutComma = nra.Replace(",", String.Empty);
            int Buildingnra = int.Parse(NRaWithoutComma);
            return Buildingnra;
        }
        public double CurrentCostBasis_ReturnActualPurchasePricePSFValue()
        {
            String initialValue = driver.FindElement(PurchasePriceNRA).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double CurrentCostBasis_CalculatePurchasePricePSFValue()
        {
            int dollarValue = CurrentCostBasis_ReturnPurchasePriceCal();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double CurrentCostBasis_ReturnActualAcquisitionLoanCostPSFValue()
        {
            String initialValue = driver.FindElement(AcquisitionloanCostsNRA).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double CurrentCostBasis_CalculateAcquisitionLoanCostPSFValue()
        {
            int dollarValue = CurrentCostBasis_ReturnAcquisitionAndLoanCostsCalCal();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double CurrentCostBasis_ReturnActualPreviousAcquisitionPSFValue()
        {
            String initialValue = driver.FindElement(PreviousAcquisitionNRA).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double CurrentCostBasis_CalculatePreviousAcquisitionPSFValue()
        {
            int dollarValue = CurrentCostBasis_ReturnPreviousAcquisitionLoanCostCal();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double CurrentCostBasis_ReturnActualRenovationCapitalPSFValue()
        {
            String initialValue = driver.FindElement(RenovationCapitalNRA).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double CurrentCostBasis_CalculateRenovationCapitalPSFValue()
        {
            int dollarValue = CurrentCostBasis_ReturnRenovationCapitalCostsCal();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double CurrentCostBasis_ReturnActualLeasingCostPSFValue()
        {
            String initialValue = driver.FindElement(LeasingCostsNRA).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double CurrentCostBasis_CalculateLeasingCostsPSFValue()
        {
            int dollarValue = CurrentCostBasis_ReturnLeasigCostsAndImprovementsCal();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double CurrentCostBasis_ReturnActualEquipmentPSFValue()
        {
            String initialValue = driver.FindElement(EquipmentNRA).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double CurrentCostBasis_CalculateEquipmentPSFValue()
        {
            int dollarValue = CurrentCostBasis_ReturnEquipmentCal();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double CurrentCostBasis_ReturnActualCarryCostPSFValue()
        {
            String initialValue = driver.FindElement(CarryCostNRA).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double CurrentCostBasis_CalculateCarryCostPSFValue()
        {
            int dollarValue = CurrentCostBasis_ReturnCarryCostCal();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double CurrentCostBasis_ReturnActualTotalCurrentCostPSFValue()
        {
            String initialValue = driver.FindElement(TotalCostBasisNRA).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public int CurrentCostBasis_ReadTotalCurrentCostBasisValue()
        {
            String currentTotal = driver.FindElement(TotalCostBasisValue).Text;
            if (currentTotal == "-")
            {
                return 0;
            }
            String removeSpace = currentTotal.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public double CurrentCostBasis_CalculateTotalCurrentCostPSFValue()
        {
            int dollarValue = CurrentCostBasis_ReadTotalCurrentCostBasisValue();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double CurrentCapitalization_ReturnActualLoanBalancePSFValue()
        {
            String initialValue = driver.FindElement(loanBalanceNRA).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double CurrentCapitalization_CalculateLoanBalancePSFValue()
        {
            int dollarValue = CurrentCapitalization_ReturnLoanBalanceValue();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double CurrentCapitalization_ReturnActualFundEquityPSFValue()
        {
            String initialValue = driver.FindElement(fundEquityNRA).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double CurrentCapitalization_CalculateFundEquityPSFValue()
        {
            int dollarValue = CurrentCapitalization_ReturnFundEquityValue();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double CurrentCapitalization_ReturnActualStreamEquityPSFValue()
        {
            String initialValue = driver.FindElement(streamEquityNRA).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double CurrentCapitalization_CalculateStreamEquityPSFValue()
        {
            int dollarValue = CurrentCapitalization_ReturnStreamEquityValue();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double CurrentCapitalization_ReturnActualTotalCapitalizationPSFValue()
        {
            String initialValue = driver.FindElement(totalCapitaNRA).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double CurrentCapitalization_CalculateTotalCapitalizationPSFValue()
        {
            int dollarValue = CurrentCapitalization_PresentValue_TotalCapitalization();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double CurrentCapitalization_ReturnActualPositiveCashflowPSFValue()
        {
            String initialValue = driver.FindElement(positiveCashFlowNRA).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double CurrentCapitalization_CalculatePositiveCashflowPSFValue()
        {
            int dollarValue = CurrentCapitalization_ReturnPositiveCashFlowValue();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double CurrentCapitalization_ReturnActualDistributionsPSFValue()
        {
            String initialValue = driver.FindElement(distributionsNRA).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double CurrentCapitalization_CalculateDistributionsPSFValue()
        {
            int dollarValue = CurrentCapitalization_ReturnDistributionsValue();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double CurrentCapitalization_ReturnActualNetCurrentAssetsPSFValue()
        {
            String initialValue = driver.FindElement(netCurrentAssetsNRA).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double CurrentCapitalization_CalculateNetCurrentAssetsPSFValue()
        {
            int dollarValue = CurrentCapitalization_ReturnNetCurrentAssetsValue();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double CurrentCapitalization_ReturnActualNetCapitalizationPSFValue()
        {
            String initialValue = driver.FindElement(netCapitaNRA).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double CurrentCapitalization_CalculateNetCapitalizationPSFValue()
        {
            int dollarValue = CurrentCapitalization_PresentValue_NetCapitalization();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double EstimatedCapitalization_ReturnActualLoanBalancePSFValue()
        {
            String initialValue = driver.FindElement(loanBalanceNRAFully).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double EstimatedCapitalization_CalculateLoanBalancePSFValue()
        {
            int dollarValue = EstimatedFullyFunded_ReturnLoanBalancevalue();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double EstimatedCapitalization_ReturnActualFundEquityPSFValue()
        {
            String initialValue = driver.FindElement(fundEquityNRAFully).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double EstimatedCapitalization_CalculateFundEquityPSFValue()
        {
            int dollarValue = EstimatedFullyFunded_ReturnFundEquityvalue();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double EstimatedCapitalization_ReturnActualStreamEquityPSFValue()
        {
            String initialValue = driver.FindElement(streamEquityNRAFully).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double EstimatedCapitalization_CalculateStreamEquityPSFValue()
        {
            int dollarValue = EstimatedFullyFunded_ReturnStreamEquityValue();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
        public double EstimatedCapitalization_ReturnActualTotalcapitalizationPSFValue()
        {
            String initialValue = driver.FindElement(totalCapitaNRAFully).Text;
            if (initialValue == "-")
            {
                return 0;
            }
            double psf = double.Parse(initialValue);
            double roundedValue = Math.Round(psf);
            return roundedValue;
        }
        public double EstimatedCapitalization_CalculateTotalCapitaPSFValue()
        {
            int dollarValue = EstimatedFullyFunded_PresentValue_TotalCapitalization();
            double dollarV = Convert.ToDouble(dollarValue);
            int buildingNRA = GeneralAssetSummary_ReturnBUildingNRaValue();
            double nra = Convert.ToDouble(buildingNRA);
            double PSFValue = dollarV / buildingNRA;
            double roundedValue = Math.Round(PSFValue);
            return roundedValue;
        }
    }
}
