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
    /// The type MediaContentRatingNewZealand.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class MediaContentRatingNewZealand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaContentRatingNewZealand"/> class.
        /// </summary>
        public MediaContentRatingNewZealand()
        {
            this.ODataType = "microsoft.graph.mediaContentRatingNewZealand";
        }

        /// <summary>
        /// Gets or sets movieRating.
        /// Movies rating selected for New Zealand. Possible values are: allAllowed, allBlocked, general, parentalGuidance, mature, agesAbove13, agesAbove15, agesAbove16, agesAbove18, restricted, agesAbove16Restricted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "movieRating", Required = Newtonsoft.Json.Required.Default)]
        public RatingNewZealandMoviesType? MovieRating { get; set; }
    
        /// <summary>
        /// Gets or sets tvRating.
        /// TV rating selected for New Zealand. Possible values are: allAllowed, allBlocked, general, parentalGuidance, adults.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tvRating", Required = Newtonsoft.Json.Required.Default)]
        public RatingNewZealandTelevisionType? TvRating { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
