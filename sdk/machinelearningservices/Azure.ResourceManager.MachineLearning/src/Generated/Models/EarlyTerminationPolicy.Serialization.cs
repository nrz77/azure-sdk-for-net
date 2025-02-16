// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class EarlyTerminationPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DelayEvaluation))
            {
                writer.WritePropertyName("delayEvaluation");
                writer.WriteNumberValue(DelayEvaluation.Value);
            }
            if (Optional.IsDefined(EvaluationInterval))
            {
                writer.WritePropertyName("evaluationInterval");
                writer.WriteNumberValue(EvaluationInterval.Value);
            }
            writer.WritePropertyName("policyType");
            writer.WriteStringValue(PolicyType.ToString());
            writer.WriteEndObject();
        }

        internal static EarlyTerminationPolicy DeserializeEarlyTerminationPolicy(JsonElement element)
        {
            if (element.TryGetProperty("policyType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Bandit": return BanditPolicy.DeserializeBanditPolicy(element);
                    case "MedianStopping": return MedianStoppingPolicy.DeserializeMedianStoppingPolicy(element);
                    case "TruncationSelection": return TruncationSelectionPolicy.DeserializeTruncationSelectionPolicy(element);
                }
            }
            return UnknownEarlyTerminationPolicy.DeserializeUnknownEarlyTerminationPolicy(element);
        }
    }
}
