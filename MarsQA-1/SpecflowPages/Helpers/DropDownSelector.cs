using System;
using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQA_1.SpecflowPages.Helpers
{
    class DropDownSelector
    {
        public SelectElement getElementSelected(string Xpath, string indexOfElement)
        {
            SelectElement selectElement = new SelectElement(Driver.driver.FindElement(By.XPath(Xpath)));
            selectElement.SelectByText(indexOfElement);
            return selectElement;
        }
    }
}
