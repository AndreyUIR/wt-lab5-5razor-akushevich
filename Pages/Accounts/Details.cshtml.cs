using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_akushevich.Data;
using wt_lab5_5razor_akushevich.Models;

namespace wt_lab5_5razor_akushevich.Pages.Accounts;

public class DetailsModel : PageModel
{
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
}