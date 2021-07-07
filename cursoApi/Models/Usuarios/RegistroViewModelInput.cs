using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cursoApi.Models.Usuarios
{
    public class RegistroViewModelInput
    {
        [Required(ErrorMessage = "O Login é Obrigatorio")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O Email é Obrigatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Senha é Obrigatorio")]
        public string Senha { get; set; }
    }
}
