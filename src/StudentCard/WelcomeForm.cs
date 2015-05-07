using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCard
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();

            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Text = "Введіть свій логін...";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);

            textBox2.ForeColor = SystemColors.GrayText;
            textBox2.Text = "Введіть свій пароль...";
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "Введіть свій логін...";
                textBox1.ForeColor = SystemColors.GrayText;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.PasswordChar = '\0';
                textBox2.Text = "Введіть свій пароль...";
                textBox2.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введіть свій логін...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введіть свій пароль...")
            {
                textBox2.Text = "";
                textBox2.ForeColor = SystemColors.WindowText;
                textBox2.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
