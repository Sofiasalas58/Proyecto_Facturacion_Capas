namespace PRACTICA_AEAE_2_Sofia
{
    partial class frmListaProductos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtbuscarproducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridproductos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strPrecio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strPrecio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(235, 57);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(254, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Administración productos";
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(449, 110);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(66, 36);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(550, 110);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(74, 36);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(534, 367);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtbuscarproducto
            // 
            this.txtbuscarproducto.Depth = 0;
            this.txtbuscarproducto.Hint = "Buscar Producto";
            this.txtbuscarproducto.Location = new System.Drawing.Point(23, 123);
            this.txtbuscarproducto.MaxLength = 32767;
            this.txtbuscarproducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbuscarproducto.Name = "txtbuscarproducto";
            this.txtbuscarproducto.PasswordChar = '\0';
            this.txtbuscarproducto.SelectedText = "";
            this.txtbuscarproducto.SelectionLength = 0;
            this.txtbuscarproducto.SelectionStart = 0;
            this.txtbuscarproducto.Size = new System.Drawing.Size(278, 23);
            this.txtbuscarproducto.TabIndex = 6;
            this.txtbuscarproducto.TabStop = false;
            this.txtbuscarproducto.UseSystemPasswordChar = false;
            // 
            // dataGridproductos
            // 
            this.dataGridproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.strNombre,
            this.strCodigo,
            this.strPrecio_compra,
            this.strPrecio_venta,
            this.IdCategoria,
            this.strDetalle,
            this.strCantidad,
            this.btnEditar,
            this.btnBorrar});
            this.dataGridproductos.Location = new System.Drawing.Point(23, 169);
            this.dataGridproductos.Name = "dataGridproductos";
            this.dataGridproductos.Size = new System.Drawing.Size(746, 161);
            this.dataGridproductos.TabIndex = 2;
            this.dataGridproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridproductos_CellContentClick);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Width = 80;
            // 
            // strNombre
            // 
            this.strNombre.HeaderText = "NOMBRE";
            this.strNombre.Name = "strNombre";
            this.strNombre.ToolTipText = "NOMBRE";
            this.strNombre.Width = 130;
            // 
            // strCodigo
            // 
            this.strCodigo.HeaderText = "CÓDIGO";
            this.strCodigo.Name = "strCodigo";
            this.strCodigo.Width = 50;
            // 
            // strPrecio_compra
            // 
            this.strPrecio_compra.HeaderText = "PRECIO_COMPRA";
            this.strPrecio_compra.Name = "strPrecio_compra";
            // 
            // strPrecio_venta
            // 
            this.strPrecio_venta.HeaderText = "PRECIO_VENTA";
            this.strPrecio_venta.Name = "strPrecio_venta";
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "CATEGORIA";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ToolTipText = "Descripción de categoría";
            this.IdCategoria.Width = 120;
            // 
            // strDetalle
            // 
            this.strDetalle.HeaderText = "DETALLE";
            this.strDetalle.Name = "strDetalle";
            this.strDetalle.ToolTipText = "DETALLE";
            // 
            // strCantidad
            // 
            this.strCantidad.HeaderText = "CANTIDAD_STOCK";
            this.strCantidad.Name = "strCantidad";
            this.strCantidad.Width = 120;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            // 
            // frmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbuscarproducto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridproductos);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmListaProductos";
            this.Text = "Administración Productos";
            this.Load += new System.EventHandler(this.frmListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtbuscarproducto;
        private System.Windows.Forms.DataGridView dataGridproductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn strPrecio_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn strPrecio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}