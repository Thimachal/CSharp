namespace Aula60
{
    partial class Thimachal1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt = new System.Windows.Forms.Button();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt
            // 
            this.bt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt.Location = new System.Drawing.Point(76, 81);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(173, 68);
            this.bt.TabIndex = 0;
            this.bt.Text = "Botão Mágico";
            this.bt.UseVisualStyleBackColor = false;
            this.bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbnome
            // 
            this.tbnome.Location = new System.Drawing.Point(76, 12);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(173, 20);
            this.tbnome.TabIndex = 2;
            this.tbnome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(63, 168);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(35, 13);
            this.lb.TabIndex = 3;
            this.lb.Text = "label1";
            this.lb.Click += new System.EventHandler(this.lb1_Click);
            // 
            // Thimachal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.bt);
            this.Name = "Thimachal1";
            this.Text = "Thimachal1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.Label lb;
    }
}

