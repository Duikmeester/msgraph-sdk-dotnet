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
    /// The enum TeamsAppDistributionMethod.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TeamsAppDistributionMethod
    {
    
        /// <summary>
        /// Store
        /// </summary>
        Store = 0,
	
        /// <summary>
        /// Organization
        /// </summary>
        Organization = 1,
	
        /// <summary>
        /// Sideloaded
        /// </summary>
        Sideloaded = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 3,
	
    }
}
