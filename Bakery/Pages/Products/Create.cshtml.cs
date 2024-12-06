using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bakery.Model;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly Bakery.Model.BakeryContext _context;
        private readonly IWebHostEnvironment _environment;


        public CreateModel(Bakery.Model.BakeryContext context,IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty,Display(Name ="Product Image")]
        public IFormFile ProductImage { get; set; }

        [BindProperty]
        public Product Product { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            ModelState.Remove("Product.ImageName");

            if (!ModelState.IsValid  || _context.Products == null || Product == null)
            {
                return Page();
            }
            Product.ImageName = ProductImage.FileName;
            var productImagePage = Path.Combine(_environment.WebRootPath, "images", "products", ProductImage.FileName);
            using var fileStream = new FileStream(productImagePage, FileMode.Create);
            await ProductImage.CopyToAsync(fileStream);


            _context.Products.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
