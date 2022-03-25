namespace Calculadora
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
            this.BtSomar = new System.Windows.Forms.Button();
            this.BtSubtrair = new System.Windows.Forms.Button();
            this.BtDividir = new System.Windows.Forms.Button();
            this.BtMultiplicar = new System.Windows.Forms.Button();
            this.BxFirstValue = new System.Windows.Forms.TextBox();
            this.BxSecondValue = new System.Windows.Forms.TextBox();
            this.LbFirstValue = new System.Windows.Forms.Label();
            this.LbSecondValue = new System.Windows.Forms.Label();
            this.LbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtSomar
            // 
            this.BtSomar.Location = new System.Drawing.Point(213, 44);
            this.BtSomar.Name = "BtSomar";
            this.BtSomar.Size = new System.Drawing.Size(75, 23);
            this.BtSomar.TabIndex = 0;
            this.BtSomar.Text = "Somar";
            this.BtSomar.UseVisualStyleBackColor = true;
            this.BtSomar.Click += new System.EventHandler(this.Somar_Click);
            // 
            // BtSubtrair
            // 
            this.BtSubtrair.Location = new System.Drawing.Point(213, 73);
            this.BtSubtrair.Name = "BtSubtrair";
            this.BtSubtrair.Size = new System.Drawing.Size(75, 23);
            this.BtSubtrair.TabIndex = 1;
            this.BtSubtrair.Text = "Subtrair";
            this.BtSubtrair.UseVisualStyleBackColor = true;
            this.BtSubtrair.Click += new System.EventHandler(this.BtSubtrair_Click);
            // 
            // BtDividir
            // 
            this.BtDividir.Location = new System.Drawing.Point(213, 102);
            this.BtDividir.Name = "BtDividir";
            this.BtDividir.Size = new System.Drawing.Size(75, 23);
            this.BtDividir.TabIndex = 2;
            this.BtDividir.Text = "Dividir";
            this.BtDividir.UseVisualStyleBackColor = true;
            this.BtDividir.Click += new System.EventHandler(this.BtDividir_Click);
            // 
            // BtMultiplicar
            // 
            this.BtMultiplicar.Location = new System.Drawing.Point(213, 131);
            this.BtMultiplicar.Name = "BtMultiplicar";
            this.BtMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.BtMultiplicar.TabIndex = 3;
            this.BtMultiplicar.Text = "Multiplicar";
            this.BtMultiplicar.UseVisualStyleBackColor = true;
            this.BtMultiplicar.Click += new System.EventHandler(this.BtMultiplicar_Click);
            // 
            // BxFirstValue
            // 
            this.BxFirstValue.Location = new System.Drawing.Point(74, 44);
            this.BxFirstValue.Name = "BxFirstValue";
            this.BxFirstValue.Size = new System.Drawing.Size(100, 23);
            this.BxFirstValue.TabIndex = 4;
            // 
            // BxSecondValue
            // 
            this.BxSecondValue.Location = new System.Drawing.Point(74, 74);
            this.BxSecondValue.Name = "BxSecondValue";
            this.BxSecondValue.Size = new System.Drawing.Size(100, 23);
            this.BxSecondValue.TabIndex = 5;
            // 
            // LbFirstValue
            // 
            this.LbFirstValue.AutoSize = true;
            this.LbFirstValue.Location = new System.Drawing.Point(30, 48);
            this.LbFirstValue.Name = "LbFirstValue";
            this.LbFirstValue.Size = new System.Drawing.Size(33, 15);
            this.LbFirstValue.TabIndex = 6;
            this.LbFirstValue.Text = "Valor";
            // 
            // LbSecondValue
            // 
            this.LbSecondValue.AutoSize = true;
            this.LbSecondValue.Location = new System.Drawing.Point(30, 77);
            this.LbSecondValue.Name = "LbSecondValue";
            this.LbSecondValue.Size = new System.Drawing.Size(33, 15);
            this.LbSecondValue.TabIndex = 7;
            this.LbSecondValue.Text = "Valor";
            // 
            // LbResultado
            // 
            this.LbResultado.AutoSize = true;
            this.LbResultado.Location = new System.Drawing.Point(30, 135);
            this.LbResultado.Name = "LbResultado";
            this.LbResultado.Size = new System.Drawing.Size(65, 15);
            this.LbResultado.TabIndex = 8;
            this.LbResultado.Text = "Resultado: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.LbResultado);
            this.Controls.Add(this.LbSecondValue);
            this.Controls.Add(this.LbFirstValue);
            this.Controls.Add(this.BxSecondValue);
            this.Controls.Add(this.BxFirstValue);
            this.Controls.Add(this.BtMultiplicar);
            this.Controls.Add(this.BtDividir);
            this.Controls.Add(this.BtSubtrair);
            this.Controls.Add(this.BtSomar);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtSomar;
        private Button BtSubtrair;
        private Button BtDividir;
        private Button BtMultiplicar;
        private TextBox BxFirstValue;
        private TextBox BxSecondValue;
        private Label LbFirstValue;
        private Label LbSecondValue;
        private Label LbResultado;
    }
}