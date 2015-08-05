using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonnier.Service.IndexSearch
{
	public class ServiceAuth : IndexSearchBase, IResultType<ServiceAuth>
	{
		public ServiceAuth(string username, string secret)
			: base(username, secret, "auth")
		{

		}

		public ServiceItem Check(string role)
		{
			return (ServiceItem)Api(role);
		}

		protected IResultType<ServiceAuth> OnCreateItem()
		{
			return new ServiceAuth(Username, Secret);
		}

		protected IResultType<ServiceResult> OnCreateResult()
		{
			return new ServiceResult(Username, Secret);
		}
	}
}
