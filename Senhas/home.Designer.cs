
namespace Senhas
{
    partial class home
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
            this.btn_medico = new System.Windows.Forms.Button();
            this.btn_recepcao = new System.Windows.Forms.Button();
            this.btn_telao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_medico
            // 
            this.btn_medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medico.Location = new System.Drawing.Point(305, 173);
            this.btn_medico.Name = "btn_medico";
            this.btn_medico.Size = new System.Drawing.Size(184, 105);
            this.btn_medico.TabIndex = 5;
            this.btn_medico.Text = "MÉDICO";
            this.btn_medico.UseVisualStyleBackColor = true;
            this.btn_medico.Click += new System.EventHandler(this.btn_medico_Click);
            // 
            // btn_recepcao
            // 
            this.btn_recepcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recepcao.Location = new System.Drawing.Point(97, 173);
            this.btn_recepcao.Name = "btn_recepcao";
            this.btn_recepcao.Size = new System.Drawing.Size(184, 105);
            this.btn_recepcao.TabIndex = 3;
            this.btn_recepcao.Text = "RECEPÇÂO";
            this.btn_recepcao.UseVisualStyleBackColor = true;
            this.btn_recepcao.Click += new System.EventHandler(this.btn_recepcao_Click);
            // 
            // btn_telao
            // 
            this.btn_telao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_telao.Location = new System.Drawing.Point(517, 173);
            this.btn_telao.Name = "btn_telao";
            this.btn_telao.Size = new System.Drawing.Size(184, 105);
            this.btn_telao.TabIndex = 6;
            this.btn_telao.Text = "TELA DE CHAMADAS";
            this.btn_telao.UseVisualStyleBackColor = true;
            this.btn_telao.Click += new System.EventHandler(this.btn_telao_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 494);
            this.Controls.Add(this.btn_telao);
            this.Controls.Add(this.btn_medico);
            this.Controls.Add(this.btn_recepcao);
            this.Name = "home";
            this.Text = "home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_medico;
        private System.Windows.Forms.Button btn_recepcao;
        private System.Windows.Forms.Button btn_telao;
    }
}