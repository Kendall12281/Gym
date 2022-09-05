using ExamenGym.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGym.Layeres.DAL
{
   public class RutinaDAL
    {
        public static void InsertarRutina(Rutina oRutina)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"PA_InsertarRutina";
                    var comando = new SqlCommand(sql);

                    comando.Parameters.AddWithValue("@Cedula", oRutina.Cedula);
                    comando.Parameters.AddWithValue("@EntrenamientoId", oRutina.EntrenamientoId);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    
                    }
                }
            catch (Exception)
            {

                throw;
            }
        }

        public static void EliminarRutina(Rutina oRutina)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"PA_EliminarRutina";
                    var comando = new SqlCommand(sql);

                    comando.Parameters.AddWithValue("@Cedula", oRutina.Cedula);
                    comando.Parameters.AddWithValue("@EntrenamientoId", oRutina.EntrenamientoId);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
