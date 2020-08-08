using System;
using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQA_1.SpecflowPages.Helpers
{
    class DropDownSelector
    {
        public SelectElement getElementSelectedByName(string Xpath, string name)
        {
            SelectElement selectElement = new SelectElement(Driver.driver.FindElement(By.XPath(Xpath)));
            selectElement.SelectByText(name);
            return selectElement;
        }

        public SelectElement getElementSelectedByValue(string Xpath, string index)
        {
            var selectElement = new SelectElement(Driver.driver.FindElement(By.XPath(Xpath)));
            selectElement.SelectByIndex(Int32.Parse(index));
            return selectElement;
        }
    }
}
