using Repositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Dto
{
    public class UsuarioRetornoDto : UsuarioBaseDto
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public static UsuarioRetornoDto DeUsuarioEntityParaUsuarioRetornoDto(UsuarioEntity usuarioEntity)
        {
            return new UsuarioRetornoDto
            {
                Id = usuarioEntity.Id,
                Nome = usuarioEntity.Nome,
                Login = usuarioEntity.Login,
                Senha = usuarioEntity.Senha
            };
        }
    }
}
