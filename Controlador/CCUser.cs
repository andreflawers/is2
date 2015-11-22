using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Modelo;

namespace Controlador
{
    public class CCUser
    {

        CDuser oCDUser = new CDuser();
        public bool validateUSer(string email , string clave)
        {
            CEuser oCEuser = new CEuser();
            oCEuser.id_usuario = email.Trim();
            oCEuser.clave = clave.Trim();
            oCEuser.id_Rol = "";
            return oCDUser.userValidate(oCEuser);
        }

    }
}
