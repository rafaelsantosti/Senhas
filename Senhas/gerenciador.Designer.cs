
namespace Senhas
{
    partial class gerenciador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_pacientes = new System.Windows.Forms.DataGridView();
            this.tbox_filtro = new System.Windows.Forms.TextBox();
            this.combo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pacientes
            // 
            this.dgv_pacientes.AllowUserToAddRows = false;
            this.dgv_pacientes.AllowUserToDeleteRows = false;
            this.dgv_pacientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_pacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pacientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_pacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_pacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pacientes.EnableHeadersVisualStyles = false;
            this.dgv_pacientes.GridColor = System.Drawing.Color.SandyBrown;
            this.dgv_pacientes.Location = new System.Drawing.Point(12, 95);
            this.dgv_pacientes.MultiSelect = false;
            this.dgv_pacientes.Name = "dgv_pacientes";
            this.dgv_pacientes.ReadOnly = true;
            this.dgv_pacientes.RowHeadersVisible = false;
            this.dgv_pacientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_pacientes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pacientes.RowTemplate.Height = 50;
            this.dgv_pacientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pacientes.Size = new System.Drawing.Size(1157, 595);
            this.dgv_pacientes.TabIndex = 1;
            // 
            // tbox_filtro
            // 
            this.tbox_filtro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbox_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_filtro.Location = new System.Drawing.Point(12, 46);
            this.tbox_filtro.Name = "tbox_filtro";
            this.tbox_filtro.Size = new System.Drawing.Size(254, 26);
            this.tbox_filtro.TabIndex = 23;
            this.tbox_filtro.Text = "Digite sua pesquisa aqui";
            this.tbox_filtro.Click += new System.EventHandler(this.tbox_filtro_Click);
            this.tbox_filtro.TextChanged += new System.EventHandler(this.tbox_filtro_TextChanged);
            this.tbox_filtro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbox_filtro_KeyUp);
            // 
            // combo
            // 
            this.combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo.FormattingEnabled = true;
            this.combo.Items.AddRange(new object[] {
            "PESQUISAR",
            "TODAS SENHAS",
            "PROXIMAS SENHAS",
            "SENHAS CHAMADAS HOJE",
            "TODAS SENHAS CHAMADAS"});
            this.combo.Location = new System.Drawing.Point(12, 14);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(254, 26);
            this.combo.TabIndex = 24;
            this.combo.Text = "PESQUISAR";
            this.combo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            // 
            // gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 699);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.tbox_filtro);
            this.Controls.Add(this.dgv_pacientes);
            this.Name = "gerenciador";
            this.Text = "gerenciador";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.gerenciador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pacientes;
        private System.Windows.Forms.TextBox tbox_filtro;
        private System.Windows.Forms.ComboBox combo;
    }
}