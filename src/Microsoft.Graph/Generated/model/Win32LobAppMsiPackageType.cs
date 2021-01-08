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
    /// The enum Win32LobAppMsiPackageType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum Win32LobAppMsiPackageType
    {
    
        /// <summary>
        /// Per Machine
        /// </summary>
        PerMachine = 0,
	
        /// <summary>
        /// Per User
        /// </summary>
        PerUser = 1,
	
        /// <summary>
        /// Dual Purpose
        /// </summary>
        DualPurpose = 2,
	
    }
}
