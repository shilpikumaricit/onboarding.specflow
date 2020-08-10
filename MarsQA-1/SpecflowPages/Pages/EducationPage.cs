using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.SpecflowPages.Pages
{
    class EducationPage
    {
        private DropDownSelector dropDownSelector;
        private static IWebElement ClickOnEducationTab =>
           Driver.driver.FindElement(By.XPath(XpathConstants.educationTabXPath));
        private static IWebElement AddEducationNewButton =>
           Driver.driver.FindElement(By.XPath(XpathConstants.educationAddNewXPath));
        private static IWebElement AddCollegeField
            => Driver.driver.FindElement(By.XPath(XpathConstants.inputCollegeXPath));

        private static IWebElement AddDegreeField
            => Driver.driver.FindElement(By.XPath(XpathConstants.inputDegreeXPath));

        private static IWebElement EditskillButton => Driver.driver.FindElement(By.XPath(XpathConstants.skillEditButton));
        private static IWebElement EditSkillButton => Driver.driver.FindElement(By.XPath(XpathConstants.SkillUpdateFieldXPath));

        private static IWebElement UpdateEducationButton => Driver.driver.FindElement(By.XPath(XpathConstants.EducationUpdateButton));
        private static IWebElement DeleteSkillButton => Driver.driver.FindElement(By.XPath(XpathConstants.DeleteSkillButton));
        public EducationPage()
        {
            this.dropDownSelector = new DropDownSelector();
        }

        public void AddEduction(string College, string Country, string Title, 
            String Degree, string YearOfPassing)
        {
            ClickOnEducationTab.Click();
            AddEducationNewButton.Click();
            AddCollegeField.SendKeys(College);
            AddDegreeField.SendKeys(Degree);
            this.dropDownSelector.getElementSelectedByName(XpathConstants.selectCountryXPath, Country);
            this.dropDownSelector.getElementSelectedByName(XpathConstants.selectTitleXPath, Title);
            this.dropDownSelector.getElementSelectedByName(XpathConstants.selectYearOfPassingXPath, YearOfPassing);
            Driver.driver.FindElement(By.XPath(XpathConstants.Addbutton)).Click();
        }

        //Edit Education

        internal void EditEducation (string originalCollegeName, string newCollegeName)
        {
            ClickOnEducationTab.Click();
            int recordsCount = Driver.driver.FindElements(By.XPath(XpathConstants.eductionTableXPath)).Count;
            for (int i = 1; i <= recordsCount; i++)
            {
                var College = Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.EducationUpdateFieldXPath, i))).Text;

                if (College == originalCollegeName)
                {
                    Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.EducationEditButton, i))).Click();

                    IWebElement EducationEditField = Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.EducationUpdateField, originalCollegeName)));
                    EducationEditField.Clear();
                    EducationEditField.SendKeys(newCollegeName);
                    UpdateEducationButton.Click();
                    break;
                }
            }
        }
        public Boolean VerifyDegree(string College, string Country, string Title,
            String Degree, string YearOfPassing)
        {
            //Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Thread.Sleep(5000);
            int SkillFieldRecordCount = Driver.driver.FindElements(By.XPath(XpathConstants.eductionTableXPath)).Count;
            bool recordFound = false;
            for (int i = 1; i <= SkillFieldRecordCount; i++)
            {
                var webElement = Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.TableRowFieldValueXPath, i))).Text;
                
                if (webElement == College)
                {
                    recordFound = true;
                    break;
                }
            }
            return recordFound;
        }

        public void EducationDelete(string CollegeToDelete)
        {
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            ClickOnEducationTab.Click();
            int recordsCount = Driver.driver.FindElements(By.XPath(XpathConstants.eductionTableXPath)).Count;
            for (int i = 1; i <= recordsCount; i++)
            {
                var College = Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.EducationUpdateFieldXPath, i))).Text;
                if (College == CollegeToDelete)
                {
                    IWebElement EducationDeleteButton = Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.DeleteEducationButton, i)));
                    EducationDeleteButton.Click();
                    break;
                }
            }
        }
    }
    
}
