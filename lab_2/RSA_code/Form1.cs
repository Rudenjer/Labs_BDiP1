using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RSA_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Text = "";
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                label5.Text = "";
                label4.Text = "Encoding";
                RSA rsa = new RSA();
                richTextBox2.Text = rsa.encode(richTextBox1.Text);
                textBox1.Text = ""+rsa.GetNKey();
                textBox2.Text = ""+rsa.GetDKey();
            }
            else
            {
                label5.Text = "Текст для шифрования не может быть пустым!";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text.Length > 0))
            {
                label5.Text = "Введите первую часть ключа для дешифровки!";
            }
            else if (!(textBox2.Text.Length > 0))
            {
                label5.Text = "Введите вторую часть ключа для дешифровки!";
            }
            else if (richTextBox2.Text.Length > 0)
            {
                label5.Text = "";
                label4.Text = "Decoding";
                RSA rsa = new RSA();
                richTextBox1.Text = rsa.decode(richTextBox2.Text, textBox1.Text, textBox2.Text);
            }
            else
            {
                label5.Text = "Текст для шифрования не может быть пустым!";
            }

        }

    }
}
