namespace RetoCalculadora
{
    partial class Calculadora
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
            this.primerNumero = new System.Windows.Forms.TextBox();
            this.segundoNumero = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRsultado = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.TextBox();
            this.reiniciar = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // primerNumero
            // 
            this.primerNumero.Location = new System.Drawing.Point(45, 53);
            this.primerNumero.Name = "primerNumero";
            this.primerNumero.Size = new System.Drawing.Size(63, 20);
            this.primerNumero.TabIndex = 0;
            this.primerNumero.Text = "5";
            this.primerNumero.TextChanged += new System.EventHandler(this.primerNumero_TextChanged);
            // 
            // segundoNumero
            // 
            this.segundoNumero.Location = new System.Drawing.Point(45, 86);
            this.segundoNumero.Name = "segundoNumero";
            this.segundoNumero.Size = new System.Drawing.Size(63, 20);
            this.segundoNumero.TabIndex = 1;
            this.segundoNumero.TextChanged += new System.EventHandler(this.segundoNumero_TextChanged);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(208, 50);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(30, 23);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(208, 79);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(30, 23);
            this.btnDivision.TabIndex = 3;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(244, 50);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(30, 23);
            this.btnResta.TabIndex = 4;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(244, 79);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(30, 23);
            this.btnMultiplicacion.TabIndex = 5;
            this.btnMultiplicacion.Text = "x";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(132, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "CALCULADORA";
            // 
            // lblRsultado
            // 
            this.lblRsultado.AutoSize = true;
            this.lblRsultado.Location = new System.Drawing.Point(25, 136);
            this.lblRsultado.Name = "lblRsultado";
            this.lblRsultado.Size = new System.Drawing.Size(13, 13);
            this.lblRsultado.TabIndex = 7;
            this.lblRsultado.Text = "=";
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(44, 133);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(64, 20);
            this.resultado.TabIndex = 8;
            this.resultado.TextChanged += new System.EventHandler(this.resultado_TextChanged);
            // 
            // reiniciar
            // 
            this.reiniciar.Location = new System.Drawing.Point(208, 173);
            this.reiniciar.Name = "reiniciar";
            this.reiniciar.Size = new System.Drawing.Size(66, 23);
            this.reiniciar.TabIndex = 10;
            this.reiniciar.Text = "Reiniciar";
            this.reiniciar.UseVisualStyleBackColor = true;
            this.reiniciar.Click += new System.EventHandler(this.reiniciar_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(208, 109);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(66, 23);
            this.btnRaiz.TabIndex = 11;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 208);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.reiniciar);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.lblRsultado);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.segundoNumero);
            this.Controls.Add(this.primerNumero);
            this.Name = "Calculadora";
            this.Text = "27-3442-2023";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox primerNumero;
        private System.Windows.Forms.TextBox segundoNumero;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRsultado;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button reiniciar;
        private System.Windows.Forms.Button btnRaiz;
    }
}

