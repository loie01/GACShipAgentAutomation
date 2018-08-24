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
    class GACShip_Agent_SOFPage
    {

        //Constructor to initialize the elements in this page.
        //ctor double tab will bring constructor

        public GACShip_Agent_SOFPage()
        {
            PageFactory.InitElements(PropertyCollection.Driver, this);
        }

//******SOF_PAGE_MAIN_HEADER************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//div[@class='row heading']//h3[contains(.,'SOF')]//following-sibling::span[contains(text(),'SOF Missing')]")]
        public IWebElement SOFPageHeader { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='col-sm-12 col-xs-12']/span")]
        public IWebElement SOFPageJobNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'SOF Timings')]")]
        public IWebElement SOFTimingPlaceHolder { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@ng-click='vm.lockOrUnlockJob()']")]
        public IWebElement LockButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='fa fa-download']")]
        public IWebElement DownloadSOFReportButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@data-original-title='Document Upload/View']")]
        public IWebElement DocumentUploadViewButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button/i[@class='fa fa-save']")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='btn anchor-btn']/span[contains(.,'Submit')]")]
        public IWebElement SubmitButton { get; set; }


//******EDIT_DETAILS************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//input[@id='check-all']//ancestor::div[@class='tab-content']/div[1]")]
        public IWebElement PageCheckAllButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//tbody[@role='rowgroup']//td/input[@class='checkbox'])[1]")]
        public IWebElement PageFirstCheckBoxFDAJobs { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='fa fa-lock ']")]
        public IWebElement JobEditButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='fa fa-unlock ']")]
        public IWebElement JobUnlockButton { get; set; }

//******SOF_DATES_BUTTON************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//div[@class='modal-content']//button[@class='btn btn-submit pull-right']")]
        public IWebElement SOFDateMissingModalConfirmButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='panel-heading']/i")]
        public IWebElement SOFDatesDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "Eta")]
        public IWebElement ETAOfSOFJob { get; set; }

        [FindsBy(How = How.Id, Using = "Etd")]
        public IWebElement ETDOfSOFJob { get; set; }

        [FindsBy(How = How.Id, Using = "Etb")]
        public IWebElement ETBOfSOFJob { get; set; }

        [FindsBy(How = How.Id, Using = "Ata")]
        public IWebElement ATAOfSOFJob { get; set; }

        [FindsBy(How = How.Id, Using = "Atd")]
        public IWebElement ATDOfSOFJob { get; set; }

        [FindsBy(How = How.Id, Using = "Atb")]
        public IWebElement ATBOfSOFJob { get; set; }

        [FindsBy(How = How.Id, Using = "NoticeOfReadiness.Started")]
        public IWebElement NoticeOfReadinessOfSOFJob { get; set; }

        [FindsBy(How = How.Id, Using = "Commenced.Started")]
        public IWebElement CommencedStartedOfSOFJob { get; set; }

        [FindsBy(How = How.Id, Using = "Anchored.Started")]
        public IWebElement AnchoredStartedOfSOFJob { get; set; }

        [FindsBy(How = How.Id, Using = "Completed.Started")]
        public IWebElement CompletedStartedOfSOFJob { get; set; }

        [FindsBy(How = How.Id, Using = "AllFast.Started")]
        public IWebElement AllFastStartedOfSOFJob { get; set; }

//******SOF_RADIO_BUTTON************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//label[@class='control-label'][contains(.,'HSSE Incident')]")]
        public IWebElement HSSEIncidentHeaderOfSOFJob { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@class='radio-inline']/input[@name='hsse'][@value='true']")]
        public IWebElement HSSEYesRadioButtonOfSOFJob { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@class='radio-inline']/input[@name='hsse'][@value='false']")]
        public IWebElement HSSENoRadioButtonOfSOFJob { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@class='control-label'][contains(.,'Customer Complaint')]")]
        public IWebElement CustomerComplaintHeaderOfSOFJob { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@class='radio-inline']/input[@name='CustomerComplaint'][@value='true']")]
        public IWebElement CustomerCompliantYesRadioButtonOfSOFJob { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@class='radio-inline']/input[@name='CustomerComplaint'][@value='false']")]
        public IWebElement CustomerCompliantNoRadioButtonOfSOFJob { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@class='control-label'][contains(.,'Other Feedback')]")]
        public IWebElement OtherFeedbackHeaderOfSOFJob { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@class='radio-inline']/input[@name='OtherFeedback'][@value='true']")]
        public IWebElement OtherFeedbackYesRadioButtonOfSOFJob { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@class='radio-inline']/input[@name='OtherFeedback'][@value='false']")]
        public IWebElement OtherFeedbackNoRadioButtonOfSOFJob { get; set; }

//******SOF_ARRIVAL_REMARKS************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//label[@class='control-label'][contains(.,'Arrival Remarks')]")]
        public IWebElement ArrivalRemarksHeaderOfSOFJob { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@class='control-label'][contains(.,'Arrival Remarks')]//following-sibling::textarea")]
        public IWebElement ArrivalRemarksTextAreaOfSOFJob { get; set; }

//******SOF_EVENTS_AND_DETAILS_TAB************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-default']/i[@class='fa fa-plus']")]
        public IWebElement AddNewRowButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(.,'SOF events and details')]")]
        public IWebElement SOFEventsAndDetailsTabButton { get; set; }

        //******Description*******//

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[1]//th[@data-title='Description']")]
        public IWebElement SOFEventsAndDetailsDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[2]//span[@class='k-icon k-i-arrow-s']")]
        public IWebElement DescriptionDropdownSOFEventsAndDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'Commenced Ullaging')]")]
        public IWebElement SelectCommencedUllagingInSOFEventDropdown { get; set; }

        //******Event Date*******//

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[1]//th[@data-title='Event Date']")]
        public IWebElement SOFEventsAndDetailsEventDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Started']")]
        public IWebElement SOFEventDate { get; set; }

        //******Unit*******//

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[1]//th[@data-title='Unit']")]
        public IWebElement SOFEventsAndDetailsUnit { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'Date')]")]
        public IWebElement SelectDateInSOFUnitDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[4]//span[@class='k-icon k-i-arrow-s']")]
        public IWebElement UnitDropdownSOFEventsAndDetails { get; set; }

        //******Quantity*******//

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[1]//th[@data-title='Quantity']")]
        public IWebElement SOFEventsAndDetailsQuantity { get; set; }

        [FindsBy(How = How.Name, Using = "Quantity")]
        public IWebElement SOFEventQuantity { get; set; }

        //******Cargo*******//

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[1]//th[@data-title='Cargo']")]
        public IWebElement SOFEventsAndDetailsCargo { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[6]//span[@class='k-icon k-i-arrow-s']")]
        public IWebElement CargoDropdownSOFEventsAndDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'GENERAL')]")]
        public IWebElement SelectGeneralInSOFCargoDropdown { get; set; }

        //******Remarks*******//

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[1]//th[@data-title='Remarks']")]
        public IWebElement SOFEventsAndDetailsRemarks { get; set; }

        [FindsBy(How = How.Name, Using = "Remarks")]
        public IWebElement SOFEventRemarks { get; set; }

        [FindsBy(How = How.XPath, Using = "//tbody[@role='rowgroup']//a[@class='remarks-toggle fa fa-caret-right']")]
        public IWebElement SOFPageToggleOnFirstRemarks { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='RebillableRemarks']/following-sibling::input")]
        public IWebElement SOFPageFirstRebillableRemarks { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@for='AgentRemarks']/following-sibling::input")]
        public IWebElement SOFPageFirstAgentRemarks { get; set; }

//******DISCLAIMER_MODAL************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//div[@class='checkbox agree-checkbox']//input[@type='checkbox']")]
        public IWebElement SOFPageDisclaimerModalCheckbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='row footer']/button[contains(.,'Submit')]")]
        public IWebElement SOFPageDisclaimerModalSubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//tbody[@role='rowgroup']//td/input[@class='checkbox'])[1]")]
        public IWebElement SOFPageFirstCheckBoxSOFJobs { get; set; }

//******ARRIVAL_DETAILS_TAB************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Arrival details')]")]
        public IWebElement ArrivalDetailsTabButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[2]//button[@class='btn btn-default gs-btn-icon']/i[@class='fa fa-plus']")]
        public IWebElement AddNewRowArrivalDetailsTab { get; set; }

        //******Description*******//

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[2]//th[@data-title='Description']")]
        public IWebElement ArrivalDetailsDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[2]//span[@class='k-icon k-i-arrow-s']")]
        public IWebElement ArrivalDetailsDescriptionDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[2]//span[@unselectable='on']/input")]
        public IWebElement ArrivalDetailsDescriptionTextField { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'IFO on arrival')]")]
        public IWebElement ArrivalDetailsDescriptionDropdownSelectIPOOnArrival { get; set; }

        //******Unit*******//

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[2]//th[@data-title='Unit']")]
        public IWebElement ArrivalDetailsUnit { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[3]//span[@class='k-icon k-i-arrow-s']")]
        public IWebElement UnitDropdownArrivalDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'Date')]")]
        public IWebElement SelectKiloTonnesInArrivalDetailsUnitDropdown { get; set; }

        //******Quantity*******//

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[2]//th[@data-title='Quantity']")]
        public IWebElement ArrivalDetailsQuantity { get; set; }

        public String Nuve = "//div[@class='tab-content']/div[2]//th[@data-title='Quantity']";

        [FindsBy(How = How.Name, Using = "Quantity")]
        public IWebElement ArrivalDetailsQuantityTextField { get; set; }

        //******Purpose*******//

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[2]//th[@data-title='Purpose']")]
        public IWebElement ArrivalDetailsPurpose { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[5]//span[@class='k-icon k-i-arrow-s']")]
        public IWebElement PurposeDropdownArrivalDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'ROB')]")]
        public IWebElement ArrivalDetailsPurposeDropdownSelectROBInSOF { get; set; }


        //******Remarks*******//

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[2]//th[@data-title='Remarks']")]
        public IWebElement ArrivalDetailsRemarks { get; set; }

        [FindsBy(How = How.Name, Using = "Remarks")]
        public IWebElement ArrivalDetailsRemarksTextField { get; set; }

//******DEPARTURE_DETAILS_TAB************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Departure Details')]")]
        public IWebElement DepartureDetailsTabButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[3]//button[@class='btn btn-default gs-btn-icon']/i[@class='fa fa-plus']")]
        public IWebElement AddNewRowDepartureDetailsTab { get; set; }

        //******Description*******//

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[3]//th[@data-title='Description']")]
        public IWebElement DepartureDetailsDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[3]//span[@class='k-icon k-i-arrow-s']")]
        public IWebElement DepartureDetailsDescriptionDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[3]//span[@unselectable='on']/input")]
        public IWebElement DepartureDetailsDescriptionTextField { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'IFO on departure')]")]
        public IWebElement DepartureDetailsDescriptionDropdownSelectIPOOnDeparture { get; set; }

        //******Unit*******//

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[3]//th[@data-title='Unit']")]
        public IWebElement DepartureDetailsUnit { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[3]//span[@class='k-icon k-i-arrow-s']")]
        public IWebElement ArrivalDetailsUnitDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'Date')]")]
        public IWebElement SelectKiloTonnesInDepartureDetailsUnitDropdown { get; set; }

        //******Quantity*******//

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[3]//th[@data-title='Quantity']")]
        public IWebElement DepartureDetailsQuantity { get; set; }

        [FindsBy(How = How.Name, Using = "Quantity")]
        public IWebElement DepartureDetailsQuantityTextField { get; set; }

        //******Purpose*******//

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[3]//th[@data-title='Purpose']")]
        public IWebElement DepartureDetailsPurpose { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[5]//span[@class='k-icon k-i-arrow-s']")]
        public IWebElement DepartureDetailsPurposeDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(.,'ROB')]")]
        public IWebElement DepartureDetailsxPurposeDropdownDepartureDetails { get; set; }


        //******Remarks*******//

        [FindsBy(How = How.XPath, Using = "//div[@class='tab-content']/div[3]//th[@data-title='Remarks']")]
        public IWebElement DepartureDetailsRemarks { get; set; }

        [FindsBy(How = How.Name, Using = "Remarks")]
        public IWebElement DepartureDetailsRemarksTextField { get; set; }

//******VALIDATION_MESSAGES************************************************************************************************************************************

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'SOF successfully submitted!')]")]
        public IWebElement SOFSuccessfullySubmittedMessage { get; set; }

        public string SOFRequiredPageHeader = "//div[@class='row heading']//h3[contains(.,'SOF')]//following-sibling::span[contains(text(),'SOF Missing')]";

//**************************************************************************************************************************************************************
    }
}
