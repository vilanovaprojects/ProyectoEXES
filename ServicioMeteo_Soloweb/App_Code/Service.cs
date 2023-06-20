using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;

public class Service : IService
{

    string cadenaConexion = ConfigurationManager.ConnectionStrings["myConexion"].ConnectionString;

    public List<Meteo> mostrarRegistros()
    {
        List<Meteo> lista = new List<Meteo>();
        try
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            MySqlCommand comand = new MySqlCommand("Readonly", conexion);
            comand.CommandType = CommandType.StoredProcedure;

            MySqlDataReader rd = comand.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    lista.Add(new Meteo
                    {
                        Provincia = rd.GetString(1),
                        FechaPrevision = rd.GetDateTime(2),
                        TempMax = rd.GetDecimal(3),
                        TempMin = rd.GetDecimal(4),
                        Viento = rd.IsDBNull(5) ? 0 : rd.GetInt32(5),
                        Humedad = rd.IsDBNull(6) ? 0 : rd.GetDecimal(6),
                        Precipitaciones = rd.IsDBNull(7) ? 0 : rd.GetInt32(7),
                        Comentarios = rd.IsDBNull(8) ? "" : rd.GetString(8),
                        Valoracion = rd.IsDBNull(9) ? "" : rd.GetString(9),
                        Mapa = rd.IsDBNull(10) ? null : (byte[])rd.GetValue(10)
                });
                }
            }
            else
            {
                throw new Exception("No hay Registros");
            }

            conexion.Close();
        }
        catch (Exception ex)
        {
            throw new Exception("Error :", ex);
        }
        return lista;
    }
}
