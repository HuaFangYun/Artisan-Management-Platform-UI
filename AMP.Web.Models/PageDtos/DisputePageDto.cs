﻿using AMP.Web.Models.Enums;

namespace AMP.Web.Models.PageDtos
{
    public class DisputePageDto
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string OrderId { get; set; }
        public string Details { get; set; }
        public DisputeStatus Status { get; set; }
        public CustomerPageDto Customer { get; set; }
        public OrderPageDto Order { get; set; }
    }
}