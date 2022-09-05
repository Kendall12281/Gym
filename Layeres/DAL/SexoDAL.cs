using ExamenGym.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGym.Layeres.DAL
{
    public class SexoDAL
    {
        public static List<Sexo> SeleccionarSexos()
        {
            try
            {
                List<Sexo> ListaSexos = new List<Sexo>();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"PA_SeleccionarSexos";
                    var comando = new SqlCommand(sql);


                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        Sexo oSexo = new Sexo()
                        {
                            Codigo = Convert.ToChar(reader["Codigo"].ToString()),
                            Nombre = reader["Nombre"].ToString()

                        };
                        ListaSexos.Add(oSexo);
                    }

                    return ListaSexos;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
