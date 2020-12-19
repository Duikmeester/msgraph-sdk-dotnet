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
    /// The type UserTeamworkInstalledAppsCollectionRequestBuilder.
    /// </summary>
    public partial class UserTeamworkInstalledAppsCollectionRequestBuilder : BaseRequestBuilder, IUserTeamworkInstalledAppsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UserTeamworkInstalledAppsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserTeamworkInstalledAppsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserTeamworkInstalledAppsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserTeamworkInstalledAppsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserTeamworkInstalledAppsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IUserScopeTeamsAppInstallationRequestBuilder"/> for the specified UserTeamworkUserScopeTeamsAppInstallation.
        /// </summary>
        /// <param name="id">The ID for the UserTeamworkUserScopeTeamsAppInstallation.</param>
        /// <returns>The <see cref="IUserScopeTeamsAppInstallationRequestBuilder"/>.</returns>
        public IUserScopeTeamsAppInstallationRequestBuilder this[string id]
        {
            get
            {
                return new UserScopeTeamsAppInstallationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
