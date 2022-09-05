using ExamenGym.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGym.Layeres.DAL
{
    public class EntrenamientoDAL
    {
        public static List<Entrenamiento> SeleccionarEntrenamientosPorSexoEdad(char codigoSexo, int edad)
        {
            try
            {
                List<Entrenamiento> ListaEntrenamientos = new List<Entrenamiento>();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"PA_SeleccionarEntrenamientosPorSexoYEdad";
                    var comando = new SqlCommand(sql);

                    comando.Parameters.AddWithValue("@CodigoSexo", codigoSexo);
                    comando.Parameters.AddWithValue("@Edad", edad);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Entrenamiento oEntrenamiento = new Entrenamiento()
                        {
                            Id = (reader["Id"].ToString()),
                            CodigoSexo = Convert.ToChar(reader["CodigoSexo"].ToString()),
                            EdadMinima = Convert.ToInt32(reader["EdadMinima"].ToString()),
                            EdadMaxima = Convert.ToInt32(reader["EdadMaxima"].ToString()),
                            Descripcion = reader["Descripcion"].ToString()
                        };
                        ListaEntrenamientos.Add(oEntrenamiento);
                    }
                }
                return ListaEntrenamientos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Entrenamiento> SeleccionarEntrenamientosPorCedula(long cedula)
        {
            try
            {
                List<Entrenamiento> ListaEntrenamientos = new List<Entrenamiento>();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"PA_SeleccionarEntrenamientosPorCedula";
                    var comando = new SqlCommand(sql);

                    comando.Parameters.AddWithValue("@Cedula", cedula);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Entrenamiento oEntrenamiento = new Entrenamiento()
                        {
                            Id = (reader["Id"].ToString()),
                            CodigoSexo = Convert.ToChar(reader["CodigoSexo"].ToString()),
                            EdadMinima = Convert.ToInt32(reader["EdadMinima"].ToString()),
                            EdadMaxima = Convert.ToInt32(reader["EdadMaxima"].ToString()),
                            Descripcion = reader["Descripcion"].ToString()
                        };
                        ListaEntrenamientos.Add(oEntrenamiento);
                    }
                }
                return ListaEntrenamientos;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
