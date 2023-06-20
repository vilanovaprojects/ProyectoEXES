using FormsMeteo.MeteoService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormsMeteo
{
    public partial class Form1 : Form
    {
        bool hayimagen = false;
        private FormLogIn formLogIn;

        public UserDetails userDetails { get; set; }

        public Form1()
        {
            InitializeComponent();
            CargarComboboxes();
            CargarMapaInicial();
        }

        public bool Hayimagen
        {
            get { return hayimagen; }
            set { hayimagen = value; }
        }

        public void CargarComboboxes()
        {

            string[] Provincias;

            string todaslasprovincias = Properties.Resources.Provincias.ToString();
            Provincias = todaslasprovincias.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < Provincias.Length; i++)
            {
                comboProvincias.Items.Add(Provincias[i]);
            }
            comboProvincias.SelectedIndex = 0;

        }

        public void CargarMapaInicial()
        {
            Hayimagen = false;
            pbMapa.Image = Properties.Resources.sinImagen;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mensajeBuscar.Text = "";
            MeteoIServiceClient cliente = new MeteoIServiceClient();
            Meteo registro = new Meteo();

            try
            {
                registro = cliente.BuscarRegistro(userDetails, comboProvincias.Text, DateTime.Parse(dateFechaPrevision.Text));
                decimalTempMax.Text = registro.TempMax.ToString();
                decimalTempMin.Text = registro.TempMin.ToString();
                intViento.Text = registro.Viento.ToString();
                decimalHumedad.Text = registro.Humedad.ToString();
                intPrecipitaciones.Text = registro.Precipitaciones.ToString();
                txtValoracion.Text = registro.Valoracion;
                txtComentarios.Text = registro.Comentarios;

                if (registro.Mapa != null) { pbMapa.Image = clsImagen.ByteToImage(registro.Mapa); }
                else { CargarMapaInicial(); }


            }

            catch (FaultException<string> ex)
            {
                // Captura una excepción del servicio web que contiene el detalle del error
                mensajeBuscar.Text = "Error: " + ex.Detail;
                CargarMapaInicial();
            }

            catch (Exception ex)
            {
                mensajeBuscar.Text = ex.Message;
                CargarMapaInicial();
            }


        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            mensajeGrid.Text = "";
            try
            {
                MeteoIServiceClient cliente = new MeteoIServiceClient();
                gridViewRegistros.DataSource = cliente.mostrarRegistros(userDetails);
                gridViewRegistros.Refresh();

                gridViewRegistros.Columns["provincia"].DisplayIndex = 0;
                gridViewRegistros.Columns["FechaPrevision"].DisplayIndex = 1;
                gridViewRegistros.Columns["TempMax"].DisplayIndex = 2;
                gridViewRegistros.Columns["TempMin"].DisplayIndex = 3;
                gridViewRegistros.Columns["Viento"].DisplayIndex = 4;
                gridViewRegistros.Columns["Humedad"].DisplayIndex = 5;
                gridViewRegistros.Columns["Precipitaciones"].DisplayIndex = 6;
                gridViewRegistros.Columns["Mapa"].Visible = false;
            }
            catch (FaultException<string> ex)
            {
                // Captura una excepción del servicio web que contiene el detalle del error
                mensajeGrid.Text = "Error: " + ex.Detail;
            }

            catch (Exception ex)
            {
                mensajeGrid.Text = ex.Message;
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            mensajeNuevEditElim.Text = "";
            try
            {
                MeteoIServiceClient cliente = new MeteoIServiceClient();
                Meteo registro = new Meteo();

                /*---------Función para quitar las máscaras de los Maskedtextbox---------*/     //quitar de aquí y meter en clase aparte
                Func<string, string, int> obtenerNumeroDesdeTexto = (texto, unidad) =>
                {
                    int numero;
                    int.TryParse(texto.Replace($" {unidad}", ""), out numero);
                    return numero;
                };

                string unidadKmh = "Km/h";
                string unidadMmh = "mm/h";
                string valorviento = intViento.Text;
                string valorprecipitaciones = intPrecipitaciones.Text;

                registro.Provincia = comboProvincias.Text;
                registro.FechaPrevision = DateTime.Parse(dateFechaPrevision.Text);
                registro.TempMax = decimalTempMax.Value;
                registro.TempMin = decimalTempMin.Value;
                registro.Viento = obtenerNumeroDesdeTexto(valorviento, unidadKmh);
                registro.Humedad = decimalHumedad.Value;
                registro.Precipitaciones = obtenerNumeroDesdeTexto(valorprecipitaciones, unidadMmh);
                registro.Comentarios = txtComentarios.Text;
                registro.Valoracion = txtValoracion.Text;
                if (Hayimagen) { registro.Mapa = clsImagen.ImageToByte(pbMapa.Image); }
                else { registro.Mapa = null; }


                if (cliente.NuevoRegistro(userDetails, registro) > 0)
                {
                    mensajeNuevEditElim.Text = "Contacto agregado con Exito...";
                }
            }

            catch (Exception ex)
            {
                mensajeNuevEditElim.Text = ex.Message;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            mensajeNuevEditElim.Text = "";
            try
            {
                MeteoIServiceClient cliente = new MeteoIServiceClient();
                Meteo registro = new Meteo();

                /*---------Función para quitar las máscaras de los Maskedtextbox---------*/
                Func<string, string, int> obtenerNumeroDesdeTexto = (texto, unidad) =>
                {
                    int numero;
                    int.TryParse(texto.Replace($" {unidad}", ""), out numero);
                    return numero;
                };

                string unidadKmh = "Km/h";
                string unidadMmh = "mm/h";
                string valorviento = intViento.Text;
                string valorprecipitaciones = intPrecipitaciones.Text;

                registro.Provincia = comboProvincias.Text;
                registro.FechaPrevision = DateTime.Parse(dateFechaPrevision.Text);
                registro.TempMax = decimalTempMax.Value;
                registro.TempMin = decimalTempMin.Value;
                registro.Viento = obtenerNumeroDesdeTexto(valorviento, unidadKmh);
                registro.Humedad = decimalHumedad.Value;
                registro.Precipitaciones = obtenerNumeroDesdeTexto(valorprecipitaciones, unidadMmh);
                registro.Comentarios = txtComentarios.Text;
                registro.Valoracion = txtValoracion.Text;
                if (Hayimagen) { registro.Mapa = clsImagen.ImageToByte(pbMapa.Image); }
                else { registro.Mapa = null; }

                if (cliente.EditarRegistro(userDetails, registro) > 0)
                {
                    mensajeNuevEditElim.Text = "Contacto editado con Exito...";
                }
            }

            catch (Exception ex)
            {
                mensajeNuevEditElim.Text = ex.Message;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mensajeNuevEditElim.Text = "";
            try
            {
                MeteoIServiceClient cliente = new MeteoIServiceClient();

                if (cliente.EliminarRegistro(userDetails, comboProvincias.Text, DateTime.Parse(dateFechaPrevision.Text)) > 0)
                {
                    mensajeNuevEditElim.Text = "Registro eliminado con Exito...";
                }
            }

            catch (Exception ex)
            {
                mensajeNuevEditElim.Text = ex.Message;
            }


        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Seleccione una imagen";
            dialog.Filter = "Archivos de imagen| *.jpg; *.jpeg";
            dialog.InitialDirectory = "C:\\Users\\Moises\\Pictures";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string archivoSeleccionado = dialog.FileName;
                long tamanoArchivoBytes = new FileInfo(archivoSeleccionado).Length;       // Validar el tamaño del archivo en bytes
                long tamanoArchivoKB = tamanoArchivoBytes / 1024;                                   // Convertir bytes a kilobytes (KB)
                long limiteTamanoKB = 40;                                                           // Establecer el límite de tamaño permitido en KB (50 KB en este ejemplo)

                if (tamanoArchivoKB > limiteTamanoKB)
                {
                    MessageBox.Show("El archivo seleccionado excede el límite de tamaño permitido de " + limiteTamanoKB + " KB.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pbMapa.ImageLocation = dialog.FileName;
                    Hayimagen = true;
                }

            }

        }

        private void btnBorrarImagen_Click(object sender, EventArgs e)
        {
            CargarMapaInicial();
            hayimagen = false;
        }



        // Método para recibir la instancia del formulario FormLogIn
        public void SetFormLogInInstance(FormLogIn formLogIn)
        {
            this.formLogIn = formLogIn;
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (formLogIn != null)
            {
                formLogIn.Close(); // Cerrar el formulario FormLogIn
            }
        }


        //Contror para no pasarse de longitud en los textboxes
        private void txtValoracion_TextChanged(object sender, EventArgs e)
        {

            if (txtValoracion.Text.Length > 40)
            {
                txtValoracion.Text = txtValoracion.Text.Substring(0, 40);
                txtValoracion.SelectionStart = 40;
            }

        }

        private void txtComentarios_TextChanged(object sender, EventArgs e)
        {
            if (txtComentarios.Text.Length > 250)
            {
                txtComentarios.Text = txtValoracion.Text.Substring(0, 40);
                txtComentarios.SelectionStart = 40;
            }
        }
    }
}
