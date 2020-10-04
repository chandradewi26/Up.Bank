using Up.Bank.BusinessLogic.DomainModel;

namespace Up.Bank.BusinessLogic.Logic
{
    public class AccountLogic
    {

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
