
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.btn_medico = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_recepcao = new System.Windows.Forms.Button();
            this.btn_telao = new System.Windows.Forms.Button();
            this.btn_confi = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btn_medico
            // 
            this.btn_medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medico.ImageIndex = 1;
            this.btn_medico.ImageList = this.imageList1;
            this.btn_medico.Location = new System.Drawing.Point(34, 199);
            this.btn_medico.Name = "btn_medico";
            this.btn_medico.Size = new System.Drawing.Size(245, 120);
            this.btn_medico.TabIndex = 5;
            this.btn_medico.Text = "MÉDICO";
            this.btn_medico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_medico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_medico.UseVisualStyleBackColor = true;
            this.btn_medico.Click += new System.EventHandler(this.btn_medico_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "recepcao.png");
            this.imageList1.Images.SetKeyName(1, "medicos.png");
            this.imageList1.Images.SetKeyName(2, "chamada.png");
            // 
            // btn_recepcao
            // 
            this.btn_recepcao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_recepcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recepcao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_recepcao.ImageIndex = 0;
            this.btn_recepcao.ImageList = this.imageList1;
            this.btn_recepcao.Location = new System.Drawing.Point(34, 57);
            this.btn_recepcao.Name = "btn_recepcao";
            this.btn_recepcao.Size = new System.Drawing.Size(245, 120);
            this.btn_recepcao.TabIndex = 3;
            this.btn_recepcao.Text = "RECEPÇÂO";
            this.btn_recepcao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_recepcao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_recepcao.UseVisualStyleBackColor = true;
            this.btn_recepcao.Click += new System.EventHandler(this.btn_recepcao_Click);
            // 
            // btn_telao
            // 
            this.btn_telao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_telao.ImageIndex = 2;
            this.btn_telao.ImageList = this.imageList1;
            this.btn_telao.Location = new System.Drawing.Point(34, 342);
            this.btn_telao.Name = "btn_telao";
            this.btn_telao.Size = new System.Drawing.Size(245, 120);
            this.btn_telao.TabIndex = 6;
            this.btn_telao.Text = "TELA DE SENHAS";
            this.btn_telao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_telao.UseVisualStyleBackColor = true;
            this.btn_telao.Click += new System.EventHandler(this.btn_telao_Click);
            // 
            // btn_confi
            // 
            this.btn_confi.AutoSize = true;
            this.btn_confi.BackColor = System.Drawing.Color.Transparent;
            this.btn_confi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confi.FlatAppearance.BorderSize = 0;
            this.btn_confi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confi.ForeColor = System.Drawing.Color.Transparent;
            this.btn_confi.ImageKey = "cogwheel.png";
            this.btn_confi.ImageList = this.imageList2;
            this.btn_confi.Location = new System.Drawing.Point(240, 12);
            this.btn_confi.Name = "btn_confi";
            this.btn_confi.Size = new System.Drawing.Size(39, 39);
            this.btn_confi.TabIndex = 7;
            this.btn_confi.UseVisualStyleBackColor = false;
            this.btn_confi.Click += new System.EventHandler(this.btn_confi_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "cogwheel.png");
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(318, 484);
            this.Controls.Add(this.btn_confi);
            this.Controls.Add(this.btn_telao);
            this.Controls.Add(this.btn_medico);
            this.Controls.Add(this.btn_recepcao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SENHASSAUDE";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_medico;
        private System.Windows.Forms.Button btn_recepcao;
        private System.Windows.Forms.Button btn_telao;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_confi;
        private System.Windows.Forms.ImageList imageList2;
    }
}