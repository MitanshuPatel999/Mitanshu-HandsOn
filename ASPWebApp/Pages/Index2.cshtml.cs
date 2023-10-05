using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPWebApp.Pages;

public class Index2Model : PageModel
{
    [BindProperty]
    public int Num1 { get; set; } = 0;
    [BindProperty]
    public int Num2 { get; set; } = 0;

    public int Result { get; set; }

    private readonly ILogger<IndexModel> _logger;

    public Index2Model(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    
    }
    public void OnPost()
    {
        Result=Num1+Num2;
    }
}
