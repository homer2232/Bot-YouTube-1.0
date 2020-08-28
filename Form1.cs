using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        IWebDriver Browser;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://www.youtube.com/");

            IWebElement searchElement = Browser.FindElement(By.LinkText("В тренде"));
            searchElement.Click();
            //sleep for download page
            Thread.Sleep(3000);

            List<IWebElement> searchElementie = Browser.FindElements(By.CssSelector("#thumbnail")).ToList();
            searchElementie[26].Click();

            Thread.Sleep(3000);

            List<IWebElement> searchLike = Browser.FindElements(By.CssSelector("yt-icon")).ToList();
            searchLike[99].Click();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Browser.Quit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://www.youtube.com/");

            IWebElement searchElement = Browser.FindElement(By.LinkText("В тренде"));
            searchElement.Click();

            Thread.Sleep(3000);

            List<IWebElement> searchElementie = Browser.FindElements(By.CssSelector("#thumbnail")).ToList();
            searchElementie[33].Click();

            Thread.Sleep(3000);
            //scroll page
            IJavaScriptExecutor js = (IJavaScriptExecutor)Browser;
            js.ExecuteScript("window.scrollTo(5, 200);");

            Thread.Sleep(3000);

            IWebElement searchSpace = Browser.FindElement(By.Id("simplebox-placeholder"));
            searchSpace.Click();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://www.youtube.com/");

            Thread.Sleep(2000);

            List<IWebElement> searchSpaceText = Browser.FindElements(By.Id("search")).ToList();
            searchSpaceText[3].SendKeys("kaspersky" + OpenQA.Selenium.Keys.Enter);

        }
    }
}
