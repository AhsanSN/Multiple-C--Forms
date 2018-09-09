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
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gender:";
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(118, 70);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(121, 20);
            this.gender.TabIndex = 10;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(52, 36);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 13);
            this.label.TabIndex = 9;
            this.label.Text = "Name:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(118, 33);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 20);
            this.name.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "City:";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(118, 148);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(121, 20);
            this.city.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Country:";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(118, 111);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(121, 20);
            this.country.TabIndex = 12;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 203);
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
    }
}