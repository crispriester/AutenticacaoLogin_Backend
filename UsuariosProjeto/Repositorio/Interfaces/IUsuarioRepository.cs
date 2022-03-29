using Repositorio.Entidades;
using System;

namespace Repositorio.Interfaces
{
    public interface IUsuarioRepository
    {
        UsuarioEntity GetByLogin(string login, string senha);
    }
}
