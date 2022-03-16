using System;

namespace CheckerLangDaiHocAPI.Models
{
    [Flags]
    public enum ChickenStatus
    {
        ACTIVE = 1,
        REST = 0,
    }

    public class Chicken
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public ChickenStatus Status { get; set; } = ChickenStatus.ACTIVE;
    }
}