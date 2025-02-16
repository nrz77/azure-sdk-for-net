// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation.Models
{
    internal partial class TextSourceInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("text");
            writer.WriteStringValue(Text);
            if (Optional.IsDefined(SourceLocale))
            {
                writer.WritePropertyName("sourceLocale");
                writer.WriteStringValue(SourceLocale);
            }
            if (Optional.IsDefined(TargetLocale))
            {
                writer.WritePropertyName("targetLocale");
                writer.WriteStringValue(TargetLocale);
            }
            if (Optional.IsDefined(VoiceGender))
            {
                writer.WritePropertyName("voiceGender");
                writer.WriteStringValue(VoiceGender.Value.ToString());
            }
            if (Optional.IsDefined(VoiceName))
            {
                writer.WritePropertyName("voiceName");
                writer.WriteStringValue(VoiceName);
            }
            writer.WriteEndObject();
        }
    }
}
