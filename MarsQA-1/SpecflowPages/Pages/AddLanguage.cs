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

        public AddLanguage()
        {
            this.dropDownSelector = new DropDownSelector();
        }

        public void Addlanguage(string language)
        {
            string XPath = "//select[@class='ui dropdown']";
            string indexOfElement = "Basic";
            Driver.driver.FindElement(By.XPath("(//div[contains(.,'Add New')])[11]")).Click();
            Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']")).SendKeys(language);
            this.dropDownSelector.getElementSelected(XPath, indexOfElement);
            //SelectElement userRole = new SelectElement(driver.FindElement(By.XPath("//select[@class='ui dropdown']")));
            //userRole.SelectByText("Basic");
            Driver.driver.FindElement(By.XPath("//input[contains(@class,'ui teal button')]")).Click();
            VerifySkill(language);
        }

        private void VerifySkill(string skillName)
        {
            Console.WriteLine("");
        }
    }
}
