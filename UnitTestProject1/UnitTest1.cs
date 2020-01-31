using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using AutomationTestFramework.Base;
using AutomationTests.Pages;

namespace AutomationTests
{
	[TestClass]
	public class UnitTest1 : Base
	{
		[TestMethod]
		public void TestMethod1()
		{
			String url = "https://www.gumtree.com.au/";
			DriverContext.Driver = new ChromeDriver();
			DriverContext.Driver.Navigate().GoToUrl(url);
			DriverContext.Driver.Manage().Window.Maximize();
			LandingPage page = new LandingPage();
			page.ChooseCategory();
			page.EnterSearchKeyword("Toyota");
			page.EnterSearchArea("Wollongong Region, NSW");
			page.ChooseSeachRadius();
			CurrentPage = page.SubmitSearchButton();
			int resultCount = CurrentPage.As<ResultsPage>().GetResultsCount();
			Assert.AreEqual(((resultCount).ToString()), CurrentPage.As<ResultsPage>().GetResultsCountLabel(), "Results are not equal");
			CurrentPage.As<ResultsPage>().ClickPage2();
			CurrentPage.As<ResultsPage>().ClickPage3();
			CurrentPage.As<ResultsPage>().ClickPage4();
			CurrentPage = CurrentPage.As<ResultsPage>().ClickAnyAd();
			CurrentPage.As<AdPage>().ClickImgBtn();
			CurrentPage.As<AdPage>().CycleThruAllImages();
			
		}
	}
}
