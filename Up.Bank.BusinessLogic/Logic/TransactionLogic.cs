
using System;
using Up.Bank.BusinessLogic.DomainModel;

namespace Up.Bank.BusinessLogic.Logic
{
    public class TransactionLogic
    {

        

        public Transaction GetNewTransaction()
        {
            var transaction = new Transaction("01010101", "transactions", -1000, "Spending Money", "Duck", DateTime.Parse("2020-10-01T04:24:51+10:00"));
            //public Transaction(String id, String type, decimal value, String description, String message, DateTime settledAt)

            return transaction;
        }

    }
}
