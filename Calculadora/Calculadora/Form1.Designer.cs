namespace Calculadora
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
            this.tbCalculos = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSimbolo = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.tbHistorial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbCalculos
            // 
            this.tbCalculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCalculos.Location = new System.Drawing.Point(606, 74);
            this.tbCalculos.Margin = new System.Windows.Forms.Padding(6);
            this.tbCalculos.Name = "tbCalculos";
            this.tbCalculos.Size = new System.Drawing.Size(406, 80);
            this.tbCalculos.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(606, 175);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 55);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSimbolo
            // 
            this.btnSimbolo.Location = new System.Drawing.Point(714, 175);
            this.btnSimbolo.Name = "btnSimbolo";
            this.btnSimbolo.Size = new System.Drawing.Size(83, 55);
            this.btnSimbolo.TabIndex = 2;
            this.btnSimbolo.Text = "+/-";
            this.btnSimbolo.UseVisualStyleBackColor = true;
            this.btnSimbolo.Click += new System.EventHandler(this.btnSimbolo_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(822, 175);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(83, 55);
            this.btnRaiz.TabIndex = 3;
            this.btnRaiz.Tag = "√";
            this.btnRaiz.Text = "√x";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Location = new System.Drawing.Point(929, 175);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(83, 55);
            this.btnCuadrado.TabIndex = 4;
            this.btnCuadrado.Tag = "²";
            this.btnCuadrado.Text = "x²";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(929, 264);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(83, 39);
            this.btnDivision.TabIndex = 8;
            this.btnDivision.Tag = "/";
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(822, 264);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(83, 55);
            this.btnNum9.TabIndex = 7;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(714, 264);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(83, 55);
            this.btnNum8.TabIndex = 6;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(606, 264);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(83, 55);
            this.btnNum7.TabIndex = 5;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(822, 348);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(83, 55);
            this.btnNum6.TabIndex = 11;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(714, 348);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(83, 55);
            this.btnNum5.TabIndex = 10;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(606, 348);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(83, 55);
            this.btnNum4.TabIndex = 9;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(822, 437);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(83, 55);
            this.btnNum3.TabIndex = 15;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(714, 437);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(83, 55);
            this.btnNum2.TabIndex = 14;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(606, 437);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(83, 55);
            this.btnNum1.TabIndex = 13;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(929, 493);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(83, 78);
            this.btnIgual.TabIndex = 19;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(714, 516);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(83, 55);
            this.btnNum0.TabIndex = 18;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(606, 516);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(83, 55);
            this.btnHistorial.TabIndex = 17;
            this.btnHistorial.Text = "◴";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(929, 321);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(83, 39);
            this.btnMultiplicacion.TabIndex = 20;
            this.btnMultiplicacion.Tag = "X";
            this.btnMultiplicacion.Text = "x";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(929, 379);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(83, 39);
            this.btnResta.TabIndex = 21;
            this.btnResta.Tag = "-";
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(929, 437);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(83, 39);
            this.btnSuma.TabIndex = 22;
            this.btnSuma.Tag = "+";
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(822, 516);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(83, 55);
            this.btnDecimal.TabIndex = 23;
            this.btnDecimal.Tag = ".";
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // tbHistorial
            // 
            this.tbHistorial.Location = new System.Drawing.Point(167, 175);
            this.tbHistorial.Multiline = true;
            this.tbHistorial.Name = "tbHistorial";
            this.tbHistorial.Size = new System.Drawing.Size(403, 396);
            this.tbHistorial.TabIndex = 24;
            this.tbHistorial.Visible = false;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tbHistorial);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnSimbolo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbCalculos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Calculadora";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.Click += new System.EventHandler(this.agregarNumero);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCalculos;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSimbolo;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.TextBox tbHistorial;
    }
}

