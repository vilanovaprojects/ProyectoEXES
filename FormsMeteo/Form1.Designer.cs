namespace FormsMeteo
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtValoracion = new System.Windows.Forms.TextBox();
            this.txtComentarios = new System.Windows.Forms.RichTextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gridViewRegistros = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.mensajeBuscar = new System.Windows.Forms.Label();
            this.dateFechaPrevision = new System.Windows.Forms.DateTimePicker();
            this.decimalTempMax = new System.Windows.Forms.NumericUpDown();
            this.decimalTempMin = new System.Windows.Forms.NumericUpDown();
            this.decimalHumedad = new System.Windows.Forms.NumericUpDown();
            this.intViento = new System.Windows.Forms.MaskedTextBox();
            this.intPrecipitaciones = new System.Windows.Forms.MaskedTextBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.mensajeGrid = new System.Windows.Forms.Label();
            this.mensajeNuevEditElim = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.btnBorrarImagen = new System.Windows.Forms.Button();
            this.comboProvincias = new System.Windows.Forms.ComboBox();
            this.pbMapa = new System.Windows.Forms.PictureBox();
            this.panelFoto = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decimalTempMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decimalTempMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decimalHumedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).BeginInit();
            this.panelFoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Previsiones Meteorológicas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de la Previsión:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperatura máxima:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Temperatura mínima:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(122, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Provincia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Viento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 237);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Humedad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 286);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Precipitaciones:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 310);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Valoración:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 337);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Comentarios:";
            // 
            // txtValoracion
            // 
            this.txtValoracion.Location = new System.Drawing.Point(148, 308);
            this.txtValoracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValoracion.Name = "txtValoracion";
            this.txtValoracion.Size = new System.Drawing.Size(76, 20);
            this.txtValoracion.TabIndex = 17;
            this.txtValoracion.TextChanged += new System.EventHandler(this.txtValoracion_TextChanged);
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(76, 352);
            this.txtComentarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(148, 54);
            this.txtComentarios.TabIndex = 18;
            this.txtComentarios.Text = "";
            this.txtComentarios.TextChanged += new System.EventHandler(this.txtComentarios_TextChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(98, 431);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 25);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.Text = "Nuevo Registro";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gridViewRegistros
            // 
            this.gridViewRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewRegistros.Location = new System.Drawing.Point(104, 532);
            this.gridViewRegistros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridViewRegistros.Name = "gridViewRegistros";
            this.gridViewRegistros.RowTemplate.Height = 24;
            this.gridViewRegistros.Size = new System.Drawing.Size(551, 163);
            this.gridViewRegistros.TabIndex = 22;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(212, 431);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 25);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar Registro";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(326, 431);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 25);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar Registro";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(350, 98);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 37);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // mensajeBuscar
            // 
            this.mensajeBuscar.AutoSize = true;
            this.mensajeBuscar.Location = new System.Drawing.Point(448, 110);
            this.mensajeBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mensajeBuscar.Name = "mensajeBuscar";
            this.mensajeBuscar.Size = new System.Drawing.Size(0, 13);
            this.mensajeBuscar.TabIndex = 26;
            // 
            // dateFechaPrevision
            // 
            this.dateFechaPrevision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaPrevision.Location = new System.Drawing.Point(224, 94);
            this.dateFechaPrevision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateFechaPrevision.Name = "dateFechaPrevision";
            this.dateFechaPrevision.Size = new System.Drawing.Size(96, 20);
            this.dateFechaPrevision.TabIndex = 27;
            this.dateFechaPrevision.Value = new System.DateTime(2023, 4, 9, 20, 23, 14, 0);
            // 
            // decimalTempMax
            // 
            this.decimalTempMax.DecimalPlaces = 2;
            this.decimalTempMax.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.decimalTempMax.Location = new System.Drawing.Point(148, 187);
            this.decimalTempMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.decimalTempMax.Name = "decimalTempMax";
            this.decimalTempMax.Size = new System.Drawing.Size(76, 20);
            this.decimalTempMax.TabIndex = 28;
            // 
            // decimalTempMin
            // 
            this.decimalTempMin.DecimalPlaces = 2;
            this.decimalTempMin.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.decimalTempMin.Location = new System.Drawing.Point(149, 211);
            this.decimalTempMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.decimalTempMin.Name = "decimalTempMin";
            this.decimalTempMin.Size = new System.Drawing.Size(76, 20);
            this.decimalTempMin.TabIndex = 29;
            // 
            // decimalHumedad
            // 
            this.decimalHumedad.DecimalPlaces = 2;
            this.decimalHumedad.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.decimalHumedad.Location = new System.Drawing.Point(149, 236);
            this.decimalHumedad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.decimalHumedad.Name = "decimalHumedad";
            this.decimalHumedad.Size = new System.Drawing.Size(76, 20);
            this.decimalHumedad.TabIndex = 30;
            // 
            // intViento
            // 
            this.intViento.Location = new System.Drawing.Point(148, 259);
            this.intViento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.intViento.Mask = "999 Km/h";
            this.intViento.Name = "intViento";
            this.intViento.Size = new System.Drawing.Size(76, 20);
            this.intViento.TabIndex = 31;
            this.intViento.ValidatingType = typeof(int);
            // 
            // intPrecipitaciones
            // 
            this.intPrecipitaciones.Location = new System.Drawing.Point(148, 284);
            this.intPrecipitaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.intPrecipitaciones.Mask = "999 mm/h";
            this.intPrecipitaciones.Name = "intPrecipitaciones";
            this.intPrecipitaciones.Size = new System.Drawing.Size(76, 20);
            this.intPrecipitaciones.TabIndex = 32;
            this.intPrecipitaciones.ValidatingType = typeof(int);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(104, 505);
            this.btnMostrarTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(200, 25);
            this.btnMostrarTodos.TabIndex = 33;
            this.btnMostrarTodos.Text = "Mostrar registros almecenados";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // mensajeGrid
            // 
            this.mensajeGrid.AutoSize = true;
            this.mensajeGrid.Location = new System.Drawing.Point(106, 697);
            this.mensajeGrid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mensajeGrid.Name = "mensajeGrid";
            this.mensajeGrid.Size = new System.Drawing.Size(0, 13);
            this.mensajeGrid.TabIndex = 34;
            // 
            // mensajeNuevEditElim
            // 
            this.mensajeNuevEditElim.AutoSize = true;
            this.mensajeNuevEditElim.Location = new System.Drawing.Point(101, 476);
            this.mensajeNuevEditElim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mensajeNuevEditElim.Name = "mensajeNuevEditElim";
            this.mensajeNuevEditElim.Size = new System.Drawing.Size(0, 13);
            this.mensajeNuevEditElim.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(348, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Mapa de pronóstico";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(545, 420);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnCargarImagen.TabIndex = 37;
            this.btnCargarImagen.Text = "Cargar";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // btnBorrarImagen
            // 
            this.btnBorrarImagen.Location = new System.Drawing.Point(626, 420);
            this.btnBorrarImagen.Name = "btnBorrarImagen";
            this.btnBorrarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarImagen.TabIndex = 38;
            this.btnBorrarImagen.Text = "Borrar";
            this.btnBorrarImagen.UseVisualStyleBackColor = true;
            this.btnBorrarImagen.Click += new System.EventHandler(this.btnBorrarImagen_Click);
            // 
            // comboProvincias
            // 
            this.comboProvincias.FormattingEnabled = true;
            this.comboProvincias.Location = new System.Drawing.Point(224, 121);
            this.comboProvincias.Name = "comboProvincias";
            this.comboProvincias.Size = new System.Drawing.Size(97, 21);
            this.comboProvincias.TabIndex = 39;
            // 
            // pbMapa
            // 
            this.pbMapa.Location = new System.Drawing.Point(0, 0);
            this.pbMapa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMapa.Name = "pbMapa";
            this.pbMapa.Size = new System.Drawing.Size(351, 226);
            this.pbMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMapa.TabIndex = 0;
            this.pbMapa.TabStop = false;
            // 
            // panelFoto
            // 
            this.panelFoto.BackColor = System.Drawing.Color.White;
            this.panelFoto.Controls.Add(this.pbMapa);
            this.panelFoto.Location = new System.Drawing.Point(350, 187);
            this.panelFoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFoto.Name = "panelFoto";
            this.panelFoto.Size = new System.Drawing.Size(351, 226);
            this.panelFoto.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 744);
            this.Controls.Add(this.comboProvincias);
            this.Controls.Add(this.btnBorrarImagen);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mensajeNuevEditElim);
            this.Controls.Add(this.mensajeGrid);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.intPrecipitaciones);
            this.Controls.Add(this.intViento);
            this.Controls.Add(this.decimalHumedad);
            this.Controls.Add(this.decimalTempMin);
            this.Controls.Add(this.decimalTempMax);
            this.Controls.Add(this.dateFechaPrevision);
            this.Controls.Add(this.mensajeBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gridViewRegistros);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.panelFoto);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.txtValoracion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Servicio nacional de Meteorología";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decimalTempMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decimalTempMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decimalHumedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).EndInit();
            this.panelFoto.ResumeLayout(false);
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValoracion;
        private System.Windows.Forms.RichTextBox txtComentarios;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView gridViewRegistros;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label mensajeBuscar;
        private System.Windows.Forms.DateTimePicker dateFechaPrevision;
        private System.Windows.Forms.NumericUpDown decimalTempMax;
        private System.Windows.Forms.NumericUpDown decimalTempMin;
        private System.Windows.Forms.NumericUpDown decimalHumedad;
        private System.Windows.Forms.MaskedTextBox intViento;
        private System.Windows.Forms.MaskedTextBox intPrecipitaciones;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Label mensajeGrid;
        private System.Windows.Forms.Label mensajeNuevEditElim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Button btnBorrarImagen;
        private System.Windows.Forms.ComboBox comboProvincias;
        private System.Windows.Forms.PictureBox pbMapa;
        private System.Windows.Forms.Panel panelFoto;
    }
}

