using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonnier.Web.Services.Trapp
{
	public abstract class TrappBase : ServiceItem
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
