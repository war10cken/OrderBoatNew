#nullable enable

using System;

namespace OrderBoatNew.Domain.Models
{
    public class Customers : DomainObject
    {
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? OrganizationName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string IdNumber { get; set; }
        public string DocumentName { get; set; }
    }
}