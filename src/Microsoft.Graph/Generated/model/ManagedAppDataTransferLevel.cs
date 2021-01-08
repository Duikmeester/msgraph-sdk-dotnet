// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ManagedAppDataTransferLevel.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ManagedAppDataTransferLevel
    {
    
        /// <summary>
        /// All Apps
        /// </summary>
        AllApps = 0,
	
        /// <summary>
        /// Managed Apps
        /// </summary>
        ManagedApps = 1,
	
        /// <summary>
        /// None
        /// </summary>
        None = 2,
	
    }
}
