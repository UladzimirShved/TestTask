using System.IO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;


namespace Task2
{
    public static class LoginPage
    {       
        static BaseElement loginBar = new BaseElement(By.XPath("//input[@name='loginfmt']"), "Login Bar");
        static BaseElement nextButton = new BaseElement(By.XPath("//input[@id='idSIButton9']"), "Next Button");
        static BaseElement passwordBar = new BaseElement(By.XPath("//input[@name='passwd']"), "Password Bar");
        static BaseElement loginButton = new BaseElement(By.XPath("//input[@id='idSIButton9']"), "Login Button");
        static BaseElement noButton = new BaseElement(By.XPath("//input[@id='idBtn_Back']"), "No Button");
        

        public static void Login()
        {      
            loginBar.FillLabel(TestData.login);
            nextButton.MyClick();
            loginBar.waitUntilElementInvisible();
            passwordBar.FillLabel(TestData.password);           
            loginButton.MyClick();           
            noButton.MyClick();            
        }
    }
}
