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
        static BaseElement qSearchButton = new BaseElement(By.XPath("//a[contains(@aria-label, 'q.Search')]"), "Q.SEARCH");
        static BaseElement xButton = new BaseElement(By.XPath("//div[@id='xbutton']"), "x Button");

        public static void GoToTheSearchPage()
        {
            String currentWindow = Singleton.GetInstance().CurrentWindowHandle;

            if (!qSearchButton.GetElement().Enabled)
            {
                xButton.MyClick();
            }
            qSearchButton.MyClick();      

            foreach(String winHandle in Singleton.GetInstance().WindowHandles)
            {
                 if(currentWindow != winHandle)
                 {                     
                     Singleton.GetInstance().SwitchTo().Window(winHandle);
                     Singleton.GetInstance().SwitchTo().Frame("contentFrame");
                 }
            }               
        }
    }
}
