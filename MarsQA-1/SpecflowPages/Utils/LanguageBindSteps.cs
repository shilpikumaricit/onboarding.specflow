﻿using System;
using System.Runtime.CompilerServices;
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
        private SkillPage skillPage;
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
            //Assert.True(actualResult);
            if (actualResult)
            {
                Assert.True(actualResult);
            }
            else
            {
                Assert.Fail("Verification Failed.");
                throw new Exception("Result does not match");
            }
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
            // Assert.True(actualResult);
            if (actualResult)
            {
                Assert.True(actualResult);
            }
            else
            {
                Assert.Fail("Verification Failed.");
                throw new Exception("Result does not match");
            }
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
            //Assert.False(actualResult);
            if (!actualResult)
            {
                Assert.False(actualResult);
            }
            else
            {
                Assert.Fail("Verification Failed.");
                throw new Exception("Result does not match");
            }
        }

        [When(@"Seller click on skill button")]
        public void WhenSellerClickOnSkillButton()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"Click on add new button")]
        public void ThenClickOnAddNewButton()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"Add a skill in add skill field and Select a level from choose skill level")]
        public void ThenAddASkillInAddSkillFieldAndSelectALevelFromChooseSkillLevel()
        {
            //ScenarioContext.Current.Pending();
        }
        [Then(@"click on add button seller should able to add/verify skill succesfully")]
        public void ThenClickOnAddButtonSellerShouldAbleToAddVerifySkillSuccesfully()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.DataFilePath, "Skill");
            skillPage = new SkillPage();
            skillPage.AddSkill(ExcelLibHelper.ReadData(2, "Skill"), ExcelLibHelper.ReadData(2, "Level"));
            bool actualResult = skillPage.VerifySkill(ExcelLibHelper.ReadData(2, "Skill"));
            if (actualResult)
            {
                Assert.True(actualResult);
            } else
            {
                Assert.Fail("Verification Failed.");
                throw new Exception("Result does not match");
            }
        }


        [Then(@"Seller should be able to see the add skill")]
        public void ThenSellerShouldBeAbleToSeeTheAddSkill()
        {
            //Not needed
        }

        [AfterScenario]
        public void TearDown()
        {
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            Close();
        }//For verify Skill Functionality
       
        [When(@"Seller click on edit skill  button")]
        public void WhenSellerClickOnEditSkillButton()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"Seller should be able to edit the skill to the profile page")]
        public void ThenSellerShouldBeAbleToEditTheSkillToTheProfilePage()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"should be able to verify the edited skill")]
        public void ThenShouldBeAbleToVerifyTheEditedSkill()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.DataFilePath, "Skill");
            SkillPage skillPage = new SkillPage();
            skillPage.EditSkill(ExcelLibHelper.ReadData(2, "Skill"), ExcelLibHelper.ReadData(3, "Skill"));
        }
        
        //Delete skill
        [When(@"Seller click on delete Skill  button")]
        public void WhenSellerClickOnDeleteSkillButton()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"Seller should be able to delete the Skill to the profile page")]
        public void ThenSellerShouldBeAbleToDeleteTheSkillToTheProfilePage()
        {
            skillPage = new SkillPage();
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.DataFilePath, "Skill");
            skillPage.SkillDelete(ExcelLibHelper.ReadData(3, "Skill"));
            bool isRecordPresent = skillPage.VerifySkill(ExcelLibHelper.ReadData(3, "Skill"));
           // Assert.False(isRecordPresent);
            if (!isRecordPresent)
            {
                Assert.False(isRecordPresent);
            }
            else
            {
                Assert.Fail("Verification Failed.");
                throw new Exception("Result does not match");
            }
        }

        [Then(@"should be able to verify the deleted Skill")]
        public void ThenShouldBeAbleToVerifyTheDeletedSkill()
        {
            //ExcelLibHelper.PopulateInCollection(ConstantHelpers.DataFilePath, "Skill");
           // bool actualResult = skillPage.VerifySkill(ExcelLibHelper.ReadData(3, "Skill"));
            //Assert.False(actualResult);
        }

        [When(@"seller click on Education Tab And Click on Add new Button")]
        public void WhenSellerClickOnEducationTabAndClickOnAddNewButton()
        {
            EducationPage educationPage = new EducationPage();
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.DataFilePath, "Education");
            string collegeName = ExcelLibHelper.ReadData(2, "CollegeName");
            string country = ExcelLibHelper.ReadData(2, "Country");
            string title = ExcelLibHelper.ReadData(2, "Title");
            string degree = ExcelLibHelper.ReadData(2, "Degree");
            string yearOfPassing = ExcelLibHelper.ReadData(2, "YearOfPassing");
            educationPage.AddEduction(collegeName, country, title, degree, yearOfPassing);
            bool isRecordPresent = educationPage.VerifyDegree(collegeName, country, title, degree, yearOfPassing);
            //Assert.True(isRecordPresent);
            if (isRecordPresent)
            {
                Assert.True(isRecordPresent);
            }
            else
            {
                Assert.Fail("Verification Failed.");
                throw new Exception("Result does not match");
            }
        }

        [Then(@"Seller should be able to fill his eduction and Verify it\.")]
        public void ThenSellerShouldBeAbleToFillHisEductionAndVerifyIt_()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"seller click on Education Tab And Click on Edit existing education Button")]
        public void WhenSellerClickOnEducationTabAndClickOnEditExistingEducationButton()
        {
            EducationPage educationPage = new EducationPage();
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.DataFilePath, "Education");
            string originalCollegeName = ExcelLibHelper.ReadData(2, "CollegeName");
            string NewcollegeName = ExcelLibHelper.ReadData(3, "CollegeName");
            string country = ExcelLibHelper.ReadData(2, "Country");
            string title = ExcelLibHelper.ReadData(2, "Title");
            string degree = ExcelLibHelper.ReadData(2, "Degree");
            string yearOfPassing = ExcelLibHelper.ReadData(2, "YearOfPassing");
            educationPage.EditEducation(originalCollegeName, NewcollegeName);
            bool isRecordPresent = educationPage.VerifyDegree(NewcollegeName, country, title, degree, yearOfPassing);
            //Assert.True(isRecordPresent);
            if (isRecordPresent)
            {
                Assert.True(isRecordPresent);
            }
            else
            {
                Assert.Fail("Verification Failed.");
                throw new Exception("Result does not match");
            }
        }

        [Then(@"Seller should be able to Edit his eduction and Verify it\.")]
        public void ThenSellerShouldBeAbleToEditHisEductionAndVerifyIt_()
        {
            //ScenarioContext.Current.Pending();
        }

        // Delete Education
        [When(@"seller click on Education Tab And Click on Delete existing education Button")]
        public void WhenSellerClickOnEducationTabAndClickOnDeleteExistingEducationButton()
        {
            EducationPage educationPage = new EducationPage();
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.DataFilePath, "Education");
            string originalCollegeName = ExcelLibHelper.ReadData(2, "CollegeName");
            string NewcollegeName = ExcelLibHelper.ReadData(3, "CollegeName");
            string country = ExcelLibHelper.ReadData(2, "Country");
            string title = ExcelLibHelper.ReadData(2, "Title");
            string degree = ExcelLibHelper.ReadData(2, "Degree");
            string yearOfPassing = ExcelLibHelper.ReadData(2, "YearOfPassing");
            educationPage.EducationDelete(NewcollegeName);
            bool isRecordPresent = educationPage.VerifyDegree(NewcollegeName, country, title, degree, yearOfPassing);
           // Assert.False(isRecordPresent);

            if (!isRecordPresent)
            {
                Assert.False(isRecordPresent);
            }
            else
            {
                Assert.Fail("Verification Failed.");
                throw new Exception("Result does not match");
            }
        }

        [Then(@"Seller should be able to Delete his eduction and Verify it\.")]
        public void ThenSellerShouldBeAbleToDeleteHisEductionAndVerifyIt_()
        {
            //ScenarioContext.Current.Pending();
        }


    }
}
