﻿using Sender.UniOne.ApiClient.Apis;
using Sender.UniOne.ApiClient.Common;

namespace Sender.UniOne.ApiClient.Template
{
    internal class TemplateListRequest : PageRequest
    {
        internal override ApiEndpoint Endpoint => ApiEndpoint.Template.List;

        public TemplateListRequest(Page page) 
            : base(page)
        { }
    }
}
