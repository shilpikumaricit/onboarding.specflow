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

        private static IWebElement AddLanguageButton => Driver.driver.FindElement(By.XPath("(//div[contains(.,'Add New')])[11]"));
        private static IWebElement AddLanguageField => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));

        private static IWebElement EditLanguageButton => Driver.driver.FindElement(By.XPath("(//i[contains(@class,'outline write icon')])[2]"));
        private static IWebElement EditLanguageField => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));

        private static IWebElement UpdateLanguageButton => Driver.driver.FindElement(By.XPath("//input[contains(@value,'Update')]"));

        private static IWebElement DeleteLanguageButton => Driver.driver.FindElement(By.XPath("(//i[@class='remove icon'])[1]"));
        public LanguagePage()
        {
            this.dropDownSelector = new DropDownSelector();
        }

        public void Addlanguage(string language, string selectLevel)
        {
            string XPath = "//select[@class='ui dropdown']";
            AddLanguageButton.Click();
            AddLanguageField.SendKeys(language);
            this.dropDownSelector.getElementSelected(XPath, selectLevel);
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
        }

        internal void EditLanguage(string actualLanguage, string newLanguage)
        {
            string TableXPath = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody";
            Thread.Sleep(5000);
            int recordsCount = Driver.driver.FindElements(By.XPath(TableXPath)).Count;
            for (int i = 1; i <= recordsCount; i++)
            {
                IWebElement webElementEditButton = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i"));
                var recordUserName = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                if (recordUserName == actualLanguage)
                {
                    webElementEditButton.Click();
                    IWebElement LanguageEditField = Driver.driver.FindElement(By.XPath("//input[contains(@value,'" + actualLanguage + "')]"));
                    LanguageEditField.Clear();
                    LanguageEditField.SendKeys(newLanguage);
                    UpdateLanguageButton.Click();
                    break;
                }
            }
        }

        public Boolean VerifyLanguage (string Language)
        {

            string TableXPath = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody";
            Thread.Sleep(5000);
            int recordsCount = Driver.driver.FindElements(By.XPath(TableXPath)).Count;
            bool recordFound = false;
            for (int i = 1; i <= recordsCount; i++)
            {
                var recordUserName = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                if (recordUserName == Language)
                {
                    recordFound = true;
                    break;
                }
            }

            if (recordFound)
            {
                Console.WriteLine("Record {0} is created successfully and exists in records list", Language);
            }
            else
                Console.WriteLine("Record {0} is created but does not exists in records list", Language);

            return recordFound;
        }

        internal void DeleteLanguage(string LanguageToDelete)
        {
            string TableXPath = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody";
            Thread.Sleep(5000);
            int recordsCount = Driver.driver.FindElements(By.XPath(TableXPath)).Count;
            for (int i = 1; i <= recordsCount; i++)
            {
                IWebElement webElementDeleteButton = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i"));
                var recordUserName = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;

                if (recordUserName == LanguageToDelete)
                {
                    webElementDeleteButton.Click();
                    break;
                }
            }
        }
    }
}
