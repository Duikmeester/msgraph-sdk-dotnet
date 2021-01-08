// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsSumSqRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsSumSqRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsSumSqRequest>, IWorkbookFunctionsSumSqRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsSumSqRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="values">A values parameter for the OData method call.</param>
        public WorkbookFunctionsSumSqRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken values)
            : base(requestUrl, client)
        {
            this.SetParameter("values", values, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsSumSqRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsSumSqRequest(functionUrl, this.Client, options);

            if (this.HasParameter("values"))
            {
                request.RequestBody.Values = this.GetParameter<Newtonsoft.Json.Linq.JToken>("values");
            }

            return request;
        }
    }
}
