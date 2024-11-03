using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace AppExercicio.Models
{
    public class Usuario
    {

        [Range(1, 200, ErrorMessage = "O Id deve estar entre 1 e 200")]
        public int Cod { get; set; }

        [Required(ErrorMessage = "O nome é obrigatorio")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira uma informação de 5 até 50 caracteres")]
        public string Obs { get; set; }

        [Required(ErrorMessage = "Informe a Data de Nascimento")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Nasc { get; set; }

        [Required(ErrorMessage = "O email é obrigatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Login é obrigatorio")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Somente letras,no minimo 5 e maximo 15 caracteres")]
        public string Login{ get; set; }

        [Required(ErrorMessage = "A senha é obrigatoria")]
        public string Senha{ get; set; }

        [Compare("Senha", ErrorMessage = "As senhas são diferentes")]
        public string ComfirmSenha { get; set; }
    }
}