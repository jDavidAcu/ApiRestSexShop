using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logica_Usuario
    {
        Datos_Usuario op = new Datos_Usuario();

        public List<USUARIO> SeleccionarUsuarios()
        {
            return op.SeleccionarUsuarios();
        }

        public USUARIO SeleccionarUsuariosPorID(string DNI)
        {
            return op.SeleccionarUsuariosPorID(DNI);
        }

        public bool InsertarUsuario(USUARIO nuevoUsuario)
        {
            return op.InsertarUsuario(nuevoUsuario);
        }

        public bool ActualizarUsuario(USUARIO usuarioActualizado)
        {
            return op.ActualizarUsuario(usuarioActualizado);
        }

        public bool EliminarUsuario(string id)
        {
            return op.EliminarUsuario(id);
        }
    }
}
