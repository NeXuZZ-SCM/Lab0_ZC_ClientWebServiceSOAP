using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Usuarios
    {
        #region ABM

        #region Alta
        public static int AgregarUsuario(Entidades.Usuario Usuario)
        {
            return Datos.UsuariosCRUD.AgregarUsuario(Usuario);
        }
        #endregion

        #region BAJA
        public static void EliminarUsuario(Entidades.Usuario usuario)
        {
            Datos.UsuariosCRUD.EliminarUsuario(usuario);
        }
        #endregion

        #region Modificacion
        public static void EditarUsuarios(Entidades.Usuario usuario)
        {
            Datos.UsuariosCRUD.EditarUsuarios(usuario);
        }
        #endregion


        #endregion

        #region Show Table
        public static DataTable obtenerTabla()
        {
            return Datos.UsuariosCRUD.ObtenerTabla();
        }
        #endregion

    }
}
