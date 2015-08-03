using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bonnier.Service;
using Bonnier.Service.IndexSearch;

namespace Test
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			var service = new ServiceContent("netTest", "A11555640D4747A5B27B46333260F2F3");
			service.Development = true;

			var results = service.Get();

			foreach (ServiceItem result in results)
			{
				var title = result.Row.title;
			}

		}
	}
}