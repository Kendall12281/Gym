using ExamenGym.Layeres.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGym.Layeres.DAL
{
    public class ClienteDAL
    {
        public static void InsertarCliente(Cliente oCliente)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"PA_InsertarCliente";
                    var comando = new SqlCommand(sql);


                    comando.Parameters.AddWithValue("@Cedula", oCliente.Cedula);
                    comando.Parameters.AddWithValue("@Nombre", oCliente.Nombre);
                    comando.Parameters.AddWithValue("@CodigoSexo", oCliente.CodigoSexo);
                    comando.Parameters.AddWithValue("@FechaNacimiento", oCliente.FechaNacimiento);
                    comando.Parameters.AddWithValue("@Peso", oCliente.Peso);
                    comando.Parameters.AddWithValue("@Estatura", oCliente.Estatura);
                    comando.Parameters.AddWithValue("@Cintura", oCliente.Cintura);
                    comando.Parameters.AddWithValue("@Foto", oCliente.Foto);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static Cliente SeleccionarClientePorCedula(long cedula)
        {
            try
            {
                Cliente cliente = new Cliente();

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"PA_SeleccionarClientePorCedula";
                    var comando = new SqlCommand(sql);

                    comando.Parameters.AddWithValue("@Cedula", cedula);

                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        byte[] fotografia = null;
                        if (reader["Foto"] != DBNull.Value)
                        {
                            fotografia = (byte[])reader["Foto"];
                        }

                        Cliente Ocliente = new Cliente()
                        {
                            Cedula = Convert.ToInt64(reader["Cedula"].ToString()),
                            Nombre = reader["Nombre"].ToString(),
                            CodigoSexo = Convert.ToChar(reader["CodigoSexo"].ToString()),
                            FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"].ToString()),
                            Peso = Convert.ToInt16(reader["Peso"].ToString()),
                            Estatura = Convert.ToInt16(reader["Estatura"].ToString()),
                            Cintura = Convert.ToInt16(reader["Cintura"].ToString()),
                            Foto = fotografia
                        };

                        if(Ocliente == null)
                        {
                            cliente = null;
                        }
                        else
                        {
                            cliente = Ocliente;
                        }
                    }

                    return cliente;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Cliente> SeleccionarClientes()
        {
            try
            {
                List<Cliente> ListaClientes = new List<Cliente>();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    string sql = @"PA_SeleccionarClientes";
                    var comando = new SqlCommand(sql);


                    comando.CommandType = System.Data.CommandType.StoredProcedure;

                    var reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        byte[] fotografia = null;
                        if (reader["Foto"] != DBNull.Value)
                        {
                            fotografia = (byte[])reader["Foto"];
                        }

                        Cliente Ocliente = new Cliente()
                        {
                            Cedula = Convert.ToInt64(reader["Cedula"].ToString()),
                            Nombre = reader["Nombre"].ToString(),
                            CodigoSexo = Convert.ToChar(reader["CodigoSexo"].ToString()),
                            FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"].ToString()),
                            Peso = Convert.ToInt16(reader["Peso"].ToString()),
                            Estatura = Convert.ToInt16(reader["Estatura"].ToString()),
                            Cintura = Convert.ToInt16(reader["Cintura"].ToString()),
                            Foto = fotografia
                        };

                        ListaClientes.Add(Ocliente);
                    }
                }
                return ListaClientes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Calculos

        public static double ObtenerIMC(Cliente oCliente)
        {
            try
            {
                double total = ((oCliente.Peso) * ((oCliente.Estatura / 100) * (oCliente.Estatura / 100)));
                return total;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static double ObtenerICA(Cliente oCliente)
        {
            try
            {
                double total = oCliente.Cintura * oCliente.Estatura;
                return total;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static double ObtenerIMB(Cliente oCliente)
        {
            try
            {
                double total = 0;

                switch (oCliente.CodigoSexo)
                {
                    case 'H':
                        total = 66 + (13.7 * oCliente.Peso) + (5 * (oCliente.Estatura / 100)) - (6.8 * oCliente.Edad);
                        break;
                    default:
                        total = 655 + (9.6 * oCliente.Peso) + (1.8 * (oCliente.Estatura / 100)) - (4.7 * oCliente.Edad);
                        break;
                }
                return total;
            }
            catch (Exception)
            {

                throw;
            }
        }
        

        
    }
}
