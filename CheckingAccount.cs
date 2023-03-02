public class CheckingAccount : BankAccount {

    public CheckingAccount (string newCustomerName, double newBalance) : base(newCustomerName, newBalance) {

        balance += 100; // all checking accounts created get $100 more in their balance


    }
}