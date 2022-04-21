namespace BankingApp.State
{
    public class FrozenState : AccountState
    {
        public FrozenState(double balance, BankAccount bankAccount)
        {
            Balance = balance;
            BankAccount = bankAccount;
        }

        public override void Deposit(int amount)
        {
            throw new Exception("Your account is frozen!");
        }

        public override string ToString()
        {
            return "FROZEN";
        }

        public override void Withdraw(int amount)
        {
            throw new Exception("Your account is frozen!");
        }
    }
}