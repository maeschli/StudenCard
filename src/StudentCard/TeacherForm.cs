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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
            SqlConnection Connect = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect.Open();
            SqlCommand commData = new SqlCommand("SELECT * from TeacherGroups WHERE Код = '" + Global.usercode + "'", Connect);
            SqlDataReader readData;
            readData = commData.ExecuteReader();

            while (readData.Read())
            {
                userName.Text = readData.GetString(1);
                groupComboBox.Items.Add(readData.GetString(2));

            }
            readData.Close();
            Connect.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lessonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection Connect = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect.Open();
            SqlCommand commData = new SqlCommand("SELECT * from TeacherLessons WHERE Код = '" + Global.usercode + "' AND Група = '" + groupComboBox.SelectedItem + "' AND  Предмет =  '" + lessonComboBox.SelectedItem + "'", Connect);
            SqlDataReader readData;
            readData = commData.ExecuteReader();

            while (readData.Read())
            {
                semestrComboBox.Items.Clear();
                for (int i = 0; i < 11; i++) {
                    if (readData.GetValue(4 + i).ToString() == "1")
                        semestrComboBox.Items.Add("Семестр " + (i + 1) + "");
                }

            }
            readData.Close();
            Connect.Close();
     
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lessonComboBox.Items.Clear();
            SqlConnection Connect2 = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect2.Open();
            SqlCommand commData2 = new SqlCommand("SELECT * from TeacherLessons WHERE Код = '" + Global.usercode + "' AND Група = '" + groupComboBox.SelectedItem + "'", Connect2);
            SqlDataReader readData2;
            readData2 = commData2.ExecuteReader();

            while (readData2.Read())
            {
                lessonComboBox.Items.Add(readData2.GetString(3));
            }
            Connect2.Close();
        }

        private void watchButton_Click(object sender, EventArgs e)
        {
            SqlConnection Connect = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect.Open();
            SqlDataAdapter adaptStData = new SqlDataAdapter("SELECT * from StudentMarks WHERE Група = '" + groupComboBox.SelectedItem + "' AND Семестр = '" + semestrComboBox.SelectedItem + "' AND Предмет = '" + lessonComboBox.SelectedItem + "'", Connect);

            using (adaptStData){
                DataTable t = new DataTable();
                adaptStData.Fill(t);
                
                dataGridView.DataSource = t;
                
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[2].Visible = false;
                dataGridView.Columns[3].Visible = false;
                dataGridView.Columns[4].Visible = false;

            }
            Connect.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
