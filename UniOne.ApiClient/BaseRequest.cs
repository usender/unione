﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Sender.UniOne.ApiClient.Apis;
using Sender.UniOne.ApiClient.Infrastructure.Extensions;

namespace Sender.UniOne.ApiClient
{
    internal abstract class BaseRequest
    {
        internal abstract ApiAction ApiAction { get; }

        /// <summary>
        /// Key to access the API
        /// </summary>
        [JsonProperty("api_key")]
        internal string ApiKey { get; set; }

        /// <summary>
        /// Returns a string that represents the current object as JSON
        /// </summary>
        public override string ToString()
        {
            return this.ToJson();
        }

        protected internal virtual void Validate()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);

            if (!Validator.TryValidateObject(this, context, results, true))
            {
                throw new ValidationException(results[0].ErrorMessage);
            }
        }
    }
}