// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Mail Assessment Request.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MailAssessmentRequestObject : ThreatAssessmentRequestObject
    {
    
		///<summary>
		/// The MailAssessmentRequest constructor
		///</summary>
        public MailAssessmentRequestObject()
        {
            this.ODataType = "microsoft.graph.mailAssessmentRequest";
        }
	
        /// <summary>
        /// Gets or sets destination routing reason.
        /// The reason for mail routed to its destination. Possible values are: none, mailFlowRule, safeSender, blockedSender, advancedSpamFiltering, domainAllowList, domainBlockList, notInAddressBook, firstTimeSender, autoPurgeToInbox, autoPurgeToJunk, autoPurgeToDeleted, outbound, notJunk, junk.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationRoutingReason", Required = Newtonsoft.Json.Required.Default)]
        public MailDestinationRoutingReason? DestinationRoutingReason { get; set; }
    
        /// <summary>
        /// Gets or sets message uri.
        /// The resource URI of the mail message for assessment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "messageUri", Required = Newtonsoft.Json.Required.Default)]
        public string MessageUri { get; set; }
    
        /// <summary>
        /// Gets or sets recipient email.
        /// The mail recipient whose policies are used to assess the mail.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipientEmail", Required = Newtonsoft.Json.Required.Default)]
        public string RecipientEmail { get; set; }
    
    }
}

