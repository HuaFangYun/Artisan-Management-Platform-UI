﻿using System;
using AMP.Web.Models.Enums;
using AMP.Web.Models.ValueObjects;

namespace AMP.Web.Models.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int? ArtisanId { get; set; }
        public bool IsArtisanComplete { get; set; }
        public bool IsRequestAccepted { get; set; }
        public int ServiceId { get; set; }
        public int? PaymentId { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public decimal PaymentMade { get; set; }
        public Urgency Urgency { get; set; }
        public ScopeOfWork Scope { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime PreferredStartDate { get; set; }
        public DateTime PreferredCompletionDate { get; set; }
        public Address WorkAddress { get; set; } = new Address();
        public CustomerDto Customer { get; set; } = new CustomerDto();
        public ArtisanDto Artisan { get; set; } = new ArtisanDto();
        public ServiceDto Service { get; set; } = new ServiceDto();
        public PaymentDto Payment { get; set; } = new PaymentDto();
    }
}