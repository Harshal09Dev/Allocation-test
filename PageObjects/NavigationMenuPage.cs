using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_InvestmentMangement.PageObjects
{
    class NavigationMenuPage
    {
        private IWebDriver driver;
        public NavigationMenuPage(IWebDriver driver)
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
        By fundsdropdwon = By.XPath("//div/div/div[2]/div/div[5]/div/div[2]/div/div/a");
        By fundAdrop = By.XPath("//div/div/div[2]/div/div[5]/div/div[2]/div/div[2]/div/div/a");
        By fundBdrop = By.XPath("//div/div/div[2]/div/div[5]/div/div[2]/div/div[2]/div[2]/div/a");
        By TrackRecord = By.XPath("//div[@class='menu']/div[2]/div[2]/div/a");
        By PropertyMaintenanceMenu = By.XPath("//div[@class='menu']/div[2]/div[3]/div/a");
        By LoanMaintenanceMenu = By.XPath("//div[@class='menu']/div[2]/div[4]/div/a");
        By ContingentOption = By.XPath("//div[@class='menu']/div[2]/div[5]/div/a");
        By BudgetSummaryMenu = By.XPath("//div[@class='menu']/div[2]/div[6]/div/a");
        By MyAboutMenu = By.XPath("//div[@class='menu']/div[2]/div[7]/div/a");
        By FundATab = By.XPath("//div/div/div[3]/div/div/button");
        By FundBTab = By.XPath("//div/div/div[3]/div/div[2]/button");
        By asOfDate = By.XPath("//div[@class='as-of-container']/div/div/div/input");
        By OrgSelctionX = By.XPath("//div[@class='header-container']/div[4]/div/select");

        //
        //Locators from card 
        By Card_label1 = By.XPath("//div[@class='card-main-body']/div[2]/div[1]/div/span");
        By Card_label2 = By.XPath("//div[@class='card-main-body']/div[2]/div[2]/div/span");
        By Card_label3 = By.XPath("//div[@class='card-main-body']/div[2]/div[3]/div/span");
        By Card_label4 = By.XPath("//div[@class='card-main-body']/div[2]/div[5]/div/span");
        By Card_label5 = By.XPath("//div[@class='card-main-body']/div[2]/div[6]/div/span");
        By Card_label6 = By.XPath("//div[@class='card-main-body']/div[2]/div[7]/div/span");

        //Locators from list view
        By List_Column1 = By.XPath("//div[@class='rt-thead -header']/div/div[1]/div/span");
        By List_Column2 = By.XPath("//div[@class='rt-thead -header']/div/div[2]/div/span");
        By List_Column3 = By.XPath("//div[@class='rt-thead -header']/div/div[3]/div/span");
        By List_Column4 = By.XPath("//div[@class='rt-thead -header']/div/div[4]/div/span");
        By List_Column5 = By.XPath("//div[@class='rt-thead -header']/div/div[5]/div/span");
        By List_Column6 = By.XPath("//div[@class='rt-thead -header']/div/div[6]/div/span");
        By List_Column7 = By.XPath("//div[@class='rt-thead -header']/div/div[7]/div/span");
        By List_Column8 = By.XPath("//div[@class='rt-thead -header']/div/div[8]/div/span");
        By List_Column9 = By.XPath("//div[@class='rt-thead -header']/div/div[9]/div/span");
        By List_Column10 = By.XPath("//div[@class='rt-thead -header']/div/div[10]/div/span");
        By List_Column11 = By.XPath("//div[@class='rt-thead -header']/div/div[11]/div/span");
        By List_Column12 = By.XPath("//div[@class='rt-thead -header']/div/div[12]/div/span");
        By List_Column13 = By.XPath("//div[@class='rt-thead -header']/div/div[13]/div/span");
        By List_Column14 = By.XPath("//div[@class='rt-thead -header']/div/div[14]/div/span");

        By AlertText = By.XPath("//div[@class='mainContainer']/div/div/div/div/div/div[2]");

        public void ClickMainMenu()
        {
            driver.FindElement(MenuIcon).Click();
        }
        public void ClickFundAFromDropDown()
        {
            driver.FindElement(fundAdrop).Click();
        }
        public void ClickFundBFromDropDown()
        {
            driver.FindElement(fundBdrop).Click();
        }
        public void ClickTrackRecordOption()
        {
            driver.FindElement(TrackRecord).Click();
        }
        public void ClickPropertyMaintenanceOption()
        {
            driver.FindElement(PropertyMaintenanceMenu).Click();
        }
        public void ClickLoanMaintenanceOption()
        {
            driver.FindElement(LoanMaintenanceMenu).Click();
        }
        public void ClickContingentLiabilityOption()
        {
            driver.FindElement(ContingentOption).Click();
        }
        public void ClickBudgetSummaryOption()
        {
            driver.FindElement(BudgetSummaryMenu).Click();
        }
        public void ClickMyAboutOption()
        {
            driver.FindElement(MyAboutMenu).Click();
        }
        public void ClickFundATab()
        {
            driver.FindElement(FundATab).Click();
        }
        public void ClickFundBTab()
        {
            driver.FindElement(FundBTab).Click();
        }
        public void SelectPreviousMonth()
        {
            Actions action = new Actions(driver);
            IWebElement optionsList = driver.FindElement(asOfDate);
            action.MoveToElement(optionsList);

        }
        public void SelectIMOrganization()
        {
            SelectElement lendername = new SelectElement(driver.FindElement(OrgSelctionX));
            lendername.SelectByIndex(0);
        }
        public String ReturnCardLabel1()
        {
            String label=driver.FindElement(Card_label1).Text;
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
        public String ReturnListViewColumnLabel8()
        {
            String label = driver.FindElement(List_Column8).Text;
            return label;
        }
        public String ReturnListViewColumnLabel9()
        {
            String label = driver.FindElement(List_Column9).Text;
            return label;
        }
        public String ReturnListViewColumnLabel10()
        {
            String label = driver.FindElement(List_Column10).Text;
            return label;
        }
        public String ReturnListViewColumnLabel11()
        {
            String label = driver.FindElement(List_Column11).Text;
            return label;
        }
        public String ReturnListViewColumnLabel12()
        {
            String label = driver.FindElement(List_Column12).Text;
            return label;
        }
        public String VerifyAlertText()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AlertText));
            var elementToClick = driver.FindElement(AlertText);
            String alertMessage = elementToClick.Text;
            return alertMessage;
        }

    }
}
