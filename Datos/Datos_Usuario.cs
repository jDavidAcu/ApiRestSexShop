using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class Datos_Usuario
    {
        EntitiesPEPE_SEX_SHOP _contexto;

        public Datos_Usuario()
        {
            _contexto = new EntitiesPEPE_SEX_SHOP();
            _contexto.Configuration.ProxyCreationEnabled = false;
        }
        public List<USUARIO> SeleccionarUsuarios()
        {
            return _contexto.USUARIO.ToList();
        }

        public USUARIO SeleccionarUsuariosPorID(string DNI)
        {
            return _contexto.USUARIO.Where(d => d.USU_DNI == DNI).SingleOrDefault();
        }

        public bool InsertarUsuario(USUARIO nuevoUsuario)
        {
            bool insert = false;
            if (insert == false)
            {
                _contexto.USUARIO.Add(nuevoUsuario);
                _contexto.SaveChanges();
                insert = true;
                return insert;
            }
            return insert;
        }

        public bool ActualizarUsuario(USUARIO usuarioActualizado)
        {
            bool actualizado = false;
            var usuarioExistente = _contexto.USUARIO.Find(usuarioActualizado.USU_DNI);
            if (usuarioExistente != null)
            {
                usuarioExistente.USU_NOMBRE = usuarioActualizado.USU_NOMBRE;
                usuarioExistente.USU_CONTRASENA = usuarioActualizado.USU_CONTRASENA;
                _contexto.SaveChanges();
                actualizado = true;
            }
            return actualizado;
        }

        public bool EliminarUsuario(string id)
        {
            bool eliminado = false;
            var usuarioAEliminar = _contexto.USUARIO.Find(id);
            if (usuarioAEliminar != null)
            {
                _contexto.USUARIO.Remove(usuarioAEliminar);
                _contexto.SaveChanges();
                eliminado = true;
            }
            return eliminado;
        }
    }
}
