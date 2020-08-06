using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Helpers
{
    class XpathConstants
    {
        // XPath constants for Language
        public static string AddNewLanguageButton = "(//div[contains(.,'Add New')])[11]";

        public static string AddLangaugeField = "//input[@placeholder='Add Language']";

        public static string LanguageTablePath = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody";

        public static string LanguageDropdownXPath = "//select[@class='ui dropdown']";

        public static string AddLanguageButton = "//input[@value='Add']";

        public static string EditLanguageButtonXPath = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[{0}]/tr/td[1]";

        public static string EditLanguageFieldXPath = "//input[contains(@value,'{0}')]";

        public static string EditButtonXPath = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[{0}]/tr/td[3]/span[1]/i";

        public static string LanguageFileTextXPath = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[{0}]/tr/td[1]";

        public static string DeleteLanguageButtonXPath = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[{0}]/tr/td[3]/span[2]/i";

        public static string UpdateLanguageXpath = "//input[contains(@value,'Update')]";

    }
}
