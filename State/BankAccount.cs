using BankingApp.Models;

namespace BankingApp.State
{
    public class BankAccount
    {
        public AccountState AccountState { get; set; }
        public double Balance => AccountState.Balance;
        public Person Owner { get; private set; }

        public BankAccount(Person owner)
        {
            Owner = owner;
            AccountState = new NormalState(100, this);
        }

        public void Freeze()
        {
            AccountState = new FrozenState(Balance, this);
        }
    }
}