﻿namespace SaiGonTee_Ecom.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Role { get; set; } = "user";
        public string FullName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
