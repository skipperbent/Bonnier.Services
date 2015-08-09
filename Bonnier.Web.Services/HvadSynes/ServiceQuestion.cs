using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bonnier.Web.Services.HvadSynes.Question;
using Bonnier.Web.Services.IndexSearch.Content;

namespace Bonnier.Web.Services.HvadSynes
{
	public class ServiceQuestion : RestBase
	{
		public bool Development { get; set; }

		public ServiceQuestion(string username, string secret) : base(username, secret)
		{
			
		}

		protected override string GetServiceUrl()
		{
			// TODO: add "real url" and make use of "Development" property
			return "http://52.19.1.159/question/";
		}

		public QuestionCollection GetCollection()
		{
			return new QuestionCollection(Username, Secret);
		}

		public ServiceItem GetById(string id)
		{
			return (ServiceItem)Api(id);
		}

		protected new ServiceQuestion OnCreateItem()
		{
			return new ServiceQuestion(Username, Secret);
		}

		protected new QuestionCollection OnCreateResult()
		{
			return new QuestionCollection(Username, Secret);
		}
	}
}
