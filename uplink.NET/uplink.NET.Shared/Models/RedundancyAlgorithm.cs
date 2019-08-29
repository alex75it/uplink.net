﻿using System;
using System.Collections.Generic;
using System.Text;

namespace uplink.NET.Models
{
    public enum RedundancyAlgorithm
    {
        STORJ_INVALID_REDUNDANCY_ALGORITHM = 0,
        STORJ_REED_SOLOMON = 1
    }

    internal static class RedundancyAlgorithmHelper
    {
        internal static RedundancyAlgorithm FromSWIG(SWIG.RedundancyAlgorithm original)
        {
           return (RedundancyAlgorithm)Enum.Parse(typeof(RedundancyAlgorithm), original.ToString());
        }
    }
}