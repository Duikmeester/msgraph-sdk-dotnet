// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ChannelTabsCollectionRequestBuilder.
    /// </summary>
    public partial class ChannelTabsCollectionRequestBuilder : BaseRequestBuilder, IChannelTabsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ChannelTabsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ChannelTabsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IChannelTabsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IChannelTabsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ChannelTabsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITeamsTabRequestBuilder"/> for the specified ChannelTeamsTab.
        /// </summary>
        /// <param name="id">The ID for the ChannelTeamsTab.</param>
        /// <returns>The <see cref="ITeamsTabRequestBuilder"/>.</returns>
        public ITeamsTabRequestBuilder this[string id]
        {
            get
            {
                return new TeamsTabRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}