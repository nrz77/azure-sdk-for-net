// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Paged Gateway hostname configuration list representation. </summary>
    internal partial class GatewayHostnameConfigurationListResult
    {
        /// <summary> Initializes a new instance of GatewayHostnameConfigurationListResult. </summary>
        internal GatewayHostnameConfigurationListResult()
        {
            Value = new ChangeTrackingList<ApiManagementGatewayHostnameConfigurationData>();
        }

        /// <summary> Initializes a new instance of GatewayHostnameConfigurationListResult. </summary>
        /// <param name="value"> Page values. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        internal GatewayHostnameConfigurationListResult(IReadOnlyList<ApiManagementGatewayHostnameConfigurationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Page values. </summary>
        public IReadOnlyList<ApiManagementGatewayHostnameConfigurationData> Value { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}
