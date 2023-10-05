using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPWebApp.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public int Num { get; set; } = 0;
    public int Count { get; set; } = 0;

    public int Result { get; set; }

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    
    }
    public void OnPost()
    {
        Result=Num*2;
    }
}
