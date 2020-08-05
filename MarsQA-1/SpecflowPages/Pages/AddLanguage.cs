using System;
using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.SpecflowPages.Pages
{
    class AddLanguage
    {      

        private DropDownSelector dropDownSelector;

        private static IWebElement AddLanguageButton => Driver.driver.FindElement(By.XPath("(//div[contains(.,'Add New')])[11]"));
        private static IWebElement AddLanguageField => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));

        private static IWebElement EditLanguageButton => Driver.driver.FindElement(By.XPath("(//i[@class='outline write icon'])[2]"));
        private static IWebElement EditLanguageField => Driver.driver.FindElement(By.XPath("//input[contains(@value,'English')]"));

        private static IWebElement UpdateLanguageButton => Driver.driver.FindElement(By.XPath("//input[contains(@value,'Update')]"));

        private static IWebElement DeleteLanguageButton => Driver.driver.FindElement(By.XPath("(//i[@class='remove icon'])[1]"));
        public AddLanguage()
        {
            this.dropDownSelector = new DropDownSelector();
        }

        public void Addlanguage(string language, string selectLevel)
        {
            string XPath = "//select[@class='ui dropdown']";
            AddLanguageField.SendKeys(language);
            this.dropDownSelector.getElementSelected(XPath, selectLevel);
            Driver.driver.FindElement(By.XPath("(//div[contains(.,'Add New')])[11]")).Click();
            AddLanguageButton.Click();
            VerifyLanguage(language);
        }

        internal void EditLanguage(string actualLanguage, string newLanguage)
        {
            EditLanguageButton.Click();
            EditLanguageField.SendKeys(newLanguage);
            UpdateLanguageButton.Click();
        }

        public void VerifyLanguage (string Language)
        {
            DeleteLanguageButton.Click();
        }

        internal void DeleteLanguage(string v)
        {
            throw new NotImplementedException();
        }
    }
}
