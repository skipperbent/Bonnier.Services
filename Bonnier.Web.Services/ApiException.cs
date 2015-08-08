using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bonnier.Web.Services
{
	public class ApiException : Exception
	{
		public int ErrorCode { get; private set; }
		public ApiException()
		{
		}

		public ApiException(string message) : base(message)
		{
		}

		public ApiException(string message, int errorCode) : base(message)
		{
			ErrorCode = errorCode;
		}
	}
}
