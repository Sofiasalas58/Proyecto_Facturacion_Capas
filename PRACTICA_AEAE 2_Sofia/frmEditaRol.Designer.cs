namespace PRACTICA_AEAE_2_Sofia
{
    partial class frmEditaRol
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
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlactualizarclientes = new System.Windows.Forms.Panel();
            this.txtDesRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnlactualizarclientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(314, 291);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseCompatibleTextRendering = true;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(119, 291);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.TabStop = false;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseCompatibleTextRendering = true;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 20);
            this.textBox1.TabIndex = 6;
            // 
            // pnlactualizarclientes
            // 
            this.pnlactualizarclientes.Controls.Add(this.txtDesRol);
            this.pnlactualizarclientes.Controls.Add(this.txtNombreRol);
            this.pnlactualizarclientes.Location = new System.Drawing.Point(55, 121);
            this.pnlactualizarclientes.Name = "pnlactualizarclientes";
            this.pnlactualizarclientes.Size = new System.Drawing.Size(387, 139);
            this.pnlactualizarclientes.TabIndex = 5;
            // 
            // txtDesRol
            // 
            this.txtDesRol.Depth = 0;
            this.txtDesRol.Hint = "Descripcion detallada Rol";
            this.txtDesRol.Location = new System.Drawing.Point(34, 50);
            this.txtDesRol.MaxLength = 32767;
            this.txtDesRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDesRol.Name = "txtDesRol";
            this.txtDesRol.PasswordChar = '\0';
            this.txtDesRol.SelectedText = "";
            this.txtDesRol.SelectionLength = 0;
            this.txtDesRol.SelectionStart = 0;
            this.txtDesRol.Size = new System.Drawing.Size(266, 23);
            this.txtDesRol.TabIndex = 1;
            this.txtDesRol.TabStop = false;
            this.txtDesRol.UseSystemPasswordChar = false;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Depth = 0;
            this.txtNombreRol.Hint = "Nombre Rol";
            this.txtNombreRol.Location = new System.Drawing.Point(34, 21);
            this.txtNombreRol.MaxLength = 32767;
            this.txtNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.PasswordChar = '\0';
            this.txtNombreRol.SelectedText = "";
            this.txtNombreRol.SelectionLength = 0;
            this.txtNombreRol.SelectionStart = 0;
            this.txtNombreRol.Size = new System.Drawing.Size(266, 23);
            this.txtNombreRol.TabIndex = 0;
            this.txtNombreRol.TabStop = false;
            this.txtNombreRol.Tag = "";
            this.txtNombreRol.UseSystemPasswordChar = false;
            // 
            // frmEditaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pnlactualizarclientes);
            this.Name = "frmEditaRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROL EMPLEADOS";
            this.Load += new System.EventHandler(this.frmEditaRol_Load);
            this.pnlactualizarclientes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlactualizarclientes;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDesRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreRol;
    }
}