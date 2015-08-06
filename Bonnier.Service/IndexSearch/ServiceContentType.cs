using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonnier.Web.Services.IndexSearch
{
	public class ServiceContentType : IndexSearchBase, IBaseResultProvider<ServiceContentType>
	{
		public ServiceContentType(string username, string secret) : base(username, secret, "auth")
		{

		}

		public ServiceItem Check(string role)
		{
			return (ServiceItem)Api(role);
		}

		protected new IBaseResultProvider<ServiceContentType> OnCreateItem()
		{
			return new ServiceContentType(Username, Secret);
		}

		protected new IBaseResultProvider<ServiceResult> OnCreateResult()
		{
			return new ServiceResult(Username, Secret);
		}
	}
}
