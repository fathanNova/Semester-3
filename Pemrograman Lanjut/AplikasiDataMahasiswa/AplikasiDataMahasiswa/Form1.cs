using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiDataMahasiswa
{
    public partial class Form1 : Form
    {
        List<Mahasiswa> list = new List<Mahasiswa>();
        public Form1()
        {
            InitializeComponent();
            ListTabel();
        }

        //Reset Button
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ListTabel()
        {
            lvwMahasiswa.View = View.Details;
            lvwMahasiswa.FullRowSelect = true;
            lvwMahasiswa.GridLines = true;

            lvwMahasiswa.Columns.Add("No", 30, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("NIM", 80, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nama", 150, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Kelas", 60, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nilai", 70, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("Nilai Huruf", 70, HorizontalAlignment.Center);
        }

        private void txtNilai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Mahasiswa mhs = new Mahasiswa();

            mhs.Nim = txtNim.Text;
            mhs.Nama = txtNama.Text;
            mhs.Kelas = txtKelas.Text;
            mhs.Nilai = int.Parse(txtNilai.Text);
            if (mhs.Nilai > 80)
            {
                mhs.NilaiHuruf = "A";
            }
            else if (mhs.Nilai > 60)
            {
                mhs.NilaiHuruf = "B";
            }
            else if (mhs.Nilai > 40)
            {
                mhs.NilaiHuruf = "C";
            }
            else if (mhs.Nilai > 20 && mhs.Nilai <= 40)
            {
                mhs.NilaiHuruf = "D";
            }
            else
            {
                mhs.NilaiHuruf = "E";
            }

            list.Add(mhs);
            MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Reset();

        }

        private void Reset()
        {
            txtNim.Clear();
            txtNama.Clear();
            txtKelas.Clear();
            txtNilai.Text = "";
        }

        private void btnTampilkanData_Click(object sender, EventArgs e)
        {
            lvwMahasiswa.Items.Clear();
            int number = 1;

            foreach (var mhs in list)
            {
                ListViewItem item = new ListViewItem(number.ToString());
                item.SubItems.Add(mhs.Nim);
                item.SubItems.Add(mhs.Nama);
                item.SubItems.Add(mhs.Kelas);
                item.SubItems.Add(mhs.Nilai.ToString());
                item.SubItems.Add(mhs.NilaiHuruf);

                lvwMahasiswa.Items.Add(item);
                number++;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(lvwMahasiswa.SelectedItems.Count > 0)
            {
                int index = lvwMahasiswa.SelectedIndices[0];
                list.RemoveAt(index);
                lvwMahasiswa.Items.RemoveAt(index);
                MessageBox.Show("Data Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    
}
