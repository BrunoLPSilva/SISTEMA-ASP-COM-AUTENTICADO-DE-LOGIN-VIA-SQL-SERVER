using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SistemaPIM.Models
{
    public class LoginViewModel
    {   
      [Required]
        [Display(Name ="Usuário")]
        public string Usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Display(Name = "Lembrar Me")]
        public bool LembrarMe { get; set; }
    }
}
