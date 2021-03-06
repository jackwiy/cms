﻿using System.Collections.Generic;
using SSCMS;
using SSCMS.Dto.Request;

namespace SSCMS.Web.Controllers.Home
{
    public partial class ContentsLayerColumnsController
    {
        public class GetResult
        {
            public List<ContentColumn> Attributes { get; set; }
        }

        public class SubmitRequest : ChannelRequest
        {
            public string AttributeNames { get; set; }
        }
    }
}
