using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppVentas.Model;
using AppVentas.Vista;
namespace AppVentas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void lblContraP_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrarP_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                var lista = from usuario in db.tb_usuarios
                            where usuario.Email == txtUsuarioP.Text &&
                            usuario.Contrasena == txtContraP.Text
                            select usuario;
                if (lista.Count() > 0)

                {
                    MessageBox.Show("Bienvenido/a " + txtUsuarioP.Text);

                    frMenu Us = new frMenu();
                    Us.Show();
                    Hide();
                   
                }

                else

                {
                    MessageBox.Show("Usuario o contraseña no validos, por favor verificar");
                }
            }


        }
    }
}
