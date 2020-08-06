using MarsQA_1.Helpers;
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
            ExcelLibHelper.PopulateInCollection(@"C:\Users\Shilpi\source\repos\onboarding.specflow\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");
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
            addLanguage.Addlanguage("English", "Basic");
        }

        [Then(@"should be able to verify the add language")]
        public void ThenShouldBeAbleToVerifyTheAddLanguage()
        {
            bool actualResult = addLanguage.VerifyLanguage("English");
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
            addLanguage.EditLanguage("English", "Hindi");
        }

        [Then(@"should be able to verify the edited language")]
        public void ThenShouldBeAbleToVerifyTheEditedLanguage()
        {
            bool actualResult = addLanguage.VerifyLanguage("Hindi");
            Assert.True(actualResult);
        }

        [When(@"Seller click on delete Language  button")]
        public void WhenSellerClickOnDeleteLanguageButton()
        {
            addLanguage.DeleteLanguage("Hindi");
        }

        [Then(@"Seller should be able to delete the language to the profile page")]
        public void ThenSellerShouldBeAbleToDeleteTheLanguageToTheProfilePage()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"should be able to verify the deleted language")]
        public void ThenShouldBeAbleToVerifyTheDeletedLanguage()
        {
            bool actualResult = addLanguage.VerifyLanguage("Hindi");
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
