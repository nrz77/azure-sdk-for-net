// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    internal partial class UnknownRecurrence : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("recurrenceType");
            writer.WriteStringValue(RecurrenceType.ToString());
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime");
                writer.WriteStringValue(StartOn.Value, "T");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime");
                writer.WriteStringValue(EndOn.Value, "T");
            }
            writer.WriteEndObject();
        }

        internal static UnknownRecurrence DeserializeUnknownRecurrence(JsonElement element)
        {
            RecurrenceType recurrenceType = "Unknown";
            Optional<TimeSpan> startTime = default;
            Optional<TimeSpan> endTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recurrenceType"))
                {
                    recurrenceType = new RecurrenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetTimeSpan("T");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetTimeSpan("T");
                    continue;
                }
            }
            return new UnknownRecurrence(recurrenceType, Optional.ToNullable(startTime), Optional.ToNullable(endTime));
        }
    }
}
