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

		public List<ServiceItem> Get()
		{
			return (List<ServiceItem>)Api();
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
