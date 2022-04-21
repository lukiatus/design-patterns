namespace BankingApp.State
{
    public abstract class AccountState
    {
        public abstract void Deposit(int amount);
        public abstract void Withdraw(int amount);
        public double Balance { get; protected set; }
        public BankAccount BankAccount { get; protected set; } = null!;
        public override abstract string ToString();
    }
}