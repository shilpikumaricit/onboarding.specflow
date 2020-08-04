using System;
using System.Threading;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Bind_Steps
{
    [Binding]
    public class AddSellerProfileSteps
    {
        [Given(@"Seller login to mars application as seller")]
        public void GivenSellerLoginToMarsApplicationAsSeller()
        {
            SignIn.Login();
            Thread.Sleep(10000);
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"Seller navigate to profile page")]
        public void GivenSellerNavigateToProfilePage()
        {
            AddLanguage addLanguage = new AddLanguage();
            addLanguage.Addlanguage("Hindi");
        }
        
        [When(@"Seller click on description edit button")]
        public void WhenSellerClickOnDescriptionEditButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Seller should be able to add the description to the profile")]
        public void ThenSellerShouldBeAbleToAddTheDescriptionToTheProfile()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
