using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
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

            loginTextBox.ForeColor = SystemColors.GrayText;
            loginTextBox.Text = "Введіть свій логін...";
            this.loginTextBox.Leave += new System.EventHandler(this.textBox1_Leave);
            this.loginTextBox.Enter += new System.EventHandler(this.textBox1_Enter);

            passwordTextBox.ForeColor = SystemColors.GrayText;
            passwordTextBox.Text = "Введіть свій пароль...";
            this.passwordTextBox.Leave += new System.EventHandler(this.textBox2_Leave);
            this.passwordTextBox.Enter += new System.EventHandler(this.textBox2_Enter);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Length == 0)
            {
                loginTextBox.Text = "Введіть свій логін...";
                loginTextBox.ForeColor = SystemColors.GrayText;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Length == 0)
            {
                passwordTextBox.PasswordChar = '\0';
                passwordTextBox.Text = "Введіть свій пароль...";
                passwordTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "Введіть свій логін...")
            {
                loginTextBox.Text = "";
                loginTextBox.ForeColor = SystemColors.WindowText;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Введіть свій пароль...")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = SystemColors.WindowText;
                passwordTextBox.PasswordChar = '*';
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            SqlConnection Connect = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect.Open();
            SqlCommand commLoginPass = new SqlCommand("SELECT * from SingIn WHERE Login = '" + loginTextBox.Text + "' AND Password = '" + passwordTextBox.Text + "' AND Ролі = '" + userComboBox.Text + "'", Connect);
            SqlDataReader readLoginPass;
            readLoginPass = commLoginPass.ExecuteReader();

            int count = 0;
            while (readLoginPass.Read()) {
                count += 1;
                Global.usercode = readLoginPass.GetInt32(0);
            }

                if (count != 0)
                {
                    if (userComboBox.Text == "Студент")
                    {
                        StudentForm form = new StudentForm();
                        form.Show();
                        this.Hide();
                    }
                    else if (userComboBox.Text == "Викладач")
                    {
                        TeacherForm form = new TeacherForm();
                        form.Show();
                        this.Hide();
                    }
                    else if (userComboBox.Text == "Кафедра")
                    {
                        ChairForm form = new ChairForm();
                        form.Show();
                        this.Hide();
                    }
                    else if (userComboBox.Text == "Деканат")
                    {
                        DeanForm form = new DeanForm();
                        form.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Ви ввели неправильне ім'я користувача чи пароль!\nПеревірте також, будь ласка, свою роль та чи не натиснута часом клавіша 'Caps Lock'.\n\nВведіть свої дані ще раз!");
                    loginTextBox.Clear();
                    passwordTextBox.Clear();

                }

            Connect.Close();
            
        }
    }
}
