// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class MongoDBRole : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Db))
            {
                writer.WritePropertyName("db");
                writer.WriteStringValue(Db);
            }
            if (Optional.IsDefined(Role))
            {
                writer.WritePropertyName("role");
                writer.WriteStringValue(Role);
            }
            writer.WriteEndObject();
        }

        internal static MongoDBRole DeserializeMongoDBRole(JsonElement element)
        {
            Optional<string> db = default;
            Optional<string> role = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("db"))
                {
                    db = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("role"))
                {
                    role = property.Value.GetString();
                    continue;
                }
            }
            return new MongoDBRole(db.Value, role.Value);
        }
    }
}
