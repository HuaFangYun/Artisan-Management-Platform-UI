﻿namespace AMP.Web.Models.PageDtos
{
    public class CustomerPageDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public UserPageDto User { get; set; }
    }
}