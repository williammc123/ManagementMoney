using MoneyManagement.Domain.Enums;
using System;

namespace MoneyManagement.Domain.Model
{
    public class Budget 
    {
        public Budget( BudgetType budgetType, string name, bool value, DateTime expirationDate)
        {
            this.budgetType = budgetType;
            Name = name;
            Value = value;
            ExpirationDate = expirationDate;
        }

        public int Id { get; set; }
        public BudgetType budgetType { get; set; }
        public string Name { get; set; }
        public bool Value { get; set; }
        public DateTime ExpirationDate { get; set; }       
    }
}
