namespace Presentacion
{
    partial class FormVerReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerReportes));
            this.DTGReportes = new System.Windows.Forms.DataGridView();
            this.cbAlmacen = new System.Windows.Forms.ComboBox();
            this.btPedidosEntr = new System.Windows.Forms.Button();
            this.btProduc = new System.Windows.Forms.Button();
            this.btDefec = new System.Windows.Forms.Button();
            this.btMaxStock = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btMinStock = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTGReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGReportes
            // 
            this.DTGReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGReportes.Location = new System.Drawing.Point(362, 108);
            this.DTGReportes.Name = "DTGReportes";
            this.DTGReportes.Size = new System.Drawing.Size(710, 491);
            this.DTGReportes.TabIndex = 0;
            // 
            // cbAlmacen
            // 
            this.cbAlmacen.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlmacen.FormattingEnabled = true;
            this.cbAlmacen.Location = new System.Drawing.Point(147, 223);
            this.cbAlmacen.Name = "cbAlmacen";
            this.cbAlmacen.Size = new System.Drawing.Size(190, 30);
            this.cbAlmacen.TabIndex = 1;
            // 
            // btPedidosEntr
            // 
            this.btPedidosEntr.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPedidosEntr.Location = new System.Drawing.Point(70, 314);
            this.btPedidosEntr.Name = "btPedidosEntr";
            this.btPedidosEntr.Size = new System.Drawing.Size(207, 40);
            this.btPedidosEntr.TabIndex = 106;
            this.btPedidosEntr.Text = "Ver Pedidos Entregados";
            this.btPedidosEntr.UseVisualStyleBackColor = true;
            this.btPedidosEntr.Click += new System.EventHandler(this.btPedidosEntr_Click);
            // 
            // btProduc
            // 
            this.btProduc.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProduc.Location = new System.Drawing.Point(70, 365);
            this.btProduc.Name = "btProduc";
            this.btProduc.Size = new System.Drawing.Size(207, 40);
            this.btProduc.TabIndex = 107;
            this.btProduc.Text = "Ver Productos";
            this.btProduc.UseVisualStyleBackColor = true;
            this.btProduc.Click += new System.EventHandler(this.btProduc_Click);
            // 
            // btDefec
            // 
            this.btDefec.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDefec.Location = new System.Drawing.Point(70, 411);
            this.btDefec.Name = "btDefec";
            this.btDefec.Size = new System.Drawing.Size(207, 40);
            this.btDefec.TabIndex = 109;
            this.btDefec.Text = "Ver Defec. o Caducados";
            this.btDefec.UseVisualStyleBackColor = true;
            this.btDefec.Click += new System.EventHandler(this.btDefec_Click);
            // 
            // btMaxStock
            // 
            this.btMaxStock.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMaxStock.Location = new System.Drawing.Point(182, 457);
            this.btMaxStock.Name = "btMaxStock";
            this.btMaxStock.Size = new System.Drawing.Size(95, 40);
            this.btMaxStock.TabIndex = 110;
            this.btMaxStock.Text = "Max Stock";
            this.btMaxStock.UseVisualStyleBackColor = true;
            this.btMaxStock.Click += new System.EventHandler(this.btMaxStock_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Lucida Bright", 14.25F);
            this.tbCantidad.Location = new System.Drawing.Point(194, 269);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 30);
            this.tbCantidad.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 113;
            this.label1.Text = "Almacen:";
            // 
            // btMinStock
            // 
            this.btMinStock.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinStock.Location = new System.Drawing.Point(70, 457);
            this.btMinStock.Name = "btMinStock";
            this.btMinStock.Size = new System.Drawing.Size(95, 40);
            this.btMinStock.TabIndex = 114;
            this.btMinStock.Text = "Min Stock";
            this.btMinStock.UseVisualStyleBackColor = true;
            this.btMinStock.Click += new System.EventHandler(this.btMinStock_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 116;
            this.label3.Text = "Cant. Stock:";
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(12, 570);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(85, 29);
            this.btSalir.TabIndex = 117;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 42);
            this.label4.TabIndex = 118;
            this.label4.Text = "Reportes";
            // 
            // FormVerReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btMinStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.btMaxStock);
            this.Controls.Add(this.btDefec);
            this.Controls.Add(this.btProduc);
            this.Controls.Add(this.btPedidosEntr);
            this.Controls.Add(this.cbAlmacen);
            this.Controls.Add(this.DTGReportes);
            this.Name = "FormVerReportes";
            this.Text = "FormVerReportes";
            ((System.ComponentModel.ISupportInitialize)(this.DTGReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGReportes;
        private System.Windows.Forms.ComboBox cbAlmacen;
        private System.Windows.Forms.Button btPedidosEntr;
        private System.Windows.Forms.Button btProduc;
        private System.Windows.Forms.Button btDefec;
        private System.Windows.Forms.Button btMaxStock;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMinStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label4;
    }
}