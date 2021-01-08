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
    /// The type WorkbookFunctionsWorkDayRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsWorkDayRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsWorkDayRequest>, IWorkbookFunctionsWorkDayRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsWorkDayRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="startDate">A startDate parameter for the OData method call.</param>
        /// <param name="days">A days parameter for the OData method call.</param>
        /// <param name="holidays">A holidays parameter for the OData method call.</param>
        public WorkbookFunctionsWorkDayRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken startDate,
            Newtonsoft.Json.Linq.JToken days,
            Newtonsoft.Json.Linq.JToken holidays)
            : base(requestUrl, client)
        {
            this.SetParameter("startDate", startDate, true);
            this.SetParameter("days", days, true);
            this.SetParameter("holidays", holidays, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsWorkDayRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsWorkDayRequest(functionUrl, this.Client, options);

            if (this.HasParameter("startDate"))
            {
                request.RequestBody.StartDate = this.GetParameter<Newtonsoft.Json.Linq.JToken>("startDate");
            }

            if (this.HasParameter("days"))
            {
                request.RequestBody.Days = this.GetParameter<Newtonsoft.Json.Linq.JToken>("days");
            }

            if (this.HasParameter("holidays"))
            {
                request.RequestBody.Holidays = this.GetParameter<Newtonsoft.Json.Linq.JToken>("holidays");
            }

            return request;
        }
    }
}
