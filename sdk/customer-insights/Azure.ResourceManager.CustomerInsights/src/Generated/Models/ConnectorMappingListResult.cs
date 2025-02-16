// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The response of list connector mapping operation. </summary>
    internal partial class ConnectorMappingListResult
    {
        /// <summary> Initializes a new instance of ConnectorMappingListResult. </summary>
        internal ConnectorMappingListResult()
        {
            Value = new ChangeTrackingList<ConnectorMappingResourceFormatData>();
        }

        /// <summary> Initializes a new instance of ConnectorMappingListResult. </summary>
        /// <param name="value"> Results of the list operation. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        internal ConnectorMappingListResult(IReadOnlyList<ConnectorMappingResourceFormatData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of the list operation. </summary>
        public IReadOnlyList<ConnectorMappingResourceFormatData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
