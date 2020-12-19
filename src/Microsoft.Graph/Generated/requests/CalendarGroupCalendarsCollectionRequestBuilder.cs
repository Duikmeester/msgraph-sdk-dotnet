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
    /// The type CalendarGroupCalendarsCollectionRequestBuilder.
    /// </summary>
    public partial class CalendarGroupCalendarsCollectionRequestBuilder : BaseRequestBuilder, ICalendarGroupCalendarsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CalendarGroupCalendarsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CalendarGroupCalendarsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICalendarGroupCalendarsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICalendarGroupCalendarsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CalendarGroupCalendarsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ICalendarRequestBuilder"/> for the specified CalendarGroupCalendar.
        /// </summary>
        /// <param name="id">The ID for the CalendarGroupCalendar.</param>
        /// <returns>The <see cref="ICalendarRequestBuilder"/>.</returns>
        public ICalendarRequestBuilder this[string id]
        {
            get
            {
                return new CalendarRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
