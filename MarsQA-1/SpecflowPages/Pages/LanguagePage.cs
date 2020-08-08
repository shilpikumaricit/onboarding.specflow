using System;
using System.Threading;
using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.SpecflowPages.Pages
{
    class LanguagePage
    {      

        private DropDownSelector dropDownSelector;

        private static IWebElement AddLanguageButton => 
            Driver.driver.FindElement(By.XPath(XpathConstants.AddNewLanguageButton));
        private static IWebElement AddLanguageField 
            => Driver.driver.FindElement(By.XPath(XpathConstants.AddLangaugeField));

        private static IWebElement UpdateLanguageButton => Driver.driver.FindElement(By.XPath(XpathConstants.UpdateLanguageXpath));

        public LanguagePage()
        {
            this.dropDownSelector = new DropDownSelector();
        }

        public void Addlanguage(string language, string selectLevel)
        {
            AddLanguageButton.Click();
            AddLanguageField.SendKeys(language);
            this.dropDownSelector.getElementSelectedByName(XpathConstants.LanguageDropdownXPath, selectLevel);
            Driver.driver.FindElement(By.XPath(XpathConstants.AddLanguageButton)).Click();
        }

        internal void EditLanguage(string actualLanguage, string newLanguage)
        {
            int recordsCount = Driver.driver.FindElements(By.XPath(XpathConstants.LanguageTablePath)).Count;
            for (int i = 1; i <= recordsCount; i++)
            {
                IWebElement webElementEditButton = Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.EditButtonXPath, i)));
                var recordUserName = Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.EditLanguageButtonXPath, i))).Text;

                if (recordUserName == actualLanguage)
                {
                    webElementEditButton.Click();
                    IWebElement LanguageEditField = Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.EditLanguageFieldXPath, actualLanguage)));
                    LanguageEditField.Clear();
                    LanguageEditField.SendKeys(newLanguage);
                    UpdateLanguageButton.Click();
                    break;
                }
            }
        }

        public Boolean VerifyLanguage (string Language)
        {
            Thread.Sleep(5000);
            int LanguageFieldRecordCount = Driver.driver.FindElements(By.XPath(XpathConstants.LanguageTablePath)).Count;
            bool recordFound = false;
            for (int i = 1; i <= LanguageFieldRecordCount; i++)
            {
                var LanguageText = Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.LanguageFileTextXPath, i))).Text;

                if (LanguageText == Language)
                {
                    recordFound = true;
                    break;
                }
            }
            return recordFound;
        }

        internal void DeleteLanguage(string LanguageToDelete)
        {
            Thread.Sleep(5000);
            int LanguageFieldRecordCount = Driver.driver.FindElements(By.XPath(XpathConstants.LanguageTablePath)).Count;
            for (int i = 1; i <= LanguageFieldRecordCount; i++)
            {
                var LanguageFileText = Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.LanguageFileTextXPath, i))).Text;

                if (LanguageFileText == LanguageToDelete)
                {
                    IWebElement LanguageDeleteButton = Driver.driver.FindElement(By.XPath(string.Format(XpathConstants.DeleteLanguageButtonXPath, i)));
                    LanguageDeleteButton.Click();
                    break;
                }
            }
        }
    }
}
