﻿using Newtonsoft.Json;

namespace Sender.UniOne.ApiClient.Domain
{
    public class ValidateVerificationResponse : BaseResponse
    {
        /// <summary>
        /// Debug message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; internal set; }
    }
}
