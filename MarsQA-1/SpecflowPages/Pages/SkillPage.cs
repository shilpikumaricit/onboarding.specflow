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
    class SkillPage
    {
        private DropDownSelector dropDownSelector;
        private static IWebElement ClickSkillTab =>
           Driver.driver.FindElement(By.XPath(XpathConstants.SkillTab));
        private static IWebElement AddSkillNewButton =>
           Driver.driver.FindElement(By.XPath(XpathConstants.SkillAddNewButton));
        private static IWebElement AddSkillField
            => Driver.driver.FindElement(By.XPath(XpathConstants.AddSkillField));

        private static IWebElement EditskillButton => Driver.driver.FindElement(By.XPath(XpathConstants.skillEditButton));
        private static IWebElement EditSkillButton => Driver.driver.FindElement(By.XPath(XpathConstants.SkillUpdateFieldXPath));

        private static IWebElement UpdateSkillButton => Driver.driver.FindElement(By.XPath(XpathConstants.SkillUpdateButton));
        private static IWebElement DeleteSkillButton => Driver.driver.FindElement(By.XPath(XpathConstants.DeleteSkillButton));
        public SkillPage()
        {
            this.dropDownSelector = new DropDownSelector();
        }

        public void AddSkill(string Skill, string selectLevel)
        {
            ClickSkillTab.Click();
            AddSkillNewButton.Click();
            AddSkillField.SendKeys(Skill);
            this.dropDownSelector.getElementSelectedByValue(XpathConstants.SkillDropdown, selectLevel);
            Driver.driver.FindElement(By.XPath(XpathConstants.Addbutton)).Click();
        }
        public Boolean VerifySkill(string Skill)
        {
            //Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Thread.Sleep(5000);
            int SkillFieldRecordCount = Driver.driver.FindElements(By.XPath(XpathConstants.SkillTableXPath)).Count;
            bool recordFound = false;
            for (int i = 1; i <= SkillFieldRecordCount; i++)
            {
                var SkillText = Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.SkillUpdateFieldXPath, i))).Text;

                if (SkillText == Skill)
                {
                    recordFound = true;
                    break;
                }
            }
            return recordFound;
        }
        internal void EditSkill(string actualSkill, string newSkill)
        {
            ClickSkillTab.Click();
            int recordsCount = Driver.driver.FindElements(By.XPath(XpathConstants.SkillTableXPath)).Count;
            for (int i = 1; i <= recordsCount; i++)
            {
                var skillName = Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.SkillUpdateFieldXPath, i))).Text;

                if (skillName == actualSkill)
                {
                    Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.skillEditButton, i))).Click();
                    IWebElement SkillEditField = Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.SkillUpdateField, actualSkill)));
                    SkillEditField.Clear();

                    SkillEditField.SendKeys(newSkill);
                    UpdateSkillButton.Click();

                    break;
                }
                
                    
            }
        }//Delete functianlity
        internal void SkillDelete(string SkillToDelete)
        {
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            ClickSkillTab.Click();
            int SkillFieldRecordCount = Driver.driver.FindElements(By.XPath(XpathConstants.SkillTableXPath)).Count;
            for (int i = 1; i <= SkillFieldRecordCount; i++)
            {
                var SkillFileText = Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.SkillUpdateFieldXPath, i))).Text;

                if (SkillFileText ==SkillToDelete)
                {
                    IWebElement SkillDeleteButton = Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.DeleteSkillButton, i)));
                    SkillDeleteButton.Click();
                    break;
                }
            }
        }
    }
    
}
