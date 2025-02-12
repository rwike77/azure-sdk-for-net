// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> The DatadogAgreementResource. </summary>
    public partial class DatadogAgreementResource : ResourceData
    {
        /// <summary> Initializes a new instance of DatadogAgreementResource. </summary>
        public DatadogAgreementResource()
        {
        }

        /// <summary> Initializes a new instance of DatadogAgreementResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Represents the properties of the resource. </param>
        internal DatadogAgreementResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DatadogAgreementProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Represents the properties of the resource. </summary>
        public DatadogAgreementProperties Properties { get; set; }
    }
}
