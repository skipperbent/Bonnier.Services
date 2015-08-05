using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bonnier.Service.IndexSearch.Content;

namespace Bonnier.Service.IndexSearch
{
	public class ServiceContent : IndexSearchBase
	{
		public ServiceContent(string username, string secret)
			: base(username, secret, "content")
		{
			
		}

		public ServiceResult GetCollection()
		{
			return (ServiceResult)Api();
		}

		public ServiceItem GetById(string id)
		{
			return (ServiceItem)Api(id);
		}

		public ServiceItem Delete(string id)
		{
			return (ServiceItem) Api(id, Method.Delete);
		}

		protected new ServiceItem OnCreateItem()
		{
			return new ServiceContent(Username, Secret);
		}

		protected new ContentCollection OnCreateResult()
		{
			return new ContentCollection(Username, Secret, _type);
		}
	}
}
