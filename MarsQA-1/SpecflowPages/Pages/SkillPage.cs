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
        private static IWebElement AddSkillNewButton=>
           Driver.driver.FindElement(By.XPath(XpathConstants.SkillAddNewButton));
        private static IWebElement AddSkillField
            => Driver.driver.FindElement(By.XPath(XpathConstants.AddSkillField));

        private static IWebElement UpdateLanguageButton => Driver.driver.FindElement(By.XPath(XpathConstants.UpdateLanguageXpath));
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
    }
}
