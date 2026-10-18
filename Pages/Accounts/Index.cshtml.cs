using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_akushevich.Data;
using wt_lab5_5razor_akushevich.Models;
using Microsoft.AspNetCore.Mvc;

namespace wt_lab5_5razor_akushevich.Pages.Accounts;

public class IndexModel : PageModel
{
    public List<BankAccount> Accounts { get; set; } = new();

    public void OnGet()
    {
        Accounts = BankAccountStore.Accounts;
    }
    public IActionResult OnPostDelete(int id)
    {
        var account = BankAccountStore.Accounts.FirstOrDefault(a => a.Id == id);

        if (account != null)
        {
            BankAccountStore.Accounts.Remove(account);
        }

        return RedirectToPage();
    }
}
    