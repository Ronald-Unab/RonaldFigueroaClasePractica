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

namespace AppVentas.Vista
{
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {

                var Jointables = from tbusu in bd.tb_usuarios
                                 from rolesUsuarios in bd.Roles
                                 where tbusu.Id == rolesUsuarios.Id_RolesUsuarios

                                 select new
                                 {
                                     Id = tbusu.Id,
                                     Email = tbusu.Email,
                                     Tipo_Rol = rolesUsuarios.Tipo
                                 };
                dtVista.DataSource = Jointables.ToList();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frMenu Regresar = new frMenu();
            Regresar.Show();
            Hide();
        }
    }
}
