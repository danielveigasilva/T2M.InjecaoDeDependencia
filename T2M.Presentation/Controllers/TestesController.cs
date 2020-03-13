using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using T2M.Presentation.Interfaces;
using T2M.Presentation.Models;

namespace T2M.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestesController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;
        public TestesController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet("msm")]
        public string GetMensagem() 
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Cpf = "12.345.678-9";
            pessoa.Nome = "Luke Skywallker";
            pessoa.DadaDeNascimento = Convert.ToDateTime("1973-07-03");
            return _pessoaService.GetMensagem(pessoa);
        } 
    }
}
