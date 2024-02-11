﻿namespace BlazorQuickGrid.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
    }
}
