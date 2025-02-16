// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> The properties of a resource currently being monitored by the Datadog monitor resource. </summary>
    public partial class MonitoredResource
    {
        /// <summary> Initializes a new instance of MonitoredResource. </summary>
        internal MonitoredResource()
        {
        }

        /// <summary> Initializes a new instance of MonitoredResource. </summary>
        /// <param name="id"> The ARM id of the resource. </param>
        /// <param name="sendingMetrics"> Flag indicating if resource is sending metrics to Datadog. </param>
        /// <param name="reasonForMetricsStatus"> Reason for why the resource is sending metrics (or why it is not sending). </param>
        /// <param name="sendingLogs"> Flag indicating if resource is sending logs to Datadog. </param>
        /// <param name="reasonForLogsStatus"> Reason for why the resource is sending logs (or why it is not sending). </param>
        internal MonitoredResource(string id, bool? sendingMetrics, string reasonForMetricsStatus, bool? sendingLogs, string reasonForLogsStatus)
        {
            Id = id;
            SendingMetrics = sendingMetrics;
            ReasonForMetricsStatus = reasonForMetricsStatus;
            SendingLogs = sendingLogs;
            ReasonForLogsStatus = reasonForLogsStatus;
        }

        /// <summary> The ARM id of the resource. </summary>
        public string Id { get; }
        /// <summary> Flag indicating if resource is sending metrics to Datadog. </summary>
        public bool? SendingMetrics { get; }
        /// <summary> Reason for why the resource is sending metrics (or why it is not sending). </summary>
        public string ReasonForMetricsStatus { get; }
        /// <summary> Flag indicating if resource is sending logs to Datadog. </summary>
        public bool? SendingLogs { get; }
        /// <summary> Reason for why the resource is sending logs (or why it is not sending). </summary>
        public string ReasonForLogsStatus { get; }
    }
}
