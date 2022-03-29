using Repositorio.Entidades;
using Repositorio.Interfaces;
using System;
using System.Collections.Generic;

namespace Repositorio.Repositorios
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public List<UsuarioEntity> ListaUsuarioEntity;

        public UsuarioRepository()
        {
            ListaUsuarioEntity = new List<UsuarioEntity>()
            {
                new UsuarioEntity
                (
                    "Mateus",
                    "Jubileu",
                    "CabeloCresceODedoNao"
                ),
                 new UsuarioEntity
                (
                    "Leandro",
                    "Leco",
                    "Epapapa"
                ),
                 new UsuarioEntity
                (
                    "Cris",
                    "Sla",
                    "cristininha"
                ),
                 new UsuarioEntity
                (
                    "Vanessa",
                    "Vani",
                    "amadogs"
                ),
                new UsuarioEntity
                (
                    "Rodrigo",
                    "Rod",
                    "flamenguista"
                )
            };
        }

        public UsuarioEntity GetByLogin(string login, string senha)
        {

            var entidade = ListaUsuarioEntity.Find(x => x.Login == login && x.Senha == senha);

            return entidade;
        }
    }
}
