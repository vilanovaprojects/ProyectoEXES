using FormsMeteo.MeteoService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsMeteo
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            //f.SetFormLogInInstance(this); // Pasar la instancia del formulario FormLogIn a Form1
            //f.Show();
            //this.Hide();

           
            UserDetails userDetails = new UserDetails()
            {
                userName = txtUser.Text,
                password = txtPass.Text
            };
            MeteoIServiceClient proxy = new MeteoIServiceClient();

            if (proxy.MiMetodo(userDetails))
            {
                Form1 f = new Form1();

                //f.UserName = txtUser.Text;
                //f.Password = txtPass.Text;
                f.userDetails = userDetails;
                f.SetFormLogInInstance(this); // Pasar la instancia del formulario FormLogIn a Form1
                f.Show();
                this.Hide();
            }
            
            else
            {
                txtErrorAcceso.Text = "usuario y/o contraseña incorrectos";
            }
            

            // Cerrar el proxy del servicio WCF
            proxy.Close();

        }
    }
}
