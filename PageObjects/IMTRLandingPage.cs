using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InvestmentManagement.PageObjects
{
    class IMTRLandingPage
    {
        private IWebDriver driver;
        public IMTRLandingPage(IWebDriver driver)
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
        By MenuIcon = By.XPath("//input[@class='menu_checkbox']");
        By TrackRecord = By.XPath("//div[@class='menu']/div[2]/div[2]/div/a");
        By PerformanceStats = By.XPath("//div/div/div[3]/div[2]/header/div/div/div/button[1]/span");
        By EquityInvestedLabel = By.XPath("//div/div/div[3]/div[3]/div/div/div[2]/div/label");
        By EquityInvestedSubLabel = By.XPath("//div/div/div[3]/div[3]/div/div/div[2]/div/label[2]");
        By TotalSFLabel = By.XPath("//div/div/div[3]/div[3]/div/div/div/div/label");
        By TotalSFSubLabel = By.XPath("//div/div/div[3]/div[3]/div/div/div/div/label[2]");
        By OccupanyRate = By.XPath("//div/div/div[3]/div[3]/div/div/div[3]/div/label");
        By OccupanyRateSub = By.XPath("//div/div/div[3]/div[3]/div/div/div[3]/div/label[2]");
        By OngoingTab = By.XPath("//div/div/div[3]/div[2]/header/div/div/div/button[2]/span");
        By SoldDealsTab = By.XPath("//div/div/div[3]/div[2]/header/div/div/div/button[3]/span");
        By Search = By.XPath("//div/div/div[3]/div[4]/div/div/div/span[2]/input");
        By Download = By.XPath("//div/div/div[3]/div[4]/div/div/div[2]/div/button");
        By DownloadAll = By.XPath("//div[@id='menu--1']/div");
        By DownloadOngoing = By.XPath("//div[@id='menu--1']/div[2]");
        By DownloadSold = By.XPath("//div[@id='menu--1']/div[3]");
        By ChangeView = By.XPath("//button[@class='IconButton']");
        By Filter = By.XPath("//div/div/div[3]/div[4]/div/div/div[2]/button[2]");
        By DropdownList = By.XPath("//div[@class='popupItem']/div/select");
        By Dropdownicon = By.XPath("//div[3]/ul/li/div/div");
        By Ascending = By.XPath("//div[3]/ul/li[2]/div/label/span");
        By Descending = By.XPath("//div[3]/ul/li[2]/div/label[2]/span");
        By CardView = By.XPath("//div/div/div[3]/div[4]/div/div[2]/div/div/div/div/div[2]/div[2]/div");
        By ListView = By.XPath("//div/div/div[3]/div[4]/div/div[2]/div/div/div/div/div/div/div");
        By TableContents = By.XPath("//div/div/div[3]/div[4]/div/div[2]/div/div/div/div/div/div/div[2]/div/div");
        By ClickCard = By.XPath("//div/div/div[3]/div[4]/div/div[2]/div/div/div/div/div[2]/div[2]/div");
        By NumOfCardsHolder = By.XPath("//div/div/div[3]/div[4]/div/div[2]");
        By NumOfCards = By.XPath("//div/div/div[3]/div[4]/div/div[2]/div");
        By NumOfOngoingDeals = By.XPath("//div/div/div[3]/div[3]/div/div[2]/div/div[2]/div/div/div/div/span");
        By NumOfSoldDeals = By.XPath("//div/div/div[3]/div[3]/div/div[2]/div[2]/div[2]/div/div/div/div/span");


        By Pagestag = By.ClassName("rt-td");
        By IMTRPropDetails = By.XPath("//div/div/div[3]/div/div/div/div/div");

        By List_Column1 = By.XPath("//div[@class='rt-thead -header']/div/div[1]/div");
        By List_Column2 = By.XPath("//div[@class='rt-thead -header']/div/div[2]/div");
        By List_Column3 = By.XPath("//div[@class='rt-thead -header']/div/div[3]/div");
        By List_Column4 = By.XPath("//div[@class='rt-thead -header']/div/div[4]/div");
        By List_Column5 = By.XPath("//div[@class='rt-thead -header']/div/div[5]/div");
        By List_Column6 = By.XPath("//div[@class='rt-thead -header']/div/div[6]/div");
        By List_Column7 = By.XPath("//div[@class='rt-thead -header']/div/div[7]/div");


        //archive loan
        By NumberOfCard = By.XPath("//div[@class='row']");
        By Card = By.XPath("//div[@class='card-main-body']");
        By SearchIcon = By.XPath("//input[@placeholder='Type to search...']");
        By ArchiveIcon = By.CssSelector("[data-tip='Archive Property']");
        By EditIcon = By.CssSelector("[data-tip='Click to edit']");
        By YearInDis = By.XPath("//select[@class='react-datepicker__year-select']");
        By MonthInDis = By.XPath("//select[@class='react-datepicker__month-select']");
        By DayInDis = By.XPath("//div[@class='react-datepicker__day react-datepicker__day--015']");
        By dispositonDateInput = By.XPath("//*[@id='root']/div/div[3]/div[1]/div/div/div/div[2]/div/div[2]/div[1]/div[1]/div/div[2]/div[4]/div[2]/div/div/span/div/div/input");
        By InputSoldPrice = By.CssSelector("[value='0.00']");
        By Sold_OKButton = By.XPath("/html/body/div[2]/div[3]/div/div[3]/button[1]/span[1]");
        By GI_Status = By.XPath("//*[@id='root']/div/div[3]/div[1]/div/div/div/div[2]/div/div[2]/div[1]/div[1]/div/div[2]/div[16]/div[2]/div/div/span");
        By Track_Record = By.XPath("//div[contains(text(),'Track Record')]");
        By AlertTextDis = By.XPath("//*[@id='root']/div/div[1]/div/div/div[1]/div/div[2]");
        By SaveIcon = By.CssSelector("[data-tip='Save']");


        By EditIcon_Capitalization = By.XPath("//body//div[@id='root']//div//div//div//div//div//div//div//div//div//div[2]//div[1]//div[1]//div[1]//div[3]//div[2]//*[local-name()='svg']");
        By Debt_Capitalization = By.XPath("//*[@id='root']/div/div[3]/div[1]/div/div/div/div[2]/div/div[2]/div[2]/div[1]/div/div[2]/div[2]/div[2]/div/div/span/input");
        By IE_Capitalization = By.XPath("//*[@id='root']/div/div[3]/div[1]/div/div/div/div[2]/div/div[2]/div[2]/div[1]/div/div[2]/div[5]/div[2]/div/div/span/input");
        By SSE_Capitalization = By.XPath("//*[@id='root']/div/div[3]/div[1]/div/div/div/div[2]/div/div[2]/div[2]/div[1]/div/div[2]/div[6]/div[2]/div/div/span/input");
        By OSE_Capitalization = By.XPath("//*[@id='root']/div/div[3]/div[1]/div/div/div/div[2]/div/div[2]/div[2]/div[1]/div/div[2]/div[7]/div[2]/div/div/span/input");

        // General Information : Input values
        By Edit_GI = By.XPath("//label[text()='General Information']/parent::div/parent::div/parent::div/div[3]/div[2]");
        By SaveIcon_GI = By.CssSelector("[data-tip='Save']");
        By PropertyName_GI = By.XPath("//label[text()='Yardi Property Code']/parent::div/parent::div/parent::div/parent::div/div[2]/div[2]/div/div/span/input");
        By RSF_GI = By.XPath("//label[text()='Yardi Property Code']/parent::div/parent::div/parent::div/parent::div/div[11]/div[2]/div/div/span/input");
        By PurchasePrice_GI = By.XPath("//label[text()='Yardi Property Code']/parent::div/parent::div/parent::div/parent::div/div[12]/div[2]/div/div/span/input");
        By SoldPrice_GI = By.XPath("//label[text()='Yardi Property Code']/parent::div/parent::div/parent::div/parent::div/div[13]/div[2]/div/div/span/input");
        By AcqDate_GI = By.XPath("//label[text()='Yardi Property Code']/parent::div/parent::div/parent::div/parent::div/div[3]/div[2]/div/div/span/div/div/input");
        By DisDate_GI = By.XPath("//label[text()='Yardi Property Code']/parent::div/parent::div/parent::div/parent::div/div[4]/div[2]/div/div/span/div/div/input");

        // To get the text value : General Information
        By PropertyName_GI_Text = By.XPath("//label[text()='Yardi Property Code']/parent::div/parent::div/parent::div/parent::div/div[2]/div[2]/div/div");
        By RSF_GI_Text = By.XPath("//label[text()='Yardi Property Code']/parent::div/parent::div/parent::div/parent::div/div[11]/div[2]/div/div");
        By PurchasePrice_GI_Text = By.XPath("//label[text()='Yardi Property Code']/parent::div/parent::div/parent::div/parent::div/div[12]/div[2]/div/div");
        By SoldPrice_GI_Text = By.XPath("//label[text()='Yardi Property Code']/parent::div/parent::div/parent::div/parent::div/div[13]/div[2]/div/div");
        By AcqDate_GI_Text = By.XPath("//label[text()='Yardi Property Code']/parent::div/parent::div/parent::div/parent::div/div[3]/div[2]/div/div");
        By DisDate_GI_Text = By.XPath("//label[text()='Yardi Property Code']/parent::div/parent::div/parent::div/parent::div/div[4]/div[2]/div/div");

        //Capitalization
        By TotalCapitalization = By.XPath("//label[text()='Total Capitalization']/parent::div/parent::div/parent::div[1]/div[2]");
        By Debt = By.XPath("//label[text()='Total Capitalization']/parent::div/parent::div/parent::div/parent::div/div[2]/div[2]");
        By Total_Eqty = By.XPath("//label[text()='Total Capitalization']/parent::div/parent::div/parent::div/parent::div/div[3]/div[2]");
        By LTC = By.XPath("//label[text()='Total Capitalization']/parent::div/parent::div/parent::div/parent::div/div[4]/div[2]");
        By Inv_Equity = By.XPath("//label[text()='Total Capitalization']/parent::div/parent::div/parent::div/parent::div/div[5]/div[2]");
        By Stream_Sponser_Eq = By.XPath("//label[text()='Total Capitalization']/parent::div/parent::div/parent::div/parent::div/div[6]/div[2]");
        By Outsider_Sponser_Eq = By.XPath("//label[text()='Total Capitalization']/parent::div/parent::div/parent::div/parent::div/div[6]/div[2]");


        //ThirdpartySponsorReturn

        By EditANDSave_Icon_PSR = By.XPath("//label[text()='3rd - Party Sponsor Returns']/parent::div/parent::div/parent::div/div[3]/div[2]");
        By ThirdpartySponsor = By.XPath("//label[text()='3rd-Party Sponsor Distributions']/parent::div/parent::div/parent::div/div[2]/div/div/span/input");
        By ThirdpartySponsor_Text = By.XPath("//label[text()='3rd-Party Sponsor Distributions']/parent::div/parent::div/parent::div/div[2]/div/div/span");

        // SponsorReturn
        By EditANDSave_Icon_SR = By.XPath("//label[text()='Sponsor Returns - Stream']/parent::div/parent::div/parent::div/div[3]/div[2]");
        By StreamSSD = By.XPath("//label[text()='Stream Sponsor Distributions']/parent::div/parent::div/parent::div/div[2]/div/div/span/input");
        By StreamSSD_Text = By.XPath("//label[text()='Stream Sponsor Distributions']/parent::div/parent::div/parent::div/div[2]/div/div/span");

        // Investor Return 
        By EditANDSave_Icon_IR = By.XPath("//label[text()='Investor Returns']/parent::div/parent::div/parent::div/div[3]/div[2]");
        By ID_InputField = By.XPath("//label[text()='Investor Distributions']/parent::div/parent::div/parent::div/div[2]/div/div/span/input");
        By ID_Text = By.XPath("//label[text()='Investor Distributions']/parent::div/parent::div/parent::div/div[2]/div/div/span");

        // PURCHASE VS. EXIT 
        By EditANDSave_Icon_PE = By.XPath("//label[text()='Purchase Vs. Exit']/parent::div/parent::div/parent::div/div[3]/div[2]");
        By PE_InputField = By.XPath("//label[text()='Exit Price']/parent::div/parent::div/parent::div/div[2]/div/div/span/input");
        By PE_Text = By.XPath("//label[text()='Exit Price']/parent::div/parent::div/parent::div/div[2]/div/div/span");



        public bool DispositionDate()
        {
            driver.FindElement(dispositonDateInput).Click();
            // SelectElement Dispositionyear = new SelectElement(driver.FindElement(YearInDis));
            // extention.SelectByIndex(2);

            Thread.Sleep(2000);
            SelectElement DispositionMonth = new SelectElement(driver.FindElement(MonthInDis));
            DispositionMonth.SelectByText("October");

            Thread.Sleep(2000);
            driver.FindElement(DayInDis).Click();

            Thread.Sleep(2000);
            clickOnSave();
            Thread.Sleep(2000);


            string alertMessage = PopUpAlertText();
            String TextToCompare = "Please enter Disposition Date and sold Price to sell a property.";

            if (TextToCompare == alertMessage)
            {
                return true;

            }
            else
            {

                return false;
            }
        }
        public void clickOnSave()
        {

            driver.FindElement(SaveIcon).Click();
        }

        public string Status()
        {
            String Status = driver.FindElement(GI_Status).Text;
            return Status;
        }

        public void PropertyStatus()
        {
            String BUPropertyStatus = Status();
            Thread.Sleep(2000);
            clickOnEditIcon();
            Thread.Sleep(2000);
            SelectElement DispositionMonth = new SelectElement(driver.FindElement(MonthInDis));
            DispositionMonth.SelectByText("October");

            Thread.Sleep(2000);
            driver.FindElement(DayInDis).Click();

            driver.FindElement(InputSoldPrice).Clear();
            Thread.Sleep(1000);
            driver.FindElement(InputSoldPrice).SendKeys("1000");

            clickOnSave();
            String AUPropertyStatus = Status();

            Thread.Sleep(3000);
            driver.FindElement(Track_Record).Click();
            Thread.Sleep(5000);
        }

        public bool SoldPrice()
        {

            driver.FindElement(InputSoldPrice).Clear();
            Thread.Sleep(1000);
            driver.FindElement(InputSoldPrice).SendKeys("1000");
            Thread.Sleep(2000);
            clickOnSave();
            Thread.Sleep(2000);


            string alertMessage = PopUpAlertText();
            String TextToCompare = "Please enter Disposition Date and sold Price to sell a property.";

            if (TextToCompare == alertMessage)
            {
                return true;

            }
            else
            {

                return false;
            }
        }

        public string PopUpAlertText()
        {
            String AlertText = driver.FindElement(AlertTextDis).Text;
            Console.WriteLine(AlertText);
            Thread.Sleep(2000);
            return AlertText;

        }
        public void clickOnArchiveIcon()
        {

            driver.FindElement(ArchiveIcon).Click();
            Thread.Sleep(5000);
        }
        public int CountNumberOfLoan()
        {
            //IWebElement table1 = driver.FindElement(NumOfCards);
            IList<IWebElement> listOFLoan = driver.FindElements(NumberOfCard);
            int NumofRowsbefore = listOFLoan.Count;
            return NumofRowsbefore;
            Console.WriteLine(NumofRowsbefore);
        }

        public void clickOnEditIcon()
        {

            driver.FindElement(EditIcon).Click();

        }
        public void SerachProperty()
        {
            Thread.Sleep(5000);
            driver.FindElement(SearchIcon).Click();
            String propertyName = "One51 - Phase"; // Mallard Creek
            driver.FindElement(SearchIcon).SendKeys(propertyName);

        }
        public void ClickTrackRecordOnInMenu()
        {
            Thread.Sleep(5000);
            driver.FindElement(MenuIcon).Click();
            driver.FindElement(TrackRecord).Click();
            Thread.Sleep(1000);
        }
        public void ClickPerformanceStats()
        {
            driver.FindElement(PerformanceStats).Click();
        }
        public String GetTotalSFGraphTitles()
        {
            String totalsftitle = driver.FindElement(TotalSFLabel).Text;
            return totalsftitle;
        }

        public void clickOnCard()
        {

            driver.FindElement(Card).Click();
        }
        public String GetTotalSFSubTitle()
        {
            String subtitle = driver.FindElement(TotalSFSubLabel).Text;
            return subtitle;
        }
        public String GetTotalEquityInvestedTitles()
        {
            String totaleqtitle = driver.FindElement(EquityInvestedLabel).Text;
            return totaleqtitle;
        }
        public String GetTotalEquityInvestedSubTitle()
        {
            String subtitle = driver.FindElement(EquityInvestedSubLabel).Text;
            return subtitle;
        }
        public String GetOccupanyGraphTitle()
        {
            String totaleqtitle = driver.FindElement(OccupanyRate).Text;
            return totaleqtitle;
        }
        public String GetOccupanyGraphSubTitle()
        {
            String subtitle = driver.FindElement(OccupanyRateSub).Text;
            return subtitle;
        }
        public void ClickOngoingDeals()
        {
            driver.FindElement(OngoingTab).Click();
        }
        public void ClickSoldDeals()
        {
            driver.FindElement(SoldDealsTab).Click();
        }
        public int GetNumOfOngoingDealsOnTile()
        {
            var TotalOngoingdeals = driver.FindElement(NumOfOngoingDeals).Text;
            int ongoingnum = int.Parse(TotalOngoingdeals);
            return ongoingnum;
        }
        public int GetNumOfSoldDealsOnTile()
        {
            Thread.Sleep(1000);
            var TotalSolddeals = driver.FindElement(NumOfSoldDeals).Text;
            int soldnum = int.Parse(TotalSolddeals);
            return soldnum;
        }
        public int GetNumOfOngoingDealsInTable()
        {
            IWebElement Tabledata = driver.FindElement(NumOfCardsHolder);
            var totalrows = Tabledata.FindElements(NumOfCards);
            int totalDeals = totalrows.Count;
            return totalDeals;
        }
        public int GetNumOfSoldDealsInTable()
        {
            IWebElement Tabledata = driver.FindElement(NumOfCardsHolder);
            var totalrows = Tabledata.FindElements(NumOfCards);
            int totalDeals = totalrows.Count;
            return totalDeals;
        }
        public void DownloadReportForAllDeals()
        {
            driver.FindElement(Download).Click();
            driver.FindElement(DownloadAll).Click();
            Thread.Sleep(3000);
            driver.FindElement(Download).Click();
            driver.FindElement(DownloadOngoing).Click();
            Thread.Sleep(3000);
            driver.FindElement(Download).Click();
            driver.FindElement(DownloadSold).Click();
            Thread.Sleep(3000);
        }
        public void NavigateToIMTRPropDetail()
        {
            driver.FindElement(ClickCard).Click();
        }
        public void ClickInvestMentTrackRecordFromIMTR()
        {
            Thread.Sleep(2000);
            driver.FindElement(MenuIcon).Click();
            driver.FindElement(TrackRecord).Click();
            Thread.Sleep(1000);
        }
        public String UserLandsOnPropertyDeatilsScreen()
        {
            Thread.Sleep(5000);
            String IMTrPropdetailsScreen = driver.FindElement(IMTRPropDetails).Text;
            return IMTrPropdetailsScreen;
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
            driver.FindElement(Search).SendKeys("7");
            driver.FindElement(Search).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            IList<IWebElement> listOfRows1 = driver.FindElements(NumOfCards);
            int NumofRowsafter = listOfRows1.Count;
            return NumofRowsafter;
        }
        public void ChangeToView()
        {
            var elementToClick = driver.FindElement(ChangeView);
            Actions action = new Actions(driver);
            action.Click(elementToClick).Build().Perform();
        }
        public bool ChangeToListView()
        {
            var elementToClick = driver.FindElement(ChangeView);
            Actions action = new Actions(driver);
            action.Click(elementToClick).Build().Perform();
            //action.DoubleClick(elementToClick).Build().Perform();
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
            bool cview = driver.FindElement(CardView).Displayed;
            return cview;
        }
        public void ClickOptionsInSortBy()
        {
            driver.FindElement(Filter).Click();
            driver.FindElement(Dropdownicon).Click();
            SelectElement sortby = new SelectElement(driver.FindElement(DropdownList));
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
        public String ReturnListViewColumnLabel1()
        {
            String label = driver.FindElement(List_Column1).Text;
            return label;
        }
        public String ReturnListViewColumnLabel2()
        {
            String label = driver.FindElement(List_Column2).Text;
            return label;
        }
        public String ReturnListViewColumnLabel3()
        {
            String label = driver.FindElement(List_Column3).Text;
            return label;
        }
        public String ReturnListViewColumnLabel4()
        {
            String label = driver.FindElement(List_Column4).Text;
            return label;
        }
        public String ReturnListViewColumnLabel5()
        {
            String label = driver.FindElement(List_Column5).Text;
            return label;
        }
        public String ReturnListViewColumnLabel6()
        {
            String label = driver.FindElement(List_Column6).Text;
            return label;
        }
        public String ReturnListViewColumnLabel7()
        {
            String label = driver.FindElement(List_Column7).Text;
            return label;
        }
        public String ReturnPerformanceHighlightsTabLabel()
        {
            String label = driver.FindElement(PerformanceStats).Text;
            return label;
        }
        public String ReturnOngoingDealTabLabel()
        {
            driver.FindElement(OngoingTab).Click();
            String label = driver.FindElement(OngoingTab).Text;
            return label;
        }
        public String ReturnSoldDealTabLabel()
        {
            driver.FindElement(SoldDealsTab).Click();
            String label = driver.FindElement(SoldDealsTab).Text;
            return label;
        }

        public bool capitalizationNullData()
        {

            driver.FindElement(EditIcon_Capitalization).Click();
            Thread.Sleep(2000);
            driver.FindElement(Debt_Capitalization).Clear();
            Thread.Sleep(2000);

            driver.FindElement(IE_Capitalization).Clear();
            Thread.Sleep(2000);

            driver.FindElement(SSE_Capitalization).Clear();
            Thread.Sleep(2000);

            driver.FindElement(OSE_Capitalization).Clear();
            Thread.Sleep(2000);

            driver.FindElement(SaveIcon).Click();
            Thread.Sleep(3000);

            bool result = CaptureAllTheCapitalizationValue();
            return result;

        }

        public bool CaptureAllTheCapitalizationValue()

        {

            String Value1 = driver.FindElement(TotalCapitalization).Text;
            String Value2 = driver.FindElement(Debt).Text;
            String Value3 = driver.FindElement(Total_Eqty).Text;
            String Value4 = driver.FindElement(LTC).Text;
            String Value5 = driver.FindElement(Inv_Equity).Text;
            String Value6 = driver.FindElement(Stream_Sponser_Eq).Text;
            String Value7 = driver.FindElement(Outsider_Sponser_Eq).Text;
            if (Value1 == "-" && Value2 == "-" && Value3 == "-" && Value4 == "-" && Value5 == "-" && Value6 == "-" && Value7 == "-")
            {
                return true;

            }
            else
            {

                return false;

            }
        }

        public bool GenralInformation()
        {
            driver.FindElement(Edit_GI).Click();
            Thread.Sleep(2000);

            driver.FindElement(PropertyName_GI).Clear();
            Thread.Sleep(2000);
            driver.FindElement(PropertyName_GI).SendKeys("null");
            Thread.Sleep(2000);
            driver.FindElement(AcqDate_GI).Click();
            Thread.Sleep(2000);
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(AcqDate_GI);
            Thread.Sleep(2000);
            element.SendKeys(Keys.Control + "a");
            Thread.Sleep(2000);
            element.SendKeys(Keys.Backspace);
            Thread.Sleep(2000);
            element.SendKeys(Keys.Escape);
            Thread.Sleep(2000);

            driver.FindElement(DisDate_GI).Click();

            IWebElement element1 = driver.FindElement(DisDate_GI);
            Thread.Sleep(2000);
            element1.SendKeys(Keys.Control + "a");
            Thread.Sleep(2000);
            element1.SendKeys(Keys.Backspace);
            Thread.Sleep(2000);
            element1.SendKeys(Keys.Escape);
            Thread.Sleep(2000);


            driver.FindElement(RSF_GI).Clear();
            Thread.Sleep(2000);
            driver.FindElement(PurchasePrice_GI).Clear();
            Thread.Sleep(2000);
            driver.FindElement(SoldPrice_GI).Clear();
            Thread.Sleep(2000);
            driver.FindElement(SaveIcon_GI).Click();
            Thread.Sleep(4000);

            bool result = CaptureAllTheGeneralInformationValue();
            return result;
        }

        public bool CaptureAllTheGeneralInformationValue()

        {

            String Value1 = driver.FindElement(PropertyName_GI_Text).Text;
            Console.WriteLine(Value1);
            String Value2 = driver.FindElement(AcqDate_GI_Text).Text;
            Console.WriteLine(Value2);
            String Value3 = driver.FindElement(DisDate_GI_Text).Text;
            Console.WriteLine(Value3);
            String Value4 = driver.FindElement(RSF_GI_Text).Text;
            Console.WriteLine(Value4);
            String Value5 = driver.FindElement(PurchasePrice_GI_Text).Text;
            Console.WriteLine(Value5);
            String Value6 = driver.FindElement(SoldPrice_GI_Text).Text;
            Console.WriteLine(Value6);
            if (Value1 == "null" && Value2 == "-" && Value3 == "-" && Value4 == "-" && Value5 == "-" && Value6 == "-")
            {
                return true;

            }
            else
            {

                return false;

            }
        }

        public bool ThirdpartySponsorReturn()
        {
            driver.FindElement(EditANDSave_Icon_PSR).Click();
            Thread.Sleep(1000);
            driver.FindElement(ThirdpartySponsor).Clear();
            Thread.Sleep(1000);
            driver.FindElement(EditANDSave_Icon_PSR).Click();
            Thread.Sleep(3000);
            String value = driver.FindElement(ThirdpartySponsor_Text).Text;
            Console.WriteLine(value);
            if (value == "-")
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool SponsorReturn()
        {
            driver.FindElement(EditANDSave_Icon_SR).Click();
            Thread.Sleep(1000);
            driver.FindElement(StreamSSD).Clear();
            Thread.Sleep(1000);
            driver.FindElement(EditANDSave_Icon_SR).Click();
            Thread.Sleep(3000);
            String value = driver.FindElement(StreamSSD_Text).Text;
            Thread.Sleep(3000);
            Console.WriteLine(value);
            if (value == "-")
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        public bool PurchaseVsExit()
        {
            driver.FindElement(EditANDSave_Icon_PE).Click();
            Thread.Sleep(1000);
            driver.FindElement(PE_InputField).Clear();
            Thread.Sleep(1000);
            driver.FindElement(EditANDSave_Icon_PE).Click();
            Thread.Sleep(3000);
            String value = driver.FindElement(PE_Text).Text;
            Thread.Sleep(3000);
            Console.WriteLine(value);
            if (value == "-")
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public bool InvestorReturn()
        {
            driver.FindElement(EditANDSave_Icon_IR).Click();
            Thread.Sleep(1000);
            driver.FindElement(ID_InputField).Clear();
            Thread.Sleep(1000);
            driver.FindElement(EditANDSave_Icon_IR).Click();
            Thread.Sleep(3000);
            String value = driver.FindElement(ID_Text).Text;
            Thread.Sleep(3000);
            Console.WriteLine(value);
            if (value == "-")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
