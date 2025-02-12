// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The list usages operation response. </summary>
    internal partial class UsagesListResult
    {
        /// <summary> Initializes a new instance of UsagesListResult. </summary>
        internal UsagesListResult()
        {
            Value = new ChangeTrackingList<FrontDoorUsage>();
        }

        /// <summary> Initializes a new instance of UsagesListResult. </summary>
        /// <param name="value"> The list of resource usages. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        internal UsagesListResult(IReadOnlyList<FrontDoorUsage> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of resource usages. </summary>
        public IReadOnlyList<FrontDoorUsage> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
