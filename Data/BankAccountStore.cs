using wt_lab5_5razor_akushevich.Models;

namespace wt_lab5_5razor_akushevich.Data;

public static class BankAccountStore
{
    public static List<BankAccount> Accounts { get; } = new()
    {
        new BankAccount
        {
            Id = 1,
            OwnerName = "Акушевич Андрей Сергеевич",
            AccountNumber = "BY01SAV0001",
            Balance = 2000m,
            IsActive = true
        },
        new BankAccount
        {
            Id = 2,
            OwnerName = "Петрова Анна Сергеевна",
            AccountNumber = "BY02CRD0002",
            Balance = 0m,
            IsActive = true
        },
        new BankAccount
        {
            Id = 3,
            OwnerName = "Сидоров Пётр Петрович",
            AccountNumber = "BY03DEP0003",
            Balance = 5000m,
            IsActive = false
        },
        new BankAccount
        {
            Id = 4,
            OwnerName = "Морозова Елена Викторовна",
            AccountNumber = "BY04DEP0004",
            Balance = 12000m,
            IsActive = true
        },
        new BankAccount
        {
            Id = 5,
            OwnerName = "Кузнецов Андрей Игоревич",
            AccountNumber = "BY05SAV0005",
            Balance = 750m,
            IsActive = false
        }
    };
}