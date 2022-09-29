
namespace Senhas
{
    partial class servidor
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
            this.btn_sair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_servidor = new System.Windows.Forms.Label();
            this.btn_testar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.tbox_senha = new System.Windows.Forms.TextBox();
            this.tbox_login = new System.Windows.Forms.TextBox();
            this.tbox_servidor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(12, 292);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(84, 37);
            this.btn_sair.TabIndex = 21;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Senha :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Usuario :";
            // 
            // lbl_servidor
            // 
            this.lbl_servidor.AutoSize = true;
            this.lbl_servidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_servidor.Location = new System.Drawing.Point(13, 15);
            this.lbl_servidor.Name = "lbl_servidor";
            this.lbl_servidor.Size = new System.Drawing.Size(71, 20);
            this.lbl_servidor.TabIndex = 17;
            this.lbl_servidor.Text = "Servidor:";
            // 
            // btn_testar
            // 
            this.btn_testar.Location = new System.Drawing.Point(102, 292);
            this.btn_testar.Name = "btn_testar";
            this.btn_testar.Size = new System.Drawing.Size(84, 37);
            this.btn_testar.TabIndex = 16;
            this.btn_testar.Text = "Testar Conexão";
            this.btn_testar.UseVisualStyleBackColor = true;
            this.btn_testar.Click += new System.EventHandler(this.btn_testar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(192, 292);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(90, 37);
            this.btn_salvar.TabIndex = 15;
            this.btn_salvar.Text = "Salvar Ccnfiguração";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tbox_senha
            // 
            this.tbox_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_senha.Location = new System.Drawing.Point(8, 164);
            this.tbox_senha.Name = "tbox_senha";
            this.tbox_senha.Size = new System.Drawing.Size(270, 26);
            this.tbox_senha.TabIndex = 14;
            // 
            // tbox_login
            // 
            this.tbox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_login.Location = new System.Drawing.Point(8, 100);
            this.tbox_login.Name = "tbox_login";
            this.tbox_login.Size = new System.Drawing.Size(270, 26);
            this.tbox_login.TabIndex = 13;
            // 
            // tbox_servidor
            // 
            this.tbox_servidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_servidor.Location = new System.Drawing.Point(12, 38);
            this.tbox_servidor.Name = "tbox_servidor";
            this.tbox_servidor.Size = new System.Drawing.Size(270, 26);
            this.tbox_servidor.TabIndex = 11;
            // 
            // servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 359);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_servidor);
            this.Controls.Add(this.btn_testar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.tbox_senha);
            this.Controls.Add(this.tbox_login);
            this.Controls.Add(this.tbox_servidor);
            this.Name = "servidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "primeira";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.servidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_servidor;
        private System.Windows.Forms.Button btn_testar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox tbox_senha;
        private System.Windows.Forms.TextBox tbox_login;
        private System.Windows.Forms.TextBox tbox_servidor;
    }
}