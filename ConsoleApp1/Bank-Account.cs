namespace ConsoleApp1;

public class Account
{
    public Account(string fullName, decimal initialBalance)
    {
        FullName = fullName;
        Deposit(initialBalance);
    }
    
    public string FullName { get; }

    public List<Transaction> Transactions { get; } = new List<Transaction>();

    public void Deposit(decimal amount)
    {
        Transaction newTransaction = new Transaction(amount, TransactionKind.Deposit);
        Transactions.Add(newTransaction);
    }

    public void Withdrawal(decimal amount)
    {
        if (GetBalance() - amount >= 0)
        {
            Transaction newTransaction = new Transaction(amount, TransactionKind.Withdrawal);
            Transactions.Add(newTransaction);  
        }
    }

    public decimal GetBalance()
    {
        return Transactions.Sum(t => t.Kind == TransactionKind.Deposit ? t.Amount : -t.Amount);
    }

    public decimal Balance => GetBalance();
}