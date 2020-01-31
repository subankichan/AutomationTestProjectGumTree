using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTestFramework.Base;
using OpenQA.Selenium;

namespace AutomationTests.Pages
{
	class ResultsPage : BasePage
	{
		public IList<IWebElement> resultsList => DriverContext.Driver.FindElements(By.XPath("//div[@class='panel search-results-page__main-ads-wrapper user-ad-collection user-ad-collection--row']/div[2]/a"));

		public IWebElement resultLable = DriverContext.Driver.FindElement(By.XPath("//div[@class='results-per-page-selector']/div/select"));

		public IWebElement page2Navigation => DriverContext.Driver.FindElement(By.XPath("//div[@class='page-number-navigation']/a[2]"));

		public IWebElement page3Navigation => DriverContext.Driver.FindElement(By.XPath("//div[@class='page-number-navigation']/a[3]"));

		public IWebElement page4Navigation => DriverContext.Driver.FindElement(By.XPath("//div[@class='page-number-navigation']/a[4]"));

		public IList<IWebElement> adListings = DriverContext.Driver.FindElements(By.XPath("//div[@class='panel search-results-page__top-ads-wrapper user-ad-collection user-ad-collection--row']/div[2]/a"));

		public int GetResultsCount()
		{
			return resultsList.Count();
		}

		public string GetResultsCountLabel()
		{
			string Result = resultLable.Text;
			Result = Result.Substring(0, 2);
			return Result;
		}

		public void ClickPage2()
		{
			page2Navigation.Click();
			Console.WriteLine("Clicked Page 2");
			System.Threading.Thread.Sleep(2000);
		}

		public void ClickPage3()
		{
			page3Navigation.Click();
			Console.WriteLine("Clicked Page 3");
			System.Threading.Thread.Sleep(2000);
		}

		public void ClickPage4()
		{
			page4Navigation.Click();
			Console.WriteLine("Clicked Page 4");
			System.Threading.Thread.Sleep(2000);
		}

		public AdPage ClickAnyAd()
		{

			Random r = new Random();
			int randomValue = 1;
			randomValue = r.Next(randomValue, adListings.Count());
			IWebElement adListAny = DriverContext.Driver.FindElement(By.XPath("//div[@class='panel search-results-page__top-ads-wrapper user-ad-collection user-ad-collection--row']/div[2]/a[" + randomValue + "]"));
			adListAny.Click();
			return new AdPage();
		}
	}
}
