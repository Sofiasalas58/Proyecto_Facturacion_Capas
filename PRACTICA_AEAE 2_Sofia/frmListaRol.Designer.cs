namespace PRACTICA_AEAE_2_Sofia
{
    partial class frmListaRol
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
            this.dataGridRolEmpleados = new System.Windows.Forms.DataGridView();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtbuscaRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.strNombreRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRolEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRolEmpleados
            // 
            this.dataGridRolEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRolEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strNombreRol,
            this.strDescripcion,
            this.btnEditar,
            this.btnBorrar});
            this.dataGridRolEmpleados.Location = new System.Drawing.Point(34, 151);
            this.dataGridRolEmpleados.Name = "dataGridRolEmpleados";
            this.dataGridRolEmpleados.Size = new System.Drawing.Size(653, 177);
            this.dataGridRolEmpleados.TabIndex = 27;
            this.dataGridRolEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRolEmpleados_CellContentClick);
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
            // 
            // txtbuscaRol
            // 
            this.txtbuscaRol.Depth = 0;
            this.txtbuscaRol.Hint = "Buscar Rol";
            this.txtbuscaRol.Location = new System.Drawing.Point(68, 105);
            this.txtbuscaRol.MaxLength = 32767;
            this.txtbuscaRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbuscaRol.Name = "txtbuscaRol";
            this.txtbuscaRol.PasswordChar = '\0';
            this.txtbuscaRol.SelectedText = "";
            this.txtbuscaRol.SelectionLength = 0;
            this.txtbuscaRol.SelectionStart = 0;
            this.txtbuscaRol.Size = new System.Drawing.Size(278, 23);
            this.txtbuscaRol.TabIndex = 23;
            this.txtbuscaRol.TabStop = false;
            this.txtbuscaRol.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(264, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(157, 25);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Rol Empleados";
            // 
            // strNombreRol
            // 
            this.strNombreRol.HeaderText = "NOMBRE_ROL";
            this.strNombreRol.Name = "strNombreRol";
            this.strNombreRol.ToolTipText = "NOMBRE_ROL";
            this.strNombreRol.Width = 200;
            // 
            // strDescripcion
            // 
            this.strDescripcion.HeaderText = "DESCRIPCION";
            this.strDescripcion.Name = "strDescripcion";
            this.strDescripcion.ToolTipText = "DESCRIPCION";
            this.strDescripcion.Width = 250;
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
            // frmListaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.dataGridRolEmpleados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtbuscaRol);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmListaRol";
            this.Text = "frmListaRol";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRolEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRolEmpleados;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtbuscaRol;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNombreRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDescripcion;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}