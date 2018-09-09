using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForms_lab2
{
    public partial class UserProfile : Form
    {
        public int selectedIndexInp;
        public UserProfile(int selectedIndex)
        {
            InitializeComponent();
            selectedIndexInp = selectedIndex;

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            Form1 searchForm = new Form1();
            name.Text = searchForm.names[selectedIndexInp] ;
            gender.Text = searchForm.gender[selectedIndexInp];
            country.Text = searchForm.country[selectedIndexInp];
            city.Text = searchForm.city[selectedIndexInp];

            schoolBox.Text = searchForm.school[selectedIndexInp];
            degreeBox.Text = searchForm.degree[selectedIndexInp];
            yearBox.Text = searchForm.year[selectedIndexInp];

            employerBox.Text = searchForm.employer[selectedIndexInp];
            jobTitleBox.Text = searchForm.jobTitle[selectedIndexInp];
        }
    }
}
