using System;

namespace Repositorio.Entidades
{
    public class UsuarioEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public UsuarioEntity(string nome, string login, string senha)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Login = login;
            Senha = senha;
        }
    }
}
