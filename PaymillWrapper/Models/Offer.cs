﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Web;

namespace PaymillWrapper.Models
{
    /// <summary>
    /// An offer is a recurring plan which a user can subscribe to. 
    /// You can create different offers with different plan attributes e.g. a monthly or a yearly based paid offer/plan.
    /// </summary>
    public class Offer : BaseModel
    {
        public Offer()
        {
            SubscriptionCount = new SubscriptionCount(null, null);
        }
        /// <summary>
        /// Your name for this offer
        /// </summary>
        [JsonPropertyAttribute("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Every interval the specified amount will be charged. In test mode only even values e.g. 42.00 = 4200 are allowed
        /// </summary>
        [JsonPropertyAttribute("Amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Return formatted amount, e.g. 4200 amount value return 42.00
        /// </summary>
        [JsonIgnore]
        public double AmountFormatted
        {
            get
            {
                return Amount / 100;
            }
        }

        /// <summary>
        /// Defining how often the client should be charged (week, month, year)
        /// </summary>
        [JsonPropertyAttribute("Interval")]
        public String Interval { get; set; }

        /// <summary>
        /// Give it a try or charge directly?
        /// </summary>
        [JsonPropertyAttribute("Trial_Period_Days")]
        public int? Trial_Period_Days { get; set; }

        /// <summary>
        /// ISO 4217 formatted currency code
        /// </summary>
        [JsonPropertyAttribute("Currency")]
        public string Currency { get; set; }

        /// <summary>
        /// App (ID) that created this offer or null if created by yourself
        /// </summary>
        [JsonPropertyAttribute("app_id")]
        public string AppId { get; set; }

        [JsonPropertyAttribute("subscription_count")]
        public SubscriptionCount SubscriptionCount { get; set; }

 
    }
}