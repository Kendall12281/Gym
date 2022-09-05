using ExamenGym.Layeres.DAL;
using ExamenGym.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGym.Layeres.BLL
{
    public class ClienteBLL
    {
        public static void InsertarCliente(Cliente oCliente)
        {
            ClienteDAL.InsertarCliente(oCliente);
        }

        public static Cliente SeleccionarClientePorCedula(long cedula)
        {
            return ClienteDAL.SeleccionarClientePorCedula(cedula);
        }

        public static List<Cliente> SeleccionarClientes()
        {
            return ClienteDAL.SeleccionarClientes();
        }

        //Calculos
        public static double ObtenerICA(Cliente oCliente)
        {
            return ClienteDAL.ObtenerICA(oCliente);
        }
        public static double ObtenerIMC(Cliente oCliente)
        {
            return ClienteDAL.ObtenerIMC(oCliente);
        }
        public static double ObtenerIMB(Cliente oCliente)
        {
            return ClienteDAL.ObtenerIMB(oCliente);
        }
    }
}
