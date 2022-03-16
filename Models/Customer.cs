using System;

namespace CheckerLangDaiHocAPI.Models
{
    [Flags]
    public enum CustomerStatus
    {
        ACTIVE = 1,
        RESTRICTED = -1,
        BANNED = -2,
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CustomerStatus Status { get; set; } = CustomerStatus.ACTIVE;
    }
}