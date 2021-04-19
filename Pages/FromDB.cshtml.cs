using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Zad5AddingService.Data;
using Zad5AddingService.Models;

namespace Zad5AddingService.Pages
{
    public class FromDBModel : PageModel
    {
        private readonly ProductsContext _context;
        private readonly ILogger<FromDBModel> _logger;
        public FromDBModel(ILogger<FromDBModel> logger, ProductsContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IList<Product> Products { get; set; }

        public void OnGet()
        {
            Products = _context.Products.ToList();
        }
    }
}
