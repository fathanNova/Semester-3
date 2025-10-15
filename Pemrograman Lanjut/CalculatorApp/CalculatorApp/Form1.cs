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

            string metode = comboBox1.Text;

            double hasil = 0;

            richTextBox1.Clear();
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

                richTextBox1.AppendText($"Hasil: " + hasil + "\n");
            
            /*richTextBox1.AppendText("Penambahan: " + calc.Penambahan(numA, numB) + "\n");
            richTextBox1.AppendText("Pengurangan: " + calc.Pengurangan(numA, numB) + "\n");
            richTextBox1.AppendText("Perkalian: " + calc.Perkalian(numA, numB) + "\n");
            richTextBox1.AppendText("Pembagian: " + calc.Pembagian(numA, numB) + "\n");*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

       
    }
}
