using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace Bonnier.Service
{
	public class ServiceResult : RestBase
	{
		List<ServiceItem> _rows;
		public string Response { get; set; }

		public ServiceResult(string username, string secret) : base(username, secret)
		{
			_rows = new List<ServiceItem>();
		}

		public List<ServiceItem> GetRows()
		{
			return _rows;
		}

		public void SetRows(List<ServiceItem> rows)
		{
			_rows = rows;
		}
		

		/*public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
		{

			var paramList = new Dictionary<string, object>();
			int i = 0;
			foreach (object obj in args)
			{
				string name = binder.CallInfo.ArgumentNames.Count > i ? binder.CallInfo.ArgumentNames[i] : ("param" + i);
				paramList.Add(name, obj);
				i++;
			}
			WriteCall(binder.Name, paramList);
			result = null;
			return true;
		}

		public void WriteCall(string name, Dictionary<string, object> paramList)
		{
			Console.WriteLine("Executing: {0}", name);
			foreach (string key in paramList.Keys)
			{
				Console.WriteLine("\t{0}: {1}", key, paramList[key]);
			}
		}*/
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
	}
}
