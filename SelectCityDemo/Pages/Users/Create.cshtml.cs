using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SelectCityDemo.Pages.Users;

public class CreateModel : PageModel
{
    public Input Input { get; set; }

    public void OnGet()
    {
    }
}

public class Input
{
    public string Name { get; set; }
    public int ProvinceId { get; set; }
    public int CityId { get; set; }
}