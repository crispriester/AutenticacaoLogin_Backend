using Negocio.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Interfaces
{
    public interface IUsuarioService
    {
        public (int, object) Insert(UsuarioDto usuarioDto);

        //public UsuarioRetornoDto GetById(Guid id);

        //public (int, object) Put(Guid id, UsuarioDto usuarioDto);

        //public (int, object) Patch(Guid id, UsuarioDto usuarioDto);

        //public (int, object) Delete(Guid id);
    }
}
