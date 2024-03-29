﻿using Sender.UniOne.ApiClient.Apis;

namespace Sender.UniOne.ApiClient.Unsubscribe
{
    internal class UnsubscribedCheckRequest : UnsubscribedBaseRequest
    {
        internal override ApiEndpoint Endpoint => ApiEndpoint.Unsubscribed.Check;

        public UnsubscribedCheckRequest(string email)
            : base(email)
        {
        }
    }
}
