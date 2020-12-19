// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type IPv4Range.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IPv4Range : IpRange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IPv4Range"/> class.
        /// </summary>
        public IPv4Range()
        {
            this.ODataType = "microsoft.graph.iPv4Range";
        }

        /// <summary>
        /// Gets or sets lowerAddress.
        /// Lower address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lowerAddress", Required = Newtonsoft.Json.Required.Default)]
        public string LowerAddress { get; set; }
    
        /// <summary>
        /// Gets or sets upperAddress.
        /// Upper address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "upperAddress", Required = Newtonsoft.Json.Required.Default)]
        public string UpperAddress { get; set; }
    
    }
}
