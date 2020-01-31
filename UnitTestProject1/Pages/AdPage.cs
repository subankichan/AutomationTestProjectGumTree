using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTestFramework.Base;
using OpenQA.Selenium;

namespace AutomationTests.Pages
{
	class AdPage : BasePage
	{
		public IWebElement imgBtn => DriverContext.Driver.FindElement(By.XPath("//div[@class='vip-ad-image__legend']/button"));

		public IWebElement imgNavigationBtn => DriverContext.Driver.FindElement(By.XPath("//div[@class='vip-ad-gallery__controls']/button[2]"));

		public void ClickImgBtn()
		{
			imgBtn.Click();
			System.Threading.Thread.Sleep(3000);
		}

		public void CycleThruAllImages()
		{
			while (imgNavigationBtn.Displayed)
			{
				imgNavigationBtn.Click();
			}
		}

	}
}
