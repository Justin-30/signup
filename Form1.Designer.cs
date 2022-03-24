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
namespace SignUpProject
{
    partial class Form1 { 


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Su_Emer = new System.Windows.Forms.TextBox();
            this.Su_Dtl = new System.Windows.Forms.DateTimePicker();
            this.Su_Email = new System.Windows.Forms.TextBox();
            this.Su_Pass = new System.Windows.Forms.TextBox();
            this.label_em = new System.Windows.Forms.Label();
            this.label_vndl = new System.Windows.Forms.Label();
            this.datepicker_dtl = new System.Windows.Forms.Label();
            this.label_gjinia = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.Su_mashkull = new System.Windows.Forms.RadioButton();
            this.Su_femer = new System.Windows.Forms.RadioButton();
            this.Su_Vndl = new System.Windows.Forms.ComboBox();
            this.Regjistrohu = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Su_Nr_Tel = new System.Windows.Forms.TextBox();
            this.label_Tel = new System.Windows.Forms.Label();
            this.SignForms = new System.Windows.Forms.TabControl();
            this.SignUp = new System.Windows.Forms.TabPage();
            this.Vndl = new System.Windows.Forms.Label();
            this.Emer = new System.Windows.Forms.Label();
            this.SignIn = new System.Windows.Forms.TabPage();
            this.SignIn_btn = new System.Windows.Forms.Button();
            this.Si_Password = new System.Windows.Forms.TextBox();
            this.Si_Mail = new System.Windows.Forms.TextBox();
            this.Si_Name = new System.Windows.Forms.TextBox();
            this.Si_Pass = new System.Windows.Forms.Label();
            this.Si_Email = new System.Windows.Forms.Label();
            this.Si_Emer = new System.Windows.Forms.Label();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.signUpDataSet = new SignUpProject.SignUpDataSet();
            this.studentInfoTableAdapter = new SignUpProject.SignUpDataSetTableAdapters.StudentInfoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SignForms.SuspendLayout();
            this.SignUp.SuspendLayout();
            this.SignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signUpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Su_Emer
            // 
            this.Su_Emer.BackColor = System.Drawing.SystemColors.Window;
            this.Su_Emer.Location = new System.Drawing.Point(123, 23);
            this.Su_Emer.Name = "Su_Emer";
            this.Su_Emer.Size = new System.Drawing.Size(163, 22);
            this.Su_Emer.TabIndex = 2;
            this.Su_Emer.TextChanged += new System.EventHandler(this.Emer_TextChanged);
            // 
            // Su_Dtl
            // 
            this.Su_Dtl.CalendarMonthBackground = System.Drawing.Color.White;
            this.Su_Dtl.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.Su_Dtl.Location = new System.Drawing.Point(119, 306);
            this.Su_Dtl.Name = "Su_Dtl";
            this.Su_Dtl.Size = new System.Drawing.Size(250, 22);
            this.Su_Dtl.TabIndex = 3;
            this.Su_Dtl.ValueChanged += new System.EventHandler(this.Dtl_ValueChanged);
            // 
            // Su_Email
            // 
            this.Su_Email.Location = new System.Drawing.Point(123, 114);
            this.Su_Email.Name = "Su_Email";
            this.Su_Email.Size = new System.Drawing.Size(163, 22);
            this.Su_Email.TabIndex = 5;
            this.Su_Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Su_Pass
            // 
            this.Su_Pass.Location = new System.Drawing.Point(123, 153);
            this.Su_Pass.Name = "Su_Pass";
            this.Su_Pass.PasswordChar = '*';
            this.Su_Pass.Size = new System.Drawing.Size(163, 22);
            this.Su_Pass.TabIndex = 6;
            this.Su_Pass.UseSystemPasswordChar = true;
            this.Su_Pass.TextChanged += new System.EventHandler(this.Pass_TextChanged);
            // 
            // label_em
            // 
            this.label_em.Location = new System.Drawing.Point(0, 0);
            this.label_em.Name = "label_em";
            this.label_em.Size = new System.Drawing.Size(100, 23);
            this.label_em.TabIndex = 19;
            // 
            // label_vndl
            // 
            this.label_vndl.Location = new System.Drawing.Point(0, 0);
            this.label_vndl.Name = "label_vndl";
            this.label_vndl.Size = new System.Drawing.Size(100, 23);
            this.label_vndl.TabIndex = 20;
            // 
            // datepicker_dtl
            // 
            this.datepicker_dtl.AutoSize = true;
            this.datepicker_dtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.datepicker_dtl.ForeColor = System.Drawing.Color.White;
            this.datepicker_dtl.Location = new System.Drawing.Point(21, 306);
            this.datepicker_dtl.Name = "datepicker_dtl";
            this.datepicker_dtl.Size = new System.Drawing.Size(79, 20);
            this.datepicker_dtl.TabIndex = 9;
            this.datepicker_dtl.Text = "Birthday";
            // 
            // label_gjinia
            // 
            this.label_gjinia.AutoSize = true;
            this.label_gjinia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_gjinia.ForeColor = System.Drawing.Color.White;
            this.label_gjinia.Location = new System.Drawing.Point(21, 258);
            this.label_gjinia.Name = "label_gjinia";
            this.label_gjinia.Size = new System.Drawing.Size(70, 20);
            this.label_gjinia.TabIndex = 10;
            this.label_gjinia.Text = "Gender";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.White;
            this.label_email.Location = new System.Drawing.Point(21, 120);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(56, 20);
            this.label_email.TabIndex = 11;
            this.label_email.Text = "Email";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_pass.ForeColor = System.Drawing.Color.White;
            this.label_pass.Location = new System.Drawing.Point(21, 159);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(91, 20);
            this.label_pass.TabIndex = 12;
            this.label_pass.Text = "Password";
            // 
            // Su_mashkull
            // 
            this.Su_mashkull.AutoSize = true;
            this.Su_mashkull.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Su_mashkull.ForeColor = System.Drawing.Color.White;
            this.Su_mashkull.Location = new System.Drawing.Point(123, 258);
            this.Su_mashkull.Name = "Su_mashkull";
            this.Su_mashkull.Size = new System.Drawing.Size(62, 20);
            this.Su_mashkull.TabIndex = 13;
            this.Su_mashkull.TabStop = true;
            this.Su_mashkull.Text = "Male";
            this.Su_mashkull.UseVisualStyleBackColor = true;
            this.Su_mashkull.CheckedChanged += new System.EventHandler(this.radioButton_mashkull_CheckedChanged);
            // 
            // Su_femer
            // 
            this.Su_femer.AutoSize = true;
            this.Su_femer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Su_femer.ForeColor = System.Drawing.Color.White;
            this.Su_femer.Location = new System.Drawing.Point(206, 259);
            this.Su_femer.Name = "Su_femer";
            this.Su_femer.Size = new System.Drawing.Size(80, 20);
            this.Su_femer.TabIndex = 14;
            this.Su_femer.TabStop = true;
            this.Su_femer.Text = "Female";
            this.Su_femer.UseVisualStyleBackColor = true;
            this.Su_femer.CheckedChanged += new System.EventHandler(this.radioButton_femer_CheckedChanged);
            // 
            // Su_Vndl
            // 
            this.Su_Vndl.FormattingEnabled = true;
            this.Su_Vndl.Items.AddRange(new object[] {
            "Berat",
            "Durrës",
            "Dibër",
            "Elbasan",
            "Fier",
            "Gjirokastër\t",
            "Korçë",
            "Kukës",
            "Lezhë",
            "Lushnje",
            "Paskuqan",
            "Peshkopi",
            "Përmet",
            "Pogradec",
            "Sarandë",
            "Shkodër",
            "Tepelenë",
            "Tiranë",
            "Vlorë",
            "Himarë"});
            this.Su_Vndl.Location = new System.Drawing.Point(123, 71);
            this.Su_Vndl.Name = "Su_Vndl";
            this.Su_Vndl.Size = new System.Drawing.Size(163, 24);
            this.Su_Vndl.TabIndex = 15;
            this.Su_Vndl.SelectedIndexChanged += new System.EventHandler(this.comboBox_vndl_SelectedIndexChanged);
            // 
            // Regjistrohu
            // 
            this.Regjistrohu.BackColor = System.Drawing.Color.White;
            this.Regjistrohu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regjistrohu.Location = new System.Drawing.Point(24, 364);
            this.Regjistrohu.Name = "Regjistrohu";
            this.Regjistrohu.Size = new System.Drawing.Size(151, 33);
            this.Regjistrohu.TabIndex = 16;
            this.Regjistrohu.Text = "SignUp";
            this.Regjistrohu.UseVisualStyleBackColor = false;
            this.Regjistrohu.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // Su_Nr_Tel
            // 
            this.Su_Nr_Tel.Location = new System.Drawing.Point(123, 202);
            this.Su_Nr_Tel.Name = "Su_Nr_Tel";
            this.Su_Nr_Tel.Size = new System.Drawing.Size(163, 22);
            this.Su_Nr_Tel.TabIndex = 17;
            this.Su_Nr_Tel.TextChanged += new System.EventHandler(this.textBox_tel_TextChanged);
            // 
            // label_Tel
            // 
            this.label_Tel.AutoSize = true;
            this.label_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_Tel.ForeColor = System.Drawing.Color.White;
            this.label_Tel.Location = new System.Drawing.Point(21, 204);
            this.label_Tel.Name = "label_Tel";
            this.label_Tel.Size = new System.Drawing.Size(68, 20);
            this.label_Tel.TabIndex = 18;
            this.label_Tel.Text = "Tel_No";
            // 
            // SignForms
            // 
            this.SignForms.Controls.Add(this.SignUp);
            this.SignForms.Controls.Add(this.SignIn);
            this.SignForms.Location = new System.Drawing.Point(12, 12);
            this.SignForms.Name = "SignForms";
            this.SignForms.SelectedIndex = 0;
            this.SignForms.Size = new System.Drawing.Size(800, 500);
            this.SignForms.TabIndex = 19;
            this.SignForms.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // SignUp
            // 
            this.SignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUp.BackgroundImage")));
            this.SignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SignUp.Controls.Add(this.label1);
            this.SignUp.Controls.Add(this.Vndl);
            this.SignUp.Controls.Add(this.Emer);
            this.SignUp.Controls.Add(this.Su_Emer);
            this.SignUp.Controls.Add(this.Regjistrohu);
            this.SignUp.Controls.Add(this.Su_Nr_Tel);
            this.SignUp.Controls.Add(this.label_Tel);
            this.SignUp.Controls.Add(this.label_em);
            this.SignUp.Controls.Add(this.label_vndl);
            this.SignUp.Controls.Add(this.Su_Vndl);
            this.SignUp.Controls.Add(this.Su_Pass);
            this.SignUp.Controls.Add(this.label_pass);
            this.SignUp.Controls.Add(this.Su_femer);
            this.SignUp.Controls.Add(this.label_email);
            this.SignUp.Controls.Add(this.Su_Email);
            this.SignUp.Controls.Add(this.datepicker_dtl);
            this.SignUp.Controls.Add(this.Su_mashkull);
            this.SignUp.Controls.Add(this.Su_Dtl);
            this.SignUp.Controls.Add(this.label_gjinia);
            this.SignUp.Location = new System.Drawing.Point(4, 25);
            this.SignUp.Name = "SignUp";
            this.SignUp.Padding = new System.Windows.Forms.Padding(3);
            this.SignUp.Size = new System.Drawing.Size(792, 471);
            this.SignUp.TabIndex = 0;
            this.SignUp.Text = "SignUp";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // Vndl
            // 
            this.Vndl.AutoSize = true;
            this.Vndl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vndl.ForeColor = System.Drawing.Color.White;
            this.Vndl.Location = new System.Drawing.Point(20, 75);
            this.Vndl.Name = "Vndl";
            this.Vndl.Size = new System.Drawing.Size(60, 20);
            this.Vndl.TabIndex = 23;
            this.Vndl.Text = "Origin";
            // 
            // Emer
            // 
            this.Emer.AutoSize = true;
            this.Emer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emer.ForeColor = System.Drawing.Color.White;
            this.Emer.Location = new System.Drawing.Point(20, 23);
            this.Emer.Name = "Emer";
            this.Emer.Size = new System.Drawing.Size(57, 20);
            this.Emer.TabIndex = 22;
            this.Emer.Text = "Name";
            // 
            // SignIn
            // 
            this.SignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignIn.BackgroundImage")));
            this.SignIn.Controls.Add(this.label2);
            this.SignIn.Controls.Add(this.SignIn_btn);
            this.SignIn.Controls.Add(this.Si_Password);
            this.SignIn.Controls.Add(this.Si_Mail);
            this.SignIn.Controls.Add(this.Si_Name);
            this.SignIn.Controls.Add(this.Si_Pass);
            this.SignIn.Controls.Add(this.Si_Email);
            this.SignIn.Controls.Add(this.Si_Emer);
            this.SignIn.Location = new System.Drawing.Point(4, 25);
            this.SignIn.Name = "SignIn";
            this.SignIn.Padding = new System.Windows.Forms.Padding(3);
            this.SignIn.Size = new System.Drawing.Size(792, 471);
            this.SignIn.TabIndex = 1;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.DbEdit_Click);
            // 
            // SignIn_btn
            // 
            this.SignIn_btn.BackColor = System.Drawing.Color.White;
            this.SignIn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SignIn_btn.Location = new System.Drawing.Point(69, 259);
            this.SignIn_btn.Name = "SignIn_btn";
            this.SignIn_btn.Size = new System.Drawing.Size(155, 38);
            this.SignIn_btn.TabIndex = 6;
            this.SignIn_btn.Text = "Sign In";
            this.SignIn_btn.UseVisualStyleBackColor = false;
            this.SignIn_btn.Click += new System.EventHandler(this.SignIn_btn_Click);
            // 
            // Si_Password
            // 
            this.Si_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Si_Password.Location = new System.Drawing.Point(170, 197);
            this.Si_Password.Name = "Si_Password";
            this.Si_Password.Size = new System.Drawing.Size(176, 30);
            this.Si_Password.TabIndex = 5;
            this.Si_Password.UseSystemPasswordChar = true;
            this.Si_Password.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Si_Mail
            // 
            this.Si_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Si_Mail.Location = new System.Drawing.Point(170, 139);
            this.Si_Mail.Name = "Si_Mail";
            this.Si_Mail.Size = new System.Drawing.Size(176, 30);
            this.Si_Mail.TabIndex = 4;
            this.Si_Mail.TextChanged += new System.EventHandler(this.Si_Mail_TextChanged);
            // 
            // Si_Name
            // 
            this.Si_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Si_Name.Location = new System.Drawing.Point(170, 78);
            this.Si_Name.Name = "Si_Name";
            this.Si_Name.Size = new System.Drawing.Size(176, 30);
            this.Si_Name.TabIndex = 3;
            this.Si_Name.TextChanged += new System.EventHandler(this.Si_Name_TextChanged);
            // 
            // Si_Pass
            // 
            this.Si_Pass.AutoSize = true;
            this.Si_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.Si_Pass.ForeColor = System.Drawing.Color.White;
            this.Si_Pass.Location = new System.Drawing.Point(36, 198);
            this.Si_Pass.Name = "Si_Pass";
            this.Si_Pass.Size = new System.Drawing.Size(128, 29);
            this.Si_Pass.TabIndex = 2;
            this.Si_Pass.Text = "Password";
            // 
            // Si_Email
            // 
            this.Si_Email.AutoSize = true;
            this.Si_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.Si_Email.ForeColor = System.Drawing.Color.White;
            this.Si_Email.Location = new System.Drawing.Point(36, 139);
            this.Si_Email.Name = "Si_Email";
            this.Si_Email.Size = new System.Drawing.Size(79, 29);
            this.Si_Email.TabIndex = 1;
            this.Si_Email.Text = "Email";
            // 
            // Si_Emer
            // 
            this.Si_Emer.AutoSize = true;
            this.Si_Emer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Si_Emer.ForeColor = System.Drawing.Color.White;
            this.Si_Emer.Location = new System.Drawing.Point(36, 78);
            this.Si_Emer.Name = "Si_Emer";
            this.Si_Emer.Size = new System.Drawing.Size(82, 29);
            this.Si_Emer.TabIndex = 0;
            this.Si_Emer.Text = "Name";
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.signUpDataSet;
            // 
            // signUpDataSet
            // 
            this.signUpDataSet.DataSetName = "SignUpDataSet";
            this.signUpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "If you already have an account\r\n please click on Sign In Tab!\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "If you don\'t have an account please \r\nclick at Sign Up tab to register!";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(822, 526);
            this.Controls.Add(this.SignForms);
            this.Name = "Form1";
            this.SignForms.ResumeLayout(false);
            this.SignUp.ResumeLayout(false);
            this.SignUp.PerformLayout();
            this.SignIn.ResumeLayout(false);
            this.SignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signUpDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        private Button Regjistrohu;
        private BackgroundWorker backgroundWorker1;
        private TextBox Su_Nr_Tel;
        private Label label_Tel;
        private TabControl SignForms;
        private TabPage SignUp;
        private TabPage SignIn;
        private SignUpDataSet signUpDataSet;
        private BindingSource studentInfoBindingSource;
        private IContainer components;
        private SignUpDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private Button SignIn_btn;
        private TextBox Si_Password;
        private TextBox Si_Mail;
        private TextBox Si_Name;
        private Label Si_Pass;
        private Label Si_Email;
        private Label Si_Emer;
        private Label Vndl;
        private Label Emer;
        private Label label1;
        private Label label2;
    }
}

