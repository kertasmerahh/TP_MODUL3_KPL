using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MODUL3_103022400036
{
    public partial class Form1 : Form
    {
        int nilaiPertama = 0;
        string op = "";
        bool isLagiInput = false;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TombolAngka_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (textBox1.Text == "0" || baruKlikOperator)
            {
                textBox1.Text = b.Text;
                baruKlikOperator = false;
            }
            else
            {
                textBox1.Text += b.Text;
            }
        }

        private void Plus_click(object sender, EventArgs e)
        {
            nilaiPertama = int.Parse(textBox1.Text);
            op = "+";
            baruKlikOperator = true;
        }

        private void equals_click(object sender, EventArgs e)
        {
            int nilaiKedua = int.Parse(textBox1.Text);
            int hasil = 0;

            if (op == "+")
            {
                hasil = nilaiPertama + nilaiKedua;
            }

            textBox1.Text = hasil.ToString(); 
            baruKlikOperator = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
