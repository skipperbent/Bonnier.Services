using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonnier.Web.Services.IndexSearch.Content
{
	public class ContentCollection : IndexSearchBase
	{

		public ContentCollection(string username, string secret, string type) : base(username, secret, type) {

		}


		public ContentCollection execute() {
			return (ContentCollection)Api ();
		}
	}
}
