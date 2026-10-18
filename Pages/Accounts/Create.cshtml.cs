using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_akushevich.Data;
using wt_lab5_5razor_akushevich.Models;

namespace wt_lab5_5razor_akushevich.Pages.Accounts;

public class CreateModel : PageModel
{
    [BindProperty]
    public BankAccount Account { get; set; } = new();

    public void OnGet()
    {
    }

        public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        Account.Id = BankAccountStore.Accounts.Any()
            ? BankAccountStore.Accounts.Max(a => a.Id) + 1
            : 1;
        Account.IsActive = true;

        BankAccountStore.Accounts.Add(Account);

        return RedirectToPage("./Index");
    }
}