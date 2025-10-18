using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLatihan3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pendidikan = cmbPendidikan.Text;
            var pekerjaan = lstPekerjaan.SelectedItem;

            txtPesan.Text = "Halo " + nama;
            txtPesan2.Text = "Pendidikan Anda " + pendidikan + " ya?";
            txtPesan3.Text = "Anda Seorang " + pekerjaan + ", Hebat !!!";
        }
    }
}
