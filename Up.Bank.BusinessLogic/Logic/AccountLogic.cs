using Newtonsoft.Json;
using System;
using System.Net.Http;
using Up.Bank.BusinessLogic.DomainModel;

namespace Up.Bank.BusinessLogic.Logic
{
    public class AccountLogic
    {

        public void DownloadAccount()
        {
            var httpClient = new HttpClient();
            var accountJsonString = httpClient.GetStringAsync("https://api.up.com.au/api/v1/accounts").Result;
            var account1 = new Account();
            account1 = JsonConvert.DeserializeObject<Account>(accountJsonString);


            Console.WriteLine("Account Name   : " + account1.DisplayName);
            Console.WriteLine("Account Type   : " + account1.AccountType);
            Console.WriteLine("Value          : " + account1.Value);

        }

        public Account GetAccountInformation()
        {
            var account = new Account();
            return account;
        }

        public Account GetNewAccount()
        {
            var account1 = new Account("Tuition Fee", "Savings", 50000);

            return account1;
        }
    }
}
