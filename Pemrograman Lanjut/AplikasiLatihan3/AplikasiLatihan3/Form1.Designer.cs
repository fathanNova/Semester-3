namespace AplikasiLatihan3
{
    partial class Form1
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
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPesan3 = new System.Windows.Forms.TextBox();
            this.txtPesan = new System.Windows.Forms.TextBox();
            this.txtPesan2 = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbPendidikan = new System.Windows.Forms.ComboBox();
            this.lstPekerjaan = new System.Windows.Forms.ListBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblPendidikan = new System.Windows.Forms.Label();
            this.lblPekerjaan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(99, 274);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtPesan3
            // 
            this.txtPesan3.Location = new System.Drawing.Point(16, 248);
            this.txtPesan3.Name = "txtPesan3";
            this.txtPesan3.ReadOnly = true;
            this.txtPesan3.Size = new System.Drawing.Size(246, 20);
            this.txtPesan3.TabIndex = 1;
            // 
            // txtPesan
            // 
            this.txtPesan.Location = new System.Drawing.Point(16, 196);
            this.txtPesan.Name = "txtPesan";
            this.txtPesan.ReadOnly = true;
            this.txtPesan.Size = new System.Drawing.Size(246, 20);
            this.txtPesan.TabIndex = 2;
            // 
            // txtPesan2
            // 
            this.txtPesan2.Location = new System.Drawing.Point(16, 222);
            this.txtPesan2.Name = "txtPesan2";
            this.txtPesan2.ReadOnly = true;
            this.txtPesan2.Size = new System.Drawing.Size(246, 20);
            this.txtPesan2.TabIndex = 3;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(88, 16);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(173, 20);
            this.txtNama.TabIndex = 4;
            // 
            // cmbPendidikan
            // 
            this.cmbPendidikan.FormattingEnabled = true;
            this.cmbPendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "Diploma",
            "Sarjana",
            "Pascasarjana"});
            this.cmbPendidikan.Location = new System.Drawing.Point(88, 45);
            this.cmbPendidikan.Name = "cmbPendidikan";
            this.cmbPendidikan.Size = new System.Drawing.Size(173, 21);
            this.cmbPendidikan.TabIndex = 5;
            // 
            // lstPekerjaan
            // 
            this.lstPekerjaan.FormattingEnabled = true;
            this.lstPekerjaan.Items.AddRange(new object[] {
            "ABRI",
            "Dosen",
            "Pedagang",
            "Pegawai",
            "Pengusaha",
            "PNS",
            ""});
            this.lstPekerjaan.Location = new System.Drawing.Point(88, 81);
            this.lstPekerjaan.Name = "lstPekerjaan";
            this.lstPekerjaan.Size = new System.Drawing.Size(173, 95);
            this.lstPekerjaan.TabIndex = 6;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(12, 19);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(35, 13);
            this.lblNama.TabIndex = 7;
            this.lblNama.Text = "Nama";
            // 
            // lblPendidikan
            // 
            this.lblPendidikan.AutoSize = true;
            this.lblPendidikan.Location = new System.Drawing.Point(12, 48);
            this.lblPendidikan.Name = "lblPendidikan";
            this.lblPendidikan.Size = new System.Drawing.Size(60, 13);
            this.lblPendidikan.TabIndex = 8;
            this.lblPendidikan.Text = "Pendidikan";
            // 
            // lblPekerjaan
            // 
            this.lblPekerjaan.AutoSize = true;
            this.lblPekerjaan.Location = new System.Drawing.Point(12, 81);
            this.lblPekerjaan.Name = "lblPekerjaan";
            this.lblPekerjaan.Size = new System.Drawing.Size(55, 13);
            this.lblPekerjaan.TabIndex = 9;
            this.lblPekerjaan.Text = "Pekerjaan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 310);
            this.Controls.Add(this.lblPekerjaan);
            this.Controls.Add(this.lblPendidikan);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lstPekerjaan);
            this.Controls.Add(this.cmbPendidikan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtPesan2);
            this.Controls.Add(this.txtPesan);
            this.Controls.Add(this.txtPesan3);
            this.Controls.Add(this.btnOk);
            this.Name = "Form1";
            this.Text = "Latihan 3.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtPesan3;
        private System.Windows.Forms.TextBox txtPesan;
        private System.Windows.Forms.TextBox txtPesan2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbPendidikan;
        private System.Windows.Forms.ListBox lstPekerjaan;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblPendidikan;
        private System.Windows.Forms.Label lblPekerjaan;
    }
}

