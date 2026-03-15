namespace PRACTICA_AEAE_2_Sofia
{
    partial class frmEditarproducto
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
            this.components = new System.ComponentModel.Container();
            this.Titulo = new System.Windows.Forms.Label();
            this.pnlactualizarclientes = new System.Windows.Forms.Panel();
            this.txtCantidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioV = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombrep = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this._IDP = new System.Windows.Forms.TextBox();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDetalle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlactualizarclientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Maroon;
            this.Titulo.Location = new System.Drawing.Point(196, 90);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(100, 25);
            this.Titulo.TabIndex = 2;
            this.Titulo.Text = "Productos";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // pnlactualizarclientes
            // 
            this.pnlactualizarclientes.Controls.Add(this.txtDetalle);
            this.pnlactualizarclientes.Controls.Add(this.txtCategoria);
            this.pnlactualizarclientes.Controls.Add(this.txtCantidad);
            this.pnlactualizarclientes.Controls.Add(this.txtPrecioV);
            this.pnlactualizarclientes.Controls.Add(this.txtPrecioC);
            this.pnlactualizarclientes.Controls.Add(this.txtCodigo);
            this.pnlactualizarclientes.Controls.Add(this.txtNombrep);
            this.pnlactualizarclientes.Location = new System.Drawing.Point(32, 156);
            this.pnlactualizarclientes.Name = "pnlactualizarclientes";
            this.pnlactualizarclientes.Size = new System.Drawing.Size(426, 247);
            this.pnlactualizarclientes.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Depth = 0;
            this.txtCantidad.Hint = "Cantidad Stock";
            this.txtCantidad.Location = new System.Drawing.Point(34, 137);
            this.txtCantidad.MaxLength = 32767;
            this.txtCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.Size = new System.Drawing.Size(266, 23);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.TabStop = false;
            this.txtCantidad.UseSystemPasswordChar = false;
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.Depth = 0;
            this.txtPrecioV.Hint = "Precio Venta";
            this.txtPrecioV.Location = new System.Drawing.Point(34, 108);
            this.txtPrecioV.MaxLength = 32767;
            this.txtPrecioV.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.PasswordChar = '\0';
            this.txtPrecioV.SelectedText = "";
            this.txtPrecioV.SelectionLength = 0;
            this.txtPrecioV.SelectionStart = 0;
            this.txtPrecioV.Size = new System.Drawing.Size(266, 23);
            this.txtPrecioV.TabIndex = 3;
            this.txtPrecioV.TabStop = false;
            this.txtPrecioV.UseSystemPasswordChar = false;
            // 
            // txtPrecioC
            // 
            this.txtPrecioC.Depth = 0;
            this.txtPrecioC.Hint = "Precio Compra";
            this.txtPrecioC.Location = new System.Drawing.Point(34, 79);
            this.txtPrecioC.MaxLength = 32767;
            this.txtPrecioC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioC.Name = "txtPrecioC";
            this.txtPrecioC.PasswordChar = '\0';
            this.txtPrecioC.SelectedText = "";
            this.txtPrecioC.SelectionLength = 0;
            this.txtPrecioC.SelectionStart = 0;
            this.txtPrecioC.Size = new System.Drawing.Size(266, 23);
            this.txtPrecioC.TabIndex = 2;
            this.txtPrecioC.TabStop = false;
            this.txtPrecioC.UseSystemPasswordChar = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Hint = "Código Referencia";
            this.txtCodigo.Location = new System.Drawing.Point(34, 50);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(266, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // txtNombrep
            // 
            this.txtNombrep.Depth = 0;
            this.txtNombrep.Hint = "Nombre Producto";
            this.txtNombrep.Location = new System.Drawing.Point(34, 21);
            this.txtNombrep.MaxLength = 32767;
            this.txtNombrep.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombrep.Name = "txtNombrep";
            this.txtNombrep.PasswordChar = '\0';
            this.txtNombrep.SelectedText = "";
            this.txtNombrep.SelectionLength = 0;
            this.txtNombrep.SelectionStart = 0;
            this.txtNombrep.Size = new System.Drawing.Size(266, 23);
            this.txtNombrep.TabIndex = 0;
            this.txtNombrep.TabStop = false;
            this.txtNombrep.Tag = "";
            this.txtNombrep.UseSystemPasswordChar = false;
            // 
            // _IDP
            // 
            this._IDP.Location = new System.Drawing.Point(66, 120);
            this._IDP.Name = "_IDP";
            this._IDP.Size = new System.Drawing.Size(41, 20);
            this._IDP.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(400, 427);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseCompatibleTextRendering = true;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(298, 427);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(84, 36);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseCompatibleTextRendering = true;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Depth = 0;
            this.txtCategoria.Hint = "Categoria";
            this.txtCategoria.Location = new System.Drawing.Point(34, 166);
            this.txtCategoria.MaxLength = 32767;
            this.txtCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PasswordChar = '\0';
            this.txtCategoria.SelectedText = "";
            this.txtCategoria.SelectionLength = 0;
            this.txtCategoria.SelectionStart = 0;
            this.txtCategoria.Size = new System.Drawing.Size(266, 23);
            this.txtCategoria.TabIndex = 5;
            this.txtCategoria.TabStop = false;
            this.txtCategoria.UseSystemPasswordChar = false;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Depth = 0;
            this.txtDetalle.Hint = "Detalle";
            this.txtDetalle.Location = new System.Drawing.Point(34, 195);
            this.txtDetalle.MaxLength = 32767;
            this.txtDetalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.PasswordChar = '\0';
            this.txtDetalle.SelectedText = "";
            this.txtDetalle.SelectionLength = 0;
            this.txtDetalle.SelectionStart = 0;
            this.txtDetalle.Size = new System.Drawing.Size(266, 23);
            this.txtDetalle.TabIndex = 6;
            this.txtDetalle.TabStop = false;
            this.txtDetalle.UseSystemPasswordChar = false;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmEditarproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 534);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this._IDP);
            this.Controls.Add(this.pnlactualizarclientes);
            this.Controls.Add(this.Titulo);
            this.Name = "frmEditarproducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de productos";
            this.pnlactualizarclientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Panel pnlactualizarclientes;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantidad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioV;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioC;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombrep;
        private System.Windows.Forms.TextBox _IDP;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDetalle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}