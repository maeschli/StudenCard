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
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
            SqlConnection Connect = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect.Open();
            SqlCommand comm = new SqlCommand("SELECT * from SingIn WHERE Код = '" + Global.usercode + "'", Connect);
            SqlDataReader readData;
            readData = comm.ExecuteReader();

            string role;
            while (readData.Read())
            {
                role = readData.GetString(2);

                if (role == "Студент")
                {
                    saveButton.Hide();
                    Student("SELECT * from StudentInfo WHERE Код = '" + Global.usercode + "'");
                }
                else if (role == "Деканат")
                {
                    saveButton.Hide();
                    Student("SELECT * from StudentInfo WHERE Код = '" + Global.studentcode + "'");
                }
                else if (role == "Кафедра")
                {
                    Student("SELECT * from StudentInfo WHERE Код = '" + Global.studentcode + "'");
                }
            }

            Connect.Close();
        }

        private void Student(string command)
        {
            SqlConnection Connect = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect.Open();
            SqlCommand comm = new SqlCommand(command, Connect);
            SqlDataReader readData;
            readData = comm.ExecuteReader();

            while (readData.Read())
            {
                nameTextBox.Text = "" + readData.GetValue(2) + "";
                //enterDatePicker.Text = "" + readData.GetValue(4) + "";
                enterDatePicker.Text = ""+ readData.GetValue(4)+"";
                leaveDatePicker.Text = ""+ readData.GetValue(5) + "";
                birthDatePicker.Text = "" + readData.GetValue(3) + "";
                directTextBox.Text = "" + readData.GetValue(6) + "";
                specTextBox.Text = "" + readData.GetValue(7) + "";
                groupTextBox.Text = "" + readData.GetValue(1) + "";
                levelTextBox.Text = "" + readData.GetValue(8) + "";
                formTextBox.Text = "" + readData.GetValue(9) + "";
            }

            Connect.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Connect = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
                Connect.Open();
                SqlCommand comm = new SqlCommand("UPDATE StudentInfo SET Група = @group, ПІБ = @name," +
                   "[Дата народження] = @birth, [Рік зарахування] = @enter, [Рік випуску] = @leave," +
                   "[Напрям підготовки] = @direct, Спеціальність = @spec, [Форма навчання] = @form," +
                   "[Осв-кв рівень] = @level WHERE Код = '" + Global.studentcode + "'", Connect);
                comm.Parameters.Add("@group", SqlDbType.VarChar).Value = groupTextBox.Text;
                comm.Parameters.AddWithValue("@name", SqlDbType.VarChar).Value = nameTextBox.Text;
                comm.Parameters.AddWithValue("@direct", SqlDbType.VarChar).Value = directTextBox.Text;
                comm.Parameters.AddWithValue("@spec", SqlDbType.VarChar).Value = specTextBox.Text;
                comm.Parameters.AddWithValue("@form", SqlDbType.VarChar).Value = formTextBox.Text;
                comm.Parameters.AddWithValue("@level", SqlDbType.VarChar).Value = levelTextBox.Text;
                comm.Parameters.AddWithValue("@birth", SqlDbType.DateTime).Value = birthDatePicker.Text;
                comm.Parameters.AddWithValue("@enter", SqlDbType.DateTime).Value = enterDatePicker.Text;
                comm.Parameters.AddWithValue("@leave", SqlDbType.DateTime).Value = leaveDatePicker.Text;
                comm.ExecuteNonQuery();
                Connect.Close();
                MessageBox.Show("Зміни успішно збережені!");
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }
            

        }
    }
}
