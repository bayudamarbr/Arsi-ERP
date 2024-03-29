﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Try_Gradient_and_Sidebar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Mengatur properti UseSystemPasswordChar menjadi true untuk TextBoxPassword
            TextboxPassword.UseSystemPasswordChar = true;
            // Mengaitkan event handler TextBoxPassword_KeyDown dengan event KeyDown dari TextBoxPassword
            TextboxPassword.KeyDown += TextBoxPassword_KeyDown;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = TextboxUsername.Text;
            string password = TextboxPassword.Text;

            // Check if the username and password match the expected values
            if (username == "admin" && password == "admin")
            {
                // Jika berhasil, buka Form3 dan sembunyikan Form2
                Form3 form3 = new Form3(username);
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah. Silakan coba lagi.");
            }
        }

        private void TextBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Panggil fungsi atau metode yang menangani logika masuk
                buttonLogin_Click(sender, e); // Memanggil event handler buttonLogin_Click
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void erpLogo_Click(object sender, EventArgs e)
        {

        }

        private void TextboxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void htaLogo_Click(object sender, EventArgs e)
        {

        }

        private void TextboxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
