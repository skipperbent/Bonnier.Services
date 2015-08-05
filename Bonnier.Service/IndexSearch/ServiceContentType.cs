using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonnier.Service.IndexSearch
{
	public class ServiceContentType : IndexSearchBase, IResultType<ServiceContentType>
	{
		public ServiceContentType(string username, string secret) : base(username, secret, "auth")
		{

		}

		public ServiceItem Check(string role)
		{
			return (ServiceItem)Api(role);
		}

		protected new IResultType<ServiceContentType> OnCreateItem()
		{
			return new ServiceContentType(Username, Secret);
		}

		protected new IResultType<ServiceResult> OnCreateResult()
		{
			return new ServiceResult(Username, Secret);
		}
	}
}
