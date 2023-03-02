public class BankAccount
{
    public string customerName = "";
    public double balance = 0;


    public BankAccount()
    {
        customerName = "Bob";
        balance = 300;
    }

    public BankAccount(string newCustomerName, double newBalance)
    {
        customerName = newCustomerName;
        balance = newBalance;

     }

    public void deposit(double amount) {

        if(amount <= 0){
            throw new Exception("No negative deposits allowed");
        }

            balance += amount;

    }

    public double getBalance() {
        return balance;
    }

}