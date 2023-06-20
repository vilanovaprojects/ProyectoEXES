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


    public bool MiMetodo(UserDetails userDetails)
    {
        // Valida los datos de seguridad
        if (userDetails.IsValid())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int NuevoRegistro(UserDetails userDetails, Meteo registro)
    {
        try
        {
            if (userDetails != null)
            {
                if (userDetails.IsValid())
                {
                    int res = 0;
                    try
                    {
                        MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                        conexion.Open();
                        MySqlCommand comand = new MySqlCommand("IARegistro", conexion);
                        comand.CommandType = CommandType.StoredProcedure;

                        comand.Parameters.AddWithValue("operacion", "I");
                        comand.Parameters.AddWithValue("Iprovincia", registro.Provincia);
                        comand.Parameters.AddWithValue("Ifecha_prevision", registro.FechaPrevision);
                        comand.Parameters.AddWithValue("Itemp_max", registro.TempMax);
                        comand.Parameters.AddWithValue("Itemp_min", registro.TempMin);
                        comand.Parameters.AddWithValue("Iviento", registro.Viento);
                        comand.Parameters.AddWithValue("Ihumedad", registro.Humedad);
                        comand.Parameters.AddWithValue("Iprecipitaciones", registro.Precipitaciones);
                        comand.Parameters.AddWithValue("Icomentarios", registro.Comentarios);
                        comand.Parameters.AddWithValue("Ivaloracion", registro.Valoracion);
                        comand.Parameters.AddWithValue("Iimagen", registro.Mapa);


                        res = comand.ExecuteNonQuery();

                        conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al Insertar", ex);
                    }
                    return res;
                }
                else
                {
                    throw new Exception("Usuario y/o contraseña inválidos");
                }
            }
            else
            {
                throw new Exception("Usuario y/o contraseña inválidos");
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error" + ex.Message);
        }

    }

    public int EditarRegistro(UserDetails userDetails, Meteo registro)
    {
        try
        {
            if (userDetails != null)
            {
                if (userDetails.IsValid())
                {
                    int res = 0;
                    try
                    {
                        MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                        conexion.Open();
                        MySqlCommand comand = new MySqlCommand("IARegistro", conexion);
                        comand.CommandType = CommandType.StoredProcedure;

                        comand.Parameters.AddWithValue("operacion", "A");
                        comand.Parameters.AddWithValue("Iprovincia", registro.Provincia);
                        comand.Parameters.AddWithValue("Ifecha_prevision", registro.FechaPrevision);
                        comand.Parameters.AddWithValue("Itemp_max", registro.TempMax);
                        comand.Parameters.AddWithValue("Itemp_min", registro.TempMin);
                        comand.Parameters.AddWithValue("Iviento", registro.Viento);
                        comand.Parameters.AddWithValue("Ihumedad", registro.Humedad);
                        comand.Parameters.AddWithValue("Iprecipitaciones", registro.Precipitaciones);
                        comand.Parameters.AddWithValue("Icomentarios", registro.Comentarios);
                        comand.Parameters.AddWithValue("Ivaloracion", registro.Valoracion);
                        comand.Parameters.AddWithValue("Iimagen", registro.Mapa);

                        res = comand.ExecuteNonQuery();

                        conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al Editar", ex);
                    }
                    return res;
                }
                else
                {
                    throw new Exception("Usuario y/o contraseña inválidos");
                }
            }
            else
            {
                throw new Exception("Usuario y/o contraseña inválidos");
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error" + ex.Message);
        }




    }

    public int EliminarRegistro(UserDetails userDetails, string provincia, DateTime fechaprevision)
    {
        try
        {
            if (userDetails != null)
            {
                if (userDetails.IsValid())
                {
                    int res = 0;
                    try
                    {
                        MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                        conexion.Open();
                        MySqlCommand comand = new MySqlCommand("BERegistro", conexion);
                        comand.CommandType = CommandType.StoredProcedure;

                        comand.Parameters.AddWithValue("operacion", "E");
                        comand.Parameters.AddWithValue("Iprovincia", provincia);
                        comand.Parameters.AddWithValue("Ifecha_prevision", fechaprevision);

                        res = comand.ExecuteNonQuery();

                        conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al Eliminar", ex);
                    }
                    return res;
                }
                else
                {
                    throw new Exception("Usuario y/o contraseña inválidos");
                }
            }
            else
            {
                throw new Exception("Usuario y/o contraseña inválidos");
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error" + ex.Message);
        }



    }

    public Meteo BuscarRegistro(UserDetails userDetails, string provincia, DateTime fechaprevision)
    {
        try
        {
            if (userDetails != null)
            {
                if (userDetails.IsValid())
                {
                    Meteo newRegistro = new Meteo();
                    try
                    {
                        MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                        conexion.Open();
                        MySqlCommand comand = new MySqlCommand("BERegistro", conexion);
                        comand.CommandType = CommandType.StoredProcedure;

                        comand.Parameters.AddWithValue("operacion", "S");
                        comand.Parameters.AddWithValue("Iprovincia", provincia);
                        comand.Parameters.AddWithValue("Ifecha_prevision", fechaprevision);



                        MySqlDataReader rd = comand.ExecuteReader();
                        if (rd.HasRows)
                        {
                            if (rd.Read())
                            {
                                newRegistro.Provincia = rd.GetString(1);
                                newRegistro.FechaPrevision = rd.GetDateTime(2);
                                newRegistro.TempMax = rd.GetDecimal(3);
                                newRegistro.TempMin = rd.GetDecimal(4);
                                newRegistro.Viento = rd.GetInt32(5);
                                newRegistro.Humedad = rd.GetDecimal(6);
                                newRegistro.Precipitaciones = rd.GetInt32(7);
                                newRegistro.Comentarios = rd.IsDBNull(8) ? "" : rd.GetString(8);
                                newRegistro.Valoracion = rd.IsDBNull(9) ? "" : rd.GetString(9);
                                newRegistro.Mapa = rd.IsDBNull(10) ? null : (byte[])rd.GetValue(10);
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
                        throw new FaultException<string>("Error al buscar", ex.Message);
                    }
                    return newRegistro;
                }
                else
                {
                    throw new Exception("Usuario y/o contraseña inválidos");
                }
            }
            else
            {
                throw new Exception("Usuario y/o contraseña inválidos");
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error" + ex.Message);
        }



    }




    public List<Meteo> mostrarRegistros(UserDetails userDetails)
    {
        try
        {
            if (userDetails != null)
            {
                if (userDetails.IsValid())
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
                else
                {
                    throw new Exception("Usuario y/o contraseña inválidos");
                }
            }
            else
            {
                throw new Exception("Usuario y/o contraseña inválidos");
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error" + ex.Message);
        }

    }


}



