// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DomainServiceConfigurationRecordsCollectionRequestBuilder.
    /// </summary>
    public partial class DomainServiceConfigurationRecordsCollectionRequestBuilder : BaseRequestBuilder, IDomainServiceConfigurationRecordsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DomainServiceConfigurationRecordsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DomainServiceConfigurationRecordsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDomainServiceConfigurationRecordsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDomainServiceConfigurationRecordsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DomainServiceConfigurationRecordsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDomainDnsRecordRequestBuilder"/> for the specified DomainDomainDnsRecord.
        /// </summary>
        /// <param name="id">The ID for the DomainDomainDnsRecord.</param>
        /// <returns>The <see cref="IDomainDnsRecordRequestBuilder"/>.</returns>
        public IDomainDnsRecordRequestBuilder this[string id]
        {
            get
            {
                return new DomainDnsRecordRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
