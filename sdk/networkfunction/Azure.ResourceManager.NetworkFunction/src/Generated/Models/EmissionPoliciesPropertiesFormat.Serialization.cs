// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkFunction.Models
{
    public partial class EmissionPoliciesPropertiesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EmissionType))
            {
                writer.WritePropertyName("emissionType");
                writer.WriteStringValue(EmissionType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(EmissionDestinations))
            {
                writer.WritePropertyName("emissionDestinations");
                writer.WriteStartArray();
                foreach (var item in EmissionDestinations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static EmissionPoliciesPropertiesFormat DeserializeEmissionPoliciesPropertiesFormat(JsonElement element)
        {
            Optional<EmissionType> emissionType = default;
            Optional<IList<EmissionPolicyDestination>> emissionDestinations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("emissionType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    emissionType = new EmissionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("emissionDestinations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EmissionPolicyDestination> array = new List<EmissionPolicyDestination>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EmissionPolicyDestination.DeserializeEmissionPolicyDestination(item));
                    }
                    emissionDestinations = array;
                    continue;
                }
            }
            return new EmissionPoliciesPropertiesFormat(Optional.ToNullable(emissionType), Optional.ToList(emissionDestinations));
        }
    }
}
