// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> IPTag associated with the object. </summary>
    public partial class ManagedClusterIPTag
    {
        /// <summary> Initializes a new instance of ManagedClusterIPTag. </summary>
        /// <param name="ipTagType"> The IP tag type. </param>
        /// <param name="tag"> The value of the IP tag. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipTagType"/> or <paramref name="tag"/> is null. </exception>
        public ManagedClusterIPTag(string ipTagType, string tag)
        {
            if (ipTagType == null)
            {
                throw new ArgumentNullException(nameof(ipTagType));
            }
            if (tag == null)
            {
                throw new ArgumentNullException(nameof(tag));
            }

            IPTagType = ipTagType;
            Tag = tag;
        }

        /// <summary> The IP tag type. </summary>
        public string IPTagType { get; set; }
        /// <summary> The value of the IP tag. </summary>
        public string Tag { get; set; }
    }
}
