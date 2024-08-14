using Exo.WebApi.Models;
using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

// ProjetosController.cs Controlador da nossa API. Nesse sistema, ela trabalha com a classe 
// ProjetoRepository.cs e com as operações de manipulação do banco de dados.


namespace Exo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;
        public ProjetosController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_projetoRepository.Listar());
        }

    }
}
