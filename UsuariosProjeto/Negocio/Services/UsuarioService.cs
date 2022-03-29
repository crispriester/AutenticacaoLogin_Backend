using Negocio.Dto;
using Negocio.Interfaces;
using Repositorio.Entidades;
using Repositorio.Interfaces;
using Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Negocio.Services
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public (int, object) Insert(UsuarioDto usuarioDto)
        {
            if (usuarioDto.Login == "" || usuarioDto.Senha == "")
            {
                return ((int)EnumRetornosHttp.Ok, new MensagemRetornoDto("Todos os dados devem ser preenchidos."));
            }

            var entidade = _usuarioRepository.GetByLogin(usuarioDto.Login, usuarioDto.Senha);

            if (entidade == null)
            {
                return ((int)EnumRetornosHttp.Ok, new MensagemRetornoDto("Usuário não encontrado."));
            }

            return ((int)EnumRetornosHttp.Ok, UsuarioRetornoDto.DeUsuarioEntityParaUsuarioRetornoDto(entidade));
        }

        //public (int, object) Put(Guid id, UsuarioDto usuarioDto)
        //{
        //    var result = _usuarioRepository.GetById(id);

        //    if (result == null)
        //    {
        //        return ((int)EnumRetornosHttp.NotFound, new MensagemRetornoDto("Usuário não encontrado."));
        //    }

        //    if ((usuarioDto.Nome == result.Nome || usuarioDto.Login == result.Login || usuarioDto.Senha == result.Senha) &&
        //        (usuarioDto.Nome == "" || usuarioDto.Login == "" || usuarioDto.Senha == ""))
                 
        //    {
        //        return ((int)EnumRetornosHttp.BadRequest, new MensagemRetornoDto("Todos os dados devem ser preenchidos e nenhum deve ser igual ao que já era antes."));
        //    }

        //    result.Nome = usuarioDto.Nome;
        //    result.Login = usuarioDto.Login;
        //    result.Senha = usuarioDto.Senha;

        //    return ((int)EnumRetornosHttp.Ok, UsuarioRetornoDto.DeUsuarioEntityParaUsuarioRetornoDto(result));
        //}

        //public (int, object) Patch(Guid id, UsuarioDto usuarioDto)
        //{
        //    var result = _usuarioRepository.GetById(id);

        //    if (result == null)
        //    {
        //        return ((int)EnumRetornosHttp.NotFound, new MensagemRetornoDto("Usuário não encontrado."));
        //    }

        //    if ((usuarioDto.Nome != result.Nome && usuarioDto.Login != result.Login && usuarioDto.Senha != result.Senha) ||
        //        (usuarioDto.Nome == result.Nome && usuarioDto.Login == result.Login && usuarioDto.Senha == result.Senha))
        //    {
        //        return ((int)EnumRetornosHttp.BadRequest, new MensagemRetornoDto("Somente alguns dados devem ser preenchidos, não todos."));
        //    }

        //    if (usuarioDto.Nome != result.Nome)
        //    {
        //        result.Nome = usuarioDto.Nome;
        //    }
        //    if (usuarioDto.Senha != result.Senha)
        //    {
        //        result.Senha = usuarioDto.Senha;
        //    }
        //    if (usuarioDto.Login != result.Login)
        //    {
        //        result.Login = usuarioDto.Login;
        //    }

        //    return ((int)EnumRetornosHttp.Ok, UsuarioRetornoDto.DeUsuarioEntityParaUsuarioRetornoDto(result));
        //}

        //public (int, object) Delete(Guid id)
        //{
        //    var result = _usuarioRepository.GetById(id);

        //    if (result == null)
        //    {
        //        return ((int)EnumRetornosHttp.NotFound, new MensagemRetornoDto("Usuário não encontrado."));
        //    }

        //    _usuarioRepository.Delete(result);

        //    return ((int)EnumRetornosHttp.Ok, new MensagemRetornoDto("Usuário deletado."));
        //}
    }
}
