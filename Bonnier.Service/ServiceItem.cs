using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Bonnier.Service
{
	public class ServiceItem : RestBase
	{
		public dynamic Row { get; private set; }

		public ServiceItem(string username, string secret) : base(username, secret)
		{

		}

		protected override string GetServiceUrl()
		{
			return String.Empty;
		}

		protected override ServiceItem OnCreateItem()
		{
			return new ServiceItem(Username, Secret);
		}

		protected override ServiceResult OnCreateResult()
		{
			return new ServiceResult(Username, Secret);
		}

		public void SetRow(dynamic row)
		{
			Row = row;
		}
	}
}
