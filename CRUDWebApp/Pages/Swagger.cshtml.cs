using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDWebApp.Pages{
    public class SwaggerPageModel : PageModel
{
    public string SwaggerEndpoint = "/swagger/v1/swagger.json"; // Specify the correct Swagger JSON endpoint
}
}