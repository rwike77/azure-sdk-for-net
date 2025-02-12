// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Search.Models
{
    internal static partial class SharedPrivateLinkResourceProvisioningStateExtensions
    {
        public static string ToSerialString(this SharedPrivateLinkResourceProvisioningState value) => value switch
        {
            SharedPrivateLinkResourceProvisioningState.Updating => "Updating",
            SharedPrivateLinkResourceProvisioningState.Deleting => "Deleting",
            SharedPrivateLinkResourceProvisioningState.Failed => "Failed",
            SharedPrivateLinkResourceProvisioningState.Succeeded => "Succeeded",
            SharedPrivateLinkResourceProvisioningState.Incomplete => "Incomplete",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SharedPrivateLinkResourceProvisioningState value.")
        };

        public static SharedPrivateLinkResourceProvisioningState ToSharedPrivateLinkResourceProvisioningState(this string value)
        {
            if (string.Equals(value, "Updating", StringComparison.InvariantCultureIgnoreCase)) return SharedPrivateLinkResourceProvisioningState.Updating;
            if (string.Equals(value, "Deleting", StringComparison.InvariantCultureIgnoreCase)) return SharedPrivateLinkResourceProvisioningState.Deleting;
            if (string.Equals(value, "Failed", StringComparison.InvariantCultureIgnoreCase)) return SharedPrivateLinkResourceProvisioningState.Failed;
            if (string.Equals(value, "Succeeded", StringComparison.InvariantCultureIgnoreCase)) return SharedPrivateLinkResourceProvisioningState.Succeeded;
            if (string.Equals(value, "Incomplete", StringComparison.InvariantCultureIgnoreCase)) return SharedPrivateLinkResourceProvisioningState.Incomplete;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SharedPrivateLinkResourceProvisioningState value.");
        }
    }
}
