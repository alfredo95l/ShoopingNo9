﻿using System.ComponentModel.DataAnnotations;

namespace ShoopingNo9.Models
{
    public class AddProductImageViewModel
    {
        public int ProductId { get; set; }
        [Display(Name = "Foto")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public IFormFile ImageFile { get; set; }
    }
}
