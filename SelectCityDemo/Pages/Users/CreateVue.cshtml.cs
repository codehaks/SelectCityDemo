using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SelectCityDemo.Pages.Users;

public class CreateVueModel : PageModel
{
    public Input Input { get; set; }
    public void OnGet()
    {
    }
}
