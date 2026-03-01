using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace negocio
{
    public class UsuarioNegocio // 
    {
        public bool Loguear(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT id, admin FROM USERS WHERE email = @email AND pass = @pass");
                datos.setearParametro("@email", usuario.User);
                datos.setearParametro("@pass", usuario.Pass);

                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["id"];

                    bool esAdmin = (bool)datos.Lector["admin"];
                    usuario.TipoUsuario = esAdmin ? TipoUsuario.ADMIN : TipoUsuario.NORMAL;

                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
