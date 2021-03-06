﻿using System;
using PayPal.Forms.Abstractions.Enum;
using Newtonsoft.Json;

namespace PayPal.Forms.Abstractions
{
	public class FuturePaymentsResult
	{

		public class Response
		{
			[JsonProperty(PropertyName = "code")]
			public string Code { get; set; }
		}

		public class Client
		{
			[JsonProperty(PropertyName = "paypal_sdk_version")]
			public string PaypalSdkVersion { get; set; }

			[JsonProperty(PropertyName = "environment")]
			public string Environment { get; set; }

			[JsonProperty(PropertyName = "platform")]
			public string Platform { get; set; }

			[JsonProperty(PropertyName = "product_name")]
			public string ProductName { get; set; }
		}

		public class PayPalFuturePaymentsResponse
		{
			[JsonProperty(PropertyName = "response")]
			public Response Response { get; set; }

			[JsonProperty(PropertyName = "client")]
			public Client Client { get; set; }

			[JsonProperty(PropertyName = "response_type")]
			public string ResponseType { get; set; }
		}

		public PayPalStatus Status { get; private set; }

		public string ErrorMessage { get; private set; }

		public PayPalFuturePaymentsResponse ServerResponse { get; private set; }

		public FuturePaymentsResult(PayPalStatus status, string errorMessage = null, PayPalFuturePaymentsResponse serverResponse = null)
		{
			Status = status;
			ErrorMessage = errorMessage;
			ServerResponse = serverResponse;
		}
	}
}

