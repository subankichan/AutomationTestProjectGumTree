using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestFramework.Base
{
	public class Base
	{
		public BasePage CurrentPage { get; set; }

		//	private IWebDriver _driver;

		protected TPage GetInstance<TPage>() where TPage : BasePage, new()

		{

			return (TPage)Activator.CreateInstance(typeof(TPage));
			

		}

		public TPage As<TPage>() where TPage : BasePage
		{
			return (TPage)this;
		}
	}
}
