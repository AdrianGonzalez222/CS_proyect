﻿namespace Vista
{
    partial class VsFactura
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
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.dtFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNumeroCedula = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtApellidoUsuario = new System.Windows.Forms.TextBox();
            this.txtTefefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComprobante = new System.Windows.Forms.TextBox();
            this.dateTPFNF = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRegistrarDatosFact = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Location = new System.Drawing.Point(237, 26);
            this.txtNumFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.ReadOnly = true;
            this.txtNumFactura.Size = new System.Drawing.Size(269, 22);
            this.txtNumFactura.TabIndex = 0;
            this.txtNumFactura.TextChanged += new System.EventHandler(this.txtNumFactura_TextChanged);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(237, 133);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(269, 22);
            this.txtNombreUsuario.TabIndex = 2;
            // 
            // dtFechaFactura
            // 
            this.dtFechaFactura.Location = new System.Drawing.Point(237, 641);
            this.dtFechaFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFechaFactura.Name = "dtFechaFactura";
            this.dtFechaFactura.Size = new System.Drawing.Size(269, 22);
            this.dtFechaFactura.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero de factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero de cedula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 641);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de emision:";
            // 
            // cbNumeroCedula
            // 
            this.cbNumeroCedula.FormattingEnabled = true;
            this.cbNumeroCedula.Location = new System.Drawing.Point(237, 80);
            this.cbNumeroCedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNumeroCedula.Name = "cbNumeroCedula";
            this.cbNumeroCedula.Size = new System.Drawing.Size(269, 24);
            this.cbNumeroCedula.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Apellido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha nacimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Teléfono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Dirección:";
            // 
            // txtApellidoUsuario
            // 
            this.txtApellidoUsuario.Location = new System.Drawing.Point(237, 186);
            this.txtApellidoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoUsuario.Name = "txtApellidoUsuario";
            this.txtApellidoUsuario.Size = new System.Drawing.Size(269, 22);
            this.txtApellidoUsuario.TabIndex = 14;
            this.txtApellidoUsuario.TextChanged += new System.EventHandler(this.txtApellidoUsuario_TextChanged);
            // 
            // txtTefefono
            // 
            this.txtTefefono.Location = new System.Drawing.Point(237, 292);
            this.txtTefefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTefefono.Name = "txtTefefono";
            this.txtTefefono.Size = new System.Drawing.Size(269, 22);
            this.txtTefefono.TabIndex = 16;
            this.txtTefefono.TextChanged += new System.EventHandler(this.txtTefefono_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(237, 345);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(269, 22);
            this.txtDireccion.TabIndex = 17;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(237, 398);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(269, 22);
            this.txtEstado.TabIndex = 18;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Comprobante";
            // 
            // txtComprobante
            // 
            this.txtComprobante.Location = new System.Drawing.Point(237, 441);
            this.txtComprobante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComprobante.Name = "txtComprobante";
            this.txtComprobante.Size = new System.Drawing.Size(269, 22);
            this.txtComprobante.TabIndex = 21;
            this.txtComprobante.TextChanged += new System.EventHandler(this.txtComprobante_TextChanged);
            // 
            // dateTPFNF
            // 
            this.dateTPFNF.Location = new System.Drawing.Point(237, 231);
            this.dateTPFNF.Margin = new System.Windows.Forms.Padding(4);
            this.dateTPFNF.Name = "dateTPFNF";
            this.dateTPFNF.Size = new System.Drawing.Size(265, 22);
            this.dateTPFNF.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 509);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Actividades";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 502);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 22);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(237, 567);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 22);
            this.textBox2.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(83, 572);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Membresía:";
            // 
            // btnRegistrarDatosFact
            // 
            this.btnRegistrarDatosFact.Location = new System.Drawing.Point(627, 64);
            this.btnRegistrarDatosFact.Name = "btnRegistrarDatosFact";
            this.btnRegistrarDatosFact.Size = new System.Drawing.Size(144, 52);
            this.btnRegistrarDatosFact.TabIndex = 27;
            this.btnRegistrarDatosFact.Text = "REGISTRAR";
            this.btnRegistrarDatosFact.UseVisualStyleBackColor = true;
            this.btnRegistrarDatosFact.Click += new System.EventHandler(this.btnRegistrarDatosFact_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 52);
            this.button1.TabIndex = 28;
            this.button1.Text = "VER REGISTRO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VsFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegistrarDatosFact);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTPFNF);
            this.Controls.Add(this.txtComprobante);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTefefono);
            this.Controls.Add(this.txtApellidoUsuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbNumeroCedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaFactura);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtNumFactura);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VsFactura";
            this.Text = "Datos Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.DateTimePicker dtFechaFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNumeroCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtApellidoUsuario;
        private System.Windows.Forms.TextBox txtTefefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtComprobante;
        private System.Windows.Forms.DateTimePicker dateTPFNF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRegistrarDatosFact;
        private System.Windows.Forms.Button button1;
    }
}