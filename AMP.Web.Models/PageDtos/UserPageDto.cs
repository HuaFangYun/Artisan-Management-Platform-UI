﻿using AMP.Web.Models.Enums;
using AMP.Web.Models.ValueObjects;

namespace AMP.Web.Models.PageDtos
{
    public class UserPageDto
    {
        public string Id { get; set; }
        public string UserNo { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public string OtherName { get; set; }
        public string DisplayName { get; set; } 
        public string MomoNumber { get; set; }
        public bool IsSuspended { get; set; }
        public bool IsRemoved { get; set; }
        public UserType Type { get; set; }
        public LevelOfEducation LevelOfEducation { get; set; }
        public Contact Contact { get; set; } = new Contact();
        public Address Address { get; set; } = new Address();
        public ImagePageDto Image { get; set; } = new ImagePageDto();

    }
}