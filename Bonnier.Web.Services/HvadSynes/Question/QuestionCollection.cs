using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonnier.Web.Services.HvadSynes.Question
{
	public class QuestionCollection : ServiceQuestion
	{
		private readonly Dictionary<string, string> _data;
		public QuestionCollection(string username, string secret) : base(username, secret) {
			_data = new Dictionary<string, string>();
		}


		public QuestionCollection Execute() {
			return (QuestionCollection)Api (Method.Get, UrlencodeDictionary(_data));
		}

		public void Skip(int skip)
		{
			_data["skip"] = skip.ToString();
		}

		public void Limit(int limit)
		{
			_data["limit"] = limit.ToString();
		}

		public void Order(string order)
		{
			_data["order"] = order;
		}
	}
}
