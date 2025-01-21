using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstDescktopApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text))
            {
                MessageBox.Show("Username cannot be empty.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_password.Text) || string.IsNullOrWhiteSpace(txt_confirmPassword.Text))
            {
                MessageBox.Show("Password fields cannot be empty.");
                return;
            }
            if (txt_password.Text != txt_confirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            if (num_age.Value < 18)
            {
                MessageBox.Show("You must be at least 18 years old.");
                return;
            }
            if (combo_country.SelectedItem == null)
            {
                MessageBox.Show("Please select a country.");
                return;
            }

            string gender = radio_female.Checked ? radio_female.Text : radio_male.Text;
            string state = combo_country.SelectedItem.ToString();
            MessageBox.Show($"Name: {txt_username.Text}\n" +
                             $"Age: {num_age.Value}\n" +
                             $"Birth Date: {dtp_birthDate.Value.ToShortDateString()}\n" +
                             $"Country: {state}\n" +
                             $"Gender: {gender}\n");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void num_age_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
