namespace Ejercicio1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListaIncidentes = new System.Windows.Forms.Button();
            this.btnCrearComisaria = new System.Windows.Forms.Button();
            this.grBadmin = new System.Windows.Forms.GroupBox();
            this.comboAgente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbMI = new System.Windows.Forms.TextBox();
            this.tbHI = new System.Windows.Forms.TextBox();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbNombrePersona = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboTipoI = new System.Windows.Forms.ComboBox();
            this.btnRegistrarIncidente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbMDesde = new System.Windows.Forms.TextBox();
            this.tbMG = new System.Windows.Forms.TextBox();
            this.tbHG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboGuardia = new System.Windows.Forms.ComboBox();
            this.btnAsignarGuardia = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.grBadmin.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListaIncidentes);
            this.groupBox1.Controls.Add(this.btnCrearComisaria);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administracion comisaria";
            // 
            // btnListaIncidentes
            // 
            this.btnListaIncidentes.Location = new System.Drawing.Point(627, 16);
            this.btnListaIncidentes.Name = "btnListaIncidentes";
            this.btnListaIncidentes.Size = new System.Drawing.Size(129, 61);
            this.btnListaIncidentes.TabIndex = 1;
            this.btnListaIncidentes.Text = "Listar Incidentes";
            this.btnListaIncidentes.UseVisualStyleBackColor = true;
            this.btnListaIncidentes.Click += new System.EventHandler(this.btnListaIncidentes_Click);
            // 
            // btnCrearComisaria
            // 
            this.btnCrearComisaria.Location = new System.Drawing.Point(472, 16);
            this.btnCrearComisaria.Name = "btnCrearComisaria";
            this.btnCrearComisaria.Size = new System.Drawing.Size(129, 61);
            this.btnCrearComisaria.TabIndex = 0;
            this.btnCrearComisaria.Text = "Creacion Comisaria";
            this.btnCrearComisaria.UseVisualStyleBackColor = true;
            this.btnCrearComisaria.Click += new System.EventHandler(this.btnCrearComisaria_Click);
            // 
            // grBadmin
            // 
            this.grBadmin.Controls.Add(this.comboAgente);
            this.grBadmin.Controls.Add(this.label1);
            this.grBadmin.Controls.Add(this.groupBox4);
            this.grBadmin.Controls.Add(this.groupBox3);
            this.grBadmin.Location = new System.Drawing.Point(12, 107);
            this.grBadmin.Name = "grBadmin";
            this.grBadmin.Size = new System.Drawing.Size(756, 427);
            this.grBadmin.TabIndex = 1;
            this.grBadmin.TabStop = false;
            this.grBadmin.Text = "Operaciones sobre el agente";
            // 
            // comboAgente
            // 
            this.comboAgente.FormattingEnabled = true;
            this.comboAgente.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboAgente.Location = new System.Drawing.Point(167, 32);
            this.comboAgente.Name = "comboAgente";
            this.comboAgente.Size = new System.Drawing.Size(129, 24);
            this.comboAgente.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agente";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbMI);
            this.groupBox4.Controls.Add(this.tbHI);
            this.groupBox4.Controls.Add(this.tbMotivo);
            this.groupBox4.Controls.Add(this.tbDNI);
            this.groupBox4.Controls.Add(this.tbNombrePersona);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.comboTipoI);
            this.groupBox4.Controls.Add(this.btnRegistrarIncidente);
            this.groupBox4.Location = new System.Drawing.Point(25, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(718, 202);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Administracion de Incidentes";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // tbMI
            // 
            this.tbMI.Location = new System.Drawing.Point(221, 64);
            this.tbMI.Name = "tbMI";
            this.tbMI.Size = new System.Drawing.Size(58, 22);
            this.tbMI.TabIndex = 20;
            // 
            // tbHI
            // 
            this.tbHI.Location = new System.Drawing.Point(139, 64);
            this.tbHI.Name = "tbHI";
            this.tbHI.Size = new System.Drawing.Size(58, 22);
            this.tbHI.TabIndex = 19;
            // 
            // tbMotivo
            // 
            this.tbMotivo.Location = new System.Drawing.Point(144, 141);
            this.tbMotivo.Multiline = true;
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.Size = new System.Drawing.Size(556, 55);
            this.tbMotivo.TabIndex = 17;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(347, 101);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(129, 22);
            this.tbDNI.TabIndex = 16;
            // 
            // tbNombrePersona
            // 
            this.tbNombrePersona.Location = new System.Drawing.Point(136, 101);
            this.tbNombrePersona.Name = "tbNombrePersona";
            this.tbNombrePersona.Size = new System.Drawing.Size(143, 22);
            this.tbNombrePersona.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Motivo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "DNI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Persona";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo";
            // 
            // comboTipoI
            // 
            this.comboTipoI.FormattingEnabled = true;
            this.comboTipoI.Items.AddRange(new object[] {
            "Arresto",
            "Denuncia"});
            this.comboTipoI.Location = new System.Drawing.Point(139, 25);
            this.comboTipoI.Name = "comboTipoI";
            this.comboTipoI.Size = new System.Drawing.Size(140, 24);
            this.comboTipoI.TabIndex = 3;
            // 
            // btnRegistrarIncidente
            // 
            this.btnRegistrarIncidente.Location = new System.Drawing.Point(548, 35);
            this.btnRegistrarIncidente.Name = "btnRegistrarIncidente";
            this.btnRegistrarIncidente.Size = new System.Drawing.Size(129, 61);
            this.btnRegistrarIncidente.TabIndex = 3;
            this.btnRegistrarIncidente.Text = "Registrar incidentes";
            this.btnRegistrarIncidente.UseVisualStyleBackColor = true;
            this.btnRegistrarIncidente.Click += new System.EventHandler(this.btnRegistrarIncidente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbMDesde);
            this.groupBox3.Controls.Add(this.tbMG);
            this.groupBox3.Controls.Add(this.tbHG);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboGuardia);
            this.groupBox3.Controls.Add(this.btnAsignarGuardia);
            this.groupBox3.Location = new System.Drawing.Point(25, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(718, 117);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Administracion de Guradias";
            // 
            // tbMDesde
            // 
            this.tbMDesde.Location = new System.Drawing.Point(140, 86);
            this.tbMDesde.Name = "tbMDesde";
            this.tbMDesde.Size = new System.Drawing.Size(80, 22);
            this.tbMDesde.TabIndex = 20;
            // 
            // tbMG
            // 
            this.tbMG.Location = new System.Drawing.Point(214, 57);
            this.tbMG.Name = "tbMG";
            this.tbMG.Size = new System.Drawing.Size(58, 22);
            this.tbMG.TabIndex = 19;
            // 
            // tbHG
            // 
            this.tbHG.Location = new System.Drawing.Point(142, 57);
            this.tbHG.Name = "tbHG";
            this.tbHG.Size = new System.Drawing.Size(58, 22);
            this.tbHG.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Durarion en M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "N° de Guardia";
            // 
            // comboGuardia
            // 
            this.comboGuardia.FormattingEnabled = true;
            this.comboGuardia.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboGuardia.Location = new System.Drawing.Point(142, 21);
            this.comboGuardia.Name = "comboGuardia";
            this.comboGuardia.Size = new System.Drawing.Size(129, 24);
            this.comboGuardia.TabIndex = 3;
            // 
            // btnAsignarGuardia
            // 
            this.btnAsignarGuardia.Location = new System.Drawing.Point(548, 21);
            this.btnAsignarGuardia.Name = "btnAsignarGuardia";
            this.btnAsignarGuardia.Size = new System.Drawing.Size(129, 61);
            this.btnAsignarGuardia.TabIndex = 2;
            this.btnAsignarGuardia.Text = "Asignacion de las guardias";
            this.btnAsignarGuardia.UseVisualStyleBackColor = true;
            this.btnAsignarGuardia.Click += new System.EventHandler(this.btnAsignarGuardia_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(322, 540);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 61);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 604);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grBadmin);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comisaria";
            this.groupBox1.ResumeLayout(false);
            this.grBadmin.ResumeLayout(false);
            this.grBadmin.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListaIncidentes;
        private System.Windows.Forms.Button btnCrearComisaria;
        private System.Windows.Forms.GroupBox grBadmin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRegistrarIncidente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAsignarGuardia;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTipoI;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboGuardia;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbNombrePersona;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboAgente;
        private System.Windows.Forms.TextBox tbMI;
        private System.Windows.Forms.TextBox tbHI;
        private System.Windows.Forms.TextBox tbMDesde;
        private System.Windows.Forms.TextBox tbMG;
        private System.Windows.Forms.TextBox tbHG;
    }
}

