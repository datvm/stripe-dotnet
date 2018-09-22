﻿namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class StripeOrderListOptions : StripeListOptionsWithCreated
    {
        /// <summary>
        /// Only return orders for the given customer.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Only return orders with the given IDs.
        /// </summary>
        [JsonProperty("ids")]
        public string[] Ids { get; set; }

        /// <summary>
        /// Only return orders that have the given status. One of created, paid, fulfilled, or refunded.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Only return orders that match the given status_transitions. One of canceled, fulfilled, paid or returned.
        /// </summary>
        [JsonProperty("status_transitions")]
        public StripeOrderStatusTransitionsOptions StatusTransitions { get; set; }

        /// <summary>
        /// Only return orders with the given upstream order IDs.
        /// </summary>
        [JsonProperty("upstream_ids")]
        public string[] UpstreamIds { get; set; }
    }
}