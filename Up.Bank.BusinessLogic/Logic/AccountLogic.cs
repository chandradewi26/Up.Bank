using Up.Bank.BusinessLogic.DomainModel;

namespace Up.Bank.BusinessLogic.Logic
{
    public class AccountLogic
    {

        public Account GetNewAccount()
        {
            var account2 = new Account(1999767676, "Chandra", "Dewi", "2A Elsie Street");

            return account2;
        }
    }
}
