namespace Senhas
{
    partial class cadastropaciente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_sus = new System.Windows.Forms.TextBox();
            this.tbox_nome = new System.Windows.Forms.TextBox();
            this.tbox_end = new System.Windows.Forms.TextBox();
            this.tbox_obs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.tbox_data = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rmas = new System.Windows.Forms.RadioButton();
            this.rfem = new System.Windows.Forms.RadioButton();
            this.btn_informacoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de Nascimento:";
            // 
            // tbox_sus
            // 
            this.tbox_sus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_sus.Location = new System.Drawing.Point(35, 36);
            this.tbox_sus.Name = "tbox_sus";
            this.tbox_sus.Size = new System.Drawing.Size(460, 26);
            this.tbox_sus.TabIndex = 1;
            // 
            // tbox_nome
            // 
            this.tbox_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_nome.Location = new System.Drawing.Point(35, 92);
            this.tbox_nome.Name = "tbox_nome";
            this.tbox_nome.Size = new System.Drawing.Size(460, 26);
            this.tbox_nome.TabIndex = 2;
            // 
            // tbox_end
            // 
            this.tbox_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_end.Location = new System.Drawing.Point(35, 154);
            this.tbox_end.Name = "tbox_end";
            this.tbox_end.Size = new System.Drawing.Size(460, 26);
            this.tbox_end.TabIndex = 3;
            // 
            // tbox_obs
            // 
            this.tbox_obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_obs.Location = new System.Drawing.Point(41, 346);
            this.tbox_obs.Multiline = true;
            this.tbox_obs.Name = "tbox_obs";
            this.tbox_obs.Size = new System.Drawing.Size(454, 142);
            this.tbox_obs.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "OBS:";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(399, 562);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(108, 66);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(263, 561);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(108, 66);
            this.btn_voltar.TabIndex = 7;
            this.btn_voltar.Text = "VOLTAR";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // tbox_data
            // 
            this.tbox_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbox_data.Location = new System.Drawing.Point(35, 216);
            this.tbox_data.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.tbox_data.Name = "tbox_data";
            this.tbox_data.Size = new System.Drawing.Size(177, 26);
            this.tbox_data.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(399, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 66);
            this.button1.TabIndex = 14;
            this.button1.Text = "ALTERAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sexo:";
            // 
            // rmas
            // 
            this.rmas.AutoSize = true;
            this.rmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmas.Location = new System.Drawing.Point(112, 255);
            this.rmas.Name = "rmas";
            this.rmas.Size = new System.Drawing.Size(107, 24);
            this.rmas.TabIndex = 16;
            this.rmas.TabStop = true;
            this.rmas.Text = "Masculino";
            this.rmas.UseVisualStyleBackColor = true;
            // 
            // rfem
            // 
            this.rfem.AutoSize = true;
            this.rfem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfem.Location = new System.Drawing.Point(112, 285);
            this.rfem.Name = "rfem";
            this.rfem.Size = new System.Drawing.Size(100, 24);
            this.rfem.TabIndex = 16;
            this.rfem.TabStop = true;
            this.rfem.Text = "Feminino";
            this.rfem.UseVisualStyleBackColor = true;
            // 
            // btn_informacoes
            // 
            this.btn_informacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_informacoes.Location = new System.Drawing.Point(35, 561);
            this.btn_informacoes.Name = "btn_informacoes";
            this.btn_informacoes.Size = new System.Drawing.Size(108, 66);
            this.btn_informacoes.TabIndex = 17;
            this.btn_informacoes.Text = "Informações do Paciente";
            this.btn_informacoes.UseVisualStyleBackColor = true;
            this.btn_informacoes.Visible = false;
            this.btn_informacoes.Click += new System.EventHandler(this.btn_informacoes_Click);
            // 
            // cadastropaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 639);
            this.Controls.Add(this.btn_informacoes);
            this.Controls.Add(this.rfem);
            this.Controls.Add(this.rmas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbox_data);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.tbox_obs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbox_end);
            this.Controls.Add(this.tbox_nome);
            this.Controls.Add(this.tbox_sus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cadastropaciente";
            this.Text = "cadastropaciente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.cadastropaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_sus;
        private System.Windows.Forms.TextBox tbox_nome;
        private System.Windows.Forms.TextBox tbox_end;
        private System.Windows.Forms.TextBox tbox_obs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DateTimePicker tbox_data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rmas;
        private System.Windows.Forms.RadioButton rfem;
        private System.Windows.Forms.Button btn_informacoes;
    }
}