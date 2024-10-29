using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Agrolifenet
{
    public class ConeccionaBD
    {
        string connectionsString = "server=localhost\\SQLEXPRESS; database=AgroLifeNet; TrustServerCertificate=True;Integrated Security=True";
        public void Insertar()
        {
           
            using (SqlConnection connection = new SqlConnection(connectionsString))
            {
                try
                {

                    Console.WriteLine("coneccion exitosa");

                    SqlCommand command = new SqlCommand("insertarUsuario", connection) { CommandType = CommandType.StoredProcedure};
                    command.Parameters.AddWithValue("IdentificacionUsuario", "1030685996");
                    command.Parameters.AddWithValue("NombreUsuario", "Paula Andrea");
                    command.Parameters.AddWithValue("ApellidoUsuario", "Gutierrez Rivera");
                    command.Parameters.AddWithValue("FechadenacimientoUsuario", "1998-03-13");
                    command.Parameters.AddWithValue("CorreoelectronicoUsuario", "Paula@hotmail.com");
                    command.Parameters.AddWithValue("NumerotelefonicoUsuario", "3232171316");
                    command.Parameters.AddWithValue("EstadoUsuario", 1);
                    command.Parameters.AddWithValue("FechadecreacionUsuario", "2015-10-20");
                    command.Parameters.AddWithValue("Fechademodificacion", "2024-10-28");
                    command.Parameters.AddWithValue("BloqueoUsuario", 1);
      connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("usuario insertado exitosamente");
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error al conectar" + ex.Message);
                }
            }
        }


        public void Actualizar()
        {
            using (SqlConnection connection = new SqlConnection(connectionsString))
            {
                SqlCommand command = new SqlCommand("ActualizarUsuario", connection) { CommandType = CommandType.StoredProcedure };
                command.Parameters.AddWithValue("IdentificacionUsuario", "1030685996");
                command.Parameters.AddWithValue("NombreUsuario", "Paula Andrea");
                command.Parameters.AddWithValue("ApellidoUsuario", "Gutierrez ");
                command.Parameters.AddWithValue("FechadenacimientoUsuario", "1998-03-13");
                command.Parameters.AddWithValue("CorreoelectronicoUsuario", "Paula@hotmail.com");
                command.Parameters.AddWithValue("NumerotelefonicoUsuario", "3232171316");
                command.Parameters.AddWithValue("EstadoUsuario", 1);
                command.Parameters.AddWithValue("FechadecreacionUsuario", "2015-10-20");
                command.Parameters.AddWithValue("Fechademodificacion", "2024-10-28");
                command.Parameters.AddWithValue("BloqueoUsuario", 1);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Usuario actualizado exitosamente");
            }
        }
        public void Eliminar ()
        {
            using (SqlConnection connection = new SqlConnection(connectionsString))
            {
                SqlCommand command = new SqlCommand("EliminarUsuario", connection) { CommandType = CommandType.StoredProcedure };
                command.Parameters.AddWithValue("@IdUsuario", 5);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("usuario eliminado exitosamente");
            }
        }
        public void Buscar ()
        {
            using (SqlConnection connection = new SqlConnection(connectionsString))
            {
                SqlCommand command = new SqlCommand("BuscarUsuario", connection) { CommandType = CommandType.StoredProcedure };
                command.Parameters.AddWithValue("@IdentificacionUsuario", "1030685996");
                command.Parameters.AddWithValue("@Tipodecargo", "administrador");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) 
                {
                    Console.WriteLine($"IdentificacionUsuario : {reader["IdentificacionUsuario"]}, Tipodecargo : {reader["Tipodecargo"]} ");
                }
            }
        }


    }
}
