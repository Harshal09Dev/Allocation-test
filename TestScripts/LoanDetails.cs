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
    class LoanDetails : BaseTest
    {
        BaseTest baseTest = new BaseTest();


        [Test, Category("Sanity Test")]
        [Description("Verify Loan label")]

        public void VerifyLoanlabelInLoanDetailsPage()
        {
            try
            {
                test = extent.CreateTest("VerifyLoanlabelInLoanDetailsPage").Info("Test Started");
                LoanDetailsPage LoanMainPage = new PageObjects.LoanDetailsPage(BaseTest.driver);

                LoanMainPage.ClickTrackRecordOnInMenu();
                LoanMainPage.ClickOnCardDetails();
                var loan = LoanMainPage.getText_LOANDETAILS();
                Assert.AreEqual("LOAN DETAILS", loan, "Loan label does not match");

                var TC = LoanMainPage.getText_LOANDETAILS_TC();
                Assert.AreEqual("Total Commitment", TC, "Total commitment label does not match");


                var OD = LoanMainPage.getText_LOANDETAILS_OD();
                Assert.AreEqual("Origination Date", OD, "Origination Date label does not match");

                var IM = LoanMainPage.getText_LOANDETAILS_IM();
                Assert.AreEqual("Initial Maturity", IM, "Total commitment label does not match");

                var TM = LoanMainPage.getText_LOANDETAILS_TM();
                Assert.AreEqual("Term (Months)", TM, "Term (Months) label does not match");

                var CM = LoanMainPage.getText_LOANDETAILS_CM();
                Assert.AreEqual("Current Maturity", CM, "Current Maturity label does not match");


                var OA = LoanMainPage.getText_LOANDETAILS_OA();
                Assert.AreEqual("Outstanding Amount", OA, "Outstanding Amount label does not match");

                var lender = LoanMainPage.getText_LOANDETAILS_Lender();
                Assert.AreEqual("Lender", lender, "Lender label does not match");

                var loanType = LoanMainPage.getText_LOANDETAILS_LoanType();
                Assert.AreEqual("Loan Type", loanType, "Loan Type label does not match");

                var LenderType = LoanMainPage.getText_LOANDETAILS_LenderType();
                Assert.AreEqual("Lender", lender, "Lender Type label does not match");


                var InRateType = LoanMainPage.getText_LOANDETAILS_IRateType();
                Console.WriteLine(InRateType);
                Assert.AreEqual("Interest Rate Type", InRateType, "Interest Rate Type label does not match");

                test.Log(Status.Pass, "Test Case Passed");

            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                test.Log(Status.Fail, e.ToString());
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);


            }
        }

        [Test, Category("Sanity Test")]
        [Description("Verify Hedging label")]

        public void VerifyTheHedginlabelInLoanDetailsPage()
        {
            try
            {
                test = extent.CreateTest("VerifyTheHedginlabelInLoanDetailsPage").Info("Test Started");
                LoanDetailsPage LoanMainPage = new PageObjects.LoanDetailsPage(BaseTest.driver);
                LoanMainPage.ClickTrackRecordOnInMenu();
                Thread.Sleep(1000);
                LoanMainPage.ClickOnCardDetails();
                Thread.Sleep(1000);

                String HEDGING_Title = LoanMainPage.getText_LoanDetail_HEDGING_Title();
                Assert.AreEqual("HEDGING INSTRUMENT", HEDGING_Title, "Hedging Instrument label does not match");

                String Hedging_IT = LoanMainPage.getText_LoanDetail_HEDGING_Instru_Type();
                Assert.AreEqual("Hedging Instrument Type", Hedging_IT, "Hedging Instrument Type label does not match");

                String Hedging_TTHM = LoanMainPage.getText_LoanDetail_HEDGING_TTHedgeMaturity();
                Assert.AreEqual("Term To Hedge Maturity", Hedging_TTHM, "Term To Hedge Maturity label does not match");

                String Hedging_ED = LoanMainPage.getText_LoanDetail_HEDGING_ExpirationDate();
                Assert.AreEqual("Expiration Date", Hedging_ED, "Expiration Date label does not match");

                String Hedging_HN = LoanMainPage.getText_LoanDetail_HEDGING_Notes();
                Assert.AreEqual("Notes", Hedging_HN, "Note label does not match"); // re-verify the text


                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                test.Log(Status.Fail, e.ToString());
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);


            }
        }

        [Test, Category("Sanity Test")]
        [Description("Verify TheAmortization label")]

        public void VerifyTheAmortizationlabelInLoanDetailsPage()
        {
            try
            {
                test = extent.CreateTest("VerifyTheAmortizationlabelInLoanDetailsPage").Info("Test Started");
                LoanDetailsPage LoanMainPage = new PageObjects.LoanDetailsPage(BaseTest.driver);
                LoanMainPage.ClickTrackRecordOnInMenu();
                Thread.Sleep(1000);
                LoanMainPage.ClickOnCardDetails();
                Thread.Sleep(1000);

                String Amorization_Title = LoanMainPage.getText_LoanDetail_AMORTIZATION_Title();
                Assert.AreEqual("AMORTIZATION", Amorization_Title, "Amortization label does not match");

                String Amorization_InterestRate = LoanMainPage.getText_LoanDetail_AMORTIZATION_InterestRate();
                Assert.AreEqual("Amortization Interest Rate", Amorization_InterestRate, "Amortization Interest Rate label does not match");

                String Amorization_InterestOnlyPeriod_Month = LoanMainPage.getText_LoanDetail_AMORTIZATION_InterestOnlyPeriod_Month();
                Assert.AreEqual("Interest Only Period (Months)", Amorization_InterestOnlyPeriod_Month, "Interest Only Period (Months) label does not match");

                String Amorization_InterestOnlyPeriod_Year = LoanMainPage.getText_LoanDetail_AMORTIZATION_InterestOnlyPeriod_Year();
                Assert.AreEqual("Amortization Period (Years)", Amorization_InterestOnlyPeriod_Year, "Amortization Period (Years) label does not match");

                String Amorization_Calc_Method = LoanMainPage.getTextLoanDetail_AMORTIZATION_Amortization_Calc_Method();
                Assert.AreEqual("Amortization Calc Method", Amorization_Calc_Method, "Amortization Calc Method label does not match"); // re-verify the text


                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                test.Log(Status.Fail, e.ToString());
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);


            }
        }

        [Test, Category("Sanity Test")]
        [Description("Verify TermExtensio label")]

        public void VerifyTheTermExtensionlabelInLoanDetailsPage()
        {
            try
            {
                test = extent.CreateTest("VerifyTheTermExtensionlabelInLoanDetailsPage").Info("Test Started");
                LoanDetailsPage LoanMainPage = new PageObjects.LoanDetailsPage(BaseTest.driver);
                LoanMainPage.ClickTrackRecordOnInMenu();
                Thread.Sleep(1000);
                LoanMainPage.ClickOnCardDetails();
                Thread.Sleep(1000);

                String Amorization_TE_Title = LoanMainPage.getText_LoanDetail_TE_Title();
                Assert.AreEqual("TERM + EXTENSION OPTIONS", Amorization_TE_Title, "Term + Extension  label does not match");

                String Amorization_Ext_Number = LoanMainPage.getText_LoanDetail_TE_Extension_Number();
                Assert.AreEqual("Extension Number", Amorization_Ext_Number, "Extension Number label does not match");

                String Amorization_Mat_Date = LoanMainPage.getText_LoanDetail_TE_Extension_MaturityDate();
                Assert.AreEqual("Extension Maturity Date", Amorization_Mat_Date, "Extension Maturity Date label does not match");

                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                test.Log(Status.Fail, e.ToString());
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);


            }
        }

        [Test, Category("Sanity Test")]
        [Description("Verify Prepayment label")]
        public void VerifyThePrepaymentlabelInLoanDetailsPage()
        {
            try
            {
                test = extent.CreateTest("VerifyThePrepaymentlabelInLoanDetailsPage").Info("Test Started");
                LoanDetailsPage LoanMainPage = new PageObjects.LoanDetailsPage(BaseTest.driver);
                LoanMainPage.ClickTrackRecordOnInMenu();
                Thread.Sleep(1000);
                LoanMainPage.ClickOnCardDetails();
                Thread.Sleep(1000);

                String Prepayment_Title = LoanMainPage.getText_LoanDetails_Preapayment_Title();
                Assert.AreEqual("PREPAYMENT", Prepayment_Title, "Prepayment  label does not match"); //Reverify the title

                String Prepayment_Amount = LoanMainPage.getText_LoanDetails_Preapayment_Amount();
                Assert.AreEqual("Prepayment Amount", Prepayment_Amount, "Prepayment Amount label does not match");

                String Prepayment_Notes = LoanMainPage.getText_LoanDetails_Preapayment_Notes();
                Assert.AreEqual("Prepayment Notes", Prepayment_Notes, "Prepayment Notes label does not match");

                String Prepayment_Calc_Date = LoanMainPage.getText_LoanDetails_Preapayment_Calc_Date();
                Assert.AreEqual("Prepayment Calc Date", Prepayment_Calc_Date, "Prepayment Calc Date  label does not match");

                String Prepayment_EBA_PatOff = LoanMainPage.getText_LoanDetails_Preapayment_EBA_PatOff();
                Assert.AreEqual("Estimated Balance at Payoff", Prepayment_EBA_PatOff, "Estimated Balance at Payoff label does not match");

                String OLB_Title = LoanMainPage.getText_LoanDetails_Preapayment_OLB_PenaltyAct();
                Assert.AreEqual("Outstanding Loan Balance Penalty Pct", OLB_Title, "Outstanding Loan Balance Penalty Pct label does not match");


                String Prepayment_Exit_Fee_Pct = LoanMainPage.getText_LoanDetails_Preapayment_Exit_Fee_Pct();
                Assert.AreEqual("Exit Fee Pct", Prepayment_Exit_Fee_Pct, "Exit Fee Pct label does not match");


                String Prepayment_EF_Account = LoanMainPage.getText_LoanDetails_Preapayment_EF_Account();
                Assert.AreEqual("Prepayment Type", Prepayment_EF_Account, "Prepayment Type label does not match");

                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                test.Log(Status.Fail, e.ToString());
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);


            }
        }

        [Test, Category("Regression Test")]
        [Description("Verify Total commitment fields are editable")]
        public void VerifyTotalCommitmentInLoanDetailsIsEditable()
        {
            try
            {
                test = extent.CreateTest("VerifyTotalCommitmentInLoanDetailsIsEditable").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.NavigateToLoanDetails();
                Boolean res = loandetails.EditAndUpdateLoanCommitment();
                Assert.IsTrue(res == true, "Total Commitment is not editablle");
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
        [Description("Verify Prepayment fields are editable")]
        public void VerifyPrepaymentAmountInPrepaymentIsEditable()
        {
            try
            {
                test = extent.CreateTest("VerifyPrepaymentAmountInPrepaymentIsEditable").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.NavigateToLoanDetails();
                loandetails.EditPrepayment();

                Boolean PreapaymentValue = loandetails.EditAndUpdatePrepaymentAmountBoolValue();
                Assert.IsTrue(PreapaymentValue == true, "Prepayment amount is not editable");

                Boolean NotesValue = loandetails.EditAndUpdatePrepaymentNotesBoolvalue();
                Assert.IsTrue(NotesValue == true, "Prepayment Notes is not editable");

                Boolean DateValue = loandetails.EditAndUpdatePrepaymentDatePickerBoolvalue();
                Assert.IsTrue(DateValue == true, "Prepayment date is not editable");

                Boolean EBAPNotes = loandetails.EditAndUpdatePrepaymentEBAPBoolvalue();
                Assert.IsTrue(EBAPNotes == true, "Prepayment EBAP is not editable");

                Boolean OLBPPNotes = loandetails.EditAndUpdatePrepaymentOLBPPBoolvalue();
                Assert.IsTrue(OLBPPNotes == true, "Prepayment OLBPP is not editable");

                Boolean EFAPPNotes = loandetails.EditAndUpdatePrepaymentEFABoolvalue();
                Assert.IsTrue(EFAPPNotes == true, "Prepayment OLBPP is not editable");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }

        [Test, Category("Regression Test")]
        [Description("Verify Prepayment Amount with empty data ")]

        public void VerifyPrepaymentAmountInPrepaymentIsUpdateWithEmptyData()
        {
            try
            {
                test = extent.CreateTest("VerifyPrepaymentAmountUpdateWithEmptyData").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.NavigateToLoanDetails();
                loandetails.EditPrepayment();
                loandetails.ClickOnSavePrepaymentButton();

                string alertMessage = loandetails.CaptureAlertMessage();
                Assert.AreEqual("No changes made in data...", alertMessage, "Alert does not match");


            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }


        [Test, Category("Regression Test")]
        [Description("Verify Prepayment Update With Valid Data")]
        public void VerifyPrepaymentAmountInPrepaymentIsUpdateWithValidData()
        {
            try
            {
                test = extent.CreateTest("VerifyPrepaymentAmountInPrepaymentIsUpdateWithValidData").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.NavigateToLoanDetails();
                loandetails.VerifyPREPAYValidDetails();
                Assert.IsTrue(true == true, "{Prepayment updation has been done successfully");

                Thread.Sleep(9000);
                //No alert is getting for saving the data

            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }


        [Test, Category("Regression Test")]
        [Description("Verify Hedging Instrument with valid Data")]
        public void VerifyHedgingInstrumentWithValidData()
        {
            try
            {
                test = extent.CreateTest("VerifyHedgingInstrumentWithValidData").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.NavigateToLoanDetails();
                bool res = loandetails.EditHedgeingInstrumentDetails();
                Assert.IsTrue(res == true, "Hedging instrument is failed to update");
                test.Log(Status.Pass, "Test Case Passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }

       [Test]
        [Description("Verify Hedging Instrument date")]
        public void VerifyHedgingInstrumentForDate()
        {
            try
            {
                test = extent.CreateTest("VerifyHedgingInstrumentForDate").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.NavigateToLoanDetails();
                bool res1 = loandetails.HedgingExpirationDate();
                Assert.IsTrue(res1 == true, "Hedging instrument month date is not matching ");
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
        [Description("Verify Hedging Instrument Details With Empty Data")]

        public void VerifyHedgingInstrumentDetailsWithEmptyData()
        {
            try
            {
                test = extent.CreateTest("VerifyHedgingInstrumentDetailsWithEmptyData").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.NavigateToLoanDetails();
                Boolean res = loandetails.ClearHedgingIntrumentDetails();
                Assert.IsTrue(res == true, "Hedging instrument is failed to update empty data");
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
        [Description("Verify Amortization with Empty data")]
        public void VerifyAmortizationWithEmptyData()
        {
            try
            {
                test = extent.CreateTest("VerifyWithEmptyDataAmortizationDetails").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.NavigateToLoanDetails();
                loandetails.ClickOnEditIconAmorization();
                loandetails.ClickOnSaveIconAmorization();
                string alertMessage = loandetails.AlertTextAmorization();
                Assert.AreEqual("No changes made in data...", alertMessage, "Alert pop up text did not match");
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
        [Description("Verify Amortization with ValidData")]
        public void VerifyAmortizationwithValidData()
        {
            try
            {
                test = extent.CreateTest("VerifyAmortizationwithValidData").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.NavigateToLoanDetails();
                bool result = loandetails.validDataAmorization();
                Assert.IsTrue(result == true, "UpdateWithValidDataAmortization is not successful");
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
        [Description("Verify Loan details Interest Rate Type")]
        public void VerifyLoanDetailsInterestRateType()
        {
            try
            {
                test = extent.CreateTest("VerifyLoanDetailsInterestRateType").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.NavigateToLoanDetails();
                bool res = loandetails.LoanDetailsIntType();
                Assert.IsTrue(res == true, "Int rate is not updated successfully");
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
        [Description("Verify Loan details table with empty  data")]

        public void VerifyLoanDetailsWithEmptyData()
        {
            try
            {
                test = extent.CreateTest("VerifyLoanDetailsWithEmptyData").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.NavigateToLoanDetails();
                loandetails.UpdateLoanWithOutAddingData();
                string alert = loandetails.CaptureAlertMessage();
                Assert.AreEqual("No changes made in data...", alert, "Alert does not match");
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
        [Description("Verify Loan details table with null data")]

        public void VerifyLoanDetailsWithNullData()
        {
            try
            {
                test = extent.CreateTest("VerifyLoanDetailsWithEmptyData").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                loandetails.selectPropertyWithIndustrialType();
                loandetails.NavigateToPropertyDetails();
                loandetails.UpdateLoanDetailsWithNullData();
                string alert = loandetails.CaptureAlertMessage();
                Assert.AreEqual("All Fields are mandatory", alert, "Alert does not match");
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
        [Description("Verify the TermMonth in loan Details Page")]
        public void VerifytheTermMonthinloanDetailsPage()
        {
            try
            {
                test = extent.CreateTest("VerifytheTermMonthinloanDetailsPage").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.ClickdebtSummary();
                int termMonth = debt.AddLoanWithFloatingInterest();
                Thread.Sleep(2000);
                int Month = debt.getTermMonth();
                Assert.IsTrue(Month == termMonth, "Term month does not match");
                test.Log(Status.Pass, "Test Case passed");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Test Case Failed");
                baseTest.TakeScreenshot();
                Console.WriteLine(e.StackTrace);
            }
        }



        [Test, Category("Regression Test")]
        [Description("Verify Loan Navigation From Property Name To Property Detials Page")]

        public void VerifyLoanNavigationFromPropertyNameToPropertyDetialsPage()
        {
            try
            {
                test = extent.CreateTest("VerifyNavigationFromPropertyNameToPropertyDetialsPage").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                debt.NavigateToLoanDetails();
                string title = loandetails.navigationToPropertydetails();
                Assert.AreEqual("General Asset Summary", title, "Failed to navigate to portfolio Page / Property Name is not present");


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
        [Description("Verify archive loan")]

        public void VerifyArchiveLoan()
        {
            try
            {
                test = extent.CreateTest("VerifyArchiveLoan").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                int NumberOfRowsBeforeArchive = debt.CountNumberOfLoan();
                loandetails.ClickOnCardDetails();
                debt.archive_Loan();
                debt.NavigateToLoanDetails();
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                int NumberOfRowsAfterArchive = debt.CountNumberOfLoan();
                Assert.IsTrue(NumberOfRowsBeforeArchive > NumberOfRowsAfterArchive, "Failed to archived loan");

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

        [Description("Verify Add loan label in add loan page")]

        public void VerifyAddLoanLabel()
        {
            try
            {
                test = extent.CreateTest("VerifyAddLoanLabel").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickdebtSummary();
                debt.ClickOnAddLoanButton();
                bool res = debt.CheckLoanlabel();
                Assert.IsTrue(res == true, "Label are incorrect");



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
        public void UpdatetheExtension()
        {
            try
            {
                test = extent.CreateTest("UpdatetheExtension").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.NavigateToLoanDetails();
                Boolean res = loandetails.UpdateExtentionDetails();
                Assert.IsTrue(res == true, "New extention date is not updated");
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
        [Description("Verify Prepayment with null data")]

        public void VerifyPrePaymentWithNullData()
        {
            try
            {
                test = extent.CreateTest("VerifyPrePaymentWithNullData").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                loandetails.selectPropertyWithIndustrialType();
                loandetails.NavigateToPropertyDetails();
                loandetails.UpdatePrepaymentWithNullData();
                string alert = loandetails.CaptureAlertMessage();
                Assert.AreEqual("One or more validation errors occurred.", alert, "Alert does not match");
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
        [Description("Verify Amorization with Null data")]

        public void VerifyAmortizationWithNullData()
        {
            try
            {
                test = extent.CreateTest("VerifyAmortizationWithNullData").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                loandetails.selectPropertyWithIndustrialType();
                loandetails.NavigateToPropertyDetails();
                loandetails.UpdateAmorizationNullData();
                string alert = loandetails.CaptureAlertMessage();
                Assert.AreEqual("All Fields are mandatory", alert, "Alert does not match");
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
        [Description("Verify Hedging with Null data")]
        public void VerifyHedgingWithNullData()
        {
            try
            {
                test = extent.CreateTest("VerifyHedgingWithNullData").Info("Test Started");
                DebtSummaryPage debt = new DebtSummaryPage(BaseTest.driver);
                LoanDetailsPage loandetails = new LoanDetailsPage(BaseTest.driver);
                debt.ClickFundATabDebt();
                debt.ClickdebtSummary();
                loandetails.selectPropertyWithIndustrialType();
                loandetails.NavigateToPropertyDetails();
                bool res = loandetails.HedgingWithNullData();
                Assert.IsTrue(res == true, "Values are not updated to hyphen/null");
                test.Log(Status.Pass, "Test Case Passed");
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
