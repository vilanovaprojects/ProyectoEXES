using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IService
{

    [OperationContract]
    List<Meteo> mostrarRegistros();
}

[DataContract]
public class Meteo
{
    string provincia;
    DateTime fecha_prevision;
    decimal temp_max;
    decimal temp_min;
    int viento;
    decimal humedad;
    int precipitaciones;
    string comentarios;
    string valoracion;
    byte[] mapa;


    [DataMember]
    public string Provincia
    {
        get { return provincia; }
        set { provincia = value; }
    }
    [DataMember]
    public DateTime FechaPrevision
    {
        get { return fecha_prevision; }
        set { fecha_prevision = value; }
    }
    [DataMember]
    public decimal TempMax
    {
        get { return temp_max; }
        set { temp_max = value; }
    }
    [DataMember]
    public decimal TempMin
    {
        get { return temp_min; }
        set { temp_min = value; }
    }
    [DataMember]
    public int Viento
    {
        get { return viento; }
        set { viento = value; }
    }
    [DataMember]
    public decimal Humedad
    {
        get { return humedad; }
        set { humedad = value; }
    }
    [DataMember]
    public int Precipitaciones
    {
        get { return precipitaciones; }
        set { precipitaciones = value; }
    }
    [DataMember]
    public string Comentarios
    {
        get { return comentarios; }
        set { comentarios = value; }
    }
    [DataMember]
    public string Valoracion
    {
        get { return valoracion; }
        set { valoracion = value; }
    }
    [DataMember]
    public byte[] Mapa
    {
        get { return mapa; }
        set { mapa = value; }
    }




}

