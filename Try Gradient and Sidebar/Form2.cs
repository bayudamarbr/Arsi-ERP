using System;
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

    }
}
