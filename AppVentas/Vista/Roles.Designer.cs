namespace AppVentas.Vista
{
    partial class Roles
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
            this.dtVista = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtVista)).BeginInit();
            this.SuspendLayout();
            // 
            // dtVista
            // 
            this.dtVista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVista.Location = new System.Drawing.Point(12, 121);
            this.dtVista.Name = "dtVista";
            this.dtVista.Size = new System.Drawing.Size(776, 317);
            this.dtVista.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 13);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dtVista);
            this.Name = "Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtVista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtVista;
        private System.Windows.Forms.Button btnRegresar;
    }
}