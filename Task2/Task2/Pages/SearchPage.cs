using System.IO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class SearchPage
    {
        static string manufacturerXpath = String.Format("//a[@href='/noutbuki/{0}/']", TestData.manufacturer.ToLower());


        static BaseElement priceBeforeLabel = new BaseElement(By.XPath("//input[@name='price_before']"), "Price Before");
        static BaseElement priceAfterLabel = new BaseElement(By.XPath("//input[@name='price_after']"), "Price Before");
        static BaseElement manufacturerCheckBox = new BaseElement(By.XPath(manufacturerXpath), "Manufacturer CheckBox");
        static BaseElement showButton = new BaseElement(By.XPath("//span[contains(@class, 'ModelFilter__BtnFormSubmit Page__ActiveButtonBg')]"), "Show");
        static BaseElement searchResults = new BaseElement(By.XPath("//div[@class='ModelList']"), "SearchResults");

        public static void StartSearch()
        {
            try
            {
                priceBeforeLabel.MyClick();
                priceBeforeLabel.FillLabel(TestData.priceBefore);
                priceAfterLabel.MyClick();
                priceAfterLabel.FillLabel(TestData.priceAfter);
                manufacturerCheckBox.MyClick();
                showButton.MyClick();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static bool GetSearchResults()
        {
            
            bool check = false;
            int counter = 0;
            try
            {
                foreach (var result in Singleton.GetInstance().FindElements(searchResults.locator))
                {
                    if (result.Text.ToString().ToUpper().Contains(TestData.manufacturer.ToUpper()))
                    {
                        counter++;
                    }
                }

                if (counter == Singleton.GetInstance().FindElements(searchResults.locator).Count)
                {
                    check = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return check;
        }

    }

}
