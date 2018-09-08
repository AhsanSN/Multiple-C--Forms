namespace MultipleForms_lab2
{
    partial class Form1
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
            this.firstnameTxt = new System.Windows.Forms.TextBox();
            this.selectCountry = new System.Windows.Forms.ComboBox();
            this.citySelect = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.viewProfileBtn = new System.Windows.Forms.Button();
            this.editProfileBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.searchResult = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstnameTxt
            // 
            this.firstnameTxt.Location = new System.Drawing.Point(88, 32);
            this.firstnameTxt.Name = "firstnameTxt";
            this.firstnameTxt.Size = new System.Drawing.Size(121, 20);
            this.firstnameTxt.TabIndex = 0;
            // 
            // selectCountry
            // 
            this.selectCountry.FormattingEnabled = true;
            this.selectCountry.Location = new System.Drawing.Point(88, 58);
            this.selectCountry.Name = "selectCountry";
            this.selectCountry.Size = new System.Drawing.Size(121, 21);
            this.selectCountry.TabIndex = 1;
            this.selectCountry.SelectedIndexChanged += new System.EventHandler(this.selectCountry_SelectedIndexChanged);
            // 
            // citySelect
            // 
            this.citySelect.FormattingEnabled = true;
            this.citySelect.Location = new System.Drawing.Point(88, 85);
            this.citySelect.Name = "citySelect";
            this.citySelect.Size = new System.Drawing.Size(121, 21);
            this.citySelect.TabIndex = 2;
            this.citySelect.SelectedIndexChanged += new System.EventHandler(this.selectCity_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.firstnameTxt);
            this.groupBox1.Controls.Add(this.citySelect);
            this.groupBox1.Controls.Add(this.selectCountry);
            this.groupBox1.Location = new System.Drawing.Point(31, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(337, 97);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.femaleRadio);
            this.groupBox2.Controls.Add(this.maleRadio);
            this.groupBox2.Location = new System.Drawing.Point(308, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 72);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(19, 43);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(59, 17);
            this.femaleRadio.TabIndex = 1;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Location = new System.Drawing.Point(19, 19);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(48, 17);
            this.maleRadio.TabIndex = 0;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.searchResult);
            this.groupBox3.Location = new System.Drawing.Point(31, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 235);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // viewProfileBtn
            // 
            this.viewProfileBtn.Location = new System.Drawing.Point(56, 433);
            this.viewProfileBtn.Name = "viewProfileBtn";
            this.viewProfileBtn.Size = new System.Drawing.Size(75, 23);
            this.viewProfileBtn.TabIndex = 8;
            this.viewProfileBtn.Text = "View Profile";
            this.viewProfileBtn.UseVisualStyleBackColor = true;
            // 
            // editProfileBtn
            // 
            this.editProfileBtn.Location = new System.Drawing.Point(153, 433);
            this.editProfileBtn.Name = "editProfileBtn";
            this.editProfileBtn.Size = new System.Drawing.Size(75, 23);
            this.editProfileBtn.TabIndex = 9;
            this.editProfileBtn.Text = "Edit Profile";
            this.editProfileBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(384, 433);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // searchResult
            // 
            this.searchResult.FormattingEnabled = true;
            this.searchResult.Location = new System.Drawing.Point(25, 31);
            this.searchResult.Name = "searchResult";
            this.searchResult.Size = new System.Drawing.Size(403, 186);
            this.searchResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 477);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.editProfileBtn);
            this.Controls.Add(this.viewProfileBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Search User";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox firstnameTxt;
        private System.Windows.Forms.ComboBox selectCountry;
        private System.Windows.Forms.ComboBox citySelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button viewProfileBtn;
        private System.Windows.Forms.Button editProfileBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ListBox searchResult;
    }
}

