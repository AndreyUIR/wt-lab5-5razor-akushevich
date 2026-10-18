using System.ComponentModel.DataAnnotations;

namespace wt_lab5_5razor_akushevich.Models;

public class BankAccount
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Укажите владельца счёта")]
    [StringLength(100, ErrorMessage = "Не более 100 символов")]
    public string OwnerName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Укажите номер счёта")]
    [StringLength(34, MinimumLength = 6, ErrorMessage = "Номер счёта: от 6 до 34 символов")]
    public string AccountNumber { get; set; } = string.Empty;

    [Range(0, 1000000000, ErrorMessage = "Баланс должен быть от 0 до 1 000 000 000")]
    public decimal Balance { get; set; }

    public bool IsActive { get; set; }
}