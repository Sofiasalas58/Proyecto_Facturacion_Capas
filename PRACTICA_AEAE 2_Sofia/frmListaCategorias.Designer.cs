namespace PRACTICA_AEAE_2_Sofia
{
    partial class frmListaCategorias
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
            this.txtbuscarcategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridcategoria = new System.Windows.Forms.DataGridView();
            this.strNombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(229, 57);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(247, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Categorías de productos";
            // 
            // txtbuscarcategoria
            // 
            this.txtbuscarcategoria.Depth = 0;
            this.txtbuscarcategoria.Hint = "Buscar Categoria";
            this.txtbuscarcategoria.Location = new System.Drawing.Point(54, 128);
            this.txtbuscarcategoria.MaxLength = 32767;
            this.txtbuscarcategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbuscarcategoria.Name = "txtbuscarcategoria";
            this.txtbuscarcategoria.PasswordChar = '\0';
            this.txtbuscarcategoria.SelectedText = "";
            this.txtbuscarcategoria.SelectionLength = 0;
            this.txtbuscarcategoria.SelectionStart = 0;
            this.txtbuscarcategoria.Size = new System.Drawing.Size(278, 23);
            this.txtbuscarcategoria.TabIndex = 7;
            this.txtbuscarcategoria.TabStop = false;
            this.txtbuscarcategoria.UseSystemPasswordChar = false;
            // 
            // dataGridcategoria
            // 
            this.dataGridcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridcategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strNombreCategoria,
            this.btnEditar,
            this.btnBorrar});
            this.dataGridcategoria.Location = new System.Drawing.Point(54, 175);
            this.dataGridcategoria.Name = "dataGridcategoria";
            this.dataGridcategoria.Size = new System.Drawing.Size(543, 150);
            this.dataGridcategoria.TabIndex = 8;
            this.dataGridcategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridcategoria_CellContentClick);
            // 
            // strNombreCategoria
            // 
            this.strNombreCategoria.FillWeight = 150F;
            this.strNombreCategoria.HeaderText = "NOMBRE_CATEGORIA";
            this.strNombreCategoria.Name = "strNombreCategoria";
            this.strNombreCategoria.ToolTipText = "NOMBRE_CATEGORIA";
            this.strNombreCategoria.Width = 300;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "EDITAR";
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "BORRAR";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(510, 115);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(74, 36);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Icon = null;
            this.btnNuevo.Location = new System.Drawing.Point(409, 115);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(66, 36);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(526, 343);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmListaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataGridcategoria);
            this.Controls.Add(this.txtbuscarcategoria);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmListaCategorias";
            this.Text = "frmListaCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtbuscarcategoria;
        private System.Windows.Forms.DataGridView dataGridcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNombreCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}