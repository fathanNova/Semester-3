using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorMachine;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numA = Convert.ToDouble(textBox1.Text);
            double numB = Convert.ToDouble(textBox2.Text);

            Calculator calc = new Calculator();

            lstHasil.Items.Clear();

            // Menampilkan semua hasil operasi
            /*lstHasil.Items.Add(string.Format("Hasil Penambahan: {0} + {1} = {2} ", numA, numB, calc.Penambahan(numA, numB) + "\n"));
            lstHasil.Items.Add(string.Format("Hasil Pengurangan: {0} - {1} = {2} ", numA, numB, calc.Pengurangan(numA, numB) + "\n"));
            lstHasil.Items.Add(string.Format("Hasil Perkalian: {0} x {1} = {2} ", numA, numB, calc.Perkalian(numA, numB) + "\n"));
            lstHasil.Items.Add(string.Format("Hasil Pembagian: {0} + {1} = {2} ", numA, numB, calc.Pembagian(numA, numB) + "\n"));*/

            // Menampilkan hasil berdasarkan metode yang dipilih
            string metode = comboBox1.Text;

             double hasil = 0;

             if (metode == "Penambahan")
             {
                 hasil = calc.Penambahan(numA, numB);
             }
             else if (metode == "Pengurangan")
             {
                 hasil = calc.Pengurangan(numA, numB);
             }
             else if (metode == "Perkalian")
             {
                 hasil = calc.Perkalian(numA, numB);
             }
             else if (metode == "Pembagian")
             {
                 hasil = calc.Pembagian(numA, numB);
             }
             else
             {
                 MessageBox.Show("Silahkan Pilih Metode Terlebih Dahulu.");
             }

                 //lstHasil.Items.Add("Hasil: " + hasil + "\n");
                 textBox3.Text = hasil.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstHasil.Items.Clear();
            textBox3.Clear();
        }

        
    }
}
