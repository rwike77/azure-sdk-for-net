// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Quota availability request content. </summary>
    public partial class NetAppQuotaAvailabilityContent
    {
        /// <summary> Initializes a new instance of NetAppQuotaAvailabilityContent. </summary>
        /// <param name="name"> Name of the resource to verify. </param>
        /// <param name="availabilityResourceType"> Resource type used for verification. </param>
        /// <param name="resourceGroup"> Resource group name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="resourceGroup"/> is null. </exception>
        public NetAppQuotaAvailabilityContent(string name, NetAppQuotaAvailabilityResourceType availabilityResourceType, string resourceGroup)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }

            Name = name;
            AvailabilityResourceType = availabilityResourceType;
            ResourceGroup = resourceGroup;
        }

        /// <summary> Name of the resource to verify. </summary>
        public string Name { get; }
        /// <summary> Resource type used for verification. </summary>
        public NetAppQuotaAvailabilityResourceType AvailabilityResourceType { get; }
        /// <summary> Resource group name. </summary>
        public string ResourceGroup { get; }
    }
}
