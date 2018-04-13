using System.IO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class SearchPage
    {
        static BaseElement nameBar = new BaseElement(By.XPath("//*[@id='CompanyTextBox']"), "Name");
        static BaseElement searchButton = new BaseElement(By.XPath("//input[@name='SearchBtn']"), "Search Button");
        static BaseElement firstResult = new BaseElement(By.XPath("//tr[@id='1']"), "First Result");
        static BaseElement popup = new BaseElement(By.XPath("//*[contains(text(), 'Processing')]"), "Pop Up");

        public static void StartSearch()
        { 
            Singleton.GetInstance().Manage().Window.Maximize();          
                       
            nameBar.MyClick();
            nameBar.FillLabel(Files.ReadFromFile());
            searchButton.MyClick();
            popup.waitUntilElementInvisible();
        }

        public static string GetSearchResults()
        {
            string searchResults = "";

            foreach (var row in Singleton.GetInstance().FindElements(firstResult.locator))
            {                  
               searchResults = searchResults + row.Text.ToString();
            }
            return searchResults;
        }

    }

}
