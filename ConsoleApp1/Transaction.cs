namespace ConsoleApp1;

public class Transaction
{
    public Transaction(decimal amount, TransactionKind kind)
    {
        Amount = amount;
        Kind = kind;
    }
    public decimal Amount { get; }
    public TransactionKind Kind { get; }
}