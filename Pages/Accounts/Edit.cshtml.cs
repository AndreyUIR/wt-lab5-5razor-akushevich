using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_akushevich.Data;
using wt_lab5_5razor_akushevich.Models;

namespace wt_lab5_5razor_akushevich.Pages.Accounts;

public class EditModel : PageModel
{
    [BindProperty]
    public BankAccount Account { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        var account = BankAccountStore.Accounts.FirstOrDefault(a => a.Id == id);

        if (account == null)
        {
            return NotFound();
        }

        Account = account;
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var existing = BankAccountStore.Accounts.FirstOrDefault(a => a.Id == Account.Id);

        if (existing == null)
        {
            return NotFound();
        }

        // Меняем только разрешённые поля, баланс и номер из формы не берём
        existing.OwnerName = Account.OwnerName;
        existing.IsActive = Account.IsActive;

        return RedirectToPage("./Index");
    }
}