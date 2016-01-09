using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonnier.Web.Services.IndexSearch.Content
{
	public class ContentCollection : IndexSearchBase
	{
		private Dictionary<string, string> _data = new Dictionary<string, string>();

		public ContentCollection(string username, string secret, string type) : base(username, secret, type) {

		}
			
		public ContentCollection execute() {
			return (ContentCollection)Api ();
		}
	}
}
