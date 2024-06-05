using System;
using System.Windows.Forms;

namespace CarlosRamosExamonCRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxSKU = new System.Windows.Forms.TextBox();
            this.textBoxProveedor = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.numericUpDownSTOK = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBoxCosto = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPrecioVenta = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.botonActualizar = new System.Windows.Forms.Button();
            this.botonInsertar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.botonSeleccionarImagen = new System.Windows.Forms.Button();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonLeer = new System.Windows.Forms.Button();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonBuscarPorFechas = new System.Windows.Forms.Button();
            this.monthCalendarSeleccion = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.botonPruebaConexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSTOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Producto";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "SKU de Producto";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Costo de Producto";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(403, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Proveedor";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(703, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Categoria";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1268, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de Registro";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(702, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "Disponible";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(403, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 31);
            this.label9.TabIndex = 8;
            this.label9.Text = "Precio de Venta";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(246, 97);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(89, 26);
            this.textBoxID.TabIndex = 9;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(402, 95);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(800, 26);
            this.textBoxNombre.TabIndex = 10;
            // 
            // textBoxSKU
            // 
            this.textBoxSKU.Location = new System.Drawing.Point(55, 260);
            this.textBoxSKU.Name = "textBoxSKU";
            this.textBoxSKU.Size = new System.Drawing.Size(280, 26);
            this.textBoxSKU.TabIndex = 11;
            // 
            // textBoxProveedor
            // 
            this.textBoxProveedor.Location = new System.Drawing.Point(402, 260);
            this.textBoxProveedor.Name = "textBoxProveedor";
            this.textBoxProveedor.Size = new System.Drawing.Size(234, 26);
            this.textBoxProveedor.TabIndex = 12;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(704, 260);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(211, 26);
            this.textBoxCategoria.TabIndex = 13;
            // 
            // numericUpDownSTOK
            // 
            this.numericUpDownSTOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSTOK.Location = new System.Drawing.Point(704, 367);
            this.numericUpDownSTOK.Name = "numericUpDownSTOK";
            this.numericUpDownSTOK.Size = new System.Drawing.Size(211, 30);
            this.numericUpDownSTOK.TabIndex = 14;
            // 
            // maskedTextBoxCosto
            // 
            this.maskedTextBoxCosto.Location = new System.Drawing.Point(60, 367);
            this.maskedTextBoxCosto.Name = "maskedTextBoxCosto";
            this.maskedTextBoxCosto.Size = new System.Drawing.Size(275, 26);
            this.maskedTextBoxCosto.TabIndex = 15;
            this.maskedTextBoxCosto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCosto_MaskInputRejected);
            // 
            // maskedTextBoxPrecioVenta
            // 
            this.maskedTextBoxPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxPrecioVenta.Location = new System.Drawing.Point(402, 367);
            this.maskedTextBoxPrecioVenta.Name = "maskedTextBoxPrecioVenta";
            this.maskedTextBoxPrecioVenta.Size = new System.Drawing.Size(234, 28);
            this.maskedTextBoxPrecioVenta.TabIndex = 16;
            // 
            // dateTimePickerFechaRegistro
            // 
            this.dateTimePickerFechaRegistro.Location = new System.Drawing.Point(1273, 97);
            this.dateTimePickerFechaRegistro.Name = "dateTimePickerFechaRegistro";
            this.dateTimePickerFechaRegistro.Size = new System.Drawing.Size(365, 26);
            this.dateTimePickerFechaRegistro.TabIndex = 17;
            // 
            // botonActualizar
            // 
            this.botonActualizar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.botonActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonActualizar.Location = new System.Drawing.Point(983, 280);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(219, 40);
            this.botonActualizar.TabIndex = 19;
            this.botonActualizar.Text = "Actualizar Producto";
            this.botonActualizar.UseVisualStyleBackColor = false;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // botonInsertar
            // 
            this.botonInsertar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.botonInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInsertar.Location = new System.Drawing.Point(511, 929);
            this.botonInsertar.Name = "botonInsertar";
            this.botonInsertar.Size = new System.Drawing.Size(170, 49);
            this.botonInsertar.TabIndex = 20;
            this.botonInsertar.Text = "Insertar";
            this.botonInsertar.UseVisualStyleBackColor = false;
            this.botonInsertar.Click += new System.EventHandler(this.botonInsertar_Click_1);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // botonSeleccionarImagen
            // 
            this.botonSeleccionarImagen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.botonSeleccionarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSeleccionarImagen.Location = new System.Drawing.Point(55, 929);
            this.botonSeleccionarImagen.Name = "botonSeleccionarImagen";
            this.botonSeleccionarImagen.Size = new System.Drawing.Size(413, 49);
            this.botonSeleccionarImagen.TabIndex = 21;
            this.botonSeleccionarImagen.Text = "Selecionar Imagen";
            this.botonSeleccionarImagen.UseVisualStyleBackColor = false;
            this.botonSeleccionarImagen.Click += new System.EventHandler(this.botonSeleccionarImagen_Click);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxImagen.Location = new System.Drawing.Point(55, 482);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(413, 420);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 22;
            this.pictureBoxImagen.TabStop = false;
            // 
            // botonBuscar
            // 
            this.botonBuscar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.botonBuscar.Location = new System.Drawing.Point(246, 139);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(89, 37);
            this.botonBuscar.TabIndex = 23;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = false;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonLeer
            // 
            this.botonLeer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.botonLeer.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLeer.Location = new System.Drawing.Point(983, 209);
            this.botonLeer.Name = "botonLeer";
            this.botonLeer.Size = new System.Drawing.Size(219, 39);
            this.botonLeer.TabIndex = 24;
            this.botonLeer.Text = "Leer Productos";
            this.botonLeer.UseVisualStyleBackColor = false;
            this.botonLeer.Click += new System.EventHandler(this.botonLeer_Click);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToOrderColumns = true;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(511, 556);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 62;
            this.dataGridViewProductos.RowTemplate.Height = 28;
            this.dataGridViewProductos.Size = new System.Drawing.Size(1127, 346);
            this.dataGridViewProductos.TabIndex = 25;
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.botonEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.Location = new System.Drawing.Point(983, 355);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(219, 44);
            this.botonEliminar.TabIndex = 26;
            this.botonEliminar.Text = "Eliminar Producto";
            this.botonEliminar.UseVisualStyleBackColor = false;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonBuscarPorFechas
            // 
            this.botonBuscarPorFechas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.botonBuscarPorFechas.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscarPorFechas.Location = new System.Drawing.Point(1273, 473);
            this.botonBuscarPorFechas.Name = "botonBuscarPorFechas";
            this.botonBuscarPorFechas.Size = new System.Drawing.Size(365, 49);
            this.botonBuscarPorFechas.TabIndex = 28;
            this.botonBuscarPorFechas.Text = "Consultar Fechas";
            this.botonBuscarPorFechas.UseVisualStyleBackColor = false;
            // 
            // monthCalendarSeleccion
            // 
            this.monthCalendarSeleccion.Location = new System.Drawing.Point(1273, 208);
            this.monthCalendarSeleccion.MaxSelectionCount = 30;
            this.monthCalendarSeleccion.Name = "monthCalendarSeleccion";
            this.monthCalendarSeleccion.TabIndex = 28;
            this.monthCalendarSeleccion.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarSeleccion_DateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarlosRamosExamonCRUD.Properties.Resources.Screenshot_20240603_144202_Logo_Maker;
            this.pictureBox1.Location = new System.Drawing.Point(55, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1268, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(370, 36);
            this.label10.TabIndex = 32;
            this.label10.Text = "Buscar Fecha de Registro";
            // 
            // botonPruebaConexion
            // 
            this.botonPruebaConexion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.botonPruebaConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPruebaConexion.Location = new System.Drawing.Point(1396, 929);
            this.botonPruebaConexion.Name = "botonPruebaConexion";
            this.botonPruebaConexion.Size = new System.Drawing.Size(242, 49);
            this.botonPruebaConexion.TabIndex = 33;
            this.botonPruebaConexion.Text = "Prueba de Conexion";
            this.botonPruebaConexion.UseVisualStyleBackColor = false;
            this.botonPruebaConexion.Click += new System.EventHandler(this.botonPruebaConexion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1713, 1036);
            this.Controls.Add(this.botonPruebaConexion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendarSeleccion);
            this.Controls.Add(this.botonBuscarPorFechas);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.botonLeer);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.botonSeleccionarImagen);
            this.Controls.Add(this.botonInsertar);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.dateTimePickerFechaRegistro);
            this.Controls.Add(this.maskedTextBoxPrecioVenta);
            this.Controls.Add(this.maskedTextBoxCosto);
            this.Controls.Add(this.numericUpDownSTOK);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxProveedor);
            this.Controls.Add(this.textBoxSKU);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSTOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxSKU;
        private System.Windows.Forms.TextBox textBoxProveedor;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.NumericUpDown numericUpDownSTOK;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCosto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrecioVenta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaRegistro;
        private System.Windows.Forms.Button botonActualizar;
        private System.Windows.Forms.Button botonInsertar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button botonSeleccionarImagen;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Button botonLeer;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.MonthCalendar monthCalendarFechasSeleccionadas;
        private System.Windows.Forms.Button botonBuscarPorFechas;
        private System.Windows.Forms.MonthCalendar monthCalendarSeleccion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button botonPruebaConexion;
    }
}

