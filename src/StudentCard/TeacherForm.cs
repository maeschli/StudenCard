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
            SqlConnection Connect1 = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect1.Open();
            SqlCommand commData1 = new SqlCommand("SELECT * from TeacherGroups WHERE Код = '" + Global.usercode + "'", Connect1);
            SqlDataReader readData1;
            readData1 = commData1.ExecuteReader();

            while (readData1.Read())
            {
                userName.Text = readData1.GetString(1);
                groupComboBox.Items.Add(readData1.GetString(2));

            }
            readData1.Close();
            Connect1.Close();

            SqlConnection Connect2 = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect2.Open();
            SqlCommand commData2 = new SqlCommand("SELECT * from TeacherLessons WHERE Код = '" + Global.usercode + "' AND Група = '" + groupComboBox.SelectedText + "'", Connect2);
            SqlDataReader readData2;
            readData2 = commData2.ExecuteReader();

            while (readData2.Read())
            {
                userName.Text = readData2.GetString(1);
                lessonComboBox.Items.Add(readData2.GetString(3));

            }
            Connect2.Close();
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
            SqlConnection Connect2 = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect2.Open();
            SqlCommand commData2 = new SqlCommand("SELECT * from TeacherLessons WHERE Код = '" + Global.usercode + "' AND Група = '" + groupComboBox.SelectedText + "'", Connect2);
            SqlDataReader readData2;
            readData2 = commData2.ExecuteReader();

            while (readData2.Read())
            {
                userName.Text = readData2.GetString(1);
                lessonComboBox.Items.Add(readData2.GetString(3));

            }
            Connect2.Close();
     
        }
    }
}
