using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UI_InvestmentMangement.PageObjects
{
    class BudgetSummaryPage
    {
        private IWebDriver driver;
        public BudgetSummaryPage(IWebDriver driver)
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
        By BudgetSummaryMenu = By.XPath("//div[@class='menu']/div[2]/div[6]/div/a");
        By DevBudgetTitle = By.XPath("//div[@id='root']/div/div[3]/div/div/div/div[1]/div");
        By SearchOnMain = By.XPath("//div[@id='root']/div/div[3]/div/div/div/div[2]/div/div[2]/span[2]/input");
        By ChangeView = By.XPath("//div[@id='root']/div/div[3]/div/div/div/div[2]/div/div[3]/button[1]");
        By SortIcon = By.XPath("//div[@id='root']/div/div[3]/div/div/div/div[2]/div/div[3]/button[2]");
        By ListinDropdown = By.XPath("//div[@class='popupItem']/div[2]/select");
        By Ascending = By.XPath("//div[@role='presentation']/div[3]/ul/li[2]/div/label/span");
        By Decending = By.XPath("//div[@role='presentation']/div[3]/ul/li[2]/div/label[2]/span");
        By NumOfCards = By.XPath("//div[@id='root']/div/div[3]/div/div/div/div[2]/div[2]/div");
        By Card = By.XPath("//div[@id='root']/div/div[3]/div/div/div/div[2]/div[2]/div[2]");
        By CardView = By.XPath("//div/div/div[3]/div/div/div/div[2]/div[2]/div/div/div/div");
        By ListView = By.XPath("//div/div/div[3]/div/div/div/div[2]/div[2]/div/div/div/div/div/div/div/div");
        By DevDetailsScreen = By.XPath("//div[@class='maintenance-card-header']/div[2]");
        By DevelopmentLink = By.XPath("//div[@class='maintenance-card-header']/div[1]");
        By HeaderOptions = By.XPath("//div[@class='maintenance-card-body']/div/div/div[3]/div/div/div/div/div/div/div/div");
        By SearchOnDetails = By.XPath("//div[@class='maintenance-card-body']/div/div/div/div/div/span[2]");
        By SearchInput = By.XPath("//span[@class='autocompleteContainer']/div/div/input");
        By SearchResults = By.XPath("//span[@class='autocompleteContainer']/div/div/div");
        By DownloadExcel = By.XPath("//div[@class='maintenance-card-body']/div/div/div/div/div/span[3]");
        By SearchRes = By.XPath("//span[@class='autocompleteContainer']/div/div/div/a");

        ////Locators from card 
        By Card_label1 = By.XPath("//div[@class='card-main-body']/div[2]/div[1]/div/span");
        By Card_label2 = By.XPath("//div[@class='card-main-body']/div[2]/div[2]/div/span");
        By Card_label3 = By.XPath("//div[@class='card-main-body']/div[2]/div[4]/div/span");
        By Card_label4 = By.XPath("//div[@class='card-main-body']/div[2]/div[5]/div/span");
        By Card_label5 = By.XPath("//div[@class='card-main-body']/div[2]/div[6]/div/span");

        //locators for card view
        By List_label1 = By.XPath("//div[@class='rt-thead -header']/div/div[1]/div/span");
        By List_label2 = By.XPath("//div[@class='rt-thead -header']/div/div[2]/div/span");
        By List_label3 = By.XPath("//div[@class='rt-thead -header']/div/div[3]/div/span");
        By List_label4 = By.XPath("//div[@class='rt-thead -header']/div/div[4]/div/span");
        By List_label5 = By.XPath("//div[@class='rt-thead -header']/div/div[5]/div/span");
        By List_label6 = By.XPath("//div[@class='rt-thead -header']/div/div[6]/div/span");

        public void ClickBudgetSummaryMenu()
        {
            driver.FindElement(MenuIcon).Click();
            Thread.Sleep(2000);
            driver.FindElement(BudgetSummaryMenu).Click();
        }
        public String UserLandsOnDevelopmentBudget()
        {
            ClickBudgetSummaryMenu();
            Thread.Sleep(2000);
            String title=driver.FindElement(DevBudgetTitle).Text;
            return title;
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
            driver.FindElement(SearchOnMain).Click();
            driver.FindElement(SearchOnMain).SendKeys("Dev");
            driver.FindElement(SearchOnMain).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            IList<IWebElement> listOfRows1 = driver.FindElements(NumOfCards);
            int NumofRowsafter = listOfRows1.Count;
            return NumofRowsafter;
        }
        public void TestSortByInBudget()
        {
            driver.FindElement(SortIcon).Click();
            SelectElement sortby = new SelectElement(driver.FindElement(ListinDropdown));
            for (int i = 1; i < 6; i++)
            {
                sortby.SelectByIndex(i);
                driver.FindElement(Decending).Click();
                driver.FindElement(Ascending).Click();
                Thread.Sleep(1000);
            }
        }
        public Boolean SelectDescending()
        {
            driver.FindElement(Decending).Click();
            Boolean desc = driver.FindElement(Decending).Enabled;
            return desc;
        }
        public Boolean SelectAscending()
        {
            driver.FindElement(Ascending).Click();
            Boolean asce = driver.FindElement(Ascending).Enabled;
            return asce;
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
            bool cview = driver.FindElement(CardView).Displayed;
            return cview;
        }
        public String NavigateToBudgetDetails()
        {
            driver.FindElement(Card).Click();
            Thread.Sleep(3000);
            String title=driver.FindElement(DevDetailsScreen).Text;
            return title;
        }
        public String NavigateBackToDevelopmentLandingScreen()
        {
            driver.FindElement(DevelopmentLink).Click();
            Thread.Sleep(3000);
            String title = driver.FindElement(DevBudgetTitle).Text;
            return title;
        }
        public Boolean SearchInPropertyDetails()
        {
            driver.FindElement(SearchOnDetails).Click();
            driver.FindElement(SearchInput).SendKeys("Development");
            IList<IWebElement> listOfRows = driver.FindElements(SearchResults);
            int count = listOfRows.Count();
            if (count > 0)
            {
                return true;
            }
            return false;
        }
        public void downloadDevBudgetSummary()
        {
            driver.FindElement(DownloadExcel).Click();
            Thread.Sleep(3000);
        }
        public void GetTotalConfirmed()
        {
            //SFBCH002D01
            driver.FindElement(SearchOnDetails).Click();
            driver.FindElement(SearchInput).SendKeys("SFBCH002D01");
            driver.FindElement(SearchInput).SendKeys(Keys.Enter);           
        }
        public String CardView_ReturnJobCodelabel()
        {
            String label= driver.FindElement(Card_label1).Text;
            return label;
        }
        public String CardView_ReturnPropertyNamelabel()
        {
            String label = driver.FindElement(Card_label2).Text;
            return label;
        }
        public String CardView_ReturnInvoicedAmountlabel()
        {
            String label = driver.FindElement(Card_label3).Text;
            return label;
        }
        public String CardView_ReturnNewBudgetlabel()
        {
            String label = driver.FindElement(Card_label4).Text;
            return label;
        }
        public String CardView_ReturnOverBudgetlabel()
        {
            String label = driver.FindElement(Card_label5).Text;
            return label;
        }
        public String ListView_ReturnJobCodelabel()
        {
            String label = driver.FindElement(List_label1).Text;
            return label;
        }
        public String ListView_ReturnJobDescriptionlabel()
        {
            String label = driver.FindElement(List_label2).Text;
            return label;
        }
        public String ListView_ReturnPropertyNamelabel()
        {
            String label = driver.FindElement(List_label3).Text;
            return label;
        }
        public String ListView_ReturnInvoicedAmountlabel()
        {
            String label = driver.FindElement(List_label4).Text;
            return label;
        }
        public String ListView_ReturnNewBudgetAmountlabel()
        {
            String label = driver.FindElement(List_label5).Text;
            return label;
        }
        public String ListView_ReturnOverBudgetAmountlabel()
        {
            String label = driver.FindElement(List_label6).Text;
            return label;
        }
        public String DetailsScreenListView_ReturnCategoryCodelabel()
        {
            String label = driver.FindElement(List_label1).Text;
            return label;
        }
        public String DetailsScreenListView_ReturnCategoryDescriptionlabel()
        {
            String label = driver.FindElement(List_label2).Text;
            return label;
        }
        public String DetailsScreenListView_ReturnRevisedBudgetlabel()
        {
            String label = driver.FindElement(List_label3).Text;
            return label;
        }
        public String DetailsScreenListView_ReturnToDateSpentlabel()
        {
            String label = driver.FindElement(List_label4).Text;
            return label;
        }
        public String DetailsScreenListView_ReturnOverBudgetlabel()
        {
            String label = driver.FindElement(List_label5).Text;
            return label;
        }

    }
}
