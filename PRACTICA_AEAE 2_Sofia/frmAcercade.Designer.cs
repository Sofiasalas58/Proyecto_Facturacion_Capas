namespace PRACTICA_AEAE_2_Sofia
{
    partial class frmAcercade
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
            this.panelAcercade = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panelAcercade.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAcercade
            // 
            this.panelAcercade.Controls.Add(this.btnSalir);
            this.panelAcercade.Controls.Add(this.textBox1);
            this.panelAcercade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAcercade.Location = new System.Drawing.Point(0, 0);
            this.panelAcercade.Name = "panelAcercade";
            this.panelAcercade.Size = new System.Drawing.Size(800, 450);
            this.panelAcercade.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(607, 97);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Sistema de Facturación\r\n\r\nDesarrollado por: Sofia Salas\r\n\r\nEste sistema permite g" +
    "estionar clientes,\r\nproductos y facturación.\r\n\r\nVersión 1.0";
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(562, 169);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseCompatibleTextRendering = true;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAcercade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAcercade);
            this.Name = "frmAcercade";
            this.Text = "frmAcercade";
            this.panelAcercade.ResumeLayout(false);
            this.panelAcercade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAcercade;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}