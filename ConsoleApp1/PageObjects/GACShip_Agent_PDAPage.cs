using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MainTest;
//using UserActions;
//using ExcelUtilities;
//using Assertion;
//using ReportingUtility;
using NUnit.Framework;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;

namespace GACShip
{
    class GACShipPDAPage
    {

        //Constructor to initialize the elements in this page.
        //ctor double tab will bring constructor

        public GACShipPDAPage()
        {
            PageFactory.InitElements(PropertyCollection.Driver, this);
        }

//******PDA_PAGE_MAIN_HEADER************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//h3[contains(.,'PDA')]//following-sibling::job-summary//span[contains(.,'Acknowledged by PA')]")]
        public IWebElement PDAPageHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@ng-show='!vm.isLoading']/span")]
        public IWebElement PDAPageJobNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn anchor-btn']/span[contains(.,'Submit')]")]
        public IWebElement PDAPageSubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@data-original-title='Save']")]
        public IWebElement PDAPageSaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@data-original-title='Export to Excel']")]
        public IWebElement PDAPageExportToExcelButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@ng-click='vm.lockOrUnlockJob()']")]
        public IWebElement PDALockButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='fa fa-lock ']")]
        public IWebElement PDAJobEditButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='fa fa-unlock ']")]
        public IWebElement PDAJobNotEditableButton { get; set; }

//******PDA_PAGE_EXPECTED_DATES************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//div[@class='panel-heading'][contains(.,'Expected dates')]")]
        public IWebElement PDAPageExpectedDates { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='panel-heading'][contains(.,'Expected dates')]/i[@class='pull-right glyphicon glyphicon-chevron-down']")]
        public IWebElement PDAPageExpectedDatesExpand { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='panel-heading'][contains(.,'Expected dates')]/i[@class='pull-right glyphicon glyphicon-chevron-up']")]
        public IWebElement PDAPageExpectedDatesCollapse { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Eta']")]
        public IWebElement PDAPageExpectedDatesETA { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Etd']")]
        public IWebElement PDAPageExpectedDatesETD { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Etb']")]
        public IWebElement PDAPageExpectedDatesETB { get; set; }

//******PDA_PAGE_CHECK_BOX_BUTTONS************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//input[@id='check-all']")]
        public IWebElement PDAPageCheckAllButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//tbody[@role='rowgroup']//td/input[@class='checkbox'])[1]")]
        public IWebElement PDAPageFirstCheckBoxPDAJobs { get; set; }

//******PDA_PAGE_MAIN_HEADER*******************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//th[@data-title='Description']")]
        public IWebElement PDAPageVersionDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//th[@data-title='Provider']")]
        public IWebElement PDAPageVersionProvider { get; set; }

        [FindsBy(How = How.XPath, Using = "//th[@data-title='Paid by']")]
        public IWebElement PDAPageVersionPaidBy { get; set; }

        [FindsBy(How = How.XPath, Using = "//th[@data-title='Currency']")]
        public IWebElement PDAPageVersionCurrency { get; set; }

        [FindsBy(How = How.XPath, Using = "//th[@data-title='Quantity']")]
        public IWebElement PDAPageVersionQuantity { get; set; }

        [FindsBy(How = How.XPath, Using = "//th[contains(.,'USD Unit Price')]")]
        public IWebElement PDAPageVersionUSDUnitPrice { get; set; }

        [FindsBy(How = How.XPath, Using = "//th[contains(.,'USD amount')]")]
        public IWebElement PDAPageVersionUSDAmount { get; set; }


//******PDA_PAGE_MAIN_HEADER************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//div[@class='checkbox agree-checkbox']//input[@type='checkbox']")]
        public IWebElement PDAPageDisclaimerModalCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row footer']/button[contains(.,'Submit')]")]
        public IWebElement PDAPageDisclaimerModalSubmitButton { get; set; }

//******ADDITIONAL_ROW*******************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//button[@data-original-title='Add New Row']")]
        public IWebElement PDAPageAddNewRowButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[3]//div[@class='k-dropdown-wrap form-control']/input")]
        public IWebElement PDAPageAddedNewRowDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@name='PrncpServCode_input']")]
        public IWebElement PDAPageAddedNewRowDescriptionTextField { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='PrncpServCode_listbox']/li[1]")]
        public IWebElement PDAPageSelectAnchorageDuesFromDropdown { get; set; }

//******VALIDATION_MESSAGES****************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'PDA successfully submitted!')]")]
        public IWebElement PDASuccessfullySubmittedMessage { get; set; }

        public string ProformaPageHeader = "//h3[contains(.,'PDA')]//following-sibling::job-summary//span[contains(.,'Acknowledged by PA')]";

//*****************************************************************************************************************************************************************

    }
}
