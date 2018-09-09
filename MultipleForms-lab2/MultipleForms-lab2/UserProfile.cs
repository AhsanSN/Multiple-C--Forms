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
        public string vala = "val";
        public UserProfile(string val)
        {
            InitializeComponent();
            vala = val;

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            Form1 searchForm = new Form1();
            name.Text = vala;
            gender.Text = searchForm.gender[0];
            country.Text = searchForm.country[0];
            city.Text = searchForm.city[0];
        }
    }
}
