using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class frmTugasTigaSatu : Form
    {
        public frmTugasTigaSatu()
        {
            InitializeComponent();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            lblNim.Text = "NIM    : 24.11.6064";
            lblNama.Text = "Nama : FATHAN NOVA ARROYAN";
            lblKelas.Text = "Kelas  : S1-IF03";
        }

        private void btnKosongkan_Click(object sender, EventArgs e)
        {
            lblNim.Text = "NIM    : ";
            lblNama.Text = "Nama : ";
            lblKelas.Text = "Kelas  : ";
        }
    }
}
