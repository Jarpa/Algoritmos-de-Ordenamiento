namespace AnalisisDeAlgoritmos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Solo = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Ordenados = new System.Windows.Forms.ListBox();
            this.mostrarOrdenados = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Generados = new System.Windows.Forms.ListBox();
            this.mostrarGenerados = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ejecucion = new System.Windows.Forms.TextBox();
            this.metodo = new System.Windows.Forms.GroupBox();
            this.cbalgoritmo = new System.Windows.Forms.ComboBox();
            this.btordenar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDatos = new System.Windows.Forms.ComboBox();
            this.cborden = new System.Windows.Forms.ComboBox();
            this.btgenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.resultado.SuspendLayout();
            this.metodo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Solo
            // 
            this.Solo.Location = new System.Drawing.Point(624, 393);
            this.Solo.Name = "Solo";
            this.Solo.Size = new System.Drawing.Size(111, 36);
            this.Solo.TabIndex = 0;
            this.Solo.Text = "Trabaja Solo";
            this.Solo.UseVisualStyleBackColor = true;
            this.Solo.Click += new System.EventHandler(this.Solo_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(511, 406);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btLimpiar.TabIndex = 8;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Ordenados);
            this.groupBox5.Controls.Add(this.mostrarOrdenados);
            this.groupBox5.Location = new System.Drawing.Point(511, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(224, 360);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Numeros Ordenados";
            // 
            // Ordenados
            // 
            this.Ordenados.FormattingEnabled = true;
            this.Ordenados.Location = new System.Drawing.Point(6, 59);
            this.Ordenados.Name = "Ordenados";
            this.Ordenados.Size = new System.Drawing.Size(213, 290);
            this.Ordenados.TabIndex = 3;
            // 
            // mostrarOrdenados
            // 
            this.mostrarOrdenados.Enabled = false;
            this.mostrarOrdenados.Location = new System.Drawing.Point(59, 19);
            this.mostrarOrdenados.Name = "mostrarOrdenados";
            this.mostrarOrdenados.Size = new System.Drawing.Size(125, 23);
            this.mostrarOrdenados.TabIndex = 0;
            this.mostrarOrdenados.Text = "Mostrar";
            this.mostrarOrdenados.UseVisualStyleBackColor = true;
            this.mostrarOrdenados.Click += new System.EventHandler(this.mostrarOrdenados_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Generados);
            this.groupBox4.Controls.Add(this.mostrarGenerados);
            this.groupBox4.Location = new System.Drawing.Point(262, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 360);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Numeros Generados";
            // 
            // Generados
            // 
            this.Generados.FormattingEnabled = true;
            this.Generados.Location = new System.Drawing.Point(6, 59);
            this.Generados.Name = "Generados";
            this.Generados.Size = new System.Drawing.Size(213, 290);
            this.Generados.TabIndex = 2;
            // 
            // mostrarGenerados
            // 
            this.mostrarGenerados.Enabled = false;
            this.mostrarGenerados.Location = new System.Drawing.Point(52, 20);
            this.mostrarGenerados.Name = "mostrarGenerados";
            this.mostrarGenerados.Size = new System.Drawing.Size(125, 23);
            this.mostrarGenerados.TabIndex = 0;
            this.mostrarGenerados.Text = "Mostrar";
            this.mostrarGenerados.UseVisualStyleBackColor = true;
            this.mostrarGenerados.Click += new System.EventHandler(this.mostrarGenerados_Click);
            // 
            // resultado
            // 
            this.resultado.Controls.Add(this.label4);
            this.resultado.Controls.Add(this.ejecucion);
            this.resultado.Location = new System.Drawing.Point(2, 287);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(239, 100);
            this.resultado.TabIndex = 7;
            this.resultado.TabStop = false;
            this.resultado.Text = "Resultados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tiempo de Ejecución";
            // 
            // ejecucion
            // 
            this.ejecucion.Enabled = false;
            this.ejecucion.Location = new System.Drawing.Point(53, 50);
            this.ejecucion.Name = "ejecucion";
            this.ejecucion.Size = new System.Drawing.Size(131, 20);
            this.ejecucion.TabIndex = 0;
            // 
            // metodo
            // 
            this.metodo.Controls.Add(this.cbalgoritmo);
            this.metodo.Controls.Add(this.btordenar);
            this.metodo.Controls.Add(this.label3);
            this.metodo.Enabled = false;
            this.metodo.Location = new System.Drawing.Point(2, 167);
            this.metodo.Name = "metodo";
            this.metodo.Size = new System.Drawing.Size(239, 114);
            this.metodo.TabIndex = 6;
            this.metodo.TabStop = false;
            this.metodo.Text = "Metodo de Ordenamiento";
            // 
            // cbalgoritmo
            // 
            this.cbalgoritmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbalgoritmo.FormattingEnabled = true;
            this.cbalgoritmo.Items.AddRange(new object[] {
            "Seleccione",
            "Burbuja",
            "Burbuja 2",
            "InsertSort",
            "Seleccion",
            "ShellSort",
            "QuickSort",
            "MergeSort"});
            this.cbalgoritmo.Location = new System.Drawing.Point(95, 45);
            this.cbalgoritmo.Name = "cbalgoritmo";
            this.cbalgoritmo.Size = new System.Drawing.Size(138, 21);
            this.cbalgoritmo.TabIndex = 2;
            // 
            // btordenar
            // 
            this.btordenar.Location = new System.Drawing.Point(122, 81);
            this.btordenar.Name = "btordenar";
            this.btordenar.Size = new System.Drawing.Size(111, 27);
            this.btordenar.TabIndex = 1;
            this.btordenar.Text = "Ordenar";
            this.btordenar.UseVisualStyleBackColor = true;
            this.btordenar.Click += new System.EventHandler(this.btordenar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Algoritmo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDatos);
            this.groupBox1.Controls.Add(this.cborden);
            this.groupBox1.Controls.Add(this.btgenerar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración Datos";
            // 
            // cbDatos
            // 
            this.cbDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatos.FormattingEnabled = true;
            this.cbDatos.Items.AddRange(new object[] {
            "Seleccione",
            "10",
            "50",
            "100",
            "500",
            "1000",
            "5000",
            "10000",
            "25000",
            "50000",
            "75000",
            "100000",
            "250000",
            "500000",
            "750000",
            "1000000",
            "2500000",
            "5000000",
            "7500000",
            "10000000"});
            this.cbDatos.Location = new System.Drawing.Point(95, 22);
            this.cbDatos.Name = "cbDatos";
            this.cbDatos.Size = new System.Drawing.Size(138, 21);
            this.cbDatos.TabIndex = 4;
            // 
            // cborden
            // 
            this.cborden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborden.FormattingEnabled = true;
            this.cborden.Items.AddRange(new object[] {
            "Seleccione",
            "Ascendiente",
            "Descendiente",
            "Sin Repetición",
            "Con Repetición"});
            this.cborden.Location = new System.Drawing.Point(95, 59);
            this.cborden.Name = "cborden";
            this.cborden.Size = new System.Drawing.Size(138, 21);
            this.cborden.TabIndex = 3;
            // 
            // btgenerar
            // 
            this.btgenerar.Location = new System.Drawing.Point(118, 91);
            this.btgenerar.Name = "btgenerar";
            this.btgenerar.Size = new System.Drawing.Size(115, 29);
            this.btgenerar.TabIndex = 2;
            this.btgenerar.Text = "Generar";
            this.btgenerar.UseVisualStyleBackColor = true;
            this.btgenerar.Click += new System.EventHandler(this.btgenerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Orden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad Datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 443);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.metodo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Solo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.resultado.ResumeLayout(false);
            this.resultado.PerformLayout();
            this.metodo.ResumeLayout(false);
            this.metodo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Solo;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox Ordenados;
        private System.Windows.Forms.Button mostrarOrdenados;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox Generados;
        private System.Windows.Forms.Button mostrarGenerados;
        private System.Windows.Forms.GroupBox resultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ejecucion;
        private System.Windows.Forms.GroupBox metodo;
        private System.Windows.Forms.ComboBox cbalgoritmo;
        private System.Windows.Forms.Button btordenar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDatos;
        private System.Windows.Forms.ComboBox cborden;
        private System.Windows.Forms.Button btgenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

