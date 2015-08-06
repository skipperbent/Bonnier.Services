using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bonnier.Web.Services;
using Bonnier.Web.Services.IndexSearch;

namespace Test
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			var service = new ServiceContent("netTest", "A11555640D4747A5B27B46333260F2F3");
			service.Development = true;

			var item = service.GetById("576FF4FF07534BDB185B673F100D3EE3");

			var test = "test";

			/*var results = service.Get();

			foreach (var result in results.GetRows())
			{
				var title = result.Row.title;
			}*/

		}
	}
}