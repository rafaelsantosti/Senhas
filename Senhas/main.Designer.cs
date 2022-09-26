namespace Senhas
{
    partial class main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_pacientes = new System.Windows.Forms.DataGridView();
            this.btn_carregar = new System.Windows.Forms.Button();
            this.btn_senha = new System.Windows.Forms.Button();
            this.btn_retirar = new System.Windows.Forms.Button();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_total1 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_teste = new System.Windows.Forms.Button();
            this.lbl_data = new System.Windows.Forms.Label();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.alterar_cadastro = new System.Windows.Forms.Button();
            this.tbox_filtro = new System.Windows.Forms.TextBox();
            this.btn_listarsenha = new System.Windows.Forms.Button();
            this.btn_listarsenhadia = new System.Windows.Forms.Button();
            this.btn_senhasatendidashoje = new System.Windows.Forms.Button();
            this.btn_pacientes = new System.Windows.Forms.Button();
            this.medico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pacientes
            // 
            this.dgv_pacientes.AllowUserToAddRows = false;
            this.dgv_pacientes.AllowUserToDeleteRows = false;
            this.dgv_pacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pacientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_pacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_pacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pacientes.EnableHeadersVisualStyles = false;
            this.dgv_pacientes.GridColor = System.Drawing.Color.SandyBrown;
            this.dgv_pacientes.Location = new System.Drawing.Point(12, 93);
            this.dgv_pacientes.MultiSelect = false;
            this.dgv_pacientes.Name = "dgv_pacientes";
            this.dgv_pacientes.ReadOnly = true;
            this.dgv_pacientes.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_pacientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_pacientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pacientes.Size = new System.Drawing.Size(571, 390);
            this.dgv_pacientes.TabIndex = 0;
            // 
            // btn_carregar
            // 
            this.btn_carregar.Location = new System.Drawing.Point(1000, 529);
            this.btn_carregar.Name = "btn_carregar";
            this.btn_carregar.Size = new System.Drawing.Size(278, 23);
            this.btn_carregar.TabIndex = 1;
            this.btn_carregar.UseVisualStyleBackColor = true;
            this.btn_carregar.Visible = false;
            this.btn_carregar.Click += new System.EventHandler(this.btn_carregar_Click);
            // 
            // btn_senha
            // 
            this.btn_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_senha.ForeColor = System.Drawing.Color.Red;
            this.btn_senha.Location = new System.Drawing.Point(1000, 196);
            this.btn_senha.MinimumSize = new System.Drawing.Size(200, 200);
            this.btn_senha.Name = "btn_senha";
            this.btn_senha.Size = new System.Drawing.Size(301, 200);
            this.btn_senha.TabIndex = 3;
            this.btn_senha.Text = "CHAMAR SENHA";
            this.btn_senha.UseVisualStyleBackColor = true;
            this.btn_senha.Click += new System.EventHandler(this.btn_senha_Click_1);
            // 
            // btn_retirar
            // 
            this.btn_retirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retirar.ForeColor = System.Drawing.Color.Red;
            this.btn_retirar.Location = new System.Drawing.Point(598, 196);
            this.btn_retirar.MinimumSize = new System.Drawing.Size(200, 200);
            this.btn_retirar.Name = "btn_retirar";
            this.btn_retirar.Size = new System.Drawing.Size(382, 200);
            this.btn_retirar.TabIndex = 3;
            this.btn_retirar.Text = "RETIRAR SENHA";
            this.btn_retirar.UseVisualStyleBackColor = true;
            this.btn_retirar.Click += new System.EventHandler(this.btn_retirar_Click);
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.Color.Black;
            this.lbl_senha.Location = new System.Drawing.Point(1001, 43);
            this.lbl_senha.MinimumSize = new System.Drawing.Size(300, 150);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(300, 150);
            this.lbl_senha.TabIndex = 4;
            this.lbl_senha.Text = "123";
            this.lbl_senha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_senha.Visible = false;
            // 
            // lbl_total1
            // 
            this.lbl_total1.AutoSize = true;
            this.lbl_total1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total1.ForeColor = System.Drawing.Color.Black;
            this.lbl_total1.Location = new System.Drawing.Point(591, 136);
            this.lbl_total1.Name = "lbl_total1";
            this.lbl_total1.Size = new System.Drawing.Size(40, 42);
            this.lbl_total1.TabIndex = 6;
            this.lbl_total1.Text = "0";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.Red;
            this.lbl_total.Location = new System.Drawing.Point(589, 43);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(391, 84);
            this.lbl_total.TabIndex = 5;
            this.lbl_total.Text = "TOTAL DE SENHAS \r\nHOJE:";
            // 
            // btn_load
            // 
            this.btn_load.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_load.Location = new System.Drawing.Point(435, 489);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(148, 49);
            this.btn_load.TabIndex = 8;
            this.btn_load.Text = "TODAS SENHAS CHAMADAS";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_teste
            // 
            this.btn_teste.Location = new System.Drawing.Point(1000, 500);
            this.btn_teste.Name = "btn_teste";
            this.btn_teste.Size = new System.Drawing.Size(75, 23);
            this.btn_teste.TabIndex = 9;
            this.btn_teste.UseVisualStyleBackColor = true;
            this.btn_teste.Visible = false;
            this.btn_teste.Click += new System.EventHandler(this.btn_teste_Click);
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(1081, 500);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(0, 20);
            this.lbl_data.TabIndex = 10;
            this.lbl_data.Visible = false;
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Location = new System.Drawing.Point(265, 28);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(102, 50);
            this.btn_cadastro.TabIndex = 11;
            this.btn_cadastro.Text = "CADASTRAR PACIENTE";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(481, 28);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(102, 50);
            this.btn_excluir.TabIndex = 12;
            this.btn_excluir.Text = "EXCLUIR PACIENTE";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // alterar_cadastro
            // 
            this.alterar_cadastro.Location = new System.Drawing.Point(373, 28);
            this.alterar_cadastro.Name = "alterar_cadastro";
            this.alterar_cadastro.Size = new System.Drawing.Size(102, 50);
            this.alterar_cadastro.TabIndex = 13;
            this.alterar_cadastro.Text = "ALTERAR CADASTRO";
            this.alterar_cadastro.UseVisualStyleBackColor = true;
            this.alterar_cadastro.Click += new System.EventHandler(this.alterar_click);
            // 
            // tbox_filtro
            // 
            this.tbox_filtro.Location = new System.Drawing.Point(12, 64);
            this.tbox_filtro.Name = "tbox_filtro";
            this.tbox_filtro.Size = new System.Drawing.Size(148, 20);
            this.tbox_filtro.TabIndex = 14;
            
            this.tbox_filtro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbox_filtro_KeyUp);
            // 
            // btn_listarsenha
            // 
            this.btn_listarsenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_listarsenha.Location = new System.Drawing.Point(12, 489);
            this.btn_listarsenha.Name = "btn_listarsenha";
            this.btn_listarsenha.Size = new System.Drawing.Size(148, 49);
            this.btn_listarsenha.TabIndex = 16;
            this.btn_listarsenha.Text = "LISTAR TODAS SENHAS";
            this.btn_listarsenha.UseVisualStyleBackColor = true;
            this.btn_listarsenha.Click += new System.EventHandler(this.btn_listarsenha_Click);
            // 
            // btn_listarsenhadia
            // 
            this.btn_listarsenhadia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_listarsenhadia.Location = new System.Drawing.Point(12, 544);
            this.btn_listarsenhadia.Name = "btn_listarsenhadia";
            this.btn_listarsenhadia.Size = new System.Drawing.Size(148, 49);
            this.btn_listarsenhadia.TabIndex = 17;
            this.btn_listarsenhadia.Text = "PROXIMAS SENHAS";
            this.btn_listarsenhadia.UseVisualStyleBackColor = true;
            this.btn_listarsenhadia.Click += new System.EventHandler(this.btn_listarsenhadia_Click);
            // 
            // btn_senhasatendidashoje
            // 
            this.btn_senhasatendidashoje.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_senhasatendidashoje.Location = new System.Drawing.Point(435, 542);
            this.btn_senhasatendidashoje.Name = "btn_senhasatendidashoje";
            this.btn_senhasatendidashoje.Size = new System.Drawing.Size(148, 49);
            this.btn_senhasatendidashoje.TabIndex = 18;
            this.btn_senhasatendidashoje.Text = "SENHAS CHAMADAS HOJE";
            this.btn_senhasatendidashoje.UseVisualStyleBackColor = true;
            this.btn_senhasatendidashoje.Click += new System.EventHandler(this.btn_senhasatendidashoje_Click);
            // 
            // btn_pacientes
            // 
            this.btn_pacientes.Location = new System.Drawing.Point(12, 12);
            this.btn_pacientes.Name = "btn_pacientes";
            this.btn_pacientes.Size = new System.Drawing.Size(148, 49);
            this.btn_pacientes.TabIndex = 18;
            this.btn_pacientes.Text = "LISTAR TODOS PACIENTES";
            this.btn_pacientes.UseVisualStyleBackColor = true;
            this.btn_pacientes.Click += new System.EventHandler(this.btn_carregar_Click);
            // 
            // medico
            // 
            this.medico.Location = new System.Drawing.Point(251, 544);
            this.medico.Name = "medico";
            this.medico.Size = new System.Drawing.Size(102, 50);
            this.medico.TabIndex = 19;
            this.medico.Text = "FORMS MEDICO";
            this.medico.UseVisualStyleBackColor = true;
            this.medico.Click += new System.EventHandler(this.medico_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 612);
            this.Controls.Add(this.medico);
            this.Controls.Add(this.btn_pacientes);
            this.Controls.Add(this.btn_senhasatendidashoje);
            this.Controls.Add(this.btn_listarsenhadia);
            this.Controls.Add(this.btn_listarsenha);
            this.Controls.Add(this.tbox_filtro);
            this.Controls.Add(this.alterar_cadastro);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.btn_teste);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.lbl_total1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.btn_retirar);
            this.Controls.Add(this.btn_senha);
            this.Controls.Add(this.btn_carregar);
            this.Controls.Add(this.dgv_pacientes);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "main";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pacientes;
        private System.Windows.Forms.Button btn_carregar;
        private System.Windows.Forms.Button btn_senha;
        private System.Windows.Forms.Button btn_retirar;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_total1;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_teste;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button alterar_cadastro;
        private System.Windows.Forms.TextBox tbox_filtro;
        private System.Windows.Forms.Button btn_listarsenha;
        private System.Windows.Forms.Button btn_listarsenhadia;
        private System.Windows.Forms.Button btn_senhasatendidashoje;
        private System.Windows.Forms.Button btn_pacientes;
        private System.Windows.Forms.Button medico;
    }
}