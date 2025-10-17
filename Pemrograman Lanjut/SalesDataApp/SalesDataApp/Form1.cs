using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesDataApp
{
    public partial class DataPenjualan : Form
    {
        public DataPenjualan()
        {
            InitializeComponent();
        }

        // Tombol Hitung untuk menghitung sub total dari masing-masing item
        private void btnHitung_Click(object sender, EventArgs e)
        {
            int harga = Convert.ToInt32(txtHarga.Text);
            int harga2 = Convert.ToInt32(txtHarga2.Text);
            int harga3 = Convert.ToInt32(txtHarga3.Text);
            int harga4 = Convert.ToInt32(txtHarga4.Text);
            int harga5 = Convert.ToInt32(txtHarga5.Text);
            int jumlah = Convert.ToInt16(nudJumlah.Text);
            int jumlah2 = Convert.ToInt16(nudJumlah2.Text);
            int jumlah3 = Convert.ToInt16(nudJumlah3.Text);
            int jumlah4 = Convert.ToInt16(nudJumlah4.Text);
            int jumlah5 = Convert.ToInt16(nudJumlah5.Text);

            txtSub.Text = ("Rp." + (harga * jumlah).ToString("N0"));
            txtSub2.Text = ("Rp." + (harga2 * jumlah2).ToString("N0"));
            txtSub3.Text = ("Rp." + (harga3 * jumlah3).ToString("N0"));
            txtSub4.Text = ("Rp." + (harga4 * jumlah4).ToString("N0"));
            txtSub5.Text = ("Rp." + (harga5 * jumlah5).ToString("N0"));
        }

        // Tombol Simpan untuk menghitung total dari semua sub total
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int total = GetSub(txtSub) + GetSub(txtSub2) + GetSub(txtSub3) + GetSub(txtSub4) + GetSub(txtSub5);
            txtTotal.Text = "Rp." + total.ToString("N0");
        }

        // Fungsi untuk mengonversi nilai sub total dari TextBox ke integer dan menghapus format mata uang
        private int GetSub(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
                return 0;

            string hapus = txt.Text.Replace("Rp.", "").Replace(".", "");
            return int.TryParse(hapus, out int convert) ? convert : 0;

        }
    }
}
