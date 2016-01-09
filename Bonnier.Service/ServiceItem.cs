﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Bonnier.Web.Services
{
	public class ServiceItem : RestBase, IBaseResultProvider<ServiceItem>
	{
		public dynamic Row { get; private set; }

		public ServiceItem(string username, string secret) : base(username, secret)
		{
			Row = new ExpandoObject();
		}

		protected override string GetServiceUrl()
		{
			return String.Empty;
		}

		protected new IBaseResultProvider<ServiceItem> OnCreateItem()
		{
			return new ServiceItem(Username, Secret);
		}

		protected new IBaseResultProvider<ServiceResult> OnCreateResult()
		{
			return new ServiceResult(Username, Secret);
		}

		public void SetRow(dynamic row)
		{
			Row = row;
		}

		public void Update()
		{
			this.Row = ((ServiceItem)Api(this.Row.id, Method.Put, GetRowArray())).Row;
		}

		public void Save()
		{
			this.Row = ((ServiceItem)Api(Method.Post, GetRowArray())).Row;
		}
	}
}