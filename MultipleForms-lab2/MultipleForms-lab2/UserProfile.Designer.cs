namespace MultipleForms_lab2
{
    partial class UserProfile
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
            this.label2 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.degree = new System.Windows.Forms.Label();
            this.degreeBox = new System.Windows.Forms.TextBox();
            this.school = new System.Windows.Forms.Label();
            this.schoolBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.year = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.employerBox = new System.Windows.Forms.TextBox();
            this.jobTitle = new System.Windows.Forms.Label();
            this.employer = new System.Windows.Forms.Label();
            this.jobTitleBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gender:";
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(91, 49);
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Size = new System.Drawing.Size(121, 20);
            this.gender.TabIndex = 10;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(25, 15);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 13);
            this.label.TabIndex = 9;
            this.label.Text = "Name:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(91, 12);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(121, 20);
            this.name.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "City:";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(91, 127);
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Size = new System.Drawing.Size(121, 20);
            this.city.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Country:";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(91, 90);
            this.country.Name = "country";
            this.country.ReadOnly = true;
            this.country.Size = new System.Drawing.Size(121, 20);
            this.country.TabIndex = 12;
            // 
            // degree
            // 
            this.degree.AutoSize = true;
            this.degree.Location = new System.Drawing.Point(13, 57);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(45, 13);
            this.degree.TabIndex = 19;
            this.degree.Text = "Degree:";
            // 
            // degreeBox
            // 
            this.degreeBox.Location = new System.Drawing.Point(79, 54);
            this.degreeBox.Name = "degreeBox";
            this.degreeBox.ReadOnly = true;
            this.degreeBox.Size = new System.Drawing.Size(121, 20);
            this.degreeBox.TabIndex = 18;
            // 
            // school
            // 
            this.school.AutoSize = true;
            this.school.Location = new System.Drawing.Point(13, 22);
            this.school.Name = "school";
            this.school.Size = new System.Drawing.Size(43, 13);
            this.school.TabIndex = 17;
            this.school.Text = "School:";
            // 
            // schoolBox
            // 
            this.schoolBox.Location = new System.Drawing.Point(79, 19);
            this.schoolBox.Name = "schoolBox";
            this.schoolBox.ReadOnly = true;
            this.schoolBox.Size = new System.Drawing.Size(121, 20);
            this.schoolBox.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.year);
            this.groupBox1.Controls.Add(this.yearBox);
            this.groupBox1.Controls.Add(this.schoolBox);
            this.groupBox1.Controls.Add(this.degree);
            this.groupBox1.Controls.Add(this.school);
            this.groupBox1.Controls.Add(this.degreeBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 130);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Education";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(13, 92);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(32, 13);
            this.year.TabIndex = 21;
            this.year.Text = "Year:";
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(79, 89);
            this.yearBox.Name = "yearBox";
            this.yearBox.ReadOnly = true;
            this.yearBox.Size = new System.Drawing.Size(121, 20);
            this.yearBox.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.employerBox);
            this.groupBox2.Controls.Add(this.jobTitle);
            this.groupBox2.Controls.Add(this.employer);
            this.groupBox2.Controls.Add(this.jobTitleBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 90);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Professional";
            // 
            // employerBox
            // 
            this.employerBox.Location = new System.Drawing.Point(79, 19);
            this.employerBox.Name = "employerBox";
            this.employerBox.ReadOnly = true;
            this.employerBox.Size = new System.Drawing.Size(121, 20);
            this.employerBox.TabIndex = 16;
            // 
            // jobTitle
            // 
            this.jobTitle.AutoSize = true;
            this.jobTitle.Location = new System.Drawing.Point(13, 57);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(50, 13);
            this.jobTitle.TabIndex = 19;
            this.jobTitle.Text = "Job Title:";
            // 
            // employer
            // 
            this.employer.AutoSize = true;
            this.employer.Location = new System.Drawing.Point(13, 22);
            this.employer.Name = "employer";
            this.employer.Size = new System.Drawing.Size(53, 13);
            this.employer.TabIndex = 17;
            this.employer.Text = "Employer:";
            // 
            // jobTitleBox
            // 
            this.jobTitleBox.Location = new System.Drawing.Point(79, 54);
            this.jobTitleBox.Name = "jobTitleBox";
            this.jobTitleBox.ReadOnly = true;
            this.jobTitleBox.Size = new System.Drawing.Size(121, 20);
            this.jobTitleBox.TabIndex = 18;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label);
            this.Controls.Add(this.name);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Label degree;
        private System.Windows.Forms.TextBox degreeBox;
        private System.Windows.Forms.Label school;
        private System.Windows.Forms.TextBox schoolBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox employerBox;
        private System.Windows.Forms.Label jobTitle;
        private System.Windows.Forms.Label employer;
        private System.Windows.Forms.TextBox jobTitleBox;
    }
}