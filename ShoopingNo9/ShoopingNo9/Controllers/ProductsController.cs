using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoopingNo9.Data;
using ShoopingNo9.Data.Entities;
using ShoopingNo9.Helpers;
using ShoopingNo9.Models;

namespace ShoopingNo9.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataContext _context;
        private readonly ICombosHelper _combosHelper;
        private readonly IBlobHelper _blobHelper;

        public ProductsController(DataContext context, ICombosHelper combosHelper, IBlobHelper blobHelper)
        {
            _context = context;
            _combosHelper = combosHelper;
            _blobHelper = blobHelper;
        }
        /*
        public async Task<ActionResult> Index()
        {
            return View(await _context.Products
                .Include(p => p.ProductImages)
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .ToListAsync());
        }
        public async Task<IActionResult> Create()
        {
            CreateProductViewModel model = new()
            {
                Categories = await _combosHelper.GetComboCategoriesAsync(),
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                Guid imageId = Guid.Empty;
                if (model.ImageFile != null)
                {
                    imageId = await _blobHelper.UploadBlobAsync(model.ImageFile, "product");
                }
                Product product = new()
                {
                    Description = model.Description,
                    Name = model.Name,
                    Price = model.Price,
                    Stock = model.Stock,
                };
                product.ProductCategories = new List<ProductCategory>()
                {
                    new ProductCategory()
                    {
                        Category = await _context.Categories.FindAsync(model.CategoryId)
                    }
                };
                if (imageId != Guid.Empty)
                {
                    product.ProductImages = new List<ProductImage>()
                    {
                        new ProductImage { ImageId = imageId }
                    };
                }
                try
                {
                    _context.Add(product);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException dbUpdateException)
                {
                    if (dbUpdateException.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, "Ya existe un producto con el mismo nombre.");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, dbUpdateException.InnerException.Message);
                    }
                }
                catch (Exception exception)
                {
                    ModelState.AddModelError(string.Empty, exception.Message);
                }
            }
            model.Categories = await _combosHelper.GetComboCategoriesAsync();
            return View(model);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            EditProductViewModel model = new()
            {
                Description = product.Description,
                Id = product.Id,
                Name = product.Name,
                Stock = product.Stock,
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CreateProductViewModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }
            try
            {
                Product product = await _context.Products.FindAsync(model.Id);
                product.Description = model.Description;
                product.Name = model.Name;
                product.Price = model.Price;
                product.Stock = model.Stock;
                _context.Update(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException.Message.Contains("duplicate"))
                {
                    ModelState.AddModelError(string.Empty, "Ya existe un producto con el mismo nombre.");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, dbUpdateException.InnerException.Message);
                }
            }
            catch (Exception exception)
            {
                ModelState.AddModelError(string.Empty, exception.Message);
            }
            return View(model); 
        }
        public async Task<IActionResult> Details(int? id)
        {
            // 16:00 10:00
            if (id == null)
            {
                return NotFound();
            }
            Product product = await _context.Products
                .Include(p => p.ProductImages)
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .FirstOrDefaultAsync(p => p.Id==id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        public async Task<IActionResult> AddImage(int? id)
        {
            if (id == null)

            {
                return NotFound();
            }
            Product product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            AddProductImageViewModel model = new()
            {
                ProductId = product.Id,
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddImage(AddProductImageViewModel model)
        {
            if (ModelState.IsValid)
            {
                Guid imageId = Guid.Empty;
                if (model.ImageFile != null)
                {
                    imageId = await _blobHelper.UploadBlobAsync(model.ImageFile, "product");
                }
                Product product = await _context.Products.FindAsync(model.ProductId);
                ProductImage productImage = new()
                {
                    Product = product,
                    ImageId = imageId,
                };
                try
                {
                    _context.Add(productImage);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Details), new { Id = product.Id });
                }
                catch (Exception exception)
                {
                    ModelState.AddModelError(string.Empty, exception.Message);
                }
            }
            return View(model);
        }
        public async Task<IActionResult> DeleteImage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProductImage productImage = await _context.ProductImages
                .Include(pi => pi.Product)
                .FirstOrDefaultAsync(pi => pi.Id == id);
            if (productImage == null)
            {
                //16 minuto 22
                return NotFound();
            }
            await _blobHelper.DeleteBlobAsync(productImage.ImageId, "product");
            _context.ProductImages.Remove(productImage);
            return RedirectToAction(nameof(Details), new { Id = productImage.Id });
        }
        */
    }
}
