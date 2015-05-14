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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            SqlConnection Connect = new SqlConnection("Data Source=TATIANA;Initial Catalog=StudentCard;Integrated Security=True");
            Connect.Open();
            SqlCommand commStData = new SqlCommand("SELECT * from StudentSemesters WHERE Код = '" + Global.usercode + "'", Connect);
            SqlDataReader readStData;
            readStData = commStData.ExecuteReader();

            while(readStData.Read()){
                userName.Text = "" + readStData.GetString(1) + ", група " + readStData.GetString(2) + "";
                
                for (int i = 0; i < 11; i++) {
                    if (readStData.GetValue(3 + i).ToString() == "1")
                        comboSemester.Items.Add("Семестр "+(i+1)+"");
                }
            }
            Connect.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void watchData_Click(object sender, EventArgs e)
        {
            SqlConnection Connect = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect.Open();
            SqlDataAdapter adaptStData = new SqlDataAdapter("SELECT * from StudentMarks WHERE Код = '" + Global.usercode + "' AND Семестр = '" + comboSemester.Text + "'", Connect);

            using (adaptStData){
                DataTable t = new DataTable();
                adaptStData.Fill(t);

                dataGridView.ReadOnly = true;
                dataGridView.AllowUserToResizeRows = false;
                dataGridView.AllowUserToOrderColumns = false;
                dataGridView.AutoSize = true;
                
                dataGridView.DataSource = t;
                
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].Visible = false;
                dataGridView.Columns[2].Visible = false;
                dataGridView.Columns[3].Visible = false;

            }
            Connect.Close();
        }

        private void userName_Click(object sender, EventArgs e)
        {

        }
    }
}
