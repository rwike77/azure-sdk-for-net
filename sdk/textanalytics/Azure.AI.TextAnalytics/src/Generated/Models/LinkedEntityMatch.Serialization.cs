// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    public partial struct LinkedEntityMatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("confidenceScore");
            writer.WriteNumberValue(ConfidenceScore);
            writer.WritePropertyName("text");
            writer.WriteStringValue(Text);
            writer.WritePropertyName("offset");
            writer.WriteNumberValue(Offset);
            writer.WritePropertyName("length");
            writer.WriteNumberValue(Length);
            writer.WriteEndObject();
        }

        internal static LinkedEntityMatch DeserializeLinkedEntityMatch(JsonElement element)
        {
            double confidenceScore = default;
            string text = default;
            int offset = default;
            int length = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("confidenceScore"))
                {
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offset"))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
            }
            return new LinkedEntityMatch(confidenceScore, text, offset, length);
        }
    }
}
