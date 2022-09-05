using ExamenGym.Layeres.DAL;
using ExamenGym.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGym.Layeres.BLL
{
    public class RutinaBLL
    {
        public static void InsertarRutina(Rutina oRutina)
        {
            RutinaDAL.InsertarRutina(oRutina);
        }

        public static void EliminarRutina(Rutina oRutina)
        {
            RutinaDAL.EliminarRutina(oRutina);
        }
    }
}
