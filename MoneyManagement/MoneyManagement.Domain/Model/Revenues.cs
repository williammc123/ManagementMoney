using MoneyManagement.Domain.Enums;
using System;

namespace MoneyManagement.Domain.Model
{
    public class Revenues
    {
        public Revenues( RevenueType revenueType, bool value, bool extra, bool foodVouchers)
        {
            this.revenueType = revenueType;
            Value = value;
            Extra = extra;
            FoodVouchers = foodVouchers;
        }

        public int Id { get; set; }
        public RevenueType revenueType { get; set; }
        public Boolean Value { get; set; }
        public Boolean Extra { get; set; }
        public Boolean FoodVouchers { get; set; }
    }
}
