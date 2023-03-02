public class SavingsAccount : BankAccount {

    public SavingsAccount(string newCustomerName, float newBalance) : base ( newCustomerName,  newBalance) {

        balance += 200;
    }
}