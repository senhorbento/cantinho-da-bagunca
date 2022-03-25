namespace TesteBuscaArquivo
{
    partial class BuscarArquivo
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
            this.BtLista1 = new System.Windows.Forms.Button();
            this.CxAbriArquivo = new System.Windows.Forms.OpenFileDialog();
            this.BxTextLista1 = new System.Windows.Forms.TextBox();
            this.LbLista1 = new System.Windows.Forms.Label();
            this.LbLista2 = new System.Windows.Forms.Label();
            this.BxTextLista2 = new System.Windows.Forms.TextBox();
            this.BtLista2 = new System.Windows.Forms.Button();
            this.BtLer = new System.Windows.Forms.Button();
            this.LbResultado = new System.Windows.Forms.Label();
            this.BtGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtLista1
            // 
            this.BtLista1.Location = new System.Drawing.Point(358, 55);
            this.BtLista1.Name = "BtLista1";
            this.BtLista1.Size = new System.Drawing.Size(30, 23);
            this.BtLista1.TabIndex = 0;
            this.BtLista1.Text = "...";
            this.BtLista1.UseVisualStyleBackColor = true;
            this.BtLista1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CxAbriArquivo
            // 
            this.CxAbriArquivo.FileName = "openFileDialog1";
            // 
            // BxTextLista1
            // 
            this.BxTextLista1.Location = new System.Drawing.Point(92, 55);
            this.BxTextLista1.Name = "BxTextLista1";
            this.BxTextLista1.Size = new System.Drawing.Size(260, 23);
            this.BxTextLista1.TabIndex = 1;
            // 
            // LbLista1
            // 
            this.LbLista1.AutoSize = true;
            this.LbLista1.Location = new System.Drawing.Point(29, 59);
            this.LbLista1.Name = "LbLista1";
            this.LbLista1.Size = new System.Drawing.Size(43, 15);
            this.LbLista1.TabIndex = 2;
            this.LbLista1.Text = "Lista 1:";
            // 
            // LbLista2
            // 
            this.LbLista2.AutoSize = true;
            this.LbLista2.Location = new System.Drawing.Point(29, 92);
            this.LbLista2.Name = "LbLista2";
            this.LbLista2.Size = new System.Drawing.Size(43, 15);
            this.LbLista2.TabIndex = 5;
            this.LbLista2.Text = "Lista 2:";
            // 
            // BxTextLista2
            // 
            this.BxTextLista2.Location = new System.Drawing.Point(92, 88);
            this.BxTextLista2.Name = "BxTextLista2";
            this.BxTextLista2.Size = new System.Drawing.Size(260, 23);
            this.BxTextLista2.TabIndex = 4;
            // 
            // BtLista2
            // 
            this.BtLista2.Location = new System.Drawing.Point(358, 88);
            this.BtLista2.Name = "BtLista2";
            this.BtLista2.Size = new System.Drawing.Size(30, 23);
            this.BtLista2.TabIndex = 3;
            this.BtLista2.Text = "...";
            this.BtLista2.UseVisualStyleBackColor = true;
            this.BtLista2.Click += new System.EventHandler(this.BtLista2_Click);
            // 
            // BtLer
            // 
            this.BtLer.Location = new System.Drawing.Point(232, 171);
            this.BtLer.Name = "BtLer";
            this.BtLer.Size = new System.Drawing.Size(75, 23);
            this.BtLer.TabIndex = 6;
            this.BtLer.Text = "Ler";
            this.BtLer.UseVisualStyleBackColor = true;
            this.BtLer.Click += new System.EventHandler(this.BtLer_Click);
            // 
            // BtGravar
            // 
            this.BtGravar.Location = new System.Drawing.Point(313, 171);
            this.BtGravar.Name = "BtGravar";
            this.BtGravar.Size = new System.Drawing.Size(75, 23);
            this.BtGravar.TabIndex = 8;
            this.BtGravar.Text = "Gravar";
            this.BtGravar.UseVisualStyleBackColor = true;
            this.BtGravar.Click += new System.EventHandler(this.BtGravar_Click);
            // 
            // BuscarArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 218);
            this.Controls.Add(this.BtGravar);
            this.Controls.Add(this.LbResultado);
            this.Controls.Add(this.BtLer);
            this.Controls.Add(this.LbLista2);
            this.Controls.Add(this.BxTextLista2);
            this.Controls.Add(this.BtLista2);
            this.Controls.Add(this.LbLista1);
            this.Controls.Add(this.BxTextLista1);
            this.Controls.Add(this.BtLista1);
            this.Name = "BuscarArquivo";
            this.Text = "BuscarArquivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtLista1;
        private OpenFileDialog CxAbriArquivo;
        private TextBox BxTextLista1;
        private Label LbLista1;
        private Label LbLista2;
        private TextBox BxTextLista2;
        private Button BtLista2;
        private Button BtLer;
        private Label LbResultado;
        private Button BtGravar;
    }
}