using System.IO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;

namespace Task2.Pages
{
    public static class MainPage
    {
        static BaseElement computersButton = new BaseElement(By.XPath("//span[@title='Компьютеры']"), "Computers");
        static BaseElement noutbukiButton = new BaseElement(By.XPath("//a[@class='VisitSection__LinkRecipesName'][@href='/noutbuki/']"), "Noutbuki");

        public static void GoToTheSearchPage()
        {
            try
            {
                computersButton.MyClick();
                noutbukiButton.MyClick();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
