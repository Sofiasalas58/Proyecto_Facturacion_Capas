namespace PRACTICA_AEAE_2_Sofia
{
    partial class frmPrincipal
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlcontenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbpMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.btnsalir_click = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tablas = new System.Windows.Forms.TabPage();
            this.btncategorias = new System.Windows.Forms.Button();
            this.btnproductos = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.facturación = new System.Windows.Forms.TabPage();
            this.btninformes = new System.Windows.Forms.Button();
            this.btnfacturas = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Seguridad = new System.Windows.Forms.TabPage();
            this.btnseguridad = new System.Windows.Forms.Button();
            this.btnroles = new System.Windows.Forms.Button();
            this.btnempleados = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Acerca = new System.Windows.Forms.TabPage();
            this.btnacercade = new System.Windows.Forms.Button();
            this.btnayuda = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.TabOpcionesMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.pnlPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TbpMenu.SuspendLayout();
            this.Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.facturación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Acerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlcontenedor);
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Location = new System.Drawing.Point(-5, 63);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1207, 586);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pnlcontenedor
            // 
            this.pnlcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcontenedor.Location = new System.Drawing.Point(200, 0);
            this.pnlcontenedor.Name = "pnlcontenedor";
            this.pnlcontenedor.Size = new System.Drawing.Size(1007, 586);
            this.pnlcontenedor.TabIndex = 1;
            this.pnlcontenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlcontenedor_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TbpMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 586);
            this.panel1.TabIndex = 0;
            // 
            // TbpMenu
            // 
            this.TbpMenu.Controls.Add(this.Principal);
            this.TbpMenu.Controls.Add(this.tablas);
            this.TbpMenu.Controls.Add(this.facturación);
            this.TbpMenu.Controls.Add(this.Seguridad);
            this.TbpMenu.Controls.Add(this.Acerca);
            this.TbpMenu.Depth = 0;
            this.TbpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbpMenu.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbpMenu.Location = new System.Drawing.Point(0, 0);
            this.TbpMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbpMenu.Name = "TbpMenu";
            this.TbpMenu.SelectedIndex = 0;
            this.TbpMenu.Size = new System.Drawing.Size(200, 586);
            this.TbpMenu.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Principal.Controls.Add(this.btnsalir_click);
            this.Principal.Controls.Add(this.pictureBox1);
            this.Principal.Location = new System.Drawing.Point(4, 25);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(192, 557);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            // 
            // btnsalir_click
            // 
            this.btnsalir_click.FlatAppearance.BorderSize = 0;
            this.btnsalir_click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnsalir_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir_click.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir_click.ForeColor = System.Drawing.Color.White;
            this.btnsalir_click.Image = global::PRACTICA_AEAE_2_Sofia.Properties.Resources.cerrar_sesion;
            this.btnsalir_click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir_click.Location = new System.Drawing.Point(0, 141);
            this.btnsalir_click.Name = "btnsalir_click";
            this.btnsalir_click.Size = new System.Drawing.Size(196, 58);
            this.btnsalir_click.TabIndex = 1;
            this.btnsalir_click.Text = "Salir";
            this.btnsalir_click.UseVisualStyleBackColor = true;
            this.btnsalir_click.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRACTICA_AEAE_2_Sofia.Properties.Resources.social;
            this.pictureBox1.Location = new System.Drawing.Point(30, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tablas
            // 
            this.tablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tablas.Controls.Add(this.btncategorias);
            this.tablas.Controls.Add(this.btnproductos);
            this.tablas.Controls.Add(this.btnclientes);
            this.tablas.Controls.Add(this.pictureBox2);
            this.tablas.Location = new System.Drawing.Point(4, 25);
            this.tablas.Name = "tablas";
            this.tablas.Padding = new System.Windows.Forms.Padding(3);
            this.tablas.Size = new System.Drawing.Size(192, 557);
            this.tablas.TabIndex = 1;
            this.tablas.Text = "Tablas";
            // 
            // btncategorias
            // 
            this.btncategorias.FlatAppearance.BorderSize = 0;
            this.btncategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btncategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategorias.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategorias.ForeColor = System.Drawing.Color.White;
            this.btncategorias.Image = global::PRACTICA_AEAE_2_Sofia.Properties.Resources.categorizacion;
            this.btncategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategorias.Location = new System.Drawing.Point(-4, 280);
            this.btncategorias.Name = "btncategorias";
            this.btncategorias.Size = new System.Drawing.Size(196, 58);
            this.btncategorias.TabIndex = 4;
            this.btncategorias.Text = "Categorias";
            this.btncategorias.UseVisualStyleBackColor = true;
            this.btncategorias.Click += new System.EventHandler(this.btncategorias_Click);
            // 
            // btnproductos
            // 
            this.btnproductos.FlatAppearance.BorderSize = 0;
            this.btnproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproductos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.ForeColor = System.Drawing.Color.White;
            this.btnproductos.Image = global::PRACTICA_AEAE_2_Sofia.Properties.Resources.agregar_producto;
            this.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductos.Location = new System.Drawing.Point(-3, 216);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(196, 58);
            this.btnproductos.TabIndex = 3;
            this.btnproductos.Text = "Productos";
            this.btnproductos.UseVisualStyleBackColor = true;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.Color.White;
            this.btnclientes.Image = global::PRACTICA_AEAE_2_Sofia.Properties.Resources.personas;
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(0, 152);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(196, 58);
            this.btnclientes.TabIndex = 2;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PRACTICA_AEAE_2_Sofia.Properties.Resources.social;
            this.pictureBox2.Location = new System.Drawing.Point(31, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // facturación
            // 
            this.facturación.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.facturación.Controls.Add(this.btninformes);
            this.facturación.Controls.Add(this.btnfacturas);
            this.facturación.Controls.Add(this.pictureBox3);
            this.facturación.Location = new System.Drawing.Point(4, 25);
            this.facturación.Name = "facturación";
            this.facturación.Size = new System.Drawing.Size(192, 557);
            this.facturación.TabIndex = 2;
            this.facturación.Text = "facturación";
            // 
            // btninformes
            // 
            this.btninformes.FlatAppearance.BorderSize = 0;
            this.btninformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btninformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninformes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformes.ForeColor = System.Drawing.Color.White;
            this.btninformes.Image = global::PRACTICA_AEAE_2_Sofia.Properties.Resources.cuidado_de_la_salud;
            this.btninformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninformes.Location = new System.Drawing.Point(-1, 189);
            this.btninformes.Name = "btninformes";
            this.btninformes.Size = new System.Drawing.Size(196, 58);
            this.btninformes.TabIndex = 3;
            this.btninformes.Text = "Informes";
            this.btninformes.UseVisualStyleBackColor = true;
            this.btninformes.Click += new System.EventHandler(this.btninformes_Click);
            // 
            // btnfacturas
            // 
            this.btnfacturas.FlatAppearance.BorderSize = 0;
            this.btnfacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnfacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfacturas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfacturas.ForeColor = System.Drawing.Color.White;
            this.btnfacturas.Image = global::PRACTICA_AEAE_2_Sofia.Properties.Resources.factura;
            this.btnfacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfacturas.Location = new System.Drawing.Point(-3, 134);
            this.btnfacturas.Name = "btnfacturas";
            this.btnfacturas.Size = new System.Drawing.Size(196, 58);
            this.btnfacturas.TabIndex = 2;
            this.btnfacturas.Text = "Facturas";
            this.btnfacturas.UseVisualStyleBackColor = true;
            this.btnfacturas.Click += new System.EventHandler(this.btnfacturas_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PRACTICA_AEAE_2_Sofia.Properties.Resources.social;
            this.pictureBox3.Location = new System.Drawing.Point(37, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(110, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // Seguridad
            // 
            this.Seguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Seguridad.Controls.Add(this.btnseguridad);
            this.Seguridad.Controls.Add(this.btnroles);
            this.Seguridad.Controls.Add(this.btnempleados);
            this.Seguridad.Controls.Add(this.pictureBox4);
            this.Seguridad.Location = new System.Drawing.Point(4, 25);
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(192, 557);
            this.Seguridad.TabIndex = 3;
            this.Seguridad.Text = "Seguridad";
            // 
            // btnseguridad
            // 
            this.btnseguridad.FlatAppearance.BorderSize = 0;
            this.btnseguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnseguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseguridad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseguridad.ForeColor = System.Drawing.Color.White;
            this.btnseguridad.Image = global::PRACTICA_AEAE_2_Sofia.Properties.Resources.verificado;
            this.btnseguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnseguridad.Location = new System.Drawing.Point(-4, 270);
            this.btnseguridad.Name = "btnseguridad";
            this.btnseguridad.Size = new System.Drawing.Size(196, 58);
            this.btnseguridad.TabIndex = 5;
            this.btnseguridad.Text = "Seguridad";
            this.btnseguridad.UseVisualStyleBackColor = true;
            this.btnseguridad.Click += new System.EventHandler(this.btnseguridad_Click);
            // 
            // btnroles
            // 
            this.btnroles.FlatAppearance.BorderSize = 0;
            this.btnroles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnroles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnroles.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroles.ForeColor = System.Drawing.Color.White;
            this.btnroles.Image = global::PRACTICA_AEAE_2_Sofia.Properties.Resources.administracion;
            this.btnroles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnroles.Location = new System.Drawing.Point(-3, 206);
            this.btnroles.Name = "btnroles";
            this.btnroles.Size = new System.Drawing.Size(196, 58);
            this.btnroles.TabIndex = 4;
            this.btnroles.Text = "Roles";
            this.btnroles.UseVisualStyleBackColor = true;
            this.btnroles.Click += new System.EventHandler(this.btnroles_Click);
            // 
            // btnempleados
            // 
            this.btnempleados.FlatAppearance.BorderSize = 0;
            this.btnempleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleados.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleados.ForeColor = System.Drawing.Color.White;
            this.btnempleados.Image = global::PRACTICA_AEAE_2_Sofia.Properties.Resources.personas;
            this.btnempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleados.Location = new System.Drawing.Point(-1, 142);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(196, 58);
            this.btnempleados.TabIndex = 3;
            this.btnempleados.Text = "Empleados";
            this.btnempleados.UseVisualStyleBackColor = true;
            this.btnempleados.Click += new System.EventHandler(this.btnempleados_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PRACTICA_AEAE_2_Sofia.Properties.Resources.social;
            this.pictureBox4.Location = new System.Drawing.Point(41, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(110, 91);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // Acerca
            // 
            this.Acerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Acerca.Controls.Add(this.btnacercade);
            this.Acerca.Controls.Add(this.btnayuda);
            this.Acerca.Controls.Add(this.pictureBox5);
            this.Acerca.Location = new System.Drawing.Point(4, 25);
            this.Acerca.Name = "Acerca";
            this.Acerca.Size = new System.Drawing.Size(192, 557);
            this.Acerca.TabIndex = 4;
            this.Acerca.Text = "Ayuda";
            // 
            // btnacercade
            // 
            this.btnacercade.FlatAppearance.BorderSize = 0;
            this.btnacercade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnacercade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacercade.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnacercade.ForeColor = System.Drawing.Color.White;
            this.btnacercade.Image = global::PRACTICA_AEAE_2_Sofia.Properties.Resources.acerca_de;
            this.btnacercade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnacercade.Location = new System.Drawing.Point(-3, 202);
            this.btnacercade.Name = "btnacercade";
            this.btnacercade.Size = new System.Drawing.Size(196, 58);
            this.btnacercade.TabIndex = 5;
            this.btnacercade.Text = "Acerca de..";
            this.btnacercade.UseVisualStyleBackColor = true;
            this.btnacercade.Click += new System.EventHandler(this.btnacercade_Click);
            // 
            // btnayuda
            // 
            this.btnayuda.FlatAppearance.BorderSize = 0;
            this.btnayuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnayuda.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnayuda.ForeColor = System.Drawing.Color.White;
            this.btnayuda.Image = global::PRACTICA_AEAE_2_Sofia.Properties.Resources.ayudar;
            this.btnayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnayuda.Location = new System.Drawing.Point(0, 138);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.Size = new System.Drawing.Size(196, 58);
            this.btnayuda.TabIndex = 4;
            this.btnayuda.Text = "Ayuda";
            this.btnayuda.UseVisualStyleBackColor = true;
            this.btnayuda.Click += new System.EventHandler(this.btnayuda_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PRACTICA_AEAE_2_Sofia.Properties.Resources.social;
            this.pictureBox5.Location = new System.Drawing.Point(33, 25);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(110, 91);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // TabOpcionesMenu
            // 
            this.TabOpcionesMenu.BaseTabControl = this.TbpMenu;
            this.TabOpcionesMenu.Depth = 0;
            this.TabOpcionesMenu.Location = new System.Drawing.Point(215, 34);
            this.TabOpcionesMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabOpcionesMenu.Name = "TabOpcionesMenu";
            this.TabOpcionesMenu.Size = new System.Drawing.Size(615, 23);
            this.TabOpcionesMenu.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.TabOpcionesMenu);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "frmPrincipal";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de facturación";
            this.pnlPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.TbpMenu.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tablas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.facturación.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Seguridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Acerca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTabControl TbpMenu;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.TabPage tablas;
        private System.Windows.Forms.TabPage facturación;
        private System.Windows.Forms.TabPage Seguridad;
        private System.Windows.Forms.TabPage Acerca;
        private MaterialSkin.Controls.MaterialTabSelector TabOpcionesMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnsalir_click;
        private System.Windows.Forms.Button btncategorias;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btninformes;
        private System.Windows.Forms.Button btnfacturas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnseguridad;
        private System.Windows.Forms.Button btnroles;
        private System.Windows.Forms.Button btnempleados;
        private System.Windows.Forms.Button btnacercade;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.Panel pnlcontenedor;
    }
}