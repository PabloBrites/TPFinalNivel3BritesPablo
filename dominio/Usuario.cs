using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public enum TipoUsuario //enum = enumeración: 
    {
        NORMAL = 1, //para usuario normal va a guardar valor 1 
        ADMIN = 2, //para usuario Admin va a guardar valor 2
    }
    public class Usuario
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

        public Usuario(string user, string pass, bool admin) //si admin es true es admin sino normal
        {
            User = user;
            Pass = pass;
            TipoUsuario = admin ? TipoUsuario.ADMIN : TipoUsuario.NORMAL;
        }
    }
}
