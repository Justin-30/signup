namespace SignUpProject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vndlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gjiniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.signUpDataSet = new SignUpProject.SignUpDataSet();
            this.studentInfoTableAdapter = new SignUpProject.SignUpDataSetTableAdapters.StudentInfoTableAdapter();
            this.Db_Emer = new System.Windows.Forms.Label();
            this.Db_Vndl = new System.Windows.Forms.Label();
            this.Db_Gjinia = new System.Windows.Forms.Label();
            this.Db_Dtl = new System.Windows.Forms.Label();
            this.Db_Tel = new System.Windows.Forms.Label();
            this.Db_Pass = new System.Windows.Forms.Label();
            this.Db_Email = new System.Windows.Forms.Label();
            this.Db_Name = new System.Windows.Forms.TextBox();
            this.Db_Id_textbox = new System.Windows.Forms.TextBox();
            this.Db_Phone = new System.Windows.Forms.TextBox();
            this.Db_Pass_textbox = new System.Windows.Forms.TextBox();
            this.Db_Email_textbox = new System.Windows.Forms.TextBox();
            this.Db_Id = new System.Windows.Forms.Label();
            this.Db_Origin = new System.Windows.Forms.ComboBox();
            this.Db_mashkull = new System.Windows.Forms.RadioButton();
            this.Db_femer = new System.Windows.Forms.RadioButton();
            this.Db_dtl_timepicker = new System.Windows.Forms.DateTimePicker();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signUpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.emerDataGridViewTextBoxColumn,
            this.dtlDataGridViewTextBoxColumn,
            this.vndlDataGridViewTextBoxColumn,
            this.gjiniaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 453);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // emerDataGridViewTextBoxColumn
            // 
            this.emerDataGridViewTextBoxColumn.DataPropertyName = "Emer";
            this.emerDataGridViewTextBoxColumn.HeaderText = "Emer";
            this.emerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emerDataGridViewTextBoxColumn.Name = "emerDataGridViewTextBoxColumn";
            this.emerDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtlDataGridViewTextBoxColumn
            // 
            this.dtlDataGridViewTextBoxColumn.DataPropertyName = "Dtl";
            this.dtlDataGridViewTextBoxColumn.HeaderText = "Dtl";
            this.dtlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtlDataGridViewTextBoxColumn.Name = "dtlDataGridViewTextBoxColumn";
            this.dtlDataGridViewTextBoxColumn.Width = 125;
            // 
            // vndlDataGridViewTextBoxColumn
            // 
            this.vndlDataGridViewTextBoxColumn.DataPropertyName = "Vndl";
            this.vndlDataGridViewTextBoxColumn.HeaderText = "Vndl";
            this.vndlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vndlDataGridViewTextBoxColumn.Name = "vndlDataGridViewTextBoxColumn";
            this.vndlDataGridViewTextBoxColumn.Width = 125;
            // 
            // gjiniaDataGridViewTextBoxColumn
            // 
            this.gjiniaDataGridViewTextBoxColumn.DataPropertyName = "Gjinia";
            this.gjiniaDataGridViewTextBoxColumn.HeaderText = "Gjinia";
            this.gjiniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gjiniaDataGridViewTextBoxColumn.Name = "gjiniaDataGridViewTextBoxColumn";
            this.gjiniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "Pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "Pass";
            this.passDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.Width = 125;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.Width = 125;
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
            // Db_Emer
            // 
            this.Db_Emer.AutoSize = true;
            this.Db_Emer.Location = new System.Drawing.Point(45, 40);
            this.Db_Emer.Name = "Db_Emer";
            this.Db_Emer.Size = new System.Drawing.Size(39, 16);
            this.Db_Emer.TabIndex = 1;
            this.Db_Emer.Text = "Emer";
            // 
            // Db_Vndl
            // 
            this.Db_Vndl.AutoSize = true;
            this.Db_Vndl.Location = new System.Drawing.Point(45, 93);
            this.Db_Vndl.Name = "Db_Vndl";
            this.Db_Vndl.Size = new System.Drawing.Size(34, 16);
            this.Db_Vndl.TabIndex = 2;
            this.Db_Vndl.Text = "Vndl";
            // 
            // Db_Gjinia
            // 
            this.Db_Gjinia.AutoSize = true;
            this.Db_Gjinia.Location = new System.Drawing.Point(45, 155);
            this.Db_Gjinia.Name = "Db_Gjinia";
            this.Db_Gjinia.Size = new System.Drawing.Size(41, 16);
            this.Db_Gjinia.TabIndex = 3;
            this.Db_Gjinia.Text = "Gjinia";
            // 
            // Db_Dtl
            // 
            this.Db_Dtl.AutoSize = true;
            this.Db_Dtl.Location = new System.Drawing.Point(45, 213);
            this.Db_Dtl.Name = "Db_Dtl";
            this.Db_Dtl.Size = new System.Drawing.Size(23, 16);
            this.Db_Dtl.TabIndex = 4;
            this.Db_Dtl.Text = "Dtl";
            // 
            // Db_Tel
            // 
            this.Db_Tel.AutoSize = true;
            this.Db_Tel.Location = new System.Drawing.Point(580, 155);
            this.Db_Tel.Name = "Db_Tel";
            this.Db_Tel.Size = new System.Drawing.Size(48, 16);
            this.Db_Tel.TabIndex = 5;
            this.Db_Tel.Text = "Nr_Tel";
            // 
            // Db_Pass
            // 
            this.Db_Pass.AutoSize = true;
            this.Db_Pass.Location = new System.Drawing.Point(580, 93);
            this.Db_Pass.Name = "Db_Pass";
            this.Db_Pass.Size = new System.Drawing.Size(67, 16);
            this.Db_Pass.TabIndex = 6;
            this.Db_Pass.Text = "Password";
            // 
            // Db_Email
            // 
            this.Db_Email.AutoSize = true;
            this.Db_Email.Location = new System.Drawing.Point(580, 40);
            this.Db_Email.Name = "Db_Email";
            this.Db_Email.Size = new System.Drawing.Size(41, 16);
            this.Db_Email.TabIndex = 7;
            this.Db_Email.Text = "Email";
            // 
            // Db_Name
            // 
            this.Db_Name.Location = new System.Drawing.Point(143, 33);
            this.Db_Name.Name = "Db_Name";
            this.Db_Name.Size = new System.Drawing.Size(219, 22);
            this.Db_Name.TabIndex = 8;
            this.Db_Name.TextChanged += new System.EventHandler(this.Db_Name_TextChanged);
            // 
            // Db_Id_textbox
            // 
            this.Db_Id_textbox.Location = new System.Drawing.Point(698, 223);
            this.Db_Id_textbox.Name = "Db_Id_textbox";
            this.Db_Id_textbox.ReadOnly = true;
            this.Db_Id_textbox.Size = new System.Drawing.Size(219, 22);
            this.Db_Id_textbox.TabIndex = 9;
            this.Db_Id_textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Db_Phone
            // 
            this.Db_Phone.Location = new System.Drawing.Point(698, 155);
            this.Db_Phone.Name = "Db_Phone";
            this.Db_Phone.Size = new System.Drawing.Size(219, 22);
            this.Db_Phone.TabIndex = 10;
            // 
            // Db_Pass_textbox
            // 
            this.Db_Pass_textbox.Location = new System.Drawing.Point(698, 93);
            this.Db_Pass_textbox.Name = "Db_Pass_textbox";
            this.Db_Pass_textbox.Size = new System.Drawing.Size(219, 22);
            this.Db_Pass_textbox.TabIndex = 11;
            // 
            // Db_Email_textbox
            // 
            this.Db_Email_textbox.Location = new System.Drawing.Point(698, 40);
            this.Db_Email_textbox.Name = "Db_Email_textbox";
            this.Db_Email_textbox.Size = new System.Drawing.Size(219, 22);
            this.Db_Email_textbox.TabIndex = 12;
            this.Db_Email_textbox.TextChanged += new System.EventHandler(this.Db_Email_textbox_TextChanged);
            // 
            // Db_Id
            // 
            this.Db_Id.AutoSize = true;
            this.Db_Id.Location = new System.Drawing.Point(583, 223);
            this.Db_Id.Name = "Db_Id";
            this.Db_Id.Size = new System.Drawing.Size(18, 16);
            this.Db_Id.TabIndex = 13;
            this.Db_Id.Text = "Id";
            // 
            // Db_Origin
            // 
            this.Db_Origin.FormattingEnabled = true;
            this.Db_Origin.Items.AddRange(new object[] {
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
            this.Db_Origin.Location = new System.Drawing.Point(143, 93);
            this.Db_Origin.Name = "Db_Origin";
            this.Db_Origin.Size = new System.Drawing.Size(219, 24);
            this.Db_Origin.TabIndex = 14;
            this.Db_Origin.SelectedIndexChanged += new System.EventHandler(this.Db_Origin_SelectedIndexChanged);
            // 
            // Db_mashkull
            // 
            this.Db_mashkull.AutoSize = true;
            this.Db_mashkull.Location = new System.Drawing.Point(143, 150);
            this.Db_mashkull.Name = "Db_mashkull";
            this.Db_mashkull.Size = new System.Drawing.Size(81, 20);
            this.Db_mashkull.TabIndex = 15;
            this.Db_mashkull.TabStop = true;
            this.Db_mashkull.Text = "mashkull";
            this.Db_mashkull.UseVisualStyleBackColor = true;
            // 
            // Db_femer
            // 
            this.Db_femer.AutoSize = true;
            this.Db_femer.Location = new System.Drawing.Point(259, 150);
            this.Db_femer.Name = "Db_femer";
            this.Db_femer.Size = new System.Drawing.Size(62, 20);
            this.Db_femer.TabIndex = 16;
            this.Db_femer.TabStop = true;
            this.Db_femer.Text = "femer";
            this.Db_femer.UseVisualStyleBackColor = true;
            // 
            // Db_dtl_timepicker
            // 
            this.Db_dtl_timepicker.Location = new System.Drawing.Point(143, 213);
            this.Db_dtl_timepicker.Name = "Db_dtl_timepicker";
            this.Db_dtl_timepicker.Size = new System.Drawing.Size(200, 22);
            this.Db_dtl_timepicker.TabIndex = 17;
            this.Db_dtl_timepicker.ValueChanged += new System.EventHandler(this.Db_dtl_timepicker_ValueChanged);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(48, 272);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(125, 42);
            this.Update.TabIndex = 18;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(196, 272);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(125, 42);
            this.Delete.TabIndex = 19;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(351, 272);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(125, 42);
            this.Refresh.TabIndex = 20;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 816);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Db_dtl_timepicker);
            this.Controls.Add(this.Db_femer);
            this.Controls.Add(this.Db_mashkull);
            this.Controls.Add(this.Db_Origin);
            this.Controls.Add(this.Db_Id);
            this.Controls.Add(this.Db_Email_textbox);
            this.Controls.Add(this.Db_Pass_textbox);
            this.Controls.Add(this.Db_Phone);
            this.Controls.Add(this.Db_Id_textbox);
            this.Controls.Add(this.Db_Name);
            this.Controls.Add(this.Db_Email);
            this.Controls.Add(this.Db_Pass);
            this.Controls.Add(this.Db_Tel);
            this.Controls.Add(this.Db_Dtl);
            this.Controls.Add(this.Db_Gjinia);
            this.Controls.Add(this.Db_Vndl);
            this.Controls.Add(this.Db_Emer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signUpDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SignUpDataSet signUpDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private SignUpDataSetTableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vndlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gjiniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label Db_Emer;
        private System.Windows.Forms.Label Db_Vndl;
        private System.Windows.Forms.Label Db_Gjinia;
        private System.Windows.Forms.Label Db_Dtl;
        private System.Windows.Forms.Label Db_Tel;
        private System.Windows.Forms.Label Db_Pass;
        private System.Windows.Forms.Label Db_Email;
        private System.Windows.Forms.TextBox Db_Name;
        private System.Windows.Forms.TextBox Db_Id_textbox;
        private System.Windows.Forms.TextBox Db_Phone;
        private System.Windows.Forms.TextBox Db_Pass_textbox;
        private System.Windows.Forms.TextBox Db_Email_textbox;
        private System.Windows.Forms.Label Db_Id;
        private System.Windows.Forms.ComboBox Db_Origin;
        private System.Windows.Forms.RadioButton Db_mashkull;
        private System.Windows.Forms.RadioButton Db_femer;
        private System.Windows.Forms.DateTimePicker Db_dtl_timepicker;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Refresh;
    }
}