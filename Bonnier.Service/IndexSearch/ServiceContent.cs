using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonnier.Service.IndexSearch
{
	public class ServiceContent : IndexSearchBase
	{
		public ServiceContent(string username, string secret)
			: base(username, secret, "content")
		{
			
		}

		public ServiceResult Get()
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

		protected override ServiceItem OnCreateItem()
		{
			return new ServiceContent(Username, Secret);
		}

		protected override ServiceResult OnCreateResult()
		{
			return new ServiceResult(Username, Secret);
		}
	}
}
