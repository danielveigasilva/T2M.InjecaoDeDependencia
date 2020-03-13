using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T2M.Presentation.Interfaces;
using T2M.Presentation.Models;

namespace T2M.Presentation.Services
{
    public class PessoaService : IPessoaService
    {
        public string GetMensagem(Pessoa pessoa)
        {
            return "Service I: Oi " + pessoa.Nome + ", tudo Bem?";
        }
    }
}
