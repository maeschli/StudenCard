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
            SqlConnection Connect = new SqlConnection("Data Source=MASHABOROVIK-ПК\\SQLEXPRESS;Initial Catalog=D:\\02_BERUF\\BERUF_GITHUB\\STUDENCARD\\DOC\\STUDENTCARD.MDF;Integrated Security=True");
            Connect.Open();
            SqlCommand commStData = new SqlCommand("SELECT * from StudentMarks WHERE Код = '" + Global.usercode + "'", Connect);
            SqlDataReader readStData;
            readStData = commStData.ExecuteReader();

            while(readStData.Read()){
                userName.Text = readStData.GetString(1);
                comboSemester.Items.Add(readStData.GetString(2));
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
    }
}
