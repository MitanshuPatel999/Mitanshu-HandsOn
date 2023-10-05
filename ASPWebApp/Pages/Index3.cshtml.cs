using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPWebApp.Pages;

public class Index3Model : PageModel
{
    [BindProperty]
    public int Num1 { get; set; } = 0;
    [BindProperty]
    public int Num2 { get; set; } = 0;
    [BindProperty]
    public int Num3 { get; set; } = 0;
    [BindProperty]
    public int Num4 { get; set; } = 0;
    [BindProperty]
    public int Num5 { get; set; } = 0;

    public double Result { get; set; }

    private readonly ILogger<IndexModel> _logger;

    public Index3Model(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    
    }
    public void OnPost()
    {
        Result=(double)(Num1+Num2+Num3+Num4+Num5)*0.2;
    }
}
