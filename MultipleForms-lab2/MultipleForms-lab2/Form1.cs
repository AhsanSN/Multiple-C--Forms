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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectCountry.Items.Add("Afghanistan");
            selectCountry.Items.Add("China");
            selectCountry.Items.Add("India");
            selectCountry.Items.Add("Pakistan");
        }

        private void selectCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void selectCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectCountry.SelectedItem == "Afghanistan")
            {
                selectCity.Items.Add("Kabul");
            }
        }
    }
}
