using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using AutomationTestFramework.Base;


namespace AutomationTests.Pages
{
	class LandingPage : BasePage
	{
		public IWebElement categoryDrpDwn => DriverContext.Driver.FindElement(By.XPath("//div[@id='categoryId-wrp']"));

		public IWebElement chooseCars => DriverContext.Driver.FindElement(By.XPath("//div[@id='categoryId-wrpwrapper']/ul[@class='j-selectbox__ul']/li[6]"));

		public IWebElement searchTxtBox => DriverContext.Driver.FindElement(By.Id("search-query"));

		public IWebElement searchAreaTxtBox => DriverContext.Driver.FindElement(By.Id("search-area"));

		public IWebElement searchRadiusDrpDwn => DriverContext.Driver.FindElement(By.XPath("//div[@id='srch-radius-wrp']"));

		public IWebElement chooseRadius => DriverContext.Driver.FindElement(By.XPath("//div[@id='srch-radius-wrpwrapper']/ul/li[8]"));

		public IWebElement srchBtn => DriverContext.Driver.FindElement(By.XPath("//button[@type='submit']"));

		

		public void ChooseCategory()
		{
			categoryDrpDwn.Click();
			chooseCars.Click();
		}

		public void EnterSearchKeyword(string searchKey)
		{
			searchTxtBox.SendKeys(searchKey);
		}

		public void EnterSearchArea(string searchAreaKey)
		{
			searchAreaTxtBox.SendKeys(searchAreaKey);
		}

		public void ChooseSeachRadius()
		{
			searchRadiusDrpDwn.Click();
			chooseRadius.Click();
		}

		public ResultsPage SubmitSearchButton()
		{
			srchBtn.Submit();
			return new ResultsPage();
		}

		
	}

}
