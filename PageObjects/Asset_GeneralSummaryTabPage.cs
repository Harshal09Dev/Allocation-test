using AutoItX3Lib;
using InvestmentManagement.BaseClass;
using MongoDB.Driver;
using MongoDB.Driver.Core.WireProtocol.Messages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UI_InvestmentMangement.PageObjects
{
    class AssetPropertyDetailsPage
    {
        private IWebDriver driver;
        public AssetPropertyDetailsPage(IWebDriver driver)
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
        //Property Header and Category Locators
        By MarketAndTypeValue = By.XPath("//div[@class='property_main_container']/div[1]/div[1]/div[2]/div[2]");
        By SearchIcon = By.XPath("//div[@class='property_main_container']/div/div/div/div/span[2]");
        By SearchInput = By.XPath("//span[@class='autocompleteContainer']/div/div/input");
        By SearchResult = By.XPath("//div[@class='property_main_container']/div/div/div/div/span/div/div/div/a/div");
        By DownloadExcel = By.XPath("//div[@class='property_main_container']/div/div/div/div/span[3]");
        By Category_StackingPlan = By.XPath("//div[@class='property_main_container']/div[1]/div[2]/div/button[1]");
        By Category_SitePlan = By.XPath("//div[@class='property_main_container']/div[1]/div[2]/div/button[2]");
        By Category_PropertyImages = By.XPath("//div[@class='property_main_container']/div[1]/div[2]/div/button[3]");
        By Category_OtherDocuments = By.XPath("//div[@class='property_main_container']/div[1]/div[2]/div/button[4]");

        //Stacking plan site plan views
        By stackingplanimage = By.XPath("//div[@id='wrapD3Cube']");
        By siteplanimage = By.XPath("//div[@class='upload-header']/div/label/span");

        //General Asset tables edit and manimize button
        By General_Edit = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div/div[3]/div[2]");
        By General_MinMax = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div/div[3]/div[3]");
        By Reversion_Edit = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div/div[3]/div[2]");
        By Reversion_MinMax = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div/div[3]/div[3]");
        By CurrentCost_Edit = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div/div[3]/div[2]");
        By CurrentCost_MinMax = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div/div[3]/div[3]");

        //General Asset fields one by one
        By Location = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div/div/div[1]/label[1]");
        By Fund = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[2]/div/div[1]/label[1]");
        By YearBuilt = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[3]/div/div[1]/label[1]");
        By Market = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[4]/div/div[1]/label[1]");
        By Submarket = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[5]/div/div[1]/label[1]");
        By ProductType = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[6]/div/div[1]/label[1]");
        By BuildingNRA = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[7]/div/div[1]/label[1]");
        By AcquisitionDate = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[8]/div/div[1]/label[1]");
        By YearRenovated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[9]/div/div[1]/label[1]");
        By MonthsOwned = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[10]/div/div[1]/label[1]");
        By CurrentLeased = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[11]/div/div[1]/label[1]");
        //Edited fields in general asset
        By YearBuiltInput = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[3]/div[2]/div/div/span/input");
        By SubmarketInput = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[5]/div[2]/div/div/span/input");
        By YearRenovatedInput = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[9]/div[2]/div/div/span/input");
        //Updated values
        By YearBuiltInput_Updated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[3]/div[2]/div/div/span");
        By SubmarketInput_updated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[5]/div[2]/div/div/span");
        By YearRenovatedInput_Updated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[9]/div[2]/div/div/span");
        By BuildingNRAUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[7]/div[2]/div/div/span");
        By AcquisitionDateUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[1]/div/div/div[2]/div[8]/div[2]/div/div/span");

        //Reversion Summary fields one by one
        By DispositionDate = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div/div[1]/label[1]");
        By DispositionMonth = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div[2]/div/div[1]/label[1]");
        By EstimatedPrice = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div[3]/div/div[1]/label[1]");
        By EstimatedPricePSF = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div[4]/div/div[1]/label[1]");
        By Residualcaprate = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div[5]/div/div[1]/label[1]");
        By DealIRR = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div[6]/div/div[1]/label[1]");
        By MultipleReturn = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div[7]/div/div[1]/label[1]");
        //Editable fields in reversion summary
        By DispositionDateInput = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/div/div/span/div/div/input");
        By EstimatedPriceInput = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div[3]/div[2]/div/div/span/input");
        By ResidualcaprateInput = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div[5]/div[2]/div/div/span/input");
        By DealIRRInput = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div[6]/div[2]/div/div/span/input");
        By MultipleReturnInput = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div[7]/div[2]/div/div/span/input");

        By DispoYear = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/div/div/span/div[2]/div/div/div/div[2]/div/div[2]/div[2]/select");
        By DispoExactDate = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/div/div/span/div[2]/div/div/div/div[2]/div[2]/div[3]/div[3]");
        //Editable fields in reversion summary
        By DispositionDateUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/div/div/span");
        By DispositionMonthUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div[2]/div[2]/div/div/span");
        By EstimatedPriceUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div[3]/div[2]/div/div/span");
        By EstimatedPricePSFUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div[4]/div[2]/div/div/span");
        By ResidualcaprateUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div[5]/div[2]/div/div/span");
        By DealIRRUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div[6]/div[2]/div/div/span");
        By MultipleReturnUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div[7]/div[2]/div/div/span");

        //Current Cost basis fields one by one
        By SubuHeader = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div/div/div[1]/label[1]");
        By PurchasePrice = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[2]/div/div[1]/label[1]");
        By AcquisitionloanCosts = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[3]/div/div[1]/label[1]");
        By PreviousAcquisition = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[4]/div/div[1]/label[1]");
        By RenovationCapital = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[5]/div/div[1]/label[1]");
        By LeasingCosts = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[6]/div/div[1]/label[1]");
        By Equipment = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[7]/div/div[1]/label[1]");
        By CarryCost = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[8]/div/div[1]/label[1]");
        By TotalCostBasis = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[9]/div/div[1]/label[1]");
        //Editable values

        By AlertText = By.XPath("//div[@class='mainContainer']/div/div/div/div/div/div[2]");

        //Current cost basis $/SF values
        By PurchasePriceNRA = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[2]/div[2]/div[2]/div/span");
        By AcquisitionloanCostsNRA = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[3]/div[2]/div[2]/div/span");
        By PreviousAcquisitionNRA = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[4]/div[2]/div[2]/div/span");
        By RenovationCapitalNRA = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[5]/div[2]/div[2]/div/span");
        By LeasingCostsNRA = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[6]/div[2]/div[2]/div/span");
        By EquipmentNRA = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[7]/div[2]/div[2]/div/span");
        By CarryCostNRA = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[8]/div[2]/div[2]/div/span");
        By TotalCostBasisNRA = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[9]/div[2]/div[2]/div/span");

        By PreviousAcquisitionInput = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[4]/div[2]/div/div/span/input");
        By CarryCostInput = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[8]/div[2]/div/div/span/input");
        By TotalCostBasisInput = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[9]/div[2]/div/div/span/input");
        //Updated fields
        By PurchasePriceUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[2]/div[2]/div/div/span");
        By AcquisitionloanCostsUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[3]/div[2]/div/div/span");
        By RenovationCapitalUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[5]/div[2]/div/div/span");
        By LeasingCostsUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[6]/div[2]/div/div/span");
        By EquipmentUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[7]/div[2]/div/div/span");
        By PreviousAcquisitionUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[4]/div[2]/div/div/span");
        By CarryCostUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[8]/div[2]/div/div/span");
        By TotalCostBasisUpdated = By.XPath("//div[@class='tab-container']/div[2]/div/div/div/div/div/div[3]/div/div/div[2]/div[9]/div[2]/div/div/span");

        //Locators to four tabs and tab titles
        By GeneralTab = By.XPath("//div[@class='property_main_container']/div[3]/div[1]/div/div/button[1]/div");
        By BasisDebtTab = By.XPath("//div[@class='property_main_container']/div[3]/div[1]/div/div/button[2]/div");
        By OperatingSumTab = By.XPath("//div[@class='property_main_container']/div[3]/div[1]/div/div/button[3]/div");
        By MapTab = By.XPath("//div[@class='property_main_container']/div[3]/div[1]/div/div/button[4]/div");

        //Industrial details locators
        By IndustrialEdit = By.XPath("//div[@class='tab-workspace']/div/div[2]/div/div[2]/div/div/div/div[3]/div[2]");
        By IndustrialMax = By.XPath("//div[@class='tab-workspace']/div/div[2]/div/div[2]/div/div/div/div[3]/div[3]");
        By ClearHeights = By.XPath("//div[@class='tab-workspace']/div/div[2]/div/div[2]/div/div/div[2]/div/div/div/label");
        By Dockdoors = By.XPath("//div[@class='tab-workspace']/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div/div/label");
        By TruckCourt = By.XPath("//div[@class='tab-workspace']/div/div[2]/div/div[2]/div/div/div[2]/div[3]/div/div/label");
        //edit industrial details
        By ClearHeightsInput = By.XPath("//div[@class='tab-workspace']/div/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div/span/input");
        By DockdoorsInput = By.XPath("//div[@class='tab-workspace']/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div[2]/div/div/span/input");
        By TruckCourtInput = By.XPath("//div[@class='tab-workspace']/div/div[2]/div/div[2]/div/div/div[2]/div[3]/div[2]/div/div/span/input");
        //UpdateDefinition industrial details
        By ClearHeightsUpdated = By.XPath("//div[@class='tab-workspace']/div/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div/span");
        By DockdoorsUpdated = By.XPath("//div[@class='tab-workspace']/div/div[2]/div/div[2]/div/div/div[2]/div[2]/div[2]/div/div/span");
        By TruckCourtUpdated = By.XPath("//div[@class='tab-workspace']/div/div[2]/div/div[2]/div/div/div[2]/div[3]/div[2]/div/div/span");

        //Core factor
        By CoreFactor = By.XPath("//div[@class='property_main_container']/div[3]/div[2]/div/div/div/div[2]/div/div[2]/div/div/div[2]/div/div/div/label");
        By InputCore = By.XPath("//div[@class='property_main_container']/div[3]/div[2]/div/div/div/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div/span/input");
        By UpdatedCore = By.XPath("//div[@class='property_main_container']/div[3]/div[2]/div/div/div/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div/span");

        //Stacking plan locators
        By floorLeftSide = By.XPath("//div[@id='left-side']/div/div/div/div");
        By floorDetails = By.XPath("//div[@id='myNav']/div/div/div");

        //Upload Images Locators
        By UploadImagesButton = By.XPath("//div[@class='fileUploadContainer']/div/div/label/span");
        By UploadImage = By.XPath("//input[@id='files']");
        By ImageLabel = By.XPath("//li[@class='slide selected']/div/p");


        //Property Images 
        By PropertyImageButton = By.XPath("//div[contains(text(),'Property Images')]");
        string fileName = @"C:\Users\GS-1638\Desktop\at.png";
        By UploadImageButton = By.XPath("//label[@class='select-button']");
        By Popup_KeepBoth_RadioButton = By.XPath("//label[contains(text(),'Keep Both')]");
        By popup_Replace_RadioButton = By.XPath("//label[contains(text(),'Replace')]");
        By Popup_UploadFiles = By.XPath("//div[contains(text(),'Upload Files')]");
        By Popup_Upload_Button = By.XPath("//button[contains(text(),'Upload')]");
        By SitePlanImageButton = By.XPath("//div[contains(text(),'Site Plan')]");
        By OtherDocsButton = By.XPath("//div[contains(text(),'Other Docs')]");
        By DeleteButton = By.XPath("//span[@class='img-delete']");
        By OkButton = By.XPath("//span[@class='MuiButton-label']");
        By ImageCount = By.XPath("//ul[@class='control-dots']/following::li");
        By NoPropertyImage = By.XPath("//*[contains(text(),'No ')]");
        By DeleteTextPopUp = By.XPath("//div[@id='customized-dialog-title']");
        By FileDeleted = By.XPath("//div[contains(text(),'File deleted successfully.')]");
        By ToastMessage = By.XPath("//div[@id='root']/div/div[1]/div/div/div[1]/div/div[2]");
        By NoSitePlanText = By.XPath("//*[contains(text(),'No site plan images uploaded.')]");
        By DeleteButtonOD = By.XPath("//*[@data-tip='Delete']");
        By DownlaodButton = By.XPath("//*[@data-tip='Download']");
        By AcquiDate = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[3]/div[2]/div/div/div/div[1]/div/div[1]/div/div/div[2]/div[8]/div[2]/div/div/span");
        By DispDate = By.XPath("//*[@id='root']/div/div[3]/div/div/div/div[2]/div/div[3]/div[2]/div/div/div/div[1]/div/div[2]/div/div/div[2]/div[1]/div[2]/div/div/span");

        //General Asset Summary 

        By EditSaveIcon_GAS = By.XPath("//label[text()='General Asset Summary']/parent::div/parent::div/parent::div/div[3]/div[2]");
        By YearBuilt_GAS = By.XPath("//label[text()='Location']/parent::div/parent::div/parent::div/parent::div/div[3]/div[2]/div/div/span/input");
        By Submarket_GAS = By.XPath("//label[text()='Location']/parent::div/parent::div/parent::div/parent::div/div[5]/div[2]/div/div/span/input");
        By YearRennovated_GAS = By.XPath("//label[text()='Location']/parent::div/parent::div/parent::div/parent::div/div[9]/div[2]/div/div/span/input");

        // Revision Summary 

        By EditSaveIcon_RS = By.XPath("//label[text()='Reversion Summary']/parent::div/parent::div/parent::div/div[3]/div[2]");
        By Dispo_Date_RS = By.XPath("//label[text()='Disposition Date']/parent::div/parent::div/parent::div/parent::div/div[1]/div[2]/div/div/span/div/div/input");
        By Est_Sales_Price_RS = By.XPath("//label[text()='Disposition Date']/parent::div/parent::div/parent::div/parent::div/div[3]/div[2]/div/div/span/input");
        By Residual_Cap_Rate_RS = By.XPath("//label[text()='Disposition Date']/parent::div/parent::div/parent::div/parent::div/div[5]/div[2]/div/div/span/input");
        By Deal_IRR_RS = By.XPath("//label[text()='Disposition Date']/parent::div/parent::div/parent::div/parent::div/div[6]/div[2]/div/div/span/input");
        By Return_Multiple_RS = By.XPath("//label[text()='Disposition Date']/parent::div/parent::div/parent::div/parent::div/div[7]/div[2]/div/div/span/input");

        //Total Current Cost Basis 
        By EditSaveIcon_CCB = By.XPath("//label[text()='Current Cost Basis']/parent::div/parent::div/parent::div/div[3]/div[2]");
        By PreAcqLoanCost_CCB = By.XPath("//label[text()='Purchase Price']/parent::div/parent::div/parent::div/parent::div/div[4]/div[2]/div[1]/div/span/input");
        By CarryCost_CCB = By.XPath("//label[text()='Purchase Price']/parent::div/parent::div/parent::div/parent::div/div[8]/div[2]/div[1]/div/span/input");


        public void Edt(By value)
        {
            Thread.Sleep(2000);
            driver.FindElement(value).Click();
            Thread.Sleep(2000);

        }

        public void clearField(By value)
        {
            Thread.Sleep(2000);
            driver.FindElement(value).Clear();
            Thread.Sleep(2000);

        }
        public string alrtText()
        {
            try
            {
                Thread.Sleep(2000);
                string alert = driver.FindElement(AlertText).Text;
                return alert;

            }
            catch (Exception e)
            {

                return "Values can not be updated as its alredy been empty";
                Console.WriteLine(e);
            }
        }
        public void clearDatePickerValue(By Value)
        {
            driver.FindElement(Value).Click();
            IWebElement element = driver.FindElement(Value);
            element.SendKeys(Keys.Control + "a");
            element.SendKeys(Keys.Backspace);
            element.SendKeys(Keys.Escape);

        }
        public bool GenralAssetSummaryWithNullData()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(EditSaveIcon_GAS));
            Edt(EditSaveIcon_GAS);
            clearField(YearBuilt_GAS);
            clearField(Submarket_GAS);
            clearField(YearRennovated_GAS);
            Edt(EditSaveIcon_GAS);
            string AlertMessage = alrtText();
            if (AlertMessage == "No changes made in data..." || AlertMessage == "Values can not be updated as its alredy been empty")
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool ReversionSummaryWithNullData()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(EditSaveIcon_RS));
            Edt(EditSaveIcon_RS);
            clearDatePickerValue(Dispo_Date_RS);
            clearField(Est_Sales_Price_RS);
            clearField(Residual_Cap_Rate_RS);
            clearField(Deal_IRR_RS);
            clearField(Return_Multiple_RS);
            Edt(EditSaveIcon_RS);
            string AlertMessage = alrtText();
            if (AlertMessage == "No changes made in data..." || AlertMessage == "Values can not be updated as its alredy been empty")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TotalCurrentCostBasisWithNullData()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(EditSaveIcon_CCB));
            Edt(EditSaveIcon_CCB);
            clearField(PreAcqLoanCost_CCB);
            clearField(CarryCost_CCB);
            Edt(EditSaveIcon_CCB);
            string AlertMessage = alrtText();
            if (AlertMessage == "No changes made in data..." || AlertMessage == "Values can not be updated as its alredy been empty")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClickOnOtherDocs()
        {
            Thread.Sleep(9000);
            driver.FindElement(OtherDocsButton).Click();
            Thread.Sleep(3000);
        }
        public void ClickOnSitePlanImage()
        {
            Thread.Sleep(5000);
            driver.FindElement(SitePlanImageButton).Click();
            Thread.Sleep(3000);
        }

        public bool downloadImages()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            string Text = ImageIPresetToDelete();
            if (Text == "Image is there")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DownlaodButton));
                driver.FindElement(DownlaodButton).Click();
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DownlaodButton));

                return true;
            }
            else
            {

                return false;
            }


        }
        public bool UploadAllTypeOfFilesInSiteDoc()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));

            int BeforeUploadCount = ImageTotalCount();
            IWebElement fileUpload = driver.FindElement(UploadImageButton);

            // For Sophos

            AutoItX3 autoIt = new AutoItX3();

            string fileLocation = @"C:\Users\GS-1638\Desktop\Testing"; // Folder should have all type of file image/doc/pdf

            string[] filePath = Directory.GetFiles(fileLocation, "*", SearchOption.AllDirectories);
            foreach (string element in filePath)

            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(fileUpload));
                Thread.Sleep(9000);
                fileUpload.Click();
                Thread.Sleep(8000);
                Console.WriteLine(element);
                autoIt.WinActivate("Open");
                autoIt.Send(element);
                Thread.Sleep(3000);
                autoIt.Send("{Enter}");
                Thread.Sleep(8000);
                bool value = IsElementPresent();

                if (value == true)
                {

                    driver.FindElement(Popup_KeepBoth_RadioButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(Popup_Upload_Button).Click();

                    try
                    {
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(UploadImageButton));
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.StackTrace);
                    }
                }
                else
                {
                    try
                    {
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(UploadImageButton));
                        Console.WriteLine("Uploaded file");
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.StackTrace);
                    }
                }
            }
            int AfterUploadCount = ImageTotalCount();
            if (AfterUploadCount > BeforeUploadCount)
            {

                return true;
            }

            else
            {

                return false;
            }
        }

        public int ImageTotalCount()
        {
            try
            {
                int count = driver.FindElements(DeleteButtonOD).Count;
                return count;
            }
            catch (Exception e)
            {
                int count = 0;
                return count;
            }

        }
        public bool DeleteOtherDoc()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            string Text = ImageIPresetToDelete();
            if (Text == "Image is there")
            {
                int FilesBeforeDelete = driver.FindElements(DeleteButtonOD).Count;
                Console.WriteLine(FilesBeforeDelete);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DeleteButtonOD));
                driver.FindElement(DeleteButtonOD).Click();
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DeleteTextPopUp));
                driver.FindElement(OkButton).Click();
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DeleteTextPopUp));


                int DCAfterDelete = FilesCountAfterDelete();
                Console.WriteLine(DCAfterDelete);

                if (FilesBeforeDelete != DCAfterDelete)
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
                return false;
            }

        }

        public string ImageIPresetToDelete()
        {
            try
            {
                driver.FindElement(NoPropertyImage);
                return "No images is there";
            }
            catch (Exception e)
            {
                return "Image is there";
            }

        }
        public bool DeleteSiteImage()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            string Text = ImageIPresetToDelete();
            if (Text == "Image is there")
            {
                int ICBeforeDelete = driver.FindElements(ImageCount).Count;
                Console.WriteLine(ICBeforeDelete);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DeleteButton));
                driver.FindElement(DeleteButton).Click();
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DeleteTextPopUp));
                driver.FindElement(OkButton).Click();
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DeleteTextPopUp));


                int ICAfterDelete = ImageCountAfterDelete();
                Console.WriteLine(ICAfterDelete);

                if (ICBeforeDelete != ICAfterDelete)
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
                return false;
            }

        }

        public bool UploadSitePlanImages()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));

            IWebElement fileUpload = driver.FindElement(UploadImageButton);
            // For Sophos

            AutoItX3 autoIt = new AutoItX3();

            string fileLocation = @"C:\Users\GS-1638\Desktop\ImageFile"; // To get the all the images 

            string[] filePath = Directory.GetFiles(fileLocation, "*", SearchOption.AllDirectories);
            foreach (string element in filePath)

            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(fileUpload));
                Thread.Sleep(9000);
                fileUpload.Click();
                Thread.Sleep(8000);
                Console.WriteLine(element);
                autoIt.WinActivate("Open");
                autoIt.Send(element);
                Thread.Sleep(3000);
                autoIt.Send("{Enter}");
                Thread.Sleep(8000);

                bool value = IsElementPresent();

                if (value == true)
                {

                    driver.FindElement(Popup_KeepBoth_RadioButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(Popup_Upload_Button).Click();

                    try
                    {
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(UploadImageButton));
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.StackTrace);
                    }
                }
                else
                {
                    try
                    {
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(UploadImageButton));
                        Console.WriteLine("Uploaded file");
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.StackTrace);
                    }
                }
            }
            By ToastMessage = By.XPath("//div[@id='root']/div/div[1]/div/div/div[1]/div/div[2]");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(ToastMessage));
            String Message = driver.FindElement(ToastMessage).Text;
            Console.WriteLine(Message);
            if (Message == "File uploaded successfully.")
            {

                return true;
            }

            else
            {

                return false;
            }
        }


        public bool UploadImageAndReplaceinOtherDoc()
        {

            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));

            IWebElement fileUpload = driver.FindElement(UploadImageButton);

            // For Sophos

            AutoItX3 autoIt = new AutoItX3();


            string fileLocation = @"C:\Users\GS-1638\Desktop\Testing"; // Add folder where all type of file is available(supported) 

            string[] filePath = Directory.GetFiles(fileLocation, "*", SearchOption.AllDirectories);
            foreach (string element in filePath)

            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(fileUpload));
                Thread.Sleep(9000);
                fileUpload.Click();
                Thread.Sleep(8000);
                Console.WriteLine(element);
                autoIt.WinActivate("Open");
                autoIt.Send(element);
                Thread.Sleep(3000);
                autoIt.Send("{Enter}");
                Thread.Sleep(8000);

                bool value = IsElementPresent();

                if (value == true)
                {



                    driver.FindElement(popup_Replace_RadioButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(Popup_Upload_Button).Click();

                    try
                    {
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(UploadImageButton));
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.StackTrace);
                    }
                }
                else
                {
                    try
                    {
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(UploadImageButton));
                        Console.WriteLine("Uploaded file");
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.StackTrace);
                    }
                }

            }

            String Message = driver.FindElement(ToastMessage).Text;
            if (Message == "File uploaded successfully.")
            {

                return true;
            }

            else
            {

                return false;
            }


        }

        public bool UploadImageAndReplace()
        {

            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));

            IWebElement fileUpload = driver.FindElement(UploadImageButton);

            // For Sophos

            AutoItX3 autoIt = new AutoItX3();

            //  string[] filePath = { @"C:\Users\GS-1638\Desktop\Testing\dummypdf.pdf", @"C:\Users\GS-1638\Desktop\Testing\Test1.png", @"C:\Users\GS-1638\Desktop\Testing\test2.png" };

            string fileLocation = @"C:\Users\GS-1638\Desktop\Testing";

            string[] filePath = Directory.GetFiles(fileLocation, "*", SearchOption.AllDirectories);
            foreach (string element in filePath)

            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(fileUpload));
                Thread.Sleep(9000);
                fileUpload.Click();
                Thread.Sleep(8000);
                Console.WriteLine(element);
                autoIt.WinActivate("Open");
                autoIt.Send(element);
                Thread.Sleep(3000);
                autoIt.Send("{Enter}");
                Thread.Sleep(8000);

                bool value = IsElementPresent();

                if (value == true)
                {



                    driver.FindElement(popup_Replace_RadioButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(Popup_Upload_Button).Click();

                    try
                    {
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(UploadImageButton));
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.StackTrace);
                    }
                }
                else
                {
                    try
                    {
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(UploadImageButton));
                        Console.WriteLine("Uploaded file");
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.StackTrace);
                    }
                }

            }

            String Message = driver.FindElement(ToastMessage).Text;
            if (Message == "File uploaded successfully.")
            {

                return true;
            }

            else
            {

                return false;
            }


        }
        public bool IsElementPresent()
        {
            try
            {
                driver.FindElement(Popup_UploadFiles);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool UploadPropertyImages()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));

            IWebElement fileUpload = driver.FindElement(UploadImageButton);

            // For Sophos

            AutoItX3 autoIt = new AutoItX3();

            string fileLocation = @"C:\Users\GS-1638\Desktop\ImageFile"; // To get the all the images 

            string[] filePath = Directory.GetFiles(fileLocation, "*", SearchOption.AllDirectories);
            foreach (string element in filePath)

            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(fileUpload));
                Thread.Sleep(9000);
                fileUpload.Click();
                Thread.Sleep(8000);
                Console.WriteLine(element);
                autoIt.WinActivate("Open");
                autoIt.Send(element);
                Thread.Sleep(3000);
                autoIt.Send("{Enter}");
                Thread.Sleep(8000);
                bool value = IsElementPresent();

                if (value == true)
                {
                    driver.FindElement(Popup_KeepBoth_RadioButton).Click();
                    Thread.Sleep(2000);
                    driver.FindElement(Popup_Upload_Button).Click();

                    try
                    {
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(UploadImageButton));
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.StackTrace);
                    }
                }
                else
                {
                    try
                    {
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(UploadImageButton));
                        Console.WriteLine("Uploaded file");
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.StackTrace);
                    }
                }
            }
            String Message = driver.FindElement(ToastMessage).Text;
            if (Message == "File uploaded successfully.")
            {

                return true;
            }

            else
            {

                return false;
            }
        }

        public bool DeletePropertyImage()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
            string Text = ImageIPresetToDelete();
            if (Text == "Image is there")
            {
                int ICBeforeDelete = driver.FindElements(ImageCount).Count;
                Console.WriteLine(ICBeforeDelete);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DeleteButton));
                driver.FindElement(DeleteButton).Click();
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DeleteTextPopUp));
                driver.FindElement(OkButton).Click();
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(DeleteTextPopUp));


                int ICAfterDelete = ImageCountAfterDelete();
                Console.WriteLine(ICAfterDelete);

                if (ICBeforeDelete != ICAfterDelete)
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
                return false;
            }

        }

        public int ImageCountAfterDelete()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(FileDeleted));


            string Successtext = driver.FindElement(FileDeleted).Text;
            Console.WriteLine(Successtext);
            if (Successtext == "File deleted successfully.")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(ImageCount));
                int count = driver.FindElements(ImageCount).Count();
                return count;

            }
            else
            {
                int count = 0;
                return count;
            }

        }
        public int FilesCountAfterDelete()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(FileDeleted));


            string Successtext = driver.FindElement(FileDeleted).Text;
            Console.WriteLine(Successtext);
            if (Successtext == "File deleted successfully.")
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(DeleteButtonOD));
                int count = driver.FindElements(DeleteButtonOD).Count();
                return count;

            }
            else
            {
                int count = 0;
                return count;
            }

        }


        public void ClickOnPropertyImage()
        {
            Thread.Sleep(9000);
            driver.FindElement(PropertyImageButton).Click();
            Thread.Sleep(3000);
        }
        public bool CompareDisAndAcqDate()
        {
            string DD = driver.FindElement(AcquiDate).Text;
            Console.WriteLine(DD);

            string[] valDateArr = DD.Split('/');
            DD = valDateArr[1] + "/" + valDateArr[0] + "/" + valDateArr[2];

            DateTime DisposionDate = DateTime.Parse(DD);
            Console.WriteLine(DisposionDate);


            Thread.Sleep(2000);
            String AD = driver.FindElement(DispDate).Text;
            DateTime AcquisionDate = DateTime.Parse(AD);
            Console.WriteLine(AcquisionDate);

            if (AcquisionDate > DisposionDate)
            {
                return true;
            }

            else
            {
                return false;

            }


        }

        public void selectPropertyWithIndustrialTypeForImageUpload()
        {
            By SearchIcon = By.XPath("//input[@placeholder='Type to search...']");

            Thread.Sleep(5000);
            driver.FindElement(SearchIcon).Click();
            String propertyName = "North River";
            driver.FindElement(SearchIcon).SendKeys(propertyName);
            //  driver.FindElement(SearchResult).Click();
            // Thread.Sleep(9000);
        }
        public String ReturnProductType()
        {
            String Producttype = driver.FindElement(MarketAndTypeValue).Text;
            String[] AllTypes = Producttype.Split(':');
            String type = AllTypes[2];
            return type;
        }
        public Boolean StackingPlanIsDisplayed()
        {
            Boolean stacking = driver.FindElement(Category_StackingPlan).Enabled;
            return stacking;
        }
        public Boolean sitePlanIsDisplayed()
        {
            Boolean site = driver.FindElement(Category_SitePlan).Enabled;
            return site;
        }
        public void SelectPropertyOtherThanOfficeType()
        {
            String prop = ReturnProductType();
            if (prop == " Office")
            {
                selectPropertyWithIndustrialType();
            }
        }
        public void selectPropertyWithOfficeType()
        {
            driver.FindElement(SearchIcon).Click();
            String propertyName = "Centerra";
            driver.FindElement(SearchInput).SendKeys(propertyName);
            driver.FindElement(SearchResult).Click();
        }
        public void selectPropertyWithIndustrialType()
        {
            driver.FindElement(SearchIcon).Click();
            String propertyName = "905 Howard";
            driver.FindElement(SearchInput).SendKeys(propertyName);
            driver.FindElement(SearchResult).Click();
        }
        public void selectPropertyRiverSouth()
        {
            driver.FindElement(SearchIcon).Click();
            String propertyName = "River South";
            driver.FindElement(SearchInput).SendKeys(propertyName);
            driver.FindElement(SearchResult).Click();
        }
        public void selectPropertyQuorum()
        {
            driver.FindElement(SearchIcon).Click();
            String propertyName = "Quorum";
            driver.FindElement(SearchInput).SendKeys(propertyName);
            driver.FindElement(SearchResult).Click();
        }
        public void selectPropertyWithRetailType()
        {
            driver.FindElement(SearchIcon).Click();
            driver.FindElement(SearchInput).SendKeys("Lake Jackson");
            driver.FindElement(SearchResult).Click();
        }
        public void selectPropertyWithMixedUse()
        {
            driver.FindElement(SearchIcon).Click();
            driver.FindElement(SearchInput).SendKeys("Quorum");
            driver.FindElement(SearchResult).Click();
        }
        public Boolean ShowCoreFactor()
        {
            Boolean res = driver.FindElement(CoreFactor).Displayed;
            return res;
        }
        public Boolean ShowIndustrial()
        {
            Boolean res = driver.FindElement(ClearHeights).Displayed;
            return res;
        }
        public void DownloadAssetSummaryReport()
        {
            driver.FindElement(DownloadExcel).Click();
        }
        public Boolean MaximizeMiniMize()
        {
            driver.FindElement(General_MinMax).Click();
            Thread.Sleep(2000);
            driver.FindElement(General_MinMax).Click();
            driver.FindElement(Reversion_MinMax).Click();
            Thread.Sleep(1000);
            driver.FindElement(Reversion_MinMax).Click();
            driver.FindElement(CurrentCost_MinMax).Click();
            Thread.Sleep(1000);
            driver.FindElement(CurrentCost_MinMax).Click();
            Boolean res = driver.FindElement(PurchasePrice).Displayed;
            return res;
        }
        public String GeneralAsset_LocationField()
        {
            String location = driver.FindElement(Location).Text;
            return location;
        }
        public String GeneralAsset_FundField()
        {
            String fund = driver.FindElement(Fund).Text;
            return fund;
        }
        public String GeneralAsset_MarketField()
        {
            String market = driver.FindElement(Market).Text;
            return market;
        }
        public String GeneralAsset_SubmarketField()
        {
            String submarket = driver.FindElement(Submarket).Text;
            return submarket;
        }
        public String GeneralAsset_YearBuiltField()
        {
            String yearbuilt = driver.FindElement(YearBuilt).Text;
            return yearbuilt;
        }
        public String GeneralAsset_ProductTypeField()
        {
            String productype = driver.FindElement(ProductType).Text;
            return productype;
        }
        public String GeneralAsset_BuildingNRAField()
        {
            String buildingNRA = driver.FindElement(BuildingNRA).Text;
            return buildingNRA;
        }
        public String GeneralAsset_AcquisitionDateField()
        {
            String acquisitionDate = driver.FindElement(AcquisitionDate).Text;
            return acquisitionDate;
        }
        public String GeneralAsset_YearRenovatedField()
        {
            String yearRenovated = driver.FindElement(YearRenovated).Text;
            return yearRenovated;
        }
        public String GeneralAsset_MonthsOwnedField()
        {
            String monthsOwned = driver.FindElement(MonthsOwned).Text;
            return monthsOwned;
        }
        public String GeneralAsset_CurrentLeasedField()
        {
            String currentLeased = driver.FindElement(CurrentLeased).Text;
            return currentLeased;
        }
        public String ReverSionSummary_DispositionDate()
        {
            String dispositionDate = driver.FindElement(DispositionDate).Text;
            return dispositionDate;
        }
        public String ReverSionSummary_DispositionMonth()
        {
            String dispositionMonth = driver.FindElement(DispositionMonth).Text;
            return dispositionMonth;
        }
        public String ReverSionSummary_EstimatedSalesPrice()
        {
            String estimatedSales = driver.FindElement(EstimatedPrice).Text;
            return estimatedSales;
        }
        public String ReverSionSummary_EstimatedPricePSF()
        {
            String estimatedPSF = driver.FindElement(EstimatedPricePSF).Text;
            return estimatedPSF;
        }
        public String ReverSionSummary_ResidualcapRate()
        {
            String residualCapRate = driver.FindElement(Residualcaprate).Text;
            return residualCapRate;
        }
        public String ReverSionSummary_DealIRR()
        {
            String dealIRR = driver.FindElement(DealIRR).Text;
            return dealIRR;
        }
        public String ReverSionSummary_ReturnMultiple()
        {
            String returnMultiple = driver.FindElement(MultipleReturn).Text;
            return returnMultiple;
        }
        public String CurrentCostbasis_PurchasePrice()
        {
            String purchasePrice = driver.FindElement(PurchasePrice).Text;
            return purchasePrice;
        }
        public String CurrentCostbasis_AcquisitionLoanCosts()
        {
            String acquisitionLoan = driver.FindElement(AcquisitionloanCosts).Text;
            return acquisitionLoan;
        }
        public String CurrentCostbasis_PreviousAcqLoanCost()
        {
            String previousAcquisition = driver.FindElement(PreviousAcquisition).Text;
            return previousAcquisition;
        }
        public String CurrentCostbasis_RenovationCapitalCosts()
        {
            String renovation = driver.FindElement(RenovationCapital).Text;
            return renovation;
        }
        public String CurrentCostbasis_LeasingCostsImprovements()
        {
            String leasingCost = driver.FindElement(LeasingCosts).Text;
            return leasingCost;
        }
        public String CurrentCostbasis_Equipment()
        {
            String equipment = driver.FindElement(Equipment).Text;
            return equipment;
        }
        public String CurrentCostbasis_CarryCost()
        {
            String carryCost = driver.FindElement(CarryCost).Text;
            return carryCost;
        }
        public String CurrentCostbasis_TotalCurrentCostBasis()
        {
            String totalCurrentCost = driver.FindElement(TotalCostBasis).Text;
            return totalCurrentCost;
        }
        public Boolean UpdateGeneralAssetDetails_YearBuilt()
        {
            String existingYear = driver.FindElement(YearBuiltInput_Updated).Text;
            driver.FindElement(General_Edit).Click();
            driver.FindElement(YearBuiltInput).Clear();
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(11, 99);
            String year = "19" + randomInt;
            driver.FindElement(YearBuiltInput).SendKeys(year);
            driver.FindElement(General_Edit).Click();
            String updatedYear = driver.FindElement(YearBuiltInput_Updated).Text;
            if (existingYear != updatedYear)
            {
                return true;
            }
            else
                return false;
        }
        public Boolean UpdateGeneralAssetDetails_SubMarket()
        {
            String existing = driver.FindElement(SubmarketInput_updated).Text;
            driver.FindElement(General_Edit).Click();
            driver.FindElement(SubmarketInput).Clear();
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1, 999);
            String name = "Test" + randomInt;
            driver.FindElement(SubmarketInput).SendKeys(name);
            driver.FindElement(General_Edit).Click();
            String updated = driver.FindElement(SubmarketInput_updated).Text;
            if (existing != updated)
            {
                return true;
            }
            else
                return false;
        }
        public Boolean UpdateGeneralAssetDetails_YearRenovated()
        {
            String existing = driver.FindElement(YearRenovatedInput_Updated).Text;
            driver.FindElement(General_Edit).Click();
            driver.FindElement(YearRenovatedInput).Clear();
            int randomInt = randomGenerator.Next(00, 20);
            String year = "20" + randomInt;
            driver.FindElement(YearRenovatedInput).SendKeys(year);
            driver.FindElement(General_Edit).Click();
            String updated = driver.FindElement(YearRenovatedInput_Updated).Text;
            if (existing != updated)
            {
                return true;
            }
            else
                return false;
        }
        Random randomGenerator = new Random();
        public Boolean UpdateReversionSummary_Dispositiondate()
        {
            String existing = driver.FindElement(DispositionDateUpdated).Text;
            driver.FindElement(Reversion_Edit).Click();
            driver.FindElement(DispositionDateInput).Click();
            driver.FindElement(DispositionDateInput).Clear();
            SelectElement dispo = new SelectElement(driver.FindElement(DispoYear));
            dispo.SelectByValue("2021");
            driver.FindElement(DispoExactDate).Click();
            driver.FindElement(Reversion_Edit).Click();
            String updated = driver.FindElement(DispositionDateUpdated).Text;
            if (existing != updated)
            {
                return true;
            }
            else
                return false;
        }
        public Boolean UpdateReversionSummary_EstimatedSalesPrice()
        {
            String existing = driver.FindElement(EstimatedPriceUpdated).Text;
            driver.FindElement(Reversion_Edit).Click();
            driver.FindElement(EstimatedPriceInput).Clear();
            int randomInt = randomGenerator.Next(100000, 100000000);
            String salesprice = "2" + randomInt;
            driver.FindElement(EstimatedPriceInput).SendKeys(salesprice);
            driver.FindElement(Reversion_Edit).Click();
            String updated = driver.FindElement(EstimatedPriceUpdated).Text;
            if (existing != updated)
            {
                return true;
            }
            else
                return false;
        }
        public int GeneralAssetSummary_ReturnBUildingNRaValue()
        {
            String nra = driver.FindElement(BuildingNRAUpdated).Text;
            if (nra == "-")
            { return 0; }
            String NRaWithoutComma = nra.Replace(",", String.Empty);
            int Buildingnra = int.Parse(NRaWithoutComma);
            return Buildingnra;
        }
        public Boolean ReversionSummary_EstimatedSalesPricePSF_calculation()
        {
            String existing = driver.FindElement(EstimatedPriceUpdated).Text;
            if (existing == "-")
            {
                UpdateReversionSummary_EstimatedSalesPrice();
            }
            String estimated = driver.FindElement(EstimatedPriceUpdated).Text;
            String removeDolar = estimated.Replace('$', ' ');
            String removecomma = removeDolar.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int estimatedValue = int.Parse(removeSpace);
            String nra = driver.FindElement(BuildingNRAUpdated).Text;
            String NRaWithoutComma = nra.Replace(',', ' ');
            String BNRA = NRaWithoutComma.Replace(" ", String.Empty);
            int Buildingnra = int.Parse(BNRA);
            double calculatedValue = estimatedValue / Buildingnra;
            String CalculateFinal = calculatedValue.ToString();
            String updatedSalesPSF = driver.FindElement(EstimatedPricePSFUpdated).Text;
            //int salesPricePSF = int.Parse(updatedSalesPSF);
            if (CalculateFinal == updatedSalesPSF)
            {
                return true;
            }
            return false;
        }
        public Boolean UpdateReversionSummary_ResidualCapRate()
        {
            String existing = driver.FindElement(ResidualcaprateUpdated).Text;
            int randomInt = randomGenerator.Next(0, 20);
            String capRate = "" + randomInt;
            driver.FindElement(Reversion_Edit).Click();
            driver.FindElement(ResidualcaprateInput).Clear();
            driver.FindElement(ResidualcaprateInput).SendKeys(capRate);
            driver.FindElement(Reversion_Edit).Click();
            String updated = driver.FindElement(ResidualcaprateUpdated).Text;
            if (existing != updated)
            {
                return true;
            }
            else
                return false;
        }
        public Boolean UpdateReversionSummary_MultipleReturn()
        {
            String existing = driver.FindElement(MultipleReturnUpdated).Text;
            driver.FindElement(Reversion_Edit).Click();
            int randomInt = randomGenerator.Next(0, 20);
            String multiple = "" + randomInt;
            driver.FindElement(MultipleReturnInput).Clear();
            driver.FindElement(MultipleReturnInput).SendKeys(multiple);
            driver.FindElement(Reversion_Edit).Click();
            String updated = driver.FindElement(MultipleReturnUpdated).Text;
            if (existing != updated)
            {
                return true;
            }
            else
                return false;
        }
        public Boolean UpdateReversionSummary_DealIRR()
        {
            String existing = driver.FindElement(DealIRRUpdated).Text;
            int randomInt = randomGenerator.Next(0, 20);
            String dealIrr = "" + randomInt;
            driver.FindElement(Reversion_Edit).Click();
            driver.FindElement(DealIRRInput).Clear();
            driver.FindElement(DealIRRInput).SendKeys(dealIrr);
            driver.FindElement(Reversion_Edit).Click();
            String updated = driver.FindElement(DealIRRUpdated).Text;
            if (existing != updated)
            {
                return true;
            }
            else
                return false;
        }
        public int ReversionSummary_CalculateDispositionMonth()
        {
            String acquDate = driver.FindElement(AcquisitionDateUpdated).Text;
            DateTime acquisitionDate = DateTime.Parse(acquDate);
            String dispDate = driver.FindElement(DispositionDateUpdated).Text;
            DateTime dispositionDate = DateTime.Parse(dispDate);
            return (dispositionDate.Month - acquisitionDate.Month) + 12 * (dispositionDate.Year - acquisitionDate.Year);
        }
        public int ReversionSummary_ReadDispositionMonthValue()
        {
            String dispositionMonth = driver.FindElement(DispositionMonthUpdated).Text;
            String[] stringMonth = dispositionMonth.Split(' ');
            String MonthValue = stringMonth[1];
            int value = int.Parse(MonthValue);
            return value;
        }
        public Boolean CurrentCostBasis_UpdatePreviousAcquisition()
        {
            String currentPreviousAcq = driver.FindElement(PreviousAcquisitionUpdated).Text;
            driver.FindElement(CurrentCost_Edit).Click();
            int randomInt = randomGenerator.Next(100000, 100000000);
            String randomValue = "2" + randomInt;
            driver.FindElement(PreviousAcquisitionInput).Clear();
            driver.FindElement(PreviousAcquisitionInput).SendKeys(randomValue);
            driver.FindElement(CurrentCost_Edit).Click();
            String updatedPreviousAcq = driver.FindElement(PreviousAcquisitionUpdated).Text;
            if (currentPreviousAcq != updatedPreviousAcq)
            {
                return true;
            }
            else
                return false;
        }
        public Boolean CurrentCostBasis_UpdateCarryCost()
        {
            String currentCarryCost = driver.FindElement(CarryCostUpdated).Text;
            driver.FindElement(CurrentCost_Edit).Click();
            int randomInt = randomGenerator.Next(100000, 100000000);
            String randomValue = "2" + randomInt;
            driver.FindElement(CarryCostInput).Clear();
            driver.FindElement(CarryCostInput).SendKeys(randomValue);
            driver.FindElement(CurrentCost_Edit).Click();
            String updatedCarryCost = driver.FindElement(CarryCostUpdated).Text;
            if (currentCarryCost != updatedCarryCost)
            {
                return true;
            }
            else
                return false;
        }
        public int CurrentCostBasis_ReturnPurchasePriceCal()
        {
            String currentValue = driver.FindElement(PurchasePriceUpdated).Text;
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
            String currentValue = driver.FindElement(AcquisitionloanCostsUpdated).Text;
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
            String currentValue = driver.FindElement(PreviousAcquisitionUpdated).Text;
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
            String currentValue = driver.FindElement(RenovationCapitalUpdated).Text;
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
            String currentValue = driver.FindElement(LeasingCostsUpdated).Text;
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
            String currentValue = driver.FindElement(EquipmentUpdated).Text;
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
            String currentValue = driver.FindElement(CarryCostUpdated).Text;
            if (currentValue == "-")
            {
                return 0;
            }
            String removecomma = currentValue.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public int CurrentCostBasis_CalculateTotalCurrentCostBasisValue()
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
        public int CurrentCostBasis_ReadTotalCurrentCostBasisValue()
        {
            String currentTotal = driver.FindElement(TotalCostBasisUpdated).Text;
            String removecomma = currentTotal.Replace(',', ' ');
            String removeSpace = removecomma.Replace(" ", String.Empty);
            int totalActual = int.Parse(removeSpace);
            return totalActual;
        }
        public Boolean UpdateIndustrialDetails()
        {
            driver.FindElement(IndustrialEdit).Click();
            driver.FindElement(ClearHeightsInput).Clear();
            driver.FindElement(ClearHeightsInput).SendKeys("1");
            driver.FindElement(DockdoorsInput).Clear();
            driver.FindElement(DockdoorsInput).SendKeys("2");
            driver.FindElement(TruckCourtInput).Clear();
            driver.FindElement(TruckCourtInput).SendKeys("3");
            driver.FindElement(IndustrialEdit).Click();
            String clearheight = driver.FindElement(ClearHeightsUpdated).Text;
            String dockdoors = driver.FindElement(DockdoorsUpdated).Text;
            String truckCourt = driver.FindElement(TruckCourtUpdated).Text;
            if (clearheight == "1" && dockdoors == "2" && truckCourt == "3")
            {
                return true;
            }
            else return false;
        }
        public Boolean UpdateCorefactorValue()
        {
            driver.FindElement(IndustrialEdit).Click();
            driver.FindElement(InputCore).Clear();
            driver.FindElement(InputCore).SendKeys("1");
            driver.FindElement(IndustrialEdit).Click();
            String core = driver.FindElement(UpdatedCore).Text;
            if (core == "1.00%")
            {
                return true;
            }
            else return false;
        }
        //WebElement addFile = driver.findElement(By.xpath(".//input[@type='file']"));
        //addFile.sendKeys("/Users/neeraj.kumar/Desktop/c1.jpeg");
        public Boolean UploadImagesInSitePlan()
        {
            IWebElement addFile = driver.FindElement(UploadImage);
            addFile.SendKeys(@"C:\Users\shilpa.shinde\source\repos\LatestAutomationCode\InvestmentManagement\Test\FilesToUpload\AundhImage.jpeg");
            //C:\Users\shilpa.shinde\source\repos\LatestAutomationCode\InvestmentManagement\Test\FilesToUpload
            String filename = driver.FindElement(ImageLabel).Text;
            if (filename == "AundhImage.jpeg")
            {
                return true;
            }
            return false;
        }
        public Boolean VerifyButtonLabelsWithRespecToImageCategory()
        {
            driver.FindElement(Category_SitePlan).Click();
            String UploadSiteLabel = driver.FindElement(UploadImagesButton).Text;
            driver.FindElement(Category_PropertyImages).Click();
            String UploadPropLabel = driver.FindElement(UploadImagesButton).Text;
            driver.FindElement(Category_OtherDocuments).Click();
            String UploadOtherDocsLabel = driver.FindElement(UploadImagesButton).Text;
            if (UploadSiteLabel == "Upload Site Plan" && UploadPropLabel == "Upload Images" && UploadOtherDocsLabel == "Upload Documents")
            {
                return true;
            }
            else return false;
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
        public String VerifyAlertText()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(AlertText));
            var elementToClick = driver.FindElement(AlertText);
            String alertMessage = elementToClick.Text;
            return alertMessage;
        }
        public String GeneralAssetSummary_VerifyErrorNoChangesmade()
        {
            driver.FindElement(General_Edit).Click();
            driver.FindElement(General_Edit).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(AlertText));
            String alertMessage = driver.FindElement(AlertText).Text;
            return alertMessage;
        }
        public String ReversionSummary_VerifyErrorNoChangesmade()
        {
            driver.FindElement(Reversion_Edit).Click();
            driver.FindElement(Reversion_Edit).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(AlertText));
            String alertMessage = driver.FindElement(AlertText).Text;
            return alertMessage;
        }
        public String CurrentCostBasis_VerifyErrorNoChangesmade()
        {
            driver.FindElement(CurrentCost_Edit).Click();
            driver.FindElement(CurrentCost_Edit).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(AlertText));
            String alertMessage = driver.FindElement(AlertText).Text;
            return alertMessage;
        }
        public String GeneralAssetSummary_VerifyYearBuiltErrorEnterCorrectYear()
        {
            driver.FindElement(General_Edit).Click();
            driver.FindElement(YearBuiltInput).SendKeys("2736");
            driver.FindElement(General_Edit).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(AlertText));
            String alertMessage = driver.FindElement(AlertText).Text;
            return alertMessage;
        }
        public String GeneralAssetSummary_VerifyYearRenovatedErrorEnterCorrectYear()
        {
            driver.FindElement(General_Edit).Click();
            driver.FindElement(YearRenovated).SendKeys("8765");
            driver.FindElement(General_Edit).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(AlertText));
            String alertMessage = driver.FindElement(AlertText).Text;
            return alertMessage;
        }
        public String IndustrialDetails_VerifyErrorNoChangesmade()
        {
            driver.FindElement(IndustrialEdit).Click();
            driver.FindElement(IndustrialEdit).Click();
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(AlertText));
            String alertMessage = driver.FindElement(AlertText).Text;
            return alertMessage;
        }
        public Boolean StackingPlan_FloorDetailsAreDisplayed()
        {
            String leftfloor = driver.FindElement(floorLeftSide).Text;
            driver.FindElement(floorLeftSide).Click();
            String Detailfloor = driver.FindElement(floorDetails).Text;
            if (leftfloor == Detailfloor)
            {
                return true;
            }
            return false;
        }

    }
}
