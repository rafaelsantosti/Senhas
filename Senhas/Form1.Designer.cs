namespace Senhas
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
            this.components = new System.ComponentModel.Container();
            this.btn_senha = new System.Windows.Forms.Button();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.btn_retirar = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_total1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_conectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_senha
            // 
            this.btn_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_senha.ForeColor = System.Drawing.Color.Red;
            this.btn_senha.Location = new System.Drawing.Point(544, 246);
            this.btn_senha.MinimumSize = new System.Drawing.Size(200, 200);
            this.btn_senha.Name = "btn_senha";
            this.btn_senha.Size = new System.Drawing.Size(289, 200);
            this.btn_senha.TabIndex = 0;
            this.btn_senha.Text = "CHAMAR SENHA";
            this.btn_senha.UseVisualStyleBackColor = true;
            this.btn_senha.Click += new System.EventHandler(this.btn_senha_Click);
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.Color.Black;
            this.lbl_senha.Location = new System.Drawing.Point(548, 69);
            this.lbl_senha.MinimumSize = new System.Drawing.Size(300, 150);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(300, 150);
            this.lbl_senha.TabIndex = 1;
            this.lbl_senha.Text = "123";
            this.lbl_senha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_senha.Visible = false;
            // 
            // btn_retirar
            // 
            this.btn_retirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retirar.ForeColor = System.Drawing.Color.Red;
            this.btn_retirar.Location = new System.Drawing.Point(19, 13);
            this.btn_retirar.Name = "btn_retirar";
            this.btn_retirar.Size = new System.Drawing.Size(363, 206);
            this.btn_retirar.TabIndex = 2;
            this.btn_retirar.Text = "TIRAR SENHA";
            this.btn_retirar.UseVisualStyleBackColor = true;
            this.btn_retirar.Click += new System.EventHandler(this.btn_retirar_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Red;
            this.lbl_total.Location = new System.Drawing.Point(12, 295);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(391, 42);
            this.lbl_total.TabIndex = 3;
            this.lbl_total.Text = "TOTAL DE SENHAS:";
            // 
            // lbl_total1
            // 
            this.lbl_total1.AutoSize = true;
            this.lbl_total1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total1.ForeColor = System.Drawing.Color.Black;
            this.lbl_total1.Location = new System.Drawing.Point(12, 349);
            this.lbl_total1.Name = "lbl_total1";
            this.lbl_total1.Size = new System.Drawing.Size(40, 42);
            this.lbl_total1.TabIndex = 4;
            this.lbl_total1.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(119, 402);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_conectar.TabIndex = 5;
            this.btn_conectar.Text = "conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 529);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_total1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_retirar);
            this.Controls.Add(this.btn_senha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_senha;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Button btn_retirar;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_total1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_conectar;
    }
}

