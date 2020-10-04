
using Newtonsoft.Json;
using System;
using System.Net.Http;
using Up.Bank.BusinessLogic.DomainModel;

namespace Up.Bank.BusinessLogic.Logic
{
    public class TransactionLogic
    {

        public void DownloadTransactions()
        {
            var httpClient = new HttpClient();
            var transactionJsonString = httpClient.GetStringAsync("https://api.up.com.au/api/v1/transactions").Result;
            var transaction1 = new Transaction();
            //Encountered Error because it creates Account Object, not Transaction Object
            transaction1 = JsonConvert.DeserializeObject<Account>(transactionJsonString);


            Console.WriteLine("Transaction ID : " + transaction1.);
            Console.WriteLine("Type           : " + transaction1.);
            Console.WriteLine("Value          : " + transaction1.);
            Console.WriteLine("Description    : " + transaction1.);
            Console.WriteLine("Message        : " + transaction1.);
            Console.WriteLine("Settled At     : " + transaction1.);

        }


        public Transaction GetNewTransaction()
        {
            var transaction = new Transaction("01010101", "transactions", -1000, "Spending Money", "Duck", DateTime.Parse("2020-10-01T04:24:51+10:00"));
            //public Transaction(String id, String type, decimal value, String description, String message, DateTime settledAt)

            return transaction;
        }

    }
}
