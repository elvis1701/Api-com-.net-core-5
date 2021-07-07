using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cursoApi.Models.Usuarios
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "O Login é Obrigatorio")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A Senha é Obrigatorio")]
        public string Senha { get; set; }
    }
}
