using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonnier.Web.Services.HvadSynes.Content
{
	public class ContentCollection : ServiceHvadSynes
	{
		private Dictionary<string, string> _data = new Dictionary<string, string>();

		public ContentCollection(string username, string secret) : base(username, secret) {

		}

		public ContentCollection execute() {
			return (ContentCollection)Api();
		}

		public void Order(string order) {
			_data ["order"] = order;
		}
	}
}
