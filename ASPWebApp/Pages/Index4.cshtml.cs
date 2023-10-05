using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPWebApp.Pages;

public class Index4Model : PageModel
{
    [BindProperty]
    public int Num { get; set; } = 0;
    [BindProperty]

    public string Result { get; set; }=null!;

    private readonly ILogger<IndexModel> _logger;

    public Index4Model(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    
    }
    public void OnPost()
    {
        int a=0,b=1,c;
        for(int i=0;i<Num;i++){
            Result+=a+" ";
            c=a+b;
            a=b;
            b=c;
        }

    }
}
