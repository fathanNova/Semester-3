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
        ComboBox[] comboBoxes;
        NumericUpDown[] nudJumlahBarang;
        TextBox[] boxHarga;
        TextBox[] boxSub;
        public DataPenjualan()
        {
            InitializeComponent();
            comboBoxes = new ComboBox[] { cmbJenisBarang, cmbJenisBarang2, cmbJenisBarang3, cmbJenisBarang4, cmbJenisBarang5 };
            nudJumlahBarang = new NumericUpDown[]  { nudJumlah, nudJumlah2, nudJumlah3, nudJumlah4, nudJumlah5 };
            boxHarga = new TextBox[] { txtHarga, txtHarga2, txtHarga3, txtHarga4, txtHarga5 };
            boxSub = new TextBox[] { txtSub, txtSub2, txtSub3, txtSub4, txtSub5 };
        }

        // Tombol Hitung untuk menghitung sub total dari masing-masing item
        private void btnHitung_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nudJumlahBarang.Length; i++)
            {
                int harga = Convert.ToInt32(boxHarga[i].Text);
                int jumlah = Convert.ToInt16(nudJumlahBarang[i].Value);
                boxSub[i].Text = "Rp." + (harga * jumlah).ToString("N0");
            }
        }

        // Tombol Simpan untuk menghitung total dari semua sub total
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int total = 0;

            for (int i = 0; i < boxSub.Length; i++)
            {
                total += GetSub(boxSub[i]);   
            }

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

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpTanggal.Value = DateTime.Now;

            txtName.Clear();

            txtNoHP.Clear();

            foreach (ComboBox cmb in comboBoxes)
            {
                cmb.Text = "Pilih Salah Satu";
            }

            foreach (NumericUpDown nud in nudJumlahBarang)
            {
                nud.Value = 0;
            }

            foreach (TextBox box in boxHarga)
            {
                box.Clear();
            }

            foreach (TextBox box in boxSub)
            {
                box.Clear();
            }

            txtTotal.Clear();

            
        }
    }
}
