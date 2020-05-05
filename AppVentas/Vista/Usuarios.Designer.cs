namespace AppVentas.Vista
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtUsuarioU = new System.Windows.Forms.TextBox();
            this.txtContrasenaU = new System.Windows.Forms.TextBox();
            this.lblUsuarioU = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dtvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(332, 22);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtUsuarioU
            // 
            this.txtUsuarioU.Location = new System.Drawing.Point(12, 139);
            this.txtUsuarioU.Name = "txtUsuarioU";
            this.txtUsuarioU.Size = new System.Drawing.Size(238, 20);
            this.txtUsuarioU.TabIndex = 2;
            // 
            // txtContrasenaU
            // 
            this.txtContrasenaU.Location = new System.Drawing.Point(12, 215);
            this.txtContrasenaU.Name = "txtContrasenaU";
            this.txtContrasenaU.PasswordChar = '*';
            this.txtContrasenaU.Size = new System.Drawing.Size(238, 20);
            this.txtContrasenaU.TabIndex = 3;
            // 
            // lblUsuarioU
            // 
            this.lblUsuarioU.AutoSize = true;
            this.lblUsuarioU.Location = new System.Drawing.Point(13, 120);
            this.lblUsuarioU.Name = "lblUsuarioU";
            this.lblUsuarioU.Size = new System.Drawing.Size(43, 13);
            this.lblUsuarioU.TabIndex = 4;
            this.lblUsuarioU.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(89, 258);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(582, 22);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(464, 22);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dtvUsuarios
            // 
            this.dtvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvUsuarios.Location = new System.Drawing.Point(332, 91);
            this.dtvUsuarios.Name = "dtvUsuarios";
            this.dtvUsuarios.Size = new System.Drawing.Size(325, 261);
            this.dtvUsuarios.TabIndex = 9;
            this.dtvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(19, 22);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 364);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dtvUsuarios);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsuarioU);
            this.Controls.Add(this.txtContrasenaU);
            this.Controls.Add(this.txtUsuarioU);
            this.Controls.Add(this.btnCargar);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtUsuarioU;
        private System.Windows.Forms.TextBox txtContrasenaU;
        private System.Windows.Forms.Label lblUsuarioU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dtvUsuarios;
        private System.Windows.Forms.Button btnRegresar;
    }
}