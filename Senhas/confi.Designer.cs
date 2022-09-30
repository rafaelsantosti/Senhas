
namespace Senhas
{
    partial class confi
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confi));
            this.tbox_servidor = new System.Windows.Forms.TextBox();
            this.tbox_banco = new System.Windows.Forms.TextBox();
            this.tbox_login = new System.Windows.Forms.TextBox();
            this.tbox_senha = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_testar = new System.Windows.Forms.Button();
            this.lbl_servidor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_criar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tbox_servidor
            // 
            this.tbox_servidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_servidor.Location = new System.Drawing.Point(29, 40);
            this.tbox_servidor.Name = "tbox_servidor";
            this.tbox_servidor.Size = new System.Drawing.Size(270, 26);
            this.tbox_servidor.TabIndex = 0;
            this.tbox_servidor.TextChanged += new System.EventHandler(this.tbox_servidor_TextChanged);
            // 
            // tbox_banco
            // 
            this.tbox_banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_banco.Location = new System.Drawing.Point(29, 110);
            this.tbox_banco.Name = "tbox_banco";
            this.tbox_banco.Size = new System.Drawing.Size(270, 26);
            this.tbox_banco.TabIndex = 1;
            this.tbox_banco.TextChanged += new System.EventHandler(this.tbox_banco_TextChanged);
            // 
            // tbox_login
            // 
            this.tbox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_login.Location = new System.Drawing.Point(29, 180);
            this.tbox_login.Name = "tbox_login";
            this.tbox_login.Size = new System.Drawing.Size(270, 26);
            this.tbox_login.TabIndex = 2;
            this.tbox_login.TextChanged += new System.EventHandler(this.tbox_login_TextChanged);
            // 
            // tbox_senha
            // 
            this.tbox_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_senha.Location = new System.Drawing.Point(29, 244);
            this.tbox_senha.Name = "tbox_senha";
            this.tbox_senha.Size = new System.Drawing.Size(270, 26);
            this.tbox_senha.TabIndex = 3;
            this.tbox_senha.TextChanged += new System.EventHandler(this.tbox_senha_TextChanged);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(209, 294);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(90, 37);
            this.btn_salvar.TabIndex = 4;
            this.btn_salvar.Text = "Salvar Ccnfiguração";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_testar
            // 
            this.btn_testar.Location = new System.Drawing.Point(119, 294);
            this.btn_testar.Name = "btn_testar";
            this.btn_testar.Size = new System.Drawing.Size(84, 37);
            this.btn_testar.TabIndex = 5;
            this.btn_testar.Text = "Testar Conexão";
            this.btn_testar.UseVisualStyleBackColor = true;
            this.btn_testar.Click += new System.EventHandler(this.btn_testar_Click);
            // 
            // lbl_servidor
            // 
            this.lbl_servidor.AutoSize = true;
            this.lbl_servidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_servidor.Location = new System.Drawing.Point(30, 17);
            this.lbl_servidor.Name = "lbl_servidor";
            this.lbl_servidor.Size = new System.Drawing.Size(71, 20);
            this.lbl_servidor.TabIndex = 6;
            this.lbl_servidor.Text = "Servidor:";
            this.lbl_servidor.Click += new System.EventHandler(this.lbl_servidor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Banco de Dados:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Senha :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(29, 294);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(84, 37);
            this.btn_sair.TabIndex = 10;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(434, 294);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(84, 37);
            this.btn_criar.TabIndex = 11;
            this.btn_criar.Text = "Criar Banco de Dados";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(524, 294);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(90, 37);
            this.btn_deletar.TabIndex = 12;
            this.btn_deletar.Text = "Excluir Banco de Dados";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(344, 294);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(84, 37);
            this.btn_show.TabIndex = 13;
            this.btn_show.Text = "Mostrar Banco de Dados";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // list
            // 
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.FullRowSelect = true;
            this.list.GridLines = true;
            this.list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list.HideSelection = false;
            this.list.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.list.Location = new System.Drawing.Point(344, 40);
            this.list.MultiSelect = false;
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(270, 230);
            this.list.TabIndex = 14;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "BANCO DE DADOS ";
            this.columnHeader1.Width = 263;
            // 
            // confi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 346);
            this.Controls.Add(this.list);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_servidor);
            this.Controls.Add(this.btn_testar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.tbox_senha);
            this.Controls.Add(this.tbox_login);
            this.Controls.Add(this.tbox_banco);
            this.Controls.Add(this.tbox_servidor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "confi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIGURAÇÂO BANCO DE DADOS";
            this.Load += new System.EventHandler(this.confi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_servidor;
        private System.Windows.Forms.TextBox tbox_banco;
        private System.Windows.Forms.TextBox tbox_login;
        private System.Windows.Forms.TextBox tbox_senha;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_testar;
        private System.Windows.Forms.Label lbl_servidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}