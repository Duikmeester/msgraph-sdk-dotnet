// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type MicrosoftStoreForBusinessAppRequest.
    /// </summary>
    public partial class MicrosoftStoreForBusinessAppRequest : BaseRequest, IMicrosoftStoreForBusinessAppRequest
    {
        /// <summary>
        /// Constructs a new MicrosoftStoreForBusinessAppRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MicrosoftStoreForBusinessAppRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MicrosoftStoreForBusinessApp using POST.
        /// </summary>
        /// <param name="microsoftStoreForBusinessAppToCreate">The MicrosoftStoreForBusinessApp to create.</param>
        /// <returns>The created MicrosoftStoreForBusinessApp.</returns>
        public System.Threading.Tasks.Task<MicrosoftStoreForBusinessApp> CreateAsync(MicrosoftStoreForBusinessApp microsoftStoreForBusinessAppToCreate)
        {
            return this.CreateAsync(microsoftStoreForBusinessAppToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MicrosoftStoreForBusinessApp using POST.
        /// </summary>
        /// <param name="microsoftStoreForBusinessAppToCreate">The MicrosoftStoreForBusinessApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MicrosoftStoreForBusinessApp.</returns>
        public async System.Threading.Tasks.Task<MicrosoftStoreForBusinessApp> CreateAsync(MicrosoftStoreForBusinessApp microsoftStoreForBusinessAppToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MicrosoftStoreForBusinessApp>(microsoftStoreForBusinessAppToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified MicrosoftStoreForBusinessApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MicrosoftStoreForBusinessApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MicrosoftStoreForBusinessApp>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MicrosoftStoreForBusinessApp.
        /// </summary>
        /// <returns>The MicrosoftStoreForBusinessApp.</returns>
        public System.Threading.Tasks.Task<MicrosoftStoreForBusinessApp> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MicrosoftStoreForBusinessApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MicrosoftStoreForBusinessApp.</returns>
        public async System.Threading.Tasks.Task<MicrosoftStoreForBusinessApp> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MicrosoftStoreForBusinessApp>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified MicrosoftStoreForBusinessApp using PATCH.
        /// </summary>
        /// <param name="microsoftStoreForBusinessAppToUpdate">The MicrosoftStoreForBusinessApp to update.</param>
        /// <returns>The updated MicrosoftStoreForBusinessApp.</returns>
        public System.Threading.Tasks.Task<MicrosoftStoreForBusinessApp> UpdateAsync(MicrosoftStoreForBusinessApp microsoftStoreForBusinessAppToUpdate)
        {
            return this.UpdateAsync(microsoftStoreForBusinessAppToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MicrosoftStoreForBusinessApp using PATCH.
        /// </summary>
        /// <param name="microsoftStoreForBusinessAppToUpdate">The MicrosoftStoreForBusinessApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MicrosoftStoreForBusinessApp.</returns>
        public async System.Threading.Tasks.Task<MicrosoftStoreForBusinessApp> UpdateAsync(MicrosoftStoreForBusinessApp microsoftStoreForBusinessAppToUpdate, CancellationToken cancellationToken)
        {
			if (microsoftStoreForBusinessAppToUpdate.AdditionalData != null)
			{
				if (microsoftStoreForBusinessAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					microsoftStoreForBusinessAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, microsoftStoreForBusinessAppToUpdate.GetType().Name)
						});
				}
			}
            if (microsoftStoreForBusinessAppToUpdate.AdditionalData != null)
            {
                if (microsoftStoreForBusinessAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    microsoftStoreForBusinessAppToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, microsoftStoreForBusinessAppToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MicrosoftStoreForBusinessApp>(microsoftStoreForBusinessAppToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMicrosoftStoreForBusinessAppRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMicrosoftStoreForBusinessAppRequest Expand(Expression<Func<MicrosoftStoreForBusinessApp, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IMicrosoftStoreForBusinessAppRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMicrosoftStoreForBusinessAppRequest Select(Expression<Func<MicrosoftStoreForBusinessApp, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="microsoftStoreForBusinessAppToInitialize">The <see cref="MicrosoftStoreForBusinessApp"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MicrosoftStoreForBusinessApp microsoftStoreForBusinessAppToInitialize)
        {

        }
    }
}
