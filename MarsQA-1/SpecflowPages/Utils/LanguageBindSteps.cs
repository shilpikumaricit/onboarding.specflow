﻿using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;
namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {
        private LanguagePage addLanguage = new LanguagePage();
        [BeforeScenario]
        public void Setup()
        {
            Initialize();
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.CredentialExcelPathLocation, "Credentials");
            SignIn.SigninStep();
        }

        [When(@"Seller click on new Add Language  button")]
        public void WhenSellerClickOnNewAddLanguageButton()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"Seller should be able to add the language to the profile page")]
        public void ThenSellerShouldBeAbleToAddTheLanguageToTheProfilePage()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.DataFilePath, "Language");
            addLanguage.Addlanguage(ExcelLibHelper.ReadData(2, "Language"), ExcelLibHelper.ReadData(2, "Level"));
        }

        [Then(@"should be able to verify the add language")]
        public void ThenShouldBeAbleToVerifyTheAddLanguage()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.DataFilePath, "Language");
            bool actualResult = addLanguage.VerifyLanguage(ExcelLibHelper.ReadData(2, "Language"));
            Assert.True(actualResult);
        }
        [When(@"Seller click on edit Language  button")]
        public void WhenSellerClickOnEditLanguageButton()
        {
            //addLanguage.EditLanguage("English", "Hindi");
        }

        [Then(@"Seller should be able to edit the language to the profile page")]
        public void ThenSellerShouldBeAbleToEditTheLanguageToTheProfilePage()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.DataFilePath, "Language");
            addLanguage.EditLanguage(ExcelLibHelper.ReadData(2, "Language"), ExcelLibHelper.ReadData(3, "Language"));
        }

        [Then(@"should be able to verify the edited language")]
        public void ThenShouldBeAbleToVerifyTheEditedLanguage()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.DataFilePath, "Language");
            bool actualResult = addLanguage.VerifyLanguage(ExcelLibHelper.ReadData(3, "Language"));
            Assert.True(actualResult);
        }

        [When(@"Seller click on delete Language  button")]
        public void WhenSellerClickOnDeleteLanguageButton()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.DataFilePath, "Language");
            addLanguage.DeleteLanguage(ExcelLibHelper.ReadData(3, "Language"));
        }

        [Then(@"Seller should be able to delete the language to the profile page")]
        public void ThenSellerShouldBeAbleToDeleteTheLanguageToTheProfilePage()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"should be able to verify the deleted language")]
        public void ThenShouldBeAbleToVerifyTheDeletedLanguage()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.DataFilePath, "Language");
            bool actualResult = addLanguage.VerifyLanguage(ExcelLibHelper.ReadData(3, "Language"));
            Assert.False(actualResult);
        }

        [AfterScenario]
        public void TearDown()
        {
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            Close();
        }
    }
}
