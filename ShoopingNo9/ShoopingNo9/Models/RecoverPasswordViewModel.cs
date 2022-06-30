using System.ComponentModel.DataAnnotations;

namespace ShoopingNo9.Models
{
    public class RecoverPasswordViewModel
    {
        [Display(Name ="Email")]
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage ="Deves ingresar un correo valido.")]
        public string Email { get; set; }
    }
}
