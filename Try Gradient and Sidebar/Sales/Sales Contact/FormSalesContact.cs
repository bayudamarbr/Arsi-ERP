using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try_Gradient_and_Sidebar
{
    public partial class FormSalesContact : Form
    {
        FormSalesContactCreate contactCreate;
        public FormSalesContact()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            if (contactCreate == null)
            {
                contactCreate = new FormSalesContactCreate();
                contactCreate.FormClosed += contactCreate_FormClosed;
                contactCreate.MdiParent = this.ParentForm;
                contactCreate.Dock = DockStyle.Fill;
                contactCreate.Show();
            }
            else
            {
                contactCreate.Activate();
            }
        }

        private void contactCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            contactCreate = null;
        }
    }
}
