namespace SignUpProject
{
    partial class Hyrje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hyrje));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Page2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Page3 = new System.Windows.Forms.Panel();
            this.SignUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Page1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Page2.SuspendLayout();
            this.Page3.SuspendLayout();
            this.Page1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(495, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(271, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Previous Page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Page2
            // 
            this.Page2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Page2.BackgroundImage")));
            this.Page2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Page2.Controls.Add(this.Page3);
            this.Page2.Controls.Add(this.label2);
            this.Page2.Location = new System.Drawing.Point(0, 0);
            this.Page2.Name = "Page2";
            this.Page2.Size = new System.Drawing.Size(798, 502);
            this.Page2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(51, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(697, 90);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Page3
            // 
            this.Page3.BackgroundImage = global::SignUpProject.Properties.Resources.Mang_Island_Logo1;
            this.Page3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Page3.Controls.Add(this.SignUp);
            this.Page3.Controls.Add(this.label3);
            this.Page3.Location = new System.Drawing.Point(0, 109);
            this.Page3.Name = "Page3";
            this.Page3.Size = new System.Drawing.Size(798, 502);
            this.Page3.TabIndex = 2;
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.White;
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.Black;
            this.SignUp.Location = new System.Drawing.Point(332, 50);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(122, 39);
            this.SignUp.TabIndex = 2;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(205, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "What are you waiting for??? ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Page1
            // 
            this.Page1.BackgroundImage = global::SignUpProject.Properties.Resources.Mang_Island_Logo1;
            this.Page1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Page1.Controls.Add(this.Page2);
            this.Page1.Controls.Add(this.label1);
            this.Page1.Location = new System.Drawing.Point(9, 12);
            this.Page1.Name = "Page1";
            this.Page1.Size = new System.Drawing.Size(798, 502);
            this.Page1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(196, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To Mango Island ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Hyrje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 603);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Page1);
            this.Controls.Add(this.button1);
            this.Name = "Hyrje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hyrje";
            this.Page2.ResumeLayout(false);
            this.Page2.PerformLayout();
            this.Page3.ResumeLayout(false);
            this.Page3.PerformLayout();
            this.Page1.ResumeLayout(false);
            this.Page1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Page1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Page2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Page3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SignUp;
    }
}