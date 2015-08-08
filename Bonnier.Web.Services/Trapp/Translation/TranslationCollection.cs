using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonnier.Web.Services.Trapp.Translation
{
	public class TranslationCollection : TrappBase
	{
		private readonly Dictionary<string, string> _data;
		public TranslationCollection(string username, string secret, string type) : base(username, secret, type) {
			_data = new Dictionary<string, string>();
		}

		public TranslationCollection Execute()
		{
			return (TranslationCollection)Api(Method.Get, UrlencodeDictionary(_data));
		}
	}
}
