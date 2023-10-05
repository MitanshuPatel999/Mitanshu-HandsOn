using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPWebApp.Pages;

public class Index5Model : PageModel
{
    [BindProperty]
    public int Num { get; set; } = 0;
    [BindProperty]

    public int Result { get; set; }=1;

    private readonly ILogger<IndexModel> _logger;

    public Index5Model(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    
    }
    public void OnPost()
    {
        Result=Fact(Num);
        Console.WriteLine(Result);
    }
public int Fact(int n){
    if(n<0)
        throw new InvalidDataException("Factorial is not possible for negative integers!!!");
    if(n>0)
        return Fact(n-1)*n;
    else
        return 1;
}

}
