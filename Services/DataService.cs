using BankingApp.Models;
using BankingApp.State;

namespace BankingApp.Services
{
    public class DataService
    {
        public DataService()
        {
            Customer = new Person
            {
                FirstName = "Attila",
                LastName = "Lukács",
                Neptun = "K6FS84"
            };

            Account = new BankAccount(Customer);
        }

        public Person Customer { get; private set; }
        public BankAccount Account { get; private set; }
    }
}