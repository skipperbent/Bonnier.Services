using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonnier.Service.IndexSearch
{
	public class ServiceApplication : IndexSearchBase
	{
		public ServiceApplication(string username, string secret)
			: base(username, secret, "auth")
		{

		}

		public ServiceItem Check(string role)
		{
			return (ServiceItem)Api(role);
		}

		protected override ServiceItem OnCreateItem()
		{
			return new ServiceApplication(Username, Secret);
		}

		protected override ServiceResult OnCreateResult()
		{
			return new ServiceResult(Username, Secret);
		}
	}
}
