using System;
using System.ComponentModel.DataAnnotations;

namespace Core.MVC.ViewModels
{
    public class UserViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(80, ErrorMessage = "Tamanho máximo de 80 caracteres")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(200, ErrorMessage = "Tamanho máximo de 200 caracteres")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        public string Password { get; set; }

        [ScaffoldColumn(false)]
        public int Status { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreationDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime LastModification { get; set; }

        public int RoleId { get; set; }

        public virtual RoleViewModel Role { get; set; }
    }
}
