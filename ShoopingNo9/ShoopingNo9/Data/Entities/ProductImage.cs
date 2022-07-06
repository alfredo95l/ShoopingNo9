using System.ComponentModel.DataAnnotations;

namespace ShoopingNo9.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        [Display(Name ="Foto")]
        public Guid ImageId { get; set; }
        [Display(Name = "Foto")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:7126/images/noimage.png"
            : $"https://shoppingdos.blob.core.windows.net/product/{ImageId}";
    }
}
