using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppVentas.Vista;

namespace AppVentas.Vista
{
    public partial class frMenu : Form
    {
        public frMenu()
        {
            InitializeComponent();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roles Rol = new Roles();
            Rol.Show();
            Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios Us = new Usuarios();
            Us.Show();
            Hide();
        }
    }
}
