using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using SignUpProject.Models;

namespace SignUpProject
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        public Form2()
        {
            InitializeComponent();
        }

        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code,
            // you can retrieve it from a configuration file.
            return "Data Source=Justin;Initial Catalog=SignUp;"
                + "Integrated Security=true;";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Db_dtl_timepicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Db_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Db_Name.Text = dataGridView1.Rows[e.RowIndex].Cells["emerDataGridViewTextBoxColumn"].Value.ToString();
            Db_Email_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
            Db_Phone.Text = dataGridView1.Rows[e.RowIndex].Cells["telDataGridViewTextBoxColumn"].Value.ToString();
            Db_Pass_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells["passDataGridViewTextBoxColumn"].Value.ToString();
            Db_Origin.Text = dataGridView1.Rows[e.RowIndex].Cells["vndlDataGridViewTextBoxColumn"].Value.ToString();
            Db_dtl_timepicker.Text = dataGridView1.Rows[e.RowIndex].Cells["dtlDataGridViewTextBoxColumn"].Value.ToString();
            Db_Id_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells["IdDataGridViewTextBoxColumn"].Value.ToString();
        }
        private void LoadData()
        {
            this.studentInfoTableAdapter.Fill(this.signUpDataSet.StudentInfo);
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
        private String ValidateStudent(Student student)
        {
            if (String.IsNullOrEmpty(student.Pass))
                return "Password-i eshte fushe e detyrueshme!";

            else if (String.IsNullOrEmpty(student.Phone))
                return "Numri i telefonit eshte i detyrueshem!";

            else if (String.IsNullOrEmpty(student.Name))
                return "Emri eshte fushe e detyrueshme!";

            else if (String.IsNullOrEmpty(student.Email))
                return "Email-i eshte fushe e detyrueshme!";

            return null;
        }

        private bool IsUniqueEmail(string email)
        {
            con = new SqlConnection();
            con.ConnectionString = GetConnectionString();
            con.Open();
            SqlCommand command = new SqlCommand("Select Email from [StudentInfo] where lower(email)=@email", con);
            command.Parameters.AddWithValue("@email", email.ToLower());
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                    return false;
                else return true;
            }
            con.Close();
        }

        private bool IsUniquePhone(string phone)
        {
            con = new SqlConnection();
            con.ConnectionString = GetConnectionString();
            con.Open();
            SqlCommand command = new SqlCommand("Select Tel from [StudentInfo] where tel=@tel", con);
            command.Parameters.AddWithValue("@tel", phone);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                    return false;
                else return true;
            }
            con.Close();
        }
        private void UpdateStudent(Student student)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand updatecmd = new SqlCommand();
            con.ConnectionString = "Data Source=Justin;Initial Catalog=SignUp;Integrated Security=True";
            if (student.Name != "" && student.Name != "")
            {
                updatecmd = new SqlCommand("update StudentInfo set Emer=@emer, Vndl=@vndl, Dtl=@dtl, Email=@email, Pass=@pass, Tel=@tel where ID=@id", con);
                con.Open();
                updatecmd.Parameters.AddWithValue("@id", student.Id);
                updatecmd.Parameters.AddWithValue("@emer", student.Name);
                updatecmd.Parameters.AddWithValue("@dtl", student.Birthday);
                updatecmd.Parameters.AddWithValue("@email", student.Email);
                updatecmd.Parameters.AddWithValue("@pass", student.Pass);
                updatecmd.Parameters.AddWithValue("@tel", student.Phone);
                updatecmd.Parameters.AddWithValue("@vndl", student.Origin);
                updatecmd.ExecuteNonQuery();

                con.Close();
                LoadData();
                MessageBox.Show("Te dhenat u ruajten me sukses");
            }
            else
            {
                MessageBox.Show("Selektoni nje te rekord!");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            
            Student student = new Student()
            {
                Pass = Db_Pass_textbox.Text,
                Birthday = Db_dtl_timepicker.Text,
                Email = Db_Email_textbox.Text,
                Origin = Db_Origin.Text,
                Phone = Db_Phone.Text,
                Name = Db_Name.Text,
                Id = int.Parse(Db_Id_textbox.Text)
            };
            var errorMessage = ValidateStudent(student);
            if (!String.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                var isEmailUnique = IsUniqueEmail(student.Email);
                if (!isEmailUnique)
                {
                    MessageBox.Show("Emaili juaj eshte regjistruar me  pare ne sistem!");
                }
                var isPhoneUnique = IsUniquePhone(student.Phone);
                if (!isPhoneUnique)
                {
                    MessageBox.Show("Numri i telefonit eshte regjistruar me pare ne sistem!");
                }
                else
                {
                    UpdateStudent(student);
                }
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            delete_record();

            SqlConnection con = new SqlConnection();
            SqlCommand delcmd = new SqlCommand();
            con.ConnectionString = "Data Source=Justin;Initial Catalog=SignUp;Integrated Security=True";
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM StudentInfo", selectConnection: con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void delete_record()
        {
            SqlConnection con = new SqlConnection();
            SqlCommand delcmd = new SqlCommand();
            if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
            {
                delcmd.CommandText = "DELETE FROM StudentInfo WHERE ID=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                con.ConnectionString = "Data Source=Justin;Initial Catalog=SignUp;Integrated Security=True";
                con.Open();
                delcmd.Connection = con;
                delcmd.ExecuteNonQuery();
                con.Close();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("deleted");
            }
        }

            private void Refresh_Click(object sender, EventArgs e)
        {
             LoadData();
        }

        private void Db_Email_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Db_Origin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
