﻿using System;
using System.Collections.Generic;
using System.Text;

namespace uplink.NET.Models
{
    public class SystemMetadata
    {
        public DateTime Created { get; set; }
        public DateTime Expires { get; set; }
        public long ContentLength { get; set; }

        internal static SystemMetadata FromSWIG(SWIG.SystemMetadata original)
        {
            SystemMetadata ret = new SystemMetadata();
            ret.ContentLength = original.content_length;
            ret.Created = DateTimeOffset.FromUnixTimeSeconds(original.created).ToLocalTime().DateTime;
            ret.Expires = DateTimeOffset.FromUnixTimeSeconds(original.expires).ToLocalTime().DateTime;

            return ret;
        }

        internal static SWIG.SystemMetadata ToSWIG(SystemMetadata original)
        {
            SWIG.SystemMetadata ret = new SWIG.SystemMetadata();
            ret.content_length = original.ContentLength;
            ret.created = new DateTimeOffset(original.Created).ToUnixTimeSeconds();
            ret.expires = new DateTimeOffset(original.Expires).ToUnixTimeSeconds();

            return ret;
        }
    }
}
