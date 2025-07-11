using System;
namespace HELLOWORLD
{
    public class BankAccount
{
    private decimal balance;
    private string accountNumber;
    private DateTime lastTransaction;
    
    // 1. Oddiy property
    public string AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }
    
    // 2. Auto-implemented property (qisqa usul)
    public string CustomerName { get; set; }
    
    // 3. Read-only property
    public string AccountType { get; }
    
    // 4. Computed property (hisoblangan)
    public string AccountInfo
    {
        get { return $"{AccountNumber} - {CustomerName}"; }
    }
    
    // 5. Property with validation (tekshirish bilan)
    public decimal Balance
    {
        get { return balance; }
        set 
        { 
            if (value >= 0)
                balance = value;
            else
                throw new ArgumentException("Balans manfiy bo'lishi mumkin emas!");
        }
    }
    
    // 6. Private set (faqat class ichida o'rnatish)
    public DateTime LastTransaction
    {
        get { return lastTransaction; }
        private set { lastTransaction = value; }
    }
    
    // Constructor
    public BankAccount(string accountNumber, string customerName, string accountType)
    {
        this.accountNumber = accountNumber;
        this.CustomerName = customerName;
        this.AccountType = accountType;
        this.balance = 0;
        this.lastTransaction = DateTime.Now;
    }
}
}