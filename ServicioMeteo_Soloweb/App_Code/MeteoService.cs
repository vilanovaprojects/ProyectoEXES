using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System.Runtime.Remoting.Contexts;

public class MeteoService : MeteoIService
{
    string cadenaConexion = ConfigurationManager.ConnectionStrings["myConexion"].ConnectionString;



    public List<Meteo> mostrarRegistros()
    {
        List<Meteo> lista = new List<Meteo>();
        try
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            MySqlCommand comand = new MySqlCommand("BERegistro", conexion);
            comand.CommandType = CommandType.StoredProcedure;

            comand.Parameters.AddWithValue("operacion", "");
            comand.Parameters.AddWithValue("Iprovincia", null);
            comand.Parameters.AddWithValue("Ifecha_prevision", null);

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
            throw new Exception("Error al Buscar", ex);
        }
        return lista;

    }


}



