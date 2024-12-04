namespace Controle_de_Vendas.br.com.projeto.view
{
    partial class Input
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
            this.Nome = new System.Windows.Forms.Label();
            this.txtidfuncionario = new System.Windows.Forms.TextBox();
            this.btnprocuraid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(48, 34);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(120, 18);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "ID do funcionario";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtidfuncionario
            // 
            this.txtidfuncionario.Location = new System.Drawing.Point(51, 66);
            this.txtidfuncionario.Name = "txtidfuncionario";
            this.txtidfuncionario.Size = new System.Drawing.Size(376, 22);
            this.txtidfuncionario.TabIndex = 1;
            this.txtidfuncionario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnprocuraid
            // 
            this.btnprocuraid.Location = new System.Drawing.Point(188, 214);
            this.btnprocuraid.Name = "btnprocuraid";
            this.btnprocuraid.Size = new System.Drawing.Size(108, 40);
            this.btnprocuraid.TabIndex = 2;
            this.btnprocuraid.Text = "Excluir";
            this.btnprocuraid.UseVisualStyleBackColor = true;
            this.btnprocuraid.Click += new System.EventHandler(this.button1_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(481, 266);
            this.Controls.Add(this.btnprocuraid);
            this.Controls.Add(this.txtidfuncionario);
            this.Controls.Add(this.Nome);
            this.Name = "Input";
            this.Text = "Input";
            this.Load += new System.EventHandler(this.Input_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtidfuncionario;
        private System.Windows.Forms.Button btnprocuraid;
    }
}