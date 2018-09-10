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
        public int selectedIndex = -1;
        public string[] names = { "Ahsan", "Mohsin", "Zakir", "Hadia" , "Zara" };
        public string[] country = { "Pakistan", "India", "China", "Pakistan", "Afghanistan" };
        public string[] city = { "Karachi", "Mumbai", "Beijing", "Lahore", "Kabul" };
        public string[] gender = { "Male", "Male", "Male", "Female", "Female" };

        public string[] school = { "NED", "Habib", "Beijing University", "KU", "UET" };
        public string[] degree = { "EE", "CS", "Electronics", "Architecture", "Painting" };
        public string[] year = { "2000", "2010", "1997", "1992", "2014" };

        public string[] employer = { "Microsoft", "Apple", "Amazon", "Netflix", "CNN" };
        public string[] jobTitle = { "Front end developer", "IT Expert", "Product Manager", "Technical Head", "Main Host" };

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

            selectCountry.SelectedItem = "Pakistan";
        }

        private void selectCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectCountry.SelectedItem == "Pakistan")
            {
                citySelect.Items.Clear();
                citySelect.Items.Add("Karachi");
                citySelect.Items.Add("Lahore");
                citySelect.Items.Add("Islamabad");
                citySelect.Items.Add("Rawalpindi");
                citySelect.Items.Add("Quetta");
            }
            if (selectCountry.SelectedItem == "China")
            {
                citySelect.Items.Clear(); //comment
                citySelect.Items.Add("Beijing");
                citySelect.Items.Add("Shanghai");
                citySelect.Items.Add("Hong Kong");
            }
            if (selectCountry.SelectedItem == "India")
            {
                citySelect.Items.Clear();
                citySelect.Items.Add("Mumbai");
                citySelect.Items.Add("New Delhi");
                citySelect.Items.Add("Bhopal");
                citySelect.Items.Add("Lucknow");
            }
            if (selectCountry.SelectedItem == "Afghanistan")
            {
                citySelect.Items.Clear();
                citySelect.Items.Add("Kabul");
                citySelect.Items.Add("Kunduz");
                citySelect.Items.Add("Ghazni");
            }
        }

        private void selectCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            //clearing for new search
            searchResult.Items.Clear();

            string genderRadio = "Male";
            if (maleRadio.Checked == true)
            {
                genderRadio = "Male";
            }
            else if (femaleRadio.Checked == true)
            {
                genderRadio = "Female";
            }
            for (int i = 0; i < names.Count(); i++)
            {
                if (((country[i] == selectCountry.SelectedItem) || (selectCountry.SelectedIndex <1))&& ((city[i] == citySelect.SelectedItem) || (citySelect.SelectedIndex < 1)) && (names[i].ToLower().Contains(firstnameTxt.Text.ToLower()) || firstnameTxt.Text.Length == 0) && (genderRadio == gender[i]))
                {
                    searchResult.Items.Add(names[i]);
                }
            }
        }

        private void viewProfileBtn_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < names.Count(); i++)
            {
                if (searchResult.SelectedItem == names[i])
                {
                    selectedIndex = i;
                }
            }

                //searchResult.SelectedItem.ToString()
            if (selectedIndex != -1)
            {
                UserProfile f2 = new UserProfile(selectedIndex);
                f2.ShowDialog(); // Shows Form2
            }
        }
    }

    // You can convert it back to an array if you would like to
    //int[] terms = termsList.ToArray();
}
