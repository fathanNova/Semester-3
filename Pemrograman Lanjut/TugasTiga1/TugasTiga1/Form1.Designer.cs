namespace TugasTiga1
{
    partial class frmTugasTigaSatu
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
            this.lblNim = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnKosongkan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNim
            // 
            this.lblNim.AutoSize = true;
            this.lblNim.Location = new System.Drawing.Point(24, 19);
            this.lblNim.Name = "lblNim";
            this.lblNim.Size = new System.Drawing.Size(99, 13);
            this.lblNim.TabIndex = 0;
            this.lblNim.Text = "NIM    : 24.11.6064";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(24, 53);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(176, 13);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama : FATHAN NOVA ARROYAN";
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Location = new System.Drawing.Point(24, 84);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(82, 13);
            this.lblKelas.TabIndex = 2;
            this.lblKelas.Text = "Kelas  : S1-IF03";
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.Location = new System.Drawing.Point(44, 113);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(75, 23);
            this.btnTampilkan.TabIndex = 3;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = true;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnKosongkan
            // 
            this.btnKosongkan.Location = new System.Drawing.Point(125, 113);
            this.btnKosongkan.Name = "btnKosongkan";
            this.btnKosongkan.Size = new System.Drawing.Size(75, 23);
            this.btnKosongkan.TabIndex = 4;
            this.btnKosongkan.Text = "Kosongkan";
            this.btnKosongkan.UseVisualStyleBackColor = true;
            this.btnKosongkan.Click += new System.EventHandler(this.btnKosongkan_Click);
            // 
            // frmTugasTigaSatu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 153);
            this.Controls.Add(this.btnKosongkan);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNim);
            this.Name = "frmTugasTigaSatu";
            this.Text = "Tugas 3.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNim;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnKosongkan;
    }
}

