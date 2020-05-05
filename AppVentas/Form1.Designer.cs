namespace AppVentas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuarioP = new System.Windows.Forms.TextBox();
            this.txtContraP = new System.Windows.Forms.TextBox();
            this.lblUsuarioP = new System.Windows.Forms.Label();
            this.lblContraP = new System.Windows.Forms.Label();
            this.btnEntrarP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuarioP
            // 
            this.txtUsuarioP.Location = new System.Drawing.Point(12, 72);
            this.txtUsuarioP.Name = "txtUsuarioP";
            this.txtUsuarioP.Size = new System.Drawing.Size(277, 20);
            this.txtUsuarioP.TabIndex = 0;
            // 
            // txtContraP
            // 
            this.txtContraP.Location = new System.Drawing.Point(12, 173);
            this.txtContraP.Name = "txtContraP";
            this.txtContraP.PasswordChar = '*';
            this.txtContraP.Size = new System.Drawing.Size(277, 20);
            this.txtContraP.TabIndex = 1;
            // 
            // lblUsuarioP
            // 
            this.lblUsuarioP.AutoSize = true;
            this.lblUsuarioP.Font = new System.Drawing.Font("Pixeled", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioP.Location = new System.Drawing.Point(12, 24);
            this.lblUsuarioP.Name = "lblUsuarioP";
            this.lblUsuarioP.Size = new System.Drawing.Size(122, 45);
            this.lblUsuarioP.TabIndex = 2;
            this.lblUsuarioP.Text = "USUARIO";
            // 
            // lblContraP
            // 
            this.lblContraP.AutoSize = true;
            this.lblContraP.Font = new System.Drawing.Font("Pixeled", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraP.Location = new System.Drawing.Point(12, 125);
            this.lblContraP.Name = "lblContraP";
            this.lblContraP.Size = new System.Drawing.Size(180, 45);
            this.lblContraP.TabIndex = 3;
            this.lblContraP.Text = "Contraseña";
            this.lblContraP.Click += new System.EventHandler(this.lblContraP_Click);
            // 
            // btnEntrarP
            // 
            this.btnEntrarP.Font = new System.Drawing.Font("Pixeled", 8F);
            this.btnEntrarP.Location = new System.Drawing.Point(103, 241);
            this.btnEntrarP.Name = "btnEntrarP";
            this.btnEntrarP.Size = new System.Drawing.Size(89, 40);
            this.btnEntrarP.TabIndex = 4;
            this.btnEntrarP.Text = "Entrar";
            this.btnEntrarP.UseVisualStyleBackColor = true;
            this.btnEntrarP.Click += new System.EventHandler(this.btnEntrarP_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 291);
            this.Controls.Add(this.btnEntrarP);
            this.Controls.Add(this.lblContraP);
            this.Controls.Add(this.lblUsuarioP);
            this.Controls.Add(this.txtContraP);
            this.Controls.Add(this.txtUsuarioP);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioP;
        private System.Windows.Forms.TextBox txtContraP;
        private System.Windows.Forms.Label lblUsuarioP;
        private System.Windows.Forms.Label lblContraP;
        private System.Windows.Forms.Button btnEntrarP;
    }
}

