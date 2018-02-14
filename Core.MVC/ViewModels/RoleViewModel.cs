using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.MVC.ViewModels
{
    public class RoleViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [MaxLength(80, ErrorMessage = "Tamanho máximo de 80 caracteres")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreationDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime LastModification { get; set; }

        private ICollection<UserViewModel> users;

        public ICollection<UserViewModel> GetUsers()
        {
            return users;
        }

        public void SetUsers(ICollection<UserViewModel> value)
        {
            users = value;
        }

        //public ICollection<Privilege> Privileges { get; set; }

    }
}
