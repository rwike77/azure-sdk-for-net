// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> A privately linkable resource properties. </summary>
    public partial class PurviewPrivateLinkResourceProperties
    {
        /// <summary> Initializes a new instance of PurviewPrivateLinkResourceProperties. </summary>
        internal PurviewPrivateLinkResourceProperties()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of PurviewPrivateLinkResourceProperties. </summary>
        /// <param name="groupId"> The private link resource group identifier. </param>
        /// <param name="requiredMembers"> This translates to how many Private IPs should be created for each privately linkable resource. </param>
        /// <param name="requiredZoneNames"> The required zone names for private link resource. </param>
        internal PurviewPrivateLinkResourceProperties(string groupId, IReadOnlyList<string> requiredMembers, IReadOnlyList<string> requiredZoneNames)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary> The private link resource group identifier. </summary>
        public string GroupId { get; }
        /// <summary> This translates to how many Private IPs should be created for each privately linkable resource. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> The required zone names for private link resource. </summary>
        public IReadOnlyList<string> RequiredZoneNames { get; }
    }
}
