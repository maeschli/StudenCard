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
    public partial class ChairForm : Form
    {
        public ChairForm()
        {
            InitializeComponent();
            studComboBox.Items.Clear();
            SqlConnection Connect = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect.Open();
            SqlCommand commData = new SqlCommand("SELECT * from TeacherGroups WHERE Код = '" + Global.usercode + "'", Connect);
            SqlDataReader readData;
            readData = commData.ExecuteReader();

            while (readData.Read())
            {
                userName.Text = readData.GetValue(1).ToString();
                groupComboBox.Items.Add("" + readData.GetValue(2) + "");
            }
            readData.Close();
            Connect.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            studComboBox.Items.Clear();
            SqlConnection Connect = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect.Open();
            SqlCommand commData = new SqlCommand("SELECT * from StudentInfo WHERE Група = '" + groupComboBox.SelectedItem + "'", Connect);
            SqlDataReader readData;
            readData = commData.ExecuteReader();

            while (readData.Read())
            {
                studComboBox.Items.Add("" + readData.GetValue(2) + "");
            }

            readData.Close();
            Connect.Close();
        }

        private void studComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection Connect = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect.Open();
            SqlCommand commData = new SqlCommand("SELECT * from StudentSemesters WHERE ПІБ = '" + studComboBox.SelectedItem + "'", Connect);
            SqlDataReader readData;
            readData = commData.ExecuteReader();

            while (readData.Read())
            {
                semestrComboBox.Items.Clear();
                Global.studentcode = readData.GetInt32(0);

                for (int i = 0; i < 11; i++)
                {
                    if (readData.GetValue(3 + i).ToString() == "1")
                        semestrComboBox.Items.Add("Семестр " + (i + 1) + "");
                }
            }

            readData.Close();
            Connect.Close();
        }

        private void watchInfo_Click(object sender, EventArgs e)
        {
            StudentInfo form = new StudentInfo();
            form.Show();
        }

        private void watchMarks_Click(object sender, EventArgs e)
        {
            SqlConnection Connect = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect.Open();
            SqlDataAdapter adaptStData = new SqlDataAdapter("SELECT * from StudentMarks WHERE Група = '" + groupComboBox.SelectedItem + "' AND ПІБ = '" + studComboBox.SelectedItem + "' AND Семестр = '" + semestrComboBox.SelectedItem + "'", Connect);

            using (adaptStData)
            {
                DataTable t = new DataTable();
                adaptStData.Fill(t);

                dataGridView.AutoSize = true;

                dataGridView.DataSource = t;

                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].Visible = false;
                dataGridView.Columns[2].Visible = false;
                dataGridView.Columns[3].Visible = false;
            }
            Connect.Close();
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            SqlConnection Connect = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect.Open();
            SqlDataAdapter adaptStData = new SqlDataAdapter("SELECT * from StudentMarks WHERE Група = '" + groupComboBox.SelectedItem + "' AND ПІБ = '" + studComboBox.SelectedItem + "' AND Семестр = '" + semestrComboBox.SelectedItem + "'", Connect);

            using (adaptStData)
            {
                SqlConnection Conn = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
                Conn.Open();
                SqlDataAdapter adStData = new SqlDataAdapter("SELECT * from StudentMarks WHERE Група = '" + groupComboBox.SelectedItem + "' AND ПІБ = '" + studComboBox.SelectedItem + "' AND Семестр = '" + semestrComboBox.SelectedItem + "'", Conn);
                
                /*DataTable t = new DataTable();
                adaptStData.Fill(t);

                dataGridView.AutoSize = true;

                dataGridView.DataSource = t;

                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].Visible = false;
                dataGridView.Columns[2].Visible = false;
                dataGridView.Columns[3].Visible = false;*/

                Conn.Close();
            }
            Connect.Close();
        }
    }
}
