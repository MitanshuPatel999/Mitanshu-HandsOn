using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDWebApp.Models;

namespace CRUDWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CRUDWebApp.Data.MyDbContext _context;

        public IndexModel(CRUDWebApp.Data.MyDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
    }
}
