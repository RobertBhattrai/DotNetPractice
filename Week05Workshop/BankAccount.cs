//Task 1: Encapsulation
public class BankAccount
{
    // Private fields
    private int accountNumber;
    private decimal balance;

    // Public property for AccountNumber
        public int AccountNumber
    {
        get { return accountNumber; }
    }
    // public property for Balance that doesn't allow negative values
    public decimal Balance
    {
        get { return balance; }
        set
        {
            if (value < 0)
            {
                throw new System.ArgumentException("Balance cannot be negative.");
            }
            balance = value;
        }
    }

    // Constructor
    public BankAccount(int accountNumber, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        Balance = initialBalance;
    }

    // Method to deposit money
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new System.ArgumentException("Deposit amount must be positive.");
        }
        Balance += amount;
    }

    // Method to withdraw money
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new System.ArgumentException("Withdrawal amount must be positive.");
        }
        if (amount > Balance)
        {
            throw new System.InvalidOperationException("Insufficient funds.");
        }
        Balance -= amount;
    }

}