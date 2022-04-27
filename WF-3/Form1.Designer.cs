namespace WF_3
{
    partial class Form1
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
            this.btnCriarPasta = new System.Windows.Forms.Button();
            this.btnDeletaPasta = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCriarPasta = new System.Windows.Forms.TextBox();
            this.txtDeletaPasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArqOrigem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArqDestino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeArq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCriarPasta
            // 
            this.btnCriarPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPasta.Location = new System.Drawing.Point(319, 47);
            this.btnCriarPasta.Name = "btnCriarPasta";
            this.btnCriarPasta.Size = new System.Drawing.Size(75, 23);
            this.btnCriarPasta.TabIndex = 0;
            this.btnCriarPasta.Text = "Criar";
            this.btnCriarPasta.UseVisualStyleBackColor = true;
            this.btnCriarPasta.Click += new System.EventHandler(this.btnCriarPasta_Click);
            // 
            // btnDeletaPasta
            // 
            this.btnDeletaPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletaPasta.Location = new System.Drawing.Point(319, 112);
            this.btnDeletaPasta.Name = "btnDeletaPasta";
            this.btnDeletaPasta.Size = new System.Drawing.Size(75, 23);
            this.btnDeletaPasta.TabIndex = 1;
            this.btnDeletaPasta.Text = "Deleta";
            this.btnDeletaPasta.UseVisualStyleBackColor = true;
            this.btnDeletaPasta.Click += new System.EventHandler(this.btnDeletaPasta_Click);
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.Location = new System.Drawing.Point(319, 254);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(95, 35);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome da Pasta a Ser Criada";
            // 
            // txtCriarPasta
            // 
            this.txtCriarPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriarPasta.Location = new System.Drawing.Point(63, 48);
            this.txtCriarPasta.Name = "txtCriarPasta";
            this.txtCriarPasta.Size = new System.Drawing.Size(157, 22);
            this.txtCriarPasta.TabIndex = 5;
            // 
            // txtDeletaPasta
            // 
            this.txtDeletaPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeletaPasta.Location = new System.Drawing.Point(63, 113);
            this.txtDeletaPasta.Name = "txtDeletaPasta";
            this.txtDeletaPasta.Size = new System.Drawing.Size(157, 22);
            this.txtDeletaPasta.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome da Pasta a Ser Deletada";
            // 
            // txtArqOrigem
            // 
            this.txtArqOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArqOrigem.Location = new System.Drawing.Point(63, 253);
            this.txtArqOrigem.Name = "txtArqOrigem";
            this.txtArqOrigem.Size = new System.Drawing.Size(157, 22);
            this.txtArqOrigem.TabIndex = 9;
            this.txtArqOrigem.TextChanged += new System.EventHandler(this.txtArqOrigem_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome da pasta de Origem";
            // 
            // txtArqDestino
            // 
            this.txtArqDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArqDestino.Location = new System.Drawing.Point(63, 301);
            this.txtArqDestino.Name = "txtArqDestino";
            this.txtArqDestino.Size = new System.Drawing.Size(157, 22);
            this.txtArqDestino.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome da pasta de Destino";
            // 
            // txtNomeArq
            // 
            this.txtNomeArq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeArq.Location = new System.Drawing.Point(63, 205);
            this.txtNomeArq.Name = "txtNomeArq";
            this.txtNomeArq.Size = new System.Drawing.Size(157, 22);
            this.txtNomeArq.TabIndex = 13;
            this.txtNomeArq.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome do Arquivo ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 356);
            this.Controls.Add(this.txtNomeArq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtArqDestino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArqOrigem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDeletaPasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCriarPasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnDeletaPasta);
            this.Controls.Add(this.btnCriarPasta);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarPasta;
        private System.Windows.Forms.Button btnDeletaPasta;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCriarPasta;
        private System.Windows.Forms.TextBox txtDeletaPasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArqOrigem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArqDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeArq;
        private System.Windows.Forms.Label label5;
    }
}

