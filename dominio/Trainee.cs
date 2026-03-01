using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Trainee //esta va a ser nuestra clase usuario si tiene permiso de admin  
    {
        public int Id { get; set; }//
        public string Email { get; set; }
        public string pass { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string ImagenPerfil { get; set; }
        public bool Admin { get; set; }

    }
}
