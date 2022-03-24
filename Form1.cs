using SignUpProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpProject
{
    public partial class Form1 : Form
    {

        string gjinia;
        SqlConnection con;
        private TextBox Su_Emer;
        private DateTimePicker Su_Dtl;
        private TextBox Su_Email;
        private TextBox Su_Pass;
        private Label label_em;
        private Label label_vndl;
        private Label datepicker_dtl;
        private Label label_gjinia;
        private Label label_email;
        private Label label_pass;
        private RadioButton Su_mashkull;
        private RadioButton Su_femer;
        private ComboBox Su_Vndl;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            Student student = new Student() {
                Pass = Su_Pass.Text,
                Birthday = Su_Dtl.Text,
                Email = Su_Email.Text,
                Origin = Su_Vndl.Text,
                Phone = Su_Nr_Tel.Text,
                Name = Su_Emer.Text,
                Gender = gjinia
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
                else {
                    InsertStudent(student);
                    Form1 cr = new Form1();
                    Form3 df = new Form3();
                    cr.Close();
                    df.Show();
                }
            }
        }

        private void InsertStudent(Student student) {
            con = new SqlConnection();
            con.ConnectionString = GetConnectionString();
            con.Open();
            String query = "Insert into StudentInfo (Emer,Dtl,Vndl,Gjinia,Email,Pass,Tel) Values (";
            query = query + "'" + student.Name + "',";
            query = query + "'" + student.Birthday + "',";
            query = query + "'" + student.Origin + "',";
            query = query + "'" + student.Gender + "',";
            query = query + "'" + student.Email + "',";
            query = query + "'" + student.Pass + "',";
            query = query + "'" + student.Phone + "');";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Te dhenat u ruajten me sukses");
            con.Close();

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

        private bool IsUniqueEmail(string email) {
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


        private void Emer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vndl_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dtl_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Pass_Leave(object sender, EventArgs e)
        {
           
        }

        private void radioButton_mashkull_CheckedChanged(object sender, EventArgs e)
        {
            gjinia = "Mashkull";
        }

        private void radioButton_femer_CheckedChanged(object sender, EventArgs e)
        {
            gjinia = "Femer";
        }

        private void comboBox_vndl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code,
            // you can retrieve it from a configuration file.
            return "Data Source=Justin;Initial Catalog=SignUp;"
                + "Integrated Security=true;";
        }

        private void textBox_tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        

        private void DbEdit_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Si_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Si_Mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_btn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = GetConnectionString();
            con.Open();
            SqlDataReader dr;
            if (Si_Password.Text != string.Empty || Si_Mail.Text != string.Empty || Si_Name.Text != string.Empty)
            {
                var cmd = new SqlCommand("select * from StudentInfo where Email like'" + Si_Mail.Text + "' and Pass like '" + Si_Password.Text + "' and Emer like'" + Si_Name.Text + "'", con);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                dr = sqlDataReader;
                if (dr.Read())
                {
                    MessageBox.Show("Sign In successful!");
                    Form3 df = new Form3();
                    this.Hide();
                    df.Show();
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Asnje account nuk ekziston me kete password ose email ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Ju lutem plotesoni te dhenat ne te gjitha fushat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
