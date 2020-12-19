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
    /// The enum SharedPCAllowedAccountType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
	[System.Flags]
    public enum SharedPCAllowedAccountType
    {
    
        /// <summary>
        /// Guest
        /// </summary>
        Guest = 1,
	
        /// <summary>
        /// Domain
        /// </summary>
        Domain = 2,
	
    }
}
