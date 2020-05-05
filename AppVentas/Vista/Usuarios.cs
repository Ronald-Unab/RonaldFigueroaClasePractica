using AppVentas.Model;
using System;
using System.Linq;
using System.Windows.Forms;
using AppVentas.Vista;

namespace AppVentas.Vista
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        tb_usuarios user = new tb_usuarios();
        void cargardatos() {

            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                dtvUsuarios.DataSource = db.tb_usuarios.ToList();
                //var tb_usuarios = db.tb_usuarios;
                //foreach (var iterardatosTbUsuarios in tb_usuarios)
                //{
                //    dtvUsuarios.Rows.Add(iterardatosTbUsuarios.Email,
                //        iterardatosTbUsuarios.Contrasena,
                //        iterardatosTbUsuarios.Id);
                //}
                
            }
        }
        void LimpiarDatos()
        {
            txtUsuarioU.Text = "";
            txtContrasenaU.Text = "";
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargardatos();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities()) {
                String Id = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();
                user = db.tb_usuarios.Find(int.Parse(Id));
                db.tb_usuarios.Remove(user);
                db.SaveChanges();
            }
            cargardatos();
            LimpiarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities()) {
                user.Email = txtUsuarioU.Text;
                user.Contrasena = txtContrasenaU.Text;
                db.tb_usuarios.Add(user);
                db.SaveChanges();
            }
            cargardatos();
            LimpiarDatos();
        }

        private void dtvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                String Email = dtvUsuarios.CurrentRow.Cells[1].Value.ToString();
                String Contra = dtvUsuarios.CurrentRow.Cells[2].Value.ToString();
                txtUsuarioU.Text = Email;
                txtContrasenaU.Text = Contra;
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                String Id = dtvUsuarios.CurrentRow.Cells[0].Value.ToString();
                int Idc = int.Parse(Id);
                user = db.tb_usuarios.Where(VerificarID => VerificarID.Id == Idc).First();
                user.Email = txtUsuarioU.Text;
                user.Contrasena = txtContrasenaU.Text;
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            cargardatos();
            LimpiarDatos();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            cargardatos();
            LimpiarDatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frMenu Regresar = new frMenu();
            Regresar.Show();
            Hide();
        }
    }
}
