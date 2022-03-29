using Microsoft.AspNetCore.Mvc;
using Negocio.Dto;
using Negocio.Interfaces;
using System;

namespace UsuariosProjeto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
        //colocar o readonly para não mudar a instância
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public IActionResult Post([FromBody]UsuarioDto usuarioDto)
        {
            var (statusCode, usuarioRetornDto) = _usuarioService.Insert(usuarioDto);

            return StatusCode(statusCode, usuarioRetornDto);
        }
    }
}
