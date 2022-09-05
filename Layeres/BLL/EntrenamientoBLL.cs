using ExamenGym.Layeres.DAL;
using ExamenGym.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGym.Layeres.BLL
{
    public class EntrenamientoBLL
    {
        public static List<Entrenamiento> SeleccionarEntrenamientosPorSexoEdad(char codigoSexo, int edad)
        {
            return EntrenamientoDAL.SeleccionarEntrenamientosPorSexoEdad(codigoSexo,edad);
        }

        public static List<Entrenamiento> SeleccionarEntrenamientosPorCedula(long cedula)
        {
            return EntrenamientoDAL.SeleccionarEntrenamientosPorCedula(cedula);
        }
    }
}
