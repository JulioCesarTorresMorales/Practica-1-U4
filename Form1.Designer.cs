namespace Practica_1_U4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnLimpiar = new Button();
            label4 = new Label();
            label5 = new Label();
            txtResultado = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 29);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 85);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 137);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Numero 2:";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(222, 77);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(132, 23);
            txtNumero1.TabIndex = 3;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(222, 129);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(132, 23);
            txtNumero2.TabIndex = 4;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(614, 42);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(124, 30);
            btnSumar.TabIndex = 5;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(614, 85);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(124, 30);
            btnRestar.TabIndex = 6;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(614, 129);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(124, 30);
            btnMultiplicar.TabIndex = 7;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(614, 175);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(124, 30);
            btnDividir.TabIndex = 8;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += button4_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(85, 200);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(124, 30);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 258);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 10;
            label4.Text = "Resultado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 322);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 11;
            label5.Text = "Resultado:";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(222, 322);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(132, 23);
            txtResultado.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(642, 284);
            button1.Name = "button1";
            button1.Size = new Size(96, 39);
            button1.TabIndex = 13;
            button1.Text = "Propiedades";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtResultado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnLimpiar);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Procedimientos y Funciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnLimpiar;
        private Label label4;
        private Label label5;
        private TextBox txtResultado;
        private Button button1;
    }
}