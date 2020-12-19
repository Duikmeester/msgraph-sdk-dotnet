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
    /// The type DriveSpecialCollectionRequestBuilder.
    /// </summary>
    public partial class DriveSpecialCollectionRequestBuilder : BaseRequestBuilder, IDriveSpecialCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DriveSpecialCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DriveSpecialCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDriveSpecialCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDriveSpecialCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DriveSpecialCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDriveItemRequestBuilder"/> for the specified DriveDriveItem.
        /// </summary>
        /// <param name="id">The ID for the DriveDriveItem.</param>
        /// <returns>The <see cref="IDriveItemRequestBuilder"/>.</returns>
        public IDriveItemRequestBuilder this[string id]
        {
            get
            {
                return new DriveItemRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
