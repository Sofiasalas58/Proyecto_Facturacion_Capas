namespace PRACTICA_AEAE_2_Sofia
{
    partial class frmListaFactura
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
            this.dataGridFactura = new System.Windows.Forms.DataGridView();
            this.strNroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtbuscarFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFactura
            // 
            this.dataGridFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strNroFactura,
            this.strCliente,
            this.strEmpleado,
            this.strDetalle,
            this.strEstado,
            this.btnEditar,
            this.btnBorrar});
            this.dataGridFactura.Location = new System.Drawing.Point(2, 148);
            this.dataGridFactura.Name = "dataGridFactura";
            this.dataGridFactura.Size = new System.Drawing.Size(786, 177);
            this.dataGridFactura.TabIndex = 27;
            this.dataGridFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmpleados_CellContentClick);
            // 
            // strNroFactura
            // 
            this.strNroFactura.HeaderText = "Nro_FACTURA";
            this.strNroFactura.Name = "strNroFactura";
            this.strNroFactura.ToolTipText = "Nro_FACTURA";
            this.strNroFactura.Width = 120;
            // 
            // strCliente
            // 
            this.strCliente.HeaderText = "CLIENTE";
            this.strCliente.Name = "strCliente";
            this.strCliente.ToolTipText = "CLIENTE";
            // 
            // strEmpleado
            // 
            this.strEmpleado.HeaderText = "EMPLEADO";
            this.strEmpleado.Name = "strEmpleado";
            this.strEmpleado.ToolTipText = "EMPLEADO";
            // 
            // strDetalle
            // 
            this.strDetalle.HeaderText = "DETALLE";
            this.strDetalle.Name = "strDetalle";
            this.strDetalle.ToolTipText = "DETALLE";
            this.strDetalle.Width = 180;
            // 
            // strEstado
            // 
            this.strEstado.HeaderText = "ESTADO";
            this.strEstado.Name = "strEstado";
            this.strEstado.ToolTipText = "ESTADO";
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 80;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            this.btnBorrar.Width = 80;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(553, 368);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(537, 92);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(74, 36);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(435, 92);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(66, 36);
            this.btnNuevo.TabIndex = 24;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtbuscarFactura
            // 
            this.txtbuscarFactura.Depth = 0;
            this.txtbuscarFactura.Hint = "Buscar Factura";
            this.txtbuscarFactura.Location = new System.Drawing.Point(68, 105);
            this.txtbuscarFactura.MaxLength = 32767;
            this.txtbuscarFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbuscarFactura.Name = "txtbuscarFactura";
            this.txtbuscarFactura.PasswordChar = '\0';
            this.txtbuscarFactura.SelectedText = "";
            this.txtbuscarFactura.SelectionLength = 0;
            this.txtbuscarFactura.SelectionStart = 0;
            this.txtbuscarFactura.Size = new System.Drawing.Size(278, 23);
            this.txtbuscarFactura.TabIndex = 23;
            this.txtbuscarFactura.TabStop = false;
            this.txtbuscarFactura.UseSystemPasswordChar = false;
            this.txtbuscarFactura.Click += new System.EventHandler(this.txtbuscarcategoria_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(313, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(96, 25);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Facturas";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // frmListaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridFactura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtbuscarFactura);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmListaFactura";
            this.Text = "frmListaFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtbuscarFactura;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEstado;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}