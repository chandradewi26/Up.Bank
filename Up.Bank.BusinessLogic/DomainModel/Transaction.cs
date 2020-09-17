using System;

namespace Up.Bank.BusinessLogic.DomainModel
{
    public class Transaction
    {
        public Transaction()
        {
            Description = "Theres no transaction stored.";
            Value = 0;
        }

        public Transaction(string description, decimal value)
        {
            if (value < 0)
                throw new Exception("transaction cant be less than 0");
            Description = description;
            Value = value;
        }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}
