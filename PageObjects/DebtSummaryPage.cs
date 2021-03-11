using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InvestmentManagement.PageObjects
{
    class DebtSummaryPage
    {
        private IWebDriver driver;
        public DebtSummaryPage(IWebDriver driver)
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
        //Debt Summary Specific locators
        By DebtSummary = By.XPath("//span[contains(text(),'Debt Summary')]"); //done
        By AddLoan = By.XPath("//button[contains(text(),'Add Loan')]"); //done
        By LenderDropdown = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/div/div/div/div/div[1]/div[2]/div[1]/select");//done - //div[@class='addLoanForm']/div/div[2]/div/select
        By PropertyDropdown = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/div/div/div/div/div[2]/div[2]/select"); //done
        By AlertPopUp = By.XPath("//*[@id='root']/div/div[1]/div/div/div[1]/div/div[2]");

        By LoanTypeDropdown = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/div/div/div/div/div[3]/div[2]/div[1]/select"); //done

        By InterestTypeDropdown = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/div/div/div/div/div[8]/div[2]/select"); // repeated two time

        By Commitment = By.XPath("//div[@class='addLoanForm']/div[4]/div[2]/input"); //checked
        By AddLoan_OriginationDate = By.XPath("//div[@class='addLoanForm']/div[5]/div[2]/div/div/input"); //checked
        By Initialmaturity = By.XPath("//div[@class='addLoanForm']/div[6]/div[2]/div/div/input"); //checked
        By InterestType = By.XPath("//div[@class='addLoanForm']/div[8]/div[2]/select/option[2]"); //checked
        //index- 1- fixed and index- 2- Floating
        By InterestValue = By.XPath("//div[@class='addLoanForm']/div[9]/div[2]/input"); // checked
        By Save = By.XPath("//button[contains(text(),'Save')]"); // checked
        By Cancel = By.XPath("//button[contains(text(),'Cancel')]"); // checked
        By LoanDetailsScreen = By.XPath("//div/div[3]/div/div/div/div/div[2]"); // checked
        By OriginationDate = By.XPath("//div[@class='maintenance-card-body']/div/div[2]/div/div/div/div[2]/div[2]/div[2]/div/div/span/div/div/input"); //
        By EditLoanD = By.XPath("//div[@class='tableContainer']/div/div/div[3]/div[2]");
        By CardBody = By.XPath("//div[@id='stickytypeheader']/div/div[2]/div/div/div/div/div[2]"); //need to discuss with shilpa

        //Locators to verify add lender, lender type and loan type
        By LenderPlusButton = By.XPath("//div[@class='addLoanForm']/div[1]/div[2]/div[2]");  //checked
        By LenderInputBox = By.XPath("//div[@class='modal']/div[2]/div/div[2]/input");  //checked
        By AddLenderTypePlusButton = By.XPath("//div[@class='modal']/div[2]/div[2]/div[2]/div/div[2]"); //checked
        By AddLenderTypeInput = By.XPath("//div[@class='modal']/div[2]/div[3]/div[2]/div/div/input"); //checked
        By AddButtonLender = By.XPath("//button[contains(text(),'Add')]"); //checked
        By LoanPlusButton = By.XPath("//div[@class='addLoanForm']/div[3]/div[2]/div[2]"); //checked
        By LoanTypeInput = By.XPath("//div[@class='modal']/div[2]/div/div[2]/input"); //checked
        By LoanType_Add = By.XPath("//div[@class='modal']/div[3]/div/button[1]"); //checked

        //Common menu locators
        By menu = By.XPath("//input[@class='menu_checkbox']"); //checked
        By fundsdropdwon = By.XPath("//div/div/div[2]/div/div[5]/div/div[2]/div/div/a"); //checked
        By fundAdrop = By.XPath("//div/div/div[2]/div/div[5]/div/div[2]/div/div[2]/div/div/a"); //checked
        By fundBdrop = By.XPath("//div/div/div[2]/div/div[5]/div/div[2]/div/div[2]/div[2]/div/a"); //checked
        By FundATab = By.XPath("//a[contains(text(),'SRP Fund A')]"); //checked
        By FundBTab = By.XPath("//a[contains(text(),'SRP Fund B')]"); //checked

        //Download Locators for Fund A
        By Debt_ADownload = By.XPath("//button[@id='menu-button--menu--1']"); //need to disccus with shilpa
        By Debt_ADownladFundAll = By.XPath("//div[@id='menu--1']/div[1]");
        By Debt_ADownloadFundA = By.XPath("//div[@id='menu--1']/div[2]");
        By Debt_ADownloadFundB = By.XPath("//div[@id='menu--1']/div[3]");

        //Download Locators for Fund B
        By Debt_BDownload = By.XPath("//div[@id='stickytypeheader']/div/div/div[2]/div/button"); //need to disccus with shilpa
        By Debt_BDownladFundAll = By.XPath("//reach-portal/div/div/div[1]");
        By Debt_BDownloadFundA = By.XPath("//reach-portal/div/div/div[2]");
        By Debt_BDownladFundB = By.XPath("//reach-portal/div/div/div[3]");

        //Common elements on debt summary
        By Debt_SearchInput = By.XPath("//div[@id='stickytypeheader']/div/div/div/span[2]/input"); // Checked
        By Debt_NumOfcards = By.XPath("//div[@id='stickytypeheader']/div/div[2]/div"); // Checked
        By Debt_ChangeView = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[3]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[3]/button[1]/*[local-name()='svg'][1]"); // 
        By Debt_Filter = By.XPath("//*[@id='stickytypeheader']/div/div[1]/div[3]/button[2]/svg"); //checked
        By Debt_FilterDropdown = By.XPath("//div[@id='customized-menu']/div[3]/ul/li/div/div[2]/select"); //checked
        By Debt_FilterOptions = By.XPath("//div[@id='customized-menu']/div[3]/ul/li/div/div[2]/select"); // checked
        By Debt_Ascending = By.XPath("//div[3]/ul/li[2]/div/label[1]/span"); //checked
        By Debt_Descending = By.XPath("//div[3]/ul/li[2]/div/label[2]/span"); //  checked
        By Debt_CardBody = By.XPath("//div[@id='stickytypeheader']/div/div[2]/div"); //  checked
        By Debt_ListView = By.XPath("//*[@id='stickytypeheader']/div/div[1]/div[3]/button[1]/svg"); //  checked
        By LoanDetails = By.XPath("//div/div/div[3]/div/div/div/div/div[1]"); //  checked
        By DebtSummaryLink = By.XPath("//div/div[3]/div/div/div/div/div[1]"); //  checked

        //Locators from card 
        By Card_label1 = By.XPath("//span[contains(text(),'Leased Percentage:')]");
        By Card_label2 = By.XPath("//span[contains(text(),'Current Debt:')]");
        By Card_label3 = By.XPath("//span[contains(text(),'Contributions:')]");
        By Card_label4 = By.XPath("//span[contains(text(),'Distributions:')]");
        By Card_label5 = By.XPath("//span[contains(text(),'Total Basis:')]");
        By Card_label6 = By.XPath("//span[contains(text(),'Total Basis SF:')]");

        By currentMaturityAll = By.XPath("//div[@class='card-main-body redText']/div[2]/div[5]/div/span[2]");
        By monthsMaturityValue = By.XPath("//div[@class='card-main-body redText']/div[2]/div[7]/div/span[2]");

        //archive loan 
        By ArchiveLoan = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[1]/div[2]");
        By OkButton = By.XPath("//span[@class='MuiButton-label']");
        By successMessage = By.XPath("//*[@id='root']/div/div[1]/div/div/div[1]/div/div[2]");

        //About US page
        By AboutUs = By.XPath("//a[contains(text(),'About Us')]");


        // Add loan label 
        By addloan_lender = By.XPath("//div[contains(text(),'Lender')]");
        By addloan_property = By.XPath("//div[contains(text(),'Property')]");
        By addloan_loanType = By.XPath("//div[contains(text(),'Loan Type')]");
        By addloan_TLC = By.XPath("//div[contains(text(),'Total Loan Commitment')]");
        By addloan_OD = By.XPath("//div[contains(text(),'Origination Date')]");
        By addloan_IM = By.XPath("//div[contains(text(),'Initial Maturity')]");
        By addloan_TM = By.XPath("//div[contains(text(),'Term (Months)')]");
        By addloan_IRT = By.XPath("//div[contains(text(),'Interest Rate Type')]");
        By addloan_FR = By.XPath("//div[contains(text(),'Fixed Rate')]");


        public bool CheckLoanlabel()
        {
            string lenderText = driver.FindElement(addloan_lender).Text;

            string PropertyText = driver.FindElement(addloan_property).Text;

            string LoanTypeText = driver.FindElement(addloan_loanType).Text;

            string TLCText = driver.FindElement(addloan_TLC).Text;

            string IMText = driver.FindElement(addloan_IM).Text;

            string TMText = driver.FindElement(addloan_TM).Text;

            string IRTText = driver.FindElement(addloan_IRT).Text;

            string FRText = driver.FindElement(addloan_FR).Text;

            if (lenderText == "Lender" && PropertyText == "Property" && LoanTypeText == "Loan Type" && TLCText == "Total Loan Commitment" && IMText == "Initial Maturity" && TMText == "Term (Months)" && IRTText == "Interest Rate Type" && FRText == "Fixed Rate")
            {
                return true;
            }

            else
            {
                return false;
            }

        }


        public void ClickFundATabDebt()
        {
            driver.FindElement(menu).Click();
        }

        public void ClickOnAboutUs()
        {
            driver.FindElement(menu).Click();
            driver.FindElement(AboutUs).Click();
            Thread.Sleep(2000);
        }
        public void ClickOnAddLoanButton()
        {

            driver.FindElement(AddLoan).Click();
            Thread.Sleep(3000);
        }
        public void ClickdebtSummary()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            Thread.Sleep(9000);
            // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DebtSummary));
            driver.FindElement(DebtSummary).Click();
        }
        public void AddLoanWithFixedInterest()
        {
            driver.FindElement(AddLoan).Click();
            driver.FindElement(LenderDropdown).Click();
            SelectElement lendername = new SelectElement(driver.FindElement(LenderDropdown));
            lendername.SelectByIndex(2);
            driver.FindElement(PropertyDropdown).Click();
            SelectElement propertyname = new SelectElement(driver.FindElement(PropertyDropdown));
            propertyname.SelectByIndex(3);
            driver.FindElement(LoanTypeDropdown).Click();
            SelectElement loantypename = new SelectElement(driver.FindElement(LoanTypeDropdown));
            loantypename.SelectByIndex(2);
            driver.FindElement(Commitment).SendKeys("87463556");
            driver.FindElement(InterestTypeDropdown).Click();
            SelectElement interesttypenames = new SelectElement(driver.FindElement(InterestTypeDropdown));
            interesttypenames.SelectByIndex(1);
            driver.FindElement(InterestValue).SendKeys("12");
            driver.FindElement(Save).Click();
            Thread.Sleep(2000);
        }
        By NumberOfCard = By.XPath("//div[@class='row']");

        public int CountNumberOfLoan()
        {
            //IWebElement table1 = driver.FindElement(NumOfCards);
            IList<IWebElement> listOFLoan = driver.FindElements(NumberOfCard);
            int NumofRowsbefore = listOFLoan.Count;
            return NumofRowsbefore;
        }

        public void archiveLoan()
        {

            driver.FindElement(ArchiveLoan).Click();
            Thread.Sleep(2000);
            driver.FindElement(OkButton).Click();
        }


        public string ToastMessage()
        {
            String Message = driver.FindElement(successMessage).Text;
            return Message;


        }
        public int AddLoanWithFloatingInterest()
        {
            driver.FindElement(AddLoan).Click();
            driver.FindElement(LenderDropdown).Click();
            SelectElement lendername = new SelectElement(driver.FindElement(LenderDropdown));
            lendername.SelectByIndex(2);
            driver.FindElement(PropertyDropdown).Click();
            SelectElement propertyname = new SelectElement(driver.FindElement(PropertyDropdown));
            propertyname.SelectByIndex(2);
            driver.FindElement(LoanTypeDropdown).Click();
            SelectElement loantypename = new SelectElement(driver.FindElement(LoanTypeDropdown));
            loantypename.SelectByIndex(2);
            driver.FindElement(Commitment).SendKeys("87463556");
            driver.FindElement(InterestTypeDropdown).Click();
            SelectElement interesttypenames = new SelectElement(driver.FindElement(InterestTypeDropdown));
            interesttypenames.SelectByIndex(2);
            driver.FindElement(InterestValue).SendKeys("12");
            By CapturedTextTMonth = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/div/div/div/div/div[7]/div[2]");
            String termMonthvalue = driver.FindElement(CapturedTextTMonth).Text;
            int count = termMonthvalue.Length;
            string withoutspaces = termMonthvalue.Replace(" ", String.Empty);
            int monthValue = int.Parse(withoutspaces);
            Console.WriteLine(monthValue);
            driver.FindElement(Save).Click();

            return monthValue;
        }
        By capturedTextTermMonth = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/div[1]/div[1]/div/div[2]/div[4]/div[2]/div/div/span");
        public int getTermMonth()
        {

            String TMValue = driver.FindElement(capturedTextTermMonth).Text;
            int count = TMValue.Length;
            string withoutspaces = TMValue.Replace(" ", String.Empty);
            int TMonth = int.Parse(withoutspaces);
            Console.WriteLine(TMonth);
            return TMonth;

        }
        public String GetNewLoanOriginationdate()
        {
            driver.FindElement(OriginationDate).Click();
            var date = driver.FindElement(OriginationDate).GetAttribute("value");
            return date;
        }
        public void CLickEditLoanDetails()
        {
            var elementToClick = driver.FindElement(EditLoanD);
            Actions action = new Actions(driver);
            action.Click(elementToClick).Build().Perform();
        }
        public void ClickAddLoanButton()
        {
            driver.FindElement(AddLoan).Click();
        }
        public Boolean AddNewLenderAndLenderType()
        {
            driver.FindElement(LenderPlusButton).Click();
            driver.FindElement(LenderInputBox).Click();
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1, 999);
            String name = "Test" + randomInt;
            driver.FindElement(LenderInputBox).SendKeys(name);
            driver.FindElement(AddLenderTypePlusButton).Click();
            driver.FindElement(AddLenderTypeInput).Click();
            driver.FindElement(AddLenderTypeInput).SendKeys(name);
            driver.FindElement(AddButtonLender).Click();
            Thread.Sleep(2000);
            SelectElement lendername = new SelectElement(driver.FindElement(LenderDropdown));
            lendername.SelectByText(name, true);
            return true;
        }
        public Boolean AddNewLoanType()
        {
            driver.FindElement(LoanPlusButton).Click();
            driver.FindElement(LoanTypeInput).Click();
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1, 999);
            String name = "Loan" + randomInt;
            driver.FindElement(LoanTypeInput).SendKeys(name);
            driver.FindElement(LoanType_Add).Click();
            SelectElement loantypelabel = new SelectElement(driver.FindElement(LoanTypeDropdown));
            loantypelabel.SelectByText(name, true);
            return true;
        }
        public int NumberOfCardsPresent()
        {
            //IWebElement table1 = driver.FindElement(NumOfCards);
            IList<IWebElement> listOfRows = driver.FindElements(Debt_NumOfcards);
            int numOfcards = listOfRows.Count;
            return numOfcards;
        }
        public int RowsBeforeSearch()
        {
            //IWebElement table1 = driver.FindElement(NumOfCards);
            IList<IWebElement> listOfRows = driver.FindElements(Debt_NumOfcards);
            int NumofRowsbefore = listOfRows.Count;
            return NumofRowsbefore;
        }
        public int RowsafterSearchForProperty()
        {
            //Code to see total rows present in the table            
            driver.FindElement(Debt_SearchInput).SendKeys("centerra");
            driver.FindElement(Debt_SearchInput).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            IList<IWebElement> listOfRows1 = driver.FindElements(Debt_NumOfcards);
            int NumofRowsafter = listOfRows1.Count;
            return NumofRowsafter;
        }
        public void DownloadDebtReportForFundA()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Debt_ADownload));
            driver.FindElement(Debt_ADownload).Click();
            driver.FindElement(Debt_ADownladFundAll).Click();
            Thread.Sleep(2000);
            driver.FindElement(Debt_ADownload).Click();
            driver.FindElement(Debt_ADownloadFundA).Click();
            Thread.Sleep(2000);
            driver.FindElement(Debt_ADownload).Click();
            driver.FindElement(Debt_ADownloadFundB).Click();
            Thread.Sleep(2000);
        }
        public void DownloadDebtReportForFundB()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Debt_BDownload));
            driver.FindElement(Debt_BDownload).Click();
            driver.FindElement(Debt_BDownladFundAll).Click();
            Thread.Sleep(2000);
            driver.FindElement(Debt_BDownload).Click();
            driver.FindElement(Debt_BDownloadFundA).Click();
            Thread.Sleep(2000);
            driver.FindElement(Debt_BDownload).Click();
            driver.FindElement(Debt_BDownladFundB).Click();
            Thread.Sleep(2000);
        }
        public void Debt_ClickOptionsInSortBy()
        {
            driver.FindElement(Debt_Filter).Click();
            driver.FindElement(Debt_FilterDropdown).Click();
            SelectElement sortby = new SelectElement(driver.FindElement(Debt_FilterOptions));
            IList<IWebElement> ElementCount = sortby.Options;
            int total = ElementCount.Count;
            for (int i = 1; i < total; i++)
            {
                sortby.SelectByIndex(i);
                driver.FindElement(Debt_Descending).Click();
                driver.FindElement(Debt_Ascending).Click();
                Thread.Sleep(1000);
            }
        }
        public Boolean Debt_SelectDescending()
        {
            driver.FindElement(Debt_Descending).Click();
            Boolean desc = driver.FindElement(Debt_Descending).Enabled;
            return desc;
        }
        public Boolean Debt_SelectAscending()
        {
            driver.FindElement(Debt_Ascending).Click();
            Boolean asce = driver.FindElement(Debt_Ascending).Enabled;
            return asce;
        }
        public bool Debt_ChangeToListView()
        {
            var elementToClick = driver.FindElement(Debt_ChangeView);
            Actions action = new Actions(driver);
            action.Click(elementToClick).Build().Perform();
            Thread.Sleep(3000);
            bool lview = driver.FindElement(Debt_ListView).Displayed;
            return lview;
        }
        public bool Debt_ChangeToCardView()
        {
            var elementToClick = driver.FindElement(Debt_ChangeView);
            Actions action = new Actions(driver);
            action.Click(elementToClick).Build().Perform();
            Thread.Sleep(3000);
            bool cview = driver.FindElement(Debt_CardBody).Displayed;
            return cview;
        }
        public string NavigateToLoanDetails()
        {
            driver.FindElement(CardBody).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(LoanDetailsScreen)); no such title
            String title = driver.FindElement(LoanDetailsScreen).Text;
            return title;
        }
        public String NavigateBackToDebt()
        {
            driver.FindElement(DebtSummaryLink).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(DebtSummary));
            String title = driver.FindElement(DebtSummary).Text;
            return title;
        }
        public String ReturnCardLabel1()
        {
            String label = driver.FindElement(Card_label1).Text;
            return label;
        }
        public String ReturnCardLabel2()
        {
            String label = driver.FindElement(Card_label2).Text;
            return label;
        }
        public String ReturnCardLabel3()
        {
            String label = driver.FindElement(Card_label3).Text;
            return label;
        }
        public String ReturnCardLabel4()
        {
            String label = driver.FindElement(Card_label4).Text;
            return label;
        }
        public String ReturnCardLabel5()
        {
            String label = driver.FindElement(Card_label5).Text;
            return label;
        }
        public String ReturnCardLabel6()
        {
            String label = driver.FindElement(Card_label6).Text;
            return label;
        }
        //Verifying all fields in add loan screen are mandatory
        public void AddLoan_LenderNameIsMandatory()
        {
            driver.FindElement(AddLoan).Click();
            driver.FindElement(PropertyDropdown).Click();
            SelectElement propertyname = new SelectElement(driver.FindElement(PropertyDropdown));
            propertyname.SelectByIndex(3);
            driver.FindElement(LoanTypeDropdown).Click();
            SelectElement loantypename = new SelectElement(driver.FindElement(LoanTypeDropdown));
            loantypename.SelectByIndex(2);
            driver.FindElement(Commitment).SendKeys("87463556");
            driver.FindElement(InterestTypeDropdown).Click();
            SelectElement interesttypenames = new SelectElement(driver.FindElement(InterestTypeDropdown));
            interesttypenames.SelectByIndex(1);
            driver.FindElement(InterestValue).SendKeys("12");
            driver.FindElement(Save).Click();
            Thread.Sleep(2000);
        }
        public void AddLoan_PropertyNameIsMandatory()
        {
            driver.FindElement(AddLoan).Click();
            driver.FindElement(LenderDropdown).Click();
            SelectElement lendername = new SelectElement(driver.FindElement(LenderDropdown));
            lendername.SelectByIndex(2);
            driver.FindElement(LoanTypeDropdown).Click();
            SelectElement loantypename = new SelectElement(driver.FindElement(LoanTypeDropdown));
            loantypename.SelectByIndex(2);
            driver.FindElement(Commitment).SendKeys("87463556");
            driver.FindElement(InterestTypeDropdown).Click();
            SelectElement interesttypenames = new SelectElement(driver.FindElement(InterestTypeDropdown));
            interesttypenames.SelectByIndex(1);
            driver.FindElement(InterestValue).SendKeys("12");
            driver.FindElement(Save).Click();
            Thread.Sleep(2000);
        }
        public void AddLoan_LoanTypeIsMandatory()
        {
            driver.FindElement(AddLoan).Click();
            driver.FindElement(LenderDropdown).Click();
            SelectElement lendername = new SelectElement(driver.FindElement(LenderDropdown));
            lendername.SelectByIndex(2);
            driver.FindElement(PropertyDropdown).Click();
            SelectElement propertyname = new SelectElement(driver.FindElement(PropertyDropdown));
            propertyname.SelectByIndex(3);
            driver.FindElement(Commitment).SendKeys("87463556");
            driver.FindElement(InterestTypeDropdown).Click();
            SelectElement interesttypenames = new SelectElement(driver.FindElement(InterestTypeDropdown));
            interesttypenames.SelectByIndex(1);
            driver.FindElement(InterestValue).SendKeys("12");
            driver.FindElement(Save).Click();
            Thread.Sleep(2000);
        }
        public void AddLoan_TotalLoanCommitmentIsMandatory()
        {
            driver.FindElement(AddLoan).Click();
            driver.FindElement(LenderDropdown).Click();
            SelectElement lendername = new SelectElement(driver.FindElement(LenderDropdown));
            lendername.SelectByIndex(2);
            driver.FindElement(PropertyDropdown).Click();
            SelectElement propertyname = new SelectElement(driver.FindElement(PropertyDropdown));
            propertyname.SelectByIndex(3);
            driver.FindElement(LoanTypeDropdown).Click();
            SelectElement loantypename = new SelectElement(driver.FindElement(LoanTypeDropdown));
            loantypename.SelectByIndex(2);
            driver.FindElement(InterestTypeDropdown).Click();
            SelectElement interesttypenames = new SelectElement(driver.FindElement(InterestTypeDropdown));
            interesttypenames.SelectByIndex(1);
            driver.FindElement(InterestValue).SendKeys("12");
            driver.FindElement(Save).Click();
            Thread.Sleep(2000);
        }
        public void AddLoan_OriginationDateIsMandatory()
        {
            driver.FindElement(AddLoan).Click();
            driver.FindElement(LenderDropdown).Click();
            SelectElement lendername = new SelectElement(driver.FindElement(LenderDropdown));
            lendername.SelectByIndex(2);
            driver.FindElement(PropertyDropdown).Click();
            SelectElement propertyname = new SelectElement(driver.FindElement(PropertyDropdown));
            propertyname.SelectByIndex(3);
            driver.FindElement(LoanTypeDropdown).Click();
            SelectElement loantypename = new SelectElement(driver.FindElement(LoanTypeDropdown));
            loantypename.SelectByIndex(2);
            driver.FindElement(Commitment).SendKeys("87463556");
            driver.FindElement(AddLoan_OriginationDate).Clear();
            driver.FindElement(InterestTypeDropdown).Click();
            SelectElement interesttypenames = new SelectElement(driver.FindElement(InterestTypeDropdown));
            interesttypenames.SelectByIndex(1);
            driver.FindElement(InterestValue).SendKeys("12");
            driver.FindElement(Save).Click();
            Thread.Sleep(2000);
        }
        public void AddLoan_InitialMaturityIsMandatory()
        {
            driver.FindElement(AddLoan).Click();
            driver.FindElement(LenderDropdown).Click();
            SelectElement lendername = new SelectElement(driver.FindElement(LenderDropdown));
            lendername.SelectByIndex(2);
            driver.FindElement(PropertyDropdown).Click();
            SelectElement propertyname = new SelectElement(driver.FindElement(PropertyDropdown));
            propertyname.SelectByIndex(3);
            driver.FindElement(LoanTypeDropdown).Click();
            SelectElement loantypename = new SelectElement(driver.FindElement(LoanTypeDropdown));
            loantypename.SelectByIndex(2);
            driver.FindElement(Commitment).SendKeys("87463556");
            driver.FindElement(Initialmaturity).Clear();
            driver.FindElement(InterestTypeDropdown).Click();
            SelectElement interesttypenames = new SelectElement(driver.FindElement(InterestTypeDropdown));
            interesttypenames.SelectByIndex(1);
            driver.FindElement(InterestValue).SendKeys("12");
            driver.FindElement(Save).Click();
            Thread.Sleep(2000);
        }
        public void AddLoan_InterestRateTypeIsMandatory()
        {
            driver.FindElement(AddLoan).Click();
            driver.FindElement(LenderDropdown).Click();
            SelectElement lendername = new SelectElement(driver.FindElement(LenderDropdown));
            lendername.SelectByIndex(2);
            driver.FindElement(PropertyDropdown).Click();
            SelectElement propertyname = new SelectElement(driver.FindElement(PropertyDropdown));
            propertyname.SelectByIndex(3);
            driver.FindElement(LoanTypeDropdown).Click();
            SelectElement loantypename = new SelectElement(driver.FindElement(LoanTypeDropdown));
            loantypename.SelectByIndex(2);
            driver.FindElement(Commitment).SendKeys("87463556");
            driver.FindElement(InterestValue).SendKeys("12");
            driver.FindElement(Save).Click();
            Thread.Sleep(2000);
        }
        public string CaptureAlertMessage() //All fields are mandatory
        {
            String alertMessage = driver.FindElement(AlertPopUp).Text;
            return alertMessage;
        }
        public void ReturnCurrentMaturityOflatestLoan()
        {
            IList<IWebElement> alldates = driver.FindElements(currentMaturityAll);
            int count = alldates.Count;
            DateTime today = DateTime.Today;
            DateTime yearInTheFuture = today.AddYears(1);
            String yearValue = yearInTheFuture.ToString("MM/DD/YYYY");
            for (int i = 0; i < count; i++)
            {
                String dateinCard = alldates[i].Text;
                if (dateinCard == yearValue)
                {

                }
            }
        }
        public int SeeCurrentMonthsToMaturityValue()
        {
            String currentMaturity = driver.FindElement(monthsMaturityValue).Text;
            int MaturityonCard = int.Parse(currentMaturity);
            return MaturityonCard;
        }
        public void archive_Loan()
        {
            driver.FindElement(ArchiveLoan).Click();
            Thread.Sleep(2000);
            driver.FindElement(OkButton).Click();
        }

    }
}
