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
            var account1 = new Account(1999767676, "Chandra", "Dewi", "2A Elsie Street");

            return account1;
        }
    }
}
