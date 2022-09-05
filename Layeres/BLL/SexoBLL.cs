using ExamenGym.Layeres.DAL;
using ExamenGym.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGym.Layeres.BLL
{
    public class SexoBLL
    {
        public static List<Sexo> SeleccionarSexos()
        {
            return SexoDAL.SeleccionarSexos();
        }

    }
}
