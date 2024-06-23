namespace Presentacion
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btProveedores = new System.Windows.Forms.Button();
            this.btPedidos = new System.Windows.Forms.Button();
            this.btAlmacen = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.DTGMenu = new System.Windows.Forms.DataGridView();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btIngreso = new System.Windows.Forms.Button();
            this.Reportes = new System.Windows.Forms.Button();
            this.btRecarga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btProveedores
            // 
            this.btProveedores.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold);
            this.btProveedores.Location = new System.Drawing.Point(72, 211);
            this.btProveedores.Name = "btProveedores";
            this.btProveedores.Size = new System.Drawing.Size(262, 40);
            this.btProveedores.TabIndex = 7;
            this.btProveedores.Text = "Gestion de Proveedores";
            this.btProveedores.UseVisualStyleBackColor = true;
            this.btProveedores.Click += new System.EventHandler(this.btProveedores_Click);
            // 
            // btPedidos
            // 
            this.btPedidos.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold);
            this.btPedidos.Location = new System.Drawing.Point(72, 272);
            this.btPedidos.Name = "btPedidos";
            this.btPedidos.Size = new System.Drawing.Size(262, 40);
            this.btPedidos.TabIndex = 8;
            this.btPedidos.Text = "Realizar Pedido";
            this.btPedidos.UseVisualStyleBackColor = true;
            this.btPedidos.Click += new System.EventHandler(this.btPedidos_Click);
            // 
            // btAlmacen
            // 
            this.btAlmacen.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold);
            this.btAlmacen.Location = new System.Drawing.Point(72, 147);
            this.btAlmacen.Name = "btAlmacen";
            this.btAlmacen.Size = new System.Drawing.Size(262, 40);
            this.btAlmacen.TabIndex = 9;
            this.btAlmacen.Text = "Registrar Almacen";
            this.btAlmacen.UseVisualStyleBackColor = true;
            this.btAlmacen.Click += new System.EventHandler(this.btAlmacen_Click);
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold);
            this.btSalir.Location = new System.Drawing.Point(12, 559);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(106, 40);
            this.btSalir.TabIndex = 10;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // DTGMenu
            // 
            this.DTGMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGMenu.Location = new System.Drawing.Point(484, 108);
            this.DTGMenu.Name = "DTGMenu";
            this.DTGMenu.Size = new System.Drawing.Size(535, 491);
            this.DTGMenu.TabIndex = 11;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(919, 41);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(73, 24);
            this.lbNombre.TabIndex = 12;
            this.lbNombre.Text = "label1";
            // 
            // btIngreso
            // 
            this.btIngreso.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold);
            this.btIngreso.Location = new System.Drawing.Point(72, 333);
            this.btIngreso.Name = "btIngreso";
            this.btIngreso.Size = new System.Drawing.Size(262, 40);
            this.btIngreso.TabIndex = 13;
            this.btIngreso.Text = "Registrar Ingreso";
            this.btIngreso.UseVisualStyleBackColor = true;
            this.btIngreso.Click += new System.EventHandler(this.btIngreso_Click);
            // 
            // Reportes
            // 
            this.Reportes.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold);
            this.Reportes.Location = new System.Drawing.Point(72, 397);
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(262, 40);
            this.Reportes.TabIndex = 14;
            this.Reportes.Text = "Ver Reportes";
            this.Reportes.UseVisualStyleBackColor = true;
            this.Reportes.Click += new System.EventHandler(this.Reportes_Click);
            // 
            // btRecarga
            // 
            this.btRecarga.Location = new System.Drawing.Point(443, 117);
            this.btRecarga.Name = "btRecarga";
            this.btRecarga.Size = new System.Drawing.Size(35, 30);
            this.btRecarga.TabIndex = 15;
            this.btRecarga.Text = "R";
            this.btRecarga.UseVisualStyleBackColor = true;
            this.btRecarga.Click += new System.EventHandler(this.btRecarga_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.btRecarga);
            this.Controls.Add(this.Reportes);
            this.Controls.Add(this.btIngreso);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.DTGMenu);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAlmacen);
            this.Controls.Add(this.btPedidos);
            this.Controls.Add(this.btProveedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)(this.DTGMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btProveedores;
        private System.Windows.Forms.Button btPedidos;
        private System.Windows.Forms.Button btAlmacen;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.DataGridView DTGMenu;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btIngreso;
        private System.Windows.Forms.Button Reportes;
        private System.Windows.Forms.Button btRecarga;
    }
}