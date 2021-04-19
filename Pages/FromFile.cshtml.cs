using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Zad5AddingService.Models;
using Zad5AddingService.Services;

namespace Zad5AddingService.Pages
{
    public class FromFileModel : PageModel
    {
        private readonly ILogger<FromFileModel> _logger;

        public FromFileModel(ILogger<FromFileModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }
        public IEnumerable<Product> Products { get; private set; }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
