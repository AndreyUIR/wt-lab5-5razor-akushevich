namespace wt_lab5_5razor_akushevich.Models;

public class BankAccount
{
    public int Id { get; set; }
    public string OwnerName { get; set; } = string.Empty;
    public string AccountNumber { get; set; } = string.Empty;
    public decimal Balance { get; set; }
    public bool IsActive { get; set; }
}