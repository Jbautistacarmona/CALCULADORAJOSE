namespace CALCULADORAJOSE
{
    partial class FrmCalculadora
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
            this.button1Suma = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LbPrimerValor = new System.Windows.Forms.Label();
            this.LbSegundaValor = new System.Windows.Forms.Label();
            this.LbResultado = new System.Windows.Forms.Label();
            this.TxtPrimerValor = new System.Windows.Forms.TextBox();
            this.TxtSegundaValor = new System.Windows.Forms.TextBox();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.Dividir = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Multiplicacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1Suma
            // 
            this.button1Suma.Location = new System.Drawing.Point(51, 253);
            this.button1Suma.Name = "button1Suma";
            this.button1Suma.Size = new System.Drawing.Size(91, 42);
            this.button1Suma.TabIndex = 0;
            this.button1Suma.Text = "&Sumar";
            this.button1Suma.UseVisualStyleBackColor = true;
            this.button1Suma.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LbPrimerValor
            // 
            this.LbPrimerValor.AutoSize = true;
            this.LbPrimerValor.Location = new System.Drawing.Point(42, 47);
            this.LbPrimerValor.Name = "LbPrimerValor";
            this.LbPrimerValor.Size = new System.Drawing.Size(84, 16);
            this.LbPrimerValor.TabIndex = 2;
            this.LbPrimerValor.Text = "Primer Valor:";
            // 
            // LbSegundaValor
            // 
            this.LbSegundaValor.AutoSize = true;
            this.LbSegundaValor.Location = new System.Drawing.Point(42, 109);
            this.LbSegundaValor.Name = "LbSegundaValor";
            this.LbSegundaValor.Size = new System.Drawing.Size(100, 16);
            this.LbSegundaValor.TabIndex = 3;
            this.LbSegundaValor.Text = "Segundo Valor:";
            this.LbSegundaValor.Click += new System.EventHandler(this.label1_Click);
            // 
            // LbResultado
            // 
            this.LbResultado.AutoSize = true;
            this.LbResultado.Location = new System.Drawing.Point(42, 176);
            this.LbResultado.Name = "LbResultado";
            this.LbResultado.Size = new System.Drawing.Size(72, 16);
            this.LbResultado.TabIndex = 4;
            this.LbResultado.Text = "Resultado:";
            // 
            // TxtPrimerValor
            // 
            this.TxtPrimerValor.Location = new System.Drawing.Point(143, 47);
            this.TxtPrimerValor.Name = "TxtPrimerValor";
            this.TxtPrimerValor.Size = new System.Drawing.Size(248, 22);
            this.TxtPrimerValor.TabIndex = 5;
            this.TxtPrimerValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtSegundaValor
            // 
            this.TxtSegundaValor.Location = new System.Drawing.Point(143, 109);
            this.TxtSegundaValor.Name = "TxtSegundaValor";
            this.TxtSegundaValor.Size = new System.Drawing.Size(248, 22);
            this.TxtSegundaValor.TabIndex = 6;
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(143, 170);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(248, 22);
            this.TxtResultado.TabIndex = 7;
            // 
            // Dividir
            // 
            this.Dividir.Location = new System.Drawing.Point(177, 317);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(91, 42);
            this.Dividir.TabIndex = 8;
            this.Dividir.Text = "&Division";
            this.Dividir.UseVisualStyleBackColor = true;
            this.Dividir.Click += new System.EventHandler(this.button3_Click);
            // 
            // Resta
            // 
            this.Resta.Location = new System.Drawing.Point(177, 253);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(91, 42);
            this.Resta.TabIndex = 9;
            this.Resta.Text = "&Restar";
            this.Resta.UseVisualStyleBackColor = true;
            this.Resta.Click += new System.EventHandler(this.button4_Click);
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.Location = new System.Drawing.Point(51, 317);
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.Size = new System.Drawing.Size(91, 42);
            this.Multiplicacion.TabIndex = 10;
            this.Multiplicacion.Text = "&Multiplicar";
            this.Multiplicacion.UseVisualStyleBackColor = true;
            this.Multiplicacion.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmCalculadora
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(427, 371);
            this.Controls.Add(this.Multiplicacion);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtSegundaValor);
            this.Controls.Add(this.TxtPrimerValor);
            this.Controls.Add(this.LbResultado);
            this.Controls.Add(this.LbSegundaValor);
            this.Controls.Add(this.LbPrimerValor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1Suma);
            this.Name = "FrmCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.TxtPrimerValor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Suma;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LbPrimerValor;
        private System.Windows.Forms.Label LbSegundaValor;
        private System.Windows.Forms.Label LbResultado;
        private System.Windows.Forms.TextBox TxtPrimerValor;
        private System.Windows.Forms.TextBox TxtSegundaValor;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Multiplicacion;
    }
}