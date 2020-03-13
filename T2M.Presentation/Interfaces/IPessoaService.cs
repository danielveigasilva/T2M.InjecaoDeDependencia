using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T2M.Presentation.Models;

namespace T2M.Presentation.Interfaces
{
    public interface IPessoaService
    {
        string GetMensagem(Pessoa pessoa);
    }
}
