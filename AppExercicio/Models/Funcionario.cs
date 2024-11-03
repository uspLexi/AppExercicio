using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppExercicio.Models
{
    public class Funcionario
    {
        [Required(ErrorMessage = "O campo codigo é obrigatorio ")]
        public int Cod { get; set; }

        [Required(ErrorMessage = "O nome é obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O cargo é obrigatorio")]
        public string Cargo { get; set; }
    }
}