namespace Reservas
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
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.rbtVentana = new System.Windows.Forms.RadioButton();
            this.rbtCentro = new System.Windows.Forms.RadioButton();
            this.rbtPasillo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaSalida.Location = new System.Drawing.Point(91, 177);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(200, 35);
            this.dtpFechaSalida.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Salida";
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(124, 268);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(167, 61);
            this.btnReservar.TabIndex = 8;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // cboOrigen
            // 
            this.cboOrigen.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Location = new System.Drawing.Point(91, 79);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(200, 37);
            this.cboOrigen.TabIndex = 10;
            // 
            // cboDestino
            // 
            this.cboDestino.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Location = new System.Drawing.Point(461, 75);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(204, 37);
            this.cboDestino.TabIndex = 11;
            // 
            // rbtVentana
            // 
            this.rbtVentana.AutoSize = true;
            this.rbtVentana.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtVentana.Location = new System.Drawing.Point(462, 147);
            this.rbtVentana.Name = "rbtVentana";
            this.rbtVentana.Size = new System.Drawing.Size(208, 33);
            this.rbtVentana.TabIndex = 12;
            this.rbtVentana.TabStop = true;
            this.rbtVentana.Text = "Asiento en Ventana";
            this.rbtVentana.UseVisualStyleBackColor = true;
            // 
            // rbtCentro
            // 
            this.rbtCentro.AutoSize = true;
            this.rbtCentro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCentro.Location = new System.Drawing.Point(461, 203);
            this.rbtCentro.Name = "rbtCentro";
            this.rbtCentro.Size = new System.Drawing.Size(214, 33);
            this.rbtCentro.TabIndex = 13;
            this.rbtCentro.TabStop = true;
            this.rbtCentro.Text = "Asiento en el Centro";
            this.rbtCentro.UseVisualStyleBackColor = true;
            // 
            // rbtPasillo
            // 
            this.rbtPasillo.AutoSize = true;
            this.rbtPasillo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPasillo.Location = new System.Drawing.Point(462, 254);
            this.rbtPasillo.Name = "rbtPasillo";
            this.rbtPasillo.Size = new System.Drawing.Size(212, 33);
            this.rbtPasillo.TabIndex = 14;
            this.rbtPasillo.TabStop = true;
            this.rbtPasillo.Text = "Asiento en el Pasillo";
            this.rbtPasillo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtPasillo);
            this.Controls.Add(this.rbtCentro);
            this.Controls.Add(this.rbtVentana);
            this.Controls.Add(this.cboDestino);
            this.Controls.Add(this.cboOrigen);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.RadioButton rbtVentana;
        private System.Windows.Forms.RadioButton rbtCentro;
        private System.Windows.Forms.RadioButton rbtPasillo;
    }
}

