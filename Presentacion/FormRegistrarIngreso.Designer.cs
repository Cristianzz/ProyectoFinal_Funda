﻿namespace Presentacion
{
    partial class FormRegistrarIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarIngreso));
            this.DTGIngreso = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFecha_Entrega = new System.Windows.Forms.TextBox();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAlmacen = new System.Windows.Forms.ComboBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.btAsignarMal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btProductoBueno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGIngreso
            // 
            this.DTGIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGIngreso.Location = new System.Drawing.Point(516, 113);
            this.DTGIngreso.Name = "DTGIngreso";
            this.DTGIngreso.Size = new System.Drawing.Size(557, 486);
            this.DTGIngreso.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 18);
            this.label2.TabIndex = 81;
            this.label2.Text = "Ingrese Fecha de Ingreso:";
            // 
            // tbFecha_Entrega
            // 
            this.tbFecha_Entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFecha_Entrega.Location = new System.Drawing.Point(280, 226);
            this.tbFecha_Entrega.Name = "tbFecha_Entrega";
            this.tbFecha_Entrega.Size = new System.Drawing.Size(214, 22);
            this.tbFecha_Entrega.TabIndex = 80;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.Location = new System.Drawing.Point(137, 329);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(251, 40);
            this.btRegistrar.TabIndex = 82;
            this.btRegistrar.Text = "Registrar Ingreso al Almacen";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 18);
            this.label1.TabIndex = 83;
            this.label1.Text = "Seleccione Almacen de Ingreso:";
            // 
            // cbAlmacen
            // 
            this.cbAlmacen.FormattingEnabled = true;
            this.cbAlmacen.Location = new System.Drawing.Point(280, 272);
            this.cbAlmacen.Name = "cbAlmacen";
            this.cbAlmacen.Size = new System.Drawing.Size(214, 21);
            this.cbAlmacen.TabIndex = 84;
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold);
            this.btSalir.Location = new System.Drawing.Point(16, 559);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(120, 40);
            this.btSalir.TabIndex = 85;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAsignarMal
            // 
            this.btAsignarMal.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAsignarMal.Location = new System.Drawing.Point(108, 397);
            this.btAsignarMal.Name = "btAsignarMal";
            this.btAsignarMal.Size = new System.Drawing.Size(315, 40);
            this.btAsignarMal.TabIndex = 86;
            this.btAsignarMal.Text = "Asignar Producto en Mal Estado";
            this.btAsignarMal.UseVisualStyleBackColor = true;
            this.btAsignarMal.Click += new System.EventHandler(this.btAsignarMal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 40);
            this.label3.TabIndex = 87;
            this.label3.Text = "Registrar Ingreso:";
            // 
            // btGuardar
            // 
            this.btGuardar.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold);
            this.btGuardar.Location = new System.Drawing.Point(374, 559);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(120, 40);
            this.btGuardar.TabIndex = 88;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btProductoBueno
            // 
            this.btProductoBueno.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProductoBueno.Location = new System.Drawing.Point(108, 455);
            this.btProductoBueno.Name = "btProductoBueno";
            this.btProductoBueno.Size = new System.Drawing.Size(315, 40);
            this.btProductoBueno.TabIndex = 89;
            this.btProductoBueno.Text = "Asignar Producto a Buen Estado";
            this.btProductoBueno.UseVisualStyleBackColor = true;
            this.btProductoBueno.Click += new System.EventHandler(this.btProductoBueno_Click);
            // 
            // FormRegistrarIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.btProductoBueno);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAsignarMal);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.cbAlmacen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFecha_Entrega);
            this.Controls.Add(this.DTGIngreso);
            this.Name = "FormRegistrarIngreso";
            this.Text = "FormRegistrarIngreso";
            ((System.ComponentModel.ISupportInitialize)(this.DTGIngreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFecha_Entrega;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAlmacen;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btAsignarMal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btProductoBueno;
    }
}