using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoItX3Lib;
using System.Linq.Expressions;

namespace UI_InvestmentMangement.PageObjects
{
    class LoanDetailsPage
    {
        private IWebDriver driver;
        public LoanDetailsPage(IWebDriver driver)
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


        //Locators for loan details screen
        By EditLoanDeatils = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div/div/div/div/div[3]/div[2]");
        By InputTotalCommitment = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div/div/div/div[2]/div/div[2]/div/div/span/input");
        By UpdatedTotalCommitment = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div/div/div/div[2]/div/div[2]/div/div/span");
        By MaxMinLoanDeatils = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div/div/div/div/div[3]/div[2]");

        //Locators for prepayment details
        By EditPrapayment = By.XPath("//*[@id='root']/div/div[3]/div[1]/div/div/div/div[2]/div/div[2]/div[1]/div[2]/div/div[1]/div[3]/div[2]");
        By InputPrepaymentAmount = By.XPath("//label[text()='Prepayment Amount']/parent::div/parent::div/parent::div/div[2]/div/div/span/input");
        By UpdatedPrepaymentAmount = By.XPath("//label[text()='Prepayment Amount']/parent::div/parent::div/parent::div/div[2]/div/div/span");
        By InputPrepaymentNotes = By.XPath("//label[text()='Prepayment Notes']/parent::div/parent::div/parent::div/div[2]/div/div/span/input");
        By UpdatedPrepaymentNotes = By.XPath("//label[text()='Prepayment Notes']/parent::div/parent::div/parent::div/div[2]/div/div/span");
        By CancelIconPrepayment = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div/div[2]/div/div/div[3]/div[3]");
        By InputPrepaymentsDatePicker = By.XPath("//input[@placeholder='Select a date...']");
        By InputPrepaymentsEBAP = By.XPath("//div[4]//div[2]//div[1]//div[1]//span[1]//input[1]");
        By InputPrepaymentsOLBPP = By.XPath("//div[5]//div[2]//div[1]//div[1]//span[1]//input[1]");
        By InputPrepaymentsEFA = By.XPath("//div[6]//div[2]//div[1]//div[1]//span[1]//input[1]");
        By InputPrepaymentsEFP = By.XPath("//div[7]//div[2]//div[1]//div[1]//span[1]//input[1]");
        By AlertPopUp = By.XPath("//*[@id='root']/div/div[1]/div/div/div[1]/div/div[2]");
        By InputPrepaymentSelect = By.XPath("//select[@class='select-css']");
        //xpath to verify enterted value in prepayment 
        By CapturedTextPreAmount = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div/div[1]/div[2]/div/div[2]/div[1]/div[2]/div/div/span");
        By CapturedTextPreNotes = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div/div[1]/div[2]/div/div[2]/div[2]/div[2]/div/div");
        By CapturedTextPreCalcDate = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/div[1]/div[2]/div/div[2]/div[3]/div[2]/div/div/span");
        By CapturedPreAmountEBAP = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div/div[1]/div[2]/div/div[2]/div[4]/div[2]/div/div");
        By CapturedPreOLBPP = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div/div[1]/div[2]/div/div[2]/div[5]/div[2]/div/div");
        By CapturedPreEFA = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div/div[1]/div[2]/div/div[2]/div[6]/div[2]/div/div");
        By CapturedPreEFP = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div/div[1]/div[2]/div/div[2]/div[7]/div[2]/div/div");
        By CapturedPrePT = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div/div[1]/div[2]/div/div[2]/div[8]/div[2]/div/div");

        //Locators for Hedging instrument details

        By CapturedTextHedInstType = By.XPath("//body/div[@id='root']/div/div/div/div/div/div/div/div/div/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/span[1]");
        By EditHedging = By.XPath("//label[text()='Hedging Instrument']/parent::div/parent::div/parent::div/div[3]/div[3]");
        By SaveHedging = By.CssSelector("[data-tip='Save']");
        By SelectHedging = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div/span/select");
        By CapRate = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div/div/div[2]/div[2]/div[2]/div/div/span/input");
        By SwapRate = By.XPath("//label[text()='Swap Rate']/parent::div/parent::div/parent::div/div[2]/div/div/span/input");
        By ExpirationDate = By.XPath("//input[@placeholder='Select a date...']");
        By UpdatedCapRate = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div/div/div[2]/div[2]/div[2]/div/div/span");
        By ClearHedging = By.XPath("//div[@class='maintenance-card-body']/div/div/div[2]/div/div/div/div[3]/div");
        By ClearPopUp = By.XPath("//div[@class='modal confirmPopup']/div[2]/div/button");
        By InstrumentHedgingAfterClear = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div/span");
        By MaxMinHedging = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div/div/div/div[3]/div[4]");
        By SaveDataPopUpHedging = By.XPath("//*[@id='root']/div/div[1]/div/div/div[1]/div/div[2]");
        By inputNotesHedging = By.XPath("//label[text()='Notes']/parent::div/parent::div/parent::div/div[2]/div/div/span/input");
        By CapturedTextHedgingNotes = By.XPath("//label[text()='Notes']/parent::div/parent::div/parent::div/div[2]/div/div/span");
        By CapturedTextExpirationDate = By.XPath("//label[text()='Expiration Date']/parent::div/parent::div/parent::div/div[2]/div/div/span");
        By CapturedTextSwapRate = By.XPath("//label[text()='Swap Rate']/parent::div/parent::div/parent::div/div[2]/div/div/span");

        //Locators for extentions details
        By EditExtention = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div/div[2]/div[3]/div/div/div[1]/div[3]/div[3]");
        By AddExtention = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[3]/div/div/div/div[3]/div[2]");
        By InputaddExtention = By.XPath("//input[@placeholder='Select a date...']");
        By SaveExtension = By.XPath("//div[@id='root']/div/div[3]/div/div/div/div[2]/div/div/div[2]/div[3]/div/div/div[1]/div[3]/div[3]");
        By YearInExt = By.XPath("//select[@class='react-datepicker__year-select']");
        By DayInExt = By.XPath("//div[@class='react-datepicker__day react-datepicker__day--015']");
        By UpdatedExtention = By.XPath("//div[@id='root']/div/div[3]/div/div/div/div[2]/div/div/div[2]/div[3]/div/div/div[2]/div[2]/div[2]/div/div/span");
        By InputExtention = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[3]/div/div/div[2]/div[2]/div[2]/div/div/span/div/div/input");
        By MaxMinExtention = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[3]/div/div/div/div[3]/div[4]");


        //xpath Menu : This will verify all the lables 
        By MenuIcon = By.XPath("//input[@class='menu_checkbox']");
        By LoanMaintainace_button = By.XPath("//*[@id='root']/div/div[2]/div/div[5]/div/div[2]/div[4]/div[1]/a");
        By LoanMaintainace_card = By.XPath("//div[4]//div[1]//div[1]//div[1]//div[2]//div[1]//div[1]//span[1]");
        // By LoanMaintainace_card = By.LinkText("Loan Maintenance");

        //Xpath loan details page 
        By LoanDetails_Card_Loan_Title = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/div[1]/div[1]/div/div[1]/div[2]");
        By LoanMaintainace_Card_TC = By.XPath("//label[contains(text(),'Total Commitment')]"); //total commitment
        By LoanMaintainace_Card_OD = By.XPath("//label[contains(text(),'Origination Date')]"); // original date
        By LoanMaintainace_Card_IM = By.XPath("//label[contains(text(),'Initial Maturity')]"); //Initial maturity
        By LoanMaintainace_Card_TM = By.XPath("//label[contains(text(),'Term (Months)')]"); //Term month
        By LoanMaintainace_Card_CM = By.XPath("//label[contains(text(),'Current Maturity')]");// Current Maturity 
        By LoanMaintainace_Card_OA = By.XPath("//label[contains(text(),'Outstanding Amount')]");  //outstanding amount
        By LoanMaintainace_Card_Lender = By.XPath("//label[contains(text(),'Lender')]");
        By LoanMaintainace_Card_LT = By.XPath("//label[contains(text(),'Loan Type')]");
        By LoanMaintainace_Card_LenderType = By.XPath("//label[contains(text(),'Lender Type')]");
        By LoanMaintainace_Card_Inter_Rate_Type = By.XPath("//label[contains(text(),'Interest Rate Type')]");
        By LoanMaintainace_Card_Fixed_Rate = By.XPath("//label[contains(text(),'Spread')]");


        //HEDGING INSTRUMENT
        By LoanDetail_HEDGING_Title = By.XPath("//label[contains(text(),'Hedging Instrument')]");
        By LoanDetail_HEDGING_Instru_Type = By.XPath("//label[contains(text(),'Hedging Instrument Type')]");
        By LoanDetail_HEDGING_TTHedgeMaturity = By.XPath("//label[contains(text(),'Term To Hedge Maturity')]");
        By LoanDetail_HEDGING_ExpirationDate = By.XPath("//label[contains(text(),'Expiration Date')]");
        By LoanDetail_HEDGING_Notes = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div/div[2]/div[1]/div/div[2]/div[4]/div[1]/div/label");


        //AMORTIZATION
        By LoanDetail_AMORTIZATION_Title = By.XPath("//label[contains(text(),'Amortization ')]");
        By LoanDetail_AMORTIZATION_InterestRate = By.XPath("//label[contains(text(),'Amortization Interest Rate')]");
        By LoanDetail_AMORTIZATION_InterestOnlyPeriod_Month = By.XPath("//label[contains(text(),'Interest Only Period (Months)')]");
        By LoanDetail_AMORTIZATION_InterestOnlyPeriod_Year = By.XPath("//label[contains(text(),'Amortization Period (Years)')]");
        By LoanDetail_AMORTIZATION_Amortization_calc_Method = By.XPath("//label[contains(text(),'Amortization Calc Method')]");


        //Term + Extension Options
        By LoanDetail_TE_Title = By.XPath("//label[contains(text(),'Term + Extension Options')]");
        By LoanDetail_TE_Extension_Number = By.XPath("//label[contains(text(),'Extension Number')]");
        By LoanDetail_TE_Extension_MaturityDate = By.XPath("//label[contains(text(),'Extension Maturity Date')]");



        //PREPAYMENT 
        By LoanDetails_Preapayment_Title = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div/div[1]/div[2]/div/div[1]/div[2]");
        By LoanDetails_Preapayment_Amount = By.XPath("//label[contains(text(),'Prepayment Amount')]");
        By LoanDetails_Preapayment_Notes = By.XPath("//label[contains(text(),'Prepayment Notes')]");
        By LoanDetails_Preapayment_Calc_Date = By.XPath("//label[contains(text(),'Prepayment Calc Date')]");
        By LoanDetails_Preapayment_EBA_PatOff = By.XPath("//label[contains(text(),'Estimated Balance at Payoff')]");
        By LoanDetails_Preapayment_OLB_PenaltyAct = By.XPath("//label[contains(text(),'Outstanding Loan Balance Penalty Pct')]");
        By LoanDetails_Preapayment_EF_Account = By.XPath("//label[contains(text(),'Exit Fee Amount')]");
        By LoanDetails_Preapayment_Exit_Fee_Pct = By.XPath("//label[contains(text(),'Exit Fee Pct')]");
        By LoanDetails_Preapayment_Payment_Type = By.XPath("//label[contains(text(),'Prepayment Type')]");


        //Locators for Amortization details
        By EditAmortizationIcon = By.XPath("//label[text()='Amortization ']/parent::div/parent::div/parent::div/div[3]/div[2]");
        By SaveAmortizationIcon = By.CssSelector("[data-tip='Save']");
        By PopUpAlertAmorization = By.XPath("//*[@id='root']/div/div[1]/div/div/div[1]/div/div[2]");
        By InputAmorizationIR = By.XPath("//label[text()='Amortization Interest Rate']/parent::div/parent::div/parent::div/div[2]/div/div/span/input");
        By InputAmorizationIOPM = By.XPath("//label[text()='Interest Only Period (Months)']/parent::div/parent::div/parent::div/div[2]/div/div/span/input");
        By InputAmorizationAPY = By.XPath("//label[text()='Amortization Period (Years)']/parent::div/parent::div/parent::div/div[2]/div/div/span/input");
        By InputAmorizationACM = By.XPath("//label[text()='Amortization Calc Method']/parent::div/parent::div/parent::div/div[2]/div/div/span/input");

        By CapturedTextAmorizationIR = By.XPath("//label[text()='Amortization Interest Rate']/parent::div/parent::div/parent::div/div[2]/div/div/span");
        By CapturedTextAmorizationIOPM = By.XPath("//label[text()='Interest Only Period (Months)']/parent::div/parent::div/parent::div/div[2]/div/div/span");
        By CapTuredTextAmorizationAPY = By.XPath("//label[text()='Amortization Period (Years)']/parent::div/parent::div/parent::div/div[2]/div/div/span");
        By CapturedTextAmorizationACM = By.XPath("//label[text()='Amortization Calc Method']/parent::div/parent::div/parent::div/div[2]/div/div/span");
        //   By InputAmorizationIOPM = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div[2]/div[2]/div/div/span/input");

        By AmortizationIntrest = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[2]/div/div[2]/div/div[2]/div/div/span/input");
        By UpdatedAmortIntrest = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[2]/div/div[2]/div/div[2]/div/div/span");
        By MaxMinAmortization = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div[2]/div[2]/div/div/div[3]/div[3]");


        By NoDataAvailable = By.XPath("//*[@id='stickytypeheader']/div/div[2]/div");

        By asOfData = By.XPath("//*[@id='root']/div/div[2]/div/div[4]/div[2]/div/div/div/div");
        By asOFDateDropdown = By.XPath("//input[@id='as-of-date-box-header']");

        By Card = By.XPath("//div[@class='row']");
        By SearchIcon = By.XPath("//input[@placeholder='Type to search...']");
        By LoanDetail_TotalCommitment_Input = By.XPath("//label[text()='Total Commitment']/parent::div/parent::div/parent::div/div[2]/div/div/span/input");
        By CaptureHedgingExpDate = By.XPath("//label[text()='Expiration Date']/parent::div/parent::div/parent::div/div[2]/div/div/span");

        public void checkDataAvailability()
        {

            Thread.Sleep(5000);

            DateTime d = DateTime.Now;
            d = d.AddMonths(-1);
            string c = d.ToString("MM/yyyy");

            Console.WriteLine(c);

        }

        public void ClickTrackRecordOnInMenu()
        {
            Thread.Sleep(5000);
            driver.FindElement(MenuIcon).Click();
            driver.FindElement(LoanMaintainace_button).Click();
            Thread.Sleep(1000);
        }


        public void ClickOnCardDetails()
        {
            driver.FindElement(LoanMaintainace_card).Click();

        }
        //loan details page 
        public String getText_LOANDETAILS()
        {
            String loanTitle = driver.FindElement(LoanDetails_Card_Loan_Title).Text;
            Console.WriteLine(loanTitle);
            return loanTitle;
        }

        public String getText_LOANDETAILS_TC()
        {
            String TC = driver.FindElement(LoanMaintainace_Card_TC).Text;
            return TC;
        }

        public String getText_LOANDETAILS_OD()
        {
            String OD = driver.FindElement(LoanMaintainace_Card_OD).Text;
            return OD;

        }

        public String getText_LOANDETAILS_IM()
        {
            String IM = driver.FindElement(LoanMaintainace_Card_IM).Text;
            return IM;

        }

        public String getText_LOANDETAILS_TM()
        {
            String TM = driver.FindElement(LoanMaintainace_Card_TM).Text;
            return TM;

        }

        public String getText_LOANDETAILS_CM()
        {
            String CM = driver.FindElement(LoanMaintainace_Card_CM).Text;
            return CM;
        }

        public String getText_LOANDETAILS_OA()
        {
            String OA = driver.FindElement(LoanMaintainace_Card_OA).Text;
            return OA;
        }

        public String getText_LOANDETAILS_Lender()
        {
            String Lender = driver.FindElement(LoanMaintainace_Card_Lender).Text;
            return Lender;
        }

        public String getText_LOANDETAILS_LoanType()
        {
            String LoanType = driver.FindElement(LoanMaintainace_Card_LT).Text;
            return LoanType;
        }


        public String getText_LOANDETAILS_LenderType()
        {
            String LenderType = driver.FindElement(LoanMaintainace_Card_LenderType).Text;
            return LenderType;
        }


        public String getText_LOANDETAILS_IRateType()
        {
            String RateType = driver.FindElement(LoanMaintainace_Card_Inter_Rate_Type).Text;
            return RateType;
        }

        public String getText_LOANDETAILS_IntRateType()
        {
            String IntRateType = driver.FindElement(LoanMaintainace_Card_Inter_Rate_Type).Text;
            return IntRateType;
        }


        //HEDGING INSTRUMENT

        public String getText_LoanDetail_HEDGING_Title()
        {
            String HEDGING_Title = driver.FindElement(LoanDetail_HEDGING_Title).Text;
            return HEDGING_Title;
        }


        public String getText_LoanDetail_HEDGING_Instru_Type()
        {
            String Hedging_IT = driver.FindElement(LoanDetail_HEDGING_Instru_Type).Text;
            return Hedging_IT;
        }

        public String getText_LoanDetail_HEDGING_TTHedgeMaturity()
        {
            String Hedging_TTHM = driver.FindElement(LoanDetail_HEDGING_TTHedgeMaturity).Text;
            return Hedging_TTHM;
        }

        public String getText_LoanDetail_HEDGING_ExpirationDate()
        {
            String Hedging_ED = driver.FindElement(LoanDetail_HEDGING_ExpirationDate).Text;
            return Hedging_ED;
        }

        public String getText_LoanDetail_HEDGING_Notes()
        {
            String Hedging_HN = driver.FindElement(LoanDetail_HEDGING_Notes).Text;
            return Hedging_HN;
        }


        ////AMORTIZATION
        public String getText_LoanDetail_AMORTIZATION_Title()
        {
            String Amorization_Title = driver.FindElement(LoanDetail_AMORTIZATION_Title).Text;
            return Amorization_Title;
        }

        public String getText_LoanDetail_AMORTIZATION_InterestRate()
        {
            String Amorization_InterestRate = driver.FindElement(LoanDetail_AMORTIZATION_InterestRate).Text;
            return Amorization_InterestRate;
        }

        public String getText_LoanDetail_AMORTIZATION_InterestOnlyPeriod_Month()
        {
            String Amorization_InterestOnlyPeriod_Month = driver.FindElement(LoanDetail_AMORTIZATION_InterestOnlyPeriod_Month).Text;
            return Amorization_InterestOnlyPeriod_Month;
        }

        public String getText_LoanDetail_AMORTIZATION_InterestOnlyPeriod_Year()
        {
            String Amorization_InterestOnlyPeriod_Year = driver.FindElement(LoanDetail_AMORTIZATION_InterestOnlyPeriod_Year).Text;
            return Amorization_InterestOnlyPeriod_Year;
        }

        public String getTextLoanDetail_AMORTIZATION_Amortization_Calc_Method()
        {
            String Amorization_Calc_Method = driver.FindElement(LoanDetail_AMORTIZATION_Amortization_calc_Method).Text;
            return Amorization_Calc_Method;
        }

        //Term + Extension Options methods

        public String getText_LoanDetail_TE_Title()
        {
            String Amorization_TE_Title = driver.FindElement(LoanDetail_TE_Title).Text;
            return Amorization_TE_Title;
        }

        public String getText_LoanDetail_TE_Extension_Number()
        {
            String Amorization_Ext_Number = driver.FindElement(LoanDetail_TE_Extension_Number).Text;
            return Amorization_Ext_Number;
        }

        public String getText_LoanDetail_TE_Extension_MaturityDate()
        {
            String Amorization_Mat_Date = driver.FindElement(LoanDetail_TE_Extension_MaturityDate).Text;
            return Amorization_Mat_Date;
        }




        public String getText_LoanDetails_Preapayment_Title()
        {
            String Prepayment_Title = driver.FindElement(LoanDetails_Preapayment_Title).Text;
            return Prepayment_Title;
        }

        public String getText_LoanDetails_Preapayment_Amount()
        {
            String Prepayment_Amount = driver.FindElement(LoanDetails_Preapayment_Amount).Text;
            return Prepayment_Amount;
        }

        public String getText_LoanDetails_Preapayment_Notes()
        {
            String Prepayment_Notes = driver.FindElement(LoanDetails_Preapayment_Notes).Text;
            return Prepayment_Notes;
        }

        public String getText_LoanDetails_Preapayment_Calc_Date()
        {
            String Prepayment_Calc_Date = driver.FindElement(LoanDetails_Preapayment_Calc_Date).Text;
            return Prepayment_Calc_Date;
        }
        public String getText_LoanDetails_Preapayment_EBA_PatOff()
        {
            String Prepayment_EBA_PatOff = driver.FindElement(LoanDetails_Preapayment_EBA_PatOff).Text;
            return Prepayment_EBA_PatOff;
        }
        public String getText_LoanDetails_Preapayment_OLB_PenaltyAct()
        {
            String Prepayment_OLB_PenaltyAct = driver.FindElement(LoanDetails_Preapayment_OLB_PenaltyAct).Text;
            return Prepayment_OLB_PenaltyAct;
        }

        public String getText_LoanDetails_Preapayment_Exit_Fee_Pct()
        {
            String Prepayment_Exit_Fee_Pct = driver.FindElement(LoanDetails_Preapayment_Exit_Fee_Pct).Text;
            return Prepayment_Exit_Fee_Pct;
        }


        public String getText_LoanDetails_Preapayment_EF_Account()
        {
            String Prepayment_EF_Account = driver.FindElement(LoanDetails_Preapayment_Payment_Type).Text;
            return Prepayment_EF_Account;
        }


        public Boolean EditAndUpdateLoanCommitment()
        {
            try
            {
                var elementToClick = driver.FindElement(EditLoanDeatils);
                Actions action = new Actions(driver);
                action.Click(elementToClick).Build().Perform();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            driver.FindElement(InputTotalCommitment).Clear();
            driver.FindElement(InputTotalCommitment).SendKeys("10000");
            driver.FindElement(EditLoanDeatils).Click();
            Thread.Sleep(3000);
            String commitment = driver.FindElement(UpdatedTotalCommitment).Text;
            if (commitment == "$10,000")
            {
                return true;
            }
            return false;
        }

        //Checking all the prepayment fields are editable or not 
        public void EditPrepayment()
        {
            driver.FindElement(EditPrapayment).Click();
            Thread.Sleep(3000);

        }


        public void AddingValidDataInPrepayment() //Adding a valid data into prepayment 
        {


            driver.FindElement(InputPrepaymentAmount).Clear();
            Thread.Sleep(1000);
            driver.FindElement(InputPrepaymentAmount).SendKeys("1111");
            Thread.Sleep(2000);

            driver.FindElement(InputPrepaymentNotes).Clear();
            Thread.Sleep(1000);
            driver.FindElement(InputPrepaymentNotes).SendKeys("Testing");
            Thread.Sleep(2000);

            driver.FindElement(InputPrepaymentsDatePicker).Clear();
            //driver.FindElement(InputPrepaymentsDatePicker).Click();
            Thread.Sleep(2000);

            //To select Month from date picker
            By Prepayment_DatePicker_Month = By.XPath("//select[@class='react-datepicker__month-select']");
            IWebElement dropdownMonth = driver.FindElement(Prepayment_DatePicker_Month);
            SelectElement datePickerMonth = new SelectElement(dropdownMonth);
            datePickerMonth.SelectByText("December");

            // To select year from date picker 
            Thread.Sleep(2000);

            By Prepayment_DatePicker_Year = By.XPath("//select[@class='react-datepicker__year-select']");
            IWebElement dropdownYear = driver.FindElement(Prepayment_DatePicker_Year);
            SelectElement datePickerYear = new SelectElement(dropdownYear);
            datePickerYear.SelectByText("2020");

            Thread.Sleep(2000);
            By Prepayment_DatePicker_Day = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div/div[1]/div[2]/div/div[2]/div[3]/div[2]/div/div/span/div[2]/div[2]/div/div/div[2]/div[2]/div[2]/div[4]");
            driver.FindElement(Prepayment_DatePicker_Day).Click();
            Thread.Sleep(2000);


            //driver.FindElement(InputPrepaymentsDatePicker).SendKeys("10/01/2020");
            Thread.Sleep(2000);

            driver.FindElement(InputPrepaymentsEBAP).Clear();
            Thread.Sleep(1000);
            driver.FindElement(InputPrepaymentsEBAP).SendKeys("111");
            Thread.Sleep(2000);

            driver.FindElement(InputPrepaymentsOLBPP).Clear();
            Thread.Sleep(1000);
            driver.FindElement(InputPrepaymentsOLBPP).SendKeys("1111");
            Thread.Sleep(2000);

            driver.FindElement(InputPrepaymentsEFA).Clear();
            Thread.Sleep(1000);
            driver.FindElement(InputPrepaymentsEFA).SendKeys("111");
            Thread.Sleep(2000);


            driver.FindElement(InputPrepaymentsEFP).Clear();
            Thread.Sleep(1000);
            driver.FindElement(InputPrepaymentsEFP).SendKeys("111");
            Thread.Sleep(2000);

            IWebElement dropdown = driver.FindElement(InputPrepaymentSelect);
            Thread.Sleep(1000);
            SelectElement s = new SelectElement(dropdown);
            //s.SelectByText("String");
            Thread.Sleep(2000);
            s.SelectByIndex(2);

            Thread.Sleep(3000);
        }

        public void VerifyPREPAYValidDetails()
        {
            string CapturedValuePA = driver.FindElement(CapturedTextPreAmount).Text;

            if (CapturedValuePA == "-")
            {
                EditPrepayment();
                AddingValidDataInPrepayment();
                ClickOnSavePrepaymentButton();

            }

            else
            {

                //1
                String withoutComma = CapturedValuePA.Replace(",", String.Empty);
                String withoutPerc = withoutComma.Replace("$", String.Empty);
                String ao = withoutPerc.Replace("$", String.Empty);
                int existingV1 = int.Parse(withoutPerc);
                int PA = existingV1 + 5;
                String Value_PA = PA.ToString();



                //2
                string CapturedValuePN = driver.FindElement(CapturedTextPreNotes).Text;
                Random randomGenerator = new Random();
                int randomInt = randomGenerator.Next(10000, 25000);
                String PN = CapturedValuePN + randomInt;
                String Value_PN = PN.ToString();


                //3 Date


                //4 EBAP

                String CapturedValueEBAP = driver.FindElement(CapturedPreAmountEBAP).Text;

                String CommaRemoveEBAP = CapturedValueEBAP.Replace(",", String.Empty);
                String DollarRemovedEBAP = CommaRemoveEBAP.Replace("$", String.Empty);
                int existingV4 = int.Parse(DollarRemovedEBAP);
                int EBAP = existingV4 + 100;
                String Value_EBAP = EBAP.ToString();


                //OLBPC

                string CapturedValueOLBPP = driver.FindElement(CapturedPreOLBPP).Text;
                String PerRemoveOLBPC = CapturedValueOLBPP.Replace("%", String.Empty);
                int existingV5 = int.Parse(PerRemoveOLBPC);
                int OLBPC = existingV5 + 100;
                String Value_OLBPC = OLBPC.ToString();


                //EFA 
                string CapturedValueEFA = driver.FindElement(CapturedPreEFA).Text;
                String CommaRemoveEFA = CapturedValueEFA.Replace(",", String.Empty);
                String PerRemoveEFA = CommaRemoveEFA.Replace("$", String.Empty);
                int existingV6 = int.Parse(PerRemoveEFA);
                int EFA = existingV6 + 100;
                String Value_EFA = EFA.ToString();



                //EFP
                string CapturedValueEFP = driver.FindElement(CapturedPreEFP).Text;
                String CommaRemoveEFP = CapturedValueEFP.Replace("%", String.Empty);
                int existingV7 = int.Parse(CommaRemoveEFP);
                int EFP = existingV7 + 100;
                String Value_EFP = EFP.ToString();




                //PT This is select dropdown value 

                string CapturedValuePT = driver.FindElement(CapturedPrePT).Text;

                EditPrepayment();

                driver.FindElement(InputPrepaymentAmount).Clear();
                Thread.Sleep(1000);
                driver.FindElement(InputPrepaymentAmount).SendKeys(Value_PA);
                Thread.Sleep(2000);

                driver.FindElement(InputPrepaymentNotes).Clear();
                Thread.Sleep(1000);
                driver.FindElement(InputPrepaymentNotes).SendKeys(Value_PN);
                Thread.Sleep(2000);
                /*
                driver.FindElement(InputPrepaymentsDatePicker).Clear();
                //driver.FindElement(InputPrepaymentsDatePicker).Click();
                Thread.Sleep(2000);

                //To select Month from date picker
                By Prepayment_DatePicker_Month = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/div[1]/div[2]/div/div[2]/div[3]/div[2]/div/div/span/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[1]/select");
                IWebElement dropdownMonth = driver.FindElement(Prepayment_DatePicker_Month);
                SelectElement datePickerMonth = new SelectElement(dropdownMonth);
                datePickerMonth.SelectByText("December");

                // To select year from date picker 
                Thread.Sleep(2000);

                By Prepayment_DatePicker_Year = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/div[1]/div[2]/div/div[2]/div[3]/div[2]/div/div/span/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[2]/select");
                IWebElement dropdownYear = driver.FindElement(Prepayment_DatePicker_Year);
                SelectElement datePickerYear = new SelectElement(dropdownYear);
                datePickerYear.SelectByText("2020");
                

                Thread.Sleep(2000);
                By Prepayment_DatePicker_Day = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/div[1]/div[2]/div/div[2]/div[3]/div[2]/div/div/span/div[2]/div[2]/div/div/div[2]/div[2]/div[4]/div[2]");
                driver.FindElement(Prepayment_DatePicker_Day).Click();
                Thread.Sleep(2000);
                */

                //driver.FindElement(InputPrepaymentsDatePicker).SendKeys("10/01/2020");
                Thread.Sleep(2000);

                driver.FindElement(InputPrepaymentsEBAP).Clear();
                Thread.Sleep(1000);
                driver.FindElement(InputPrepaymentsEBAP).SendKeys(Value_EBAP);
                Thread.Sleep(2000);

                driver.FindElement(InputPrepaymentsOLBPP).Clear();
                Thread.Sleep(1000);
                driver.FindElement(InputPrepaymentsOLBPP).SendKeys(Value_OLBPC);
                Thread.Sleep(2000);

                driver.FindElement(InputPrepaymentsEFA).Clear();
                Thread.Sleep(1000);
                driver.FindElement(InputPrepaymentsEFA).SendKeys(Value_EFA);
                Thread.Sleep(2000);


                driver.FindElement(InputPrepaymentsEFP).Clear();
                Thread.Sleep(1000);
                driver.FindElement(InputPrepaymentsEFP).SendKeys(Value_EFP);
                Thread.Sleep(2000);

                IWebElement dropdown = driver.FindElement(InputPrepaymentSelect);
                Thread.Sleep(1000);
                SelectElement s = new SelectElement(dropdown);
                //s.SelectByText("String");
                Thread.Sleep(2000);
                s.SelectByIndex(2);

                Thread.Sleep(3000);

                ClickOnSavePrepaymentButton();


            }
        }

        public void ClickOnSavePrepaymentButton() //without adding a data into prepayment 
        {
            driver.FindElement(LoanSaveIcon).Click();
            Thread.Sleep(2000);
        }
        public string CaptureAlertMessage() //without adding a data into prepayment 
        {
            try
            {
                String alertMessage = driver.FindElement(AlertPopUp).Text;
                return alertMessage;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return "No pop up found to capture text";
        }


        public Boolean EditAndUpdatePrepaymentAmountBoolValue()
        {

            bool PrePayvalue = driver.FindElement(InputPrepaymentAmount).Enabled;
            Console.WriteLine(PrePayvalue);
            return PrePayvalue;


            // String preAmount = driver.FindElement(UpdatedPrepaymentAmount).Text;
            // Thread.Sleep(3000);
            // 
        }
        public Boolean EditAndUpdatePrepaymentNotesBoolvalue()
        {
            bool NotesValue = driver.FindElement(InputPrepaymentNotes).Enabled;
            return NotesValue;
        }

        public Boolean EditAndUpdatePrepaymentDatePickerBoolvalue()
        {
            bool DateValue = driver.FindElement(InputPrepaymentsDatePicker).Enabled;
            return DateValue;
        }

        public Boolean EditAndUpdatePrepaymentEBAPBoolvalue()
        {
            bool EBAPValue = driver.FindElement(InputPrepaymentsEBAP).Enabled;
            return EBAPValue;
        }

        public Boolean EditAndUpdatePrepaymentOLBPPBoolvalue()
        {
            bool OLBPPValue = driver.FindElement(InputPrepaymentsOLBPP).Enabled;
            return OLBPPValue;
        }

        public Boolean EditAndUpdatePrepaymentEFABoolvalue()
        {
            bool EFAValue = driver.FindElement(InputPrepaymentsEFA).Enabled;
            return EFAValue;
        }



        // To udpate the prepayment notes 
        public Boolean EditAndUpdatePrepaymentNotes()
        {
            driver.FindElement(EditPrapayment).Click();
            driver.FindElement(InputPrepaymentNotes).Clear();
            driver.FindElement(InputPrepaymentNotes).SendKeys("This is test text");
            driver.FindElement(EditPrapayment).Click();
            Thread.Sleep(3000);
            String paymentnotes = driver.FindElement(UpdatedPrepaymentNotes).Text;
            if (paymentnotes == "This is test text")
            {
                return true;
            }
            return false;
        }


        public void ClickOnHedgingEditIcon()
        {
            driver.FindElement(EditHedging).Click();

        }
        public void ClickOnHedgingSaveIcon()
        {
            driver.FindElement(SaveHedging).Click();

        }


        public void ClickOnHedgingSelectDropdown()
        {

            driver.FindElement(SelectHedging).Click();

        }

        public void randomText()
        {
            Random randGen = new Random();
            int randomINT = randGen.Next(10, 100);
            string PNN = "test" + randomINT;
            string Value_PNN = PNN.ToString();
            Console.WriteLine(Value_PNN);
        }

        public bool capHedging()
        {


            ClickOnHedgingEditIcon();
            ClickOnHedgingSelectDropdown();
            SelectElement hedgeing = new SelectElement(driver.FindElement(SelectHedging));
            hedgeing.SelectByText("Swap");
            driver.FindElement(CapRate).Clear();

            Random randomGenerator1 = new Random();
            int randomIntt = randomGenerator1.Next(1, 9);
            string VaLEnterCaprate = randomIntt.ToString();

            String ValueNot = "test" + randomIntt;
            String ValueNotes = ValueNot.ToString();

            Thread.Sleep(1000);
            driver.FindElement(CapRate).SendKeys(VaLEnterCaprate);
            Thread.Sleep(2000);

            By InputNotesHedgingNotes = By.XPath("//label[text()='Hedging Instrument Type']/parent::div/parent::div/parent::div/parent::div/div[5]/div[2]/div/div/span/input");
            driver.FindElement(InputNotesHedgingNotes).Clear();
            Thread.Sleep(1000);
            driver.FindElement(InputNotesHedgingNotes).SendKeys(ValueNotes);
            Thread.Sleep(1000);
            driver.FindElement(EditHedging).Click();
            String caprate = driver.FindElement(UpdatedCapRate).Text;

            String Notes = driver.FindElement(CapturedTextHedgingNotes).Text;
            //String withoutSpaces = Notes.Replace("", String.Empty);


            String withoutComma = caprate.Replace("%", String.Empty);

            if (caprate == VaLEnterCaprate && Notes == ValueNotes)
            {
                return false;
            }
            return true;

        }

        public bool swapHedging()
        {


            ClickOnHedgingEditIcon();
            ClickOnHedgingSelectDropdown();
            SelectElement hedgeing = new SelectElement(driver.FindElement(SelectHedging));
            hedgeing.SelectByText("Cap");
            driver.FindElement(CapRate).Clear();

            Random randomGenerator1 = new Random();
            int randomIntt = randomGenerator1.Next(1, 9);
            string VaLEnterCaprate = randomIntt.ToString();

            String ValueNot = "test" + randomIntt;
            String ValueNotes = ValueNot.ToString();

            Thread.Sleep(1000);
            driver.FindElement(CapRate).SendKeys(VaLEnterCaprate);
            Thread.Sleep(2000);
            driver.FindElement(inputNotesHedging).Clear();
            Thread.Sleep(1000);
            driver.FindElement(inputNotesHedging).SendKeys(ValueNotes);
            Thread.Sleep(1000);
            driver.FindElement(EditHedging).Click();
            String caprate = driver.FindElement(UpdatedCapRate).Text;

            String Notes = driver.FindElement(CapturedTextHedgingNotes).Text;
            //String withoutSpaces = Notes.Replace("", String.Empty);


            String withoutComma = caprate.Replace("%", String.Empty);

            if (caprate == VaLEnterCaprate && Notes == ValueNotes)
            {
                return false;
            }
            return true;

        }



        public bool HedgingExpirationDate()
        {

            string ExDate = driver.FindElement(CaptureHedgingExpDate).Text;

            Console.WriteLine(ExDate);

            string[] valDateArr = ExDate.Split('/');
            ExDate = valDateArr[1] + "/" + valDateArr[0] + "/" + valDateArr[2];

            DateTime ValueDa = DateTime.Parse(ExDate);

            Console.WriteLine("This is a parsed date");
            Console.WriteLine(ValueDa);

            //To get the current date 

            DateTime dateTime1 = DateTime.UtcNow.Date;
            String dateT = dateTime1.ToString("dd/MM/yyyy");
            Console.WriteLine(dateT);
            DateTime todaysDate = DateTime.Parse(dateT);
            Console.WriteLine(todaysDate);


            //  int month = (ValueDa.Month - todaysDate.Month) + 12 * (ValueDa.Year - todaysDate.Year);

            int month = (ValueDa.Month - todaysDate.Month) + 12 * (todaysDate.Year - ValueDa.Year);

            Console.WriteLine(month);

            Thread.Sleep(5000);
            By CapturedTextTTHM = By.XPath("//label[text()='Term To Hedge Maturity']/parent::div/parent::div/parent::div/parent::div/div[3]/div[2]/div/div/span");
            string TTHM = driver.FindElement(CapturedTextTTHM).Text;

            int ValueMonth = int.Parse(TTHM);
            if (ValueMonth == month)
            {
                return true;

            }
            else
            {


                return false;

            }
            /*
             * String withoutComma = AMOIrate.Replace("%", String.Empty);
            int existingV = int.Parse(withoutComma);
            int newValue = existingV + 2;
            String valueToEnter = newValue.ToString();
             * 
             * 
            String acquDate = driver.FindElement(AcquisitionDateUpdated).Text;
            DateTime acquisitionDate = DateTime.Parse(acquDate);

            String dispDate = driver.FindElement(DispositionDateUpdated).Text;
            DateTime dispositionDate = DateTime.Parse(dispDate);
            return (dispositionDate.Month - acquisitionDate.Month) + 12 * (dispositionDate.Year - acquisitionDate.Year);
                
            */

        }






        public bool EditHedgeingInstrumentDetails()
        {


            string CapturedTextHIT = driver.FindElement(CapturedTextHedInstType).Text;
            if (CapturedTextHIT == "Cap")
            {
                bool resultCap = capHedging();
                return resultCap;
            }
            else if (CapturedTextHIT == "Collar")
            {
                bool resultSwap = swapHedging();
                return resultSwap;
            }

            else if (CapturedTextHIT == "Swap")
            {
                bool resultSwap1 = swapHedging();
                return resultSwap1;

            }
            else
            {
                ClickOnHedgingEditIcon();
                ClickOnHedgingSelectDropdown();
                SelectElement hedgeing = new SelectElement(driver.FindElement(SelectHedging));
                hedgeing.SelectByText("Swap");
                driver.FindElement(SwapRate).Clear();
                String NumberEnterted = "10";
                driver.FindElement(SwapRate).SendKeys(NumberEnterted);
                ClickOnHedgingSaveIcon();
                // String CheckAddedValue = driver.FindElement().Text; //Check if number is in perc - need to add
                return true;
            }

        }
        public Boolean ClearHedgingIntrumentDetails()
        {
            // EditHedgeingInstrumentDetails();
            driver.FindElement(EditHedging).Click();
            Thread.Sleep(1000);
            driver.FindElement(SaveHedging).Click();
            Thread.Sleep(1000);
            String valueinpopup = driver.FindElement(SaveDataPopUpHedging).Text;
            Thread.Sleep(1000);
            Console.WriteLine(valueinpopup);
            if (valueinpopup == "No changes made in data...")
            {
                return true;
            }
            return false;
        }

        public Boolean validDataAmorization()
        {
            Thread.Sleep(2000);
            string AMOIrate = driver.FindElement(CapturedTextAmorizationIR).Text;

            String withoutComma = AMOIrate.Replace("%", String.Empty);
            int existingV = int.Parse(withoutComma);
            int newValue = existingV + 2;
            String valueToEnter = newValue.ToString();

            //int value = int.Parse(amoirate);

            string AMOIONPM = driver.FindElement(CapturedTextAmorizationIOPM).Text;

            String IONPM = AMOIONPM.Replace("%", String.Empty);
            int existingV1 = int.Parse(IONPM);
            int newValue1 = existingV1 + 2;
            String valueToEnterIONPM = newValue1.ToString();


            string AMOAPY = driver.FindElement(CapTuredTextAmorizationAPY).Text;

            String APY = AMOAPY.Replace("%", String.Empty);
            int existingV2 = int.Parse(APY);
            int newValue2 = existingV2 + 2;
            String valueToEnterAPY = newValue2.ToString();



            string AMOACM = driver.FindElement(CapturedTextAmorizationACM).Text;

            String ACM = AMOACM.Replace("%", String.Empty);
            int existingV3 = int.Parse(ACM);
            int newValue3 = existingV3 + 2;
            String valueToEnterACM = newValue3.ToString();


            Thread.Sleep(2000);
            driver.FindElement(EditAmortizationIcon).Click();


            //        string removecomma = AMOIrate.Replace('%', ' ');
            //          string removeSpace = removecomma.Replace(" ", string.Empty);

            //            string myString = removeSpace.ToString();

            //int Total = int.Parse(myString) + 2;
            //   string Newvalue = Total.ToString();


            Thread.Sleep(2000);
            driver.FindElement(InputAmorizationIR).Clear();
            Thread.Sleep(1000);
            driver.FindElement(InputAmorizationIR).SendKeys(valueToEnter);
            Thread.Sleep(2000);

            driver.FindElement(InputAmorizationIOPM).Clear();
            Thread.Sleep(1000);
            driver.FindElement(InputAmorizationIOPM).SendKeys(valueToEnterIONPM);
            Thread.Sleep(2000);


            driver.FindElement(InputAmorizationAPY).Clear();
            Thread.Sleep(1000);
            driver.FindElement(InputAmorizationAPY).SendKeys(valueToEnterAPY);


            driver.FindElement(InputAmorizationACM).Clear();
            Thread.Sleep(1000);
            driver.FindElement(InputAmorizationACM).SendKeys(valueToEnterACM);

            ClickOnSaveIconAmorization();

            //Function to verify the data 
            string AMOIrateNewValue = driver.FindElement(CapturedTextAmorizationIR).Text;
            string AMOIONPMNewValue = driver.FindElement(CapturedTextAmorizationIOPM).Text;
            string AMOAPYNewValue = driver.FindElement(CapTuredTextAmorizationAPY).Text;
            string AMOACMNewValue = driver.FindElement(CapturedTextAmorizationACM).Text;

            if (AMOIrateNewValue != AMOIrate && AMOIONPMNewValue != AMOIONPM && AMOAPYNewValue != AMOAPY && AMOACMNewValue != AMOACM)
            {
                return true;
            }
            else
            {

                return false;
            }

        }


        public void ClickOnEditIconAmorization()
        {
            Thread.Sleep(2000);
            driver.FindElement(EditAmortizationIcon).Click();
            Thread.Sleep(2000);
        }
        public void ClickOnSaveIconAmorization()
        {
            driver.FindElement(SaveAmortizationIcon).Click();
            Thread.Sleep(5000);
        }

        public string AlertTextAmorization()
        {

            String alertTextAmorization = driver.FindElement(PopUpAlertAmorization).Text;

            return alertTextAmorization;
        }

        By loanDetailsEditIconn = By.CssSelector("[data-tip='Click to edit']");
        By IntRateType = By.XPath("//div[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/div[1]/div[1]/div/div[2]/div[10]/div[2]/div/div/span");
        //By IntrateDropdoown = By.XPath("//select[@class='select-css']");
        By IntrateDropdoown = By.XPath("//label[text()='Interest Rate Type']/parent::div/parent::div/parent::div/div[2]/div/div/span");
        By InterRateDropdown = By.XPath("//label[text()='Interest Rate Type']/parent::div/parent::div/parent::div/div[2]/div/div/span/select");

        By LoanSaveIcon = By.CssSelector("[data-tip='Save']");
        By CapturedTextFixedRate = By.XPath("//label[contains(text(),'Fixed Rate')]");
        By CapturedTextSpread = By.XPath("//label[contains(text(),'Spread')]");

        public void selectIntTypeFixed()
        {
            driver.FindElement(IntrateDropdoown).Click();
            Thread.Sleep(2000);
            SelectElement IntType = new SelectElement(driver.FindElement(InterRateDropdown));
            Console.WriteLine(IntType);
            IntType.SelectByText("Fixed");

        }

        public void selectIntTypeFloat()
        {
            driver.FindElement(IntrateDropdoown).Click();
            SelectElement IntType = new SelectElement(driver.FindElement(InterRateDropdown));
            IntType.SelectByText("Floating");

        }


        public void UpdateLoanWithOutAddingData()
        {
            Thread.Sleep(3000);
            driver.FindElement(loanDetailsEditIconn).Click();

            Thread.Sleep(2000);
            driver.FindElement(LoanSaveIcon).Click();
            Thread.Sleep(5000);


        }

        public void selectPropertyWithIndustrialType()
        {

            Thread.Sleep(5000);
            driver.FindElement(SearchIcon).Click();
            String propertyName = "North Rive";
            driver.FindElement(SearchIcon).SendKeys(propertyName);
        }


        public void NavigateToPropertyDetails()
        {
            Thread.Sleep(2000);
            driver.FindElement(Card).Click();
            Thread.Sleep(2000);
        }

        public void SerachProperty()
        {
            Thread.Sleep(5000);
            driver.FindElement(SearchIcon).Click();
            String propertyName = "One51 - Phase"; // Mallard Creek
            driver.FindElement(SearchIcon).SendKeys(propertyName);

        }

        By Input_OriFieldLoanDetails = By.CssSelector("[placeholder='Select a date...']");
        By Input_IniFieldLoanDetails = By.XPath("//label[text()='Initial Maturity']/parent::div/parent::div/parent::div/div[2]/div/div/span/div/div/input");
        public void UpdateLoanDetailsWithNullData()
        {
            Thread.Sleep(3000);
            driver.FindElement(loanDetailsEditIconn).Click();
            Thread.Sleep(2000);
            driver.FindElement(LoanDetail_TotalCommitment_Input).Click();
            driver.FindElement(LoanDetail_TotalCommitment_Input).Clear();
            Thread.Sleep(3000);
            IWebElement element = driver.FindElement(Input_OriFieldLoanDetails);
            element.SendKeys(Keys.Control + "a");
            element.SendKeys(Keys.Backspace);
            element.SendKeys(Keys.Escape);
            Thread.Sleep(2000);

            IWebElement element1 = driver.FindElement(Input_IniFieldLoanDetails);
            element1.SendKeys(Keys.Control + "a");
            element1.SendKeys(Keys.Backspace);
            element1.SendKeys(Keys.Escape);
            Thread.Sleep(2000);

            Thread.Sleep(3000);
            //driver.FindElement(Input_OriFieldLoanDetails).Clear();
            //Thread.Sleep(3000);


            Thread.Sleep(2000);
            driver.FindElement(LoanSaveIcon).Click();
            Thread.Sleep(5000);


        }
        public void UpdateAmorizationNullData()
        {

            Thread.Sleep(2000);
            driver.FindElement(EditAmortizationIcon).Click();


            Thread.Sleep(2000);
            driver.FindElement(InputAmorizationIR).Clear();
            Thread.Sleep(2000);

            driver.FindElement(InputAmorizationIOPM).Clear();
            Thread.Sleep(2000);


            driver.FindElement(InputAmorizationAPY).Clear();
            Thread.Sleep(1000);


            driver.FindElement(InputAmorizationACM).Clear();
            Thread.Sleep(1000);
            driver.FindElement(InputAmorizationACM).SendKeys("null");

            ClickOnSaveIconAmorization();
        }

        public bool CaptureALLHedgingValue()
        {
            string value1 = driver.FindElement(CapturedTextSwapRate).Text;
            String value2 = driver.FindElement(CapturedTextExpirationDate).Text;
            String value3 = driver.FindElement(CapturedTextSwapRate).Text;

            if (value1 == "-" && value2 == "-" && value3 == "null")
            {
                return true;

            }

            else
            {

                return false;

            }
        }
        public bool HedgingWithNullData()
        {
            driver.FindElement(EditHedging).Click();
            Thread.Sleep(1000);

            driver.FindElement(SwapRate).Clear();
            Thread.Sleep(2000);

            IWebElement element = driver.FindElement(ExpirationDate);
            element.SendKeys(Keys.Control + "a");
            element.SendKeys(Keys.Backspace);
            element.SendKeys(Keys.Escape);
            Thread.Sleep(2000);

            driver.FindElement(inputNotesHedging).Clear();
            Thread.Sleep(2000);
            driver.FindElement(inputNotesHedging).SendKeys("null");

            driver.FindElement(SaveHedging).Click();
            Thread.Sleep(2000);

            bool result = CaptureALLHedgingValue();
            return result;
        }
        public void UpdatePrepaymentWithNullData()
        {

            EditPrepayment();

            Thread.Sleep(1000);
            driver.FindElement(InputPrepaymentAmount).Clear();
            Thread.Sleep(1000);

            driver.FindElement(InputPrepaymentNotes).Clear();
            Thread.Sleep(1000);
            driver.FindElement(InputPrepaymentsDatePicker).Click();

            IWebElement element = driver.FindElement(InputPrepaymentsDatePicker);
            element.SendKeys(Keys.Control + "a");
            element.SendKeys(Keys.Backspace);
            element.SendKeys(Keys.Escape);
            Thread.Sleep(2000);

            driver.FindElement(InputPrepaymentsEBAP).Clear();
            Thread.Sleep(1000);

            driver.FindElement(InputPrepaymentsOLBPP).Clear();
            Thread.Sleep(1000);

            driver.FindElement(InputPrepaymentsEFA).Clear();
            Thread.Sleep(1000);


            driver.FindElement(InputPrepaymentsEFP).Clear();
            Thread.Sleep(1000);


            ClickOnSavePrepaymentButton();
        }

        public bool LoanDetailsMonth()
        {

            By CapturedDateIM = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/div[1]/div[1]/div/div[2]/div[3]/div[2]/div/div/span");
            By CapturedDateOD = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/div[1]/div[1]/div/div[2]/div[2]/div[2]/div/div/span");

            String IM = driver.FindElement(CapturedDateIM).Text;
            String OM = driver.FindElement(CapturedDateOD).Text;

            //To calculate the IM
            string[] valDateArr1 = IM.Split('/');
            IM = valDateArr1[1] + "/" + valDateArr1[0] + "/" + valDateArr1[2];

            DateTime ValueDate1 = DateTime.Parse(IM);


            //To calculate the OM
            string[] valDateArr2 = OM.Split('/');
            OM = valDateArr2[1] + "/" + valDateArr2[0] + "/" + valDateArr2[2];

            DateTime ValueDate2 = DateTime.Parse(OM);


            int month = (ValueDate1.Month - ValueDate2.Month) + 12 * (ValueDate2.Year - ValueDate1.Year);

            Console.WriteLine(month);

            Thread.Sleep(5000);
            By CapturedTextTM = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/div[1]/div[1]/div/div[2]/div[4]/div[2]/div/div/span");
            string TM = driver.FindElement(CapturedTextTM).Text;

            int ValueMonth = int.Parse(TM);
            if (ValueMonth == month)
            {
                return true;

            }
            else
            {


                return false;

            }


        }

        By PropertyText = By.XPath("//span[contains(text(),'Property')]");
        By PropertyName = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[1]/div[1]/a");
        By GenAssetSummary = By.XPath("//div[contains(text(),'General Asset Summary')]");


        public bool IsElementPresent()
        {
            try
            {
                driver.FindElement(PropertyText);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public string navigationToPropertydetails()
        {
            bool res = IsElementPresent();
            if (res == true)
            {
                string capturedTextproperty = driver.FindElement(PropertyText).Text;
                driver.FindElement(PropertyName).Click();


                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(GenAssetSummary));
                String title = driver.FindElement(GenAssetSummary).Text;
                return title;

            }

            else
            {
                return "Property Name is not available";

            }


        }

        public void ClickOnPropertyName()
        {

            driver.FindElement(PropertyName).Click();
            Thread.Sleep(6000);

        }

        public void ClickOnPropertyImage()
        {
            driver.FindElement(By.XPath("//div[contains(text(),'Property Images')]")).Click();
            Thread.Sleep(3000);
        }
        public void UploadImage()
        {
            IWebElement fileUpload = driver.FindElement(By.XPath("//label[@class='select-button']"));
            //fileUpload.SendKeys("C:\\Users\\GS-1638\\Desktop\\at.png");
            Thread.Sleep(8000);
            fileUpload.Click();
            Thread.Sleep(2000);
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");
            autoIt.Send(@"C:\Users\GS-1638\Desktop\at.png");
            Thread.Sleep(3000);
            autoIt.Send("{Enter}");

        }
        public bool LoanDetailsIntType()
        {
            string LoanIntType = driver.FindElement(IntRateType).Text;
            if (LoanIntType == "Floating")
            {
                driver.FindElement(loanDetailsEditIconn).Click();
                Thread.Sleep(2000);
                selectIntTypeFixed();
                Thread.Sleep(2000);
                driver.FindElement(LoanSaveIcon).Click();
                Thread.Sleep(2000);
                string FixRate = driver.FindElement(CapturedTextFixedRate).Text;

                if (FixRate != LoanIntType)
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
                driver.FindElement(loanDetailsEditIconn).Click();
                Thread.Sleep(2000);
                selectIntTypeFloat();
                driver.FindElement(LoanSaveIcon).Click();
                Thread.Sleep(2000);
                string FloatRate = driver.FindElement(CapturedTextSpread).Text;
                Thread.Sleep(2000);
                if (FloatRate != LoanIntType)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public Boolean EditInterestRateInAmortization()
        {
            driver.FindElement(EditAmortizationIcon).Click();
            driver.FindElement(AmortizationIntrest).Clear();
            driver.FindElement(AmortizationIntrest).SendKeys("10");
            driver.FindElement(EditAmortizationIcon).Click();
            String Amort = driver.FindElement(UpdatedAmortIntrest).Text;
            if (Amort == "10%")
            {
                return true;
            }
            return false;
        }
        public Boolean AddExtentionDetails()
        {
            driver.FindElement(AddExtention).Click();
            driver.FindElement(InputaddExtention).Click();
            SelectElement extention = new SelectElement(driver.FindElement(YearInExt));
            extention.SelectByIndex(2);
            driver.FindElement(DayInExt).Click();
            Thread.Sleep(2000);
            driver.FindElement(SaveExtension).Click();
            String extentiondate = driver.FindElement(UpdatedExtention).Text;
            var Matruritydate = DateTime.Parse(extentiondate);
            if (Matruritydate > DateTime.Now)
            {
                return true;
            }
            return false;
        }
        public Boolean UpdateExtentionDetails()
        {
            driver.FindElement(EditExtention).Click();
            Thread.Sleep(3000);

            driver.FindElement(InputaddExtention).Clear();
            Thread.Sleep(3000);

            driver.FindElement(InputaddExtention).Click();
            Thread.Sleep(3000);

            IWebElement dropdownYearr = driver.FindElement(YearInExt);
            Console.WriteLine(dropdownYearr);
            SelectElement extentionsYear = new SelectElement(dropdownYearr);

            extentionsYear.SelectByValue("2027");

            Thread.Sleep(3000);

            driver.FindElement(DayInExt).Click();
            Thread.Sleep(3000);
            driver.FindElement(SaveExtension).Click();
            String extentiondate = driver.FindElement(UpdatedExtention).Text;

            string[] valDateArr = extentiondate.Split('/');
            extentiondate = valDateArr[1] + "/" + valDateArr[0] + "/" + valDateArr[2];


            var Matruritydate = DateTime.Parse(extentiondate);
            if (Matruritydate > DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}
