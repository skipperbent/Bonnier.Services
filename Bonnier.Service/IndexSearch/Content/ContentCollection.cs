using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonnier.Web.Services.IndexSearch.Content
{
	public class ContentCollection : IndexSearchBase
	{
		private readonly Dictionary<string, string> _data;
		public ContentCollection(string username, string secret, string type) : base(username, secret, type) {
			_data = new Dictionary<string, string>();
		}

		public ContentCollection Execute() {
			return (ContentCollection)Api (Method.Get, UrlencodeDictionary(_data));
		}
	}
}
