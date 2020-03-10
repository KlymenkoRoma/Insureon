using System;
using System.Threading;
using FluentAssertions;
using Framework.Selenium;
using Insureon.PageObjects.AgencyPortalPages;
using Insureon.PageObjects.BasePages;
using Insureon.PageObjects.UniversallAppPages;
using Insureon.Selenium;
using NUnit.Framework;

namespace Insureon.UITests
{
    [TestFixture]
    public class Tests : BaseTest
    {
        static string[] clientNames = { "testatomk0404201", "testatomk0404202" };

        [Test]
        [TestCaseSource("clientNames")]
        [Parallelizable(ParallelScope.Children)]
        public void Submit_Application(string client)
        {
            var agentPage = new AgentLoginPage();
            string checkName = agentPage.Login()
                .NavigateToStartApplicationPage()
                .GoTo()
                .NavigateToYourCompanyPage("Accounting & Finance Professionals", "Accounting & Auditing")
                .AddZipCode("10001")
                .AddBissnessName(client)
                .NavigateToYourProtectionPage()
                .SelectGL()
                .NavigateToYourInformationPage()
                .AddFirstName("Ben")
                .AddLastName("Clover")
                .AddPhone("5557778888")
                .AddEmail("testm@mail.com")
                .AddCoverageStart("03/05/2020")
                .NavigateToYourCompanyHistoryPage()
                .AddStartOfBussiness("01/01/2010")
                .AddYearsOfExperience("5")
                .AddBusinessRegistered("Individual")
                .AddDOB("04/11/1989")
                .AddNumberOfEmployees("1")
                .AddAnnualPayroll("22222")
                .NavigateToYourLocationsPage()
                .SelectBusinessBased("Yes")
                .AddAddressLine1("432 Line")
                .NavigateToYourServiceDetailsPage()
                .AddPublicCompanyAudit("99")
                .AddOtherAudit("1")
                .NavigateToYourBusinessDetailsPage()
                .AddDescribeBusiness()
                .HaveWebsite("No")
                .DoUseAgreement("Never")
                .DoUseDeclinationLetters("Yes")
                .DoBusinessConsult("No")
                .DoTangibleGoods("No")
                .DoPerformDesign("No")
                .DoPartTime("No")
                .DoTaxLiensBankruptcy("No")
                .DoSubsidiaries("No")
                .DoCrimeFraud("No")
                .DoOwnHalf("No")
                .DoOwnerFirmNone()
                .DoStaffFirmNone()
                .AddStaffFirmNoneDetails()
                .DoSuedClient("No")
                .AddRevenueNextYear("15000")
                .AddRevenueCurrentYear("124000")
                .AddRevenuePriorYear("55004")
                .NavigateToYourInsuranceHistoryPage()
                .HaveActivePolicies("No")
                .WhatReasonNoInsurance("Other")
                .HasCompanyClaims("No")
                .HaveClaimAgainstCompany("No")
                .NavigateToYourGeneralLiabilityDetailsPage()
                .HaveActivePolicies("No")
                .AddSquareFeetOccupy()
                .NavigateToOptionalCoveragesPage()
                .WantEmploymentPracticesLiability("No")
                .WantDataBreach("No")
                .SelectProfessionalLiability("No Coverage")
                .HaveBusinessVehicles("Yes")
                .WantAdditionalInsured("No")
                .NavigateToOptionalDiscountsPage()
                .SelectBOP()
                .NavigateToReviewAndConfirmApplicationPage()
                .NavigateToClientDetailsPage()
                .businessName(YourCompanyPage.clientName).Text;

            checkName.Should().Be(YourCompanyPage.clientName);
        }

        [Test]
        public void Bind_Request()
        {
            var agentPage = new AgentLoginPage();
            string checkBind = agentPage.Login()
                .NavigateToViewClientsPage()
                .GoTo()
                .SearchClient("testatom@k0221201")
                .NavigateToClientDetailsPage("testatom@k0221201")
                .SelectQuoteDetails("Quoted")
                .SelectQuoteAction("Request Bind")
                .SubmitQuoteAction()
                .BindPopup.SelectEffectiveDate()
                .SelectPaymentPlan("Full Pay")
                .SelectPaymentMethod("Credit / Debit Card")
                .SubmitQuoteAction()
                .AddFirstName()
                .AddLastName()
                .AddCardNumber("5555555555554444")
                .SelectExpirationMonth("5")
                .SelectExpirationYear("2025")
                .AddCvvCode("701")
                .SubmitRequest()
                .requestSubmittedText.Text;

            checkBind.Should().Be("Your Bind Request has been submitted.");
        }

        [Test]
        public void Requote()
        {
            var agentPage = new AgentLoginPage();
            agentPage.Login()
                .NavigateToViewClientsPage()
                .GoTo()
                .SearchClient("testatom@k0221202")
                .NavigateToClientDetailsPage("testatom@k0221202")
                .SelectQuoteDetails("Pending Activation")
                .SelectQuoteAction("Requote")
                .SelectEffectiveDate()
                .SubmitQuoteAction();

            Thread.Sleep(90000);
            new ClientDetailsPage().cardYellowColor.Displayed.Should().BeTrue();
        }
    }
}
