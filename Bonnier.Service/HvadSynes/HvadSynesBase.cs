using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonnier.Web.Services.HvadSynes
{
	public abstract class HvadSynesBase : ServiceItem
	{
		public bool Development { get; set; }
		private readonly string _type;
		protected TrappBase(string username, string secret, string type) : base(username, secret)
		{
			_type = type;
		}

		protected override string GetServiceUrl()
		{
			return "http://local.trapp.dk/api/v1/" + _type;
		}
	}
}
