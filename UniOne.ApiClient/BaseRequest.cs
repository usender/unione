﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;
using Sender.UniOne.ApiClient.Infrastructure.Extensions;

namespace Sender.UniOne.ApiClient
{
    internal abstract class BaseRequest
    {
        /// <summary>
        /// API end part of endpoint
        /// </summary>
        internal abstract ApiEndpoint Endpoint { get; }

        /// <summary>
        /// Key to access the API
        /// </summary>
        [Required]
        [JsonProperty("api_key")]
        internal string ApiKey { get; set; }

        /// <summary>
        /// Returns a string that represents the current object as JSON
        /// </summary>
        public override string ToString()
        {
            return this.ToJson();
        }

        protected internal virtual List<string> Validate()
        {
            var listErrors = new List<string>();

            if (string.IsNullOrWhiteSpace(ApiKey))
                listErrors.Add("Invalid api key");

            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);

            if (!Validator.TryValidateObject(this, context, results, true))
            { 
                listErrors.AddRange(results.Select(x => x.ErrorMessage));
            }

            return listErrors;
        }
    }
}