namespace Presentacion
{
    partial class FormRegistroPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistroPedido));
            this.DTGPedido = new System.Windows.Forms.DataGridView();
            this.btSalir = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btCrear = new System.Windows.Forms.Button();
            this.DTGCarro = new System.Windows.Forms.DataGridView();
            this.DTGProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.tbNombreP = new System.Windows.Forms.TextBox();
            this.btBucarProveedor = new System.Windows.Forms.Button();
            this.btBucarTipo = new System.Windows.Forms.Button();
            this.btBucarNombre = new System.Windows.Forms.Button();
            this.Proveedor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btEliminarProducto = new System.Windows.Forms.Button();
            this.btVerProducPedido = new System.Windows.Forms.Button();
            this.btRealizarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGPedido
            // 
            this.DTGPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGPedido.Location = new System.Drawing.Point(5, 132);
            this.DTGPedido.Name = "DTGPedido";
            this.DTGPedido.Size = new System.Drawing.Size(383, 227);
            this.DTGPedido.TabIndex = 0;
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold);
            this.btSalir.Location = new System.Drawing.Point(977, 559);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(95, 40);
            this.btSalir.TabIndex = 86;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold);
            this.btEliminar.Location = new System.Drawing.Point(934, 112);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(140, 40);
            this.btEliminar.TabIndex = 84;
            this.btEliminar.Text = "Eliminar Pedido";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(808, 158);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(266, 40);
            this.btAgregar.TabIndex = 83;
            this.btAgregar.Text = "Agregar Producto";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btCrear
            // 
            this.btCrear.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrear.Location = new System.Drawing.Point(808, 112);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(120, 40);
            this.btCrear.TabIndex = 87;
            this.btCrear.Text = "Crear Pedido";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // DTGCarro
            // 
            this.DTGCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGCarro.Location = new System.Drawing.Point(405, 132);
            this.DTGCarro.Name = "DTGCarro";
            this.DTGCarro.Size = new System.Drawing.Size(383, 227);
            this.DTGCarro.TabIndex = 88;
            // 
            // DTGProductos
            // 
            this.DTGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGProductos.Location = new System.Drawing.Point(5, 394);
            this.DTGProductos.Name = "DTGProductos";
            this.DTGProductos.Size = new System.Drawing.Size(783, 205);
            this.DTGProductos.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 91;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 31);
            this.label2.TabIndex = 92;
            this.label2.Text = "Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(412, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 31);
            this.label3.TabIndex = 93;
            this.label3.Text = "Carro de Compras";
            // 
            // cbProveedor
            // 
            this.cbProveedor.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(806, 317);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(167, 26);
            this.cbProveedor.TabIndex = 94;
            // 
            // cbTipo
            // 
            this.cbTipo.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Electronico",
            "Alimenticio",
            "Otro"});
            this.cbTipo.Location = new System.Drawing.Point(806, 398);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(167, 26);
            this.cbTipo.TabIndex = 96;
            // 
            // tbNombreP
            // 
            this.tbNombreP.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.tbNombreP.Location = new System.Drawing.Point(806, 477);
            this.tbNombreP.Name = "tbNombreP";
            this.tbNombreP.Size = new System.Drawing.Size(167, 26);
            this.tbNombreP.TabIndex = 97;
            // 
            // btBucarProveedor
            // 
            this.btBucarProveedor.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBucarProveedor.Location = new System.Drawing.Point(987, 303);
            this.btBucarProveedor.Name = "btBucarProveedor";
            this.btBucarProveedor.Size = new System.Drawing.Size(87, 40);
            this.btBucarProveedor.TabIndex = 98;
            this.btBucarProveedor.Text = "Buscar";
            this.btBucarProveedor.UseVisualStyleBackColor = true;
            this.btBucarProveedor.Click += new System.EventHandler(this.btBucarProveedor_Click);
            // 
            // btBucarTipo
            // 
            this.btBucarTipo.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBucarTipo.Location = new System.Drawing.Point(987, 381);
            this.btBucarTipo.Name = "btBucarTipo";
            this.btBucarTipo.Size = new System.Drawing.Size(87, 40);
            this.btBucarTipo.TabIndex = 99;
            this.btBucarTipo.Text = "Buscar";
            this.btBucarTipo.UseVisualStyleBackColor = true;
            this.btBucarTipo.Click += new System.EventHandler(this.btBucarTipo_Click);
            // 
            // btBucarNombre
            // 
            this.btBucarNombre.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBucarNombre.Location = new System.Drawing.Point(987, 463);
            this.btBucarNombre.Name = "btBucarNombre";
            this.btBucarNombre.Size = new System.Drawing.Size(87, 40);
            this.btBucarNombre.TabIndex = 100;
            this.btBucarNombre.Text = "Buscar";
            this.btBucarNombre.UseVisualStyleBackColor = true;
            this.btBucarNombre.Click += new System.EventHandler(this.btBucarNombre_Click);
            // 
            // Proveedor
            // 
            this.Proveedor.AutoSize = true;
            this.Proveedor.BackColor = System.Drawing.Color.Transparent;
            this.Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proveedor.Location = new System.Drawing.Point(802, 294);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(90, 20);
            this.Proveedor.TabIndex = 101;
            this.Proveedor.Text = "Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(802, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 20);
            this.label4.TabIndex = 102;
            this.label4.Text = "Seleccione Tipo Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(802, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 20);
            this.label5.TabIndex = 103;
            this.label5.Text = "Ingrese Nombre Producto";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.Location = new System.Drawing.Point(806, 511);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(268, 40);
            this.btLimpiar.TabIndex = 105;
            this.btLimpiar.Text = "Limpiar Filtro";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btEliminarProducto
            // 
            this.btEliminarProducto.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminarProducto.Location = new System.Drawing.Point(808, 204);
            this.btEliminarProducto.Name = "btEliminarProducto";
            this.btEliminarProducto.Size = new System.Drawing.Size(266, 40);
            this.btEliminarProducto.TabIndex = 106;
            this.btEliminarProducto.Text = "Eliminar Producto";
            this.btEliminarProducto.UseVisualStyleBackColor = true;
            this.btEliminarProducto.Click += new System.EventHandler(this.btEliminarProducto_Click);
            // 
            // btVerProducPedido
            // 
            this.btVerProducPedido.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerProducPedido.Location = new System.Drawing.Point(808, 250);
            this.btVerProducPedido.Name = "btVerProducPedido";
            this.btVerProducPedido.Size = new System.Drawing.Size(266, 40);
            this.btVerProducPedido.TabIndex = 107;
            this.btVerProducPedido.Text = "Ver Productos de Pedido";
            this.btVerProducPedido.UseVisualStyleBackColor = true;
            this.btVerProducPedido.Click += new System.EventHandler(this.btVerProducPedido_Click);
            // 
            // btRealizarPedido
            // 
            this.btRealizarPedido.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold);
            this.btRealizarPedido.Location = new System.Drawing.Point(806, 559);
            this.btRealizarPedido.Name = "btRealizarPedido";
            this.btRealizarPedido.Size = new System.Drawing.Size(165, 40);
            this.btRealizarPedido.TabIndex = 108;
            this.btRealizarPedido.Text = "Realizar Pedido";
            this.btRealizarPedido.UseVisualStyleBackColor = true;
            this.btRealizarPedido.Click += new System.EventHandler(this.btRealizarPedido_Click);
            // 
            // FormRegistroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.btRealizarPedido);
            this.Controls.Add(this.btVerProducPedido);
            this.Controls.Add(this.btEliminarProducto);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Proveedor);
            this.Controls.Add(this.btBucarNombre);
            this.Controls.Add(this.btBucarTipo);
            this.Controls.Add(this.btBucarProveedor);
            this.Controls.Add(this.tbNombreP);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTGProductos);
            this.Controls.Add(this.DTGCarro);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.DTGPedido);
            this.Name = "FormRegistroPedido";
            this.Text = "FormRegistroPedido";
            ((System.ComponentModel.ISupportInitialize)(this.DTGPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGPedido;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.DataGridView DTGCarro;
        private System.Windows.Forms.DataGridView DTGProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox tbNombreP;
        private System.Windows.Forms.Button btBucarProveedor;
        private System.Windows.Forms.Button btBucarTipo;
        private System.Windows.Forms.Button btBucarNombre;
        private System.Windows.Forms.Label Proveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btEliminarProducto;
        private System.Windows.Forms.Button btVerProducPedido;
        private System.Windows.Forms.Button btRealizarPedido;
    }
}